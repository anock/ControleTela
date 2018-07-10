namespace ControleTela
{
    partial class Vendas
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
            this.components = new System.ComponentModel.Container();
            this.txtModelo = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.controleDataSet = new ControleTela.ControleDataSet();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtPreco = new MetroFramework.Controls.MetroTextBox();
            this.btnFinaliza = new MetroFramework.Controls.MetroButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.lbTotal = new MetroFramework.Controls.MetroLabel();
            this.tableTableAdapter = new ControleTela.ControleDataSetTableAdapters.TableTableAdapter();
            this.Calcular = new MetroFramework.Controls.MetroButton();
            this.btnSair = new MetroFramework.Controls.MetroButton();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtAzul = new MetroFramework.Controls.MetroTextBox();
            this.txtPreto = new MetroFramework.Controls.MetroTextBox();
            this.txtBranco = new MetroFramework.Controls.MetroTextBox();
            this.txtDourado = new MetroFramework.Controls.MetroTextBox();
            this.txtTotal = new MetroFramework.Controls.MetroTextBox();
            this.QtdLabel = new MetroFramework.Controls.MetroLabel();
            this.lbResultado = new MetroFramework.Controls.MetroLabel();
            this.txtAz = new MetroFramework.Controls.MetroTextBox();
            this.txtPt = new MetroFramework.Controls.MetroTextBox();
            this.txtBr = new MetroFramework.Controls.MetroTextBox();
            this.txtDr = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controleDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // txtModelo
            // 
            this.txtModelo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtModelo.CustomButton.Image = null;
            this.txtModelo.CustomButton.Location = new System.Drawing.Point(233, 1);
            this.txtModelo.CustomButton.Name = "";
            this.txtModelo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtModelo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtModelo.CustomButton.TabIndex = 1;
            this.txtModelo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtModelo.CustomButton.UseSelectable = true;
            this.txtModelo.CustomButton.Visible = false;
            this.txtModelo.Lines = new string[0];
            this.txtModelo.Location = new System.Drawing.Point(404, 38);
            this.txtModelo.MaxLength = 32767;
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.PasswordChar = '\0';
            this.txtModelo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtModelo.SelectedText = "";
            this.txtModelo.SelectionLength = 0;
            this.txtModelo.SelectionStart = 0;
            this.txtModelo.ShortcutsEnabled = true;
            this.txtModelo.Size = new System.Drawing.Size(237, 23);
            this.txtModelo.TabIndex = 0;
            this.txtModelo.UseSelectable = true;
            this.txtModelo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtModelo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtModelo.Click += new System.EventHandler(this.txtModelo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.tableBindingSource, "imagem", true));
            this.pictureBox1.Location = new System.Drawing.Point(23, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(334, 306);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.controleDataSet;
            // 
            // controleDataSet
            // 
            this.controleDataSet.DataSetName = "ControleDataSet";
            this.controleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(298, 40);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(59, 20);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Modelo:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(384, 255);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(48, 20);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Preço:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(25, 486);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(42, 20);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Azul.:";
            // 
            // txtPreco
            // 
            // 
            // 
            // 
            this.txtPreco.CustomButton.Image = null;
            this.txtPreco.CustomButton.Location = new System.Drawing.Point(60, 1);
            this.txtPreco.CustomButton.Name = "";
            this.txtPreco.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPreco.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPreco.CustomButton.TabIndex = 1;
            this.txtPreco.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPreco.CustomButton.UseSelectable = true;
            this.txtPreco.CustomButton.Visible = false;
            this.txtPreco.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "venda", true));
            this.txtPreco.Lines = new string[0];
            this.txtPreco.Location = new System.Drawing.Point(499, 252);
            this.txtPreco.MaxLength = 32767;
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.PasswordChar = '\0';
            this.txtPreco.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPreco.SelectedText = "";
            this.txtPreco.SelectionLength = 0;
            this.txtPreco.SelectionStart = 0;
            this.txtPreco.ShortcutsEnabled = true;
            this.txtPreco.Size = new System.Drawing.Size(82, 23);
            this.txtPreco.TabIndex = 5;
            this.txtPreco.UseSelectable = true;
            this.txtPreco.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPreco.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnFinaliza
            // 
            this.btnFinaliza.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinaliza.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnFinaliza.Location = new System.Drawing.Point(404, 400);
            this.btnFinaliza.Name = "btnFinaliza";
            this.btnFinaliza.Size = new System.Drawing.Size(262, 38);
            this.btnFinaliza.Style = MetroFramework.MetroColorStyle.Green;
            this.btnFinaliza.TabIndex = 7;
            this.btnFinaliza.Text = "Finalizar a compra";
            this.btnFinaliza.UseSelectable = true;
            this.btnFinaliza.Click += new System.EventHandler(this.btnFinaliza_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(368, 307);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(94, 20);
            this.metroLabel4.TabIndex = 9;
            this.metroLabel4.Text = "Total a pagar :";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbTotal.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbTotal.Location = new System.Drawing.Point(468, 302);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(45, 25);
            this.lbTotal.TabIndex = 10;
            this.lbTotal.Text = "R$ :";
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // Calcular
            // 
            this.Calcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Calcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Calcular.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.Calcular.ForeColor = System.Drawing.Color.Tomato;
            this.Calcular.Location = new System.Drawing.Point(404, 356);
            this.Calcular.Name = "Calcular";
            this.Calcular.Size = new System.Drawing.Size(262, 38);
            this.Calcular.Style = MetroFramework.MetroColorStyle.Green;
            this.Calcular.TabIndex = 11;
            this.Calcular.Text = "Calcular";
            this.Calcular.UseSelectable = true;
            this.Calcular.Click += new System.EventHandler(this.Calcular_Click);
            // 
            // btnSair
            // 
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnSair.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSair.Location = new System.Drawing.Point(404, 468);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(262, 38);
            this.btnSair.Style = MetroFramework.MetroColorStyle.Red;
            this.btnSair.TabIndex = 12;
            this.btnSair.Text = "Sair";
            this.btnSair.UseSelectable = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(25, 457);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(69, 20);
            this.metroLabel6.TabIndex = 15;
            this.metroLabel6.Text = "Dourado.:";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(25, 428);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(48, 20);
            this.metroLabel7.TabIndex = 17;
            this.metroLabel7.Text = "Preto.:";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(25, 399);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(58, 20);
            this.metroLabel8.TabIndex = 19;
            this.metroLabel8.Text = "Branco.:";
            // 
            // btnOk
            // 
            this.btnOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOk.Location = new System.Drawing.Point(647, 37);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(57, 23);
            this.btnOk.TabIndex = 21;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtAzul
            // 
            // 
            // 
            // 
            this.txtAzul.CustomButton.Image = null;
            this.txtAzul.CustomButton.Location = new System.Drawing.Point(60, 1);
            this.txtAzul.CustomButton.Name = "";
            this.txtAzul.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAzul.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAzul.CustomButton.TabIndex = 1;
            this.txtAzul.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAzul.CustomButton.UseSelectable = true;
            this.txtAzul.CustomButton.Visible = false;
            this.txtAzul.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "azul", true));
            this.txtAzul.Lines = new string[0];
            this.txtAzul.Location = new System.Drawing.Point(110, 486);
            this.txtAzul.MaxLength = 100;
            this.txtAzul.Name = "txtAzul";
            this.txtAzul.PasswordChar = '\0';
            this.txtAzul.ReadOnly = true;
            this.txtAzul.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAzul.SelectedText = "";
            this.txtAzul.SelectionLength = 0;
            this.txtAzul.SelectionStart = 0;
            this.txtAzul.ShortcutsEnabled = true;
            this.txtAzul.Size = new System.Drawing.Size(82, 23);
            this.txtAzul.TabIndex = 25;
            this.txtAzul.UseSelectable = true;
            this.txtAzul.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAzul.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPreto
            // 
            // 
            // 
            // 
            this.txtPreto.CustomButton.Image = null;
            this.txtPreto.CustomButton.Location = new System.Drawing.Point(60, 1);
            this.txtPreto.CustomButton.Name = "";
            this.txtPreto.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPreto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPreto.CustomButton.TabIndex = 1;
            this.txtPreto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPreto.CustomButton.UseSelectable = true;
            this.txtPreto.CustomButton.Visible = false;
            this.txtPreto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "preto", true));
            this.txtPreto.Lines = new string[0];
            this.txtPreto.Location = new System.Drawing.Point(110, 428);
            this.txtPreto.MaxLength = 100;
            this.txtPreto.Name = "txtPreto";
            this.txtPreto.PasswordChar = '\0';
            this.txtPreto.ReadOnly = true;
            this.txtPreto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPreto.SelectedText = "";
            this.txtPreto.SelectionLength = 0;
            this.txtPreto.SelectionStart = 0;
            this.txtPreto.ShortcutsEnabled = true;
            this.txtPreto.Size = new System.Drawing.Size(82, 23);
            this.txtPreto.TabIndex = 24;
            this.txtPreto.UseSelectable = true;
            this.txtPreto.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPreto.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtBranco
            // 
            // 
            // 
            // 
            this.txtBranco.CustomButton.Image = null;
            this.txtBranco.CustomButton.Location = new System.Drawing.Point(60, 1);
            this.txtBranco.CustomButton.Name = "";
            this.txtBranco.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBranco.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBranco.CustomButton.TabIndex = 1;
            this.txtBranco.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBranco.CustomButton.UseSelectable = true;
            this.txtBranco.CustomButton.Visible = false;
            this.txtBranco.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "branco", true));
            this.txtBranco.Lines = new string[0];
            this.txtBranco.Location = new System.Drawing.Point(110, 399);
            this.txtBranco.MaxLength = 100;
            this.txtBranco.Name = "txtBranco";
            this.txtBranco.PasswordChar = '\0';
            this.txtBranco.ReadOnly = true;
            this.txtBranco.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBranco.SelectedText = "";
            this.txtBranco.SelectionLength = 0;
            this.txtBranco.SelectionStart = 0;
            this.txtBranco.ShortcutsEnabled = true;
            this.txtBranco.Size = new System.Drawing.Size(82, 23);
            this.txtBranco.TabIndex = 23;
            this.txtBranco.UseSelectable = true;
            this.txtBranco.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBranco.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtDourado
            // 
            // 
            // 
            // 
            this.txtDourado.CustomButton.Image = null;
            this.txtDourado.CustomButton.Location = new System.Drawing.Point(60, 1);
            this.txtDourado.CustomButton.Name = "";
            this.txtDourado.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDourado.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDourado.CustomButton.TabIndex = 1;
            this.txtDourado.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDourado.CustomButton.UseSelectable = true;
            this.txtDourado.CustomButton.Visible = false;
            this.txtDourado.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "dourado", true));
            this.txtDourado.Lines = new string[0];
            this.txtDourado.Location = new System.Drawing.Point(110, 457);
            this.txtDourado.MaxLength = 100;
            this.txtDourado.Name = "txtDourado";
            this.txtDourado.PasswordChar = '\0';
            this.txtDourado.ReadOnly = true;
            this.txtDourado.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDourado.SelectedText = "";
            this.txtDourado.SelectionLength = 0;
            this.txtDourado.SelectionStart = 0;
            this.txtDourado.ShortcutsEnabled = true;
            this.txtDourado.Size = new System.Drawing.Size(82, 23);
            this.txtDourado.TabIndex = 22;
            this.txtDourado.UseSelectable = true;
            this.txtDourado.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDourado.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtTotal
            // 
            // 
            // 
            // 
            this.txtTotal.CustomButton.Image = null;
            this.txtTotal.CustomButton.Location = new System.Drawing.Point(45, 1);
            this.txtTotal.CustomButton.Name = "";
            this.txtTotal.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTotal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTotal.CustomButton.TabIndex = 1;
            this.txtTotal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTotal.CustomButton.UseSelectable = true;
            this.txtTotal.CustomButton.Visible = false;
            this.txtTotal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "estoque", true));
            this.txtTotal.Enabled = false;
            this.txtTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtTotal.Lines = new string[0];
            this.txtTotal.Location = new System.Drawing.Point(290, 486);
            this.txtTotal.MaxLength = 32767;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.PasswordChar = '\0';
            this.txtTotal.ReadOnly = true;
            this.txtTotal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTotal.SelectedText = "";
            this.txtTotal.SelectionLength = 0;
            this.txtTotal.SelectionStart = 0;
            this.txtTotal.ShortcutsEnabled = true;
            this.txtTotal.Size = new System.Drawing.Size(67, 23);
            this.txtTotal.Style = MetroFramework.MetroColorStyle.Magenta;
            this.txtTotal.TabIndex = 27;
            this.txtTotal.UseSelectable = true;
            this.txtTotal.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTotal.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // QtdLabel
            // 
            this.QtdLabel.AutoSize = true;
            this.QtdLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.QtdLabel.Location = new System.Drawing.Point(206, 486);
            this.QtdLabel.Name = "QtdLabel";
            this.QtdLabel.Size = new System.Drawing.Size(78, 20);
            this.QtdLabel.TabIndex = 26;
            this.QtdLabel.Text = "Qtd Total:";
            // 
            // lbResultado
            // 
            this.lbResultado.AutoSize = true;
            this.lbResultado.Location = new System.Drawing.Point(539, 307);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(12, 20);
            this.lbResultado.Style = MetroFramework.MetroColorStyle.Red;
            this.lbResultado.TabIndex = 28;
            this.lbResultado.Text = ".";
            // 
            // txtAz
            // 
            // 
            // 
            // 
            this.txtAz.CustomButton.Image = null;
            this.txtAz.CustomButton.Location = new System.Drawing.Point(60, 1);
            this.txtAz.CustomButton.Name = "";
            this.txtAz.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAz.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAz.CustomButton.TabIndex = 1;
            this.txtAz.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAz.CustomButton.UseSelectable = true;
            this.txtAz.CustomButton.Visible = false;
            this.txtAz.Lines = new string[0];
            this.txtAz.Location = new System.Drawing.Point(499, 191);
            this.txtAz.MaxLength = 100;
            this.txtAz.Name = "txtAz";
            this.txtAz.PasswordChar = '\0';
            this.txtAz.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAz.SelectedText = "";
            this.txtAz.SelectionLength = 0;
            this.txtAz.SelectionStart = 0;
            this.txtAz.ShortcutsEnabled = true;
            this.txtAz.Size = new System.Drawing.Size(82, 23);
            this.txtAz.TabIndex = 36;
            this.txtAz.UseSelectable = true;
            this.txtAz.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAz.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPt
            // 
            // 
            // 
            // 
            this.txtPt.CustomButton.Image = null;
            this.txtPt.CustomButton.Location = new System.Drawing.Point(60, 1);
            this.txtPt.CustomButton.Name = "";
            this.txtPt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPt.CustomButton.TabIndex = 1;
            this.txtPt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPt.CustomButton.UseSelectable = true;
            this.txtPt.CustomButton.Visible = false;
            this.txtPt.Lines = new string[0];
            this.txtPt.Location = new System.Drawing.Point(499, 133);
            this.txtPt.MaxLength = 100;
            this.txtPt.Name = "txtPt";
            this.txtPt.PasswordChar = '\0';
            this.txtPt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPt.SelectedText = "";
            this.txtPt.SelectionLength = 0;
            this.txtPt.SelectionStart = 0;
            this.txtPt.ShortcutsEnabled = true;
            this.txtPt.Size = new System.Drawing.Size(82, 23);
            this.txtPt.TabIndex = 35;
            this.txtPt.UseSelectable = true;
            this.txtPt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtBr
            // 
            // 
            // 
            // 
            this.txtBr.CustomButton.Image = null;
            this.txtBr.CustomButton.Location = new System.Drawing.Point(60, 1);
            this.txtBr.CustomButton.Name = "";
            this.txtBr.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBr.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBr.CustomButton.TabIndex = 1;
            this.txtBr.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBr.CustomButton.UseSelectable = true;
            this.txtBr.CustomButton.Visible = false;
            this.txtBr.Lines = new string[0];
            this.txtBr.Location = new System.Drawing.Point(499, 104);
            this.txtBr.MaxLength = 100;
            this.txtBr.Name = "txtBr";
            this.txtBr.PasswordChar = '\0';
            this.txtBr.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBr.SelectedText = "";
            this.txtBr.SelectionLength = 0;
            this.txtBr.SelectionStart = 0;
            this.txtBr.ShortcutsEnabled = true;
            this.txtBr.Size = new System.Drawing.Size(82, 23);
            this.txtBr.TabIndex = 34;
            this.txtBr.UseSelectable = true;
            this.txtBr.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBr.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtDr
            // 
            // 
            // 
            // 
            this.txtDr.CustomButton.Image = null;
            this.txtDr.CustomButton.Location = new System.Drawing.Point(60, 1);
            this.txtDr.CustomButton.Name = "";
            this.txtDr.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDr.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDr.CustomButton.TabIndex = 1;
            this.txtDr.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDr.CustomButton.UseSelectable = true;
            this.txtDr.CustomButton.Visible = false;
            this.txtDr.Lines = new string[0];
            this.txtDr.Location = new System.Drawing.Point(499, 162);
            this.txtDr.MaxLength = 100;
            this.txtDr.Name = "txtDr";
            this.txtDr.PasswordChar = '\0';
            this.txtDr.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDr.SelectedText = "";
            this.txtDr.SelectionLength = 0;
            this.txtDr.SelectionStart = 0;
            this.txtDr.ShortcutsEnabled = true;
            this.txtDr.Size = new System.Drawing.Size(82, 23);
            this.txtDr.TabIndex = 33;
            this.txtDr.UseSelectable = true;
            this.txtDr.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDr.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(414, 104);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(58, 20);
            this.metroLabel5.TabIndex = 32;
            this.metroLabel5.Text = "Branco.:";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(414, 133);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(48, 20);
            this.metroLabel9.TabIndex = 31;
            this.metroLabel9.Text = "Preto.:";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(414, 162);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(69, 20);
            this.metroLabel10.TabIndex = 30;
            this.metroLabel10.Text = "Dourado.:";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(414, 191);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(42, 20);
            this.metroLabel11.TabIndex = 29;
            this.metroLabel11.Text = "Azul.:";
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel12.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel12.Location = new System.Drawing.Point(438, 252);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(45, 25);
            this.metroLabel12.TabIndex = 37;
            this.metroLabel12.Text = "R$ :";
            // 
            // Vendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 542);
            this.Controls.Add(this.metroLabel12);
            this.Controls.Add(this.txtAz);
            this.Controls.Add(this.txtPt);
            this.Controls.Add(this.txtBr);
            this.Controls.Add(this.txtDr);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.QtdLabel);
            this.Controls.Add(this.txtAzul);
            this.Controls.Add(this.txtPreto);
            this.Controls.Add(this.txtBranco);
            this.Controls.Add(this.txtDourado);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.Calcular);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.btnFinaliza);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtModelo);
            this.MaximizeBox = false;
            this.Name = "Vendas";
            this.Text = "Vendas";
            this.Load += new System.EventHandler(this.Vendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controleDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtModelo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtPreco;
        private MetroFramework.Controls.MetroButton btnFinaliza;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel lbTotal;
        private ControleDataSet controleDataSet;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private ControleDataSetTableAdapters.TableTableAdapter tableTableAdapter;
        private MetroFramework.Controls.MetroButton Calcular;
        private MetroFramework.Controls.MetroButton btnSair;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private System.Windows.Forms.Button btnOk;
        private MetroFramework.Controls.MetroTextBox txtAzul;
        private MetroFramework.Controls.MetroTextBox txtPreto;
        private MetroFramework.Controls.MetroTextBox txtBranco;
        private MetroFramework.Controls.MetroTextBox txtDourado;
        private MetroFramework.Controls.MetroTextBox txtTotal;
        private MetroFramework.Controls.MetroLabel QtdLabel;
        private MetroFramework.Controls.MetroLabel lbResultado;
        private MetroFramework.Controls.MetroTextBox txtAz;
        private MetroFramework.Controls.MetroTextBox txtPt;
        private MetroFramework.Controls.MetroTextBox txtBr;
        private MetroFramework.Controls.MetroTextBox txtDr;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel12;
    }
}