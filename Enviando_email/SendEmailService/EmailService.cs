using Coravel.Mailer.Mail.Interfaces;
using Enviando_email.Mailables;

namespace Enviando_email.SendEmailService
{
    public class EmailService
    {
        private readonly IMailer _Imailer;

        public EmailService(IMailer mailer) => _Imailer = mailer;

        public async void SendEmail(TestMailable testMailble)
        {
                await this._Imailer.SendAsync(testMailble);
        }
    }
}