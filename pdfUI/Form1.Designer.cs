namespace pdfUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1=new Panel();
            tabControl1=new TabControl();
            tabPage1=new TabPage();
            tableLayoutPanel2=new TableLayoutPanel();
            tableLayoutPanel3=new TableLayoutPanel();
            richTextBox1=new RichTextBox();
            panel2=new Panel();
            button3=new Button();
            label1=new Label();
            textBox1=new TextBox();
            button2=new Button();
            button1=new Button();
            pdfViewer1=new PdfiumViewer.PdfViewer();
            tabPage2=new TabPage();
            tableLayoutPanel1=new TableLayoutPanel();
            tableLayoutPanel4=new TableLayoutPanel();
            panel3=new Panel();
            button4=new Button();
            richTextBox2=new RichTextBox();
            panel4=new Panel();
            richTextBox3=new RichTextBox();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel2.SuspendLayout();
            tabPage2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor=Color.FromArgb(35, 35, 35);
            panel1.Controls.Add(tabControl1);
            panel1.Dock=DockStyle.Fill;
            panel1.Location=new Point(0, 0);
            panel1.Name="panel1";
            panel1.Size=new Size(1148, 601);
            panel1.TabIndex=0;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Cursor=Cursors.SizeAll;
            tabControl1.Dock=DockStyle.Fill;
            tabControl1.Location=new Point(0, 0);
            tabControl1.Name="tabControl1";
            tabControl1.SelectedIndex=0;
            tabControl1.Size=new Size(1148, 601);
            tabControl1.TabIndex=0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor=Color.FromArgb(35, 35, 35);
            tabPage1.Controls.Add(tableLayoutPanel2);
            tabPage1.Location=new Point(4, 24);
            tabPage1.Name="tabPage1";
            tabPage1.Padding=new Padding(3);
            tabPage1.Size=new Size(1140, 573);
            tabPage1.TabIndex=0;
            tabPage1.Text="tabPage1";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount=2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel2.Controls.Add(pdfViewer1, 1, 0);
            tableLayoutPanel2.Dock=DockStyle.Fill;
            tableLayoutPanel2.Location=new Point(3, 3);
            tableLayoutPanel2.Name="tableLayoutPanel2";
            tableLayoutPanel2.RowCount=1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size=new Size(1134, 567);
            tableLayoutPanel2.TabIndex=0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount=1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(richTextBox1, 0, 1);
            tableLayoutPanel3.Controls.Add(panel2, 0, 0);
            tableLayoutPanel3.Dock=DockStyle.Fill;
            tableLayoutPanel3.Location=new Point(3, 3);
            tableLayoutPanel3.Name="tableLayoutPanel3";
            tableLayoutPanel3.RowCount=2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 18.181818F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 81.8181839F));
            tableLayoutPanel3.Size=new Size(561, 561);
            tableLayoutPanel3.TabIndex=0;
            tableLayoutPanel3.Paint+=tableLayoutPanel3_Paint;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor=SystemColors.InfoText;
            richTextBox1.Dock=DockStyle.Fill;
            richTextBox1.ForeColor=Color.White;
            richTextBox1.Location=new Point(3, 105);
            richTextBox1.Name="richTextBox1";
            richTextBox1.Size=new Size(555, 453);
            richTextBox1.TabIndex=0;
            richTextBox1.Text="";
            // 
            // panel2
            // 
            panel2.Controls.Add(button3);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Dock=DockStyle.Fill;
            panel2.Location=new Point(3, 3);
            panel2.Name="panel2";
            panel2.Size=new Size(555, 96);
            panel2.TabIndex=0;
            // 
            // button3
            // 
            button3.Location=new Point(85, 32);
            button3.Name="button3";
            button3.Size=new Size(75, 23);
            button3.TabIndex=4;
            button3.Text="choose";
            button3.UseVisualStyleBackColor=true;
            button3.Click+=button3_Click;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.ForeColor=Color.White;
            label1.Location=new Point(6, 43);
            label1.Name="label1";
            label1.Size=new Size(73, 15);
            label1.TabIndex=3;
            label1.Text="md File Path";
            // 
            // textBox1
            // 
            textBox1.BackColor=Color.Black;
            textBox1.ForeColor=Color.White;
            textBox1.Location=new Point(6, 61);
            textBox1.Name="textBox1";
            textBox1.Size=new Size(546, 23);
            textBox1.TabIndex=2;
            // 
            // button2
            // 
            button2.Location=new Point(84, 3);
            button2.Name="button2";
            button2.Size=new Size(75, 23);
            button2.TabIndex=1;
            button2.Text="Save";
            button2.UseVisualStyleBackColor=true;
            button2.Click+=button2_Click;
            // 
            // button1
            // 
            button1.Location=new Point(3, 3);
            button1.Name="button1";
            button1.Size=new Size(75, 23);
            button1.TabIndex=0;
            button1.Text="Open PDF";
            button1.UseVisualStyleBackColor=true;
            button1.Click+=button1_Click;
            // 
            // pdfViewer1
            // 
            pdfViewer1.BackColor=SystemColors.WindowFrame;
            pdfViewer1.Dock=DockStyle.Fill;
            pdfViewer1.Location=new Point(571, 3);
            pdfViewer1.Margin=new Padding(4, 3, 4, 3);
            pdfViewer1.Name="pdfViewer1";
            pdfViewer1.ShowToolbar=false;
            pdfViewer1.Size=new Size(559, 561);
            pdfViewer1.TabIndex=1;
            // 
            // tabPage2
            // 
            tabPage2.BackColor=Color.FromArgb(35, 35, 35);
            tabPage2.Controls.Add(tableLayoutPanel1);
            tabPage2.Location=new Point(4, 24);
            tabPage2.Name="tabPage2";
            tabPage2.Padding=new Padding(3);
            tabPage2.Size=new Size(1140, 573);
            tabPage2.TabIndex=1;
            tabPage2.Text="tabPage2";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount=2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 0, 0);
            tableLayoutPanel1.Controls.Add(panel4, 1, 0);
            tableLayoutPanel1.Dock=DockStyle.Fill;
            tableLayoutPanel1.Location=new Point(3, 3);
            tableLayoutPanel1.Name="tableLayoutPanel1";
            tableLayoutPanel1.RowCount=1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size=new Size(1134, 567);
            tableLayoutPanel1.TabIndex=0;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount=1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(panel3, 0, 0);
            tableLayoutPanel4.Controls.Add(richTextBox2, 0, 1);
            tableLayoutPanel4.Dock=DockStyle.Fill;
            tableLayoutPanel4.Location=new Point(3, 3);
            tableLayoutPanel4.Name="tableLayoutPanel4";
            tableLayoutPanel4.RowCount=2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 14.6167555F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 85.38325F));
            tableLayoutPanel4.Size=new Size(561, 561);
            tableLayoutPanel4.TabIndex=0;
            // 
            // panel3
            // 
            panel3.Controls.Add(button4);
            panel3.Dock=DockStyle.Fill;
            panel3.Location=new Point(3, 3);
            panel3.Name="panel3";
            panel3.Size=new Size(555, 76);
            panel3.TabIndex=0;
            // 
            // button4
            // 
            button4.Location=new Point(3, 3);
            button4.Name="button4";
            button4.Size=new Size(75, 23);
            button4.TabIndex=1;
            button4.Text="Open md";
            button4.UseVisualStyleBackColor=true;
            button4.Click+=button4_Click;
            // 
            // richTextBox2
            // 
            richTextBox2.BackColor=Color.Black;
            richTextBox2.Dock=DockStyle.Fill;
            richTextBox2.ForeColor=Color.White;
            richTextBox2.Location=new Point(3, 85);
            richTextBox2.Name="richTextBox2";
            richTextBox2.Size=new Size(555, 473);
            richTextBox2.TabIndex=1;
            richTextBox2.Text="";
            // 
            // panel4
            // 
            panel4.BackColor=SystemColors.WindowFrame;
            panel4.Controls.Add(richTextBox3);
            panel4.Dock=DockStyle.Fill;
            panel4.Location=new Point(570, 3);
            panel4.Name="panel4";
            panel4.Size=new Size(561, 561);
            panel4.TabIndex=1;
            // 
            // richTextBox3
            // 
            richTextBox3.BackColor=Color.Black;
            richTextBox3.Dock=DockStyle.Fill;
            richTextBox3.ForeColor=Color.White;
            richTextBox3.Location=new Point(0, 0);
            richTextBox3.Name="richTextBox3";
            richTextBox3.Size=new Size(561, 561);
            richTextBox3.TabIndex=2;
            richTextBox3.Text="";
            // 
            // Form1
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(1148, 601);
            Controls.Add(panel1);
            Name="Form1";
            StartPosition=FormStartPosition.CenterScreen;
            Text="Form1";
            panel1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tabPage2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private PdfiumViewer.PdfViewer pdfViewer1;
        private RichTextBox richTextBox1;
        private Panel panel2;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private Label label1;
        private Button button3;
        private TableLayoutPanel tableLayoutPanel4;
        private Panel panel3;
        private RichTextBox richTextBox2;
        private Button button4;
        private Panel panel4;
        private RichTextBox richTextBox3;
    }
}