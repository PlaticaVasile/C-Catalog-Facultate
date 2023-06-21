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
    public partial class ucCassete : UserControl
    {
        private Image img;
        private String title;
        public ucCassete()
        {
            InitializeComponent();
        }

        public Image Img
        {
            get { return img; }
            set { img = value; pcbRight.Image = value; }
        }
        public String Title
        {
            get { return title; }
            set { title = value; lblLeft.Text = value; }
        }
    }
}
