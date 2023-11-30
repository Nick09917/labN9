namespace labN9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 15;
            dataGridView1.ColumnCount = 15;
            int[,] a = new int[15, 15];
            int i, j;
            Random rand = new Random();
            for (i = 0; i < 15; i++)
            {
                for (j = 0; j < 15; j++)
                {
                    a[i, j] = rand.Next(-100, 100);
                }
            }

            a[0, 0] = 1;
            a[5, 0] = 1;
            for (i = 0; i < 15; i++)
            {
                for (j = 0; j < 15; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = a[i, j].ToString();
                }
            }



            for (i = 0; i < 15; i++)
            {
                int afrim = 0;
                int count = 0;
                for (j = 0; j < 15; j++)
                {
                    if (a[i, 0] == 1)
                    {
                        afrim += a[i, j];

                    }
                }
                if (a[i, 0] == 1)
                {
                    float afrimsred = afrim / 15.0f; // Учтите деление на вещественное число для точного результата
                    int nomstr = i + 1;

                    // Добавляем новую строку в текстовое поле
                    textBox1.AppendText("Строка с которой начинается с " + nomstr +
                        " Сред арифм строки = " + afrimsred + Environment.NewLine);

                    count++; // Увеличиваем счетчик строк, удовлетворяющих условию


                }

            }


        }

    }
}