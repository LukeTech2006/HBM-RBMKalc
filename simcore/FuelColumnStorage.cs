using HBM_RBMKalc.fuels;

namespace HBM_RBMKalc.simcore
{
    internal class FuelColumnStorage(Point coords)
    {
        public int ListIndex = -1;
        public Point Coords = coords;
        public BaseFuel? Fuel = null;

        public override string ToString()
        {
            return (Fuel is null ? "No Fuel" : Fuel.ToString()) + $" @ ({Coords.X.ToString().PadLeft(2, '0')}, {Coords.Y.ToString().PadLeft(2, '0')})";
        }
    }
}
