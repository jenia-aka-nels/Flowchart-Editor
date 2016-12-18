﻿using FlowchartEditorMVP.Model;
using FlowchartEditorMVP.Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowchartEditorMVP.View
{
    public partial class ReviewerView : Form , IView
    {
        private int xCoordsClick;
        private int yCoordsClick;        
        private IFlowchartPresenter flowchartPresenter;

        internal ReviewerView(DataManagement data)
        {
            InitializeComponent();
            flowchartPresenter = new ReviewerPresenter(data, this);
        }

        private void ReviewerView_Load(object sender, EventArgs e)
        {
            
        }

        private void addBlockButton_Click(object sender, EventArgs e)
        {
            flowchartPresenter.AddBlock(codeTextbox.Text); //vScrollBar1.Value
        }

        private void editBlockButton_Click(object sender, EventArgs e)
        {
            //flowchartPresenter.EditBlock(); //vScrollBar1.Value
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            flowchartPresenter.RemoveBlock();//vScrollBar1.Value
        }

        private void toCodeButton_Click(object sender, EventArgs e)
        {
            flowchartPresenter.ToCode();            
        }

        private void changeModeButton_Click(object sender, EventArgs e)
        {
            flowchartPresenter.ToChooseFlowchart();                
        }

        private void flowchartPictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            xCoordsClick = e.X;
            yCoordsClick = e.Y;
            if (flowchartPresenter.IsEdge(xCoordsClick, yCoordsClick, 0)) //vScrollBar1.Value
                addBlockButton.Enabled = true;

            if (flowchartPresenter.IsSquareBlock(-1))//vScrollBar1.Value
            {
                editBlockButton.Enabled = true;
                removeButton.Enabled = true;
            }
        }

        private void toDatabaseButton_Click(object sender, EventArgs e)
        {
            flowchartPresenter.ToDataBase();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            flowchartPresenter.ToChooseFlowchart();
        }
    }
}
