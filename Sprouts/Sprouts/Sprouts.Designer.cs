namespace SproutsGame
{
    partial class Sprouts
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sprouts));
            this.StartGameButton = new System.Windows.Forms.Button();
            this.RulesButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.RulesMainLabel = new System.Windows.Forms.Label();
            this.roolsLabel = new System.Windows.Forms.Label();
            this.BackToMenuButton = new System.Windows.Forms.Button();
            this.RuleLabel = new System.Windows.Forms.Label();
            this.Mode1Button = new System.Windows.Forms.Button();
            this.Mode2Button = new System.Windows.Forms.Button();
            this.ModeLabel = new System.Windows.Forms.Label();
            this.CountNLabel = new System.Windows.Forms.Label();
            this.Player1Label = new System.Windows.Forms.Label();
            this.Player2Label = new System.Windows.Forms.Label();
            this.StartMode1Button = new System.Windows.Forms.Button();
            this.Player1Box = new System.Windows.Forms.TextBox();
            this.Player2Box = new System.Windows.Forms.TextBox();
            this.BackToChoiceModeButton = new System.Windows.Forms.Button();
            this.MoveLabel = new System.Windows.Forms.Label();
            this.StartMode2Button = new System.Windows.Forms.Button();
            this.ButtonFinishGame = new System.Windows.Forms.Button();
            this.LabelWin = new System.Windows.Forms.Label();
            this.TimerErrors = new System.Windows.Forms.Timer(this.components);
            this.IntersectError = new System.Windows.Forms.Button();
            this.connectionError = new System.Windows.Forms.Button();
            this.ControlButton = new System.Windows.Forms.Button();
            this.ControlLabel = new System.Windows.Forms.Label();
            this.ControlTextLabel = new System.Windows.Forms.Label();
            this.BackToGameButton = new System.Windows.Forms.Button();
            this.BackFramePicBox = new System.Windows.Forms.PictureBox();
            this.infButton = new System.Windows.Forms.Button();
            this.n10 = new System.Windows.Forms.Button();
            this.n9 = new System.Windows.Forms.Button();
            this.n8 = new System.Windows.Forms.Button();
            this.n7 = new System.Windows.Forms.Button();
            this.n6 = new System.Windows.Forms.Button();
            this.n5 = new System.Windows.Forms.Button();
            this.n4 = new System.Windows.Forms.Button();
            this.n3 = new System.Windows.Forms.Button();
            this.n2 = new System.Windows.Forms.Button();
            this.n1 = new System.Windows.Forms.Button();
            this.GameNameLabel = new System.Windows.Forms.PictureBox();
            this.LabelCountMove = new System.Windows.Forms.Label();
            this.retryButton = new System.Windows.Forms.Button();
            this.WhileGamePicBox = new System.Windows.Forms.PictureBox();
            this.AskRetryLabel = new System.Windows.Forms.Label();
            this.YesButton = new System.Windows.Forms.Button();
            this.NoButton = new System.Windows.Forms.Button();
            this.AskBackMenuLabel = new System.Windows.Forms.Label();
            this.AskExitLabel = new System.Windows.Forms.Label();
            this.TablePanelMode1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.BackFramePicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameNameLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WhileGamePicBox)).BeginInit();
            this.TablePanelMode1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartGameButton
            // 
            this.StartGameButton.BackColor = System.Drawing.Color.Transparent;
            this.StartGameButton.FlatAppearance.BorderSize = 3;
            this.StartGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartGameButton.Font = new System.Drawing.Font("Cascadia Code SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartGameButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.StartGameButton.Location = new System.Drawing.Point(27, 158);
            this.StartGameButton.Name = "StartGameButton";
            this.StartGameButton.Size = new System.Drawing.Size(170, 45);
            this.StartGameButton.TabIndex = 1;
            this.StartGameButton.Text = "Выбор режима";
            this.StartGameButton.UseVisualStyleBackColor = false;
            this.StartGameButton.Click += new System.EventHandler(this.StartGameButton_Click);
            // 
            // RulesButton
            // 
            this.RulesButton.BackColor = System.Drawing.Color.Transparent;
            this.RulesButton.FlatAppearance.BorderSize = 3;
            this.RulesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RulesButton.Font = new System.Drawing.Font("Cascadia Code SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RulesButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.RulesButton.Location = new System.Drawing.Point(27, 210);
            this.RulesButton.Name = "RulesButton";
            this.RulesButton.Size = new System.Drawing.Size(170, 45);
            this.RulesButton.TabIndex = 2;
            this.RulesButton.Text = "Правила игры";
            this.RulesButton.UseVisualStyleBackColor = false;
            this.RulesButton.Click += new System.EventHandler(this.RoolsButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Transparent;
            this.ExitButton.FlatAppearance.BorderSize = 3;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Cascadia Code SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ExitButton.Location = new System.Drawing.Point(27, 318);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(170, 45);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Выход из игры";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // RulesMainLabel
            // 
            this.RulesMainLabel.AutoSize = true;
            this.RulesMainLabel.BackColor = System.Drawing.Color.Transparent;
            this.RulesMainLabel.Font = new System.Drawing.Font("Cascadia Code", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RulesMainLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.RulesMainLabel.Location = new System.Drawing.Point(589, 102);
            this.RulesMainLabel.Name = "RulesMainLabel";
            this.RulesMainLabel.Size = new System.Drawing.Size(363, 63);
            this.RulesMainLabel.TabIndex = 4;
            this.RulesMainLabel.Text = "Правила игры";
            this.RulesMainLabel.Visible = false;
            // 
            // roolsLabel
            // 
            this.roolsLabel.AutoSize = true;
            this.roolsLabel.Location = new System.Drawing.Point(625, 224);
            this.roolsLabel.Name = "roolsLabel";
            this.roolsLabel.Size = new System.Drawing.Size(0, 13);
            this.roolsLabel.TabIndex = 5;
            this.roolsLabel.UseWaitCursor = true;
            // 
            // BackToMenuButton
            // 
            this.BackToMenuButton.BackColor = System.Drawing.Color.Transparent;
            this.BackToMenuButton.FlatAppearance.BorderSize = 3;
            this.BackToMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackToMenuButton.Font = new System.Drawing.Font("Cascadia Code SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackToMenuButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BackToMenuButton.Location = new System.Drawing.Point(204, 321);
            this.BackToMenuButton.Name = "BackToMenuButton";
            this.BackToMenuButton.Size = new System.Drawing.Size(318, 39);
            this.BackToMenuButton.TabIndex = 6;
            this.BackToMenuButton.Text = "Вернуться в основное меню";
            this.BackToMenuButton.UseVisualStyleBackColor = false;
            this.BackToMenuButton.Visible = false;
            this.BackToMenuButton.Click += new System.EventHandler(this.BackToMenuButton_Click);
            // 
            // RuleLabel
            // 
            this.RuleLabel.AutoSize = true;
            this.RuleLabel.Font = new System.Drawing.Font("Cascadia Code", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RuleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.RuleLabel.Location = new System.Drawing.Point(-41, 370);
            this.RuleLabel.Name = "RuleLabel";
            this.RuleLabel.Size = new System.Drawing.Size(716, 325);
            this.RuleLabel.TabIndex = 7;
            this.RuleLabel.Text = resources.GetString("RuleLabel.Text");
            this.RuleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RuleLabel.Visible = false;
            // 
            // Mode1Button
            // 
            this.Mode1Button.BackColor = System.Drawing.Color.Transparent;
            this.Mode1Button.FlatAppearance.BorderSize = 3;
            this.Mode1Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Mode1Button.Font = new System.Drawing.Font("Cascadia Code SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Mode1Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Mode1Button.Location = new System.Drawing.Point(204, 216);
            this.Mode1Button.Name = "Mode1Button";
            this.Mode1Button.Size = new System.Drawing.Size(318, 39);
            this.Mode1Button.TabIndex = 8;
            this.Mode1Button.Text = "Игра с пользователем ";
            this.Mode1Button.UseVisualStyleBackColor = false;
            this.Mode1Button.Visible = false;
            this.Mode1Button.Click += new System.EventHandler(this.Mode1Button_Click);
            // 
            // Mode2Button
            // 
            this.Mode2Button.BackColor = System.Drawing.Color.Transparent;
            this.Mode2Button.FlatAppearance.BorderSize = 3;
            this.Mode2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Mode2Button.Font = new System.Drawing.Font("Cascadia Code SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Mode2Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Mode2Button.Location = new System.Drawing.Point(204, 267);
            this.Mode2Button.Name = "Mode2Button";
            this.Mode2Button.Size = new System.Drawing.Size(318, 39);
            this.Mode2Button.TabIndex = 9;
            this.Mode2Button.Text = "Игра с компьютером";
            this.Mode2Button.UseVisualStyleBackColor = false;
            this.Mode2Button.Visible = false;
            this.Mode2Button.Click += new System.EventHandler(this.Mode2Button_Click);
            // 
            // ModeLabel
            // 
            this.ModeLabel.AutoSize = true;
            this.ModeLabel.BackColor = System.Drawing.Color.Transparent;
            this.ModeLabel.Font = new System.Drawing.Font("Cascadia Code", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ModeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ModeLabel.Location = new System.Drawing.Point(744, 9);
            this.ModeLabel.Name = "ModeLabel";
            this.ModeLabel.Size = new System.Drawing.Size(503, 63);
            this.ModeLabel.TabIndex = 10;
            this.ModeLabel.Text = "Выбор режима игры";
            this.ModeLabel.Visible = false;
            // 
            // CountNLabel
            // 
            this.CountNLabel.AutoSize = true;
            this.CountNLabel.BackColor = System.Drawing.Color.Transparent;
            this.CountNLabel.Font = new System.Drawing.Font("Cascadia Code", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountNLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.CountNLabel.Location = new System.Drawing.Point(1015, 224);
            this.CountNLabel.Name = "CountNLabel";
            this.CountNLabel.Size = new System.Drawing.Size(459, 39);
            this.CountNLabel.TabIndex = 11;
            this.CountNLabel.Text = "Начальное количество точек";
            this.CountNLabel.Visible = false;
            // 
            // Player1Label
            // 
            this.Player1Label.AutoSize = true;
            this.Player1Label.Font = new System.Drawing.Font("Cascadia Code", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Player1Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Player1Label.Location = new System.Drawing.Point(1004, 332);
            this.Player1Label.Name = "Player1Label";
            this.Player1Label.Size = new System.Drawing.Size(127, 35);
            this.Player1Label.TabIndex = 12;
            this.Player1Label.Text = "Игрок 1";
            this.Player1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Player1Label.Visible = false;
            // 
            // Player2Label
            // 
            this.Player2Label.AutoSize = true;
            this.Player2Label.Font = new System.Drawing.Font("Cascadia Code", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Player2Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Player2Label.Location = new System.Drawing.Point(1004, 376);
            this.Player2Label.Name = "Player2Label";
            this.Player2Label.Size = new System.Drawing.Size(127, 35);
            this.Player2Label.TabIndex = 13;
            this.Player2Label.Text = "Игрок 2";
            this.Player2Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Player2Label.Visible = false;
            // 
            // StartMode1Button
            // 
            this.StartMode1Button.BackColor = System.Drawing.Color.Transparent;
            this.StartMode1Button.FlatAppearance.BorderSize = 3;
            this.StartMode1Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartMode1Button.Font = new System.Drawing.Font("Cascadia Code SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartMode1Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.StartMode1Button.Location = new System.Drawing.Point(528, 370);
            this.StartMode1Button.Name = "StartMode1Button";
            this.StartMode1Button.Size = new System.Drawing.Size(318, 39);
            this.StartMode1Button.TabIndex = 14;
            this.StartMode1Button.Text = "Начать игру";
            this.StartMode1Button.UseVisualStyleBackColor = false;
            this.StartMode1Button.Visible = false;
            this.StartMode1Button.Click += new System.EventHandler(this.StartMode1Button_Click);
            // 
            // Player1Box
            // 
            this.Player1Box.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Player1Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Player1Box.Font = new System.Drawing.Font("Cascadia Code SemiBold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Player1Box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Player1Box.Location = new System.Drawing.Point(1178, 335);
            this.Player1Box.MaxLength = 15;
            this.Player1Box.Name = "Player1Box";
            this.Player1Box.Size = new System.Drawing.Size(200, 32);
            this.Player1Box.TabIndex = 15;
            this.Player1Box.Text = "A";
            this.Player1Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Player1Box.Visible = false;
            // 
            // Player2Box
            // 
            this.Player2Box.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Player2Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Player2Box.Font = new System.Drawing.Font("Cascadia Code SemiBold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Player2Box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Player2Box.Location = new System.Drawing.Point(1178, 384);
            this.Player2Box.MaxLength = 15;
            this.Player2Box.Name = "Player2Box";
            this.Player2Box.Size = new System.Drawing.Size(200, 32);
            this.Player2Box.TabIndex = 16;
            this.Player2Box.Text = "B";
            this.Player2Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Player2Box.Visible = false;
            // 
            // BackToChoiceModeButton
            // 
            this.BackToChoiceModeButton.BackColor = System.Drawing.Color.Transparent;
            this.BackToChoiceModeButton.FlatAppearance.BorderSize = 3;
            this.BackToChoiceModeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackToChoiceModeButton.Font = new System.Drawing.Font("Cascadia Code SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackToChoiceModeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BackToChoiceModeButton.Location = new System.Drawing.Point(528, 415);
            this.BackToChoiceModeButton.Name = "BackToChoiceModeButton";
            this.BackToChoiceModeButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BackToChoiceModeButton.Size = new System.Drawing.Size(318, 39);
            this.BackToChoiceModeButton.TabIndex = 18;
            this.BackToChoiceModeButton.Text = "Вернуться к выбору режима";
            this.BackToChoiceModeButton.UseVisualStyleBackColor = false;
            this.BackToChoiceModeButton.Visible = false;
            this.BackToChoiceModeButton.Click += new System.EventHandler(this.BackToChoiceModeButton_Click);
            // 
            // MoveLabel
            // 
            this.MoveLabel.AutoSize = true;
            this.MoveLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MoveLabel.Font = new System.Drawing.Font("Cascadia Code SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MoveLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.MoveLabel.Location = new System.Drawing.Point(1033, 177);
            this.MoveLabel.Name = "MoveLabel";
            this.MoveLabel.Size = new System.Drawing.Size(182, 32);
            this.MoveLabel.TabIndex = 19;
            this.MoveLabel.Text = "Ход игрока: ";
            this.MoveLabel.Visible = false;
            // 
            // StartMode2Button
            // 
            this.StartMode2Button.BackColor = System.Drawing.Color.Transparent;
            this.StartMode2Button.FlatAppearance.BorderSize = 3;
            this.StartMode2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartMode2Button.Font = new System.Drawing.Font("Cascadia Code SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartMode2Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.StartMode2Button.Location = new System.Drawing.Point(528, 216);
            this.StartMode2Button.Name = "StartMode2Button";
            this.StartMode2Button.Size = new System.Drawing.Size(318, 39);
            this.StartMode2Button.TabIndex = 21;
            this.StartMode2Button.Text = "Начать игру";
            this.StartMode2Button.UseVisualStyleBackColor = false;
            this.StartMode2Button.Visible = false;
            this.StartMode2Button.Click += new System.EventHandler(this.StartMode2Button_Click);
            // 
            // ButtonFinishGame
            // 
            this.ButtonFinishGame.BackColor = System.Drawing.Color.Transparent;
            this.ButtonFinishGame.FlatAppearance.BorderSize = 3;
            this.ButtonFinishGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonFinishGame.Font = new System.Drawing.Font("Cascadia Code SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonFinishGame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ButtonFinishGame.Location = new System.Drawing.Point(528, 321);
            this.ButtonFinishGame.Name = "ButtonFinishGame";
            this.ButtonFinishGame.Size = new System.Drawing.Size(318, 39);
            this.ButtonFinishGame.TabIndex = 22;
            this.ButtonFinishGame.Text = "Невозможно найти ход";
            this.ButtonFinishGame.UseVisualStyleBackColor = false;
            this.ButtonFinishGame.Visible = false;
            this.ButtonFinishGame.Click += new System.EventHandler(this.ButtonFinishGame_Click);
            // 
            // LabelWin
            // 
            this.LabelWin.AutoSize = true;
            this.LabelWin.Font = new System.Drawing.Font("Cascadia Code SemiBold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelWin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.LabelWin.Location = new System.Drawing.Point(269, 102);
            this.LabelWin.Name = "LabelWin";
            this.LabelWin.Size = new System.Drawing.Size(344, 52);
            this.LabelWin.TabIndex = 23;
            this.LabelWin.Text = "Победа игрока ";
            this.LabelWin.Visible = false;
            // 
            // TimerErrors
            // 
            this.TimerErrors.Tick += new System.EventHandler(this.TimerErrors_Tick);
            // 
            // IntersectError
            // 
            this.IntersectError.BackColor = System.Drawing.Color.Transparent;
            this.IntersectError.Enabled = false;
            this.IntersectError.FlatAppearance.BorderSize = 2;
            this.IntersectError.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IntersectError.Font = new System.Drawing.Font("Cascadia Code SemiBold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IntersectError.ForeColor = System.Drawing.Color.Brown;
            this.IntersectError.Location = new System.Drawing.Point(598, 158);
            this.IntersectError.Name = "IntersectError";
            this.IntersectError.Size = new System.Drawing.Size(300, 62);
            this.IntersectError.TabIndex = 25;
            this.IntersectError.Text = "Ошибка пересечения!";
            this.IntersectError.UseVisualStyleBackColor = false;
            this.IntersectError.Visible = false;
            // 
            // connectionError
            // 
            this.connectionError.BackColor = System.Drawing.Color.Transparent;
            this.connectionError.Enabled = false;
            this.connectionError.FlatAppearance.BorderSize = 2;
            this.connectionError.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.connectionError.Font = new System.Drawing.Font("Cascadia Code SemiBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.connectionError.ForeColor = System.Drawing.Color.Brown;
            this.connectionError.Location = new System.Drawing.Point(212, 147);
            this.connectionError.Name = "connectionError";
            this.connectionError.Size = new System.Drawing.Size(380, 62);
            this.connectionError.TabIndex = 26;
            this.connectionError.Text = "Невозможно соединить вершины!";
            this.connectionError.UseVisualStyleBackColor = false;
            this.connectionError.Visible = false;
            // 
            // ControlButton
            // 
            this.ControlButton.BackColor = System.Drawing.Color.Transparent;
            this.ControlButton.FlatAppearance.BorderSize = 3;
            this.ControlButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ControlButton.Font = new System.Drawing.Font("Cascadia Code SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ControlButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ControlButton.Location = new System.Drawing.Point(27, 261);
            this.ControlButton.Name = "ControlButton";
            this.ControlButton.Size = new System.Drawing.Size(170, 45);
            this.ControlButton.TabIndex = 28;
            this.ControlButton.Text = "Управление";
            this.ControlButton.UseVisualStyleBackColor = false;
            this.ControlButton.Click += new System.EventHandler(this.ControlButton_Click);
            // 
            // ControlLabel
            // 
            this.ControlLabel.AutoSize = true;
            this.ControlLabel.Font = new System.Drawing.Font("Cascadia Code SemiBold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ControlLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ControlLabel.Location = new System.Drawing.Point(12, 7);
            this.ControlLabel.Name = "ControlLabel";
            this.ControlLabel.Size = new System.Drawing.Size(699, 63);
            this.ControlLabel.TabIndex = 29;
            this.ControlLabel.Text = "Управление во время игры";
            this.ControlLabel.Visible = false;
            // 
            // ControlTextLabel
            // 
            this.ControlTextLabel.AutoSize = true;
            this.ControlTextLabel.Font = new System.Drawing.Font("Cascadia Code", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ControlTextLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ControlTextLabel.Location = new System.Drawing.Point(468, 453);
            this.ControlTextLabel.Name = "ControlTextLabel";
            this.ControlTextLabel.Size = new System.Drawing.Size(687, 175);
            this.ControlTextLabel.TabIndex = 30;
            this.ControlTextLabel.Text = "LBM: Взаимодействие с элементами меню\r\n\r\nЗажать LBM и провести линию: Выполнить х" +
    "од\r\n\r\nESC: Выход в основное меню";
            this.ControlTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ControlTextLabel.Visible = false;
            // 
            // BackToGameButton
            // 
            this.BackToGameButton.BackColor = System.Drawing.Color.Transparent;
            this.BackToGameButton.FlatAppearance.BorderSize = 3;
            this.BackToGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackToGameButton.Font = new System.Drawing.Font("Cascadia Code SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackToGameButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BackToGameButton.Location = new System.Drawing.Point(528, 267);
            this.BackToGameButton.Name = "BackToGameButton";
            this.BackToGameButton.Size = new System.Drawing.Size(318, 39);
            this.BackToGameButton.TabIndex = 31;
            this.BackToGameButton.Text = "Вернуться к игре";
            this.BackToGameButton.UseVisualStyleBackColor = false;
            this.BackToGameButton.Visible = false;
            this.BackToGameButton.Click += new System.EventHandler(this.BackToGameButton_Click);
            // 
            // BackFramePicBox
            // 
            this.BackFramePicBox.BackColor = System.Drawing.Color.Transparent;
            this.BackFramePicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BackFramePicBox.Image = ((System.Drawing.Image)(resources.GetObject("BackFramePicBox.Image")));
            this.BackFramePicBox.Location = new System.Drawing.Point(895, 147);
            this.BackFramePicBox.Name = "BackFramePicBox";
            this.BackFramePicBox.Size = new System.Drawing.Size(108, 108);
            this.BackFramePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BackFramePicBox.TabIndex = 32;
            this.BackFramePicBox.TabStop = false;
            // 
            // infButton
            // 
            this.infButton.BackColor = System.Drawing.Color.MintCream;
            this.infButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("infButton.BackgroundImage")));
            this.infButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.infButton.Cursor = System.Windows.Forms.Cursors.Cross;
            this.infButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.infButton.FlatAppearance.BorderSize = 0;
            this.infButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.infButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.infButton.Location = new System.Drawing.Point(567, 551);
            this.infButton.Name = "infButton";
            this.infButton.Size = new System.Drawing.Size(40, 38);
            this.infButton.TabIndex = 33;
            this.infButton.UseVisualStyleBackColor = false;
            this.infButton.Visible = false;
            this.infButton.Click += new System.EventHandler(this.InfButton_Click);
            // 
            // n10
            // 
            this.n10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.n10.FlatAppearance.BorderSize = 3;
            this.n10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.n10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.n10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.n10.Location = new System.Drawing.Point(543, 3);
            this.n10.Name = "n10";
            this.n10.Size = new System.Drawing.Size(56, 50);
            this.n10.TabIndex = 9;
            this.n10.Text = "10";
            this.n10.UseVisualStyleBackColor = true;
            // 
            // n9
            // 
            this.n9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.n9.FlatAppearance.BorderSize = 3;
            this.n9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.n9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.n9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.n9.Location = new System.Drawing.Point(483, 3);
            this.n9.Name = "n9";
            this.n9.Size = new System.Drawing.Size(54, 50);
            this.n9.TabIndex = 8;
            this.n9.Text = "9";
            this.n9.UseVisualStyleBackColor = true;
            // 
            // n8
            // 
            this.n8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.n8.FlatAppearance.BorderSize = 3;
            this.n8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.n8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.n8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.n8.Location = new System.Drawing.Point(423, 3);
            this.n8.Name = "n8";
            this.n8.Size = new System.Drawing.Size(54, 50);
            this.n8.TabIndex = 7;
            this.n8.Text = "8";
            this.n8.UseVisualStyleBackColor = true;
            // 
            // n7
            // 
            this.n7.BackColor = System.Drawing.Color.MintCream;
            this.n7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.n7.FlatAppearance.BorderSize = 3;
            this.n7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.n7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.n7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.n7.Location = new System.Drawing.Point(363, 3);
            this.n7.Name = "n7";
            this.n7.Size = new System.Drawing.Size(54, 50);
            this.n7.TabIndex = 6;
            this.n7.Text = "7";
            this.n7.UseVisualStyleBackColor = false;
            // 
            // n6
            // 
            this.n6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.n6.FlatAppearance.BorderSize = 3;
            this.n6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.n6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.n6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.n6.Location = new System.Drawing.Point(303, 3);
            this.n6.Name = "n6";
            this.n6.Size = new System.Drawing.Size(54, 50);
            this.n6.TabIndex = 5;
            this.n6.Text = "6";
            this.n6.UseVisualStyleBackColor = true;
            // 
            // n5
            // 
            this.n5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.n5.FlatAppearance.BorderSize = 3;
            this.n5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.n5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.n5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.n5.Location = new System.Drawing.Point(243, 3);
            this.n5.Name = "n5";
            this.n5.Size = new System.Drawing.Size(54, 50);
            this.n5.TabIndex = 4;
            this.n5.Text = "5";
            this.n5.UseVisualStyleBackColor = true;
            // 
            // n4
            // 
            this.n4.BackColor = System.Drawing.Color.MintCream;
            this.n4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.n4.FlatAppearance.BorderSize = 3;
            this.n4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.n4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.n4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.n4.Location = new System.Drawing.Point(183, 3);
            this.n4.Name = "n4";
            this.n4.Size = new System.Drawing.Size(54, 50);
            this.n4.TabIndex = 3;
            this.n4.Text = "4";
            this.n4.UseVisualStyleBackColor = false;
            // 
            // n3
            // 
            this.n3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.n3.FlatAppearance.BorderSize = 3;
            this.n3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.n3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.n3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.n3.Location = new System.Drawing.Point(123, 3);
            this.n3.Name = "n3";
            this.n3.Size = new System.Drawing.Size(54, 50);
            this.n3.TabIndex = 2;
            this.n3.Text = "3";
            this.n3.UseVisualStyleBackColor = true;
            // 
            // n2
            // 
            this.n2.BackColor = System.Drawing.Color.MintCream;
            this.n2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.n2.FlatAppearance.BorderSize = 3;
            this.n2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.n2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.n2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.n2.Location = new System.Drawing.Point(63, 3);
            this.n2.Name = "n2";
            this.n2.Size = new System.Drawing.Size(54, 50);
            this.n2.TabIndex = 1;
            this.n2.Text = "2";
            this.n2.UseVisualStyleBackColor = false;
            // 
            // n1
            // 
            this.n1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.n1.BackColor = System.Drawing.Color.SeaShell;
            this.n1.FlatAppearance.BorderSize = 3;
            this.n1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.n1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.n1.ForeColor = System.Drawing.Color.Maroon;
            this.n1.Location = new System.Drawing.Point(3, 3);
            this.n1.Name = "n1";
            this.n1.Size = new System.Drawing.Size(54, 50);
            this.n1.TabIndex = 0;
            this.n1.Text = "1";
            this.n1.UseVisualStyleBackColor = false;
            // 
            // GameNameLabel
            // 
            this.GameNameLabel.Image = ((System.Drawing.Image)(resources.GetObject("GameNameLabel.Image")));
            this.GameNameLabel.Location = new System.Drawing.Point(996, 453);
            this.GameNameLabel.Name = "GameNameLabel";
            this.GameNameLabel.Size = new System.Drawing.Size(424, 121);
            this.GameNameLabel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GameNameLabel.TabIndex = 35;
            this.GameNameLabel.TabStop = false;
            // 
            // LabelCountMove
            // 
            this.LabelCountMove.AutoSize = true;
            this.LabelCountMove.Font = new System.Drawing.Font("Cascadia Code SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelCountMove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.LabelCountMove.Location = new System.Drawing.Point(990, 119);
            this.LabelCountMove.Name = "LabelCountMove";
            this.LabelCountMove.Size = new System.Drawing.Size(280, 32);
            this.LabelCountMove.TabIndex = 36;
            this.LabelCountMove.Text = "Количество ходов: 0";
            this.LabelCountMove.Visible = false;
            // 
            // retryButton
            // 
            this.retryButton.BackColor = System.Drawing.Color.MintCream;
            this.retryButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("retryButton.BackgroundImage")));
            this.retryButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.retryButton.Cursor = System.Windows.Forms.Cursors.Cross;
            this.retryButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.retryButton.FlatAppearance.BorderSize = 0;
            this.retryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.retryButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.retryButton.Location = new System.Drawing.Point(849, 551);
            this.retryButton.Name = "retryButton";
            this.retryButton.Size = new System.Drawing.Size(40, 38);
            this.retryButton.TabIndex = 37;
            this.retryButton.UseVisualStyleBackColor = false;
            this.retryButton.Visible = false;
            this.retryButton.Click += new System.EventHandler(this.RetryButton_Click);
            // 
            // WhileGamePicBox
            // 
            this.WhileGamePicBox.BackColor = System.Drawing.Color.Transparent;
            this.WhileGamePicBox.Image = ((System.Drawing.Image)(resources.GetObject("WhileGamePicBox.Image")));
            this.WhileGamePicBox.Location = new System.Drawing.Point(872, 415);
            this.WhileGamePicBox.Name = "WhileGamePicBox";
            this.WhileGamePicBox.Size = new System.Drawing.Size(375, 50);
            this.WhileGamePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.WhileGamePicBox.TabIndex = 38;
            this.WhileGamePicBox.TabStop = false;
            this.WhileGamePicBox.Visible = false;
            // 
            // AskRetryLabel
            // 
            this.AskRetryLabel.AutoSize = true;
            this.AskRetryLabel.BackColor = System.Drawing.Color.Transparent;
            this.AskRetryLabel.Font = new System.Drawing.Font("Cascadia Code", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AskRetryLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.AskRetryLabel.Location = new System.Drawing.Point(99, 53);
            this.AskRetryLabel.Name = "AskRetryLabel";
            this.AskRetryLabel.Size = new System.Drawing.Size(1056, 49);
            this.AskRetryLabel.TabIndex = 39;
            this.AskRetryLabel.Text = "Вы действительно хотите начать партию сначала? ";
            this.AskRetryLabel.Visible = false;
            // 
            // YesButton
            // 
            this.YesButton.BackColor = System.Drawing.Color.Transparent;
            this.YesButton.FlatAppearance.BorderSize = 3;
            this.YesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.YesButton.Font = new System.Drawing.Font("Cascadia Code SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.YesButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.YesButton.Location = new System.Drawing.Point(852, 276);
            this.YesButton.Name = "YesButton";
            this.YesButton.Size = new System.Drawing.Size(106, 45);
            this.YesButton.TabIndex = 40;
            this.YesButton.Text = "Да";
            this.YesButton.UseVisualStyleBackColor = false;
            this.YesButton.Visible = false;
            this.YesButton.Click += new System.EventHandler(this.YesButton_Click);
            // 
            // NoButton
            // 
            this.NoButton.BackColor = System.Drawing.Color.Transparent;
            this.NoButton.FlatAppearance.BorderSize = 3;
            this.NoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NoButton.Font = new System.Drawing.Font("Cascadia Code SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NoButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.NoButton.Location = new System.Drawing.Point(852, 338);
            this.NoButton.Name = "NoButton";
            this.NoButton.Size = new System.Drawing.Size(106, 45);
            this.NoButton.TabIndex = 41;
            this.NoButton.Text = "Нет";
            this.NoButton.UseVisualStyleBackColor = false;
            this.NoButton.Visible = false;
            this.NoButton.Click += new System.EventHandler(this.NoButton_Click);
            // 
            // AskBackMenuLabel
            // 
            this.AskBackMenuLabel.AutoSize = true;
            this.AskBackMenuLabel.BackColor = System.Drawing.Color.Transparent;
            this.AskBackMenuLabel.Font = new System.Drawing.Font("Cascadia Code", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AskBackMenuLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.AskBackMenuLabel.Location = new System.Drawing.Point(79, 224);
            this.AskBackMenuLabel.Name = "AskBackMenuLabel";
            this.AskBackMenuLabel.Size = new System.Drawing.Size(924, 49);
            this.AskBackMenuLabel.TabIndex = 42;
            this.AskBackMenuLabel.Text = "Вы действительно хотите вернуться в меню?";
            this.AskBackMenuLabel.Visible = false;
            // 
            // AskExitLabel
            // 
            this.AskExitLabel.AutoSize = true;
            this.AskExitLabel.BackColor = System.Drawing.Color.Transparent;
            this.AskExitLabel.Font = new System.Drawing.Font("Cascadia Code", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AskExitLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.AskExitLabel.Location = new System.Drawing.Point(173, 443);
            this.AskExitLabel.Name = "AskExitLabel";
            this.AskExitLabel.Size = new System.Drawing.Size(858, 49);
            this.AskExitLabel.TabIndex = 43;
            this.AskExitLabel.Text = "Вы действительно хотите выйти из игры?";
            this.AskExitLabel.Visible = false;
            // 
            // TablePanelMode1
            // 
            this.TablePanelMode1.ColumnCount = 10;
            this.TablePanelMode1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.TablePanelMode1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.TablePanelMode1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.TablePanelMode1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.TablePanelMode1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.TablePanelMode1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.TablePanelMode1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.TablePanelMode1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.TablePanelMode1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.TablePanelMode1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.TablePanelMode1.Controls.Add(this.n10, 9, 0);
            this.TablePanelMode1.Controls.Add(this.n9, 8, 0);
            this.TablePanelMode1.Controls.Add(this.n7, 6, 0);
            this.TablePanelMode1.Controls.Add(this.n6, 5, 0);
            this.TablePanelMode1.Controls.Add(this.n5, 4, 0);
            this.TablePanelMode1.Controls.Add(this.n8, 7, 0);
            this.TablePanelMode1.Controls.Add(this.n1, 0, 0);
            this.TablePanelMode1.Controls.Add(this.n2, 1, 0);
            this.TablePanelMode1.Controls.Add(this.n3, 2, 0);
            this.TablePanelMode1.Controls.Add(this.n4, 3, 0);
            this.TablePanelMode1.Location = new System.Drawing.Point(686, 46);
            this.TablePanelMode1.Name = "TablePanelMode1";
            this.TablePanelMode1.RowCount = 1;
            this.TablePanelMode1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TablePanelMode1.Size = new System.Drawing.Size(602, 56);
            this.TablePanelMode1.TabIndex = 44;
            this.TablePanelMode1.Visible = false;
            // 
            // Sprouts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1902, 999);
            this.Controls.Add(this.TablePanelMode1);
            this.Controls.Add(this.AskExitLabel);
            this.Controls.Add(this.AskBackMenuLabel);
            this.Controls.Add(this.NoButton);
            this.Controls.Add(this.YesButton);
            this.Controls.Add(this.AskRetryLabel);
            this.Controls.Add(this.retryButton);
            this.Controls.Add(this.LabelCountMove);
            this.Controls.Add(this.GameNameLabel);
            this.Controls.Add(this.infButton);
            this.Controls.Add(this.ModeLabel);
            this.Controls.Add(this.BackToGameButton);
            this.Controls.Add(this.ControlTextLabel);
            this.Controls.Add(this.ControlLabel);
            this.Controls.Add(this.ControlButton);
            this.Controls.Add(this.connectionError);
            this.Controls.Add(this.IntersectError);
            this.Controls.Add(this.LabelWin);
            this.Controls.Add(this.ButtonFinishGame);
            this.Controls.Add(this.StartMode2Button);
            this.Controls.Add(this.MoveLabel);
            this.Controls.Add(this.BackToChoiceModeButton);
            this.Controls.Add(this.Player2Box);
            this.Controls.Add(this.Player1Box);
            this.Controls.Add(this.StartMode1Button);
            this.Controls.Add(this.Player2Label);
            this.Controls.Add(this.Player1Label);
            this.Controls.Add(this.CountNLabel);
            this.Controls.Add(this.Mode2Button);
            this.Controls.Add(this.Mode1Button);
            this.Controls.Add(this.RuleLabel);
            this.Controls.Add(this.BackToMenuButton);
            this.Controls.Add(this.roolsLabel);
            this.Controls.Add(this.RulesMainLabel);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.RulesButton);
            this.Controls.Add(this.StartGameButton);
            this.Controls.Add(this.BackFramePicBox);
            this.Controls.Add(this.WhileGamePicBox);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Sprouts";
            this.Text = "Sprouts";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Sprouts_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Sprouts_KeyPress);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Sprouts_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.BackFramePicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameNameLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WhileGamePicBox)).EndInit();
            this.TablePanelMode1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button StartGameButton;
        private System.Windows.Forms.Button RulesButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label RulesMainLabel;
        private System.Windows.Forms.Label roolsLabel;
        private System.Windows.Forms.Button BackToMenuButton;
        private System.Windows.Forms.Label RuleLabel;
        private System.Windows.Forms.Button Mode1Button;
        private System.Windows.Forms.Button Mode2Button;
        private System.Windows.Forms.Label ModeLabel;
        private System.Windows.Forms.Label CountNLabel;
        private System.Windows.Forms.Label Player1Label;
        private System.Windows.Forms.Label Player2Label;
        private System.Windows.Forms.Button StartMode1Button;
        private System.Windows.Forms.TextBox Player1Box;
        private System.Windows.Forms.TextBox Player2Box;
        private System.Windows.Forms.Button BackToChoiceModeButton;
        private System.Windows.Forms.Label MoveLabel;
        private System.Windows.Forms.Button StartMode2Button;
        private System.Windows.Forms.Button ButtonFinishGame;
        private System.Windows.Forms.Label LabelWin;
        private System.Windows.Forms.Timer TimerErrors;
        private System.Windows.Forms.Button IntersectError;
        private System.Windows.Forms.Button connectionError;
        private System.Windows.Forms.Button ControlButton;
        private System.Windows.Forms.Label ControlLabel;
        private System.Windows.Forms.Label ControlTextLabel;
        private System.Windows.Forms.Button BackToGameButton;
        private System.Windows.Forms.PictureBox BackFramePicBox;
        private System.Windows.Forms.Button infButton;
        private System.Windows.Forms.Button n2;
        private System.Windows.Forms.Button n1;
        private System.Windows.Forms.Button n5;
        private System.Windows.Forms.Button n4;
        private System.Windows.Forms.Button n3;
        private System.Windows.Forms.Button n10;
        private System.Windows.Forms.Button n9;
        private System.Windows.Forms.Button n8;
        private System.Windows.Forms.Button n7;
        private System.Windows.Forms.Button n6;
        private System.Windows.Forms.PictureBox GameNameLabel;
        private System.Windows.Forms.Label LabelCountMove;
        private System.Windows.Forms.Button retryButton;
        private System.Windows.Forms.PictureBox WhileGamePicBox;
        private System.Windows.Forms.Label AskRetryLabel;
        private System.Windows.Forms.Button YesButton;
        private System.Windows.Forms.Button NoButton;
        private System.Windows.Forms.Label AskBackMenuLabel;
        private System.Windows.Forms.Label AskExitLabel;
        private System.Windows.Forms.TableLayoutPanel TablePanelMode1;
    }
}

