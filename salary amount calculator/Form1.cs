namespace salary_amount_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            int[] number = new int[11] { 5000, 1000, 500, 200, 100, 50, 20, 10, 5, 2, 1 };
            try
            {
                
                int isCheck;
                var returnVal = int.TryParse(salaryInput.Text, out isCheck);
                if (returnVal)
                {
                    int getModValue = Int32.Parse(salaryInput.Text);
                    dataGridView1.Rows.Clear();
                    for(int a = 0; a <= number.Length -1; a++)
                    {
                        int getDivideNo = (getModValue / number[a]);
                        getModValue = (getModValue % number[a]);
                        dataGridView1.Rows.Add(string.Format("{o}/=", number[a]), getDivideNo);
                    }
                }
                else
                {
                    MessageBox.Show("Entered Value is invalid");
                    salaryInput.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);    
            }
        }
    }
}