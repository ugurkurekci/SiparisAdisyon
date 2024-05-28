namespace SiparisAdisyon.WFA.Login;

partial class Login
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
        usernameTxb = new TextBox();
        passwordTxb = new TextBox();
        usernameLbl = new Label();
        passwordLbl = new Label();
        loginBtn = new Button();
        exitBtn = new Button();
        panel1 = new Panel();
        pictureBox1 = new PictureBox();
        checkBox1 = new CheckBox();
        topPanelPanel = new Panel();
        panel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        SuspendLayout();
        // 
        // usernameTxb
        // 
        usernameTxb.Font = new Font("Calibri", 12F);
        usernameTxb.Location = new Point(551, 181);
        usernameTxb.Name = "usernameTxb";
        usernameTxb.Size = new Size(347, 27);
        usernameTxb.TabIndex = 0;
        usernameTxb.TextChanged += usernameTxb_TextChanged;
        usernameTxb.KeyDown += usernameTxb_KeyDown;
        // 
        // passwordTxb
        // 
        passwordTxb.Font = new Font("Calibri", 12F);
        passwordTxb.Location = new Point(551, 246);
        passwordTxb.Name = "passwordTxb";
        passwordTxb.PasswordChar = '*';
        passwordTxb.Size = new Size(347, 27);
        passwordTxb.TabIndex = 1;
        passwordTxb.UseSystemPasswordChar = true;
        passwordTxb.KeyDown += passwordTxb_KeyDown;
        // 
        // usernameLbl
        // 
        usernameLbl.AutoSize = true;
        usernameLbl.Font = new Font("Calibri", 12F, FontStyle.Bold);
        usernameLbl.ForeColor = SystemColors.ControlText;
        usernameLbl.Location = new Point(551, 159);
        usernameLbl.Name = "usernameLbl";
        usernameLbl.Size = new Size(174, 19);
        usernameLbl.TabIndex = 2;
        usernameLbl.Text = "HESAP ADI İLE GİRİŞ YAP";
        // 
        // passwordLbl
        // 
        passwordLbl.AutoSize = true;
        passwordLbl.Font = new Font("Calibri", 12F, FontStyle.Bold);
        passwordLbl.ForeColor = SystemColors.ControlText;
        passwordLbl.Location = new Point(551, 224);
        passwordLbl.Name = "passwordLbl";
        passwordLbl.Size = new Size(64, 19);
        passwordLbl.TabIndex = 3;
        passwordLbl.Text = "PAROLA";
        // 
        // loginBtn
        // 
        loginBtn.BackColor = SystemColors.HotTrack;
        loginBtn.Font = new Font("Arial", 12F);
        loginBtn.ForeColor = Color.White;
        loginBtn.Location = new Point(764, 299);
        loginBtn.Name = "loginBtn";
        loginBtn.Size = new Size(134, 42);
        loginBtn.TabIndex = 4;
        loginBtn.Text = "Login";
        loginBtn.UseVisualStyleBackColor = false;
        loginBtn.Click += loginBtn_Click;
        // 
        // exitBtn
        // 
        exitBtn.Font = new Font("Arial", 12F);
        exitBtn.Location = new Point(910, -1);
        exitBtn.Name = "exitBtn";
        exitBtn.Size = new Size(63, 38);
        exitBtn.TabIndex = 5;
        exitBtn.Text = "X";
        exitBtn.UseVisualStyleBackColor = true;
        exitBtn.Click += exitBtn_Click;
        exitBtn.MouseEnter += exitBtn_MouseEnter;
        exitBtn.MouseLeave += exitBtn_MouseLeave;
        exitBtn.MouseUp += exitBtn_MouseUp;
        // 
        // panel1
        // 
        panel1.Controls.Add(pictureBox1);
        panel1.Location = new Point(0, -1);
        panel1.Name = "panel1";
        panel1.Size = new Size(506, 522);
        panel1.TabIndex = 8;
        // 
        // pictureBox1
        // 
        pictureBox1.Dock = DockStyle.Fill;
        pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
        pictureBox1.Location = new Point(0, 0);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(506, 522);
        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox1.TabIndex = 0;
        pictureBox1.TabStop = false;
        // 
        // checkBox1
        // 
        checkBox1.AutoSize = true;
        checkBox1.Location = new Point(551, 290);
        checkBox1.Name = "checkBox1";
        checkBox1.Size = new Size(87, 19);
        checkBox1.TabIndex = 9;
        checkBox1.Text = "Beni Hatırla";
        checkBox1.UseVisualStyleBackColor = true;
        // 
        // topPanelPanel
        // 
        topPanelPanel.Location = new Point(512, 0);
        topPanelPanel.Name = "topPanelPanel";
        topPanelPanel.Size = new Size(399, 37);
        topPanelPanel.TabIndex = 0;
        topPanelPanel.MouseDown += topPanelPanel_MouseDown;
        topPanelPanel.MouseMove += topPanelPanel_MouseMove;
        topPanelPanel.MouseUp += topPanelPanel_MouseUp;
        // 
        // Login
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(972, 519);
        Controls.Add(topPanelPanel);
        Controls.Add(checkBox1);
        Controls.Add(panel1);
        Controls.Add(exitBtn);
        Controls.Add(loginBtn);
        Controls.Add(passwordLbl);
        Controls.Add(usernameLbl);
        Controls.Add(passwordTxb);
        Controls.Add(usernameTxb);
        FormBorderStyle = FormBorderStyle.None;
        Name = "Login";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Login";
        Load += Login_Load;
        panel1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox usernameTxb;
    private TextBox passwordTxb;
    private Label usernameLbl;
    private Label passwordLbl;
    private Button loginBtn;
    private Button exitBtn;
    private Panel panel1;
    private PictureBox pictureBox1;
    private CheckBox checkBox1;
    private Panel topPanelPanel;
}