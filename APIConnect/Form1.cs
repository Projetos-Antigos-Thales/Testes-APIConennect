using Newtonsoft.Json;
using APIConnect.Model;

namespace APIConnect
{
    public partial class APIConnect : Form
    {
        public APIConnect()
        {
            InitializeComponent();
        }

        private void APIConnect_Load(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
        }

        private void nET60ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
        }

        private void nET31ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            panel3.Visible = false;
        }

        private void nET22ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = true;
        }

        private void btnSearchFile1_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = "";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog1.FileName;
                }

                if (!filePath.Equals(""))
                {
                    string extension = filePath.Split(".").Last();
                    if (extension.Equals("json"))
                    {
                        PostmanCollection pCollection;
                        using (StreamReader r = new StreamReader(filePath))
                        {
                            string json = r.ReadToEnd();
                            pCollection = JsonConvert.DeserializeObject<PostmanCollection>(json);
                        }
                        if (pCollection != null)
                        {
                            #pragma warning disable CS8604 // Possible null reference argument.
                            MessageBox.Show(pCollection.Item.FirstOrDefault()?.Name);
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Extensão \".{extension}\" não permitida!");
                    }
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Arquivo não encontrado!");
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show("Diretório não existe!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro: {ex.Message}");
            }
        }

        private void btnSearchFile2_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = "";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog1.FileName;
                }

                if (!filePath.Equals(""))
                {
                    string extension = filePath.Split(".").Last();
                    if (extension.Equals("json"))
                    {
                        PostmanCollection pCollection;
                        using (StreamReader r = new StreamReader(filePath))
                        {
                            string json = r.ReadToEnd();
                            pCollection = JsonConvert.DeserializeObject<PostmanCollection>(json);
                        }
                        if (pCollection != null)
                        {
                            #pragma warning disable CS8604 // Possible null reference argument.
                            MessageBox.Show(pCollection.Item.FirstOrDefault()?.Name);
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Extensão \".{extension}\" não permitida!");
                    }
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Arquivo não encontrado!");
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show("Diretório não existe!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro: {ex.Message}");
            }

        }

        private void btnCreateClass_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }
    }
}