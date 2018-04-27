using System;
using System.Collections.Generic;
using Hazybits.Twain.Core.Implementation.Interfaces;

namespace Hazybits.Twain.Core.Implementation
{
    internal class DataSourceManagerImpl : IDisposable
    {
        private readonly TwainWrapper _wrapper;

        public DataSourceManagerImpl()
        {
            _wrapper = new TwainWrapper();
        }

        public ReturnCode CallDsmSafe(TwainStructures.TwIdentity source, TwainStructures.TwIdentity dest, DataGroup dg, DataArgumentType dat, Message msg, ITwainStructure data)
        {
            return (ReturnCode) _wrapper.Dsm_Entry(
                source,
                dest, 
                (uint) dg, 
                (ushort) dat,
                (ushort) msg, 
                data);
        }

        public void CallDsm(TwainStructures.TwIdentity source, TwainStructures.TwIdentity dest, DataGroup dg, DataArgumentType dat, Message msg, ITwainStructure data)
        {
            var res = CallDsmSafe(source, dest, dg, dat, msg, data);
            if (res != ReturnCode.Success)
            {
                var status = new TwainStructures.TwStatus();
                CallDsmSafe(source, null, DataGroup.Control, DataArgumentType.Status, Message.Get, status);
                throw new TwainDsmException(res, status.ConditionCode);
            }
        }

        public void Dispose()
        {
            _wrapper.Dispose();
        }
    }
}
