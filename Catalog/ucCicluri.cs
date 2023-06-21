using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catalog
{
    public partial class ucCicluri : UserControl
    {
        public ucCicluri()
        {
            InitializeComponent();
        }
        public String StrF()
        {
            return tbF.Text;
        }
        public String StrA()
        {
            return tbA.Text;
        }
        public String StrAn()
        {
            return tbAn.Text;
        }
    }
}
