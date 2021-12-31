﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VKControls.VKStepProgressBar
{

    public enum StepState
    {
        Done = 0,
        Waiting = 1,
        Undefined = 2
    }

    public partial class VKStepProgressBar : UserControl
    {

        private int _statesCount = 1;

        private Action<UserControl> OnContentChanged = (control) =>
        {
            control.Invalidate();
        };


        private Collection<string> _stateNames = new Collection<string>();
        public Collection<string> StateNames
        {
            get => _stateNames;
            set
            {
                if (value != null && value.Any())
                {
                    _stateNames = value;
                    OnContentChanged(this);
                }
            }
        }

        public int StatesCount
        {
            get => _statesCount;
            set
            {
                if(_statesCount >= 1)
                {
                    _statesCount = value;
                    OnContentChanged(this);
                }
            }
        }

        public VKStepProgressBar()
        {
            InitializeComponent();
        }

        public void AddStep(string caption)
        {

        }

        public void ConfirmNextStep(int index)
        {

        }

        public void DeclineStep(int index)
        {

        }

        public void SetStepState(int index, StepState state)
        {

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            var xOffset = 0;
            for (int i = 0; i < StatesCount; i++)
            {
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                e.Graphics.DrawEllipse(new Pen(new SolidBrush(Color.Gray), 2), new Rectangle(3 + xOffset, 3, 50, 50));
                if (i != StatesCount - 1)
                {
                    e.Graphics.DrawLine(new Pen(new SolidBrush(Color.Gray), 2), new Point(53 + xOffset, 27), new Point(53 + xOffset + 70, 27));
                }

                if (_stateNames != null && _stateNames.Any())
                {
                    e.Graphics.DrawString(_stateNames[i], new Font("Arial", 10), Brushes.Black, new RectangleF(3 + xOffset, 50, 50, 50),new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center});
                }
                xOffset += 120;
            }
        }
    }
}