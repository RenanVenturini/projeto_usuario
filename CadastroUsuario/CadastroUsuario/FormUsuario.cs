using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

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

            ExcluirUsuario(Convert.ToInt32(textBoxId.Text));
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxId.Text))
                CriarUsuario();
            else
                AtualizarUsuario();
        }

        private void maskedTextBoxCPF_Leave(object sender, EventArgs e)
        {
            var usuario = _usuarioRepository.ObterUsuario(DesformatarCPF(maskedTextBoxCPF.Text));

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

        private void CriarUsuario()
        {
            var usuario = new Usuario();
            usuario.CPF = DesformatarCPF(maskedTextBoxCPF.Text);
            usuario.Nome = textBoxNome.Text;
            usuario.Sexo = comboBoxSexo.Text;
            usuario.DataNascimento = dateTimePickerDataNascimento.Value;
            usuario.Telefone = DesformatarTelefone(maskedTextBoxTelefone.Text);
            usuario.Email = textBoxEmail.Text;
            usuario.Endereco = textBoxEndereco.Text;
            usuario.Numero = textBoxNumero.Text;
            usuario.Complemento = textBoxComplemento.Text;

            if (!ValidarCampos(usuario))
                return;

            _usuarioRepository.CriarUsuario(usuario);
            textBoxId.Text = usuario.Id.ToString();
            MessageBox.Show("Registro salvo com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AtualizarUsuario()
        {
            var usuario = new Usuario();
            usuario.Id = Convert.ToInt32(textBoxId.Text);
            usuario.CPF = DesformatarCPF(maskedTextBoxCPF.Text);
            usuario.Nome = textBoxNome.Text;
            usuario.Sexo = comboBoxSexo.Text;
            usuario.DataNascimento = dateTimePickerDataNascimento.Value;
            usuario.Telefone = DesformatarTelefone(maskedTextBoxTelefone.Text);
            usuario.Email = textBoxEmail.Text;
            usuario.Endereco = textBoxEndereco.Text;
            usuario.Numero = textBoxNumero.Text;
            usuario.Complemento = textBoxComplemento.Text;

            if (!ValidarCampos(usuario))
                return;

            _usuarioRepository.AtualizarUsuario(usuario);
            MessageBox.Show("Registro salvo com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ExcluirUsuario(int id)
        {
            var result = MessageBox.Show("Deseja realmente excluir esse registro?", "Confirmar exclusão", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                _usuarioRepository.ExcluirUsuario(id);
                LimparCampos();
            }
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

        static string DesformatarCPF(string cpf)
        {
            // Remove todos os caracteres não numéricos do CPF
            string cpfDesformatado = Regex.Replace(cpf, "[^0-9]", "");
            return cpfDesformatado;
        }

        static string DesformatarTelefone(string telefone)
        {
            // Remove todos os caracteres não numéricos do CPF
            string telefoneDesformatado = Regex.Replace(telefone, "[^0-9]", "");
            return telefoneDesformatado;
        }

        private bool ValidarCampos(Usuario usuario)
        {
            if (string.IsNullOrEmpty(usuario.CPF))
            {
                MessageBox.Show("O campo CPF é obrigatório.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (usuario.CPF.Length < 11)
            {
                MessageBox.Show("O CPF deve conter 11 digitos.", "CPF Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            var usuarioExistente = _usuarioRepository.ListarUsuario().Any(x => x.CPF == usuario.CPF);

            if (usuarioExistente && string.IsNullOrEmpty(textBoxId.Text))
            {
                MessageBox.Show("CPF já cadastrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }                        

            if (string.IsNullOrEmpty(usuario.Nome))
            {
                MessageBox.Show("O campo nome é obrigatório.", "CPF Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(usuario.Sexo))
            {
                MessageBox.Show("O campo sexo é obrigatório.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (usuario.DataNascimento == null)
            {
                MessageBox.Show("O campo data de Nascimento é obrigatório.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (string.IsNullOrEmpty(usuario.Telefone))
            {
                MessageBox.Show("O campo telefone é obrigatório.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (usuario.Telefone.Length < 11)
            {
                MessageBox.Show("O Telefone deve conter 11 digitos incluindo o DDD.", "Telefone Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(usuario.Email))
            {
                MessageBox.Show("O campo email é obrigatório.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (string.IsNullOrEmpty(usuario.Endereco))
            {
                MessageBox.Show("O campo endereço é obrigatório.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (string.IsNullOrEmpty(usuario.Numero))
            {
                MessageBox.Show("O campo numero é obrigatório.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }
    }
}
