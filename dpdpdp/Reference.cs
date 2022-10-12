using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dpdpdp
{
    public partial class Reference : Form
    {
        public Reference()
        {
            InitializeComponent();
            rtb.LoadFile(Directory.GetCurrentDirectory() + @"\source\Руководство.rtf");
        }
    }
}
