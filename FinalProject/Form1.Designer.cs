namespace FinalProject {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.Players = new System.Windows.Forms.TabPage();
            this.rbEditPlayer = new System.Windows.Forms.RadioButton();
            this.rbViewPlayer = new System.Windows.Forms.RadioButton();
            this.dataGridViewPlayers = new System.Windows.Forms.DataGridView();
            this.gbViewPlayer = new System.Windows.Forms.GroupBox();
            this.txtViewPlayerAgeTo = new System.Windows.Forms.TextBox();
            this.txtViewPlayerAgeFrom = new System.Windows.Forms.TextBox();
            this.txtViewPlayerHeightTo = new System.Windows.Forms.TextBox();
            this.txtViewPlayerHeightFrom = new System.Windows.Forms.TextBox();
            this.txtViewPlayerWeightTo = new System.Windows.Forms.TextBox();
            this.txtViewPlayerWeightFrom = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtViewPlayerNumberTo = new System.Windows.Forms.TextBox();
            this.txtViewPlayerNumberFrom = new System.Windows.Forms.TextBox();
            this.txtViewPlayerPosition = new System.Windows.Forms.TextBox();
            this.btn_filter = new System.Windows.Forms.Button();
            this.cbViewPlayerTeam = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtViewPlayerLastName = new System.Windows.Forms.TextBox();
            this.btnClearPlayerFilter = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txtViewPlayerFirstName = new System.Windows.Forms.TextBox();
            this.gbEditPlayer = new System.Windows.Forms.GroupBox();
            this.numWeight = new System.Windows.Forms.NumericUpDown();
            this.numHeight = new System.Windows.Forms.NumericUpDown();
            this.numNumber = new System.Windows.Forms.NumericUpDown();
            this.numAge = new System.Windows.Forms.NumericUpDown();
            this.lblPlayerId = new System.Windows.Forms.Label();
            this.cbPlayerTeams = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.cbDeletePlayer = new System.Windows.Forms.CheckBox();
            this.btnUpdatePlayer = new System.Windows.Forms.Button();
            this.btnClearPlayer = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.btnAddPlayer = new System.Windows.Forms.Button();
            this.Teams = new System.Windows.Forms.TabPage();
            this.rbEditTeam = new System.Windows.Forms.RadioButton();
            this.rbViewTeam = new System.Windows.Forms.RadioButton();
            this.dataGridViewTeams = new System.Windows.Forms.DataGridView();
            this.gbViewTeam = new System.Windows.Forms.GroupBox();
            this.txtRankingTo = new System.Windows.Forms.TextBox();
            this.txtRankingFrom = new System.Windows.Forms.TextBox();
            this.txtFilterDivision = new System.Windows.Forms.TextBox();
            this.btnFilterTeam = new System.Windows.Forms.Button();
            this.txtFilterTeamName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClearTeamFilter = new System.Windows.Forms.Button();
            this.gbEditTeam = new System.Windows.Forms.GroupBox();
            this.txtDivision = new System.Windows.Forms.TextBox();
            this.btnAddTeam = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblTeamId = new System.Windows.Forms.Label();
            this.lblDivision = new System.Windows.Forms.Label();
            this.cbDeleteTeam = new System.Windows.Forms.CheckBox();
            this.btnClearTeams = new System.Windows.Forms.Button();
            this.btnUpdateTeam = new System.Windows.Forms.Button();
            this.trade = new System.Windows.Forms.TabPage();
            this.btn_confirmTrade = new System.Windows.Forms.Button();
            this.btn_tradeLeft = new System.Windows.Forms.Button();
            this.btn_tradeRight = new System.Windows.Forms.Button();
            this.lbTeam2 = new System.Windows.Forms.ListBox();
            this.lbTeam1 = new System.Windows.Forms.ListBox();
            this.btn_loadTrade = new System.Windows.Forms.Button();
            this.cbTeam2 = new System.Windows.Forms.ComboBox();
            this.cbTeam1 = new System.Windows.Forms.ComboBox();
            this.schedule = new System.Windows.Forms.TabPage();
            this.standings = new System.Windows.Forms.TabPage();
            this.dataGridViewStandings = new System.Windows.Forms.DataGridView();
            this.playersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cprojectDataSet = new FinalProject.cprojectDataSet();
            this.playersTableAdapter = new FinalProject.cprojectDataSetTableAdapters.playersTableAdapter();
            this.playersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.playersBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.errorTeamName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorFilterRankingTo = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorFilterRankingFrom = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorFilterAgeFrom = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorFilterAgeTo = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorFilterHeightFrom = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorFilterHeightTo = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorFilterWeightFrom = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorFilterWeightTo = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorNumberFrom = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorNumberTo = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorFilterNumberFrom = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorFilterNumberTo = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl.SuspendLayout();
            this.Players.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlayers)).BeginInit();
            this.gbViewPlayer.SuspendLayout();
            this.gbEditPlayer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).BeginInit();
            this.Teams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeams)).BeginInit();
            this.gbViewTeam.SuspendLayout();
            this.gbEditTeam.SuspendLayout();
            this.trade.SuspendLayout();
            this.standings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStandings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cprojectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTeamName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorFilterRankingTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorFilterRankingFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorFilterAgeFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorFilterAgeTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorFilterHeightFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorFilterHeightTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorFilterWeightFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorFilterWeightTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNumberFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNumberTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorFilterNumberFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorFilterNumberTo)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.Players);
            this.tabControl.Controls.Add(this.Teams);
            this.tabControl.Controls.Add(this.trade);
            this.tabControl.Controls.Add(this.schedule);
            this.tabControl.Controls.Add(this.standings);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(1);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(708, 416);
            this.tabControl.TabIndex = 0;
            // 
            // Players
            // 
            this.Players.Controls.Add(this.rbEditPlayer);
            this.Players.Controls.Add(this.rbViewPlayer);
            this.Players.Controls.Add(this.dataGridViewPlayers);
            this.Players.Controls.Add(this.gbEditPlayer);
            this.Players.Controls.Add(this.gbViewPlayer);
            this.Players.Location = new System.Drawing.Point(4, 22);
            this.Players.Margin = new System.Windows.Forms.Padding(1);
            this.Players.Name = "Players";
            this.Players.Padding = new System.Windows.Forms.Padding(1);
            this.Players.Size = new System.Drawing.Size(700, 390);
            this.Players.TabIndex = 0;
            this.Players.Text = "Players";
            this.Players.UseVisualStyleBackColor = true;
            // 
            // rbEditPlayer
            // 
            this.rbEditPlayer.AutoSize = true;
            this.rbEditPlayer.Location = new System.Drawing.Point(78, 16);
            this.rbEditPlayer.Name = "rbEditPlayer";
            this.rbEditPlayer.Size = new System.Drawing.Size(43, 17);
            this.rbEditPlayer.TabIndex = 38;
            this.rbEditPlayer.Text = "Edit";
            this.rbEditPlayer.UseVisualStyleBackColor = true;
            this.rbEditPlayer.CheckedChanged += new System.EventHandler(this.rbEditPlayer_CheckedChanged);
            // 
            // rbViewPlayer
            // 
            this.rbViewPlayer.AutoSize = true;
            this.rbViewPlayer.Checked = true;
            this.rbViewPlayer.Location = new System.Drawing.Point(15, 16);
            this.rbViewPlayer.Name = "rbViewPlayer";
            this.rbViewPlayer.Size = new System.Drawing.Size(48, 17);
            this.rbViewPlayer.TabIndex = 37;
            this.rbViewPlayer.TabStop = true;
            this.rbViewPlayer.Text = "View";
            this.rbViewPlayer.UseVisualStyleBackColor = true;
            this.rbViewPlayer.CheckedChanged += new System.EventHandler(this.rbViewPlayer_CheckedChanged);
            // 
            // dataGridViewPlayers
            // 
            this.dataGridViewPlayers.AllowUserToAddRows = false;
            this.dataGridViewPlayers.AllowUserToDeleteRows = false;
            this.dataGridViewPlayers.AllowUserToOrderColumns = true;
            this.dataGridViewPlayers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewPlayers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPlayers.Location = new System.Drawing.Point(3, 215);
            this.dataGridViewPlayers.Margin = new System.Windows.Forms.Padding(1);
            this.dataGridViewPlayers.Name = "dataGridViewPlayers";
            this.dataGridViewPlayers.RowTemplate.Height = 3;
            this.dataGridViewPlayers.RowTemplate.ReadOnly = true;
            this.dataGridViewPlayers.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPlayers.Size = new System.Drawing.Size(699, 179);
            this.dataGridViewPlayers.TabIndex = 0;
            this.dataGridViewPlayers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPlayers_CellClick);
            // 
            // gbViewPlayer
            // 
            this.gbViewPlayer.Controls.Add(this.txtViewPlayerAgeTo);
            this.gbViewPlayer.Controls.Add(this.txtViewPlayerAgeFrom);
            this.gbViewPlayer.Controls.Add(this.txtViewPlayerHeightTo);
            this.gbViewPlayer.Controls.Add(this.txtViewPlayerHeightFrom);
            this.gbViewPlayer.Controls.Add(this.txtViewPlayerWeightTo);
            this.gbViewPlayer.Controls.Add(this.txtViewPlayerWeightFrom);
            this.gbViewPlayer.Controls.Add(this.label14);
            this.gbViewPlayer.Controls.Add(this.label23);
            this.gbViewPlayer.Controls.Add(this.label16);
            this.gbViewPlayer.Controls.Add(this.label17);
            this.gbViewPlayer.Controls.Add(this.label19);
            this.gbViewPlayer.Controls.Add(this.txtViewPlayerNumberTo);
            this.gbViewPlayer.Controls.Add(this.txtViewPlayerNumberFrom);
            this.gbViewPlayer.Controls.Add(this.txtViewPlayerPosition);
            this.gbViewPlayer.Controls.Add(this.btn_filter);
            this.gbViewPlayer.Controls.Add(this.cbViewPlayerTeam);
            this.gbViewPlayer.Controls.Add(this.label15);
            this.gbViewPlayer.Controls.Add(this.label18);
            this.gbViewPlayer.Controls.Add(this.label20);
            this.gbViewPlayer.Controls.Add(this.txtViewPlayerLastName);
            this.gbViewPlayer.Controls.Add(this.btnClearPlayerFilter);
            this.gbViewPlayer.Controls.Add(this.label21);
            this.gbViewPlayer.Controls.Add(this.label22);
            this.gbViewPlayer.Controls.Add(this.txtViewPlayerFirstName);
            this.gbViewPlayer.Location = new System.Drawing.Point(3, 39);
            this.gbViewPlayer.Name = "gbViewPlayer";
            this.gbViewPlayer.Size = new System.Drawing.Size(695, 172);
            this.gbViewPlayer.TabIndex = 40;
            this.gbViewPlayer.TabStop = false;
            this.gbViewPlayer.Text = "View Player";
            // 
            // txtViewPlayerAgeTo
            // 
            this.txtViewPlayerAgeTo.Location = new System.Drawing.Point(502, 25);
            this.txtViewPlayerAgeTo.Name = "txtViewPlayerAgeTo";
            this.txtViewPlayerAgeTo.Size = new System.Drawing.Size(59, 20);
            this.txtViewPlayerAgeTo.TabIndex = 6;
            this.txtViewPlayerAgeTo.Validating += new System.ComponentModel.CancelEventHandler(this.txtViewPlayerAgeTo_Validating);
            // 
            // txtViewPlayerAgeFrom
            // 
            this.txtViewPlayerAgeFrom.Location = new System.Drawing.Point(420, 24);
            this.txtViewPlayerAgeFrom.Name = "txtViewPlayerAgeFrom";
            this.txtViewPlayerAgeFrom.Size = new System.Drawing.Size(59, 20);
            this.txtViewPlayerAgeFrom.TabIndex = 5;
            this.txtViewPlayerAgeFrom.Validating += new System.ComponentModel.CancelEventHandler(this.txtViewPlayerAgeFrom_Validating);
            // 
            // txtViewPlayerHeightTo
            // 
            this.txtViewPlayerHeightTo.Location = new System.Drawing.Point(502, 50);
            this.txtViewPlayerHeightTo.Name = "txtViewPlayerHeightTo";
            this.txtViewPlayerHeightTo.Size = new System.Drawing.Size(59, 20);
            this.txtViewPlayerHeightTo.TabIndex = 8;
            this.txtViewPlayerHeightTo.Validating += new System.ComponentModel.CancelEventHandler(this.txtViewPlayerHeightTo_Validating);
            // 
            // txtViewPlayerHeightFrom
            // 
            this.txtViewPlayerHeightFrom.Location = new System.Drawing.Point(420, 50);
            this.txtViewPlayerHeightFrom.Name = "txtViewPlayerHeightFrom";
            this.txtViewPlayerHeightFrom.Size = new System.Drawing.Size(59, 20);
            this.txtViewPlayerHeightFrom.TabIndex = 7;
            this.txtViewPlayerHeightFrom.Validating += new System.ComponentModel.CancelEventHandler(this.txtViewPlayerHeightFrom_Validating);
            // 
            // txtViewPlayerWeightTo
            // 
            this.txtViewPlayerWeightTo.Location = new System.Drawing.Point(502, 76);
            this.txtViewPlayerWeightTo.Name = "txtViewPlayerWeightTo";
            this.txtViewPlayerWeightTo.Size = new System.Drawing.Size(59, 20);
            this.txtViewPlayerWeightTo.TabIndex = 10;
            this.txtViewPlayerWeightTo.Validating += new System.ComponentModel.CancelEventHandler(this.txtViewPlayerWeightTo_Validating);
            // 
            // txtViewPlayerWeightFrom
            // 
            this.txtViewPlayerWeightFrom.Location = new System.Drawing.Point(420, 76);
            this.txtViewPlayerWeightFrom.Name = "txtViewPlayerWeightFrom";
            this.txtViewPlayerWeightFrom.Size = new System.Drawing.Size(59, 20);
            this.txtViewPlayerWeightFrom.TabIndex = 9;
            this.txtViewPlayerWeightFrom.Validating += new System.ComponentModel.CancelEventHandler(this.txtViewPlayerWeightFrom_Validating);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(503, 8);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(23, 13);
            this.label14.TabIndex = 33;
            this.label14.Text = "To:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(419, 8);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(33, 13);
            this.label23.TabIndex = 32;
            this.label23.Text = "From:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(358, 53);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 13);
            this.label16.TabIndex = 30;
            this.label16.Text = "Height:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(358, 81);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(47, 13);
            this.label17.TabIndex = 28;
            this.label17.Text = "Weight: ";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(357, 29);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(29, 13);
            this.label19.TabIndex = 24;
            this.label19.Text = "Age:";
            // 
            // txtViewPlayerNumberTo
            // 
            this.txtViewPlayerNumberTo.Location = new System.Drawing.Point(502, 102);
            this.txtViewPlayerNumberTo.Name = "txtViewPlayerNumberTo";
            this.txtViewPlayerNumberTo.Size = new System.Drawing.Size(59, 20);
            this.txtViewPlayerNumberTo.TabIndex = 12;
            this.txtViewPlayerNumberTo.Validating += new System.ComponentModel.CancelEventHandler(this.txtViewPlayerNumberTo_Validating);
            // 
            // txtViewPlayerNumberFrom
            // 
            this.txtViewPlayerNumberFrom.Location = new System.Drawing.Point(420, 103);
            this.txtViewPlayerNumberFrom.Name = "txtViewPlayerNumberFrom";
            this.txtViewPlayerNumberFrom.Size = new System.Drawing.Size(59, 20);
            this.txtViewPlayerNumberFrom.TabIndex = 11;
            this.txtViewPlayerNumberFrom.Validating += new System.ComponentModel.CancelEventHandler(this.txtViewPlayerNumberFrom_Validating);
            // 
            // txtViewPlayerPosition
            // 
            this.txtViewPlayerPosition.Location = new System.Drawing.Point(82, 124);
            this.txtViewPlayerPosition.Name = "txtViewPlayerPosition";
            this.txtViewPlayerPosition.Size = new System.Drawing.Size(59, 20);
            this.txtViewPlayerPosition.TabIndex = 4;
            // 
            // btn_filter
            // 
            this.btn_filter.Location = new System.Drawing.Point(604, 136);
            this.btn_filter.Margin = new System.Windows.Forms.Padding(1);
            this.btn_filter.Name = "btn_filter";
            this.btn_filter.Size = new System.Drawing.Size(75, 23);
            this.btn_filter.TabIndex = 14;
            this.btn_filter.Text = "Filter";
            this.btn_filter.UseVisualStyleBackColor = true;
            this.btn_filter.Click += new System.EventHandler(this.btn_filter_Click);
            // 
            // cbViewPlayerTeam
            // 
            this.cbViewPlayerTeam.FormattingEnabled = true;
            this.cbViewPlayerTeam.Location = new System.Drawing.Point(82, 91);
            this.cbViewPlayerTeam.Name = "cbViewPlayerTeam";
            this.cbViewPlayerTeam.Size = new System.Drawing.Size(188, 21);
            this.cbViewPlayerTeam.TabIndex = 3;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(13, 91);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(37, 13);
            this.label15.TabIndex = 31;
            this.label15.Text = "Team:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(15, 127);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(50, 13);
            this.label18.TabIndex = 26;
            this.label18.Text = "Position: ";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(13, 56);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(64, 13);
            this.label20.TabIndex = 22;
            this.label20.Text = "Last Name: ";
            // 
            // txtViewPlayerLastName
            // 
            this.txtViewPlayerLastName.Location = new System.Drawing.Point(82, 56);
            this.txtViewPlayerLastName.Name = "txtViewPlayerLastName";
            this.txtViewPlayerLastName.Size = new System.Drawing.Size(188, 20);
            this.txtViewPlayerLastName.TabIndex = 2;
            // 
            // btnClearPlayerFilter
            // 
            this.btnClearPlayerFilter.CausesValidation = false;
            this.btnClearPlayerFilter.Location = new System.Drawing.Point(511, 136);
            this.btnClearPlayerFilter.Name = "btnClearPlayerFilter";
            this.btnClearPlayerFilter.Size = new System.Drawing.Size(75, 23);
            this.btnClearPlayerFilter.TabIndex = 13;
            this.btnClearPlayerFilter.Text = "Clear";
            this.btnClearPlayerFilter.UseVisualStyleBackColor = true;
            this.btnClearPlayerFilter.Click += new System.EventHandler(this.btnClearPlayerFilter_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(358, 109);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(50, 13);
            this.label21.TabIndex = 17;
            this.label21.Text = "Number: ";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(13, 24);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(63, 13);
            this.label22.TabIndex = 16;
            this.label22.Text = "First Name: ";
            // 
            // txtViewPlayerFirstName
            // 
            this.txtViewPlayerFirstName.Location = new System.Drawing.Point(82, 21);
            this.txtViewPlayerFirstName.Name = "txtViewPlayerFirstName";
            this.txtViewPlayerFirstName.Size = new System.Drawing.Size(188, 20);
            this.txtViewPlayerFirstName.TabIndex = 1;
            // 
            // gbEditPlayer
            // 
            this.gbEditPlayer.Controls.Add(this.numWeight);
            this.gbEditPlayer.Controls.Add(this.numHeight);
            this.gbEditPlayer.Controls.Add(this.numNumber);
            this.gbEditPlayer.Controls.Add(this.numAge);
            this.gbEditPlayer.Controls.Add(this.lblPlayerId);
            this.gbEditPlayer.Controls.Add(this.cbPlayerTeams);
            this.gbEditPlayer.Controls.Add(this.label2);
            this.gbEditPlayer.Controls.Add(this.label7);
            this.gbEditPlayer.Controls.Add(this.label6);
            this.gbEditPlayer.Controls.Add(this.label8);
            this.gbEditPlayer.Controls.Add(this.txtPosition);
            this.gbEditPlayer.Controls.Add(this.label5);
            this.gbEditPlayer.Controls.Add(this.label4);
            this.gbEditPlayer.Controls.Add(this.txtLName);
            this.gbEditPlayer.Controls.Add(this.cbDeletePlayer);
            this.gbEditPlayer.Controls.Add(this.btnUpdatePlayer);
            this.gbEditPlayer.Controls.Add(this.btnClearPlayer);
            this.gbEditPlayer.Controls.Add(this.label9);
            this.gbEditPlayer.Controls.Add(this.label3);
            this.gbEditPlayer.Controls.Add(this.txtFName);
            this.gbEditPlayer.Controls.Add(this.btnAddPlayer);
            this.gbEditPlayer.Location = new System.Drawing.Point(4, 39);
            this.gbEditPlayer.Name = "gbEditPlayer";
            this.gbEditPlayer.Size = new System.Drawing.Size(695, 172);
            this.gbEditPlayer.TabIndex = 39;
            this.gbEditPlayer.TabStop = false;
            this.gbEditPlayer.Text = "Edit Player";
            // 
            // numWeight
            // 
            this.numWeight.Location = new System.Drawing.Point(78, 57);
            this.numWeight.Maximum = new decimal(new int[] {
            320,
            0,
            0,
            0});
            this.numWeight.Minimum = new decimal(new int[] {
            140,
            0,
            0,
            0});
            this.numWeight.Name = "numWeight";
            this.numWeight.Size = new System.Drawing.Size(56, 20);
            this.numWeight.TabIndex = 8;
            this.numWeight.Value = new decimal(new int[] {
            140,
            0,
            0,
            0});
            // 
            // numHeight
            // 
            this.numHeight.Location = new System.Drawing.Point(78, 98);
            this.numHeight.Maximum = new decimal(new int[] {
            210,
            0,
            0,
            0});
            this.numHeight.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numHeight.Name = "numHeight";
            this.numHeight.Size = new System.Drawing.Size(56, 20);
            this.numHeight.TabIndex = 10;
            this.numHeight.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numNumber
            // 
            this.numNumber.Location = new System.Drawing.Point(356, 95);
            this.numNumber.Name = "numNumber";
            this.numNumber.Size = new System.Drawing.Size(56, 20);
            this.numNumber.TabIndex = 12;
            // 
            // numAge
            // 
            this.numAge.Location = new System.Drawing.Point(580, 21);
            this.numAge.Maximum = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.numAge.Minimum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.numAge.Name = "numAge";
            this.numAge.Size = new System.Drawing.Size(56, 20);
            this.numAge.TabIndex = 7;
            this.numAge.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // lblPlayerId
            // 
            this.lblPlayerId.AutoSize = true;
            this.lblPlayerId.Location = new System.Drawing.Point(13, 136);
            this.lblPlayerId.Name = "lblPlayerId";
            this.lblPlayerId.Size = new System.Drawing.Size(50, 13);
            this.lblPlayerId.TabIndex = 33;
            this.lblPlayerId.Text = "Player ID";
            this.lblPlayerId.Visible = false;
            // 
            // cbPlayerTeams
            // 
            this.cbPlayerTeams.FormattingEnabled = true;
            this.cbPlayerTeams.Location = new System.Drawing.Point(220, 56);
            this.cbPlayerTeams.Name = "cbPlayerTeams";
            this.cbPlayerTeams.Size = new System.Drawing.Size(192, 21);
            this.cbPlayerTeams.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Team:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Height:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Weight: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(155, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Position: ";
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(220, 97);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(57, 20);
            this.txtPosition.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(546, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Age:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(277, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Last Name: ";
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(342, 21);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(182, 20);
            this.txtLName.TabIndex = 6;
            // 
            // cbDeletePlayer
            // 
            this.cbDeletePlayer.AutoSize = true;
            this.cbDeletePlayer.Location = new System.Drawing.Point(580, 95);
            this.cbDeletePlayer.Name = "cbDeletePlayer";
            this.cbDeletePlayer.Size = new System.Drawing.Size(90, 17);
            this.cbDeletePlayer.TabIndex = 13;
            this.cbDeletePlayer.Text = "Delete record";
            this.cbDeletePlayer.UseVisualStyleBackColor = true;
            this.cbDeletePlayer.CheckedChanged += new System.EventHandler(this.cbDeletePlayer_CheckedChanged);
            // 
            // btnUpdatePlayer
            // 
            this.btnUpdatePlayer.Location = new System.Drawing.Point(419, 136);
            this.btnUpdatePlayer.Name = "btnUpdatePlayer";
            this.btnUpdatePlayer.Size = new System.Drawing.Size(75, 23);
            this.btnUpdatePlayer.TabIndex = 14;
            this.btnUpdatePlayer.Text = "Update";
            this.btnUpdatePlayer.UseVisualStyleBackColor = true;
            this.btnUpdatePlayer.Click += new System.EventHandler(this.btnUpdatePlayer_Click);
            // 
            // btnClearPlayer
            // 
            this.btnClearPlayer.Location = new System.Drawing.Point(511, 136);
            this.btnClearPlayer.Name = "btnClearPlayer";
            this.btnClearPlayer.Size = new System.Drawing.Size(75, 23);
            this.btnClearPlayer.TabIndex = 15;
            this.btnClearPlayer.Text = "Clear";
            this.btnClearPlayer.UseVisualStyleBackColor = true;
            this.btnClearPlayer.Click += new System.EventHandler(this.btnClearPlayer_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(299, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Number: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "First Name: ";
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(77, 21);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(188, 20);
            this.txtFName.TabIndex = 5;
            // 
            // btnAddPlayer
            // 
            this.btnAddPlayer.Location = new System.Drawing.Point(603, 136);
            this.btnAddPlayer.Name = "btnAddPlayer";
            this.btnAddPlayer.Size = new System.Drawing.Size(75, 23);
            this.btnAddPlayer.TabIndex = 16;
            this.btnAddPlayer.Text = "Add";
            this.btnAddPlayer.UseVisualStyleBackColor = true;
            this.btnAddPlayer.Click += new System.EventHandler(this.btnAddPlayer_Click);
            // 
            // Teams
            // 
            this.Teams.Controls.Add(this.rbEditTeam);
            this.Teams.Controls.Add(this.rbViewTeam);
            this.Teams.Controls.Add(this.dataGridViewTeams);
            this.Teams.Controls.Add(this.gbEditTeam);
            this.Teams.Controls.Add(this.gbViewTeam);
            this.Teams.Location = new System.Drawing.Point(4, 22);
            this.Teams.Margin = new System.Windows.Forms.Padding(1);
            this.Teams.Name = "Teams";
            this.Teams.Padding = new System.Windows.Forms.Padding(1);
            this.Teams.Size = new System.Drawing.Size(700, 390);
            this.Teams.TabIndex = 1;
            this.Teams.Text = "Teams";
            this.Teams.UseVisualStyleBackColor = true;
            // 
            // rbEditTeam
            // 
            this.rbEditTeam.AutoSize = true;
            this.rbEditTeam.Location = new System.Drawing.Point(78, 16);
            this.rbEditTeam.Name = "rbEditTeam";
            this.rbEditTeam.Size = new System.Drawing.Size(43, 17);
            this.rbEditTeam.TabIndex = 36;
            this.rbEditTeam.Text = "Edit";
            this.rbEditTeam.UseVisualStyleBackColor = true;
            this.rbEditTeam.CheckedChanged += new System.EventHandler(this.rbEditTeam_CheckedChanged);
            // 
            // rbViewTeam
            // 
            this.rbViewTeam.AutoSize = true;
            this.rbViewTeam.Checked = true;
            this.rbViewTeam.Location = new System.Drawing.Point(15, 16);
            this.rbViewTeam.Name = "rbViewTeam";
            this.rbViewTeam.Size = new System.Drawing.Size(48, 17);
            this.rbViewTeam.TabIndex = 35;
            this.rbViewTeam.TabStop = true;
            this.rbViewTeam.Text = "View";
            this.rbViewTeam.UseVisualStyleBackColor = true;
            this.rbViewTeam.CheckedChanged += new System.EventHandler(this.rbViewTeam_CheckedChanged);
            // 
            // dataGridViewTeams
            // 
            this.dataGridViewTeams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTeams.Location = new System.Drawing.Point(333, 6);
            this.dataGridViewTeams.Margin = new System.Windows.Forms.Padding(1);
            this.dataGridViewTeams.Name = "dataGridViewTeams";
            this.dataGridViewTeams.RowTemplate.Height = 40;
            this.dataGridViewTeams.Size = new System.Drawing.Size(362, 378);
            this.dataGridViewTeams.TabIndex = 0;
            this.dataGridViewTeams.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTeams_CellClick);
            // 
            // gbViewTeam
            // 
            this.gbViewTeam.Controls.Add(this.txtRankingTo);
            this.gbViewTeam.Controls.Add(this.txtRankingFrom);
            this.gbViewTeam.Controls.Add(this.txtFilterDivision);
            this.gbViewTeam.Controls.Add(this.btnFilterTeam);
            this.gbViewTeam.Controls.Add(this.txtFilterTeamName);
            this.gbViewTeam.Controls.Add(this.label11);
            this.gbViewTeam.Controls.Add(this.label12);
            this.gbViewTeam.Controls.Add(this.label13);
            this.gbViewTeam.Controls.Add(this.label10);
            this.gbViewTeam.Controls.Add(this.label1);
            this.gbViewTeam.Controls.Add(this.btnClearTeamFilter);
            this.gbViewTeam.Location = new System.Drawing.Point(8, 39);
            this.gbViewTeam.Name = "gbViewTeam";
            this.gbViewTeam.Size = new System.Drawing.Size(316, 185);
            this.gbViewTeam.TabIndex = 37;
            this.gbViewTeam.TabStop = false;
            this.gbViewTeam.Text = "View Team";
            // 
            // txtRankingTo
            // 
            this.txtRankingTo.Location = new System.Drawing.Point(235, 111);
            this.txtRankingTo.Name = "txtRankingTo";
            this.txtRankingTo.Size = new System.Drawing.Size(59, 20);
            this.txtRankingTo.TabIndex = 4;
            this.txtRankingTo.Validating += new System.ComponentModel.CancelEventHandler(this.txtRankingTo_Validating);
            // 
            // txtRankingFrom
            // 
            this.txtRankingFrom.Location = new System.Drawing.Point(112, 111);
            this.txtRankingFrom.Name = "txtRankingFrom";
            this.txtRankingFrom.Size = new System.Drawing.Size(59, 20);
            this.txtRankingFrom.TabIndex = 3;
            this.txtRankingFrom.Validating += new System.ComponentModel.CancelEventHandler(this.txtRankingFrom_Validating);
            // 
            // txtFilterDivision
            // 
            this.txtFilterDivision.Location = new System.Drawing.Point(79, 71);
            this.txtFilterDivision.Name = "txtFilterDivision";
            this.txtFilterDivision.Size = new System.Drawing.Size(216, 20);
            this.txtFilterDivision.TabIndex = 2;
            // 
            // btnFilterTeam
            // 
            this.btnFilterTeam.Location = new System.Drawing.Point(235, 147);
            this.btnFilterTeam.Name = "btnFilterTeam";
            this.btnFilterTeam.Size = new System.Drawing.Size(75, 23);
            this.btnFilterTeam.TabIndex = 6;
            this.btnFilterTeam.Text = "Filter";
            this.btnFilterTeam.UseVisualStyleBackColor = true;
            this.btnFilterTeam.Click += new System.EventHandler(this.btnFilterTeam_Click);
            // 
            // txtFilterTeamName
            // 
            this.txtFilterTeamName.Location = new System.Drawing.Point(79, 32);
            this.txtFilterTeamName.Name = "txtFilterTeamName";
            this.txtFilterTeamName.Size = new System.Drawing.Size(216, 20);
            this.txtFilterTeamName.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(206, 116);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "To:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(2, 36);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Team Name: ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(2, 78);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "Division: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(76, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "From:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ranking:";
            // 
            // btnClearTeamFilter
            // 
            this.btnClearTeamFilter.CausesValidation = false;
            this.btnClearTeamFilter.Location = new System.Drawing.Point(143, 147);
            this.btnClearTeamFilter.Name = "btnClearTeamFilter";
            this.btnClearTeamFilter.Size = new System.Drawing.Size(75, 23);
            this.btnClearTeamFilter.TabIndex = 5;
            this.btnClearTeamFilter.Text = "Clear";
            this.btnClearTeamFilter.UseVisualStyleBackColor = true;
            this.btnClearTeamFilter.Click += new System.EventHandler(this.btnClearTeamFilter_Click);
            // 
            // gbEditTeam
            // 
            this.gbEditTeam.Controls.Add(this.txtDivision);
            this.gbEditTeam.Controls.Add(this.btnAddTeam);
            this.gbEditTeam.Controls.Add(this.txtName);
            this.gbEditTeam.Controls.Add(this.lblName);
            this.gbEditTeam.Controls.Add(this.lblTeamId);
            this.gbEditTeam.Controls.Add(this.lblDivision);
            this.gbEditTeam.Controls.Add(this.cbDeleteTeam);
            this.gbEditTeam.Controls.Add(this.btnClearTeams);
            this.gbEditTeam.Controls.Add(this.btnUpdateTeam);
            this.gbEditTeam.Location = new System.Drawing.Point(8, 39);
            this.gbEditTeam.Name = "gbEditTeam";
            this.gbEditTeam.Size = new System.Drawing.Size(316, 185);
            this.gbEditTeam.TabIndex = 38;
            this.gbEditTeam.TabStop = false;
            this.gbEditTeam.Text = "Edit Team";
            // 
            // txtDivision
            // 
            this.txtDivision.Location = new System.Drawing.Point(79, 71);
            this.txtDivision.Name = "txtDivision";
            this.txtDivision.Size = new System.Drawing.Size(216, 20);
            this.txtDivision.TabIndex = 2;
            // 
            // btnAddTeam
            // 
            this.btnAddTeam.Location = new System.Drawing.Point(235, 147);
            this.btnAddTeam.Name = "btnAddTeam";
            this.btnAddTeam.Size = new System.Drawing.Size(75, 23);
            this.btnAddTeam.TabIndex = 6;
            this.btnAddTeam.Text = "Add";
            this.btnAddTeam.UseVisualStyleBackColor = true;
            this.btnAddTeam.Click += new System.EventHandler(this.btnAddTeam_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(79, 32);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(216, 20);
            this.txtName.TabIndex = 1;
            this.txtName.Validating += new System.ComponentModel.CancelEventHandler(this.txtName_Validating);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(2, 36);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(71, 13);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Team Name: ";
            // 
            // lblTeamId
            // 
            this.lblTeamId.AutoSize = true;
            this.lblTeamId.Location = new System.Drawing.Point(2, 120);
            this.lblTeamId.Name = "lblTeamId";
            this.lblTeamId.Size = new System.Drawing.Size(48, 13);
            this.lblTeamId.TabIndex = 34;
            this.lblTeamId.Text = "Team ID";
            this.lblTeamId.Visible = false;
            // 
            // lblDivision
            // 
            this.lblDivision.AutoSize = true;
            this.lblDivision.Location = new System.Drawing.Point(2, 78);
            this.lblDivision.Name = "lblDivision";
            this.lblDivision.Size = new System.Drawing.Size(50, 13);
            this.lblDivision.TabIndex = 8;
            this.lblDivision.Text = "Division: ";
            // 
            // cbDeleteTeam
            // 
            this.cbDeleteTeam.AutoSize = true;
            this.cbDeleteTeam.Location = new System.Drawing.Point(220, 116);
            this.cbDeleteTeam.Name = "cbDeleteTeam";
            this.cbDeleteTeam.Size = new System.Drawing.Size(90, 17);
            this.cbDeleteTeam.TabIndex = 3;
            this.cbDeleteTeam.Text = "Delete record";
            this.cbDeleteTeam.UseVisualStyleBackColor = true;
            this.cbDeleteTeam.CheckedChanged += new System.EventHandler(this.cbDeleteTeam_CheckedChanged);
            // 
            // btnClearTeams
            // 
            this.btnClearTeams.Location = new System.Drawing.Point(143, 147);
            this.btnClearTeams.Name = "btnClearTeams";
            this.btnClearTeams.Size = new System.Drawing.Size(75, 23);
            this.btnClearTeams.TabIndex = 5;
            this.btnClearTeams.Text = "Clear";
            this.btnClearTeams.UseVisualStyleBackColor = true;
            this.btnClearTeams.Click += new System.EventHandler(this.btnClearTeam_Click);
            // 
            // btnUpdateTeam
            // 
            this.btnUpdateTeam.Location = new System.Drawing.Point(51, 147);
            this.btnUpdateTeam.Name = "btnUpdateTeam";
            this.btnUpdateTeam.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateTeam.TabIndex = 4;
            this.btnUpdateTeam.Text = "Update";
            this.btnUpdateTeam.UseVisualStyleBackColor = true;
            this.btnUpdateTeam.Click += new System.EventHandler(this.btnUpdateTeam_Click);
            // 
            // trade
            // 
            this.trade.Controls.Add(this.btn_confirmTrade);
            this.trade.Controls.Add(this.btn_tradeLeft);
            this.trade.Controls.Add(this.btn_tradeRight);
            this.trade.Controls.Add(this.lbTeam2);
            this.trade.Controls.Add(this.lbTeam1);
            this.trade.Controls.Add(this.btn_loadTrade);
            this.trade.Controls.Add(this.cbTeam2);
            this.trade.Controls.Add(this.cbTeam1);
            this.trade.Location = new System.Drawing.Point(4, 22);
            this.trade.Margin = new System.Windows.Forms.Padding(1);
            this.trade.Name = "trade";
            this.trade.Padding = new System.Windows.Forms.Padding(1);
            this.trade.Size = new System.Drawing.Size(700, 390);
            this.trade.TabIndex = 2;
            this.trade.Text = "Trade Players";
            this.trade.UseVisualStyleBackColor = true;
            // 
            // btn_confirmTrade
            // 
            this.btn_confirmTrade.Location = new System.Drawing.Point(273, 248);
            this.btn_confirmTrade.Margin = new System.Windows.Forms.Padding(1);
            this.btn_confirmTrade.Name = "btn_confirmTrade";
            this.btn_confirmTrade.Size = new System.Drawing.Size(77, 29);
            this.btn_confirmTrade.TabIndex = 9;
            this.btn_confirmTrade.Text = "Confirm Trade";
            this.btn_confirmTrade.UseVisualStyleBackColor = true;
            // 
            // btn_tradeLeft
            // 
            this.btn_tradeLeft.Location = new System.Drawing.Point(273, 191);
            this.btn_tradeLeft.Margin = new System.Windows.Forms.Padding(1);
            this.btn_tradeLeft.Name = "btn_tradeLeft";
            this.btn_tradeLeft.Size = new System.Drawing.Size(77, 29);
            this.btn_tradeLeft.TabIndex = 8;
            this.btn_tradeLeft.Text = "<-";
            this.btn_tradeLeft.UseVisualStyleBackColor = true;
            // 
            // btn_tradeRight
            // 
            this.btn_tradeRight.Location = new System.Drawing.Point(273, 133);
            this.btn_tradeRight.Margin = new System.Windows.Forms.Padding(1);
            this.btn_tradeRight.Name = "btn_tradeRight";
            this.btn_tradeRight.Size = new System.Drawing.Size(77, 29);
            this.btn_tradeRight.TabIndex = 7;
            this.btn_tradeRight.Text = "->";
            this.btn_tradeRight.UseVisualStyleBackColor = true;
            // 
            // lbTeam2
            // 
            this.lbTeam2.FormattingEnabled = true;
            this.lbTeam2.Location = new System.Drawing.Point(421, 83);
            this.lbTeam2.Margin = new System.Windows.Forms.Padding(1);
            this.lbTeam2.Name = "lbTeam2";
            this.lbTeam2.Size = new System.Drawing.Size(204, 251);
            this.lbTeam2.TabIndex = 6;
            // 
            // lbTeam1
            // 
            this.lbTeam1.FormattingEnabled = true;
            this.lbTeam1.Location = new System.Drawing.Point(17, 88);
            this.lbTeam1.Margin = new System.Windows.Forms.Padding(1);
            this.lbTeam1.Name = "lbTeam1";
            this.lbTeam1.Size = new System.Drawing.Size(204, 251);
            this.lbTeam1.TabIndex = 5;
            // 
            // btn_loadTrade
            // 
            this.btn_loadTrade.Location = new System.Drawing.Point(264, 34);
            this.btn_loadTrade.Margin = new System.Windows.Forms.Padding(1);
            this.btn_loadTrade.Name = "btn_loadTrade";
            this.btn_loadTrade.Size = new System.Drawing.Size(98, 23);
            this.btn_loadTrade.TabIndex = 4;
            this.btn_loadTrade.Text = "Load Players";
            this.btn_loadTrade.UseVisualStyleBackColor = true;
            this.btn_loadTrade.Click += new System.EventHandler(this.btn_loadTrade_Click);
            // 
            // cbTeam2
            // 
            this.cbTeam2.FormattingEnabled = true;
            this.cbTeam2.Location = new System.Drawing.Point(469, 38);
            this.cbTeam2.Margin = new System.Windows.Forms.Padding(1);
            this.cbTeam2.Name = "cbTeam2";
            this.cbTeam2.Size = new System.Drawing.Size(94, 21);
            this.cbTeam2.TabIndex = 1;
            // 
            // cbTeam1
            // 
            this.cbTeam1.FormattingEnabled = true;
            this.cbTeam1.Location = new System.Drawing.Point(68, 38);
            this.cbTeam1.Margin = new System.Windows.Forms.Padding(1);
            this.cbTeam1.Name = "cbTeam1";
            this.cbTeam1.Size = new System.Drawing.Size(94, 21);
            this.cbTeam1.TabIndex = 0;
            // 
            // schedule
            // 
            this.schedule.Location = new System.Drawing.Point(4, 22);
            this.schedule.Margin = new System.Windows.Forms.Padding(1);
            this.schedule.Name = "schedule";
            this.schedule.Padding = new System.Windows.Forms.Padding(1);
            this.schedule.Size = new System.Drawing.Size(700, 390);
            this.schedule.TabIndex = 3;
            this.schedule.Text = "Schedule";
            this.schedule.UseVisualStyleBackColor = true;
            // 
            // standings
            // 
            this.standings.Controls.Add(this.dataGridViewStandings);
            this.standings.Location = new System.Drawing.Point(4, 22);
            this.standings.Margin = new System.Windows.Forms.Padding(1);
            this.standings.Name = "standings";
            this.standings.Padding = new System.Windows.Forms.Padding(1);
            this.standings.Size = new System.Drawing.Size(700, 390);
            this.standings.TabIndex = 4;
            this.standings.Text = "Standings";
            this.standings.UseVisualStyleBackColor = true;
            // 
            // dataGridViewStandings
            // 
            this.dataGridViewStandings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStandings.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewStandings.Margin = new System.Windows.Forms.Padding(1);
            this.dataGridViewStandings.Name = "dataGridViewStandings";
            this.dataGridViewStandings.RowTemplate.Height = 40;
            this.dataGridViewStandings.Size = new System.Drawing.Size(705, 265);
            this.dataGridViewStandings.TabIndex = 0;
            // 
            // playersBindingSource
            // 
            this.playersBindingSource.DataMember = "players";
            this.playersBindingSource.DataSource = this.cprojectDataSet;
            // 
            // cprojectDataSet
            // 
            this.cprojectDataSet.DataSetName = "cprojectDataSet";
            this.cprojectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // playersTableAdapter
            // 
            this.playersTableAdapter.ClearBeforeFill = true;
            // 
            // playersBindingSource1
            // 
            this.playersBindingSource1.DataMember = "players";
            this.playersBindingSource1.DataSource = this.cprojectDataSet;
            // 
            // playersBindingSource2
            // 
            this.playersBindingSource2.DataMember = "players";
            this.playersBindingSource2.DataSource = this.cprojectDataSet;
            // 
            // errorTeamName
            // 
            this.errorTeamName.ContainerControl = this;
            // 
            // errorFilterRankingTo
            // 
            this.errorFilterRankingTo.ContainerControl = this;
            // 
            // errorFilterRankingFrom
            // 
            this.errorFilterRankingFrom.ContainerControl = this;
            // 
            // errorFilterAgeFrom
            // 
            this.errorFilterAgeFrom.ContainerControl = this;
            // 
            // errorFilterAgeTo
            // 
            this.errorFilterAgeTo.ContainerControl = this;
            // 
            // errorFilterHeightFrom
            // 
            this.errorFilterHeightFrom.ContainerControl = this;
            // 
            // errorFilterHeightTo
            // 
            this.errorFilterHeightTo.ContainerControl = this;
            // 
            // errorFilterWeightFrom
            // 
            this.errorFilterWeightFrom.ContainerControl = this;
            // 
            // errorFilterWeightTo
            // 
            this.errorFilterWeightTo.ContainerControl = this;
            // 
            // errorNumberFrom
            // 
            this.errorNumberFrom.ContainerControl = this;
            // 
            // errorNumberTo
            // 
            this.errorNumberTo.ContainerControl = this;
            // 
            // errorFilterNumberFrom
            // 
            this.errorFilterNumberFrom.ContainerControl = this;
            // 
            // errorFilterNumberTo
            // 
            this.errorFilterNumberTo.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(708, 416);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "Form1";
            this.Text = "Soccer Management App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.Players.ResumeLayout(false);
            this.Players.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlayers)).EndInit();
            this.gbViewPlayer.ResumeLayout(false);
            this.gbViewPlayer.PerformLayout();
            this.gbEditPlayer.ResumeLayout(false);
            this.gbEditPlayer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).EndInit();
            this.Teams.ResumeLayout(false);
            this.Teams.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeams)).EndInit();
            this.gbViewTeam.ResumeLayout(false);
            this.gbViewTeam.PerformLayout();
            this.gbEditTeam.ResumeLayout(false);
            this.gbEditTeam.PerformLayout();
            this.trade.ResumeLayout(false);
            this.standings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStandings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cprojectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTeamName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorFilterRankingTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorFilterRankingFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorFilterAgeFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorFilterAgeTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorFilterHeightFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorFilterHeightTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorFilterWeightFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorFilterWeightTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNumberFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNumberTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorFilterNumberFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorFilterNumberTo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage Players;
        private System.Windows.Forms.TabPage Teams;
        private cprojectDataSet cprojectDataSet;
        private System.Windows.Forms.BindingSource playersBindingSource;
        private cprojectDataSetTableAdapters.playersTableAdapter playersTableAdapter;
        private System.Windows.Forms.BindingSource playersBindingSource1;
        private System.Windows.Forms.BindingSource playersBindingSource2;
        private System.Windows.Forms.DataGridView dataGridViewPlayers;
        private System.Windows.Forms.DataGridView dataGridViewTeams;
        private System.Windows.Forms.TabPage trade;
        private System.Windows.Forms.Button btn_loadTrade;
        private System.Windows.Forms.ComboBox cbTeam2;
        private System.Windows.Forms.ComboBox cbTeam1;
        private System.Windows.Forms.ListBox lbTeam2;
        private System.Windows.Forms.ListBox lbTeam1;
        private System.Windows.Forms.Button btn_confirmTrade;
        private System.Windows.Forms.Button btn_tradeLeft;
        private System.Windows.Forms.Button btn_tradeRight;
        private System.Windows.Forms.TabPage schedule;
        private System.Windows.Forms.TabPage standings;
        private System.Windows.Forms.DataGridView dataGridViewStandings;
        private System.Windows.Forms.Button btnAddTeam;
        private System.Windows.Forms.TextBox txtDivision;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnUpdateTeam;
        private System.Windows.Forms.Button btnClearTeams;
        private System.Windows.Forms.Label lblDivision;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.CheckBox cbDeleteTeam;
        private System.Windows.Forms.ErrorProvider errorTeamName;
        private System.Windows.Forms.CheckBox cbDeletePlayer;
        private System.Windows.Forms.Button btnUpdatePlayer;
        private System.Windows.Forms.Button btnClearPlayer;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Button btnAddPlayer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbPlayerTeams;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPlayerId;
        private System.Windows.Forms.Label lblTeamId;
        private System.Windows.Forms.NumericUpDown numAge;
        private System.Windows.Forms.NumericUpDown numWeight;
        private System.Windows.Forms.NumericUpDown numHeight;
        private System.Windows.Forms.NumericUpDown numNumber;
        private System.Windows.Forms.GroupBox gbViewTeam;
        private System.Windows.Forms.RadioButton rbEditTeam;
        private System.Windows.Forms.RadioButton rbViewTeam;
        private System.Windows.Forms.GroupBox gbEditTeam;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFilterDivision;
        private System.Windows.Forms.Button btnFilterTeam;
        private System.Windows.Forms.TextBox txtFilterTeamName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnClearTeamFilter;
        private System.Windows.Forms.TextBox txtRankingTo;
        private System.Windows.Forms.TextBox txtRankingFrom;
        private System.Windows.Forms.ErrorProvider errorFilterRankingTo;
        private System.Windows.Forms.ErrorProvider errorFilterRankingFrom;
        private System.Windows.Forms.GroupBox gbEditPlayer;
        private System.Windows.Forms.RadioButton rbEditPlayer;
        private System.Windows.Forms.RadioButton rbViewPlayer;
        private System.Windows.Forms.GroupBox gbViewPlayer;
        private System.Windows.Forms.ComboBox cbViewPlayerTeam;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtViewPlayerLastName;
        private System.Windows.Forms.Button btnClearPlayerFilter;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtViewPlayerFirstName;
        private System.Windows.Forms.TextBox txtViewPlayerAgeTo;
        private System.Windows.Forms.TextBox txtViewPlayerAgeFrom;
        private System.Windows.Forms.TextBox txtViewPlayerHeightTo;
        private System.Windows.Forms.TextBox txtViewPlayerHeightFrom;
        private System.Windows.Forms.TextBox txtViewPlayerWeightTo;
        private System.Windows.Forms.TextBox txtViewPlayerWeightFrom;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtViewPlayerNumberTo;
        private System.Windows.Forms.TextBox txtViewPlayerNumberFrom;
        private System.Windows.Forms.TextBox txtViewPlayerPosition;
        private System.Windows.Forms.Button btn_filter;
        private System.Windows.Forms.ErrorProvider errorFilterAgeFrom;
        private System.Windows.Forms.ErrorProvider errorFilterAgeTo;
        private System.Windows.Forms.ErrorProvider errorFilterHeightFrom;
        private System.Windows.Forms.ErrorProvider errorFilterHeightTo;
        private System.Windows.Forms.ErrorProvider errorFilterWeightFrom;
        private System.Windows.Forms.ErrorProvider errorFilterWeightTo;
        private System.Windows.Forms.ErrorProvider errorNumberFrom;
        private System.Windows.Forms.ErrorProvider errorNumberTo;
        private System.Windows.Forms.ErrorProvider errorFilterNumberFrom;
        private System.Windows.Forms.ErrorProvider errorFilterNumberTo;
    }
}

