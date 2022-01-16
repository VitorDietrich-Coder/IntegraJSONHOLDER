using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp;
using RestSharp.Deserializers;


namespace IntegraJSONHOLDER
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var client = new RestClient(string.Format("https://jsonplaceholder.typicode.com/todos/1"));
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);

            string userid = new JsonDeserializer().Deserialize<Busca>(response).userId;
            string id = new JsonDeserializer().Deserialize<Busca>(response).id;
            string title = new JsonDeserializer().Deserialize<Busca>(response).title;
            string completed = new JsonDeserializer().Deserialize<Busca>(response).completed;

            MessageBox.Show(userid + " /" + id + " /" + title + " /" + completed);
        }
    }
}
