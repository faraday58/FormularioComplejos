﻿using System;

namespace FormularioComplejos
{
    internal class Complejo
    {
        private float real;
        private float imaginaria;

        public Complejo(float real, float imaginaria)
        {
            this.real = real;
            this.imaginaria = imaginaria;
        }


        public static Complejo operator +(Complejo c1,Complejo c2  )
        {
            return new Complejo(c1.real + c2.real, c1.imaginaria + c2.imaginaria);
        }

        public override string ToString()
        {
            if ( imaginaria < 0  )
            {
                return this.real.ToString() + this.imaginaria.ToString(); 
            }
            else
            {
                return this.real.ToString() + " + " + this.imaginaria.ToString() + "j";
            }
            
        }

    }
}
