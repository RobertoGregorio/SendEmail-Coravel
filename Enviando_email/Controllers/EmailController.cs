using Coravel.Mailer.Mail.Interfaces;
using Enviando_email.Interfaces;
using Enviando_email.Mailables;
using Enviando_email.ModelMail;
using Enviando_email.SendEmailService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Enviando_email.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmailController : ControllerBase
    {
        private IMailer _mailer;

        public EmailController(IMailer mailer) =>
            _mailer = mailer;

        [HttpPost]
        public IActionResult SendEmail(JsonEmail jsonEmail)
        {
            try
            {
                IEmailModel EmailModel = new TestEmailModel
                    (
                       jsonEmail.SenderEmail,
                       jsonEmail.RecipientEmail,
                       jsonEmail.TitleEmail,
                       jsonEmail.Name
                    );

                TestMailable testMailable = new TestMailable(EmailModel);

                new EmailService(_mailer).SendEmail(testMailable);

                return new JsonResult(new { Success = true, message = "email enviado" });
            }
            catch (Exception ex)
            {
                return new JsonResult(new { Success = true, message = ex.Message });
            }
        }
    }
}