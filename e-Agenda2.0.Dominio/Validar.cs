using System.Text.RegularExpressions;

namespace e_Agenda2._0.Dominio
{
    public class Validar
    {
        public bool TelefoneEstaValido(string telefone)
        {
            bool telefoneEstaValido = false;

            string telefoneProcessado = telefone.Replace("-", string.Empty)
                                                .Replace(" ", string.Empty);

            if (telefoneProcessado.Length < 9)
                return telefoneEstaValido;

            telefoneEstaValido = System.Text.RegularExpressions.Regex.IsMatch(telefoneProcessado, @"^[0-9]*$");

            return telefoneEstaValido;
        }

        public bool EmailEstaValido(string email)
        {
            bool emailEstaValido = System.Net.Mail.MailAddress.TryCreate(email, out _);

            return emailEstaValido;
        }

        public bool HorarioEstaValido(string horario)
        {
            bool horarioEstaValido = System.Text.RegularExpressions.Regex.IsMatch(horario, @"^(?:[01]\d|2[0-3]):[0-5]\d$");

            return horarioEstaValido;
        }
    }
}
