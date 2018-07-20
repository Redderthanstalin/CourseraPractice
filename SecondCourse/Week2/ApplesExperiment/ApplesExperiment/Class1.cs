using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplesExperiment
{
    class Apple
    {
        #region Fields

        float amountLeft;
        bool organic;

        #endregion
      
        public float AmountLeft
        {
            get { return amountLeft; }
        }

        public bool Organic
        {
            get { return organic; }
        }

        #region Properties


        #endregion

        #region Methods

        public void TakeBite(float size)
        {
            amountLeft -= size;
        }

        #endregion

    }
}
