using System.Runtime.InteropServices;

namespace SimuladorGravitacional
{
    public partial class Form1 : Form
    {
        private const int cGrip = 16;      // Grip size
        private const int cCaption = 25;   // Caption bar height;
        bool mover = false;
        Point posicao_inicial;



        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true); // this is to avoid visual artifacts
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;
                    return;
                }

                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17;
                    return;
                }
            }
            base.WndProc(ref m);
        }
        #region Movimentar o formulario
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mover = true;
            posicao_inicial = new Point(e.X, e.Y);
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mover = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
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