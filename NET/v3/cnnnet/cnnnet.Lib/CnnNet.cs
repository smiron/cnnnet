﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace cnnnet.Lib
{
    public partial class CnnNet
    {
        #region Fields

        private readonly Random _random;
        private readonly object _isProcessingSyncObject;
        private bool _isProcessing;

        private NeuronBase[] _neurons;
        private NeuronInput[] _neuronsInput;

        public readonly int Width;
        public readonly int Height;

        public NeuronBase[,] NeuronPositionMap;
        public double[,] NeuronDesirabilityMap;
        public double[,] NeuronUndesirabilityMap;
        private int _iteration;

        #endregion

        #region Properties

        public IActiveNeuronGenerator ActiveNeuronGenerator
        {
            get;
            set;
        }

        public NeuronBase[] Neurons
        {
            get
            {
                return _neurons;
            }
        }

        public int Iteration
        {
            get { return _iteration; }
        }

        #endregion

        #region Methods

        public void Process()
        {
            #region PreCheck

            lock (_isProcessingSyncObject)
            {
                if (_isProcessing)
                {
                    return;
                }
                _isProcessing = true;
            }

            #endregion

            _iteration++;

            ProcessDetermineActiveNeurons();

            foreach (var neuron in _neurons)
            {
                neuron.Process();
            }

            ProcessDecayDesirabilityAndUndesirability();

            #region End

            lock (_isProcessingSyncObject)
            {
                _isProcessing = false;
            }

            #endregion
        }

        private void ProcessDetermineActiveNeurons()
        {
            foreach (var neuron in _neuronsInput)
            {
                neuron.SetIsActive(false);
            }

            foreach (int activeNeuronId in ActiveNeuronGenerator.GetActiveNeuronIds())
            {
                ((NeuronInput)_neurons[activeNeuronId]).SetIsActive(true);
            }
        }

        private void ProcessDecayDesirabilityAndUndesirability()
        {
            for (int y = 0; y < Height; y++)
            {
                for (int x = 0; x < Width; x++)
                {
                    NeuronDesirabilityMap[y, x] = Math.Max(0, NeuronDesirabilityMap[y, x] - DesirabilityDecayAmount);
                    NeuronUndesirabilityMap[y, x] = Math.Max(0, NeuronUndesirabilityMap[y, x] - UndesirabilityDecayAmount);
                }
            }
        }

        public void GenerateNetwork()
        {
            NeuronDesirabilityMap = new double[Height, Width];
            NeuronUndesirabilityMap = new double[Height, Width];
            NeuronPositionMap = new NeuronBase[Height, Width];

            #region Generate Random Neurons

            var neurons = new List<NeuronBase>();
            for (int i = 0; i < NeuronCount + InputNeuronCount; i++)
            {
                var neuron = i < NeuronCount
                    ? (NeuronBase)(new NeuronCompute(i, this))
                    : (new NeuronInput(i, this));

                do
                {
                    neuron.MoveTo(_random.Next(Height), _random.Next(Width));
                }
                while (neurons.Any(n => n.PosX == neuron.PosX && n.PosY == neuron.PosY));

                neurons.Add(neuron);
                NeuronPositionMap[neuron.PosY, neuron.PosX] = neuron;
            }

            _neurons = neurons.ToArray();

            #endregion

            _neuronsInput = neurons.OfType<NeuronInput>().ToArray();

            ActiveNeuronGenerator =
                new SequentialActiveInputNeuronGenerator
                    (_neuronsInput.Select(neuron => neuron.Id).ToArray(),
                     Math.Min(_neuronsInput.Length, 2));
            _iteration = 0;
        }

        #endregion

        #region Instance

        public CnnNet(int width, int height)
        {
            _random=new Random();
            Width = width;
            Height = height;

            _isProcessingSyncObject = new object();

            GenerateNetwork();
        }

        #endregion
    }
}