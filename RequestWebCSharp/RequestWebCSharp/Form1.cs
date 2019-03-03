using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RequestWebCSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EnviaRequisicaoGET();
        }
        public void EnviaRequisicaoGET()
        {
            var requisicaoWeb = WebRequest.CreateHttp("https://s3-sa-east-1.amazonaws.com/pontotel-docs/data.json");
            requisicaoWeb.Method = "GET";
            requisicaoWeb.UserAgent = "RequisicaoWebDemo";

            using (var resposta = requisicaoWeb.GetResponse())
            {
                var streamDados = resposta.GetResponseStream();
                StreamReader reader = new StreamReader(streamDados);
                object objResponse = reader.ReadToEnd();


                textBox1.Text = objResponse.ToString();
                streamDados.Close();
                resposta.Close();
            }
        }
    }
}
