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
            this.gameNameLabel = new System.Windows.Forms.Label();
            this.startGameButton = new System.Windows.Forms.Button();
            this.roolsButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.roolsMainLabel = new System.Windows.Forms.Label();
            this.roolsLabel = new System.Windows.Forms.Label();
            this.backToMenuButton = new System.Windows.Forms.Button();
            this.roolLabel = new System.Windows.Forms.Label();
            this.mode1Button = new System.Windows.Forms.Button();
            this.mode2Button = new System.Windows.Forms.Button();
            this.modeLabel = new System.Windows.Forms.Label();
            this.countNLabel = new System.Windows.Forms.Label();
            this.player1Label = new System.Windows.Forms.Label();
            this.player2Label = new System.Windows.Forms.Label();
            this.startMode1Button = new System.Windows.Forms.Button();
            this.player1Box = new System.Windows.Forms.TextBox();
            this.player2Box = new System.Windows.Forms.TextBox();
            this.countNBox = new System.Windows.Forms.NumericUpDown();
            this.backToChoiceModeButton = new System.Windows.Forms.Button();
            this.moveLabel = new System.Windows.Forms.Label();
            this.startMode2Button = new System.Windows.Forms.Button();
            this.buttonFinishGame = new System.Windows.Forms.Button();
            this.labelWin = new System.Windows.Forms.Label();
            this.timerErrors = new System.Windows.Forms.Timer(this.components);
            this.intersectError = new System.Windows.Forms.Button();
            this.connectionError = new System.Windows.Forms.Button();
            this.controlButton = new System.Windows.Forms.Button();
            this.controlLabel = new System.Windows.Forms.Label();
            this.controlTextLabel = new System.Windows.Forms.Label();
            this.backToGameButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.countNBox)).BeginInit();
            this.SuspendLayout();
            // 
            // gameNameLabel
            // 
            this.gameNameLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.gameNameLabel.AutoSize = true;
            this.gameNameLabel.Font = new System.Drawing.Font("Cascadia Code", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gameNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gameNameLabel.Location = new System.Drawing.Point(293, 79);
            this.gameNameLabel.Name = "gameNameLabel";
            this.gameNameLabel.Size = new System.Drawing.Size(195, 63);
            this.gameNameLabel.TabIndex = 0;
            this.gameNameLabel.Text = "Ростки";
            // 
            // startGameButton
            // 
            this.startGameButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.startGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startGameButton.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startGameButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.startGameButton.Location = new System.Drawing.Point(304, 161);
            this.startGameButton.Name = "startGameButton";
            this.startGameButton.Size = new System.Drawing.Size(170, 45);
            this.startGameButton.TabIndex = 1;
            this.startGameButton.Text = "Выбор режима";
            this.startGameButton.UseVisualStyleBackColor = false;
            this.startGameButton.Click += new System.EventHandler(this.startGameButton_Click);
            // 
            // roolsButton
            // 
            this.roolsButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.roolsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roolsButton.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roolsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.roolsButton.Location = new System.Drawing.Point(304, 224);
            this.roolsButton.Name = "roolsButton";
            this.roolsButton.Size = new System.Drawing.Size(170, 45);
            this.roolsButton.TabIndex = 2;
            this.roolsButton.Text = "Правила игры";
            this.roolsButton.UseVisualStyleBackColor = false;
            this.roolsButton.Click += new System.EventHandler(this.roolsButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.exitButton.Location = new System.Drawing.Point(304, 346);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(170, 45);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Выход из игры";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // roolsMainLabel
            // 
            this.roolsMainLabel.AutoSize = true;
            this.roolsMainLabel.Font = new System.Drawing.Font("Cascadia Code", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roolsMainLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.roolsMainLabel.Location = new System.Drawing.Point(439, 378);
            this.roolsMainLabel.Name = "roolsMainLabel";
            this.roolsMainLabel.Size = new System.Drawing.Size(363, 63);
            this.roolsMainLabel.TabIndex = 4;
            this.roolsMainLabel.Text = "Правила игры";
            this.roolsMainLabel.Visible = false;
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
            // backToMenuButton
            // 
            this.backToMenuButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.backToMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backToMenuButton.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backToMenuButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.backToMenuButton.Location = new System.Drawing.Point(575, 345);
            this.backToMenuButton.Name = "backToMenuButton";
            this.backToMenuButton.Size = new System.Drawing.Size(213, 47);
            this.backToMenuButton.TabIndex = 6;
            this.backToMenuButton.Text = "Вернуться в меню";
            this.backToMenuButton.UseVisualStyleBackColor = false;
            this.backToMenuButton.Visible = false;
            this.backToMenuButton.Click += new System.EventHandler(this.backToMenuButton_Click);
            // 
            // roolLabel
            // 
            this.roolLabel.AutoSize = true;
            this.roolLabel.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roolLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.roolLabel.Location = new System.Drawing.Point(-16, 441);
            this.roolLabel.Name = "roolLabel";
            this.roolLabel.Size = new System.Drawing.Size(716, 325);
            this.roolLabel.TabIndex = 7;
            this.roolLabel.Text = resources.GetString("roolLabel.Text");
            this.roolLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.roolLabel.Visible = false;
            // 
            // mode1Button
            // 
            this.mode1Button.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.mode1Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mode1Button.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mode1Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mode1Button.Location = new System.Drawing.Point(528, 136);
            this.mode1Button.Name = "mode1Button";
            this.mode1Button.Size = new System.Drawing.Size(318, 39);
            this.mode1Button.TabIndex = 8;
            this.mode1Button.Text = "Игра с пользователем ";
            this.mode1Button.UseVisualStyleBackColor = false;
            this.mode1Button.Visible = false;
            this.mode1Button.Click += new System.EventHandler(this.mode1Button_Click);
            // 
            // mode2Button
            // 
            this.mode2Button.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.mode2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mode2Button.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mode2Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mode2Button.Location = new System.Drawing.Point(528, 198);
            this.mode2Button.Name = "mode2Button";
            this.mode2Button.Size = new System.Drawing.Size(318, 39);
            this.mode2Button.TabIndex = 9;
            this.mode2Button.Text = "Игра с компьютером";
            this.mode2Button.UseVisualStyleBackColor = false;
            this.mode2Button.Visible = false;
            this.mode2Button.Click += new System.EventHandler(this.mode2Button_Click);
            // 
            // modeLabel
            // 
            this.modeLabel.AutoSize = true;
            this.modeLabel.Font = new System.Drawing.Font("Cascadia Code", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.modeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.modeLabel.Location = new System.Drawing.Point(343, 26);
            this.modeLabel.Name = "modeLabel";
            this.modeLabel.Size = new System.Drawing.Size(503, 63);
            this.modeLabel.TabIndex = 10;
            this.modeLabel.Text = "Выбор режима игры";
            this.modeLabel.Visible = false;
            // 
            // countNLabel
            // 
            this.countNLabel.AutoSize = true;
            this.countNLabel.BackColor = System.Drawing.Color.LightGray;
            this.countNLabel.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countNLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.countNLabel.Location = new System.Drawing.Point(792, 136);
            this.countNLabel.Name = "countNLabel";
            this.countNLabel.Size = new System.Drawing.Size(216, 56);
            this.countNLabel.TabIndex = 11;
            this.countNLabel.Text = "Начальное \r\nколичество точек:";
            this.countNLabel.Visible = false;
            // 
            // player1Label
            // 
            this.player1Label.AutoSize = true;
            this.player1Label.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.player1Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.player1Label.Location = new System.Drawing.Point(792, 205);
            this.player1Label.Name = "player1Label";
            this.player1Label.Size = new System.Drawing.Size(120, 28);
            this.player1Label.TabIndex = 12;
            this.player1Label.Text = "Игрок 1: ";
            this.player1Label.Visible = false;
            // 
            // player2Label
            // 
            this.player2Label.AutoSize = true;
            this.player2Label.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.player2Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.player2Label.Location = new System.Drawing.Point(792, 249);
            this.player2Label.Name = "player2Label";
            this.player2Label.Size = new System.Drawing.Size(108, 28);
            this.player2Label.TabIndex = 13;
            this.player2Label.Text = "Игрок 2:";
            this.player2Label.Visible = false;
            // 
            // startMode1Button
            // 
            this.startMode1Button.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.startMode1Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startMode1Button.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startMode1Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.startMode1Button.Location = new System.Drawing.Point(885, 324);
            this.startMode1Button.Name = "startMode1Button";
            this.startMode1Button.Size = new System.Drawing.Size(331, 56);
            this.startMode1Button.TabIndex = 14;
            this.startMode1Button.Text = "Начать игру";
            this.startMode1Button.UseVisualStyleBackColor = false;
            this.startMode1Button.Visible = false;
            this.startMode1Button.Click += new System.EventHandler(this.startMode1Button_Click);
            // 
            // player1Box
            // 
            this.player1Box.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.player1Box.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.player1Box.Location = new System.Drawing.Point(1022, 210);
            this.player1Box.MaxLength = 15;
            this.player1Box.Name = "player1Box";
            this.player1Box.Size = new System.Drawing.Size(141, 20);
            this.player1Box.TabIndex = 15;
            this.player1Box.Text = "A";
            this.player1Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.player1Box.Visible = false;
            this.player1Box.TextChanged += new System.EventHandler(this.player1Box_TextChanged);
            // 
            // player2Box
            // 
            this.player2Box.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.player2Box.Location = new System.Drawing.Point(1022, 249);
            this.player2Box.MaxLength = 15;
            this.player2Box.Name = "player2Box";
            this.player2Box.Size = new System.Drawing.Size(141, 20);
            this.player2Box.TabIndex = 16;
            this.player2Box.Text = "B";
            this.player2Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.player2Box.Visible = false;
            this.player2Box.TextChanged += new System.EventHandler(this.player2Box_TextChanged);
            // 
            // countNBox
            // 
            this.countNBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.countNBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.countNBox.Location = new System.Drawing.Point(1022, 166);
            this.countNBox.Name = "countNBox";
            this.countNBox.Size = new System.Drawing.Size(141, 20);
            this.countNBox.TabIndex = 17;
            this.countNBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.countNBox.Visible = false;
            // 
            // backToChoiceModeButton
            // 
            this.backToChoiceModeButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.backToChoiceModeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backToChoiceModeButton.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backToChoiceModeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.backToChoiceModeButton.Location = new System.Drawing.Point(885, 412);
            this.backToChoiceModeButton.Name = "backToChoiceModeButton";
            this.backToChoiceModeButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.backToChoiceModeButton.Size = new System.Drawing.Size(331, 56);
            this.backToChoiceModeButton.TabIndex = 18;
            this.backToChoiceModeButton.Text = "Вернуться к выбору режима";
            this.backToChoiceModeButton.UseVisualStyleBackColor = false;
            this.backToChoiceModeButton.Visible = false;
            this.backToChoiceModeButton.Click += new System.EventHandler(this.backToChoiceModeButton_Click);
            // 
            // moveLabel
            // 
            this.moveLabel.AutoSize = true;
            this.moveLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.moveLabel.Font = new System.Drawing.Font("Cascadia Code SemiBold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.moveLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.moveLabel.Location = new System.Drawing.Point(1038, 42);
            this.moveLabel.Name = "moveLabel";
            this.moveLabel.Size = new System.Drawing.Size(111, 35);
            this.moveLabel.TabIndex = 19;
            this.moveLabel.Text = "moveP1";
            this.moveLabel.Visible = false;
            // 
            // startMode2Button
            // 
            this.startMode2Button.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.startMode2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startMode2Button.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startMode2Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.startMode2Button.Location = new System.Drawing.Point(487, 378);
            this.startMode2Button.Name = "startMode2Button";
            this.startMode2Button.Size = new System.Drawing.Size(331, 56);
            this.startMode2Button.TabIndex = 21;
            this.startMode2Button.Text = "Начать игру";
            this.startMode2Button.UseVisualStyleBackColor = false;
            this.startMode2Button.Visible = false;
            this.startMode2Button.Click += new System.EventHandler(this.startMode2Button_Click);
            // 
            // buttonFinishGame
            // 
            this.buttonFinishGame.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonFinishGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFinishGame.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFinishGame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonFinishGame.Location = new System.Drawing.Point(470, 519);
            this.buttonFinishGame.Name = "buttonFinishGame";
            this.buttonFinishGame.Size = new System.Drawing.Size(318, 39);
            this.buttonFinishGame.TabIndex = 22;
            this.buttonFinishGame.Text = "Невозможно найти ход";
            this.buttonFinishGame.UseVisualStyleBackColor = false;
            this.buttonFinishGame.Visible = false;
            this.buttonFinishGame.Click += new System.EventHandler(this.buttonFinishGame_Click);
            // 
            // labelWin
            // 
            this.labelWin.AutoSize = true;
            this.labelWin.Font = new System.Drawing.Font("Cascadia Code SemiBold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelWin.Location = new System.Drawing.Point(462, 240);
            this.labelWin.Name = "labelWin";
            this.labelWin.Size = new System.Drawing.Size(314, 46);
            this.labelWin.TabIndex = 23;
            this.labelWin.Text = "Победа игрока ";
            this.labelWin.Visible = false;
            // 
            // timerErrors
            // 
            this.timerErrors.Tick += new System.EventHandler(this.timerErrors_Tick);
            // 
            // intersectError
            // 
            this.intersectError.BackColor = System.Drawing.Color.Gainsboro;
            this.intersectError.Enabled = false;
            this.intersectError.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.intersectError.Font = new System.Drawing.Font("Cascadia Code SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.intersectError.ForeColor = System.Drawing.Color.Brown;
            this.intersectError.Location = new System.Drawing.Point(58, 324);
            this.intersectError.Name = "intersectError";
            this.intersectError.Size = new System.Drawing.Size(261, 45);
            this.intersectError.TabIndex = 25;
            this.intersectError.Text = "Ошибка пересечения!";
            this.intersectError.UseVisualStyleBackColor = false;
            this.intersectError.Visible = false;
            // 
            // connectionError
            // 
            this.connectionError.BackColor = System.Drawing.Color.Gainsboro;
            this.connectionError.Enabled = false;
            this.connectionError.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.connectionError.Font = new System.Drawing.Font("Cascadia Code SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.connectionError.ForeColor = System.Drawing.Color.Brown;
            this.connectionError.Location = new System.Drawing.Point(480, 280);
            this.connectionError.Name = "connectionError";
            this.connectionError.Size = new System.Drawing.Size(380, 45);
            this.connectionError.TabIndex = 26;
            this.connectionError.Text = "Невозможно соединить вершины!";
            this.connectionError.UseVisualStyleBackColor = false;
            this.connectionError.Visible = false;
            // 
            // controlButton
            // 
            this.controlButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.controlButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.controlButton.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.controlButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.controlButton.Location = new System.Drawing.Point(304, 289);
            this.controlButton.Name = "controlButton";
            this.controlButton.Size = new System.Drawing.Size(170, 45);
            this.controlButton.TabIndex = 28;
            this.controlButton.Text = "Управление";
            this.controlButton.UseVisualStyleBackColor = false;
            this.controlButton.Click += new System.EventHandler(this.controlButton_Click);
            // 
            // controlLabel
            // 
            this.controlLabel.AutoSize = true;
            this.controlLabel.Font = new System.Drawing.Font("Cascadia Code SemiBold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.controlLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.controlLabel.Location = new System.Drawing.Point(36, 9);
            this.controlLabel.Name = "controlLabel";
            this.controlLabel.Size = new System.Drawing.Size(699, 63);
            this.controlLabel.TabIndex = 29;
            this.controlLabel.Text = "Управление во время игры";
            this.controlLabel.Visible = false;
            // 
            // controlTextLabel
            // 
            this.controlTextLabel.AutoSize = true;
            this.controlTextLabel.Font = new System.Drawing.Font("Cascadia Code", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.controlTextLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.controlTextLabel.Location = new System.Drawing.Point(39, 79);
            this.controlTextLabel.Name = "controlTextLabel";
            this.controlTextLabel.Size = new System.Drawing.Size(702, 58);
            this.controlTextLabel.TabIndex = 30;
            this.controlTextLabel.Text = "LBM: нарисовать линию на поле\r\nESC: посмотреть правила игры / выйти в основное ме" +
    "ню ";
            this.controlTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.controlTextLabel.Visible = false;
            // 
            // backToGameButton
            // 
            this.backToGameButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.backToGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backToGameButton.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backToGameButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.backToGameButton.Location = new System.Drawing.Point(58, 222);
            this.backToGameButton.Name = "backToGameButton";
            this.backToGameButton.Size = new System.Drawing.Size(213, 47);
            this.backToGameButton.TabIndex = 31;
            this.backToGameButton.Text = "Вернуться к игре";
            this.backToGameButton.UseVisualStyleBackColor = false;
            this.backToGameButton.Visible = false;
            this.backToGameButton.Click += new System.EventHandler(this.backToGameButton_Click);
            // 
            // Sprouts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1902, 999);
            this.Controls.Add(this.backToGameButton);
            this.Controls.Add(this.controlTextLabel);
            this.Controls.Add(this.controlLabel);
            this.Controls.Add(this.controlButton);
            this.Controls.Add(this.connectionError);
            this.Controls.Add(this.intersectError);
            this.Controls.Add(this.labelWin);
            this.Controls.Add(this.buttonFinishGame);
            this.Controls.Add(this.startMode2Button);
            this.Controls.Add(this.moveLabel);
            this.Controls.Add(this.backToChoiceModeButton);
            this.Controls.Add(this.countNBox);
            this.Controls.Add(this.player2Box);
            this.Controls.Add(this.player1Box);
            this.Controls.Add(this.startMode1Button);
            this.Controls.Add(this.player2Label);
            this.Controls.Add(this.player1Label);
            this.Controls.Add(this.countNLabel);
            this.Controls.Add(this.modeLabel);
            this.Controls.Add(this.mode2Button);
            this.Controls.Add(this.mode1Button);
            this.Controls.Add(this.roolLabel);
            this.Controls.Add(this.backToMenuButton);
            this.Controls.Add(this.roolsLabel);
            this.Controls.Add(this.roolsMainLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.roolsButton);
            this.Controls.Add(this.startGameButton);
            this.Controls.Add(this.gameNameLabel);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(700, 800);
            this.Name = "Sprouts";
            this.Text = "Sprouts";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Sprouts_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Sprouts_KeyPress);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Sprouts_MouseMove);
            this.Resize += new System.EventHandler(this.Sprouts_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.countNBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gameNameLabel;
        private System.Windows.Forms.Button startGameButton;
        private System.Windows.Forms.Button roolsButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label roolsMainLabel;
        private System.Windows.Forms.Label roolsLabel;
        private System.Windows.Forms.Button backToMenuButton;
        private System.Windows.Forms.Label roolLabel;
        private System.Windows.Forms.Button mode1Button;
        private System.Windows.Forms.Button mode2Button;
        private System.Windows.Forms.Label modeLabel;
        private System.Windows.Forms.Label countNLabel;
        private System.Windows.Forms.Label player1Label;
        private System.Windows.Forms.Label player2Label;
        private System.Windows.Forms.Button startMode1Button;
        private System.Windows.Forms.TextBox player1Box;
        private System.Windows.Forms.TextBox player2Box;
        private System.Windows.Forms.NumericUpDown countNBox;
        private System.Windows.Forms.Button backToChoiceModeButton;
        private System.Windows.Forms.Label moveLabel;
        private System.Windows.Forms.Button startMode2Button;
        private System.Windows.Forms.Button buttonFinishGame;
        private System.Windows.Forms.Label labelWin;
        private System.Windows.Forms.Timer timerErrors;
        private System.Windows.Forms.Button intersectError;
        private System.Windows.Forms.Button connectionError;
        private System.Windows.Forms.Button controlButton;
        private System.Windows.Forms.Label controlLabel;
        private System.Windows.Forms.Label controlTextLabel;
        private System.Windows.Forms.Button backToGameButton;
    }
}

