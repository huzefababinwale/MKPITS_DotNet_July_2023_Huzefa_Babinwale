using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multiforms_Arrangment
{
    public partial class accountform : Form
    {
        public accountform()
        {
            InitializeComponent();
        }
        StringBuilder sb = new StringBuilder();
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            comboBox2.Items.Clear();
            
            switch (comboBox1.Text)
            {
                case "Diru Bhai Pharma":
                    comboBox2.Text = "Injections";
                    break;
                case "Khan Medic":
                    comboBox2.Text = "Tablet";
                    break;
                case "Dudhnath Pharma":
                    comboBox2.Text = "Capsules";
                    break;
            }
        }
            


    }
}
