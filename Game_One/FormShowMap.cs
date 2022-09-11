using ClassCore;
using System.Drawing;
using System.Windows.Forms;

namespace Game_One
{
    public partial class FormShowMap : Form
    {
        int[,] _map;
        public FormShowMap()
        {
            InitializeComponent();
            _map = Core.LoadingWord();
        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            Pen pen = new Pen(Color.Red);
            for (int x = 0; x < _map.GetLength(0); x++)
            {
                for (int y = 0; y < _map.GetLength(1); y++)
                {
                    if (_map[x, y] != 0)
                    {
                        graphics.DrawRectangle(pen, new Rectangle(x * 10, y * 10, 10, 10));
                    }
                }
            }
        }

        private void Form2_Load(object sender, System.EventArgs e)
        {

        }
    }
}
