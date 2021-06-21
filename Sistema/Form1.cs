using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO.Ports;
using System.IO;
using System.IO.Compression;
using System.Net.Cache;

namespace Sistema
{
    public partial class Form1 : Form
    {
        public Form1()
        {
        InitializeComponent();

        String caminhot = AppDomain.CurrentDomain.BaseDirectory;
            try
            {

            StreamReader lerserver = new StreamReader (caminhot + @"\server.log");
            sever.Text = lerserver.ReadToEnd();
            lerserver.Close();

            StreamReader leruser = new StreamReader(caminhot + @"\user.log");
            user.Text = leruser.ReadToEnd();
            leruser.Close();

            StreamReader sr = new StreamReader(caminhot + @"\port.log");
            porta.Text = sr.ReadToEnd();
            sr.Close();
               
            }
            catch
            {
                
            }
            try
            {
            StreamReader lercaminho = new StreamReader(caminhot + @"\caminho.log");
            caminho.Text = lercaminho.ReadToEnd();
            lercaminho.Close();
            }
            catch
            {

            }

        //--------------------CAMINHO UPDATE------------------//
        String ucaminhot = AppDomain.CurrentDomain.BaseDirectory;
            try
            {

            StreamReader ulerserver = new StreamReader(ucaminhot + @"\userver.log");
            usever.Text = ulerserver.ReadToEnd();
            ulerserver.Close();

            StreamReader uleruser = new StreamReader(ucaminhot + @"\uuser.log");
            uuser.Text = uleruser.ReadToEnd();
            uleruser.Close();

            StreamReader usr = new StreamReader(ucaminhot + @"\uport.log");
            uporta.Text = usr.ReadToEnd();
            usr.Close();
            }
            catch
            {
            }

            try
            {
            StreamReader ulercaminho = new StreamReader(ucaminhot + @"\ucaminho.log");
            ucaminho.Text = ulercaminho.ReadToEnd();
            ulercaminho.Close();
            }
            catch
            {        
            }
        //--------------------FIM CAMINHO UPDATE------------------//

        }

    private void button2_Click(object sender, EventArgs e)
        {

        String caminhot = AppDomain.CurrentDomain.BaseDirectory;

        StreamWriter escrevercaminho = new StreamWriter(caminhot + @"\caminho.log", false);
        escrevercaminho.WriteLine(caminho.Text);
        escrevercaminho.Close();
            
        DialogResult dr = MessageBox.Show(" Quer fazer o backup desse banco?\n->" + comboBox1.Text + "\n Isso pode levar um tempo",
        "Banco selecionado!", MessageBoxButtons.YesNo);
            switch (dr)
            {
            case DialogResult.Yes:

            string nomesever = (string)sever.Text;
            string nomeuser = (string)user.Text;
            string senha = (string)pass.Text;

            if (!Directory.Exists(caminho.Text + @"\Dumps\Arquivo_SQL"))

                Directory.CreateDirectory(caminho.Text + @"\Dumps\Arquivo_SQL");


            var currentDateTime = DateTime.Now;

                string data = DateTime.Now.ToString("dd-MM-yyyy");
                {

                string file = caminho.Text + @"\Dumps\Arquivo_SQL\" + comboBox1.Text + data + ".sql";//cria sql
                string MySqlDatabase = comboBox1.Text + data + ".sql";
                    using (MySqlConnection cn = new MySqlConnection())
                    {

                    cn.ConnectionString = ("server=" + nomesever + "; Port="+porta.Text+" ; pwd=" + senha + ";database=" + comboBox1.Text + "; uid=" + nomeuser + "; SslMode=none;charset=utf8;convertzerodatetime=true;");
                    
                        using (MySqlCommand cmd = new MySqlCommand())
                        {
                            using (MySqlBackup mb = new MySqlBackup(cmd))
                            {
                      
                            MessageBox.Show("fazendo backup");
                            processo.Visible = true;
                            processo.Value = 10;
                            cmd.Connection = cn;
                            processo.Value = 20;
                            cn.Open();
                            processo.Value = 50;
                               
                                
                            processo.Value = 65;
                            mb.ExportToFile(file); //exporta o arquivo pra máquina
                               
                            processo.Value = 80;
                            cn.Close();
                            processo.Value = 90;
                     
                            string startPath = caminho.Text + @"\Dumps\Arquivo_SQL";
                            
                            processo.Value = 100;
                               
                      
                            }
                        }
                    }
                }

            MessageBox.Show("backup feito");
            break;
            case DialogResult.No:
            break;
            }
        }

    private void button1_Click(object sender, EventArgs e)
    {
    string nomesever = (string)sever.Text;
    string nomeuser = (string)user.Text;
    string senha = (string)pass.Text;

        try
        {

            MySqlConnection cn = new MySqlConnection();
            cn.ConnectionString = ("server=" + nomesever + "; Port=" + porta.Text + " ; pwd=" + senha + "; uid=" + nomeuser + "; SslMode=none;charset=utf8;convertzerodatetime=true;");
            cn.Open();
            MySqlCommand com = new MySqlCommand();
            com.Connection = cn;
            com.CommandText = "Show databases";
            MySqlDataReader dr = com.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            comboBox1.DisplayMember = "Database";
            comboBox1.DataSource = dt;
            cn.Close();

            MessageBox.Show("conectado, Selecione o banco");

            String caminhot = AppDomain.CurrentDomain.BaseDirectory;

            StreamWriter escreverserver = new StreamWriter(caminhot + @"\server.log", false);
            escreverserver.WriteLine(sever.Text);
            escreverserver.Close();

            StreamWriter escreveruser = new StreamWriter(caminhot + @"\user.log", false);
            escreveruser.WriteLine(user.Text);
            escreveruser.Close();

            StreamWriter escreverporta = new StreamWriter(caminhot + @"\port.log", false);
            escreverporta.WriteLine(porta.Text);
            escreverporta.Close();
        }
        catch
        {
            MessageBox.Show("Não conectado! \n verifique se os dados estão corretos.");
        }
    }

    private void clear_Click(object sender, EventArgs e)
    {
        sever.Text = "";
        user.Text = "";
        pass.Text = "";
        porta.Text = "";
        comboBox1.Text = "";
        caminho.Text = "";
        BT_Backup.Visible = false;
    }

    private void Busca_Click(object sender, EventArgs e)
    {
        FolderBrowserDialog busca = new FolderBrowserDialog();
        busca.RootFolder = Environment.SpecialFolder.Desktop;
        busca.Description = "Selecione a pasta desejada para armazear o backup do banco de dados";
        busca.ShowNewFolderButton = false;

        if (busca.ShowDialog() == DialogResult.OK)
        {
            caminho.Text = busca.SelectedPath;

        }
        BT_Backup.Visible = true;
    }

    //------------------------------------------UPDATE-------------------------------------------------------\\

    private void uclear_Click(object sender, EventArgs e)
    {
        usever.Text = "";
        uuser.Text = "";
        upass.Text = "";
        uporta.Text = "";
        ucomboBox1.Text = "";
        ucaminho.Text = "";
        BT_update.Visible = false;
        uprocesso.Value = 0;
        uprocesso.Visible = false;
    }

    private void uconect_Click_1(object sender, EventArgs e)
    {
        string unomesever = (string)usever.Text;
        string unomeuser = (string)uuser.Text;
        string usenha = (string)upass.Text;

        try
        {

            MySqlConnection ucn = new MySqlConnection();
            ucn.ConnectionString = ("server=" + unomesever + "; Port=" + uporta.Text + " ; pwd=" + usenha + "; uid=" + unomeuser + "; SslMode=none;charset=utf8;convertzerodatetime=true;");
            ucn.Open();
            MySqlCommand ucom = new MySqlCommand();
            ucom.Connection = ucn;
            ucom.CommandText = "Show databases";
            MySqlDataReader udr = ucom.ExecuteReader();
            DataTable udt = new DataTable();
            udt.Load(udr);
            ucomboBox1.DisplayMember = "Database";
            ucomboBox1.DataSource = udt;
            ucn.Close();

            MessageBox.Show("conectado, Selecione o banco");

            String ucaminhot = AppDomain.CurrentDomain.BaseDirectory;

            StreamWriter uescreverserver = new StreamWriter(ucaminhot + @"\userver.log", false);
            uescreverserver.WriteLine(sever.Text);
            uescreverserver.Close();

            StreamWriter uescreveruser = new StreamWriter(ucaminhot + @"\uuser.log", false);
            uescreveruser.WriteLine(uuser.Text);
            uescreveruser.Close();

            StreamWriter uescreverporta = new StreamWriter(ucaminhot + @"\uport.log", false);
            uescreverporta.WriteLine(uporta.Text);
            uescreverporta.Close();

            BT_update.Visible = true;
        }
        catch
        {
            MessageBox.Show("Não conectado! \n verifique se os dados estão corretos.");
        }
    }

    private void uBusca_Click(object sender, EventArgs e)
    {
        OpenFileDialog fdlg = new OpenFileDialog();
        fdlg.Title = "Selecione o arquivo para fazer update";
        fdlg.InitialDirectory = @"c:\";
        fdlg.Filter = "All files (*.*)|*.*|Arquivos de banco (.sql)|*.sql*";
        fdlg.FilterIndex = 2;
        fdlg.RestoreDirectory = true;
        if (fdlg.ShowDialog() == DialogResult.OK)
        {
            ucaminho.Text = fdlg.FileName;
        }
    }
    private void BT_update_Click(object sender, EventArgs e)
    {
        String ucaminhot = AppDomain.CurrentDomain.BaseDirectory;

        StreamWriter uescrevercaminho = new StreamWriter(ucaminhot + @"\ucaminho.log", false);
        uescrevercaminho.WriteLine(ucaminho.Text);
        uescrevercaminho.Close();
        DialogResult udr = MessageBox.Show(" Quer mesmo sobrepor esse banco?\n->" + ucomboBox1.Text + "\n Isso irá levar um tempo e vai sobrepor o banco selecionado!",
        "Sobrepor Banco!", MessageBoxButtons.YesNo);
        switch (udr)
        {
            case DialogResult.Yes:

            string unomesever = (string)usever.Text;
            string unomeuser = (string)uuser.Text;
            string usenha = (string)upass.Text;
            string ubanco = (string)ucomboBox1.Text;
       
            uprocesso.Visible = true;
            uprocesso.Value = 10;
            string constring = ("server=" + unomesever + "; Port=" + uporta.Text + " ; pwd=" + usenha + "; uid=" + unomeuser + ";SslMode=none;database="+ubanco+";");
            uprocesso.Value = 30;

            string file = ucaminho.Text;
            uprocesso.Value = 40;
            using (MySqlConnection conn = new MySqlConnection(constring))
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    using (MySqlBackup mb = new MySqlBackup(cmd))
                    {
                            uprocesso.Value = 50;
                            cmd.Connection = conn;
                            uprocesso.Value = 70;
                            conn.Open();
                            uprocesso.Value = 80;
                            mb.ImportFromFile(file);
                            uprocesso.Value = 90;
                            conn.Close();
                    }
                }
                uprocesso.Value = 100;
                MessageBox.Show("Restauração concluida");
            }
        break;
        case DialogResult.No:
        break;
        }
    }
    private void tabPage1_Click(object sender, EventArgs e)
    {

    }
  }       
}