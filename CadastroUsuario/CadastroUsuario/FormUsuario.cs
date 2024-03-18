using System;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CadastroUsuario
{
    public partial class FormUsuario : Form
    {
        private UsuarioRepository _usuarioRepository;
        public FormUsuario()
        {
            InitializeComponent();
            _usuarioRepository = new UsuarioRepository();
            LimparCampos();
        }

        private void buttonNovo_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            textBoxId.Text = string.Empty;
            maskedTextBoxCPF.Text = string.Empty;
            textBoxNome.Text = string.Empty;
            comboBoxSexo.SelectedIndex = -1;
            dateTimePickerDataNascimento.Value = DateTime.Today;
            maskedTextBoxTelefone.Text = string.Empty;
            textBoxEmail.Text = string.Empty;
            textBoxEndereco.Text = string.Empty;
            textBoxNumero.Text = string.Empty;
            textBoxComplemento.Text = string.Empty;
            buttonAnterior.Enabled = false;
            buttonProximo.Enabled = false;
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxId.Text))
                CriarUsuario();
            else
                AtualizarUsuario();
        }

        private void CriarUsuario()
        {
            var usuario = new Usuario();
            usuario.CPF = maskedTextBoxCPF.Text;
            usuario.Nome = textBoxNome.Text;
            usuario.Sexo = comboBoxSexo.Text;
            usuario.DataNascimento = dateTimePickerDataNascimento.Value;
            usuario.Telefone = maskedTextBoxTelefone.Text;
            usuario.Email = textBoxEmail.Text;
            usuario.Endereco = textBoxEndereco.Text;
            usuario.Numero = textBoxNumero.Text;
            usuario.Complemento = textBoxComplemento.Text;

            _usuarioRepository.CriarUsuario(usuario);
            textBoxId.Text = usuario.Id.ToString();
        }

        private void AtualizarUsuario()
        {
            var usuario = new Usuario();
            usuario.Id = Convert.ToInt32(textBoxId.Text);
            usuario.CPF = maskedTextBoxCPF.Text;
            usuario.Nome = textBoxNome.Text;
            usuario.Sexo = comboBoxSexo.Text;
            usuario.DataNascimento = dateTimePickerDataNascimento.Value;
            usuario.Telefone = maskedTextBoxTelefone.Text;
            usuario.Email = textBoxEmail.Text;
            usuario.Endereco = textBoxEndereco.Text;
            usuario.Numero = textBoxNumero.Text;
            usuario.Complemento = textBoxComplemento.Text;

            _usuarioRepository.AtualizarUsuario(usuario);
        }

        private void maskedTextBoxCPF_Leave(object sender, EventArgs e)
        {
            var usuario = _usuarioRepository.ObterUsuario(maskedTextBoxCPF.Text);

            if (usuario == default)
                return;

            CarregarUsuario(usuario);
        }

        private void buttonListaNomesUsuario_Click(object sender, EventArgs e)
        {
            listBoxNomes.Visible = true; // Torna o ComboBox visível
            listBoxNomes.Size = new System.Drawing.Size(400, 132);
            listBoxNomes.Location = new System.Drawing.Point(87, 55);
            CarregarNomes();
        }

        private void CarregarNomes()
        {
            listBoxNomes.Items.Clear();
            listBoxNomes.Items.AddRange(_usuarioRepository.ListarUsuario().Select(x => x.Nome).ToArray());
        }

        private void CarregarUsuario(Usuario usuario)
        {
            textBoxId.Text = usuario.Id.ToString();
            maskedTextBoxCPF.Text = usuario.CPF;
            textBoxNome.Text = usuario.Nome;
            dateTimePickerDataNascimento.Value = usuario.DataNascimento;
            comboBoxSexo.SelectedItem = usuario.Sexo;
            maskedTextBoxTelefone.Text = usuario.Telefone;
            textBoxEmail.Text = usuario.Email;
            textBoxEndereco.Text = usuario.Endereco;
            textBoxNumero.Text = usuario.Numero;
            textBoxComplemento.Text = usuario.Complemento;
            buttonAnterior.Enabled = true;
            buttonProximo.Enabled = true;
        }

        private void listBoxNomes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxNomes.SelectedIndex != -1)
            {
                string nomeSelecionado = listBoxNomes.SelectedItem.ToString();
                var usuario = _usuarioRepository.ObterUsuarioPorNome(nomeSelecionado);
                CarregarUsuario(usuario);
                listBoxNomes.Visible = false;
            }
        }

        private void buttonPrimeiro_Click(object sender, EventArgs e)
        {
            var usuario = _usuarioRepository.ListarUsuario().FirstOrDefault();

            if (usuario == default)
                return;
            CarregarUsuario(usuario);
        }

        private void buttonAnterior_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxId.Text))
                return;

            var usuarios = _usuarioRepository.ListarUsuario()
                .Where(x => x.Id <= Convert.ToInt32(textBoxId.Text));


            var indice = usuarios.Count() - 2;

            var usuario = usuarios.ToArray()[indice < 0 ? 0 : indice];

            if (usuario == default)
                return;
            CarregarUsuario(usuario);
        }

        private void buttonProximo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxId.Text))
                return;

            var usuarios = _usuarioRepository.ListarUsuario()
                .Where(x => x.Id >= Convert.ToInt32(textBoxId.Text));


            var indice = usuarios.Count() == 1 ? 0 : 1;

            var usuario = usuarios.ToArray()[indice];

            if (usuario == default)
                return;
            CarregarUsuario(usuario);
        }

        private void buttonUltimo_Click(object sender, EventArgs e)
        {
            var usuario = _usuarioRepository.ListarUsuario().LastOrDefault();

            if (usuario == default)
                return;
            CarregarUsuario(usuario);
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxId.Text))
                return;

            _usuarioRepository.ExcluirUsuario(Convert.ToInt32(textBoxId.Text));
            LimparCampos();
        }
    }
}
