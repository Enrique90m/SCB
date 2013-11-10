using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net.Mime;



namespace Biblioteca
{
    public partial class enviarCorreo : Form
    {
        public enviarCorreo()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient();
            SmtpServer.Credentials = new System.Net.NetworkCredential("enrique.19m@gmail.com", "elkike_9");
            SmtpServer.Port = 587;
            SmtpServer.Host = "smtp.gmail.com";
            SmtpServer.EnableSsl = true;

            try
            {
                mail.From = new MailAddress("enrique.19m@gmail.com", "FALLA SISTEMA CONTROL BIBLIOTECARIO", System.Text.Encoding.UTF8);
                mail.To.Add("enrique_90m@hotmail.com");
                mail.Subject = "";
                mail.Body = "";
                string algo = "";
                algo = txtDescripcion.Text;
                mail.Body = algo;
                //if (textBox2.Text != "")
                //{
                //    LinkedResource logo = new LinkedResource(textBox2.Text);
                //    logo.ContentId = "Logo";
                //    string htmlview;
                //    htmlview = "<html><body><table border=2><tr width=100%><td><img src=cid:Logo alt=companyname /></td><td></td></tr></table><hr/></body></html>";
                //    AlternateView alternateView1 = AlternateView.CreateAlternateViewFromString(htmlview + "", null, MediaTypeNames.Text.Html);
                //    alternateView1.LinkedResources.Add(logo);
                //    mail.AlternateViews.Add(alternateView1);
                //}
                mail.IsBodyHtml = true;
                mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
                //mail.ReplyTo = new MailAddress(TextBox1.Text);
                // SmtpServer.Send(mail);
                //mail.ReplyTo = new MailAddress(TextBox1.Text);
                SmtpServer.Send(mail);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo enviar correo electronico , le presentamos algunas sugerencias y probables motivos de falla :\n \n-Verifique que tenga conexion a internet \n-Actualize el certificado de la pagina ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Correo enviado correctamente!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
