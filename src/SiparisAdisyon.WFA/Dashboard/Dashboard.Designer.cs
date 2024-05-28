namespace SiparisAdisyon.WFA.Dashboard;

partial class Dashboard
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
        topPanelPanel = new Panel();
        exitBtn = new Button();
        tableTxb = new Button();
        personalTxb = new Button();
        stockTxb = new Button();
        productTxb = new Button();
        orderTxb = new Button();
        categoryTxb = new Button();
        authTxb = new Button();
        SuspendLayout();
        // 
        // topPanelPanel
        // 
        topPanelPanel.Location = new Point(-1, 0);
        topPanelPanel.Name = "topPanelPanel";
        topPanelPanel.Size = new Size(1092, 37);
        topPanelPanel.TabIndex = 6;
        topPanelPanel.MouseDown += topPanelPanel_MouseDown;
        topPanelPanel.MouseMove += topPanelPanel_MouseMove;
        topPanelPanel.MouseUp += topPanelPanel_MouseUp;
        // 
        // exitBtn
        // 
        exitBtn.Font = new Font("Arial", 12F);
        exitBtn.Location = new Point(1090, -1);
        exitBtn.Name = "exitBtn";
        exitBtn.Size = new Size(63, 38);
        exitBtn.TabIndex = 7;
        exitBtn.Text = "X";
        exitBtn.UseVisualStyleBackColor = true;
        exitBtn.Click += exitBtn_Click;
        // 
        // tableTxb
        // 
        tableTxb.BackColor = Color.White;
        tableTxb.FlatStyle = FlatStyle.System;
        tableTxb.Location = new Point(1002, 537);
        tableTxb.Name = "tableTxb";
        tableTxb.Size = new Size(138, 61);
        tableTxb.TabIndex = 8;
        tableTxb.Text = "MASALAR";
        tableTxb.UseVisualStyleBackColor = false;
        tableTxb.Click += tableTxb_Click;
        // 
        // personalTxb
        // 
        personalTxb.BackColor = Color.White;
        personalTxb.FlatStyle = FlatStyle.System;
        personalTxb.Location = new Point(12, 537);
        personalTxb.Name = "personalTxb";
        personalTxb.Size = new Size(138, 61);
        personalTxb.TabIndex = 9;
        personalTxb.Text = "PERSONELLER";
        personalTxb.UseVisualStyleBackColor = false;
        personalTxb.Click += personalTxb_Click;
        // 
        // stockTxb
        // 
        stockTxb.BackColor = Color.White;
        stockTxb.FlatStyle = FlatStyle.System;
        stockTxb.Location = new Point(721, 537);
        stockTxb.Name = "stockTxb";
        stockTxb.Size = new Size(138, 61);
        stockTxb.TabIndex = 10;
        stockTxb.Text = "STOKLAR";
        stockTxb.UseVisualStyleBackColor = false;
        // 
        // productTxb
        // 
        productTxb.BackColor = Color.White;
        productTxb.FlatStyle = FlatStyle.System;
        productTxb.Location = new Point(433, 537);
        productTxb.Name = "productTxb";
        productTxb.Size = new Size(138, 61);
        productTxb.TabIndex = 11;
        productTxb.Text = "ÜRÜNLER";
        productTxb.UseVisualStyleBackColor = false;
        // 
        // orderTxb
        // 
        orderTxb.BackColor = Color.White;
        orderTxb.FlatStyle = FlatStyle.System;
        orderTxb.Location = new Point(577, 537);
        orderTxb.Name = "orderTxb";
        orderTxb.Size = new Size(138, 61);
        orderTxb.TabIndex = 12;
        orderTxb.Text = "SİPARİŞLER";
        orderTxb.UseVisualStyleBackColor = false;
        // 
        // categoryTxb
        // 
        categoryTxb.BackColor = Color.White;
        categoryTxb.FlatStyle = FlatStyle.System;
        categoryTxb.Location = new Point(12, 403);
        categoryTxb.Name = "categoryTxb";
        categoryTxb.Size = new Size(138, 61);
        categoryTxb.TabIndex = 13;
        categoryTxb.Text = "KATEGORİLER";
        categoryTxb.UseVisualStyleBackColor = false;
        // 
        // authTxb
        // 
        authTxb.BackColor = Color.White;
        authTxb.FlatStyle = FlatStyle.System;
        authTxb.Location = new Point(12, 470);
        authTxb.Name = "authTxb";
        authTxb.Size = new Size(138, 61);
        authTxb.TabIndex = 14;
        authTxb.Text = "YETKİLER";
        authTxb.UseVisualStyleBackColor = false;
        // 
        // Dashboard
        // 
        AutoScaleDimensions = new SizeF(8F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(1152, 610);
        Controls.Add(authTxb);
        Controls.Add(categoryTxb);
        Controls.Add(orderTxb);
        Controls.Add(productTxb);
        Controls.Add(stockTxb);
        Controls.Add(personalTxb);
        Controls.Add(tableTxb);
        Controls.Add(topPanelPanel);
        Controls.Add(exitBtn);
        Font = new Font("Arial", 11F);
        FormBorderStyle = FormBorderStyle.None;
        Name = "Dashboard";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Dashboard";
        ResumeLayout(false);
    }

    #endregion

    private Panel topPanelPanel;
    private Button exitBtn;
    private Button tableTxb;
    private Button personalTxb;
    private Button stockTxb;
    private Button productTxb;
    private Button orderTxb;
    private Button categoryTxb;
    private Button authTxb;
}