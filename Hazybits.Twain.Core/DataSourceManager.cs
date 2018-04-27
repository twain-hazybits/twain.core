using Hazybits.Twain.Core.TwainStructures;
using System;
using System.Collections.Generic;
using Hazybits.Twain.Core.Implementation.Interfaces;

namespace Hazybits.Twain.Core
{
    public sealed class DataSourceManager : IDisposable
    {
        private readonly Implementation.DataSourceManagerImpl _dataSourceManager = new Implementation.DataSourceManagerImpl();
        private readonly TwIdentity _appIdentity;
        private bool _dsmOpened = false;

        public DataSourceManager(TwIdentity appIdentity)
        {
            _appIdentity = appIdentity;
        }

        public void Dispose()
        {
            CloseDsm();
            _dataSourceManager.Dispose();
        }

        public void OpenDsm(ITwainStructure handle)
        {
            CallDsm(null, DataGroup.Control, DataArgumentType.Parent, Message.OpenDsm, handle);
            _dsmOpened = true;
        }

        public void CloseDsm()
        {
            if (_dsmOpened)
                CallDsm(null, DataGroup.Control, DataArgumentType.Parent, Message.CloseDsm, null);

            _dsmOpened = false;
        }

        public void CallDsm(TwIdentity dest, DataGroup dg, DataArgumentType dat, Message msg, ITwainStructure data)
        {
            _dataSourceManager.CallDsm(_appIdentity, dest, dg, dat, msg, data);
        }

        public ReturnCode CallDsmSafe(TwainStructures.TwIdentity source, TwainStructures.TwIdentity dest, DataGroup dg, DataArgumentType dat, Message msg, ITwainStructure data)
        {
            return _dataSourceManager.CallDsmSafe(source, dest, dg, dat, msg, data);
        }

        public TwIdentity AppIdentity { get { return _appIdentity; } }
    }
}
