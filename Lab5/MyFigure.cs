namespace Programming
{
    internal class MyFigure
    {
        public bool moveUpperRight = true;
        public int posX, posY; // Координаты центра фигуры
        private int boxSize, innerSize;
        private PictureBox pBox;

        private Point[] romb;

        public MyFigure(PictureBox pictureBox, int figureSize = 300)
        {
            pBox = pictureBox;
            if (figureSize > Math.Min(pBox.Size.Width, pBox.Size.Height))
            {
                boxSize = Math.Min(pBox.Size.Width, pBox.Size.Height) / 2;
                MessageBox.Show($"Недопустимые размеры фигуры - размер изменен на {boxSize} пикселей", "Предупреждение");
            }
            else
            {
                boxSize = figureSize;
            }

            posX = boxSize / 2;
            posY = pBox.Size.Height - boxSize / 2;
            innerSize = boxSize / 2;

        }

        private void updateRombPosition(int x, int y)
        {
            romb = new Point[4] { new Point(x - boxSize / 2, y), new Point(x, y - boxSize / 2),
                                  new Point(x + boxSize / 2, y), new Point(x, y + boxSize / 2) };
        }

        private void Show()
        {
            updateRombPosition(posX, posY);
            Graphics graphics = Graphics.FromImage(pBox.Image);
            graphics.DrawPolygon(new Pen(Color.Black), romb);
            graphics.FillPie(new SolidBrush(Color.Red), new Rectangle(posX - innerSize / 2, posY - innerSize / 2, innerSize, innerSize), -90, 120);
            graphics.FillPie(new SolidBrush(Color.Green), new Rectangle(posX - innerSize / 2, posY - innerSize / 2, innerSize, innerSize), 30, 120);
            graphics.FillPie(new SolidBrush(Color.Blue), new Rectangle(posX - innerSize / 2, posY - innerSize / 2, innerSize, innerSize), 150, 120);
            pBox.Refresh();
        }

        private void Hide()
        {
            updateRombPosition(posX, posY);
            Graphics graphics = Graphics.FromImage(pBox.Image);
            graphics.DrawPolygon(new Pen(Color.White), romb);
            graphics.FillPie(new SolidBrush(Color.White), new Rectangle(posX - innerSize / 2, posY - innerSize / 2, innerSize, innerSize), -90, 120);
            graphics.FillPie(new SolidBrush(Color.White), new Rectangle(posX - innerSize / 2, posY - innerSize / 2, innerSize, innerSize), 30, 120);
            graphics.FillPie(new SolidBrush(Color.White), new Rectangle(posX - innerSize / 2, posY - innerSize / 2, innerSize, innerSize), 150, 120);
            pBox.Refresh();
        }

        public void Move()
        {
            Hide();
            if (moveUpperRight)
            {
                if (posX + (boxSize / 2) + 1 > pBox.Width)
                {
                    moveUpperRight = false;
                    posX -= 1;
                    posY += 1;
                }
                else
                {
                    posX += 1;
                    posY -= 1;
                }
            }
            else
            {
                if (posX - (boxSize / 2) - 1 < 0)
                {
                    moveUpperRight = true;
                    posX += 1;
                    posY -= 1;
                }
                else
                {
                    posX -= 1;
                    posY += 1;
                }
            }
            Show();
        }
    }
}
