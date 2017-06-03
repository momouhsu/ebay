using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ebay
{
    public partial class FrmXml : Form
    {
        public FrmXml(string xml)
        {
            InitializeComponent();
            this.TxtXml.Text = xml;
        }
    }
}
