namespace GorselProgProje
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaElipsePanel2 = new Guna.UI.WinForms.GunaElipsePanel();
            this.sifreText = new Guna.UI2.WinForms.Guna2TextBox();
            this.kadiText = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gunaLinkLabel1 = new Guna.UI.WinForms.GunaLinkLabel();
            this.girisyapButton = new Guna.UI.WinForms.GunaButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.kayitOl = new System.Windows.Forms.TabPage();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.gunaLinkLabel2 = new Guna.UI.WinForms.GunaLinkLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.btn_kayitOl = new Guna.UI.WinForms.GunaButton();
            this.kayitol_epostaText = new Guna.UI2.WinForms.Guna2TextBox();
            this.kayitol_sifreText = new Guna.UI2.WinForms.Guna2TextBox();
            this.kayitol_kadiText = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.giris = new System.Windows.Forms.TabPage();
            this.gunaElipsePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.gunaElipsePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.kayitOl.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.giris.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.White;
            this.gunaElipsePanel1.Controls.Add(this.gunaPictureBox1);
            this.gunaElipsePanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.gunaElipsePanel1.Location = new System.Drawing.Point(383, 0);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Size = new System.Drawing.Size(636, 692);
            this.gunaElipsePanel1.TabIndex = 0;
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaPictureBox1.Image = global::GorselProgProje.Properties.Resources.login;
            this.gunaPictureBox1.Location = new System.Drawing.Point(0, 0);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(636, 692);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 0;
            this.gunaPictureBox1.TabStop = false;
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this.gunaPictureBox1;
            // 
            // gunaElipsePanel2
            // 
            this.gunaElipsePanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(35)))), ((int)(((byte)(76)))));
            this.gunaElipsePanel2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(35)))), ((int)(((byte)(76)))));
            this.gunaElipsePanel2.Controls.Add(this.sifreText);
            this.gunaElipsePanel2.Controls.Add(this.kadiText);
            this.gunaElipsePanel2.Controls.Add(this.pictureBox1);
            this.gunaElipsePanel2.Controls.Add(this.gunaLinkLabel1);
            this.gunaElipsePanel2.Controls.Add(this.girisyapButton);
            this.gunaElipsePanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaElipsePanel2.Location = new System.Drawing.Point(3, 3);
            this.gunaElipsePanel2.Name = "gunaElipsePanel2";
            this.gunaElipsePanel2.Size = new System.Drawing.Size(387, 711);
            this.gunaElipsePanel2.TabIndex = 1;
            // 
            // sifreText
            // 
            this.sifreText.Animated = true;
            this.sifreText.AutoRoundedCorners = true;
            this.sifreText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(148)))), ((int)(((byte)(88)))));
            this.sifreText.BorderRadius = 23;
            this.sifreText.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.sifreText.BorderThickness = 2;
            this.sifreText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sifreText.DefaultText = "";
            this.sifreText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.sifreText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.sifreText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.sifreText.DisabledState.Parent = this.sifreText;
            this.sifreText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.sifreText.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(35)))), ((int)(((byte)(76)))));
            this.sifreText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.sifreText.FocusedState.Parent = this.sifreText;
            this.sifreText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.sifreText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.sifreText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.sifreText.HoverState.Parent = this.sifreText;
            this.sifreText.Location = new System.Drawing.Point(45, 417);
            this.sifreText.Margin = new System.Windows.Forms.Padding(6);
            this.sifreText.Name = "sifreText";
            this.sifreText.PasswordChar = '*';
            this.sifreText.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.sifreText.PlaceholderText = "Şifre";
            this.sifreText.SelectedText = "";
            this.sifreText.ShadowDecoration.Parent = this.sifreText;
            this.sifreText.Size = new System.Drawing.Size(285, 48);
            this.sifreText.TabIndex = 9;
            // 
            // kadiText
            // 
            this.kadiText.Animated = true;
            this.kadiText.AutoRoundedCorners = true;
            this.kadiText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(148)))), ((int)(((byte)(88)))));
            this.kadiText.BorderRadius = 23;
            this.kadiText.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.kadiText.BorderThickness = 2;
            this.kadiText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.kadiText.DefaultText = "";
            this.kadiText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.kadiText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.kadiText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.kadiText.DisabledState.Parent = this.kadiText;
            this.kadiText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.kadiText.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(35)))), ((int)(((byte)(76)))));
            this.kadiText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.kadiText.FocusedState.Parent = this.kadiText;
            this.kadiText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.kadiText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.kadiText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.kadiText.HoverState.Parent = this.kadiText;
            this.kadiText.Location = new System.Drawing.Point(45, 357);
            this.kadiText.Margin = new System.Windows.Forms.Padding(6);
            this.kadiText.Name = "kadiText";
            this.kadiText.PasswordChar = '\0';
            this.kadiText.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.kadiText.PlaceholderText = "Kullanıcı Adı";
            this.kadiText.SelectedText = "";
            this.kadiText.ShadowDecoration.Parent = this.kadiText;
            this.kadiText.Size = new System.Drawing.Size(285, 48);
            this.kadiText.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GorselProgProje.Properties.Resources.logotransparan_2;
            this.pictureBox1.Location = new System.Drawing.Point(45, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(285, 271);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // gunaLinkLabel1
            // 
            this.gunaLinkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.gunaLinkLabel1.AutoSize = true;
            this.gunaLinkLabel1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gunaLinkLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(148)))), ((int)(((byte)(88)))));
            this.gunaLinkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(148)))), ((int)(((byte)(88)))));
            this.gunaLinkLabel1.Location = new System.Drawing.Point(102, 646);
            this.gunaLinkLabel1.Name = "gunaLinkLabel1";
            this.gunaLinkLabel1.Size = new System.Drawing.Size(169, 23);
            this.gunaLinkLabel1.TabIndex = 6;
            this.gunaLinkLabel1.TabStop = true;
            this.gunaLinkLabel1.Text = "Üye olmak için tıkla\r\n";
            this.gunaLinkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.gunaLinkLabel1_LinkClicked);
            // 
            // girisyapButton
            // 
            this.girisyapButton.Animated = true;
            this.girisyapButton.AnimationHoverSpeed = 0.07F;
            this.girisyapButton.AnimationSpeed = 0.03F;
            this.girisyapButton.BackColor = System.Drawing.Color.Transparent;
            this.girisyapButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(148)))), ((int)(((byte)(88)))));
            this.girisyapButton.BorderColor = System.Drawing.Color.Black;
            this.girisyapButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.girisyapButton.FocusedColor = System.Drawing.Color.Empty;
            this.girisyapButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.girisyapButton.ForeColor = System.Drawing.Color.White;
            this.girisyapButton.Image = null;
            this.girisyapButton.ImageSize = new System.Drawing.Size(20, 20);
            this.girisyapButton.Location = new System.Drawing.Point(253, 505);
            this.girisyapButton.Name = "girisyapButton";
            this.girisyapButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.girisyapButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.girisyapButton.OnHoverForeColor = System.Drawing.Color.White;
            this.girisyapButton.OnHoverImage = null;
            this.girisyapButton.OnPressedColor = System.Drawing.Color.Black;
            this.girisyapButton.Radius = 10;
            this.girisyapButton.Size = new System.Drawing.Size(88, 42);
            this.girisyapButton.TabIndex = 4;
            this.girisyapButton.Text = "Giriş Yap";
            this.girisyapButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.girisyapButton.Click += new System.EventHandler(this.girisyapButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.kayitOl);
            this.tabControl1.Controls.Add(this.giris);
            this.tabControl1.Location = new System.Drawing.Point(-8, -32);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(401, 746);
            this.tabControl1.TabIndex = 1;
            // 
            // kayitOl
            // 
            this.kayitOl.Controls.Add(this.guna2Panel1);
            this.kayitOl.Location = new System.Drawing.Point(4, 25);
            this.kayitOl.Name = "kayitOl";
            this.kayitOl.Padding = new System.Windows.Forms.Padding(3);
            this.kayitOl.Size = new System.Drawing.Size(393, 717);
            this.kayitOl.TabIndex = 1;
            this.kayitOl.Text = "tabPage2";
            this.kayitOl.UseVisualStyleBackColor = true;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(35)))), ((int)(((byte)(76)))));
            this.guna2Panel1.Controls.Add(this.gunaLinkLabel2);
            this.guna2Panel1.Controls.Add(this.gunaLabel1);
            this.guna2Panel1.Controls.Add(this.btn_kayitOl);
            this.guna2Panel1.Controls.Add(this.kayitol_epostaText);
            this.guna2Panel1.Controls.Add(this.kayitol_sifreText);
            this.guna2Panel1.Controls.Add(this.kayitol_kadiText);
            this.guna2Panel1.Controls.Add(this.pictureBox2);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(3, 3);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(387, 711);
            this.guna2Panel1.TabIndex = 0;
            // 
            // gunaLinkLabel2
            // 
            this.gunaLinkLabel2.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.gunaLinkLabel2.AutoSize = true;
            this.gunaLinkLabel2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gunaLinkLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(148)))), ((int)(((byte)(88)))));
            this.gunaLinkLabel2.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(148)))), ((int)(((byte)(88)))));
            this.gunaLinkLabel2.Location = new System.Drawing.Point(223, 332);
            this.gunaLinkLabel2.Name = "gunaLinkLabel2";
            this.gunaLinkLabel2.Size = new System.Drawing.Size(79, 23);
            this.gunaLinkLabel2.TabIndex = 13;
            this.gunaLinkLabel2.TabStop = true;
            this.gunaLinkLabel2.Text = "Giriş Yap";
            this.gunaLinkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.gunaLinkLabel2_LinkClicked);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(148)))), ((int)(((byte)(88)))));
            this.gunaLabel1.Location = new System.Drawing.Point(48, 330);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(169, 25);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Zaten üye misiniz?";
            // 
            // btn_kayitOl
            // 
            this.btn_kayitOl.Animated = true;
            this.btn_kayitOl.AnimationHoverSpeed = 0.07F;
            this.btn_kayitOl.AnimationSpeed = 0.03F;
            this.btn_kayitOl.BackColor = System.Drawing.Color.Transparent;
            this.btn_kayitOl.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(148)))), ((int)(((byte)(88)))));
            this.btn_kayitOl.BorderColor = System.Drawing.Color.Black;
            this.btn_kayitOl.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_kayitOl.FocusedColor = System.Drawing.Color.Empty;
            this.btn_kayitOl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_kayitOl.ForeColor = System.Drawing.Color.White;
            this.btn_kayitOl.Image = null;
            this.btn_kayitOl.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_kayitOl.Location = new System.Drawing.Point(141, 593);
            this.btn_kayitOl.Name = "btn_kayitOl";
            this.btn_kayitOl.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btn_kayitOl.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_kayitOl.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_kayitOl.OnHoverImage = null;
            this.btn_kayitOl.OnPressedColor = System.Drawing.Color.Black;
            this.btn_kayitOl.Radius = 10;
            this.btn_kayitOl.Size = new System.Drawing.Size(88, 42);
            this.btn_kayitOl.TabIndex = 12;
            this.btn_kayitOl.Text = "Kayıt Ol";
            this.btn_kayitOl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_kayitOl.Click += new System.EventHandler(this.btn_kayitOl_Click);
            // 
            // kayitol_epostaText
            // 
            this.kayitol_epostaText.Animated = true;
            this.kayitol_epostaText.AutoRoundedCorners = true;
            this.kayitol_epostaText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(148)))), ((int)(((byte)(88)))));
            this.kayitol_epostaText.BorderRadius = 23;
            this.kayitol_epostaText.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.kayitol_epostaText.BorderThickness = 2;
            this.kayitol_epostaText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.kayitol_epostaText.DefaultText = "";
            this.kayitol_epostaText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.kayitol_epostaText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.kayitol_epostaText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.kayitol_epostaText.DisabledState.Parent = this.kayitol_epostaText;
            this.kayitol_epostaText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.kayitol_epostaText.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(35)))), ((int)(((byte)(76)))));
            this.kayitol_epostaText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.kayitol_epostaText.FocusedState.Parent = this.kayitol_epostaText;
            this.kayitol_epostaText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.kayitol_epostaText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.kayitol_epostaText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.kayitol_epostaText.HoverState.Parent = this.kayitol_epostaText;
            this.kayitol_epostaText.Location = new System.Drawing.Point(40, 506);
            this.kayitol_epostaText.Margin = new System.Windows.Forms.Padding(6);
            this.kayitol_epostaText.Name = "kayitol_epostaText";
            this.kayitol_epostaText.PasswordChar = '\0';
            this.kayitol_epostaText.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.kayitol_epostaText.PlaceholderText = "E-Posta";
            this.kayitol_epostaText.SelectedText = "";
            this.kayitol_epostaText.ShadowDecoration.Parent = this.kayitol_epostaText;
            this.kayitol_epostaText.Size = new System.Drawing.Size(285, 48);
            this.kayitol_epostaText.TabIndex = 11;
            // 
            // kayitol_sifreText
            // 
            this.kayitol_sifreText.Animated = true;
            this.kayitol_sifreText.AutoRoundedCorners = true;
            this.kayitol_sifreText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(148)))), ((int)(((byte)(88)))));
            this.kayitol_sifreText.BorderRadius = 23;
            this.kayitol_sifreText.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.kayitol_sifreText.BorderThickness = 2;
            this.kayitol_sifreText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.kayitol_sifreText.DefaultText = "";
            this.kayitol_sifreText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.kayitol_sifreText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.kayitol_sifreText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.kayitol_sifreText.DisabledState.Parent = this.kayitol_sifreText;
            this.kayitol_sifreText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.kayitol_sifreText.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(35)))), ((int)(((byte)(76)))));
            this.kayitol_sifreText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.kayitol_sifreText.FocusedState.Parent = this.kayitol_sifreText;
            this.kayitol_sifreText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.kayitol_sifreText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.kayitol_sifreText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.kayitol_sifreText.HoverState.Parent = this.kayitol_sifreText;
            this.kayitol_sifreText.Location = new System.Drawing.Point(40, 446);
            this.kayitol_sifreText.Margin = new System.Windows.Forms.Padding(6);
            this.kayitol_sifreText.Name = "kayitol_sifreText";
            this.kayitol_sifreText.PasswordChar = '\0';
            this.kayitol_sifreText.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.kayitol_sifreText.PlaceholderText = "Şifre";
            this.kayitol_sifreText.SelectedText = "";
            this.kayitol_sifreText.ShadowDecoration.Parent = this.kayitol_sifreText;
            this.kayitol_sifreText.Size = new System.Drawing.Size(285, 48);
            this.kayitol_sifreText.TabIndex = 10;
            // 
            // kayitol_kadiText
            // 
            this.kayitol_kadiText.Animated = true;
            this.kayitol_kadiText.AutoRoundedCorners = true;
            this.kayitol_kadiText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(148)))), ((int)(((byte)(88)))));
            this.kayitol_kadiText.BorderRadius = 23;
            this.kayitol_kadiText.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.kayitol_kadiText.BorderThickness = 2;
            this.kayitol_kadiText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.kayitol_kadiText.DefaultText = "";
            this.kayitol_kadiText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.kayitol_kadiText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.kayitol_kadiText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.kayitol_kadiText.DisabledState.Parent = this.kayitol_kadiText;
            this.kayitol_kadiText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.kayitol_kadiText.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(35)))), ((int)(((byte)(76)))));
            this.kayitol_kadiText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.kayitol_kadiText.FocusedState.Parent = this.kayitol_kadiText;
            this.kayitol_kadiText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.kayitol_kadiText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.kayitol_kadiText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.kayitol_kadiText.HoverState.Parent = this.kayitol_kadiText;
            this.kayitol_kadiText.Location = new System.Drawing.Point(40, 386);
            this.kayitol_kadiText.Margin = new System.Windows.Forms.Padding(6);
            this.kayitol_kadiText.Name = "kayitol_kadiText";
            this.kayitol_kadiText.PasswordChar = '\0';
            this.kayitol_kadiText.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.kayitol_kadiText.PlaceholderText = "Kullanıcı Adı";
            this.kayitol_kadiText.SelectedText = "";
            this.kayitol_kadiText.ShadowDecoration.Parent = this.kayitol_kadiText;
            this.kayitol_kadiText.Size = new System.Drawing.Size(285, 48);
            this.kayitol_kadiText.TabIndex = 9;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GorselProgProje.Properties.Resources.logotransparan_2;
            this.pictureBox2.Location = new System.Drawing.Point(45, 36);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(285, 271);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // giris
            // 
            this.giris.Controls.Add(this.gunaElipsePanel2);
            this.giris.Location = new System.Drawing.Point(4, 25);
            this.giris.Name = "giris";
            this.giris.Padding = new System.Windows.Forms.Padding(3);
            this.giris.Size = new System.Drawing.Size(393, 717);
            this.giris.TabIndex = 0;
            this.giris.Text = "tabPage1";
            this.giris.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 692);
            this.Controls.Add(this.gunaElipsePanel1);
            this.Controls.Add(this.tabControl1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gunaElipsePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.gunaElipsePanel2.ResumeLayout(false);
            this.gunaElipsePanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.kayitOl.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.giris.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel2;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaButton girisyapButton;
        private Guna.UI.WinForms.GunaLinkLabel gunaLinkLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox kadiText;
        private Guna.UI2.WinForms.Guna2TextBox sifreText;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage kayitOl;
        private System.Windows.Forms.TabPage giris;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2TextBox kayitol_kadiText;
        private Guna.UI2.WinForms.Guna2TextBox kayitol_epostaText;
        private Guna.UI2.WinForms.Guna2TextBox kayitol_sifreText;
        private Guna.UI.WinForms.GunaButton btn_kayitOl;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLinkLabel gunaLinkLabel2;
    }
}

