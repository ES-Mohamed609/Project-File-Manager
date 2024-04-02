using System.IO;
namespace Project_File_Manager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void accbtn_Click(object sender, EventArgs e)
        {


            OpenFileDialog fileDialog = new OpenFileDialog();


            fileDialog.Title = "Select File";
            fileDialog.InitialDirectory = @"C:\";//--"C:\\;
            fileDialog.Filter = "All files (*.*)|*.*|Text File (*.txt)|.txt";
            fileDialog.FilterIndex = 2;
            fileDialog.ShowDialog();
            if (fileDialog.FileName != null)
            {
                textBox2.Text = fileDialog.FileName;
            }
            else
            {
                textBox2.Text = "you didn't select the file";
            }
            textBox2.Text = fileDialog.FileName;
            textBox1.Text= Path.GetFileName(fileDialog.FileName);
            /*  fileDialog.Multiselect = true;
           foreach(string file in fileDialog.FileNames)
           {
               MessageBox.Show(file);
           }*/


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_DragDrop(object sender, DragEventArgs e)
        {
            string[] strings = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            textBox2.Text = strings[0];
        }

        private void textBox2_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }
    }
}