namespace HBM_RBMKalc
{
    public partial class Palette : Form
    {
        public delegate void PaletteSelectionEventHandler(object sender, int selection);
        public event PaletteSelectionEventHandler PaletteSelection;

        public Palette()
        {
            InitializeComponent();
        }

        private void RadioEmpty_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioEmpty.Checked) PaletteSelection?.Invoke(this, 0);
        }

        private void RadioBlank_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioBlank.Checked) PaletteSelection?.Invoke(this, 1);
        }

        private void RadioFuel_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioFuel.Checked) PaletteSelection?.Invoke(this, 2);
        }

        private void RadioControl_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioControl.Checked) PaletteSelection?.Invoke(this, 3);
        }

        private void RadioAutoControl_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioAutoControl.Checked) PaletteSelection?.Invoke(this, 4);
        }

        private void RadioBoiler_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioBoiler.Checked) PaletteSelection?.Invoke(this, 5);
        }

        private void RadioModerator_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioModerator.Checked) PaletteSelection?.Invoke(this, 6);
        }

        private void RadioAbsorber_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioAbsorber.Checked) PaletteSelection?.Invoke(this, 7);
        }

        private void RadioReflector_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioReflector.Checked) PaletteSelection?.Invoke(this, 8);
        }

        private void RadioOutgasser_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioOutgasser.Checked) PaletteSelection?.Invoke(this, 9);
        }

        private void RadioStorage_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioStorage.Checked) PaletteSelection?.Invoke(this, 10);
        }

        private void RadioCooler_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioCooler.Checked) PaletteSelection?.Invoke(this, 11);
        }

        private void RadioHeatex_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioHeatex.Checked) PaletteSelection?.Invoke(this, 12);
        }
    }
}
