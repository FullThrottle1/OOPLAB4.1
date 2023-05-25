

namespace LAB4._1
{
    class CCircle
    {
        private int x { init; get; }
        private int y { init; get; }
        private int radius { init; get; }

        private bool selected = false;

        public void select()
        {
            selected = true;
        }
        public void unselect()
        {
            selected = false;
        }
        public CCircle(int x, int y)
        {
            this.x = x;
            this.y = y;
            this.radius = 100;
        }

        public CCircle(int x, int y, int r)
        {
            this.x = x;
            this.y = y;
            this.radius = r;
        }

        public void draw(Graphics gr)
        {

            if (selected == true)
            {
                gr.DrawEllipse(new Pen(Color.Black, 1), x - radius / 2, y - radius / 2, radius, radius);
                gr.FillEllipse(new SolidBrush(Color.Yellow), x - radius / 2, y - radius / 2, radius, radius);
            }
            else
            {
                gr.DrawEllipse(new Pen(Color.Black, 1), x - radius / 2, y - radius / 2, radius, radius);
            }
        }

        public bool hit(int x, int y)
        {
            if (x >= this.x - radius / 2 && x <= this.x + radius / 2 && y >= this.y - radius / 2 && y <= this.y + radius / 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool isSelected()
        {
            if (selected == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
