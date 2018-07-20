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

        #region Properties

        public float AmountLeft
        {
            get { return amountLeft; }
        }

        public bool Organic
        {
            get { return organic; }
        }

        #endregion

        #region

        public Apple(bool organic, float size)
        {
            this.organic = organic;
            amountLeft = size;
        }
        
        #endregion

        #region Methods

        public void TakeBite(float biteSize)
        {
            while(amountLeft > 0)
            {
                amountLeft -= biteSize;
                Console.WriteLine("Apple still has " + amountLeft.ToString() + " left.");
                Console.Write("How big is the next bite? ");
                float bite = float.Parse(Console.ReadLine());
                TakeBite(bite);
                
            }

            
        }

        #endregion

    }
}
