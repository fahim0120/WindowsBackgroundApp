using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomAlertBoxDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Alert(string title, string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(title, msg, type);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Alert("Your computer health 3 * out of 5 *", 
                "Updating can make the health 5*. Restart Required.", 
                Form_Alert.enmType.Success);
        }
    }
}
