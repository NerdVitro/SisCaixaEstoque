namespace SisCaixaEstoque
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            PnlPrincipal = new Panel();
            PnlImagem = new Panel();
            pictureBox1 = new PictureBox();
            PnlLateral = new Panel();
            BtnSair = new Button();
            panel2 = new Panel();
            panel1 = new Panel();
            ChbLembrarUsuario = new CheckBox();
            LklEsqueceuSenha = new LinkLabel();
            label1 = new Label();
            TxbSenha = new TextBox();
            TxbLogin = new TextBox();
            BtnEntrar = new Button();
            PnlPrincipal.SuspendLayout();
            PnlImagem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            PnlLateral.SuspendLayout();
            SuspendLayout();
            // 
            // PnlPrincipal
            // 
            PnlPrincipal.Controls.Add(PnlImagem);
            PnlPrincipal.Controls.Add(PnlLateral);
            PnlPrincipal.Dock = DockStyle.Fill;
            PnlPrincipal.Location = new Point(0, 0);
            PnlPrincipal.Name = "PnlPrincipal";
            PnlPrincipal.Size = new Size(700, 350);
            PnlPrincipal.TabIndex = 0;
            // 
            // PnlImagem
            // 
            PnlImagem.Controls.Add(pictureBox1);
            PnlImagem.Dock = DockStyle.Fill;
            PnlImagem.Location = new Point(350, 0);
            PnlImagem.Name = "PnlImagem";
            PnlImagem.Size = new Size(350, 350);
            PnlImagem.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(350, 350);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // PnlLateral
            // 
            PnlLateral.BackColor = Color.White;
            PnlLateral.Controls.Add(BtnSair);
            PnlLateral.Controls.Add(panel2);
            PnlLateral.Controls.Add(panel1);
            PnlLateral.Controls.Add(ChbLembrarUsuario);
            PnlLateral.Controls.Add(LklEsqueceuSenha);
            PnlLateral.Controls.Add(label1);
            PnlLateral.Controls.Add(TxbSenha);
            PnlLateral.Controls.Add(TxbLogin);
            PnlLateral.Controls.Add(BtnEntrar);
            PnlLateral.Dock = DockStyle.Left;
            PnlLateral.Location = new Point(0, 0);
            PnlLateral.Name = "PnlLateral";
            PnlLateral.Size = new Size(350, 350);
            PnlLateral.TabIndex = 0;
            // 
            // BtnSair
            // 
            BtnSair.BackColor = Color.Transparent;
            BtnSair.FlatStyle = FlatStyle.Flat;
            BtnSair.Image = (Image)resources.GetObject("BtnSair.Image");
            BtnSair.Location = new Point(114, 243);
            BtnSair.Name = "BtnSair";
            BtnSair.Size = new Size(50, 50);
            BtnSair.TabIndex = 9;
            BtnSair.UseVisualStyleBackColor = false;
            BtnSair.Click += BtnSair_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(42, 132);
            panel2.Name = "panel2";
            panel2.Size = new Size(261, 1);
            panel2.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(42, 185);
            panel1.Name = "panel1";
            panel1.Size = new Size(261, 1);
            panel1.TabIndex = 7;
            // 
            // ChbLembrarUsuario
            // 
            ChbLembrarUsuario.AutoSize = true;
            ChbLembrarUsuario.BackColor = Color.Transparent;
            ChbLembrarUsuario.Location = new Point(42, 208);
            ChbLembrarUsuario.Name = "ChbLembrarUsuario";
            ChbLembrarUsuario.Size = new Size(113, 19);
            ChbLembrarUsuario.TabIndex = 3;
            ChbLembrarUsuario.Text = "Lembrar Usuário";
            ChbLembrarUsuario.UseVisualStyleBackColor = false;
            // 
            // LklEsqueceuSenha
            // 
            LklEsqueceuSenha.ActiveLinkColor = SystemColors.ControlText;
            LklEsqueceuSenha.AutoSize = true;
            LklEsqueceuSenha.BackColor = Color.Transparent;
            LklEsqueceuSenha.LinkColor = SystemColors.ControlText;
            LklEsqueceuSenha.Location = new Point(198, 212);
            LklEsqueceuSenha.Name = "LklEsqueceuSenha";
            LklEsqueceuSenha.Size = new Size(105, 15);
            LklEsqueceuSenha.TabIndex = 4;
            LklEsqueceuSenha.TabStop = true;
            LklEsqueceuSenha.Text = "Esqueceu a senha?";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(69, 41);
            label1.Name = "label1";
            label1.Size = new Size(207, 37);
            label1.TabIndex = 6;
            label1.Text = "Seja Bem-Vindo";
            // 
            // TxbSenha
            // 
            TxbSenha.BorderStyle = BorderStyle.None;
            TxbSenha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxbSenha.Location = new Point(42, 159);
            TxbSenha.Name = "TxbSenha";
            TxbSenha.PasswordChar = '*';
            TxbSenha.PlaceholderText = "Senha";
            TxbSenha.Size = new Size(261, 22);
            TxbSenha.TabIndex = 2;
            TxbSenha.TextAlign = HorizontalAlignment.Center;
            TxbSenha.UseSystemPasswordChar = true;
            TxbSenha.KeyDown += TxbSenha_KeyDown;
            TxbSenha.KeyPress += TxbSenha_KeyPress;
            // 
            // TxbLogin
            // 
            TxbLogin.BorderStyle = BorderStyle.None;
            TxbLogin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxbLogin.Location = new Point(42, 106);
            TxbLogin.Name = "TxbLogin";
            TxbLogin.PlaceholderText = "Login";
            TxbLogin.Size = new Size(261, 22);
            TxbLogin.TabIndex = 1;
            TxbLogin.TextAlign = HorizontalAlignment.Center;
            TxbLogin.KeyDown += TxbLogin_KeyDown;
            TxbLogin.KeyPress += TxbLogin_KeyPress;
            // 
            // BtnEntrar
            // 
            BtnEntrar.BackColor = Color.Transparent;
            BtnEntrar.FlatStyle = FlatStyle.Flat;
            BtnEntrar.Image = (Image)resources.GetObject("BtnEntrar.Image");
            BtnEntrar.Location = new Point(179, 243);
            BtnEntrar.Name = "BtnEntrar";
            BtnEntrar.Size = new Size(50, 50);
            BtnEntrar.TabIndex = 5;
            BtnEntrar.UseVisualStyleBackColor = false;
            BtnEntrar.Click += BtnEntrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 350);
            Controls.Add(PnlPrincipal);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            PnlPrincipal.ResumeLayout(false);
            PnlImagem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            PnlLateral.ResumeLayout(false);
            PnlLateral.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel PnlPrincipal;
        private Panel PnlImagem;
        private Panel PnlLateral;
        private CheckBox ChbLembrarUsuario;
        private LinkLabel LklEsqueceuSenha;
        private Label label1;
        private TextBox TxbSenha;
        private TextBox TxbLogin;
        private Button BtnEntrar;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel2;
        private Button BtnSair;
    }
}