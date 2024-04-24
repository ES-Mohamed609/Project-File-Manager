using System.IO;
using System.Windows.Forms;

namespace Project_File_Manager
{
    public partial class Form1 : Form
    {     
         
        FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           DialogResult S = MessageBox.Show(" Do you want to create folder folder", "confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
          if (S == DialogResult.Yes)
       {if (textBox2.Text != "" && textBox1.Text == "")
        {
         MessageBox.Show("enter name");

     }
     else if (textBox2.Text != "" && textBox1.Text != "")
     {
         Directory.CreateDirectory(textBox2.Text + textBox1.Text);
         textBox2.Text = "";
         textBox1.Text = "";

     }

    }
    else {
   try
    {
             // Specify the file name and create the file
             string fileName = Path.Combine(folderBrowserDialog1.SelectedPath, textBox1.Text);
             using (FileStream fs = File.Create(fileName))
             {
                 // You can write content to the file if needed
                 // For example:
                 //byte[] content = new System.Text.UTF8Encoding(true).GetBytes("This is some example content.");
                 //fs.Write(content, 0, content.Length);
             }
             MessageBox.Show("File created successfully at: " + fileName, "File Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
         textBox2.Text = "";
         textBox1.Text = "";

     }


     catch (Exception ex)
     {
         MessageBox.Show("Error creating file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
     }

 }

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            if (textBox2.Text != "" && textBox1.Text == "")
            {
                MessageBox.Show("enter name");

            }
            else if (textBox2.Text != "" && textBox1.Text != "")
            {
                string fristname = textBox2.Text;
                string secondName = textBox1.Text;
                Directory.Move(fristname, secondName);
                textBox2.Text = "";
                textBox1.Text = "";
               
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

       public string sourcName= "";
        private void  Delbtn_Click(object sender, EventArgs e)
        {
            if(file.Exists(sourcName)
           {
             file.Delete(sourcName);
            }
          if(Directory.Exists(sourcName)
           {
          Directory.Delete(sourcName);
           }
          else if(file.Exists(sourcName) == false || Directory.Exists(sourcName) == false)
          {  
          MessageBox.Show("It is already  not exist");
          } 
      
      public string sourceName="";
     public string destName="";
        private void  Movbtn_Click(object sender, EventArgs e)
        {
       try 
         {
          Directory.Move(sourceName , destName)
         }
         catch (IOException exp)
         {
           MessageBox.Show(exp.Message)
         }
        }


        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void accbtn_Click(object sender, EventArgs e)
        {


            DialogResult S = MessageBox.Show(" Do you want to open folder","confirmation",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (S == DialogResult.Yes)
            {   // FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
                folderBrowserDialog1 = new FolderBrowserDialog();

                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {

                    textBox2.Text = folderBrowserDialog1.SelectedPath;

                }
            }
            else
            {
                OpenFileDialog fileDialog = new OpenFileDialog();
                fileDialog.Title = "Select folder";
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
                textBox1.Text = Path.GetFileName(fileDialog.FileName);
            }


            /*fileDialog.Multiselect = true;
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
