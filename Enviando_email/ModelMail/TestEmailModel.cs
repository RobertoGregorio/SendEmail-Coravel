using Enviando_email.Interfaces;

namespace Enviando_email.ModelMail
{
    public class TestEmailModel : IEmailModel
    {
        public string RecipientEmail { get; set; }
        public string SenderEmail { get; set; }
        public string TitleEmail { get; set; }
        public string Name { get; set; }

        public TestEmailModel(string recipientEmail, string senderEmail, string titleEmail, string name)
        {
            RecipientEmail = recipientEmail ; 
            SenderEmail = senderEmail;
            TitleEmail = titleEmail;
            Name = name;
        }
    }
}