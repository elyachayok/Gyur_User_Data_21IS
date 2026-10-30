using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gyur_User_Data_21IS
{
    public partial class FormAutorization : Form
    {
        public FormAutorization()
        {
            InitializeComponent();
        }

        private void FormAutorization_Load(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        public static Users Enter_User;



        private void buttonEnter_Click_1(object sender, EventArgs e)
        {
            Enter_User = null;
            Model1 model1 = new Model1();
            Enter_User = model1.Users.FirstOrDefault(x => x.Login == textBoxLogin.Text && x.Password == textBoxPassword.Text);
            if (Enter_User != null)
            {
                switch (Enter_User.RoleID)
                {
                    case 1:
                        FormManager formManager = new FormManager();
                        formManager.ShowDialog();
                        break;
                    case 2:
                        FormSeller formSeller = new FormSeller();
                        formSeller.ShowDialog();
                        break;
                    case 3:
                        FormDirector formDirector = new FormDirector();
                        formDirector.ShowDialog();
                        break;
                    default: throw new Exception("Роль не найдена!");
                }
            }

        }
    }


}
