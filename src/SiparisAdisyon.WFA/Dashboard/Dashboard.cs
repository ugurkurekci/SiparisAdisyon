namespace SiparisAdisyon.WFA.Dashboard;

public partial class Dashboard : Form
{
    public Dashboard()
    {
        InitializeComponent();
    }

    private void exitBtn_Click(object sender, EventArgs e)
    {
        if (MessageBox.Show("Çıkmak istediğinize emin misiniz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        {
            Application.Exit();
        }
    }

    private bool dragging = false;
    private Point dragCursorPoint;
    private Point dragFormPoint;

    private void topPanelPanel_MouseDown(object sender, MouseEventArgs e)
    {
        dragging = true;
        dragCursorPoint = Cursor.Position;
        dragFormPoint = this.Location;
    }

    private void topPanelPanel_MouseMove(object sender, MouseEventArgs e)
    {
        if (dragging)
        {
            Point currentScreenPos = Cursor.Position;
            this.Location = new Point(
                dragFormPoint.X + (currentScreenPos.X - dragCursorPoint.X),
                dragFormPoint.Y + (currentScreenPos.Y - dragCursorPoint.Y)
            );
        }
    }

    private void topPanelPanel_MouseUp(object sender, MouseEventArgs e)
    {
        dragging = false;
    }

    private void tableTxb_Click(object sender, EventArgs e)
    {
        // Table formunu aç
    }

    private void personalTxb_Click(object sender, EventArgs e)
    {
        // Personal formunu aç
        this.Hide();
        Personal.Personal personal = new Personal.Personal();
        personal.Show();

    }
}
