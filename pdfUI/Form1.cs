using PdfiumViewer;

namespace pdfUI
{
    public partial class Form1 : Form
    {
        // private PdfViewer pdfViewer1; // PdfViewer bileşeni tanımlandı
        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PDF Files|*.pdf";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                PdfDocument pdfDoc = PdfDocument.Load(openFileDialog.FileName);
                pdfViewer1.Document = pdfDoc;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "")
                {
                    File.WriteAllText(textBox1.Text, richTextBox1.Text);
                    MessageBox.Show("File saved saccessfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Choose file path!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Choose new file path!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // OpenFileDialog nesnesi oluştur
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Markdown Files|*.md"; // Yalnızca .md dosyalarını seçme
            openFileDialog.Title = "Open Markdown File";

            // Eğer bir dosya seçildiyse
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Seçilen dosyanın tam yolunu TextBox'a yaz
                textBox1.Text = openFileDialog.FileName;
            }
        }
    }
}