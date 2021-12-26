using Coravel.Mailer.Mail;
using Enviando_email.Interfaces;

namespace Enviando_email.Mailables
{
    public class TestMailable : Mailable<string>
    {
        private IEmailModel _TestMailModel;

        public TestMailable(IEmailModel newUserMailModel) => this._TestMailModel = newUserMailModel;

        //monta email
        public override void Build()
        {
            this.To(_TestMailModel.RecipientEmail)
                .From(new MailRecipient(_TestMailModel.SenderEmail, _TestMailModel.Name))
                .Html("Lorem ipsum dolor sit amet. Hic repudiandae eius sit adipisci nostrum et rerum fugiat sit internos alias. Aut minima quasi sed culpa cumque in laudantium rerum.");
        }
    }
}