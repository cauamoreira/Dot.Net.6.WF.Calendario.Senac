﻿namespace Dot.Net._6.WF.Calendario.Senac
{
    partial class FrmTelaLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTelaLogin));
            groupBox1 = new GroupBox();
            btnCancelar = new Button();
            txtSenha = new TextBox();
            btnLogin = new Button();
            txtUsuario = new TextBox();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            menuStrip1 = new MenuStrip();
            cadastroToolStripMenuItem = new ToolStripMenuItem();
            cadastrarUsuárioToolStripMenuItem = new ToolStripMenuItem();
            alterarSenhaToolStripMenuItem = new ToolStripMenuItem();
            consultarUsuáriosToolStripMenuItem = new ToolStripMenuItem();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(txtSenha);
            groupBox1.Controls.Add(btnLogin);
            groupBox1.Controls.Add(txtUsuario);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(menuStrip1);
            groupBox1.Location = new Point(-4, -10);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(774, 475);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(304, 339);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(74, 27);
            btnCancelar.TabIndex = 19;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(304, 300);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(152, 23);
            txtSenha.TabIndex = 1;
            txtSenha.UseSystemPasswordChar = true;
            txtSenha.KeyPress += txtSenha_KeyPress;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(385, 339);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(71, 27);
            btnLogin.TabIndex = 16;
            btnLogin.Text = "Entrar";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += button1_Click_1;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(304, 267);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(152, 23);
            txtUsuario.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(253, 272);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 17;
            label1.Text = "Usuário:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Location = new Point(262, 305);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 18;
            label2.Text = "Senha:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(2, 38);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(766, 446);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastroToolStripMenuItem });
            menuStrip1.Location = new Point(3, 19);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(768, 24);
            menuStrip1.TabIndex = 20;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            cadastroToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastrarUsuárioToolStripMenuItem, alterarSenhaToolStripMenuItem, consultarUsuáriosToolStripMenuItem });
            cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            cadastroToolStripMenuItem.Size = new Size(111, 20);
            cadastroToolStripMenuItem.Text = "Cadastrar usuário";
            // 
            // cadastrarUsuárioToolStripMenuItem
            // 
            cadastrarUsuárioToolStripMenuItem.Name = "cadastrarUsuárioToolStripMenuItem";
            cadastrarUsuárioToolStripMenuItem.Size = new Size(180, 22);
            cadastrarUsuárioToolStripMenuItem.Text = "Cadastro de usuário";
            cadastrarUsuárioToolStripMenuItem.Click += cadastrarUsuárioToolStripMenuItem_Click;
            // 
            // alterarSenhaToolStripMenuItem
            // 
            alterarSenhaToolStripMenuItem.Name = "alterarSenhaToolStripMenuItem";
            alterarSenhaToolStripMenuItem.Size = new Size(180, 22);
            alterarSenhaToolStripMenuItem.Text = "Alterar senha";
            // 
            // consultarUsuáriosToolStripMenuItem
            // 
            consultarUsuáriosToolStripMenuItem.Name = "consultarUsuáriosToolStripMenuItem";
            consultarUsuáriosToolStripMenuItem.Size = new Size(180, 22);
            consultarUsuáriosToolStripMenuItem.Text = "Consultar usuários";
            consultarUsuáriosToolStripMenuItem.Click += consultarUsuáriosToolStripMenuItem_Click;
            // 
            // FrmTelaLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(762, 461);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FrmTelaLogin";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agendamento de Cursos";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtSenha;
        private Button btnLogin;
        private TextBox txtUsuario;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Button btnCancelar;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastroToolStripMenuItem;
        private ToolStripMenuItem cadastrarUsuárioToolStripMenuItem;
        private ToolStripMenuItem alterarSenhaToolStripMenuItem;
        private ToolStripMenuItem consultarUsuáriosToolStripMenuItem;
    }
}