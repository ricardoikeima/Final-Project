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
            this.lblPlayerId = new System.Windows.Forms.Label();
            this.cbPlayerTeams = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.cbDeletePlayer = new System.Windows.Forms.CheckBox();
            this.btnUpdatePlayer = new System.Windows.Forms.Button();
            this.btnClearPlayer = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.btnAddPlayer = new System.Windows.Forms.Button();
            this.btn_showAll = new System.Windows.Forms.Button();
            this.btn_filter = new System.Windows.Forms.Button();
            this.tbFilter = new System.Windows.Forms.TextBox();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.dataGridViewPlayers = new System.Windows.Forms.DataGridView();
            this.Teams = new System.Windows.Forms.TabPage();
            this.cbDeleteTeam = new System.Windows.Forms.CheckBox();
            this.btnUpdateTeam = new System.Windows.Forms.Button();
            this.btnClearTeams = new System.Windows.Forms.Button();
            this.lblDivision = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtDivision = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnAddTeam = new System.Windows.Forms.Button();
            this.dataGridViewTeams = new System.Windows.Forms.DataGridView();
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
            this.tabControl.SuspendLayout();
            this.Players.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlayers)).BeginInit();
            this.Teams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeams)).BeginInit();
            this.trade.SuspendLayout();
            this.standings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStandings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cprojectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTeamName)).BeginInit();
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
            this.Players.Controls.Add(this.lblPlayerId);
            this.Players.Controls.Add(this.cbPlayerTeams);
            this.Players.Controls.Add(this.label2);
            this.Players.Controls.Add(this.label7);
            this.Players.Controls.Add(this.txtHeight);
            this.Players.Controls.Add(this.label6);
            this.Players.Controls.Add(this.txtWeight);
            this.Players.Controls.Add(this.label8);
            this.Players.Controls.Add(this.txtPosition);
            this.Players.Controls.Add(this.label5);
            this.Players.Controls.Add(this.txtAge);
            this.Players.Controls.Add(this.label4);
            this.Players.Controls.Add(this.txtLName);
            this.Players.Controls.Add(this.cbDeletePlayer);
            this.Players.Controls.Add(this.btnUpdatePlayer);
            this.Players.Controls.Add(this.btnClearPlayer);
            this.Players.Controls.Add(this.label9);
            this.Players.Controls.Add(this.label3);
            this.Players.Controls.Add(this.txtNumber);
            this.Players.Controls.Add(this.txtFName);
            this.Players.Controls.Add(this.btnAddPlayer);
            this.Players.Controls.Add(this.btn_showAll);
            this.Players.Controls.Add(this.btn_filter);
            this.Players.Controls.Add(this.tbFilter);
            this.Players.Controls.Add(this.cbFilter);
            this.Players.Controls.Add(this.dataGridViewPlayers);
            this.Players.Location = new System.Drawing.Point(4, 22);
            this.Players.Margin = new System.Windows.Forms.Padding(1);
            this.Players.Name = "Players";
            this.Players.Padding = new System.Windows.Forms.Padding(1);
            this.Players.Size = new System.Drawing.Size(700, 390);
            this.Players.TabIndex = 0;
            this.Players.Text = "Players";
            this.Players.UseVisualStyleBackColor = true;
            // 
            // lblPlayerId
            // 
            this.lblPlayerId.AutoSize = true;
            this.lblPlayerId.Location = new System.Drawing.Point(33, 180);
            this.lblPlayerId.Name = "lblPlayerId";
            this.lblPlayerId.Size = new System.Drawing.Size(50, 13);
            this.lblPlayerId.TabIndex = 33;
            this.lblPlayerId.Text = "Player ID";
            this.lblPlayerId.Visible = false;
            // 
            // cbPlayerTeams
            // 
            this.cbPlayerTeams.FormattingEnabled = true;
            this.cbPlayerTeams.Location = new System.Drawing.Point(234, 100);
            this.cbPlayerTeams.Name = "cbPlayerTeams";
            this.cbPlayerTeams.Size = new System.Drawing.Size(192, 21);
            this.cbPlayerTeams.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Team:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Height:";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(91, 140);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(57, 20);
            this.txtHeight.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Weight: ";
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(91, 101);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(57, 20);
            this.txtWeight.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(169, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Position: ";
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(234, 141);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(57, 20);
            this.txtPosition.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(560, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Age:";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(595, 65);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(57, 20);
            this.txtAge.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(291, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Last Name: ";
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(356, 65);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(182, 20);
            this.txtLName.TabIndex = 6;
            // 
            // cbDeletePlayer
            // 
            this.cbDeletePlayer.AutoSize = true;
            this.cbDeletePlayer.Location = new System.Drawing.Point(595, 139);
            this.cbDeletePlayer.Name = "cbDeletePlayer";
            this.cbDeletePlayer.Size = new System.Drawing.Size(90, 17);
            this.cbDeletePlayer.TabIndex = 13;
            this.cbDeletePlayer.Text = "Delete record";
            this.cbDeletePlayer.UseVisualStyleBackColor = true;
            // 
            // btnUpdatePlayer
            // 
            this.btnUpdatePlayer.Location = new System.Drawing.Point(438, 180);
            this.btnUpdatePlayer.Name = "btnUpdatePlayer";
            this.btnUpdatePlayer.Size = new System.Drawing.Size(75, 23);
            this.btnUpdatePlayer.TabIndex = 14;
            this.btnUpdatePlayer.Text = "Update";
            this.btnUpdatePlayer.UseVisualStyleBackColor = true;
            this.btnUpdatePlayer.Click += new System.EventHandler(this.btnUpdatePlayer_Click);
            // 
            // btnClearPlayer
            // 
            this.btnClearPlayer.Location = new System.Drawing.Point(530, 180);
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
            this.label9.Location = new System.Drawing.Point(313, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Number: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "First Name: ";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(369, 141);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(57, 20);
            this.txtNumber.TabIndex = 12;
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(91, 65);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(188, 20);
            this.txtFName.TabIndex = 5;
            // 
            // btnAddPlayer
            // 
            this.btnAddPlayer.Location = new System.Drawing.Point(622, 180);
            this.btnAddPlayer.Name = "btnAddPlayer";
            this.btnAddPlayer.Size = new System.Drawing.Size(75, 23);
            this.btnAddPlayer.TabIndex = 16;
            this.btnAddPlayer.Text = "Add";
            this.btnAddPlayer.UseVisualStyleBackColor = true;
            this.btnAddPlayer.Click += new System.EventHandler(this.btnAddPlayer_Click);
            // 
            // btn_showAll
            // 
            this.btn_showAll.Location = new System.Drawing.Point(539, 18);
            this.btn_showAll.Margin = new System.Windows.Forms.Padding(1);
            this.btn_showAll.Name = "btn_showAll";
            this.btn_showAll.Size = new System.Drawing.Size(111, 26);
            this.btn_showAll.TabIndex = 4;
            this.btn_showAll.Text = "Show All";
            this.btn_showAll.UseVisualStyleBackColor = true;
            this.btn_showAll.Click += new System.EventHandler(this.btn_showAll_Click);
            // 
            // btn_filter
            // 
            this.btn_filter.Location = new System.Drawing.Point(400, 18);
            this.btn_filter.Margin = new System.Windows.Forms.Padding(1);
            this.btn_filter.Name = "btn_filter";
            this.btn_filter.Size = new System.Drawing.Size(111, 26);
            this.btn_filter.TabIndex = 3;
            this.btn_filter.Text = "Filter";
            this.btn_filter.UseVisualStyleBackColor = true;
            this.btn_filter.Click += new System.EventHandler(this.btn_filter_Click);
            // 
            // tbFilter
            // 
            this.tbFilter.Location = new System.Drawing.Point(179, 23);
            this.tbFilter.Margin = new System.Windows.Forms.Padding(1);
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.Size = new System.Drawing.Size(184, 20);
            this.tbFilter.TabIndex = 2;
            // 
            // cbFilter
            // 
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Location = new System.Drawing.Point(29, 23);
            this.cbFilter.Margin = new System.Windows.Forms.Padding(1);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(94, 21);
            this.cbFilter.TabIndex = 1;
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
            // Teams
            // 
            this.Teams.Controls.Add(this.cbDeleteTeam);
            this.Teams.Controls.Add(this.btnUpdateTeam);
            this.Teams.Controls.Add(this.btnClearTeams);
            this.Teams.Controls.Add(this.lblDivision);
            this.Teams.Controls.Add(this.lblName);
            this.Teams.Controls.Add(this.txtDivision);
            this.Teams.Controls.Add(this.txtName);
            this.Teams.Controls.Add(this.btnAddTeam);
            this.Teams.Controls.Add(this.dataGridViewTeams);
            this.Teams.Location = new System.Drawing.Point(4, 22);
            this.Teams.Margin = new System.Windows.Forms.Padding(1);
            this.Teams.Name = "Teams";
            this.Teams.Padding = new System.Windows.Forms.Padding(1);
            this.Teams.Size = new System.Drawing.Size(700, 390);
            this.Teams.TabIndex = 1;
            this.Teams.Text = "Teams";
            this.Teams.UseVisualStyleBackColor = true;
            // 
            // cbDeleteTeam
            // 
            this.cbDeleteTeam.AutoSize = true;
            this.cbDeleteTeam.Location = new System.Drawing.Point(97, 99);
            this.cbDeleteTeam.Name = "cbDeleteTeam";
            this.cbDeleteTeam.Size = new System.Drawing.Size(90, 17);
            this.cbDeleteTeam.TabIndex = 3;
            this.cbDeleteTeam.Text = "Delete record";
            this.cbDeleteTeam.UseVisualStyleBackColor = true;
            // 
            // btnUpdateTeam
            // 
            this.btnUpdateTeam.Location = new System.Drawing.Point(414, 131);
            this.btnUpdateTeam.Name = "btnUpdateTeam";
            this.btnUpdateTeam.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateTeam.TabIndex = 4;
            this.btnUpdateTeam.Text = "Update";
            this.btnUpdateTeam.UseVisualStyleBackColor = true;
            this.btnUpdateTeam.Click += new System.EventHandler(this.btnUpdateTeam_Click);
            // 
            // btnClearTeams
            // 
            this.btnClearTeams.Location = new System.Drawing.Point(506, 131);
            this.btnClearTeams.Name = "btnClearTeams";
            this.btnClearTeams.Size = new System.Drawing.Size(75, 23);
            this.btnClearTeams.TabIndex = 5;
            this.btnClearTeams.Text = "Clear";
            this.btnClearTeams.UseVisualStyleBackColor = true;
            this.btnClearTeams.Click += new System.EventHandler(this.btnClearTeam_Click);
            // 
            // lblDivision
            // 
            this.lblDivision.AutoSize = true;
            this.lblDivision.Location = new System.Drawing.Point(4, 69);
            this.lblDivision.Name = "lblDivision";
            this.lblDivision.Size = new System.Drawing.Size(50, 13);
            this.lblDivision.TabIndex = 8;
            this.lblDivision.Text = "Division: ";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(4, 27);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(71, 13);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Team Name: ";
            // 
            // txtDivision
            // 
            this.txtDivision.Location = new System.Drawing.Point(97, 63);
            this.txtDivision.Name = "txtDivision";
            this.txtDivision.Size = new System.Drawing.Size(348, 20);
            this.txtDivision.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(97, 24);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(348, 20);
            this.txtName.TabIndex = 1;
            this.txtName.Validating += new System.ComponentModel.CancelEventHandler(this.txtName_Validating);
            // 
            // btnAddTeam
            // 
            this.btnAddTeam.Location = new System.Drawing.Point(598, 131);
            this.btnAddTeam.Name = "btnAddTeam";
            this.btnAddTeam.Size = new System.Drawing.Size(75, 23);
            this.btnAddTeam.TabIndex = 6;
            this.btnAddTeam.Text = "Add";
            this.btnAddTeam.UseVisualStyleBackColor = true;
            this.btnAddTeam.Click += new System.EventHandler(this.btnAddTeam_Click);
            // 
            // dataGridViewTeams
            // 
            this.dataGridViewTeams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTeams.Location = new System.Drawing.Point(0, 174);
            this.dataGridViewTeams.Margin = new System.Windows.Forms.Padding(1);
            this.dataGridViewTeams.Name = "dataGridViewTeams";
            this.dataGridViewTeams.RowTemplate.Height = 40;
            this.dataGridViewTeams.Size = new System.Drawing.Size(704, 146);
            this.dataGridViewTeams.TabIndex = 0;
            this.dataGridViewTeams.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTeams_CellClick);
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
            this.Teams.ResumeLayout(false);
            this.Teams.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeams)).EndInit();
            this.trade.ResumeLayout(false);
            this.standings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStandings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cprojectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTeamName)).EndInit();
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
        private System.Windows.Forms.TextBox tbFilter;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.Button btn_filter;
        private System.Windows.Forms.Button btn_showAll;
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
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Button btnAddPlayer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.ComboBox cbPlayerTeams;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPlayerId;
    }
}

