using System;
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
        private const int _borderSize = 50;

        private static int _actualStateIndex = 0;
        private static StepState _actualState = StepState.Undefined;

        private Action<UserControl> OnContentChanged = (control) =>
        {
            control.Invalidate();
        };

        public Color LineColor { get; set; } = Color.Gray;
        public Color SuccessLineColor { get; set; } = Color.Green;
        public Color WaitingStateColor { get; set; } = Color.Green;
        public Color DoneStateColor { get; set; } = Color.Purple;
        public Color EllipseColor { get; set; } = Color.Gray;

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
                    this.Width = 120 * _statesCount;
                    OnContentChanged(this);
                }
            }
        }

        public VKStepProgressBar()
        {
            InitializeComponent();
        }


        public void SetStepState(StepState state)
        {
            if (_actualStateIndex == StatesCount) return;
            switch(state)
            {
                case StepState.Undefined:
                    _actualState = StepState.Undefined;
                    OnContentChanged(this);
                    break;
                case StepState.Waiting:
                    _actualState = StepState.Waiting;
                    OnContentChanged(this);
                    break;
                case StepState.Done:
                    _actualState = StepState.Done;
                    _actualStateIndex++;
                    OnContentChanged(this);
                    break;
                default:
                    break;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            var xOffset = 0;
            for (int i = 0; i < StatesCount; i++)
            {
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

                /* Draw ellipses */
                e.Graphics.DrawEllipse(new Pen(new SolidBrush(EllipseColor), 2), new Rectangle(3 + xOffset, 3, _borderSize, _borderSize));
                if (i < _actualStateIndex)
                {
                    e.Graphics.FillEllipse(new SolidBrush(DoneStateColor), new Rectangle(3 + xOffset, 3, _borderSize, _borderSize));
                    e.Graphics.DrawLines(new Pen(new SolidBrush(Color.White), 4), new Point[]
                    {
                          /* Drawing done mark */
                          new Point(14 + xOffset, 26),
                          new Point(26 + xOffset, 38),
                          new Point(41 +xOffset, 18)
                    });
                    if(i != StatesCount - 1)
                    e.Graphics.DrawLine(new Pen(new SolidBrush(SuccessLineColor), 2), new Point(53 + xOffset, 27), new Point(53 + xOffset + 70, 27));
                }
                else
                {
                    if(i != StatesCount - 1)
                    e.Graphics.DrawLine(new Pen(new SolidBrush(LineColor), 2), new Point(53 + xOffset, 27), new Point(53 + xOffset + 70, 27));
                }

                if (i == _actualStateIndex)
                {
                    switch(_actualState)
                    {
                        case StepState.Undefined:
                            break;
                        case StepState.Waiting:
                            e.Graphics.DrawArc(new Pen(new SolidBrush(WaitingStateColor), 10), new Rectangle(8 + xOffset, 8, 40, 40), 0F, 360F);
                            break;
                        default:
                            break;
                    }
                }

                /* Draw names */
                if (_stateNames != null && _stateNames.Any())
                {
                    e.Graphics.DrawString(_stateNames[i], new Font("Arial", 8), Brushes.Black, new RectangleF(3 + xOffset, 50, 50, 50), new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
                }
                xOffset += 120;
            }
        }
    }
}
