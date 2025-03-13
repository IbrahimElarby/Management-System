namespace mangment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void studentviewbtn_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Studentcontrol student = new Studentcontrol();

            student.Dock = DockStyle.Fill;

            panel1.Controls.Add(student);
        }

        private void instructorbtn_Click(object sender, EventArgs e)
        {

            panel1.Controls.Clear();
            instructorcontrol instructor = new instructorcontrol();

            instructor.Dock = DockStyle.Fill;

            panel1.Controls.Add(instructor);
        }

        private void departmentviewbtn_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Departmentcontrol department = new Departmentcontrol();

            department.Dock = DockStyle.Fill;

            panel1.Controls.Add(department);
        }

        private void courseviewbtn_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            CourseControl course = new CourseControl();

            course.Dock = DockStyle.Fill;

            panel1.Controls.Add(course);
        }
    }
}
