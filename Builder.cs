using System;
using System.Collections.Generic;
using System.Text;

namespace BuildDesignPattern
{
    public abstract class Builder

    {
        public abstract void BuildPartA();
        public abstract void BuildPartB();
        public abstract Product GetResult();
    }
}
