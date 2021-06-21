namespace Sistema
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.BT_Backup = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.sever = new System.Windows.Forms.TextBox();
            this.cenect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pass = new System.Windows.Forms.TextBox();
            this.user = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.clear = new System.Windows.Forms.Button();
            this.Busca = new System.Windows.Forms.Button();
            this.caminho = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.porta = new System.Windows.Forms.TextBox();
            this.processo = new System.Windows.Forms.ProgressBar();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BT_update = new System.Windows.Forms.Button();
            this.usever = new System.Windows.Forms.TextBox();
            this.uprocesso = new System.Windows.Forms.ProgressBar();
            this.uuser = new System.Windows.Forms.TextBox();
            this.ucaminho = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.uBusca = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.uporta = new System.Windows.Forms.TextBox();
            this.upass = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ucomboBox1 = new System.Windows.Forms.ComboBox();
            this.uclear = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.uconect = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(16, 321);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(435, 24);
            this.comboBox1.TabIndex = 6;
            // 
            // BT_Backup
            // 
            this.BT_Backup.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BT_Backup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Backup.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BT_Backup.Location = new System.Drawing.Point(156, 465);
            this.BT_Backup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BT_Backup.Name = "BT_Backup";
            this.BT_Backup.Size = new System.Drawing.Size(159, 44);
            this.BT_Backup.TabIndex = 8;
            this.BT_Backup.Text = "Efetuar Backup";
            this.BT_Backup.UseVisualStyleBackColor = false;
            this.BT_Backup.Visible = false;
            this.BT_Backup.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 114);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Servidor:";
            // 
            // sever
            // 
            this.sever.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.sever.Location = new System.Drawing.Point(83, 114);
            this.sever.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sever.Name = "sever";
            this.sever.Size = new System.Drawing.Size(368, 22);
            this.sever.TabIndex = 0;
            // 
            // cenect
            // 
            this.cenect.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.cenect.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cenect.Location = new System.Drawing.Point(343, 256);
            this.cenect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cenect.Name = "cenect";
            this.cenect.Size = new System.Drawing.Size(109, 33);
            this.cenect.TabIndex = 4;
            this.cenect.Text = "CONECTAR";
            this.cenect.UseVisualStyleBackColor = false;
            this.cenect.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 182);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Senha:";
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(83, 178);
            this.pass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pass.Name = "pass";
            this.pass.PasswordChar = '*';
            this.pass.Size = new System.Drawing.Size(368, 22);
            this.pass.TabIndex = 2;
            // 
            // user
            // 
            this.user.Location = new System.Drawing.Point(83, 146);
            this.user.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(368, 22);
            this.user.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 150);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Usuário:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 302);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Selecionar banco para backup: ";
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.IndianRed;
            this.clear.ForeColor = System.Drawing.Color.White;
            this.clear.Location = new System.Drawing.Point(17, 256);
            this.clear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(104, 33);
            this.clear.TabIndex = 5;
            this.clear.Text = "LIMPAR";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // Busca
            // 
            this.Busca.BackColor = System.Drawing.Color.White;
            this.Busca.Location = new System.Drawing.Point(285, 378);
            this.Busca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Busca.Name = "Busca";
            this.Busca.Size = new System.Drawing.Size(167, 28);
            this.Busca.TabIndex = 7;
            this.Busca.Text = "Selecionar pasta";
            this.Busca.UseVisualStyleBackColor = false;
            this.Busca.Click += new System.EventHandler(this.Busca_Click);
            // 
            // caminho
            // 
            this.caminho.Location = new System.Drawing.Point(16, 407);
            this.caminho.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.caminho.Name = "caminho";
            this.caminho.Size = new System.Drawing.Size(435, 22);
            this.caminho.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 384);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(264, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Selecione o local desejado para backup:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 214);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Porta:";
            // 
            // porta
            // 
            this.porta.Location = new System.Drawing.Point(83, 210);
            this.porta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.porta.Name = "porta";
            this.porta.Size = new System.Drawing.Size(368, 22);
            this.porta.TabIndex = 3;
            this.porta.Text = "3306";
            // 
            // processo
            // 
            this.processo.Location = new System.Drawing.Point(16, 439);
            this.processo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.processo.Name = "processo";
            this.processo.Size = new System.Drawing.Size(436, 18);
            this.processo.TabIndex = 15;
            this.processo.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-5, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(485, 566);
            this.tabControl1.TabIndex = 17;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.pictureBox2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.BT_Backup);
            this.tabPage1.Controls.Add(this.sever);
            this.tabPage1.Controls.Add(this.processo);
            this.tabPage1.Controls.Add(this.user);
            this.tabPage1.Controls.Add(this.caminho);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.Busca);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.porta);
            this.tabPage1.Controls.Add(this.pass);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.clear);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.cenect);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(477, 537);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Backup";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(83, 4);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(327, 86);
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.BT_update);
            this.tabPage2.Controls.Add(this.usever);
            this.tabPage2.Controls.Add(this.uprocesso);
            this.tabPage2.Controls.Add(this.uuser);
            this.tabPage2.Controls.Add(this.ucaminho);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.uBusca);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.uporta);
            this.tabPage2.Controls.Add(this.upass);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.ucomboBox1);
            this.tabPage2.Controls.Add(this.uclear);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.uconect);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(477, 537);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Update";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(81, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(309, 92);
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 172);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "Servidor:";
            // 
            // BT_update
            // 
            this.BT_update.BackColor = System.Drawing.Color.White;
            this.BT_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_update.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.BT_update.Location = new System.Drawing.Point(151, 455);
            this.BT_update.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BT_update.Name = "BT_update";
            this.BT_update.Size = new System.Drawing.Size(159, 39);
            this.BT_update.TabIndex = 9;
            this.BT_update.Text = "Importar Banco";
            this.BT_update.UseVisualStyleBackColor = false;
            this.BT_update.Visible = false;
            this.BT_update.Click += new System.EventHandler(this.BT_update_Click);
            // 
            // usever
            // 
            this.usever.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.usever.Location = new System.Drawing.Point(81, 172);
            this.usever.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.usever.Name = "usever";
            this.usever.Size = new System.Drawing.Size(368, 22);
            this.usever.TabIndex = 3;
            // 
            // uprocesso
            // 
            this.uprocesso.Location = new System.Drawing.Point(15, 415);
            this.uprocesso.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uprocesso.Name = "uprocesso";
            this.uprocesso.Size = new System.Drawing.Size(436, 18);
            this.uprocesso.TabIndex = 33;
            this.uprocesso.Visible = false;
            // 
            // uuser
            // 
            this.uuser.Location = new System.Drawing.Point(81, 204);
            this.uuser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uuser.Name = "uuser";
            this.uuser.Size = new System.Drawing.Size(368, 22);
            this.uuser.TabIndex = 4;
            // 
            // ucaminho
            // 
            this.ucaminho.Location = new System.Drawing.Point(15, 135);
            this.ucaminho.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ucaminho.Name = "ucaminho";
            this.ucaminho.Size = new System.Drawing.Size(435, 22);
            this.ucaminho.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 112);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(277, 17);
            this.label9.TabIndex = 31;
            this.label9.Text = "Selecione onde está o banco para update:";
            // 
            // uBusca
            // 
            this.uBusca.BackColor = System.Drawing.Color.White;
            this.uBusca.Location = new System.Drawing.Point(299, 106);
            this.uBusca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uBusca.Name = "uBusca";
            this.uBusca.Size = new System.Drawing.Size(152, 28);
            this.uBusca.TabIndex = 1;
            this.uBusca.Text = "Selecionar arquivo";
            this.uBusca.UseVisualStyleBackColor = false;
            this.uBusca.Click += new System.EventHandler(this.uBusca_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 272);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 17);
            this.label10.TabIndex = 32;
            this.label10.Text = "Porta:";
            // 
            // uporta
            // 
            this.uporta.Location = new System.Drawing.Point(81, 268);
            this.uporta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uporta.Name = "uporta";
            this.uporta.Size = new System.Drawing.Size(368, 22);
            this.uporta.TabIndex = 6;
            this.uporta.Text = "3306";
            // 
            // upass
            // 
            this.upass.Location = new System.Drawing.Point(81, 236);
            this.upass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.upass.Name = "upass";
            this.upass.PasswordChar = '*';
            this.upass.Size = new System.Drawing.Size(368, 22);
            this.upass.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 362);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(207, 17);
            this.label11.TabIndex = 30;
            this.label11.Text = "Selecionar banco para update: ";
            // 
            // ucomboBox1
            // 
            this.ucomboBox1.FormattingEnabled = true;
            this.ucomboBox1.ItemHeight = 16;
            this.ucomboBox1.Location = new System.Drawing.Point(15, 382);
            this.ucomboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ucomboBox1.Name = "ucomboBox1";
            this.ucomboBox1.Size = new System.Drawing.Size(435, 24);
            this.ucomboBox1.TabIndex = 25;
            // 
            // uclear
            // 
            this.uclear.BackColor = System.Drawing.Color.IndianRed;
            this.uclear.ForeColor = System.Drawing.Color.White;
            this.uclear.Location = new System.Drawing.Point(16, 314);
            this.uclear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uclear.Name = "uclear";
            this.uclear.Size = new System.Drawing.Size(104, 33);
            this.uclear.TabIndex = 10;
            this.uclear.Text = "LIMPAR";
            this.uclear.UseVisualStyleBackColor = false;
            this.uclear.Click += new System.EventHandler(this.uclear_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 208);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 17);
            this.label12.TabIndex = 29;
            this.label12.Text = "Usuário:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(19, 240);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 17);
            this.label13.TabIndex = 24;
            this.label13.Text = "Senha:";
            // 
            // uconect
            // 
            this.uconect.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.uconect.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.uconect.Location = new System.Drawing.Point(341, 314);
            this.uconect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uconect.Name = "uconect";
            this.uconect.Size = new System.Drawing.Size(109, 33);
            this.uconect.TabIndex = 7;
            this.uconect.Text = "CONECTAR";
            this.uconect.UseVisualStyleBackColor = false;
            this.uconect.Click += new System.EventHandler(this.uconect_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(483, 572);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Mysql Dump";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button BT_Backup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sever;
        private System.Windows.Forms.Button cenect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button Busca;
        private System.Windows.Forms.TextBox caminho;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox porta;
        private System.Windows.Forms.ProgressBar processo;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BT_update;
        private System.Windows.Forms.TextBox usever;
        private System.Windows.Forms.ProgressBar uprocesso;
        private System.Windows.Forms.TextBox uuser;
        private System.Windows.Forms.TextBox ucaminho;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button uBusca;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox uporta;
        private System.Windows.Forms.TextBox upass;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox ucomboBox1;
        private System.Windows.Forms.Button uclear;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button uconect;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

