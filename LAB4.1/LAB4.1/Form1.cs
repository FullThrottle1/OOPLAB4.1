using LAB4._1;

namespace LAB4._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }
        bool ctrl_pressed = false;
        Storage st = new Storage(100);
        Graphics g;

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (st.countRealObjects() > 0)
            {
                g = CreateGraphics();
                int i;
                for (i = 0; i < st.countRealObjects(); i++)
                {
                    CCircle t = st.getObject(i);
                    if (t != null)
                    {
                        t.unselect();
                        t.draw(g);
                    }
                }
                st.getObject(i - 1).select();
                st.getObject(i - 1).draw(g);
            }
        }
        private void Form2_Paint(object sender, PaintEventArgs e)
        {

            for (int i = 0; i < st.countRealObjects(); i++)
            {
                CCircle t = st.getObject(i);
                if (t != null)
                {


                    t.draw(g);
                }
            }
        }
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {

            this.Paint -= Form1_Paint;
            this.Paint += Form2_Paint;
            if (!ctrl_pressed)
            {
                for (int j = 0; j < st.countRealObjects(); j++)
                {

                    st.getObject(j).unselect();

                }
            }
            bool is_touched = false;
            for (int i = 0; i < st.countRealObjects(); i++)
            {

                CCircle t = st.getObject(i);
                if (t.hit(e.X, e.Y))
                {
                    t.select();
                    is_touched = true;
                    if (!mark_more.Checked) break;


                }

            }
            this.Refresh();
            if (is_touched) return;
            this.Paint -= Form2_Paint;
            this.Paint += Form1_Paint;


            st.setObject(new CCircle(e.X, e.Y));
            this.Refresh();




        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (ctrl_enabled.Checked)
            {
                if (e.Control) ctrl_pressed = true;
            }
            if (e.KeyCode == Keys.Delete)
            {
                for (int i = 0; i < st.countRealObjects(); i++)
                {
                    if (st.getObject(i).isSelected())
                    {
                        st.deleteObject(i);
                        --i;
                    }
                }
                if (st.countRealObjects() > 0)
                {
                    for (int i = st.getCount() - 1; i >= 0; i--)
                    {
                        if (st.getObject(i) != null)
                        {
                            st.getObject(i).select();
                            break;
                        }
                    }
                }
                this.Refresh();
            }
        }


        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            ctrl_pressed = false;
        }
    }
}