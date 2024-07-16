namespace HomeWork_1_wf
{
    public partial class HomeWork_1 : Form
    {
        string fileName_;
        public HomeWork_1()
        {
            InitializeComponent();
        }

        // Обработка события "Новедение курсора на кнопку" ("убегание" кнопки от курсора мыши)
        private void btn1_run_away_MouseMove(object sender, MouseEventArgs e)
        {
            Random r = new Random(); // Генератор случайных чисел
            // Для задания эффекта "убегания" кнопки присваиваем координатам кнопки новые рандомные координаты
            btn1_run_away.Left = r.Next(0, gb2_area_run.Width - btn1_run_away.Width);
            btn1_run_away.Top = r.Next(0, gb2_area_run.Height - btn1_run_away.Height);
        }

        private void btn1_Open_Click(object sender, EventArgs e) // Нажатие на кнопку "Открыть"
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
                this.ActiveControl = null; // При нажатой клавише Control убираем фокус с TextBox,
                                           // чтобы в нём не прописывались лишние символы
            if (((keyData & Keys.Control) == Keys.Control) && ((keyData & Keys.W) == Keys.W))
            {                
                btn1_Open.PerformClick(); // При нажатии клавиш Ctrl + W вызываем нажатие кнопки btn1_Open
            }
            else                
                if (((keyData & Keys.Control) == Keys.Control) && ((keyData & Keys.S) == Keys.S))
                {
                    btn2_Save.PerformClick(); // При нажатии клавиш Ctrl + S вызываем нажатие кнопки btn2_Save                    
                }            
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}