namespace WordSculpt
{
    public partial class welcome : Form
    {
        public welcome()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            t1.Start();
        }

        private void t1_Tick(object sender, EventArgs e)
        {
            pb1.Increment(2);
            pb2.Increment(2);
            if (pb1.Value == 74)
                Thread.Sleep(1500);
            if (pb2.Value == 100)
            {
                
                t1.Stop();
                Play play = new Play();
                play.Show();

            }
        }
    }
}