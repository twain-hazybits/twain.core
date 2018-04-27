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
    public partial class ResultViewControl : UserControl
    {
        public ResultViewControl()
        {
            InitializeComponent();
        }

        public void SetResultInfo(string info)
        {
            textBox_Structure.Text = info;
        }
    }
}
