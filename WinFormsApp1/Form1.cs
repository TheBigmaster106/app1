namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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


        }
    }
}