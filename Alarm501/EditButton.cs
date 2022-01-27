using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alarm501
{
    public partial class EditButton : Form
    {
        public EditButton()
        {
            InitializeComponent();
        }

        private void uxTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void EditButton_Load(object sender, EventArgs e)
        {

        }

        private void uxCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
