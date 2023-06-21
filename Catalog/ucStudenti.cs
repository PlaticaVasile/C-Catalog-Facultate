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
    public partial class ucStudenti : UserControl
    {
        public ucStudenti()
        {
            InitializeComponent();
        }

        public String strNume()
        {
            return nume.Text;
        }
        public String strPrenume()
        {
            return prenume.Text;
        }
        public String strFacultate()
        {
            return facultate.Text;
        }
        public String strSpecializare()
        {
            return specializare.Text;
        }

    }
}
