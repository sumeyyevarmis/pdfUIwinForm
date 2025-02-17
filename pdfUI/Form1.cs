using PdfiumViewer;
using System.Text.RegularExpressions;

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

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Markdown Files (*.md)|*.md|All Files (*.*)|*.*";
            openFileDialog.Title = "MD Dosyası Seç";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string filePath = openFileDialog.FileName;
                    string fileContent = File.ReadAllText(filePath);
                    richTextBox2.Text = fileContent;

                    // Markdown içeriğini RTF formatına çevir ve önizleme için ekle
                    string markdownContent = File.ReadAllText(filePath);
                    richTextBox3.Rtf = ConvertMarkdownToRtf(markdownContent);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("File is not read: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private string ConvertMarkdownToRtf(string markdown)
        {
            // RTF Başlangıcı: Yazı tipi ve renk ayarlarını da ekleyelim
            string rtfHeader = @"{\rtf1\ansi\deff0{\colortbl;\red0\green0\blue0;\red255\green255\blue255;} ";
            // Markdown'ı RTF'ye çevirirken kullanılan dönüşümler: 
            // **Kalın** -> \b Kalın \b0
            markdown = Regex.Replace(markdown, @"\*\*(.*?)\*\*", @"\b\fs24 $1 \b0");

            // *İtalik* -> \i İtalik \i0
            markdown = Regex.Replace(markdown, @"\*(.*?)\*", @"\i\fs24 $1 \i0");

            // # Başlık -> \fs36 (Orta Boy Yazı), \cf2 (Kırmızı Renk), ve \b (Kalın)
            markdown = Regex.Replace(markdown, @"^# (.*?)$", @"\fs36\cf2\b $1 \b0\par", RegexOptions.Multiline);

            // Alt başlık için ## -> \fs24 (Küçük Yazı Boyutu), \cf2 (Kırmızı Renk), ve \b (Kalın)
            markdown = Regex.Replace(markdown, @"^## (.*?)$", @"\fs24\cf2\b $1 \b0\par", RegexOptions.Multiline);

            // Listeler için * -> \ul (Altı Çizili)
            markdown = Regex.Replace(markdown, @"^\* (.*?)$", @"\ul\fs24 $1 \ul0\par", RegexOptions.Multiline);

            // Satır içi metinlerdeki \par'ı ekleyelim ki her metin ve başlık ayrı bir satıra gelsin.
            markdown = markdown.Replace("\n", @"\par");


            // RTF Sonu
            return rtfHeader + markdown + "}";
        }


    }
}