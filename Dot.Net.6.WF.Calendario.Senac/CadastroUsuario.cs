﻿using DocumentFormat.OpenXml.Packaging;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dot.Net._6.WF.Calendario.Senac
{
    public partial class CadastroUsuario : Form
    {
        
        public CadastroUsuario()
        {
            InitializeComponent();
           
        }

        private void btnSalvarUsuario_Click(object sender, EventArgs e)
        {
            string nomeUsuarioNovo = txtNomeLogin.Text;
            string senhaNovo = txtSenha.Text;

            using (var bd = new BancoDeDados())
            {

                var usuarioExistente = bd.Usuarios.FirstOrDefault(u => u.Login == nomeUsuarioNovo);

                if (usuarioExistente != null)
                {
                    MessageBox.Show("Nome de usuário já existe. Escolha outro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

                else
                {
                    var novoUsuario = new Usuario()
                    {

                        Login = nomeUsuarioNovo,
                        
                        Senha = senhaNovo,
                       
                        Ativo = true,


                    };

                    bd.Usuarios.Add(novoUsuario);
                    bd.SaveChanges();
                    MessageBox.Show("Usuário criado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                  

                    Listar();
                }

            }
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                btnSalvarUsuario_Click(this, new EventArgs());
            }
        }



        private void LimparCampos()
        {
            txtNomeLogin.Clear();
            txtNomeCompleto.Clear();
            txtEmail.Clear();
            txtSenha.Clear();
            chkAdministrador.Checked = false;
            chkAtivo.Checked = false;
        }

        private void FrmCadastroUsuario_Load(object sender, EventArgs e)
        {
            Listar();

        }


        private void Listar()
        {
            GridConsultarUsuario.Rows.Clear();

            using (var bd = new BancoDeDados())
            {
                var usuarios = bd.Usuarios.ToList();

                foreach (var usuario in usuarios)
                {
                    GridConsultarUsuario.Rows.Add(
                        usuario.Id,
                        usuario.Login,
                        usuario.Nome,
                        usuario.Email,
                        usuario.Senha,
                        usuario.Administrador,
                        usuario.Ativo);

                }

            }

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            using (var bd = new BancoDeDados())
            {
                var usuario = bd.Usuarios.Where(w => w.Id == Convert.ToInt32(txtId.Text)).First();
                usuario.Login = txtNomeLogin.Text;
                usuario.Nome = txtNomeCompleto.Text;
                usuario.Email = txtEmail.Text;
                usuario.Senha = txtSenha.Text;
                usuario.Administrador = chkAdministrador.Checked;
                usuario.Ativo = chkAtivo.Checked;

                bd.SaveChanges();

                MessageBox.Show("Deseja alterar?", "Cadastro de Usuário", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                Listar();
                LimparCampos();
            }
        }


        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Deve selecionar o usuário que deseja excluir.");


            }
            else
            {
                DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    using (var bd = new BancoDeDados())
                    {
                        try
                        {
                            var usuario = bd.Usuarios.FirstOrDefault(w => w.Id == Convert.ToInt32(txtId.Text));

                            if (usuario != null)
                            {
                                bd.Usuarios.Remove(usuario);
                                bd.SaveChanges();
                                Listar();
                                LimparCampos();
                            }
                            else
                            {
                                MessageBox.Show("Usuário não encontrado. Verifique o usuário informado.");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Erro ao excluir: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void GridConsultarUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = GridConsultarUsuario.CurrentRow.Cells[0].Value.ToString();
            txtNomeLogin.Text = GridConsultarUsuario.CurrentRow.Cells[1].Value.ToString();
            txtNomeCompleto.Text = GridConsultarUsuario.CurrentRow.Cells[2].Value.ToString();
            txtEmail.Text = GridConsultarUsuario.CurrentRow.Cells[3].Value.ToString();
            txtSenha.Text = GridConsultarUsuario.CurrentRow.Cells[4].Value.ToString();
            chkAdministrador.Checked = (bool)GridConsultarUsuario.CurrentRow.Cells[5].Value;
            chkAtivo.Checked = (bool)GridConsultarUsuario.CurrentRow.Cells[6].Value;
        }

        private void AbrirFormAgendaCurso()
        {
            Agenda_de_Curso agenda_De_Curso = new Agenda_de_Curso();
            agenda_De_Curso.Show();
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult iSair;
            iSair = MessageBox.Show("Tem certeza que deseja sair?",
                "Cadastro de Usuário",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (iSair == DialogResult.Yes)
            {
                AbrirFormAgendaCurso();
                this.Close();

            }
        }

        private void GridConsultarUsuario_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            List<int> colunaBoolIndex = new List<int> { 5, 6 };

            if (e.RowIndex >= 0 && colunaBoolIndex.Contains(e.ColumnIndex))

            {
                if (e.Value != null && e.Value is bool)
                {
                    bool valorBool = (bool)e.Value;
                    e.Value = valorBool ? "Sim" : "Não";
                    e.FormattingApplied = true;
                }
            }
        }
    }
}














