using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelProject1._0
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
            comboBox1.Items.Add(Users.Admin);
            comboBox1.Items.Add(Users.Client);
            textBoxPassword.PasswordChar = '*';
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            User user = new User
               {
               Name = textBoxName.Text,
               LastName = textBoxLastName.Text,
               Birthday  = textBoxBD.Text != string.Empty ? 
                        DateTime.Parse(textBoxBD.Text) : new DateTime(1900, 1, 1),
               Money = 0,
               UserType = comboBox1.Text,
               Login = textBoxLogin.Text,
               Password = textBoxPassword.Text,
            };
            SaveInfo s = SaveInfo.GetInstance();
            s.SaveUser(user);
            this.Close();
        }

    }
}
