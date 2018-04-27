using Hazybits.Twain.Tester.ResultProcessing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hazybits.Twain.Core;

namespace Hazybits.Twain.Tester
{
    public partial class SendForm : Form
    {
        private DataSourceManager _dsm;
        private Hazybits.Twain.Core.TwainStructures.TwIdentity _source;

        public SendForm(DataSourceManager dsm, Hazybits.Twain.Core.TwainStructures.TwIdentity source)
        {
            _dsm = dsm;
            _source = source;

            InitForm();
        }

        private void InitForm()
        {
            InitializeComponent();

            oneValueViewControl1.initItemTypes(Enum.GetValues(typeof(Hazybits.Twain.Core.ItemType)), ItemType.Bool);

            comboBox_Capability.Items.Clear();
            foreach (var capValue in Capabilities.Values)
            {
                comboBox_Capability.Items.Add(capValue);
            }
            comboBox_Capability.Enabled = false;
            comboBox_Capability.SelectedIndex = 0;

            comboBox_Dest.Items.Add(new ComboBoxItem<Destination>(Destination.Source));
            comboBox_Dest.Items.Add(new ComboBoxItem<Destination>(Destination.SourceManager));
            comboBox_Dest.SelectedIndex = 0;
            OnDestChanged(this, EventArgs.Empty);
        }

        private enum Destination {
            Source,
            SourceManager
        };

        private readonly IList<TripletChoice> _sourceManagerTriplets = new List<TripletChoice>
        {
            new TripletChoice(HandleDsmIdentityTriplets, DsmTriplets.ControlIdentity),
            new TripletChoice(HandleDsmParentTriplets, DsmTriplets.ControlParent),
            new TripletChoice(HandleDsmStatusTriplets, DsmTriplets.ControlStatus)
        };

        private readonly IList<TripletChoice> _sourceTriplets = new List<TripletChoice>
        {
            new TripletChoice( HandleDsCapabilityTriplets, DataSourceTriplets.ControlCapability)
        };

        #region DSM Triplets handlers

        private static string HandleDsmIdentityTriplets(TripletHandlerParams handlerParams)
        {
            switch (handlerParams.MSG)
            {
                case Hazybits.Twain.Core.Message.CloseDs:
                case Hazybits.Twain.Core.Message.Get:
                case Hazybits.Twain.Core.Message.OpenDs:
                case Hazybits.Twain.Core.Message.UserSelect:
                    throw new AppException("Not supported from Specials menu.");
            }

            var identity = new Hazybits.Twain.Core.TwainStructures.TwIdentity();
            handlerParams.DSM.CallDsm(null, handlerParams.DG, handlerParams.DAT, handlerParams.MSG, identity);

            return identity.ToFormattedString();
        }

        private static string HandleDsmParentTriplets(TripletHandlerParams handlerParams)
        {
            throw new AppException("Not supported from Specials menu.");
        }

        private static string HandleDsmStatusTriplets(TripletHandlerParams handlerParams)
        {
            var status = new Hazybits.Twain.Core.TwainStructures.TwStatus();
            handlerParams.DSM.CallDsm(null, handlerParams.DG, handlerParams.DAT, handlerParams.MSG, status);

            return status.ToFormattedString();
        }

        #endregion

        #region Data Source Triplets handlers

        private static string DumpCapabilityContainer(Hazybits.Twain.Core.TwainStructures.TwCapability capability)
        {
            switch (capability.ContainerType)
            {
                case ContainerType.Enumeration:
                    {
                        var twEnumeration = capability.GetTwEnumeration();
                        var str = new StringBuilder(twEnumeration.ToFormattedString());
                        str.AppendTwEnumerationItems(capability.Capability, twEnumeration);

                        return str.ToString();
                    }

                case ContainerType.OneValue:
                    {
                        var twOneValue = capability.GetOneValue();
                        var str = new StringBuilder(twOneValue.ToFormattedString());
                        str.AppendLine();
                        str.Append("Value: ");
                        str.AppendTwOneValueItem(capability.Capability, twOneValue);

                        return str.ToString();
                    }
            }

            throw new NotImplementedException("We cannot dump capability container of this type.");

            return capability.ToFormattedString();
        }

        private static string DumpQuerySupportValues(Hazybits.Twain.Core.TwainStructures.TwCapability twCapability)
        {
            if (twCapability.ContainerType == ContainerType.OneValue)
            {
                var twOneValue = twCapability.GetOneValue();
                var str = new StringBuilder(twOneValue.ToFormattedString());
                str.AppendLine();
                str.Append("Value: ");
                str.AppendTwOneValueFlagItem(twOneValue, typeof(Hazybits.Twain.Core.Constants.TwQC));

                return str.ToString();
            }

            throw new NotImplementedException("We cannot dump <QuerySupport> values of this type.");
        }

        private static string HandleDsCapabilityTriplets(TripletHandlerParams handlerParams)
        {
            if (handlerParams.Capability == null)
                throw new NotImplementedException("This is not implemented yet.");

            handlerParams.DSM.CallDsm(handlerParams.DataSource, handlerParams.DG, handlerParams.DAT, handlerParams.MSG, handlerParams.Capability);

            if (handlerParams.MSG == Hazybits.Twain.Core.Message.Get)
            {
                return DumpCapabilityContainer(handlerParams.Capability);
            } else if (handlerParams.MSG == Hazybits.Twain.Core.Message.QuerySupport)
            {
                return DumpQuerySupportValues(handlerParams.Capability);
            }

            return DumpCapabilityContainer(handlerParams.Capability);

            //todo: implement Hazybits.Twain.Core.Message.SetConstraint
            return string.Empty;
        }

        #endregion

        public SendForm()
        {
            InitForm();
        }

        private bool IsSourceDestSelected()
        {
            return ((comboBox_Dest.SelectedItem as ComboBoxItem<Destination>).Data == Destination.Source);
        }

        private void OnDestChanged(object sender, EventArgs e)
        {
            comboBox_DG.Items.Clear();
            comboBox_DG.SelectedIndex = -1;

            var items = new List<ComboBoxItem<DataGroup>>();
            var triplets = IsSourceDestSelected() ? _sourceTriplets : _sourceManagerTriplets;
            foreach (var triplet in triplets)
            {
                if (items.FirstOrDefault((t) => { return t.Data == triplet.ChoiceInfo.DG; }) == null)
                    items.Add(new ComboBoxItem<DataGroup>(triplet.ChoiceInfo.DG));
            }

            comboBox_DG.Items.AddRange(items.ToArray());

            comboBox_DG.SelectedIndex = 0;
        }

        private void OnDgChanged(object sender, EventArgs e)
        {
            comboBox_DAT.Items.Clear();
            comboBox_DAT.SelectedIndex = -1;

            var triplets = IsSourceDestSelected() ? _sourceTriplets : _sourceManagerTriplets;
            var dataTypes = new List<ComboBoxItem<DataArgumentType>>();
            foreach (var triplet in triplets)
            {
                if (dataTypes.FirstOrDefault((t) => { return t.Data == triplet.ChoiceInfo.DAT; }) == null)
                    dataTypes.Add(new ComboBoxItem<DataArgumentType>(triplet.ChoiceInfo.DAT));
            }

            comboBox_DAT.Items.AddRange(dataTypes.ToArray());

            comboBox_DAT.SelectedIndex = 0;
        }

        private void OnDatChanged(object sender, EventArgs e)
        {
            comboBox_MSG.Items.Clear();
            comboBox_MSG.SelectedIndex = -1;

            var triplets = IsSourceDestSelected() ? _sourceTriplets : _sourceManagerTriplets;

            var triplet = triplets.FirstOrDefault((t) => 
            {
                return t.ChoiceInfo.DG == ((ComboBoxItem<DataGroup>)comboBox_DG.SelectedItem).Data && t.ChoiceInfo.DAT == ((ComboBoxItem<DataArgumentType>)comboBox_DAT.SelectedItem).Data;
            });

            if (triplet != null)
            {
                foreach (var msg in triplet.ChoiceInfo.MSGs)
                {
                    comboBox_MSG.Items.Add(new ComboBoxItem<Hazybits.Twain.Core.Message>(msg));
                }

                comboBox_Capability.Enabled = (triplet.ChoiceInfo.DAT == DataArgumentType.Capability);
            }

            comboBox_MSG.SelectedIndex = 0;
        }

        private void OnMsgChanged(object sender, EventArgs e)
        {
            var resultViewControlEnabled = false;
            var oneValueViewControlEnabled = false;

            var msg = ((ComboBoxItem<Hazybits.Twain.Core.Message>)comboBox_MSG.SelectedItem).Data;
            if (msg != Hazybits.Twain.Core.Message.Set)
            {
                resultViewControlEnabled = true;
            } else
            {

                //if (comboBox_Container)
                oneValueViewControlEnabled = true;
            }

            resultViewControl1.Visible = resultViewControlEnabled;
            oneValueViewControl1.Visible = oneValueViewControlEnabled;
        }

        private void OnCapabilityChanged(object sender, EventArgs e)
        {
            var capValue = comboBox_Capability.SelectedItem as CapabilityValue;
            if (capValue == null) return;
            oneValueViewControl1.initValuesList(capValue.PissibleValues);
        }

        private void OnContainerChanged(object sender, EventArgs e)
        {
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            var isSourceManager = comboBox_Dest.SelectedIndex == 1;
            var dg = (comboBox_DG.SelectedItem as ComboBoxItem<DataGroup>).Data;
            var dat = (comboBox_DAT.SelectedItem as ComboBoxItem<DataArgumentType>).Data;
            var msg = (comboBox_MSG.SelectedItem as ComboBoxItem<Hazybits.Twain.Core.Message>).Data;

            Hazybits.Twain.Core.Implementation.Interfaces.ITwainStructure data = null;

            Hazybits.Twain.Core.TwainStructures.TwIdentity dest = isSourceManager ? null : _source;

            try
            {
                var triplets = isSourceManager ? _sourceManagerTriplets : _sourceTriplets;
                var triplet = triplets.FirstOrDefault((t) => { return t.ChoiceInfo.DG == dg && t.ChoiceInfo.DAT == dat; });
                if (triplet != null)
                {
                    var handlerParams = new TripletHandlerParams
                    {
                        DG = dg,
                        DAT = dat,
                        MSG = msg,
                        DSM = _dsm,
                        DataSource = _source
                    };

                    if (!isSourceManager && dg == DataGroup.Control && dat == DataArgumentType.Capability)
                    {
                        var capability = new Hazybits.Twain.Core.TwainStructures.TwCapability();
                        capability.Capability = Capability.Compression;

                        if (msg != Hazybits.Twain.Core.Message.Get)
                        {
                            // todo: set capability value and type
                        }

                        handlerParams.Capability = capability;
                    }

                    var resultStr = triplet.HandleTripletDelegate(handlerParams);
                    textBox_Returned.Text = Hazybits.Twain.Core.ReturnCode.Success.ToString();

                    resultViewControl1.SetResultInfo(resultStr);
                }
                else
                    throw new NotImplementedException();

                //_dsm.CallDsm(dest, dg, dat, msg, data);
            } catch (AppException ex)
            {
                textBox_Returned.Text = "TWRC_FAILURE -- TWCC_SUCCESS";
                MessageBox.Show(ex.Message, string.Format("{0}/{1}", dat, msg), MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (TwainException ex)
            {
                resultViewControl1.SetResultInfo(ex.Message);
            }
            catch (Exception ex)
            {
                resultViewControl1.SetResultInfo(ex.Message);
            }
        }
    }
}
