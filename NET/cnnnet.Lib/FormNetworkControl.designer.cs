﻿namespace cnnnet.Lib
{
    partial class FormNetworkControl
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
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.radioButtonRunInfinity = new System.Windows.Forms.RadioButton();
            this.buttonReset = new System.Windows.Forms.Button();
            this.radioButtonSteps = new System.Windows.Forms.RadioButton();
            this.nudSteps = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxStepNumber = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonApplyParameters = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.npMaxNeuronMoveDistance = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.npInputNeuronCount = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.npMinDistanceBetweenNeurons = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.npNeuronDesirabilityPlainRange = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.npDesirabilityDecayAmount = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.npMaxNeuronInfluence = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.npNeuronInfluenceRange = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.npNeuronCount = new System.Windows.Forms.NumericUpDown();
            this.radioButtonStepByStep = new System.Windows.Forms.RadioButton();
            this.buttonNextStepByStep = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dsNeuronUndesirabilityMap = new System.Windows.Forms.CheckBox();
            this.dsNeuronDesirabilityMap = new System.Windows.Forms.CheckBox();
            this.dsDisplayNeuronDesirabilityRange = new System.Windows.Forms.CheckBox();
            this.textBoxStepsPerSecond = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbNeuronLocation = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbNeuronId = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboxBreakOnceOnNeuronProcess = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudSteps)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.npMaxNeuronMoveDistance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npInputNeuronCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npMinDistanceBetweenNeurons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npNeuronDesirabilityPlainRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npDesirabilityDecayAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npMaxNeuronInfluence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npNeuronInfluenceRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npNeuronCount)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(12, 32);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.OnButtonStartClick);
            // 
            // buttonStop
            // 
            this.buttonStop.Enabled = false;
            this.buttonStop.Location = new System.Drawing.Point(93, 32);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 2;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.OnButtonStopClick);
            // 
            // radioButtonRunInfinity
            // 
            this.radioButtonRunInfinity.AutoSize = true;
            this.radioButtonRunInfinity.Checked = true;
            this.radioButtonRunInfinity.Location = new System.Drawing.Point(12, 61);
            this.radioButtonRunInfinity.Name = "radioButtonRunInfinity";
            this.radioButtonRunInfinity.Size = new System.Drawing.Size(55, 17);
            this.radioButtonRunInfinity.TabIndex = 3;
            this.radioButtonRunInfinity.TabStop = true;
            this.radioButtonRunInfinity.Text = "Infinity";
            this.radioButtonRunInfinity.UseVisualStyleBackColor = true;
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(184, 32);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 4;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.OnButtonResetClick);
            // 
            // radioButtonSteps
            // 
            this.radioButtonSteps.AutoSize = true;
            this.radioButtonSteps.Location = new System.Drawing.Point(12, 91);
            this.radioButtonSteps.Name = "radioButtonSteps";
            this.radioButtonSteps.Size = new System.Drawing.Size(52, 17);
            this.radioButtonSteps.TabIndex = 5;
            this.radioButtonSteps.TabStop = true;
            this.radioButtonSteps.Text = "Steps";
            this.radioButtonSteps.UseVisualStyleBackColor = true;
            this.radioButtonSteps.CheckedChanged += new System.EventHandler(this.OnRadioButtonStepsCheckedChanged);
            // 
            // nudSteps
            // 
            this.nudSteps.Enabled = false;
            this.nudSteps.Location = new System.Drawing.Point(105, 92);
            this.nudSteps.Name = "nudSteps";
            this.nudSteps.Size = new System.Drawing.Size(52, 20);
            this.nudSteps.TabIndex = 6;
            this.nudSteps.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Step Number";
            // 
            // textBoxStepNumber
            // 
            this.textBoxStepNumber.Location = new System.Drawing.Point(92, 6);
            this.textBoxStepNumber.Name = "textBoxStepNumber";
            this.textBoxStepNumber.ReadOnly = true;
            this.textBoxStepNumber.Size = new System.Drawing.Size(75, 20);
            this.textBoxStepNumber.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonApplyParameters);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.npMaxNeuronMoveDistance);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.npInputNeuronCount);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.npMinDistanceBetweenNeurons);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.npNeuronDesirabilityPlainRange);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.npDesirabilityDecayAmount);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.npMaxNeuronInfluence);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.npNeuronInfluenceRange);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.npNeuronCount);
            this.groupBox1.Location = new System.Drawing.Point(290, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 282);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Network Settings";
            // 
            // buttonApplyParameters
            // 
            this.buttonApplyParameters.Location = new System.Drawing.Point(157, 250);
            this.buttonApplyParameters.Name = "buttonApplyParameters";
            this.buttonApplyParameters.Size = new System.Drawing.Size(75, 23);
            this.buttonApplyParameters.TabIndex = 19;
            this.buttonApplyParameters.Text = "Apply";
            this.buttonApplyParameters.UseVisualStyleBackColor = true;
            this.buttonApplyParameters.Click += new System.EventHandler(this.OnButtonApplyParametersClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 226);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Max Neuron Move Distance";
            // 
            // npMaxNeuronMoveDistance
            // 
            this.npMaxNeuronMoveDistance.Location = new System.Drawing.Point(173, 224);
            this.npMaxNeuronMoveDistance.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.npMaxNeuronMoveDistance.Name = "npMaxNeuronMoveDistance";
            this.npMaxNeuronMoveDistance.Size = new System.Drawing.Size(59, 20);
            this.npMaxNeuronMoveDistance.TabIndex = 17;
            this.npMaxNeuronMoveDistance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.npMaxNeuronMoveDistance.ThousandsSeparator = true;
            this.npMaxNeuronMoveDistance.Value = new decimal(new int[] {
            999,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Input Neuron Count";
            // 
            // npInputNeuronCount
            // 
            this.npInputNeuronCount.Location = new System.Drawing.Point(173, 45);
            this.npInputNeuronCount.Name = "npInputNeuronCount";
            this.npInputNeuronCount.Size = new System.Drawing.Size(59, 20);
            this.npInputNeuronCount.TabIndex = 14;
            this.npInputNeuronCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.npInputNeuronCount.ThousandsSeparator = true;
            this.npInputNeuronCount.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(157, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Min Distance Between Neurons";
            // 
            // npMinDistanceBetweenNeurons
            // 
            this.npMinDistanceBetweenNeurons.Location = new System.Drawing.Point(173, 175);
            this.npMinDistanceBetweenNeurons.Name = "npMinDistanceBetweenNeurons";
            this.npMinDistanceBetweenNeurons.Size = new System.Drawing.Size(59, 20);
            this.npMinDistanceBetweenNeurons.TabIndex = 12;
            this.npMinDistanceBetweenNeurons.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.npMinDistanceBetweenNeurons.ThousandsSeparator = true;
            this.npMinDistanceBetweenNeurons.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Neuron Desirability Plain Range";
            // 
            // npNeuronDesirabilityPlainRange
            // 
            this.npNeuronDesirabilityPlainRange.Location = new System.Drawing.Point(173, 149);
            this.npNeuronDesirabilityPlainRange.Name = "npNeuronDesirabilityPlainRange";
            this.npNeuronDesirabilityPlainRange.Size = new System.Drawing.Size(59, 20);
            this.npNeuronDesirabilityPlainRange.TabIndex = 10;
            this.npNeuronDesirabilityPlainRange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.npNeuronDesirabilityPlainRange.ThousandsSeparator = true;
            this.npNeuronDesirabilityPlainRange.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Desirability Decay Amount";
            // 
            // npDesirabilityDecayAmount
            // 
            this.npDesirabilityDecayAmount.DecimalPlaces = 3;
            this.npDesirabilityDecayAmount.Increment = new decimal(new int[] {
            5,
            0,
            0,
            196608});
            this.npDesirabilityDecayAmount.Location = new System.Drawing.Point(173, 123);
            this.npDesirabilityDecayAmount.Name = "npDesirabilityDecayAmount";
            this.npDesirabilityDecayAmount.Size = new System.Drawing.Size(59, 20);
            this.npDesirabilityDecayAmount.TabIndex = 6;
            this.npDesirabilityDecayAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.npDesirabilityDecayAmount.ThousandsSeparator = true;
            this.npDesirabilityDecayAmount.Value = new decimal(new int[] {
            5,
            0,
            0,
            196608});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Max Neuron Influence";
            // 
            // npMaxNeuronInfluence
            // 
            this.npMaxNeuronInfluence.DecimalPlaces = 2;
            this.npMaxNeuronInfluence.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.npMaxNeuronInfluence.Location = new System.Drawing.Point(173, 97);
            this.npMaxNeuronInfluence.Name = "npMaxNeuronInfluence";
            this.npMaxNeuronInfluence.Size = new System.Drawing.Size(59, 20);
            this.npMaxNeuronInfluence.TabIndex = 4;
            this.npMaxNeuronInfluence.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.npMaxNeuronInfluence.ThousandsSeparator = true;
            this.npMaxNeuronInfluence.Value = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Neuron Influence Range";
            // 
            // npNeuronInfluenceRange
            // 
            this.npNeuronInfluenceRange.Location = new System.Drawing.Point(173, 71);
            this.npNeuronInfluenceRange.Name = "npNeuronInfluenceRange";
            this.npNeuronInfluenceRange.Size = new System.Drawing.Size(59, 20);
            this.npNeuronInfluenceRange.TabIndex = 2;
            this.npNeuronInfluenceRange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.npNeuronInfluenceRange.ThousandsSeparator = true;
            this.npNeuronInfluenceRange.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Neuron Count";
            // 
            // npNeuronCount
            // 
            this.npNeuronCount.Location = new System.Drawing.Point(173, 19);
            this.npNeuronCount.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.npNeuronCount.Name = "npNeuronCount";
            this.npNeuronCount.Size = new System.Drawing.Size(59, 20);
            this.npNeuronCount.TabIndex = 0;
            this.npNeuronCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.npNeuronCount.ThousandsSeparator = true;
            this.npNeuronCount.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // radioButtonStepByStep
            // 
            this.radioButtonStepByStep.AutoSize = true;
            this.radioButtonStepByStep.Location = new System.Drawing.Point(12, 121);
            this.radioButtonStepByStep.Name = "radioButtonStepByStep";
            this.radioButtonStepByStep.Size = new System.Drawing.Size(87, 17);
            this.radioButtonStepByStep.TabIndex = 10;
            this.radioButtonStepByStep.TabStop = true;
            this.radioButtonStepByStep.Text = "Step By Step";
            this.radioButtonStepByStep.UseVisualStyleBackColor = true;
            this.radioButtonStepByStep.CheckedChanged += new System.EventHandler(this.OnRadioButtonStepByStepCheckedChanged);
            // 
            // buttonNextStepByStep
            // 
            this.buttonNextStepByStep.Location = new System.Drawing.Point(105, 118);
            this.buttonNextStepByStep.Name = "buttonNextStepByStep";
            this.buttonNextStepByStep.Size = new System.Drawing.Size(75, 23);
            this.buttonNextStepByStep.TabIndex = 11;
            this.buttonNextStepByStep.Text = "Next";
            this.buttonNextStepByStep.UseVisualStyleBackColor = true;
            this.buttonNextStepByStep.Click += new System.EventHandler(this.OnButtonNextStepByStepClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dsNeuronUndesirabilityMap);
            this.groupBox2.Controls.Add(this.dsNeuronDesirabilityMap);
            this.groupBox2.Controls.Add(this.dsDisplayNeuronDesirabilityRange);
            this.groupBox2.Location = new System.Drawing.Point(12, 147);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(272, 147);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Display Settings";
            // 
            // dsNeuronUndesirabilityMap
            // 
            this.dsNeuronUndesirabilityMap.AutoSize = true;
            this.dsNeuronUndesirabilityMap.Checked = true;
            this.dsNeuronUndesirabilityMap.CheckState = System.Windows.Forms.CheckState.Checked;
            this.dsNeuronUndesirabilityMap.Location = new System.Drawing.Point(6, 65);
            this.dsNeuronUndesirabilityMap.Name = "dsNeuronUndesirabilityMap";
            this.dsNeuronUndesirabilityMap.Size = new System.Drawing.Size(150, 17);
            this.dsNeuronUndesirabilityMap.TabIndex = 19;
            this.dsNeuronUndesirabilityMap.Text = "Neuron Undesirability Map";
            this.dsNeuronUndesirabilityMap.UseVisualStyleBackColor = true;
            // 
            // dsNeuronDesirabilityMap
            // 
            this.dsNeuronDesirabilityMap.AutoSize = true;
            this.dsNeuronDesirabilityMap.Checked = true;
            this.dsNeuronDesirabilityMap.CheckState = System.Windows.Forms.CheckState.Checked;
            this.dsNeuronDesirabilityMap.Location = new System.Drawing.Point(6, 19);
            this.dsNeuronDesirabilityMap.Name = "dsNeuronDesirabilityMap";
            this.dsNeuronDesirabilityMap.Size = new System.Drawing.Size(138, 17);
            this.dsNeuronDesirabilityMap.TabIndex = 18;
            this.dsNeuronDesirabilityMap.Text = "Neuron Desirability Map";
            this.dsNeuronDesirabilityMap.UseVisualStyleBackColor = true;
            // 
            // dsDisplayNeuronDesirabilityRange
            // 
            this.dsDisplayNeuronDesirabilityRange.AutoSize = true;
            this.dsDisplayNeuronDesirabilityRange.Location = new System.Drawing.Point(6, 42);
            this.dsDisplayNeuronDesirabilityRange.Name = "dsDisplayNeuronDesirabilityRange";
            this.dsDisplayNeuronDesirabilityRange.Size = new System.Drawing.Size(149, 17);
            this.dsDisplayNeuronDesirabilityRange.TabIndex = 17;
            this.dsDisplayNeuronDesirabilityRange.Text = "Neuron Desirability Range";
            this.dsDisplayNeuronDesirabilityRange.UseVisualStyleBackColor = true;
            // 
            // textBoxStepsPerSecond
            // 
            this.textBoxStepsPerSecond.Location = new System.Drawing.Point(184, 6);
            this.textBoxStepsPerSecond.Name = "textBoxStepsPerSecond";
            this.textBoxStepsPerSecond.ReadOnly = true;
            this.textBoxStepsPerSecond.Size = new System.Drawing.Size(75, 20);
            this.textBoxStepsPerSecond.TabIndex = 13;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cboxBreakOnceOnNeuronProcess);
            this.groupBox3.Controls.Add(this.lbNeuronLocation);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.lbNeuronId);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(12, 300);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(525, 292);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Neuron Control";
            // 
            // lbNeuronLocation
            // 
            this.lbNeuronLocation.AutoSize = true;
            this.lbNeuronLocation.Location = new System.Drawing.Point(60, 52);
            this.lbNeuronLocation.Name = "lbNeuronLocation";
            this.lbNeuronLocation.Size = new System.Drawing.Size(73, 13);
            this.lbNeuronLocation.TabIndex = 3;
            this.lbNeuronLocation.Text = "<LOCATION>";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Location";
            // 
            // lbNeuronId
            // 
            this.lbNeuronId.AutoSize = true;
            this.lbNeuronId.Location = new System.Drawing.Point(37, 26);
            this.lbNeuronId.Name = "lbNeuronId";
            this.lbNeuronId.Size = new System.Drawing.Size(30, 13);
            this.lbNeuronId.TabIndex = 1;
            this.lbNeuronId.Text = "<ID>";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "ID";
            // 
            // cboxBreakOnceOnNeuronProcess
            // 
            this.cboxBreakOnceOnNeuronProcess.AutoSize = true;
            this.cboxBreakOnceOnNeuronProcess.Location = new System.Drawing.Point(9, 81);
            this.cboxBreakOnceOnNeuronProcess.Name = "cboxBreakOnceOnNeuronProcess";
            this.cboxBreakOnceOnNeuronProcess.Size = new System.Drawing.Size(179, 17);
            this.cboxBreakOnceOnNeuronProcess.TabIndex = 4;
            this.cboxBreakOnceOnNeuronProcess.Text = "Break Once On Neuron Process";
            this.cboxBreakOnceOnNeuronProcess.UseVisualStyleBackColor = true;
            // 
            // FormNetworkControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 604);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.textBoxStepsPerSecond);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonNextStepByStep);
            this.Controls.Add(this.radioButtonStepByStep);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxStepNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudSteps);
            this.Controls.Add(this.radioButtonSteps);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.radioButtonRunInfinity);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormNetworkControl";
            this.Text = "Controls";
            ((System.ComponentModel.ISupportInitialize)(this.nudSteps)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.npMaxNeuronMoveDistance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npInputNeuronCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npMinDistanceBetweenNeurons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npNeuronDesirabilityPlainRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npDesirabilityDecayAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npMaxNeuronInfluence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npNeuronInfluenceRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npNeuronCount)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.RadioButton radioButtonRunInfinity;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.RadioButton radioButtonSteps;
        private System.Windows.Forms.NumericUpDown nudSteps;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxStepNumber;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown npNeuronCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown npNeuronInfluenceRange;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown npMaxNeuronInfluence;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown npDesirabilityDecayAmount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown npNeuronDesirabilityPlainRange;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown npMinDistanceBetweenNeurons;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown npInputNeuronCount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown npMaxNeuronMoveDistance;
        private System.Windows.Forms.Button buttonApplyParameters;
        private System.Windows.Forms.RadioButton radioButtonStepByStep;
        private System.Windows.Forms.Button buttonNextStepByStep;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.CheckBox dsDisplayNeuronDesirabilityRange;
        public System.Windows.Forms.CheckBox dsNeuronDesirabilityMap;
        public System.Windows.Forms.CheckBox dsNeuronUndesirabilityMap;
        private System.Windows.Forms.TextBox textBoxStepsPerSecond;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.Label lbNeuronId;
        public System.Windows.Forms.Label lbNeuronLocation;
        public System.Windows.Forms.CheckBox cboxBreakOnceOnNeuronProcess;
    }
}