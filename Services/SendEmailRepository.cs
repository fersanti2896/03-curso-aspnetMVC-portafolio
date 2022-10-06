using Portafolio.Models;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace Portafolio.Services {
    public interface ISendEmail {
        Task Enviar(ContactoModel contacto);
    }

    public class SendEmailRepository : ISendEmail {
        private readonly  IConfiguration configuration;

        public SendEmailRepository(IConfiguration configuration) {
            this.configuration = configuration;
        }

        public async Task Enviar(ContactoModel contacto) {
            var apiKey = configuration.GetValue<string>("SENDGRID_APIKEY");
            var email = configuration.GetValue<string>("SENDGRID_FROM");
            var nombre = configuration.GetValue<string>("SENDGRID_NOMBRE");

            var cliente = new SendGridClient(apiKey);
            var from = new EmailAddress(email, nombre);
            var subject = $"El cliente { contacto.Email } quiere contactarte.";
            var to = new EmailAddress(email, nombre);
            var msg = contacto.Mensaje;
            var contenido = @$"De: { contacto.Nombre }
                               Email: { contacto.Email }
                               Mensaje: { contacto.Mensaje }";
            var singleEmail = MailHelper.CreateSingleEmail(from, to, subject, msg, contenido);

            var respuesta = await cliente.SendEmailAsync(singleEmail);
        }
    }
}
