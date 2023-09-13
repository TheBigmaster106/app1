namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        readonly Random r;
        int punkty;

        public Form1()
        {
            InitializeComponent();
            r = new Random();
            punkty = 0;
            timer1.Start();
        }

        private void buttonFirst(object sender, EventArgs e)
        {
            // Application.Exit();

            //szerokosc okna aplikacji
            int windowWidth = Size.Width;
            //dlugosc okna aplikacji
            int widowHeight = Size.Height;

            //aby uniknac tego by guzik nie wyszedl poza monitor 
            windowWidth -= button1.Width;
            widowHeight -= button1.Height;

            //instalacjia generatora randomowych Liczb
            Random rnd = new Random();

            //losowa odleglosc od lewej - nie wiecej niz szerokosc okna 
            int randomLeft = rnd.Next(windowWidth);

            //anologicznie z odlegloscia od gory 
            int randomTop = rnd.Next(widowHeight);

            //przesuwany guzik 
            //location musi byc przekazany jako punkt na ekranie 
            Point TopleftCorner = new Point(randomLeft, randomTop);
            button1.Location = TopleftCorner;


            int maxX = this.Size.Width - button1.Size.Width - 30;
            int maxY = this.Size.Height - button1.Size.Height - 30;
            Point p = new Point();
            p.X = r.Next(12, maxX);
            p.Y = r.Next(12, maxY);
            button1.Location = p;
            punkty++;
            toolStripStatusLabel1.Text = "Punkty : " + punkty.ToString();
            timer1.Stop();
            timer1.Start();



        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            
            int maxX = this.Size.Width - button1.Size.Width - 30;
            int maxY = this.Size.Height - button1.Size.Height - 30;
            Point p = new Point();
            p.X = r.Next(12, maxX);
            p.Y = r.Next(12, maxY);
            button1.Location = p;
            punkty = 0;
            toolStripStatusLabel1.Text = "Punkty : " + punkty.ToString();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }


    }
}
