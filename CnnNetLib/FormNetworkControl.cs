﻿using System.Globalization;
using System.Windows.Forms;
using System.Threading;

namespace CnnNetLib
{
    public partial class FormNetworkControl : Form
    {
        #region Fields

        private readonly object _threadSyncObject;

        private CnnNet _cnnNet;
        private Thread _threadProcess;
        private bool _threadProcessStopInitiated;

        private int _stepNumber;

        #endregion

        #region Properties

        public CnnNet CnnNet
        {
            get
            {
                return _cnnNet;
            }
            set
            {
                _cnnNet = value;
            }
        }

        #endregion

        #region Methods

        public NetworkParameters GetNetworkParameters()
        {
            return new NetworkParameters
            {
                DesirabilityDecayAmount = (double)npDesirabilityDecayAmount.Value,
                InputNeuronCount = (int)npInputNeuronCount.Value,
                InputNeuronsMoveToHigherDesirability = npInputNeuronsMoveToHigherDesirability.Checked,
                MaxNeuronInfluence = (double)npMaxNeuronInfluence.Value,
                MaxNeuronMoveDistance = (int)npMaxNeuronMoveDistance.Value,
                MinDistanceBetweenNeurons = (int)npMinDistanceBetweenNeurons.Value,
                NeuronDensity = (double)npNeuronDensity.Value,
                NeuronDesirabilityPlainRange = (int)npNeuronDesirabilityPlainRange.Value,
                NeuronInfluenceRange = (int)npNeuronInfluenceRange.Value,
                PercentActiveNeurons = (double)npPercentActiveNeurons.Value
            };
        }

        private void CreateThread()
        {
            _threadProcess = new Thread(ProcessNetwork)
            {
                IsBackground = true
            };
        }

        private void ProcessNetwork()
        {
            while (true)
            {
                lock (_threadSyncObject)
                {
                    if (_threadProcessStopInitiated)
                    {
                        _threadProcessStopInitiated = false;
                        break;
                    }
                }

                _cnnNet.Process();

                _stepNumber++;

                this.InvokeEx(f => textBoxStepNumber.Text = _stepNumber.ToString(CultureInfo.InvariantCulture));
            }
        }

        private void OnButtonStartClick(object sender, System.EventArgs e)
        {
            CreateThread();
            _threadProcess.Start();
        }

        private void OnButtonStopClick(object sender, System.EventArgs e)
        {
            lock (_threadSyncObject)
            {
                _threadProcessStopInitiated = true;
            }
        }

        private void OnButtonApplyParametersClick(object sender, System.EventArgs e)
        {
            _cnnNet.SetNetworkParameters(GetNetworkParameters());
        }

        private void OnButtonResetClick(object sender, System.EventArgs e)
        {
            _cnnNet.GenerateNetwork();
        }

        #endregion

        #region Instance

        public FormNetworkControl()
        {
            InitializeComponent();

            CreateThread();

            _threadSyncObject = new object();
        }

        #endregion
    }
}
