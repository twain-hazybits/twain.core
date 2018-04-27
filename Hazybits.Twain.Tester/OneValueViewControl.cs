using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hazybits.Twain.Tester
{
    public partial class OneValueViewControl : UserControl
    {
        public OneValueViewControl()
        {
            InitializeComponent();
        }

        public void initItemTypes(Array items, Hazybits.Twain.Core.ItemType selectedType)
        {
            ComboBoxItem<Hazybits.Twain.Core.ItemType> selectedItem = null;
            foreach (var item in items)
            {
                var comboBoxItem = new ComboBoxItem<Hazybits.Twain.Core.ItemType>((Hazybits.Twain.Core.ItemType)item);
                itemTypeComboBox.Items.Add(comboBoxItem);
                if ((Hazybits.Twain.Core.ItemType)item == selectedType)
                    selectedItem = comboBoxItem;
            }

            if (selectedItem != null)
                itemTypeComboBox.SelectedItem = selectedItem;
        }

        public void initValuesList(Type possibleValues)
        {
            foreach (var val in Enum.GetValues(possibleValues))
            {
                valueComboBox.Items.Add(val);
            }
            valueComboBox.SelectedIndex = 0;
        }
    }
}
