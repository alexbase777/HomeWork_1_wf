namespace HomeWork_1_wf
{
    public partial class HomeWork_1 : Form
    {
        string fileName_;
        public HomeWork_1()
        {
            InitializeComponent();
        }

        // ��������� ������� "��������� ������� �� ������" ("��������" ������ �� ������� ����)
        private void btn1_run_away_MouseMove(object sender, MouseEventArgs e)
        {
            Random r = new Random(); // ��������� ��������� �����
            // ��� ������� ������� "��������" ������ ����������� ����������� ������ ����� ��������� ����������
            btn1_run_away.Left = r.Next(0, gb2_area_run.Width - btn1_run_away.Width);
            btn1_run_away.Top = r.Next(0, gb2_area_run.Height - btn1_run_away.Height);
        }

        private void btn1_Open_Click(object sender, EventArgs e) // ������� �� ������ "�������"
        {            
            openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileName_ = openFileDialog1.FileName;
                StreamReader sr = new StreamReader(fileName_);                
                tb1_text.Text = sr.ReadToEnd();
                sr.Close();
            }
        }

        private void btn2_Save_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileName_ = saveFileDialog1.FileName;
                StreamWriter sw = new StreamWriter(fileName_);
                sw.WriteLine(tb1_text.Text);
                sw.Close();
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {        
            if ((keyData & Keys.Control) == Keys.Control)
                this.ActiveControl = null; // ��� ������� ������� Control ������� ����� � TextBox,
                                           // ����� � �� �� ������������� ������ �������
            if (((keyData & Keys.Control) == Keys.Control) && ((keyData & Keys.W) == Keys.W))
            {                
                btn1_Open.PerformClick(); // ��� ������� ������ Ctrl + W �������� ������� ������ btn1_Open
            }
            else                
                if (((keyData & Keys.Control) == Keys.Control) && ((keyData & Keys.S) == Keys.S))
                {
                    btn2_Save.PerformClick(); // ��� ������� ������ Ctrl + S �������� ������� ������ btn2_Save                    
                }            
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}