using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using ControlManager;
namespace MoveAndResizeControls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ControlMoverOrResizer.Init(button1);
            ControlMoverOrResizer.Init(groupBox1);
            ControlMoverOrResizer.Init(textBox1);
            ControlMoverOrResizer.Init(button2,panel1);
            cboWorkType.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboWorkType.SelectedIndex)
            {
                case 0:
                    ControlMoverOrResizer.WorkType=ControlMoverOrResizer.MoveOrResize.MoveAndResize;
                    break;
                case 1:
                    ControlMoverOrResizer.WorkType = ControlMoverOrResizer.MoveOrResize.Move;
                    break;
                case 2:
                    ControlMoverOrResizer.WorkType = ControlMoverOrResizer.MoveOrResize.Resize;
                    break;
            }
        }

        private string controlsInfoStr;
        

        private void button3_Click(object sender, EventArgs e)
        {
            controlsInfoStr=ControlMoverOrResizer.GetSizeAndPositionOfControlsToString(this);
        }

        

        private void button4_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(controlsInfoStr))
            {
                ControlMoverOrResizer.SetSizeAndPositionOfControlsFromString(this, controlsInfoStr);
            }
        }
    }
}
