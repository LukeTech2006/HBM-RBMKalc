using HBM_RBMKalc.columns;
using HBM_RBMKalc.fuels;
using HBM_RBMKalc.Properties;
using HBM_RBMKalc.simcore;
using Microsoft.VisualBasic.Devices;
using Newtonsoft.Json;

namespace HBM_RBMKalc
{
    public partial class RBMKalc : Form
    {
        BaseFuel[] FuelList;
        BaseColumn[,] ReactorColumns;
        FuelColumnStorage?[,] FuelColumns;
        Bitmap EmpytBitmap = new(40, 40);
        bool EditingReactor = false;
        int SelectedEditorTile = 0;

        public RBMKalc()
        {
            InitializeComponent();
            this.FuelList = [
                new AmericiumZFB(),
                new BismuthZFB(),
                new MOX(),
                new NU(),
                new LEAm_242(),
                new LEAus(),
                new LEPu_239(),
                new LES(),
                new MEAm_242m(),
                new MENp_237(),
                new MEPu_239(),
                new MES(),
                new MEU_235(),
                new HEAm_242m(),
                new HEAus(),
                new HENp_237(),
                new HEPu_239(),
                new HEPu_241(),
                new HES(),
                new HEU_233(),
                new HEU_235(),
                new Flashgold(),
                new Flashlead(),
                new Balefire(),
                new Digamma()
            ];

            this.ReactorColumns = new BaseColumn[15, 15];
            this.FuelColumns = new FuelColumnStorage[15, 15];

            ReactorGrid.SuspendLayout();
            ReactorGrid.Controls.Clear();
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    this.ReactorColumns[i, j] ??= new BaseColumn();
                    this.ReactorColumns[i, j].Coords = new Point(i, j);
                    ReactorGrid.Controls.Add(new PictureBox() { BackgroundImage = this.ReactorColumns[i, j].GetBaseTexture(), Margin = Padding.Empty }, i, j);
                }
            }
            ReactorGrid.ResumeLayout();

            foreach (PictureBox space in this.ReactorGrid.Controls)
            {
                space.MouseClick += new MouseEventHandler(ReactorGrid_MouseClick);
            }

            this.FormClosing += RBMKalc_FormClosing;
        }

        private void RBMKalc_FormClosing(object? sender, FormClosingEventArgs e)
        {
            if (new Keyboard().ShiftKeyDown) return;
            var Result = MessageBox.Show("Do you want to quit?", "Quit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (Result != DialogResult.Yes) e.Cancel = true;
        }

        public void FuelTypeSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FuelTypeSelection.SelectedIndex < 1)
            {
                FuelFluxFunc.Text = string.Empty;
                FuelXenonGen.Text = string.Empty;
                FuelXenonBurn.Text = string.Empty;
                FuelHeatFunc.Text = string.Empty;
                FuelSelfIgniting.Checked = false;
                return;
            }

            FuelFluxFunc.Text = this.FuelList[FuelTypeSelection.SelectedIndex - 1].FluxFunction;
            FuelXenonGen.Text = this.FuelList[FuelTypeSelection.SelectedIndex - 1].XenonGenFunction;
            FuelXenonBurn.Text = this.FuelList[FuelTypeSelection.SelectedIndex - 1].XenonBurnFunction;
            FuelHeatFunc.Text = this.FuelList[FuelTypeSelection.SelectedIndex - 1].HeatPerTickPerFlux.ToString() + " °C";
            FuelSelfIgniting.Checked = this.FuelList[FuelTypeSelection.SelectedIndex - 1].SelfIgniting;
        }

        private void OpenMenuItem_Click(object sender, EventArgs e)
        {
            var DialogResult = OpenFileDialog.ShowDialog();
            if (DialogResult != DialogResult.OK) return;
            var options = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };
            StringReader JsonString = new(File.ReadAllText(OpenFileDialog.FileName));
            var Result = (BaseColumn[,])JsonSerializer.CreateDefault(options).Deserialize(JsonString, typeof(BaseColumn[,]));
            this.ReactorColumns = Result ??= this.ReactorColumns;

            ReactorGrid.SuspendLayout();
            ReactorGrid.Controls.Clear();
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    this.ReactorColumns[i, j] ??= new BaseColumn();
                    this.ReactorColumns[i, j].Coords = new Point(i, j);
                    ReactorGrid.Controls.Add(new PictureBox() { Image = this.ReactorColumns[i, j].GetBaseTexture(), Margin = Padding.Empty }, i, j);
                }
            }
            ReactorGrid.ResumeLayout();

            foreach (PictureBox space in this.ReactorGrid.Controls)
            {
                space.MouseClick += new MouseEventHandler(ReactorGrid_MouseClick);
            }
        }

        private void SaveMenuItem_Click(object sender, EventArgs e)
        {
            var DialogResult = SaveFileDialog.ShowDialog();
            if (DialogResult != DialogResult.OK) return;
            var options = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };
            StringWriter JsonString = new();
            JsonSerializer.CreateDefault(options).Serialize(JsonString, this.ReactorColumns);
            File.WriteAllText(SaveFileDialog.FileName, JsonString.ToString());
        }

        private void QuitMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StartMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void StepMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void TickspeedMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void HeatWarningMenuItem_Click(object sender, EventArgs e)
        {
            HeatWarningMenuItem.Checked = !HeatWarningMenuItem.Checked;
        }

        private void FluxRunawayWarningMenuItem_Click(object sender, EventArgs e)
        {
            FluxRunawayWarningMenuItem.Checked = !FluxRunawayWarningMenuItem.Checked;
        }

        private void ReaSimBoilerMenuItem_Click(object sender, EventArgs e)
        {
            ReaSimBoilerMenuItem.Checked = !ReaSimBoilerMenuItem.Checked;
        }

        private void OpenHelpMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void AboutMenuItem_Click(object sender, EventArgs e)
        {
            AboutPage AboutPage = new();
            AboutPage.ShowDialog();
            AboutPage.Dispose();
        }

        private void FuelTypeApply_Click(object sender, EventArgs e)
        {
            BaseFuel? NewFuel = null;
            switch (FuelTypeSelection.SelectedIndex)
            {
                case 1: NewFuel = new AmericiumZFB(); break;
                case 2: NewFuel = new BismuthZFB(); break;
                case 3: NewFuel = new MOX(); break;
                case 4: NewFuel = new NU(); break;
                case 5: NewFuel = new LEAm_242(); break;
                case 6: NewFuel = new LEAus(); break;
                case 7: NewFuel = new LEPu_239(); break;
                case 8: NewFuel = new LES(); break;
                case 9: NewFuel = new MEAm_242m(); break;
                case 10: NewFuel = new MENp_237(); break;
                case 11: NewFuel = new MEPu_239(); break;
                case 12: NewFuel = new MES(); break;
                case 13: NewFuel = new MEU_235(); break;
                case 14: NewFuel = new HEAm_242m(); break;
                case 15: NewFuel = new HEAus(); break;
                case 16: NewFuel = new HENp_237(); break;
                case 17: NewFuel = new HEPu_239(); break;
                case 18: NewFuel = new HEPu_241(); break;
                case 19: NewFuel = new HES(); break;
                case 20: NewFuel = new HEU_233(); break;
                case 21: NewFuel = new HEU_235(); break;
                case 22: NewFuel = new Flashgold(); break;
                case 23: NewFuel = new Flashlead(); break;
                case 24: NewFuel = new Balefire(); break;
                case 25: NewFuel = new Digamma(); break;
            }

            (FuelColumnList.SelectedItem as FuelColumnStorage).Fuel = NewFuel;
            RedrawFuelColumnList();
        }

        private void ReactorGrid_MouseClick(object sender, MouseEventArgs e)
        {
            if (!EditingReactor) return;
            BaseColumn NewColumn = new();
            switch (SelectedEditorTile)
            {
                case 1: NewColumn = new StructualColumn(); break;
                case 2: NewColumn = new FuelColumn(); break;
                case 3: NewColumn = new ControlColumn(); break;
                case 4: NewColumn = new AutoControlColumn(); break;
                case 5: NewColumn = new BoilerColumn(); break;
                case 6: NewColumn = new ModeratorColumn(); break;
                case 7: NewColumn = new AbsorberColumn(); break;
                case 8: NewColumn = new ReflectorColumn(); break;
                case 9: NewColumn = new OutgasserColumn(); break;
                case 10: NewColumn = new StorageColumn(); break;
                case 11: NewColumn = new CoolerColumn(); break;
                case 12: NewColumn = new HeatexColumn(); break;
            }

            int NewTileColumn = ReactorGrid.GetColumn((PictureBox)sender);
            int NewTileRow = ReactorGrid.GetRow((PictureBox)sender);

            if (SelectedEditorTile == 2)
            {
                this.FuelColumns[NewTileColumn, NewTileRow] = new FuelColumnStorage(new Point(NewTileColumn, NewTileRow));
            } else { this.FuelColumns[NewTileColumn, NewTileRow] = null; }
            RedrawFuelColumnList();

            this.ReactorColumns[NewTileColumn, NewTileRow] = NewColumn;
            (ReactorGrid.Controls[(NewTileColumn * 15) + NewTileRow] as PictureBox).BackgroundImage = NewColumn.GetBaseTexture();
        }

        private void EditReactorMenuItem_Click(object sender, EventArgs e)
        {
            EditingReactor = true; SelectedEditorTile = 0;
            var PaletteWindow = new Palette();
            PaletteWindow.Show();
            PaletteWindow.PaletteSelection += PaletteWindow_OnPaletteSelection;
            PaletteWindow.FormClosing += PaletteWindow_OnFormClosing;
        }

        private void PaletteWindow_OnFormClosing(object? sender, FormClosingEventArgs e)
        {
            EditingReactor = false;
        }

        private void PaletteWindow_OnPaletteSelection(object sender, int selection)
        {
            SelectedEditorTile = selection;
        }

        private void RedrawFuelColumnList()
        {
            int CurrentIndex = FuelColumnList.SelectedIndex;
            FuelColumnList.Items.Clear();
            foreach (var FuelColumn in FuelColumns)
            {
                if (FuelColumn is null) continue;
                FuelColumnList.Items.Add(FuelColumn);
            }
            FuelColumnList.SelectedIndex = Math.Clamp(CurrentIndex, -1, FuelColumnList.Items.Count - 1);
        }

        private void FuelColumnList_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (PictureBox pb in ReactorGrid.Controls) pb.Image = EmpytBitmap;
            var SelectedFuelColumn = FuelColumnList.SelectedItem as FuelColumnStorage;
            (ReactorGrid.Controls[(SelectedFuelColumn.Coords.X * 15) + SelectedFuelColumn.Coords.Y] as PictureBox).Image = Resources.selected;
        }
    }
}