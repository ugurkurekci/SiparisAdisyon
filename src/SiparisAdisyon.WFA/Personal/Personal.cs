using Newtonsoft.Json;
using SiparisAdisyon.WFA.Dtos;

namespace SiparisAdisyon.WFA.Personal;

public partial class Personal : Form
{




    public Personal()
    {
        InitializeComponent();     
    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
    }

    private void exitBtn_Click(object sender, EventArgs e)
    {
        if (MessageBox.Show("Çıkmak istediğinize emin misiniz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        {

            this.Hide();
            Dashboard.Dashboard dashboard = new Dashboard.Dashboard();
            dashboard.Show();
        }
    }


    private bool dragging = false;
    private Point dragCursorPoint;
    private Point dragFormPoint;

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

    private void topPanelPanel_MouseDown(object sender, MouseEventArgs e)
    {
        dragging = true;
        dragCursorPoint = Cursor.Position;
        dragFormPoint = this.Location;
    }

    private void topPanelPanel_MouseUp(object sender, MouseEventArgs e)
    {
        dragging = false;

    }


    private async void GetAllPersonalDetail()
    {
        HttpClient client = new HttpClient();
        client.BaseAddress = new Uri("https://localhost:7260/api/Auth/GetAllPersonalDetail");

        HttpResponseMessage response = await client.GetAsync(client.BaseAddress);

        if (response.IsSuccessStatusCode)
        {
            var result = await response.Content.ReadAsStringAsync();
            var personalDetailDtos = JsonConvert.DeserializeObject<List<PersonalDetailDto>>(result);
            if (personalDetailDtos.Count > 0)
            {
                dataGridView1.DataSource = personalDetailDtos;

            }

            if (dataGridView1.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (!Convert.ToBoolean(dataGridView1.Rows[i].Cells["IsActive"].Value))
                    {
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    }
                }
            }


        }


    }

    private void Personal_Load(object sender, EventArgs e)
    {

        GetAllPersonalDetail();
    }
}
