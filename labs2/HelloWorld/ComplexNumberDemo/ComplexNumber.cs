using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexNumberDemo
{
    internal class ComplexNumber
    {

        int real, imaginary;
        public ComplexNumber(int real,int imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
        }

        public static ComplexNumber operator +(ComplexNumber cn1 , ComplexNumber cn2)
        {
        ComplexNumber cn3=new ComplexNumber(cn1.real+cn2.real,cn1.imaginary+cn2.imaginary);
            return cn3;
        }
        public override string ToString()
        {
            return $"{real}+{imaginary}i";
        }

    }
}
