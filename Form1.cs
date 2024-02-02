namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void Add()
        {
            double fnum = double.Parse(txtFnum.Text);
            double snum = double.Parse(txtSnum.Text);
            double ttlAdd;

            ttlAdd = fnum + snum;
            lblAns.Text = ttlAdd.ToString();
        }
        //sub
        public void Sub(double x, double y)
        {
            x = double.Parse(txtFnum.Text);
            y = double.Parse(txtSnum.Text);
            double ttlSub;

            ttlSub = x - y;
            lblAns.Text = ttlSub.ToString();
        }
        String Mul()
        {
            double fnum = double.Parse(txtFnum.Text);
            double snum = double.Parse(txtSnum.Text);
            double ttlmul;

            ttlmul = fnum * snum;
            return ttlmul.ToString();

        }
        String ansdiv(String x, String y)
        {
            double fnum = double.Parse(x);
            double snum = double.Parse(y);
            double ansdiv;
            if (fnum > 0 && snum == 0)
            {
                return "CANT DIVIDE BY ZERO";
            }
            else if (fnum == 0 && snum == 0)
            {
                return "SYNTAX ERROR";
            }
            else
            {
                ansdiv = fnum / snum;
                return ansdiv.ToString();
            }
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void btnDiff_Click(object sender, EventArgs e)
        {
            Sub(double.Parse(txtFnum.Text), double.Parse(txtSnum.Text));
        }

        private void btnQuo_Click(object sender, EventArgs e)
        {
            lblAns.Text = Mul();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            lblAns.Text = ansdiv(txtFnum.Text, txtSnum.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtFnum.Text = " ";
            txtSnum.Text = " ";
            lblAns.Text = "---";
        }

        private void txtSnum_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFnum_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
