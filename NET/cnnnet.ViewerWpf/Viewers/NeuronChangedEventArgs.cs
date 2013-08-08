﻿using cnnnet.Lib.Neurons;
using System;
using System.Diagnostics.Contracts;

namespace cnnnet.ViewerWpf.Viewers
{
    public class NeuronChangedEventArgs : EventArgs
    {
        #region Properties
        
        public Neuron Neuron
        {
            get;
            private set;
        }

        #endregion

        #region Instance

        public NeuronChangedEventArgs(Neuron neuron)
        {
            Contract.Requires<ArgumentNullException>(neuron != null);

            Neuron = neuron;
        }

        #endregion
    }
}
