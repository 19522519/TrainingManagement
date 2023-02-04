using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrainingManagement.Controller;

namespace TrainingManagement
{
    public partial class ForgotPassword : Form
    {
        string randomcode;
        public static string to;
        UserController userController = new UserController(); 

        public ForgotPassword()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnSendCode_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
                MessageBox.Show("Please enter username!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                users user = userController.getUserByUsername(txtUsername.Text);
                if (user != null)
                {
                    // MessageBox.Show(user.email);
                    string from, pass, messageBody;
                    Random random = new Random();
                    randomcode = (random.Next(100000, 999999)).ToString();
                    MailMessage message = new MailMessage();
                    to = user.email;
                    from = "2nd.doan.uit@gmail.com";
                    pass = "hrniatyeabjrvpwe";
                    messageBody = "Your reset account code:" + randomcode;
                    message.To.Add(to);
                    message.From = new MailAddress(from);
                    message.Body = messageBody;
                    message.Subject = "Password reseting code";
                    SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                    smtp.EnableSsl = true;
                    smtp.Port = 587;
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.Credentials = new NetworkCredential(from, pass);
                    try
                    {
                        smtp.Send(message);
                        MessageBox.Show("Code sent successfully!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                    MessageBox.Show("Username not register account!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Close();
        }

        private void btnCheckCode_Click(object sender, EventArgs e)
        {
            if (randomcode == (txtCode.Text).ToString())
            {
                users user = userController.getUserByUsername(txtUsername.Text);
                ChangePasswordForm changePasswordForm = new ChangePasswordForm(user.id);
                this.Close();
                changePasswordForm.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Wrong reset code", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
