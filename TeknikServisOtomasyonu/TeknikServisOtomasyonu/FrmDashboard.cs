using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TeknikServisOtomasyonu
{
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            dataGridView2.Rows.Add("Ahmet Yılmaz", "iPhone 13", "15.10.2026");
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text))
            {
                string bugununTarihi = DateTime.Now.ToString("dd.MM.yyyy");

                // 2. Veriyi tabloya ekle
                dataGridView2.Rows.Add(textBox1.Text, textBox2.Text, bugununTarihi);

                // 3. İŞTE BURASI ÖNEMLİ: Sadece eklendikten sonra temizle!
                textBox1.Clear();
                textBox2.Clear();

                MessageBox.Show("Kayıt başarıyla eklendi!", "Bilgi");
            }
            else
            {
                MessageBox.Show("Lütfen tüm alanları doldurun!");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Tıklanan yerin geçerli bir satır olduğundan emin olalım
            if (e.RowIndex >= 0)
            {
                // --- 1. SİLME İŞLEMİ (Daha önce yaptığımız) ---
                if (dataGridView2.Columns[e.ColumnIndex].Name == "colSil")
                {
                    DialogResult cevap = MessageBox.Show("Bu arıza kaydını silmek istediğinize emin misiniz?", "Kayıt Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (cevap == DialogResult.Yes)
                    {
                        dataGridView2.Rows.RemoveAt(e.RowIndex);
                    }
                }

                // --- 2. GÜNCELLEME İŞLEMİ (Yeni eklediğimiz) ---
                if (dataGridView2.Columns[e.ColumnIndex].Name == "colGuncelle")
                {
                    // Tablodaki verileri sağdaki TextBox'lara aktarıyoruz
                    // DİKKAT: txtMusteri ve txtCihaz yazan yerlere kendi kutularının adını yaz!

                    txtMusteri.Text = dataGridView2.Rows[e.RowIndex].Cells["colMusteri"].Value.ToString();
                    txtCihaz.Text = dataGridView2.Rows[e.RowIndex].Cells["colCihaz"].Value.ToString();

                    // Kullanıcıya ne yapması gerektiğini söyleyelim
                    MessageBox.Show("Müşteri bilgileri sağdaki kutulara aktarıldı. Bilgileri değiştirip 'Kaydet' yapabilirsiniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {
          
        }
    }
}
