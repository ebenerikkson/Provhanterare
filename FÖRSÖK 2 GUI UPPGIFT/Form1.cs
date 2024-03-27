namespace FÖRSÖK_2_GUI_UPPGIFT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox30_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string docpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            StreamWriter sr = File.CreateText(docpath + @"/file.txt");
 
            

            List<FlowLayoutPanel> flow = tableLayoutPanel1.Controls.OfType<FlowLayoutPanel>().ToList();
            foreach(FlowLayoutPanel flowLayoutPanel in flow)
            {
                List<RadioButton> radio = flowLayoutPanel.Controls.OfType<RadioButton>().ToList();
                foreach(RadioButton radioButton in radio)
                {
                    if (radioButton.Checked)
                    {
                        sr.WriteLine(flowLayoutPanel.Tag + " " + radioButton.Text);

                    }
                }
               List<TextBox> boxes = flowLayoutPanel.Controls.OfType<TextBox>().ToList();
                foreach(TextBox textBox in boxes)
                {
                    if (textBox.ReadOnly == false)
                    {
                        sr.WriteLine(flowLayoutPanel.Tag + " " + textBox.Text);
                    }

                }
            }
            




            sr.Close();
            

        }
    }
}