namespace бд
{
    public partial class Form1 : Form
    {
        private Form form;
        private string connectionString = "Data Source=HOME-PC; Initial Catalog=К; Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonClick(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            string data = b.Tag as string;
            switch (data)
            {
                case "f1":
                    form = new Formf1(connectionString);
                    break;

                case "f2":
                    form = new Formf2(connectionString);
                    break;

                case "f3":
                    form = new Formf3(connectionString);
                    break;

                case "a1":
                    form = new Forma1(connectionString);
                    break;

                case "a2":
                    form = new Forma2(connectionString);
                    break;

                case "a3":
                    form = new Forma3(connectionString);
                    break;

                case "a4":
                    form = new Forma4(connectionString);
                    break;

                case "a5":
                    form = new Forma5(connectionString);
                    break;
            }
            form.ShowDialog();
        }
    }
}