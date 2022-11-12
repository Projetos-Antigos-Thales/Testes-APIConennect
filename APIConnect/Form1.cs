using Newtonsoft.Json;
using APIConnect.Model;
using System.Text;
using System.Text.RegularExpressions;

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
                            GenerateConnection();
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
                            MessageBox.Show(pCollection.Item.FirstOrDefault()?.Name);
                            GenerateConnection();
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
            if (!txtClassName.Text.Equals("") && Regex.IsMatch(txtClassName.Text, @"^[a-zA-Z]+$"))
            {
                GenerateConnection();
            }
            else
            {
                MessageBox.Show("Informe um nome válido para a nova classe!");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void GenerateConnection()
        {
            try
            {
                string newClass = GenerateClass("string", "ClasseTeste", "string p1, int p2, bool p3");
                
                string selectedFolder = "";
                using (var fbd = new FolderBrowserDialog())
                {
                    DialogResult result = fbd.ShowDialog();

                    if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                    {
                        selectedFolder = fbd.SelectedPath;
                    }
                }
                if (!selectedFolder.Equals(""))
                {
                    using (FileStream fs = File.Create((selectedFolder + "\\") + (txtClassName.Text) + (".cs")))
                    {
                        byte[] info = new UTF8Encoding(true).GetBytes(newClass);
                        // Add some information to the file.
                        fs.Write(info, 0, info.Length);
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

        private string GenerateClass(string type, string className, string parameters)
        {
            string open1 = "{", close1 = "}";

            if (type.Equals("void"))
            {
                return $"private void {className}({parameters}){open1}{close1}";
            }
            else
            {
                string content = $"{type} result = null; return result;";
                return $"private {type} {className}({parameters}){open1}{content}{close1}";
            }
        }

    }
}