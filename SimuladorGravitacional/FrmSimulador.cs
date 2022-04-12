using SimuladorGravitacional.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimuladorGravitacional
{
    public partial class FrmSimulador : Form
    {
        Universo universo = new Universo();
        List<CorpoCelestial> corpoCelestiais = new List<CorpoCelestial>();
        
        public FrmSimulador()
        {
            InitializeComponent();
        }
    
        public void lerarquivo()
        {
            

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                corpoCelestiais.Clear();

                try
                {
                     universo = File.ReadAllLines(openFileDialog1.FileName, Encoding.GetEncoding("iso-8859-1"))
                              .Take(1)
                              .Select(a => a.Split(';'))
                              .Select(c => new Universo()
                              {
                                  QuantidadeCorpos = Convert.ToInt32(c[0]),
                                  QuantidadeIteracoes = Convert.ToInt32(c[1]),
                                  Tempo = Convert.ToInt32(c[2]),
                              })
                                .First();

                     corpoCelestiais = File.ReadAllLines(openFileDialog1.FileName, Encoding.GetEncoding("iso-8859-1"))
                               .Skip(1)
                               .Select(a => a.Split(';'))
                               .Select(c => new CorpoCelestial()
                               {
                                  Nome = c[0],
                                  Massa = Convert.ToDouble(c[1]),
                                  Raio = Convert.ToDouble(c[2]),
                                  PosX = Convert.ToDouble(c[3]), 
                                  PosY = Convert.ToDouble(c[4]),
                                  VelX = Convert.ToDouble(c[5]),
                                  VelY = Convert.ToDouble(c[6]), 
                               })
                                 .ToList();

                    DgvCorpos.DataSource = corpoCelestiais;
                    Lblqtcorpos.Text =Convert.ToString(universo.QuantidadeCorpos);
                    LblQtIteracoes.Text = Convert.ToString(universo.QuantidadeIteracoes);
                    LblTempo.Text = Convert.ToString(universo.Tempo);

                }
                catch (Exception)
                {
                    MessageBox.Show("Ops!. O arquivo não está conforme leiaute");
                }


            }

        }

        private void BtnCarregar_Click(object sender, EventArgs e)
        {
            lerarquivo();
        }
    }
}
