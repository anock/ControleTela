namespace ControleTela
{
    partial class Cadastro
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtModelo = new MetroFramework.Controls.MetroTextBox();
            this.txtDourado = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtBranco = new MetroFramework.Controls.MetroTextBox();
            this.txtPreto = new MetroFramework.Controls.MetroTextBox();
            this.txtAzul = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.btnImagem = new MetroFramework.Controls.MetroButton();
            this.btnSalvar = new MetroFramework.Controls.MetroButton();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.btnEdit = new MetroFramework.Controls.MetroButton();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.picImagem = new System.Windows.Forms.PictureBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.txtVenda = new MetroFramework.Controls.MetroTextBox();
            this.txtCompra = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.txtData = new MetroFramework.Controls.MetroTextBox();
            this.QtdLabel = new MetroFramework.Controls.MetroLabel();
            this.LbSoma = new MetroFramework.Controls.MetroLabel();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.controleDataSet = new ControleTela.ControleDataSet();
            this.tableTableAdapter = new ControleTela.ControleDataSetTableAdapters.TableTableAdapter();
            this.TxtBusca = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controleDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(23, 109);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(62, 20);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Modelo";
            // 
            // txtModelo
            // 
            this.txtModelo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtModelo.CustomButton.Image = null;
            this.txtModelo.CustomButton.Location = new System.Drawing.Point(190, 1);
            this.txtModelo.CustomButton.Name = "";
            this.txtModelo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtModelo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtModelo.CustomButton.TabIndex = 1;
            this.txtModelo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtModelo.CustomButton.UseSelectable = true;
            this.txtModelo.CustomButton.Visible = false;
            this.txtModelo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "modelo", true));
            this.txtModelo.Lines = new string[0];
            this.txtModelo.Location = new System.Drawing.Point(98, 106);
            this.txtModelo.MaxLength = 32767;
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.PasswordChar = '\0';
            this.txtModelo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtModelo.SelectedText = "";
            this.txtModelo.SelectionLength = 0;
            this.txtModelo.SelectionStart = 0;
            this.txtModelo.ShortcutsEnabled = true;
            this.txtModelo.Size = new System.Drawing.Size(212, 23);
            this.txtModelo.TabIndex = 1;
            this.txtModelo.UseSelectable = true;
            this.txtModelo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtModelo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.txtDourado.Location = new System.Drawing.Point(228, 161);
            this.txtDourado.MaxLength = 100;
            this.txtDourado.Name = "txtDourado";
            this.txtDourado.PasswordChar = '\0';
            this.txtDourado.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDourado.SelectedText = "";
            this.txtDourado.SelectionLength = 0;
            this.txtDourado.SelectionStart = 0;
            this.txtDourado.ShortcutsEnabled = true;
            this.txtDourado.Size = new System.Drawing.Size(82, 23);
            this.txtDourado.TabIndex = 3;
            this.txtDourado.UseSelectable = true;
            this.txtDourado.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDourado.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(23, 203);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(52, 20);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Cores:";
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
            this.txtBranco.Location = new System.Drawing.Point(228, 190);
            this.txtBranco.MaxLength = 100;
            this.txtBranco.Name = "txtBranco";
            this.txtBranco.PasswordChar = '\0';
            this.txtBranco.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBranco.SelectedText = "";
            this.txtBranco.SelectionLength = 0;
            this.txtBranco.SelectionStart = 0;
            this.txtBranco.ShortcutsEnabled = true;
            this.txtBranco.Size = new System.Drawing.Size(82, 23);
            this.txtBranco.TabIndex = 5;
            this.txtBranco.UseSelectable = true;
            this.txtBranco.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBranco.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.txtPreto.Location = new System.Drawing.Point(228, 219);
            this.txtPreto.MaxLength = 100;
            this.txtPreto.Name = "txtPreto";
            this.txtPreto.PasswordChar = '\0';
            this.txtPreto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPreto.SelectedText = "";
            this.txtPreto.SelectionLength = 0;
            this.txtPreto.SelectionStart = 0;
            this.txtPreto.ShortcutsEnabled = true;
            this.txtPreto.Size = new System.Drawing.Size(82, 23);
            this.txtPreto.TabIndex = 7;
            this.txtPreto.UseSelectable = true;
            this.txtPreto.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPreto.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.txtAzul.Location = new System.Drawing.Point(228, 248);
            this.txtAzul.MaxLength = 100;
            this.txtAzul.Name = "txtAzul";
            this.txtAzul.PasswordChar = '\0';
            this.txtAzul.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAzul.SelectedText = "";
            this.txtAzul.SelectionLength = 0;
            this.txtAzul.SelectionStart = 0;
            this.txtAzul.ShortcutsEnabled = true;
            this.txtAzul.Size = new System.Drawing.Size(82, 23);
            this.txtAzul.TabIndex = 8;
            this.txtAzul.UseSelectable = true;
            this.txtAzul.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAzul.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(141, 164);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(66, 20);
            this.metroLabel4.TabIndex = 9;
            this.metroLabel4.Text = "Dourado:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(141, 193);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(55, 20);
            this.metroLabel5.TabIndex = 10;
            this.metroLabel5.Text = "Branco:";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(141, 222);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(45, 20);
            this.metroLabel6.TabIndex = 11;
            this.metroLabel6.Text = "Preto:";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(141, 248);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(39, 20);
            this.metroLabel7.TabIndex = 12;
            this.metroLabel7.Text = "Azul:";
            // 
            // btnImagem
            // 
            this.btnImagem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImagem.Location = new System.Drawing.Point(449, 380);
            this.btnImagem.Name = "btnImagem";
            this.btnImagem.Size = new System.Drawing.Size(115, 23);
            this.btnImagem.TabIndex = 14;
            this.btnImagem.Text = "Buscar Imagem";
            this.btnImagem.UseSelectable = true;
            this.btnImagem.Click += new System.EventHandler(this.btnImagem_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackgroundImage = global::ControleTela.Properties.Resources.savedisketteinterfacesymbol_79723;
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.Location = new System.Drawing.Point(639, 444);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(72, 43);
            this.btnSalvar.TabIndex = 18;
            this.btnSalvar.UseSelectable = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BackgroundImage = global::ControleTela.Properties.Resources.trash_can_38501;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Location = new System.Drawing.Point(561, 444);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(72, 43);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackgroundImage = global::ControleTela.Properties.Resources.Icone_Tome_Notas;
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Location = new System.Drawing.Point(483, 444);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(72, 43);
            this.btnEdit.TabIndex = 16;
            this.btnEdit.UseSelectable = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = global::ControleTela.Properties.Resources.add;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Location = new System.Drawing.Point(382, 444);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(95, 43);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.UseSelectable = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // picImagem
            // 
            this.picImagem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picImagem.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.tableBindingSource, "imagem", true));
            this.picImagem.Location = new System.Drawing.Point(356, 106);
            this.picImagem.Name = "picImagem";
            this.picImagem.Size = new System.Drawing.Size(295, 268);
            this.picImagem.TabIndex = 6;
            this.picImagem.TabStop = false;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel9.Location = new System.Drawing.Point(23, 309);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(117, 20);
            this.metroLabel9.TabIndex = 19;
            this.metroLabel9.Text = "Valor de Venda:";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel10.Location = new System.Drawing.Point(23, 280);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(129, 20);
            this.metroLabel10.TabIndex = 20;
            this.metroLabel10.Text = "Valor de Compra:";
            // 
            // txtVenda
            // 
            // 
            // 
            // 
            this.txtVenda.CustomButton.Image = null;
            this.txtVenda.CustomButton.Location = new System.Drawing.Point(60, 1);
            this.txtVenda.CustomButton.Name = "";
            this.txtVenda.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtVenda.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtVenda.CustomButton.TabIndex = 1;
            this.txtVenda.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtVenda.CustomButton.UseSelectable = true;
            this.txtVenda.CustomButton.Visible = false;
            this.txtVenda.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "venda", true));
            this.txtVenda.Lines = new string[0];
            this.txtVenda.Location = new System.Drawing.Point(228, 306);
            this.txtVenda.MaxLength = 1000;
            this.txtVenda.Name = "txtVenda";
            this.txtVenda.PasswordChar = '\0';
            this.txtVenda.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtVenda.SelectedText = "";
            this.txtVenda.SelectionLength = 0;
            this.txtVenda.SelectionStart = 0;
            this.txtVenda.ShortcutsEnabled = true;
            this.txtVenda.Size = new System.Drawing.Size(82, 23);
            this.txtVenda.TabIndex = 21;
            this.txtVenda.UseSelectable = true;
            this.txtVenda.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtVenda.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtCompra
            // 
            // 
            // 
            // 
            this.txtCompra.CustomButton.Image = null;
            this.txtCompra.CustomButton.Location = new System.Drawing.Point(60, 1);
            this.txtCompra.CustomButton.Name = "";
            this.txtCompra.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCompra.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCompra.CustomButton.TabIndex = 1;
            this.txtCompra.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCompra.CustomButton.UseSelectable = true;
            this.txtCompra.CustomButton.Visible = false;
            this.txtCompra.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "compra", true));
            this.txtCompra.Lines = new string[0];
            this.txtCompra.Location = new System.Drawing.Point(228, 277);
            this.txtCompra.MaxLength = 1000;
            this.txtCompra.Name = "txtCompra";
            this.txtCompra.PasswordChar = '\0';
            this.txtCompra.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCompra.SelectedText = "";
            this.txtCompra.SelectionLength = 0;
            this.txtCompra.SelectionStart = 0;
            this.txtCompra.ShortcutsEnabled = true;
            this.txtCompra.Size = new System.Drawing.Size(82, 23);
            this.txtCompra.TabIndex = 22;
            this.txtCompra.UseSelectable = true;
            this.txtCompra.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCompra.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Id", true));
            this.label1.Location = new System.Drawing.Point(31, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "label1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel8.Location = new System.Drawing.Point(27, 354);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(50, 20);
            this.metroLabel8.TabIndex = 25;
            this.metroLabel8.Text = "Data :";
            // 
            // txtData
            // 
            // 
            // 
            // 
            this.txtData.CustomButton.Image = null;
            this.txtData.CustomButton.Location = new System.Drawing.Point(82, 1);
            this.txtData.CustomButton.Name = "";
            this.txtData.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtData.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtData.CustomButton.TabIndex = 1;
            this.txtData.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtData.CustomButton.UseSelectable = true;
            this.txtData.CustomButton.Visible = false;
            this.txtData.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "data", true));
            this.txtData.Lines = new string[0];
            this.txtData.Location = new System.Drawing.Point(206, 351);
            this.txtData.MaxLength = 1000;
            this.txtData.Name = "txtData";
            this.txtData.PasswordChar = '\0';
            this.txtData.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtData.SelectedText = "";
            this.txtData.SelectionLength = 0;
            this.txtData.SelectionStart = 0;
            this.txtData.ShortcutsEnabled = true;
            this.txtData.Size = new System.Drawing.Size(104, 23);
            this.txtData.TabIndex = 26;
            this.txtData.UseSelectable = true;
            this.txtData.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtData.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // QtdLabel
            // 
            this.QtdLabel.AutoSize = true;
            this.QtdLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.QtdLabel.Location = new System.Drawing.Point(23, 444);
            this.QtdLabel.Name = "QtdLabel";
            this.QtdLabel.Size = new System.Drawing.Size(78, 20);
            this.QtdLabel.TabIndex = 4;
            this.QtdLabel.Text = "Qtd Total:";
            // 
            // LbSoma
            // 
            this.LbSoma.AutoSize = true;
            this.LbSoma.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "estoque", true));
            this.LbSoma.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.LbSoma.Location = new System.Drawing.Point(232, 444);
            this.LbSoma.Name = "LbSoma";
            this.LbSoma.Size = new System.Drawing.Size(0, 0);
            this.LbSoma.TabIndex = 27;
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
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // TxtBusca
            // 
            this.TxtBusca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.TxtBusca.CustomButton.Image = null;
            this.TxtBusca.CustomButton.Location = new System.Drawing.Point(217, 1);
            this.TxtBusca.CustomButton.Name = "";
            this.TxtBusca.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtBusca.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtBusca.CustomButton.TabIndex = 1;
            this.TxtBusca.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtBusca.CustomButton.UseSelectable = true;
            this.TxtBusca.CustomButton.Visible = false;
            this.TxtBusca.Lines = new string[0];
            this.TxtBusca.Location = new System.Drawing.Point(412, 39);
            this.TxtBusca.MaxLength = 32767;
            this.TxtBusca.Name = "TxtBusca";
            this.TxtBusca.PasswordChar = '\0';
            this.TxtBusca.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtBusca.SelectedText = "";
            this.TxtBusca.SelectionLength = 0;
            this.TxtBusca.SelectionStart = 0;
            this.TxtBusca.ShortcutsEnabled = true;
            this.TxtBusca.Size = new System.Drawing.Size(239, 23);
            this.TxtBusca.TabIndex = 28;
            this.TxtBusca.UseSelectable = true;
            this.TxtBusca.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtBusca.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(336, 42);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(56, 20);
            this.metroLabel3.TabIndex = 29;
            this.metroLabel3.Text = "Buscar";
            // 
            // metroButton1
            // 
            this.metroButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroButton1.Location = new System.Drawing.Point(658, 39);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(42, 23);
            this.metroButton1.TabIndex = 30;
            this.metroButton1.Text = "Ok";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel11.Location = new System.Drawing.Point(175, 306);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(32, 20);
            this.metroLabel11.TabIndex = 31;
            this.metroLabel11.Text = "R$ ";
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel12.Location = new System.Drawing.Point(175, 280);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(32, 20);
            this.metroLabel12.TabIndex = 32;
            this.metroLabel12.Text = "R$ ";
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 510);
            this.Controls.Add(this.metroLabel12);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.TxtBusca);
            this.Controls.Add(this.LbSoma);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCompra);
            this.Controls.Add(this.txtVenda);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnImagem);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txtAzul);
            this.Controls.Add(this.txtPreto);
            this.Controls.Add(this.picImagem);
            this.Controls.Add(this.txtBranco);
            this.Controls.Add(this.QtdLabel);
            this.Controls.Add(this.txtDourado);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.metroLabel1);
            this.Name = "Cadastro";
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.Cadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controleDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtModelo;
        private MetroFramework.Controls.MetroTextBox txtDourado;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtBranco;
        private System.Windows.Forms.PictureBox picImagem;
        private MetroFramework.Controls.MetroTextBox txtPreto;
        private MetroFramework.Controls.MetroTextBox txtAzul;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroButton btnImagem;
        private MetroFramework.Controls.MetroButton btnAdd;
        private MetroFramework.Controls.MetroButton btnEdit;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroButton btnSalvar;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroTextBox txtVenda;
        private MetroFramework.Controls.MetroTextBox txtCompra;
        private ControleDataSet controleDataSet;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private ControleDataSetTableAdapters.TableTableAdapter tableTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox txtData;
        private MetroFramework.Controls.MetroLabel QtdLabel;
        private MetroFramework.Controls.MetroLabel LbSoma;
        private MetroFramework.Controls.MetroTextBox TxtBusca;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel12;
    }
}