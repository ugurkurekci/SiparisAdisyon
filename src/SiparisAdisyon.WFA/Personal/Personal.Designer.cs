namespace SiparisAdisyon.WFA.Personal;

partial class Personal
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
        dataGridView1 = new DataGridView();
        topPanelPanel = new Panel();
        exitBtn = new Button();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        SuspendLayout();
        // 
        // dataGridView1
        // 
        dataGridView1.AllowUserToAddRows = false;
        dataGridView1.AllowUserToDeleteRows = false;
        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Location = new Point(0, 387);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.ReadOnly = true;
        dataGridView1.Size = new Size(1215, 332);
        dataGridView1.TabIndex = 1;
        dataGridView1.CellContentClick += dataGridView1_CellContentClick;
        // 
        // topPanelPanel
        // 
        topPanelPanel.Location = new Point(0, 0);
        topPanelPanel.Name = "topPanelPanel";
        topPanelPanel.Size = new Size(1155, 37);
        topPanelPanel.TabIndex = 8;
        topPanelPanel.MouseDown += topPanelPanel_MouseDown;
        topPanelPanel.MouseMove += topPanelPanel_MouseMove;
        topPanelPanel.MouseUp += topPanelPanel_MouseUp;
        // 
        // exitBtn
        // 
        exitBtn.Font = new Font("Arial", 12F);
        exitBtn.Location = new Point(1152, -1);
        exitBtn.Name = "exitBtn";
        exitBtn.Size = new Size(63, 38);
        exitBtn.TabIndex = 9;
        exitBtn.Text = "X";
        exitBtn.UseVisualStyleBackColor = true;
        exitBtn.Click += exitBtn_Click;
        // 
        // Personal
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1211, 718);
        Controls.Add(topPanelPanel);
        Controls.Add(exitBtn);
        Controls.Add(dataGridView1);
        FormBorderStyle = FormBorderStyle.None;
        Name = "Personal";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Personal";
        Load += Personal_Load;
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        ResumeLayout(false);
    }

    #endregion
    private DataGridView dataGridView1;
    private DataGridViewTextBoxColumn Id;
    private DataGridViewTextBoxColumn FullName;
    private DataGridViewTextBoxColumn Email;
    private DataGridViewTextBoxColumn Phone;
    private DataGridViewTextBoxColumn IsActive;
    private Panel topPanelPanel;
    private Button exitBtn;
}