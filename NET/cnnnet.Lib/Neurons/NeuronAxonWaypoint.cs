﻿using cnnnet.Lib.Utils;

namespace cnnnet.Lib.Neurons
{
    public class NeuronAxonWaypoint
    {
        #region Properties

        public int Id
        {
            get;
            private set;
        }

        public Neuron Neuron
        {
            get;
            private set;
        }

        public Point Waypoint
        {
            get;
            private set;
        }

        #endregion

        #region Instance

        public NeuronAxonWaypoint(int id, Neuron neuron, Point waypoint)
        {
            Id = id;
            Neuron = neuron;
            Waypoint = waypoint;
        }

        #endregion
    }
}
