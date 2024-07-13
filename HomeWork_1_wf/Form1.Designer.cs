namespace HomeWork_1_wf
{
    partial class HomeWork_1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn1_run_away = new Button();
            tb1_text = new TextBox();
            gb1_Buttons = new GroupBox();
            btn2_Save = new Button();
            btn1_Open = new Button();
            gb2_area_run = new GroupBox();
            openFileDialog1 = new OpenFileDialog();
            ld_1_Header = new Label();
            saveFileDialog1 = new SaveFileDialog();
            MainMenu = new MenuStrip();
            менюToolStripMenuItem = new ToolStripMenuItem();
            открытьToolStripMenuItem = new ToolStripMenuItem();
            сохранитьToolStripMenuItem = new ToolStripMenuItem();
            gb1_Buttons.SuspendLayout();
            gb2_area_run.SuspendLayout();
            MainMenu.SuspendLayout();
            SuspendLayout();
            // 
            // btn1_run_away
            // 
            btn1_run_away.Anchor = AnchorStyles.None;
            btn1_run_away.BackColor = Color.Red;
            btn1_run_away.FlatAppearance.BorderColor = Color.Coral;
            btn1_run_away.FlatAppearance.BorderSize = 2;
            btn1_run_away.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn1_run_away.Location = new Point(89, 108);
            btn1_run_away.Name = "btn1_run_away";
            btn1_run_away.Size = new Size(115, 30);
            btn1_run_away.TabIndex = 0;
            btn1_run_away.Text = "Нажми меня";
            btn1_run_away.UseVisualStyleBackColor = false;
            btn1_run_away.MouseMove += btn1_run_away_MouseMove;
            // 
            // tb1_text
            // 
            tb1_text.Location = new Point(50, 70);
            tb1_text.Multiline = true;
            tb1_text.Name = "tb1_text";
            tb1_text.ScrollBars = ScrollBars.Both;
            tb1_text.Size = new Size(300, 350);
            tb1_text.TabIndex = 1;
            // 
            // gb1_Buttons
            // 
            gb1_Buttons.BackColor = SystemColors.Control;
            gb1_Buttons.BackgroundImageLayout = ImageLayout.None;
            gb1_Buttons.Controls.Add(btn2_Save);
            gb1_Buttons.Controls.Add(btn1_Open);
            gb1_Buttons.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            gb1_Buttons.ForeColor = SystemColors.Highlight;
            gb1_Buttons.Location = new Point(530, 50);
            gb1_Buttons.Name = "gb1_Buttons";
            gb1_Buttons.Size = new Size(250, 100);
            gb1_Buttons.TabIndex = 2;
            gb1_Buttons.TabStop = false;
            gb1_Buttons.Text = "Кнопки для работы с файлом";
            // 
            // btn2_Save
            // 
            btn2_Save.FlatAppearance.BorderColor = Color.Black;
            btn2_Save.FlatAppearance.BorderSize = 2;
            btn2_Save.ForeColor = SystemColors.ControlText;
            btn2_Save.Location = new Point(130, 24);
            btn2_Save.Name = "btn2_Save";
            btn2_Save.Size = new Size(100, 30);
            btn2_Save.TabIndex = 1;
            btn2_Save.Text = "Сохранить";
            btn2_Save.UseVisualStyleBackColor = true;
            btn2_Save.Click += btn2_Save_Click;
            // 
            // btn1_Open
            // 
            btn1_Open.FlatAppearance.BorderColor = Color.Black;
            btn1_Open.FlatAppearance.BorderSize = 2;
            btn1_Open.ForeColor = SystemColors.ControlText;
            btn1_Open.Location = new Point(6, 24);
            btn1_Open.Name = "btn1_Open";
            btn1_Open.Size = new Size(100, 30);
            btn1_Open.TabIndex = 0;
            btn1_Open.Text = "Открыть";
            btn1_Open.UseVisualStyleBackColor = true;
            btn1_Open.Click += btn1_Open_Click;
            // 
            // gb2_area_run
            // 
            gb2_area_run.BackColor = SystemColors.AppWorkspace;
            gb2_area_run.Controls.Add(btn1_run_away);
            gb2_area_run.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            gb2_area_run.ForeColor = SystemColors.ActiveCaptionText;
            gb2_area_run.Location = new Point(370, 160);
            gb2_area_run.Name = "gb2_area_run";
            gb2_area_run.Size = new Size(400, 300);
            gb2_area_run.TabIndex = 3;
            gb2_area_run.TabStop = false;
            gb2_area_run.Text = "Область убегающей кнопки";
            // 
            // openFileDialog1
            // 
            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.FileName = "Text";
            openFileDialog1.Filter = "Text|*.txt";
            // 
            // ld_1_Header
            // 
            ld_1_Header.AutoSize = true;
            ld_1_Header.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            ld_1_Header.Location = new Point(50, 50);
            ld_1_Header.Name = "ld_1_Header";
            ld_1_Header.Size = new Size(150, 19);
            ld_1_Header.TabIndex = 4;
            ld_1_Header.Text = "Содержимое файла";
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.FileName = "Text";
            saveFileDialog1.Filter = "Text|*.txt";
            // 
            // MainMenu
            // 
            MainMenu.Items.AddRange(new ToolStripItem[] { менюToolStripMenuItem });
            MainMenu.Location = new Point(0, 0);
            MainMenu.Name = "MainMenu";
            MainMenu.Size = new Size(784, 28);
            MainMenu.TabIndex = 5;
            MainMenu.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            менюToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { открытьToolStripMenuItem, сохранитьToolStripMenuItem });
            менюToolStripMenuItem.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            менюToolStripMenuItem.Size = new Size(65, 24);
            менюToolStripMenuItem.Text = "Меню";
            // 
            // открытьToolStripMenuItem
            // 
            открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            открытьToolStripMenuItem.Size = new Size(154, 24);
            открытьToolStripMenuItem.Text = "Открыть";
            открытьToolStripMenuItem.Click += btn1_Open_Click;
            // 
            // сохранитьToolStripMenuItem
            // 
            сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            сохранитьToolStripMenuItem.Size = new Size(154, 24);
            сохранитьToolStripMenuItem.Text = "Сохранить";
            сохранитьToolStripMenuItem.Click += btn2_Save_Click;
            // 
            // HomeWork_1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(ld_1_Header);
            Controls.Add(gb2_area_run);
            Controls.Add(gb1_Buttons);
            Controls.Add(tb1_text);
            Controls.Add(MainMenu);
            HelpButton = true;
            MainMenuStrip = MainMenu;
            Name = "HomeWork_1";
            Text = "Form1";
            gb1_Buttons.ResumeLayout(false);
            gb2_area_run.ResumeLayout(false);
            MainMenu.ResumeLayout(false);
            MainMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn1_run_away;
        private TextBox tb1_text;
        private GroupBox gb1_Buttons;
        private Button btn1_Open;
        private GroupBox gb2_area_run;
        private OpenFileDialog openFileDialog1;
        private Label ld_1_Header;
        private Button btn2_Save;
        private SaveFileDialog saveFileDialog1;
        private MenuStrip MainMenu;
        private ToolStripMenuItem менюToolStripMenuItem;
        private ToolStripMenuItem открытьToolStripMenuItem;
        private ToolStripMenuItem сохранитьToolStripMenuItem;
    }
}