﻿using cnnnet.Lib;

namespace cnnnet.ViewerWpf.Viewers
{
    public class ViewerDesirability : ViewerBase
    {
        #region Fields
        
        private readonly CnnNet _network;

        #endregion

        #region Methods

        protected override void UpdateDataInternal(ref byte[,] data)
        {
            var desirabilityMap = (double[,])_network.NeuronDesirabilityMap.Clone();

            for (int y = 0; y < _network.Height; y++)
            {
                for (int x = 0; x < _network.Width; x++)
                {
                    data[y, x * 3 + Constants.ColorGreenIndex] = (byte)(desirabilityMap[y, x] * 255);
                }
            }
        }

        #endregion

        #region Instance

        public ViewerDesirability(CnnNet network)
            : base(network.Width, network.Height, 3, true)
        {
            _network = network;
        }

        #endregion
    }
}
