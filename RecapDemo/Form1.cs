namespace RecapDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int buttonSize = 60;
            int left = 5;
            int top = 5;
            Button[,] buttons = new Button[8, 8];

            var result = buttons.GetUpperBound(0);

            for (int i = 0; i < buttons.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < buttons.GetUpperBound(1) + 1; j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Width = buttonSize;
                    buttons[i, j].Height = buttonSize;
                    buttons[i, j].Left = left;
                    left += buttonSize;
                    buttons[i, j].Top = top;

                    if(i % 2 == 0)
                    {
                        if(j % 2 == 0)
                        {
                            buttons[i, j].BackColor = Color.White;
                        }
                        else
                        {
                            buttons[i, j].BackColor = Color.Black;
                        }
                    }
                    else
                    {
                        if (j % 2 == 0)
                        {
                            buttons[i, j].BackColor = Color.Black;
                        }
                        else
                        {
                            buttons[i, j].BackColor = Color.White;
                        }
                    }
                    

                    this.Controls.Add(buttons[i, j]);
                }
                left = 5;
                top += buttonSize;
            }
        }
    }
}
