namespace Lab04
{
    public partial class Form1 : Form
    {
        private Classroom classroom;
        public Form1()
        {
            InitializeComponent();
            classroom = new Classroom();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = this.textBox1.Text;
            int year = int.Parse(this.textBox2.Text);
            double grade = double.Parse(this.textBox3.Text);

            Class1 class1 = new Class1(name, year, grade);
            this.classroom.addclass1(class1);

            label5.Text = this.classroom.Showclass1();
            label7.Text = this.classroom.ShowAllAge().ToString();
            this.classroom.SetGrade();
            this.textBoxMax.Text = this.classroom.ShowMaxGrade().ToString();
            this.textBoxMin.Text = this.classroom.ShowMinGrade().ToString();
            this.textBoxNameMax.Text = this.classroom.ShowMaxGradeName();
            this.textBoxNameMin.Text = this.classroom.ShowMinGradeName();
        }
    }
}