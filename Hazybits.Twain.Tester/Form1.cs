using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hazybits.Twain.Tester
{
    public partial class Form1 : Form
    {
        private Hazybits.Twain.Core.DataSourceManager _dsm;

        Hazybits.Twain.Core.TwainStructures.TwIdentity _appIdentity = new Hazybits.Twain.Core.TwainStructures.TwIdentity
        {
            Version = new Hazybits.Twain.Core.TwainStructures.TwVersion
            {
                MajorNum = 1,
                MinorNum = 0,
                Info = "Hazybits.Twain.Tester"
            },
            Manufacturer = "Hazybits",
            ProductName = "Hazybits Twain Tester",
            ProductFamily = "Hazybits.Twain.Tester",
            ProtocolMajor = 2,
            ProtocolMinor = 3,
            SupportedGroups = (uint)(Hazybits.Twain.Core.DataGroup.Control | Hazybits.Twain.Core.DataGroup.Image | Hazybits.Twain.Core.DataGroup.DfApp2)
        };

        private Hazybits.Twain.Core.TwainStructures.TwIdentity _dataSource;

        public Form1()
        {
            InitializeComponent();
        }

        private void openDSMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_dsm == null)
            {
                _dsm = new Hazybits.Twain.Core.DataSourceManager(_appIdentity);

                var handleStruct = new Hazybits.Twain.Core.TwainStructures.HandleData { Handle = /*form.Handle*/IntPtr.Zero };
                _dsm.OpenDsm(handleStruct);
            }
        }

        private void closeDSMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_dsm == null) return;

            _dsm.CloseDsm();
            _dsm.Dispose();
            _dsm = null;
        }

        private void openDSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_dsm == null) return;

            _dataSource = new Hazybits.Twain.Core.TwainStructures.TwIdentity();

            try
            {
                _dsm.CallDsm(null, Hazybits.Twain.Core.DataGroup.Control, Hazybits.Twain.Core.DataArgumentType.Identity, Hazybits.Twain.Core.Message.UserSelect/* .GetDefault*/, _dataSource);
                _dsm.CallDsm(null, Hazybits.Twain.Core.DataGroup.Control, Hazybits.Twain.Core.DataArgumentType.Identity, Hazybits.Twain.Core.Message.OpenDs, _dataSource);
            }
            catch (Hazybits.Twain.Core.TwainException ex)
            {
                _dataSource = null;
                var message = string.Format("Failed to open data source. Error: {0}", ex.Message);
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void closeDSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_dsm == null || _dataSource == null) return;

            try
            {
                _dsm.CallDsm(null, Hazybits.Twain.Core.DataGroup.Control, Hazybits.Twain.Core.DataArgumentType.Identity, Hazybits.Twain.Core.Message.CloseDs, _dataSource);
            }
            catch (Hazybits.Twain.Core.TwainException ex)
            {
                var message = string.Format("Failed to close data source. Error: {0}", ex.Message);
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                _dataSource = null;
            }
        }

        private void sendToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_dsm == null || _dataSource == null) return;

            var sendForm = new SendForm(_dsm, _dataSource);
            sendForm.ShowDialog();
        }
    }
}
