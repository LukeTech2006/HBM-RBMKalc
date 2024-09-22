namespace HBM_RBMKalc
{
    partial class Palette
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Palette));
            RadioEmpty = new RadioButton();
            RadioBlank = new RadioButton();
            RadioFuel = new RadioButton();
            RadioControl = new RadioButton();
            RadioAutoControl = new RadioButton();
            RadioBoiler = new RadioButton();
            RadioModerator = new RadioButton();
            RadioAbsorber = new RadioButton();
            RadioReflector = new RadioButton();
            RadioOutgasser = new RadioButton();
            RadioStorage = new RadioButton();
            RadioCooler = new RadioButton();
            RadioHeatex = new RadioButton();
            ToolTip = new ToolTip(components);
            SuspendLayout();
            // 
            // RadioEmpty
            // 
            RadioEmpty.Appearance = Appearance.Button;
            RadioEmpty.AutoSize = true;
            RadioEmpty.Checked = true;
            RadioEmpty.Image = Properties.Resources.empty;
            RadioEmpty.Location = new Point(12, 12);
            RadioEmpty.Name = "RadioEmpty";
            RadioEmpty.Size = new Size(46, 46);
            RadioEmpty.TabIndex = 0;
            RadioEmpty.TabStop = true;
            ToolTip.SetToolTip(RadioEmpty, "Empty Column");
            RadioEmpty.UseVisualStyleBackColor = true;
            RadioEmpty.CheckedChanged += RadioEmpty_CheckedChanged;
            // 
            // RadioBlank
            // 
            RadioBlank.Appearance = Appearance.Button;
            RadioBlank.AutoSize = true;
            RadioBlank.Image = Properties.Resources.blank;
            RadioBlank.Location = new Point(12, 64);
            RadioBlank.Name = "RadioBlank";
            RadioBlank.Size = new Size(46, 46);
            RadioBlank.TabIndex = 1;
            ToolTip.SetToolTip(RadioBlank, "Structural Column");
            RadioBlank.UseVisualStyleBackColor = true;
            RadioBlank.CheckedChanged += RadioBlank_CheckedChanged;
            // 
            // RadioFuel
            // 
            RadioFuel.Appearance = Appearance.Button;
            RadioFuel.AutoSize = true;
            RadioFuel.Image = Properties.Resources.fuel;
            RadioFuel.Location = new Point(12, 116);
            RadioFuel.Name = "RadioFuel";
            RadioFuel.Size = new Size(46, 46);
            RadioFuel.TabIndex = 2;
            ToolTip.SetToolTip(RadioFuel, "Fuel Rod");
            RadioFuel.UseVisualStyleBackColor = true;
            RadioFuel.CheckedChanged += RadioFuel_CheckedChanged;
            // 
            // RadioControl
            // 
            RadioControl.Appearance = Appearance.Button;
            RadioControl.AutoSize = true;
            RadioControl.Image = Properties.Resources.control;
            RadioControl.Location = new Point(12, 168);
            RadioControl.Name = "RadioControl";
            RadioControl.Size = new Size(46, 46);
            RadioControl.TabIndex = 3;
            ToolTip.SetToolTip(RadioControl, "Control Rod");
            RadioControl.UseVisualStyleBackColor = true;
            RadioControl.CheckedChanged += RadioControl_CheckedChanged;
            // 
            // RadioAutoControl
            // 
            RadioAutoControl.Appearance = Appearance.Button;
            RadioAutoControl.AutoSize = true;
            RadioAutoControl.Image = Properties.Resources.control_auto;
            RadioAutoControl.Location = new Point(12, 220);
            RadioAutoControl.Name = "RadioAutoControl";
            RadioAutoControl.Size = new Size(46, 46);
            RadioAutoControl.TabIndex = 4;
            ToolTip.SetToolTip(RadioAutoControl, "Automatic Control Rod");
            RadioAutoControl.UseVisualStyleBackColor = true;
            RadioAutoControl.CheckedChanged += RadioAutoControl_CheckedChanged;
            // 
            // RadioBoiler
            // 
            RadioBoiler.Appearance = Appearance.Button;
            RadioBoiler.AutoSize = true;
            RadioBoiler.Image = Properties.Resources.boiler;
            RadioBoiler.Location = new Point(12, 272);
            RadioBoiler.Name = "RadioBoiler";
            RadioBoiler.Size = new Size(46, 46);
            RadioBoiler.TabIndex = 5;
            ToolTip.SetToolTip(RadioBoiler, "Steam Channel");
            RadioBoiler.UseVisualStyleBackColor = true;
            RadioBoiler.CheckedChanged += RadioBoiler_CheckedChanged;
            // 
            // RadioModerator
            // 
            RadioModerator.Appearance = Appearance.Button;
            RadioModerator.AutoSize = true;
            RadioModerator.Image = Properties.Resources.moderator;
            RadioModerator.Location = new Point(12, 324);
            RadioModerator.Name = "RadioModerator";
            RadioModerator.Size = new Size(46, 46);
            RadioModerator.TabIndex = 6;
            ToolTip.SetToolTip(RadioModerator, "Graphite Moderator");
            RadioModerator.UseVisualStyleBackColor = true;
            RadioModerator.CheckedChanged += RadioModerator_CheckedChanged;
            // 
            // RadioAbsorber
            // 
            RadioAbsorber.Appearance = Appearance.Button;
            RadioAbsorber.AutoSize = true;
            RadioAbsorber.Image = Properties.Resources.absorber;
            RadioAbsorber.Location = new Point(64, 12);
            RadioAbsorber.Name = "RadioAbsorber";
            RadioAbsorber.Size = new Size(46, 46);
            RadioAbsorber.TabIndex = 7;
            ToolTip.SetToolTip(RadioAbsorber, "Neutron Absorber");
            RadioAbsorber.UseVisualStyleBackColor = true;
            RadioAbsorber.CheckedChanged += RadioAbsorber_CheckedChanged;
            // 
            // RadioReflector
            // 
            RadioReflector.Appearance = Appearance.Button;
            RadioReflector.AutoSize = true;
            RadioReflector.Image = Properties.Resources.reflector;
            RadioReflector.Location = new Point(64, 64);
            RadioReflector.Name = "RadioReflector";
            RadioReflector.Size = new Size(46, 46);
            RadioReflector.TabIndex = 8;
            ToolTip.SetToolTip(RadioReflector, "Neutron Reflector");
            RadioReflector.UseVisualStyleBackColor = true;
            RadioReflector.CheckedChanged += RadioReflector_CheckedChanged;
            // 
            // RadioOutgasser
            // 
            RadioOutgasser.Appearance = Appearance.Button;
            RadioOutgasser.AutoSize = true;
            RadioOutgasser.Image = Properties.Resources.outgasser;
            RadioOutgasser.Location = new Point(64, 116);
            RadioOutgasser.Name = "RadioOutgasser";
            RadioOutgasser.Size = new Size(46, 46);
            RadioOutgasser.TabIndex = 9;
            ToolTip.SetToolTip(RadioOutgasser, "Irradiation Channel");
            RadioOutgasser.UseVisualStyleBackColor = true;
            RadioOutgasser.CheckedChanged += RadioOutgasser_CheckedChanged;
            // 
            // RadioStorage
            // 
            RadioStorage.Appearance = Appearance.Button;
            RadioStorage.AutoSize = true;
            RadioStorage.Image = Properties.Resources.storage;
            RadioStorage.Location = new Point(64, 168);
            RadioStorage.Name = "RadioStorage";
            RadioStorage.Size = new Size(46, 46);
            RadioStorage.TabIndex = 10;
            ToolTip.SetToolTip(RadioStorage, "Storage Column");
            RadioStorage.UseVisualStyleBackColor = true;
            RadioStorage.CheckedChanged += RadioStorage_CheckedChanged;
            // 
            // RadioCooler
            // 
            RadioCooler.Appearance = Appearance.Button;
            RadioCooler.AutoSize = true;
            RadioCooler.Image = Properties.Resources.cooler;
            RadioCooler.Location = new Point(64, 220);
            RadioCooler.Name = "RadioCooler";
            RadioCooler.Size = new Size(46, 46);
            RadioCooler.TabIndex = 11;
            ToolTip.SetToolTip(RadioCooler, "Cooler Column");
            RadioCooler.UseVisualStyleBackColor = true;
            RadioCooler.CheckedChanged += RadioCooler_CheckedChanged;
            // 
            // RadioHeatex
            // 
            RadioHeatex.Appearance = Appearance.Button;
            RadioHeatex.AutoSize = true;
            RadioHeatex.Image = Properties.Resources.heatex;
            RadioHeatex.Location = new Point(64, 272);
            RadioHeatex.Name = "RadioHeatex";
            RadioHeatex.Size = new Size(46, 46);
            RadioHeatex.TabIndex = 12;
            ToolTip.SetToolTip(RadioHeatex, "Fluid Heater");
            RadioHeatex.UseVisualStyleBackColor = true;
            RadioHeatex.CheckedChanged += RadioHeatex_CheckedChanged;
            // 
            // Palette
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(125, 382);
            Controls.Add(RadioHeatex);
            Controls.Add(RadioCooler);
            Controls.Add(RadioStorage);
            Controls.Add(RadioOutgasser);
            Controls.Add(RadioReflector);
            Controls.Add(RadioAbsorber);
            Controls.Add(RadioModerator);
            Controls.Add(RadioBoiler);
            Controls.Add(RadioAutoControl);
            Controls.Add(RadioControl);
            Controls.Add(RadioFuel);
            Controls.Add(RadioBlank);
            Controls.Add(RadioEmpty);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Palette";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Palette";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton RadioEmpty;
        private RadioButton RadioBlank;
        private RadioButton RadioFuel;
        private RadioButton RadioControl;
        private RadioButton RadioAutoControl;
        private RadioButton RadioBoiler;
        private RadioButton RadioModerator;
        private RadioButton RadioAbsorber;
        private RadioButton RadioReflector;
        private RadioButton RadioOutgasser;
        private RadioButton RadioStorage;
        private RadioButton RadioCooler;
        private RadioButton RadioHeatex;
        private ToolTip ToolTip;
    }
}