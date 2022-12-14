namespace Recap_Demo_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button[,] buttons = new Button[8,8];
            int top=0;
            int left=0;
            Height = 450;
            Width = 450;
            for (int i = 0; i < buttons.GetUpperBound(0); i++)
            {
                for (int j = 0; j < buttons.GetUpperBound(1); j++)
                {
                    buttons[i,j] = new Button();
                    buttons[i, j].Width = 50;
                    buttons[i,j].Height = 50;
                    buttons[i, j].Left = left;
                    left += 50;
                    if ((i+j)%2==0)
                    {
                        buttons[i,j].BackColor= Color.Black;
                    }
                    else
                    {
                        buttons[i,j].BackColor=Color.White;
                    }
                    buttons[i, j].Top = top;
                  
                    this.Controls.Add(buttons[i,j]);
                    
                }
                top += 50;
                left = 0;

            }
            
        }
    }
}