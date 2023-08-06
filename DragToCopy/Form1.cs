namespace DragToCopy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.AllowDrop = true;
        }

        private void textBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }


        private void textBox1_DragDrop(object sender, DragEventArgs e)
        {
            string text = (string)e.Data.GetData(DataFormats.Text);
            Clipboard.SetText(text);
        }

    }
}