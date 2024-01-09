using Aplication.Shared.Behavior;
using Microsoft.Extensions.DependencyInjection;
using System.Text;
using static Aplication.Shared.Behavior.UserService;
using static Aplication.Shared.Behavior.ValidationBehavior;

namespace WinForm
{
    public partial class Form1 : Form
    {
        private string valorCheckBox;
        private IServiceProvider _provider;
        public Form1(IServiceProvider provider)
        {
            InitializeComponent();
            _provider = provider;
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var validate = _provider.GetRequiredService<IValidateData>();
            var user = _provider.GetRequiredService<IUserService>();

            var motorista = validate.ValidateData(textNome.Text, textCodmot.Text, textCodpad.Text, textCodfil.Text, textCodmun.Text, valorCheckBox);

            if (motorista != null)
            {
                user.SalvarUsuario(motorista);
                textBox1.Text = "Registrado com sucesso!";
            }
            else
            {
                var validator = new ValidationBehavior.UsuarioValidator();
                var results = validator.Validate(motorista);

                if (!results.IsValid)
                {
                    StringBuilder errorMessage = new StringBuilder();
                    foreach (var failure in results.Errors)
                    {
                        errorMessage.AppendLine($"Propriedade: {failure.PropertyName}, Erro: {failure.ErrorMessage}");
                    }

                    textBox1.Text = errorMessage.ToString();
                }
                else
                {
                    textBox1.Text = "Ocorreu um erro ao validar os dados.";
                }
            }
        }

        private void LabelCodmot_Click(object sender, EventArgs e)
        {

        }

        private void textCodmun_TextChanged(object sender, EventArgs e)
        {

        }

        private void textCodfil_TextChanged(object sender, EventArgs e)
        {

        }

        private void textVeicfix_TextChanged(object sender, EventArgs e)
        {

        }

        private void textCodpad_TextChanged(object sender, EventArgs e)
        {

        }

        private void textCodmot_TextChanged(object sender, EventArgs e)
        {

        }

        private void textNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;

            if (checkBox != null)
            {
                valorCheckBox = checkBox.Checked ? "S" : "N";
            }
        }
    }
}