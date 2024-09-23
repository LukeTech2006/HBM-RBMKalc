using HBM_RBMKalc.columns;
using HBM_RBMKalc.dials;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Channels;

namespace HBM_RBMKalc.simcore
{
    internal class Simulation
    {
        private BaseColumn[,] ReactorLayout;
        private Channel<SimulationStatusReport> Channel;
        private RBMKDials Dials;

#pragma warning disable //Shut the fuck up
        public Simulation(BaseColumn[,] ReactorLayout)
        {
            this.ReactorLayout = ReactorLayout;
        }
#pragma warning restore

        private long GetMilliseconds() => DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;

        private void RunSimulation()
        {
            Vector2[] Directions = [
                new(1, 0),          //X positive (right)
                new(-1, 0),         //X negative (left)
                new(0, 1),          //Y positive (down)
                new(0, -1)          //Y negative (up)
            ];

            bool Running = true;
            while (Running)
            {
                //C# is too efficient, so we drop the sim speed to 20Hz (minecraft game tick time)
                long milliseconds = GetMilliseconds();
                if (milliseconds % 20 != 0) continue;

                //Execute in every column
                foreach (var Column in ReactorLayout)
                {
                    //spread neutron flux
                    foreach (var direction in Directions)
                    {
                        for (int range = 1; range < this.Dials.dialFluxRange; range++)
                        {
                            int CurrentColumn = (int)Math.Clamp(Column.Coords.X + (direction.X * range), 0, 14);
                            int CurrentRow = (int)Math.Clamp(Column.Coords.Y + (direction.Y * range), 0, 14);
                        }
                    }
                }
            }
        }

        public Task Start(Channel<SimulationStatusReport> TaskChannel, RBMKDials Dials)
        {
            this.Channel = TaskChannel; this.Dials = Dials;
            return Task.Factory.StartNew(RunSimulation);
        }
    }
}
