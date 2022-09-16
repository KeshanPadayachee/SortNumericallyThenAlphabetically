namespace SortNumericallyThenAlphabetically
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        RandomGenerator generator = new RandomGenerator();

        private void btnSort_Click(object sender, EventArgs e)
        {
            List<CallNumbers> lstSorted = new List<CallNumbers>();
            lstSorted = generator.sortRandomList();

            string sorted = "";

            foreach (CallNumbers output in lstSorted)
            {
                sorted += String.Format("{0:0.00}", output.CallNumber) + " " + output.CallLetter + "\n";
            }

            rTxbOutput.Text = "";
            rTxbOutput.Text = sorted;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            List<CallNumbers> lstRandom = new List<CallNumbers>();

            lstRandom = generator.testMethod();

            string random = "";

            foreach (CallNumbers output in lstRandom)
            {
                random += String.Format("{0:0.00}", output.CallNumber) + " " + output.CallLetter + "\n";
            }

            rTxbOutput.Text = "";
            rTxbOutput.Text = random;
        }
    }
}