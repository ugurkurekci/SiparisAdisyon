namespace SiparisAdisyon.WFA.Login;

public partial class Login : Form
{
    public Login()
    {
        InitializeComponent();
    }

    private void Login_Load(object sender, EventArgs e)
    {

        if (this.Visible)
        {
            usernameTxb.Focus();
        }
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

    private void loginBtn_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(usernameTxb.Text) || string.IsNullOrEmpty(passwordTxb.Text))
        {
            MessageBox.Show("Kullanıcı adı ve şifre boş bırakılamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        else
        {
            if (usernameTxb.Text == "admin" && passwordTxb.Text == "admin")
            {
                this.Hide();
                Dashboard.Dashboard dashboard = new Dashboard.Dashboard();

                dashboard.Show();



               
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    private void passwordTxb_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            loginBtn_Click(sender, e);
        }
    }

    private void usernameTxb_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            loginBtn_Click(sender, e);
        }

    }

    private void usernameTxb_TextChanged(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(usernameTxb.Text))
        {
            usernameTxb.Text = "Kullanıcı Adı";
            usernameTxb.ForeColor = Color.Gray;
        }
    }

    private void exitBtn_MouseUp(object sender, MouseEventArgs e)
    {
        exitBtn.BackColor = Color.Transparent;
    }

    private void exitBtn_MouseEnter(object sender, EventArgs e)
    {
        exitBtn.BackColor = Color.Red;
    }

    private void exitBtn_MouseLeave(object sender, EventArgs e)
    {
        exitBtn.BackColor = Color.Transparent;
    }

    private void topPanelPanel_Paint(object sender, PaintEventArgs e)
    {

    }
}