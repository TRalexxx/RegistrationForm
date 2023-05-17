using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistrationForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ChangeLocals(string lang)
        {
            ComponentResourceManager manager = new ComponentResourceManager(typeof(Form1));            
            CultureInfo cultureInfo = new CultureInfo(lang);

            foreach (Control item in this.Controls)
            {
                manager.ApplyResources(item, item.Name, cultureInfo);

                foreach (Control innerItem in item.Controls)
                {
                    manager.ApplyResources(innerItem, innerItem.Name, cultureInfo);
                }

            }
        }


        private void enBtn_Click(object sender, EventArgs e)
        {
            ChangeLocals("en-US");
        }

        private void geBtn_Click(object sender, EventArgs e)
        {
            ChangeLocals("de-DE");
        }

        private void ruBtn_Click(object sender, EventArgs e)
        {
            ChangeLocals("ru-RU");
        }

        private void ukrBtn_Click(object sender, EventArgs e)
        {
            ChangeLocals("uk-UA");
        }
    }
}
