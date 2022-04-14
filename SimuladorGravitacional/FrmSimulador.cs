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
        private const int cGrip = 16;      // Grip size
        private const int cCaption = 25;   // Caption bar height;
        bool mover = false;
        Point posicao_inicial;

        Universo universo = new Universo();
        List<CorpoCelestial> corpoCelestiais = new List<CorpoCelestial>();
        List<CorpoCelestial> corpoCelestiaisiteracao = new List<CorpoCelestial>();

        public FrmSimulador()
        {
            InitializeComponent();
            InicialDesign();
            DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }
        
        public void InicialDesign()
        {
            BtnSimular.Visible = false;
            label1.Visible = false; 
            label2.Visible = false;
            label3.Visible = false;
            BtnCarregar2.Visible = false;


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
                                  Tempo = Convert.ToDouble(c[2]),
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

        public void run()
        {
            List<string> output = new List<string>();
            int contarPassos = 0;

            int iteration=0;
            if (corpoCelestiais.Count > 1)
            {
                for ( iteration = 0; iteration < universo.QuantidadeIteracoes; iteration++)
                {
                    output.Add(String.Format("** Interacao {0} ************", iteration+1));
                    for (var i = 0; i < corpoCelestiais.Count; ++i)
                    {

                        
                        for (var j = i + 1; j < corpoCelestiais.Count; ++j)
                        {

                            contarPassos += 1;
                            universo.AplicaForcaGravitacional(corpoCelestiais, corpoCelestiais[i], corpoCelestiais[j]);


                        }
                        var novo = new CorpoCelestial();
                        novo = corpoCelestiais[i];
                        corpoCelestiaisiteracao.Add(novo);
                        output.Add(novo.formatOutputFile());
                    }

                }
               
                DgvCorpos.DataSource = corpoCelestiaisiteracao;
                DgvCorpos.Refresh();
                MessageBox.Show(contarPassos.ToString());
                SaveCelestialBodies(output);

            }
        
        }
        private void BtnCarregar_Click(object sender, EventArgs e)
        {
            lerarquivo();
            BtnCarregar.Visible = false;
            LblDescricao.Visible = false;
            LblTitulo.Visible = false;
            BtnSimular.Visible = true;
            BtnCarregar2.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
        }


        private void BtnSimulador_Click(object sender, EventArgs e)
        {
            run();


        }
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        public void SaveCelestialBodies(List<string> output)
        {
            string file = "C:\\Users\\lamontanari\\source\\repos\\SimuladorGravitacional\\SimuladorGravitacional\\Files\\outputBodies.txt";

            FileStream myFile = new FileStream(file, FileMode.Open, FileAccess.Write);
            StreamWriter sw = new StreamWriter(myFile, Encoding.UTF8);


            foreach (var item in output)
            {
                sw.WriteLine(item);
            }

            sw.Close();
            myFile.Close();

        }
        #region Movimentar o formulario
        private void FrmSimulador_MouseDown(object sender, MouseEventArgs e)
        {
            mover = true;
            posicao_inicial = new Point(e.X, e.Y);
        }

        private void FrmSimulador_MouseUp(object sender, MouseEventArgs e)
        {
            mover = false;
        }

        private void FrmSimulador_MouseMove(object sender, MouseEventArgs e)
        {
            if (mover)
            {
                Point novo = PointToScreen(e.Location);
                Location = new Point(novo.X - posicao_inicial.X, novo.Y - posicao_inicial.Y);

            }
        }

        #endregion

    

    
    }
}
