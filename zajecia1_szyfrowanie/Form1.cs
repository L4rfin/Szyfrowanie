

namespace zajecia1_szyfrowanie
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        string klucz = null;
        string iv = null;



        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string wybranaOpcja = (string)listBox1.Items[listBox1.SelectedIndex];
            label1.Text = wybranaOpcja;
            if (wybranaOpcja == "szyfr cezara")
            {
                numericUpDown1.Visible = true;
            }
            else numericUpDown1.Visible = false;
            if (wybranaOpcja == "MD5")
            {
                textBox1.Visible = true;
            }
            else textBox1.Visible = false;

        }



        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            string zawato��L = label2.Text;
            if ((string)listBox1.Items[listBox1.SelectedIndex] == "szyfr cezara")
            {
                SzyfrCezara szyfrCezara = new SzyfrCezara();
                int klucz = (int)numericUpDown1.Value;
                string zawarto��P = szyfrCezara.szyfrCezaraSzyfruj�cy(zawato��L, klucz);
                label1.Text = zawarto��P;
            }
            if ((string)listBox1.Items[listBox1.SelectedIndex] == "MD5")
            {
                MD5szyfr md5 = new MD5szyfr();
                string zawarto��P = md5.zaszyfrujMD5(zawato��L, textBox1.Text);
                label1.Text = zawarto��P;
            }




        }
        private void button2_Click(object sender, EventArgs e)
        {

            string zawato��L = label2.Text;
            if ((string)listBox1.Items[listBox1.SelectedIndex] == "szyfr cezara")
            {
                SzyfrCezara szyfrCezara = new SzyfrCezara();
                int klucz = (int)numericUpDown1.Value;
                string zawarto��L = szyfrCezara.szyfrCezaraDeszyfruj�cy(zawato��L, klucz);
                label1.Text = zawarto��L;
            }
            if ((string)listBox1.Items[listBox1.SelectedIndex] == "MD5")
            {
                MD5szyfr md5 = new MD5szyfr();
                string zawarto��L = md5.odSzyfrujMD5(zawato��L, textBox1.Text);
                label1.Text = zawarto��L;
            }

        }


        private void button5_Click(object sender, EventArgs e)
    {
        openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
        openFileDialog1.FilterIndex = 2;
        openFileDialog1.RestoreDirectory = true;
        openFileDialog1.FileName = "";
        if (openFileDialog1.ShowDialog() == DialogResult.OK)
        {
            label2.Text = openFileDialog1.FileName;
            var fileStream = openFileDialog1.OpenFile();
            using (StreamReader reader = new StreamReader(fileStream))
            {
                label2.Text = reader.ReadToEnd();
            }
        } 
        
    }
        private void button6_Click(object sender, EventArgs e)
        {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                saveFileDialog1.FilterIndex = 2;
                saveFileDialog1.RestoreDirectory = true;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    System.IO.File.WriteAllText(saveFileDialog1.FileName, label1.Text);
                    label1.Text = saveFileDialog1.FileName;
                }   
        }

        private void saveFileDialog2_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            
        }



    
    }
}


    
