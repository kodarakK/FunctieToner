namespace FuntieMaker
{
    public partial class Form1 : Form
    {
        int actueleKeuze = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            actueleKeuze = 1;
            panel1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            actueleKeuze = 2;
            panel1.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            actueleKeuze = 3;
            panel1.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            actueleKeuze = 4;
            panel1.Refresh();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            actueleKeuze = 5;
            panel1.Refresh();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            actueleKeuze = 6;
            panel1.Refresh();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            actueleKeuze = 7;
            panel1.Refresh();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            actueleKeuze = 8;
            panel1.Refresh();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            actueleKeuze = 9;
            panel1.Refresh();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            actueleKeuze = 10;
            panel1.Refresh();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen potloodCoS = new Pen(Color.Red);
            Brush penseelCoS = new SolidBrush(Color.White);
            Brush penseelCurve = new SolidBrush(Color.Yellow);

            // oorsprong omzetten
            g.TranslateTransform(panel1.Width / 2, panel1.Height / 2);

            // coordinaten intekenen
            g.DrawLine(potloodCoS, 0, -200, 0, 200);
            g.DrawLine(potloodCoS, -280, 0, 280, 0);

            // negatief x-as
            g.DrawString("-5", this.Font, penseelCoS, -275, 5);

            // negatief y-as
            g.DrawString("-5", this.Font, penseelCoS, 5, 180);

            // positief x-as
            g.DrawString("+5", this.Font, penseelCoS, 250, 5);
            
            // positief y-as
            g.DrawString("+5", this.Font, penseelCoS, 5, -200);

            // als geen functie is gekozen, niets doen
            if (this.actueleKeuze == 0)
                return;
            double x, y;
            int xpos, ypos;

            for (x = -5; x <= 5; x += 0.001)
            {
                if (actueleKeuze == 1)
                {
                    
                        y = x;
                        xpos = (int)(x * 50);
                        ypos = (int)(-y * 50);
                        g.FillEllipse(penseelCurve, xpos, ypos, 2, 2);
                    

                }
                else if (actueleKeuze == 2)
                {
                    
                        y = Math.Pow(x, 2);
                        xpos = (int)(x * 50);
                        ypos = (int)(-y * 50);
                        g.FillEllipse(penseelCurve, xpos, ypos, 2, 2);
                    
                }
                else if (actueleKeuze == 3)
                {
                    
                        y = Math.Pow(x, 3);
                        xpos = (int)(x * 50);
                        ypos = (int)(-y * 50);
                        g.FillEllipse(penseelCurve, xpos, ypos, 2, 2);
                    
                }

                else if (actueleKeuze == 4)
                {
                    
                        if (x == 0) continue;

                        y = 1 / x;
                        xpos = (int)(x * 50);
                        ypos = (int)(-y * 50);

                        try { g.FillEllipse(penseelCurve, xpos, ypos, 2, 2); } catch (OverflowException) { }



                    
                }

                else if (actueleKeuze == 5)
                {

                        if (x < 0) continue;
                        y = Math.Sqrt(x);
                        xpos = (int)(x * 50);
                        ypos = (int)(-y * 50);
                        try { g.FillEllipse(penseelCurve, xpos, ypos, 2, 2); } catch (OverflowException) { }


                    
                }

                else if (actueleKeuze == 6)
                {
                    
                        y = Math.Sin(x);
                        xpos = (int)(x * 50);
                        ypos = (int)(-y * 50);
                        g.FillEllipse(penseelCurve, xpos, ypos, 2, 2);
                    

                }
                else if (actueleKeuze == 7)
                {
                    
                        y = Math.Cos(x);
                        xpos = (int)(x * 50);
                        ypos = (int)(-y * 50);
                        g.FillEllipse(penseelCurve, xpos, ypos, 2, 2);
                }
                
                else if (actueleKeuze == 8)
                {
                    
                        y = (int)(x);
                        xpos = (int)(x * 50);
                        ypos = (int)(-y * 50);
                        g.FillEllipse(penseelCurve, xpos, ypos, 2, 2);
                    
                }
                else if (actueleKeuze == 9)
                {
                    
                        y = Math.Abs(x);
                        xpos = (int)(x * 50);
                        ypos = (int)(-y * 50);
                        g.FillEllipse(penseelCurve, xpos, ypos, 2, 2);
                    
                }
                else if (actueleKeuze == 10)
                {
                    return;
                }
                else
                    return;

            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}