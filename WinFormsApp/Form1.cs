using ClassLibrary.Data;
using ClassLibrary.Models;
using Microsoft.EntityFrameworkCore;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        private GolfContext db = new GolfContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            lbNames.DataSource
                = await db.Player.Select(x => x.Name)
                .OrderBy(x=>x)
                .ToListAsync();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            var id = await db.Player
                .Where(x => x.Name.Equals(lbNames.SelectedItem))
                .Select(x => x.Id)
                .FirstOrDefaultAsync();
            if (tbTour.Text != String.Empty)
            {
                string s = tbTour.Text + ";";
                s += id.ToString() + ";";
                s += tbR1.Text + ";";
                s += tbR2.Text + ";";
                s += tbR3.Text + ";";
                s += tbR4.Text;
                Result result = new Result(s);
                db.Result.Add(result);
                db.SaveChangesAsync();
                MessageBox.Show("Sikeres mentés!");
                tbR1.Text = "0";
                tbR2.Text = "0";
                tbR3.Text = "0";
                tbR4.Text = "0";

            }
            else
            {
                MessageBox.Show("Írd be a verseny megnevezését!");
            }
        }

        private void tbTour_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}