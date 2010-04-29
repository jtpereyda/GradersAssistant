﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GradersAssistant
{
    public partial class CriteriaTreeTest : Form
    {
        public CriteriaTreeTest()
        {
            InitializeComponent();
        }

     //   private TreeNodeCollection MakeTreeNodeCollectionFromCriteriaResponseTree(CriteriaResponseTree crt)
      //  {
     //       TreeNodeCollection tnc;
      //  }

        private void CriteriaTreeTest_Load(object sender, EventArgs e)
        {
            CriteriaResponseTree col = new CriteriaResponseTree();
            int node = col.AddNewNode(new Criteria(1, "Comments", 0));
            col.AddNewNode(new Criteria(2, "Present", 40), node);
            col.AddNewNode(new Criteria(3, "Well written", 10), node);
        }

        private void criteriaTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                MessageBox.Show(e.Node.Name.ToString());
            }
        }
    }
}