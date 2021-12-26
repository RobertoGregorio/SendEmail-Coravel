namespace Enviando_email.Interfaces
{
    public interface IEmailModel
    {
        public string Name { get; set; }

        public string RecipientEmail { get; set; }

        public string SenderEmail { get; set; }

        public string TitleEmail { get; set; }
    }
}

