using System;
using System.Collections.Generic;
using System.Text;

namespace BuildDesignPattern
{
    class Director
    {
        public void Construct(Builder builder)
        {
            builder.BuildPartA();
            builder.BuildPartB();
        }
    }
}
