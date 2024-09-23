namespace HBM_RBMKalc
{
    partial class RBMKalc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RBMKalc));
            MainStatusStrip = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            StatusProgressBar = new ToolStripProgressBar();
            StatusLabel = new ToolStripStatusLabel();
            OpenFileDialog = new OpenFileDialog();
            SaveFileDialog = new SaveFileDialog();
            MenuStrip = new MenuStrip();
            FileMenu = new ToolStripMenuItem();
            OpenMenuItem = new ToolStripMenuItem();
            SaveMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            QuitMenuItem = new ToolStripMenuItem();
            SimulationMenu = new ToolStripMenuItem();
            StartMenuItem = new ToolStripMenuItem();
            StepMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            TickspeedMenuItem = new ToolStripMenuItem();
            OptionsMenu = new ToolStripMenuItem();
            HeatWarningMenuItem = new ToolStripMenuItem();
            FluxRunawayWarningMenuItem = new ToolStripMenuItem();
            ReaSimBoilerMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            DialsMenuItem = new ToolStripMenuItem();
            EditReactorMenuItem = new ToolStripMenuItem();
            HelpMenu = new ToolStripMenuItem();
            OpenHelpMenuItem = new ToolStripMenuItem();
            AboutMenuItem = new ToolStripMenuItem();
            ReactorGrid = new TableLayoutPanel();
            SideTabs = new TabControl();
            FuelPage = new TabPage();
            FuelSelfIgniting = new CheckBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            FuelHeatFunc = new TextBox();
            FuelXenonBurn = new TextBox();
            FuelXenonGen = new TextBox();
            label4 = new Label();
            FuelFluxFunc = new TextBox();
            FuelTypeApply = new Button();
            FuelTypeSelection = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            FuelColumnList = new ListBox();
            ReactorPage = new TabPage();
            MainStatusStrip.SuspendLayout();
            MenuStrip.SuspendLayout();
            SideTabs.SuspendLayout();
            FuelPage.SuspendLayout();
            SuspendLayout();
            // 
            // MainStatusStrip
            // 
            MainStatusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, StatusProgressBar, StatusLabel });
            MainStatusStrip.Location = new Point(0, 651);
            MainStatusStrip.Name = "MainStatusStrip";
            MainStatusStrip.Size = new Size(991, 22);
            MainStatusStrip.TabIndex = 1;
            MainStatusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.BackColor = SystemColors.Control;
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(42, 17);
            toolStripStatusLabel1.Text = "Status:";
            // 
            // StatusProgressBar
            // 
            StatusProgressBar.Name = "StatusProgressBar";
            StatusProgressBar.Size = new Size(100, 16);
            // 
            // StatusLabel
            // 
            StatusLabel.BackColor = SystemColors.Control;
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(67, 17);
            StatusLabel.Text = "StatusLabel";
            // 
            // OpenFileDialog
            // 
            OpenFileDialog.FileName = "OpenFileDialog";
            OpenFileDialog.Filter = "JSON-Files|*.json|All Files|*.*";
            OpenFileDialog.InitialDirectory = "%userprofile%\\Documents";
            OpenFileDialog.RestoreDirectory = true;
            // 
            // SaveFileDialog
            // 
            SaveFileDialog.FileName = "reactor.json";
            SaveFileDialog.Filter = "JSON-Files|*.json|All Files|*.*";
            SaveFileDialog.InitialDirectory = "%userprofile%\\Documents";
            SaveFileDialog.RestoreDirectory = true;
            SaveFileDialog.Title = "Save Reactor";
            // 
            // MenuStrip
            // 
            MenuStrip.Items.AddRange(new ToolStripItem[] { FileMenu, SimulationMenu, OptionsMenu, HelpMenu });
            MenuStrip.Location = new Point(0, 0);
            MenuStrip.Name = "MenuStrip";
            MenuStrip.Size = new Size(991, 24);
            MenuStrip.TabIndex = 2;
            MenuStrip.Text = "menuStrip1";
            // 
            // FileMenu
            // 
            FileMenu.DropDownItems.AddRange(new ToolStripItem[] { OpenMenuItem, SaveMenuItem, toolStripSeparator2, QuitMenuItem });
            FileMenu.Name = "FileMenu";
            FileMenu.Size = new Size(37, 20);
            FileMenu.Text = "File";
            // 
            // OpenMenuItem
            // 
            OpenMenuItem.Name = "OpenMenuItem";
            OpenMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            OpenMenuItem.Size = new Size(148, 22);
            OpenMenuItem.Text = "Open";
            OpenMenuItem.Click += OpenMenuItem_Click;
            // 
            // SaveMenuItem
            // 
            SaveMenuItem.Name = "SaveMenuItem";
            SaveMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            SaveMenuItem.Size = new Size(148, 22);
            SaveMenuItem.Text = "Save";
            SaveMenuItem.Click += SaveMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(145, 6);
            // 
            // QuitMenuItem
            // 
            QuitMenuItem.Name = "QuitMenuItem";
            QuitMenuItem.ShortcutKeys = Keys.Control | Keys.Q;
            QuitMenuItem.Size = new Size(148, 22);
            QuitMenuItem.Text = "Quit";
            QuitMenuItem.Click += QuitMenuItem_Click;
            // 
            // SimulationMenu
            // 
            SimulationMenu.DropDownItems.AddRange(new ToolStripItem[] { StartMenuItem, StepMenuItem, toolStripSeparator1, TickspeedMenuItem });
            SimulationMenu.Name = "SimulationMenu";
            SimulationMenu.Size = new Size(76, 20);
            SimulationMenu.Text = "Simulation";
            // 
            // StartMenuItem
            // 
            StartMenuItem.Name = "StartMenuItem";
            StartMenuItem.ShortcutKeys = Keys.F5;
            StartMenuItem.Size = new Size(145, 22);
            StartMenuItem.Text = "Start";
            StartMenuItem.Click += StartMenuItem_Click;
            // 
            // StepMenuItem
            // 
            StepMenuItem.Name = "StepMenuItem";
            StepMenuItem.ShortcutKeys = Keys.Control | Keys.F5;
            StepMenuItem.Size = new Size(145, 22);
            StepMenuItem.Text = "Step";
            StepMenuItem.Click += StepMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(142, 6);
            // 
            // TickspeedMenuItem
            // 
            TickspeedMenuItem.Name = "TickspeedMenuItem";
            TickspeedMenuItem.Size = new Size(145, 22);
            TickspeedMenuItem.Text = "Tickspeed";
            TickspeedMenuItem.Click += TickspeedMenuItem_Click;
            // 
            // OptionsMenu
            // 
            OptionsMenu.DropDownItems.AddRange(new ToolStripItem[] { HeatWarningMenuItem, FluxRunawayWarningMenuItem, ReaSimBoilerMenuItem, toolStripSeparator3, DialsMenuItem, EditReactorMenuItem });
            OptionsMenu.Name = "OptionsMenu";
            OptionsMenu.Size = new Size(61, 20);
            OptionsMenu.Text = "Options";
            // 
            // HeatWarningMenuItem
            // 
            HeatWarningMenuItem.Name = "HeatWarningMenuItem";
            HeatWarningMenuItem.Size = new Size(195, 22);
            HeatWarningMenuItem.Text = "Heat Warning";
            HeatWarningMenuItem.Click += HeatWarningMenuItem_Click;
            // 
            // FluxRunawayWarningMenuItem
            // 
            FluxRunawayWarningMenuItem.Name = "FluxRunawayWarningMenuItem";
            FluxRunawayWarningMenuItem.Size = new Size(195, 22);
            FluxRunawayWarningMenuItem.Text = "Flux Runaway Warning";
            FluxRunawayWarningMenuItem.Click += FluxRunawayWarningMenuItem_Click;
            // 
            // ReaSimBoilerMenuItem
            // 
            ReaSimBoilerMenuItem.Name = "ReaSimBoilerMenuItem";
            ReaSimBoilerMenuItem.Size = new Size(195, 22);
            ReaSimBoilerMenuItem.Text = "ReaSim Boiler";
            ReaSimBoilerMenuItem.Click += ReaSimBoilerMenuItem_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(192, 6);
            // 
            // DialsMenuItem
            // 
            DialsMenuItem.Name = "DialsMenuItem";
            DialsMenuItem.Size = new Size(195, 22);
            DialsMenuItem.Text = "Dials";
            // 
            // EditReactorMenuItem
            // 
            EditReactorMenuItem.Name = "EditReactorMenuItem";
            EditReactorMenuItem.Size = new Size(195, 22);
            EditReactorMenuItem.Text = "Edit Reactor";
            EditReactorMenuItem.Click += EditReactorMenuItem_Click;
            // 
            // HelpMenu
            // 
            HelpMenu.DropDownItems.AddRange(new ToolStripItem[] { OpenHelpMenuItem, AboutMenuItem });
            HelpMenu.Name = "HelpMenu";
            HelpMenu.Size = new Size(44, 20);
            HelpMenu.Text = "Help";
            // 
            // OpenHelpMenuItem
            // 
            OpenHelpMenuItem.Name = "OpenHelpMenuItem";
            OpenHelpMenuItem.Size = new Size(131, 22);
            OpenHelpMenuItem.Text = "Open Help";
            OpenHelpMenuItem.Click += OpenHelpMenuItem_Click;
            // 
            // AboutMenuItem
            // 
            AboutMenuItem.Name = "AboutMenuItem";
            AboutMenuItem.Size = new Size(131, 22);
            AboutMenuItem.Text = "About";
            AboutMenuItem.Click += AboutMenuItem_Click;
            // 
            // ReactorGrid
            // 
            ReactorGrid.BackColor = SystemColors.ControlDarkDark;
            ReactorGrid.ColumnCount = 15;
            ReactorGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            ReactorGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            ReactorGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            ReactorGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            ReactorGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            ReactorGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            ReactorGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            ReactorGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            ReactorGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            ReactorGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            ReactorGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            ReactorGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            ReactorGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            ReactorGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            ReactorGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            ReactorGrid.Cursor = Cursors.Cross;
            ReactorGrid.Location = new Point(12, 37);
            ReactorGrid.Margin = new Padding(0);
            ReactorGrid.Name = "ReactorGrid";
            ReactorGrid.RowCount = 15;
            ReactorGrid.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            ReactorGrid.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            ReactorGrid.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            ReactorGrid.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            ReactorGrid.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            ReactorGrid.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            ReactorGrid.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            ReactorGrid.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            ReactorGrid.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            ReactorGrid.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            ReactorGrid.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            ReactorGrid.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            ReactorGrid.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            ReactorGrid.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            ReactorGrid.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            ReactorGrid.Size = new Size(600, 600);
            ReactorGrid.TabIndex = 3;
            ReactorGrid.MouseClick += ReactorGrid_MouseClick;
            // 
            // SideTabs
            // 
            SideTabs.Controls.Add(FuelPage);
            SideTabs.Controls.Add(ReactorPage);
            SideTabs.Location = new Point(618, 37);
            SideTabs.Name = "SideTabs";
            SideTabs.SelectedIndex = 0;
            SideTabs.Size = new Size(361, 600);
            SideTabs.TabIndex = 4;
            // 
            // FuelPage
            // 
            FuelPage.Controls.Add(FuelSelfIgniting);
            FuelPage.Controls.Add(label8);
            FuelPage.Controls.Add(label7);
            FuelPage.Controls.Add(label6);
            FuelPage.Controls.Add(FuelHeatFunc);
            FuelPage.Controls.Add(FuelXenonBurn);
            FuelPage.Controls.Add(FuelXenonGen);
            FuelPage.Controls.Add(label4);
            FuelPage.Controls.Add(FuelFluxFunc);
            FuelPage.Controls.Add(FuelTypeApply);
            FuelPage.Controls.Add(FuelTypeSelection);
            FuelPage.Controls.Add(label2);
            FuelPage.Controls.Add(label1);
            FuelPage.Controls.Add(FuelColumnList);
            FuelPage.Location = new Point(4, 24);
            FuelPage.Name = "FuelPage";
            FuelPage.Padding = new Padding(3);
            FuelPage.Size = new Size(353, 572);
            FuelPage.TabIndex = 0;
            FuelPage.Text = "Reactor Fuel";
            FuelPage.UseVisualStyleBackColor = true;
            // 
            // FuelSelfIgniting
            // 
            FuelSelfIgniting.AutoCheck = false;
            FuelSelfIgniting.AutoSize = true;
            FuelSelfIgniting.Cursor = Cursors.No;
            FuelSelfIgniting.Location = new Point(94, 520);
            FuelSelfIgniting.Name = "FuelSelfIgniting";
            FuelSelfIgniting.Size = new Size(89, 19);
            FuelSelfIgniting.TabIndex = 16;
            FuelSelfIgniting.TabStop = false;
            FuelSelfIgniting.Text = "Self Igniting";
            FuelSelfIgniting.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 494);
            label8.Name = "label8";
            label8.Size = new Size(56, 15);
            label8.TabIndex = 14;
            label8.Text = "Heat/t/n:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 465);
            label7.Name = "label7";
            label7.Size = new Size(72, 15);
            label7.TabIndex = 13;
            label7.Text = "Xenon Burn:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 436);
            label6.Name = "label6";
            label6.Size = new Size(68, 15);
            label6.TabIndex = 12;
            label6.Text = "Xenon Gen:";
            // 
            // FuelHeatFunc
            // 
            FuelHeatFunc.Cursor = Cursors.No;
            FuelHeatFunc.Location = new Point(94, 491);
            FuelHeatFunc.Name = "FuelHeatFunc";
            FuelHeatFunc.ReadOnly = true;
            FuelHeatFunc.Size = new Size(253, 23);
            FuelHeatFunc.TabIndex = 10;
            FuelHeatFunc.TabStop = false;
            // 
            // FuelXenonBurn
            // 
            FuelXenonBurn.Cursor = Cursors.No;
            FuelXenonBurn.Location = new Point(94, 462);
            FuelXenonBurn.Name = "FuelXenonBurn";
            FuelXenonBurn.ReadOnly = true;
            FuelXenonBurn.Size = new Size(253, 23);
            FuelXenonBurn.TabIndex = 9;
            FuelXenonBurn.TabStop = false;
            // 
            // FuelXenonGen
            // 
            FuelXenonGen.Cursor = Cursors.No;
            FuelXenonGen.Location = new Point(94, 433);
            FuelXenonGen.Name = "FuelXenonGen";
            FuelXenonGen.ReadOnly = true;
            FuelXenonGen.Size = new Size(253, 23);
            FuelXenonGen.TabIndex = 8;
            FuelXenonGen.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 407);
            label4.Name = "label4";
            label4.Size = new Size(82, 15);
            label4.TabIndex = 7;
            label4.Text = "Flux Function:";
            // 
            // FuelFluxFunc
            // 
            FuelFluxFunc.Cursor = Cursors.No;
            FuelFluxFunc.Location = new Point(94, 404);
            FuelFluxFunc.Name = "FuelFluxFunc";
            FuelFluxFunc.ReadOnly = true;
            FuelFluxFunc.Size = new Size(253, 23);
            FuelFluxFunc.TabIndex = 6;
            FuelFluxFunc.TabStop = false;
            // 
            // FuelTypeApply
            // 
            FuelTypeApply.Location = new Point(256, 375);
            FuelTypeApply.Name = "FuelTypeApply";
            FuelTypeApply.Size = new Size(91, 23);
            FuelTypeApply.TabIndex = 4;
            FuelTypeApply.Text = "Apply";
            FuelTypeApply.UseVisualStyleBackColor = true;
            FuelTypeApply.Click += FuelTypeApply_Click;
            // 
            // FuelTypeSelection
            // 
            FuelTypeSelection.AutoCompleteMode = AutoCompleteMode.Suggest;
            FuelTypeSelection.AutoCompleteSource = AutoCompleteSource.ListItems;
            FuelTypeSelection.DropDownStyle = ComboBoxStyle.DropDownList;
            FuelTypeSelection.FormattingEnabled = true;
            FuelTypeSelection.Items.AddRange(new object[] { "None", "Americium ZFB", "Bismuth ZFB", "Thorium with MEU Driver", "Natural Uranium - NU", "Low Enriched Americium-242 - LEAm-242", "Low Enriched Australium - LEAus", "Low Enriched Plutonium-239 - LEPu-239", "Low Enriched Schrabidium - LES", "Medium Enriched Americium-242m - MEAm-242m", "Medium Enriched Neptunium 237 - MENp-237", "Medium Enriched Plutonium 239 - MEPu-239", "Medium Enriched Schrabidium - MES", "Medium Enriched Uranium 235 - MEU-235", "Highly Enriched Americium 242m - HEAm-242m", "Highly Enriched Australium - HEAus", "Highly Enriched Neptunium-237 - HENp-237", "Highly Enriched Plutonium-239 - HEPu-239", "Highly Enriched Plutonium-241 - HEPu-241", "Highly Enriched Schrabidium - HES", "Highly Enriched Uranium 233 - HEU-233", "Highly Enriched Uranium 235 - HEU-235", "Flashgold Fuel", "Flashlead Fuel", "Balefire Fuel", "Digamma Fuel" });
            FuelTypeSelection.Location = new Point(6, 346);
            FuelTypeSelection.Name = "FuelTypeSelection";
            FuelTypeSelection.Size = new Size(341, 23);
            FuelTypeSelection.TabIndex = 3;
            FuelTypeSelection.SelectedIndexChanged += FuelTypeSelection_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 328);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 2;
            label2.Text = "Fuel Type:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 3);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 1;
            label1.Text = "Fuel Column:";
            // 
            // FuelColumnList
            // 
            FuelColumnList.FormattingEnabled = true;
            FuelColumnList.ItemHeight = 15;
            FuelColumnList.Location = new Point(6, 21);
            FuelColumnList.Name = "FuelColumnList";
            FuelColumnList.Size = new Size(341, 304);
            FuelColumnList.TabIndex = 0;
            FuelColumnList.SelectedIndexChanged += FuelColumnList_SelectedIndexChanged;
            // 
            // ReactorPage
            // 
            ReactorPage.Location = new Point(4, 24);
            ReactorPage.Name = "ReactorPage";
            ReactorPage.Padding = new Padding(3);
            ReactorPage.Size = new Size(353, 572);
            ReactorPage.TabIndex = 1;
            ReactorPage.Text = "Reactor Properties";
            ReactorPage.UseVisualStyleBackColor = true;
            // 
            // RBMKalc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(991, 673);
            Controls.Add(SideTabs);
            Controls.Add(ReactorGrid);
            Controls.Add(MainStatusStrip);
            Controls.Add(MenuStrip);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = MenuStrip;
            MaximizeBox = false;
            Name = "RBMKalc";
            Text = "RBMKalc";
            MainStatusStrip.ResumeLayout(false);
            MainStatusStrip.PerformLayout();
            MenuStrip.ResumeLayout(false);
            MenuStrip.PerformLayout();
            SideTabs.ResumeLayout(false);
            FuelPage.ResumeLayout(false);
            FuelPage.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private StatusStrip MainStatusStrip;
        private OpenFileDialog OpenFileDialog;
        private SaveFileDialog SaveFileDialog;
        private MenuStrip MenuStrip;
        private ToolStripMenuItem FileMenu;
        private ToolStripMenuItem OpenMenuItem;
        private ToolStripMenuItem SaveMenuItem;
        private ToolStripMenuItem QuitMenuItem;
        private ToolStripMenuItem SimulationMenu;
        private ToolStripMenuItem StartMenuItem;
        private ToolStripMenuItem StepMenuItem;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripProgressBar StatusProgressBar;
        private ToolStripStatusLabel StatusLabel;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem TickspeedMenuItem;
        private ToolStripMenuItem OptionsMenu;
        private ToolStripMenuItem HeatWarningMenuItem;
        private ToolStripMenuItem FluxRunawayWarningMenuItem;
        private ToolStripMenuItem ReaSimBoilerMenuItem;
        private TableLayoutPanel ReactorGrid;
        private ToolStripMenuItem HelpMenu;
        private ToolStripMenuItem OpenHelpMenuItem;
        private ToolStripMenuItem AboutMenuItem;
        private TabControl SideTabs;
        private TabPage FuelPage;
        private TabPage ReactorPage;
        private ComboBox FuelTypeSelection;
        private Label label2;
        private Label label1;
        private ListBox FuelColumnList;
        private Button FuelTypeApply;
        private Label label4;
        private TextBox FuelFluxFunc;
        private TextBox FuelHeatFunc;
        private TextBox FuelXenonBurn;
        private TextBox FuelXenonGen;
        private Label label8;
        private Label label7;
        private Label label6;
        private CheckBox FuelSelfIgniting;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem DialsMenuItem;
        private ToolStripMenuItem EditReactorMenuItem;
    }
}
