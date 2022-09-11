using ClassCore;
using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace Game_One
{
    public partial class Form2DGame : Form
    {

        int[,] _map;
        Image grauntBlock = Resource1.Graund;
        Image graundAndGreenBlock = Resource1.Graund_And_Green;
        Image disertBlock = Resource1.Disert1;
        Image player = Resource1.player;
        bool flag = true;

        const int blockWidth = 80, blockHeight = 80;
        int viewX = default;
        int viewY = default;
        int prewX;
        int prewY;
        int currentBlock = default;
        float playerX = 6;
        float playerY = 0;
        SoundPlayer soundPlayer = new SoundPlayer();
        public Form2DGame()
        {
            InitializeComponent();
            this.SetStyle(
                ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer, true
                );// двоиная буферизация
            soundPlayer.SoundLocation = "MySound.wav";
             soundPlayer.Play();
            prewX = Cursor.Position.X; // стартовая позиция курсора 
            prewY = Cursor.Position.Y;

            _map = Core.InitialMap();
            DrawPlayer(ref playerX, ref playerY);

        }

        private void ExitBatton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        } // завершить работу

        private void Maiin_Taimer_Tick(object sender, EventArgs e)
        {
            MovingСamera();//работа камеры(курсора)
            if (!IsGrounded())
            {
                NewMethod();
            }

            Invalidate(); //перерисовка
            Refresh();
        } // таимер 

        private void MovingСamera() // исправить дубляж !!!!!
        {
            Point cursotPlaer = PointToClient(Cursor.Position);
            if (cursotPlaer.X < 50 & cursotPlaer.X > 0) viewX -= 5;
            else if (cursotPlaer.X > 750) viewX += 5;
            if (cursotPlaer.Y > 550) viewY += 5;
            else if (cursotPlaer.Y < 50) viewY -= 5;


            label1.Text = cursotPlaer.ToString();
        } // разделить на 2 метода отдельных



        private void label1_Click(object sender, EventArgs e)
        {

        } // удалить в конце !!!!!

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics; //контекст рисования
            Image currentImage = null;
            for (int i = 0; i < _map.GetLength(0); i++)
            {
                for (int j = 0; j < _map.GetLength(1); j++)
                {
                    int blocType = _map[i, j];
                    Rectangle rectangle = new Rectangle((i * blockWidth) - viewX, (j * blockHeight) - viewY, blockWidth, blockHeight); // рисуем блоки
                    DrawBlock(rectangle, blocType, graphics);

                }
            }

            graphics.DrawImage(player, new Rectangle((int)(playerX * blockWidth) - viewX, ((int)playerY * blockHeight) - viewY, blockWidth, blockHeight));
        } //рисуем карту 

        private void SetBlock(object sender, EventArgs e)
        {
            Point cursor = PointToClient(Cursor.Position);
            int x, y;
            //переводим мировую в локальную
            x = (cursor.X + viewX) / blockWidth;
            y = (cursor.Y + viewY) / blockHeight;
            _map[x, y] = currentBlock;
        } // поставить блок по клику 

        private void DrawBlock(Rectangle rectangle, int blockType, Graphics graphics)
        {
            Image currentImage = null;
            switch (blockType)
            {
                case 1:
                    currentImage = grauntBlock;
                    break;
                case 2:
                    currentImage = graundAndGreenBlock;
                    break;
                case 3:
                    currentImage = disertBlock;
                    break;
                default:
                    if (currentImage == null)
                        return;
                    break;
            }
            graphics.DrawImage(currentImage, rectangle);
        } //рисуем блоки

        public void ClearWord()
        {
            for (int i = 0; i < _map.GetLength(0); i++)
            {
                for (int j = 0; j < _map.GetLength(1); j++)
                {
                    _map[i, j] = 0;
                }
            }
        } //удаляет все блоки
        private void GeneratButtonClick(object sender, EventArgs e) //сгенерировать новый мир
        {
            ClearWord();
            _map = Core.InitialMap();
        }

        private void LoadBattonClick(object sender, EventArgs e) // загрузить мир
        {
            _map = Core.LoadingWord();

        }

        private void SaveBattonClick(object sender, EventArgs e) //сохранить мир 
        {
            Core.SaveWord(_map);
        }
        private void ShowMap(object sender, EventArgs e)
        {
            FormShowMap form2 = new FormShowMap();
            form2.Show(this);
        } //открывает 2 форму  шде выводится карты 

        private void DrawPlayer(ref float playerX, ref float playerY)
        {
            for (int i = 0; i < _map.GetLength(1); i++)
            {
                if (_map[0, i] != 0)
                {
                    playerY = i - 1;
                    playerX = 0;
                    break;
                }

            }

        }

        private void NewMethod()
        {
            if (playerY != 0)
            {
                if (_map[(int)playerX, (int)playerY + 1] == 0)
                {
                    playerY = playerY + (1f / 10f);
                }
                if (playerX % (int)playerX != 1)
                {
                    if (_map[(int)playerX + 1, (int)playerY + 1] == 0)
                    {
                        playerY = playerY + (1f / 10f);
                    }
                }

            }
        } //движение персонажа 

        private bool IsGrounded()
        {
            if (playerY == 0) return true;
            bool isGrounded = false;
            if (_map[(int)playerX, (int)playerY + 1] != 0)
            {
                isGrounded = true;
            }
            if (_map[(int)Math.Round(playerX, MidpointRounding.AwayFromZero), (int)playerY + 1] != 0)
            {
                return true;
            }
            else return false;

        }

        //garbith

        private void button2_Click(object sender, EventArgs e)
        {
            currentBlock = (int)ChoichBlock.grauntBlock;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            currentBlock = (int)ChoichBlock.graundAndGreenBlock;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            currentBlock = (int)ChoichBlock.disertBlock;

        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) //движение
        {
            object s = "";
            EventArgs eventArgs = new EventArgs();

            switch (keyData)
            {
                case Keys.D:
                    if (!flag)
                    {
                        player.RotateFlip(RotateFlipType.Rotate180FlipY);
                        flag = true;
                    }
                    playerX += 0.5f;
                    break;
                case Keys.A:
                    if (flag)
                    {
                        player.RotateFlip(RotateFlipType.Rotate180FlipY);
                        flag = false;
                    }
                    playerX -= 0.5f;
                    break;
                case Keys.W:
                    playerY -= 0.5f;
                    break;
                case Keys.Q:
                    ShowMap(s, eventArgs);
                    break;


            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        

        public enum ChoichBlock
        {
            grauntBlock = 0,
            graundAndGreenBlock = 1,
            disertBlock = 2
        }
    }
}
