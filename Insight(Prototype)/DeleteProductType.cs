﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Insight_Prototype_
{
    public partial class DeleteProductType : Form
    {
        public DeleteProductType()
        {
            InitializeComponent();
        }

        private void DProdTCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DProdTDeleteBtn_Click(object sender, EventArgs e)
        {
            using(InsightEntities db = new InsightEntities())
            {
                var ProdType = db.ProductTypes.SingleOrDefault(x => x.ProductTypeID == 2);

                if(ProdType != null)
                {
                    db.ProductTypes.Remove(ProdType);
                    db.SaveChanges();
                }

            }
        }
    }
}
