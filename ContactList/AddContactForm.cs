using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactList
{
    public partial class AddContactForm : Form
    {
        public AddContactForm()
        {
            InitializeComponent();
        }

        private void AddContactForm_Load(object sender, EventArgs e)
        {
            Label lblInfo = new Label();
            lblInfo.Text = "Thông tin bổ sung";
            lblInfo.Location = new Point(10,100 );
            this.Controls.Add( lblInfo );
        }
    }
}
