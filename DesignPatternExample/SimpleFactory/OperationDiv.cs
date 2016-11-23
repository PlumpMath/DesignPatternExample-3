﻿using System;

namespace DesignPatternExample.SimpleFactory
{
    public class OperationDiv : Operation
    {
        public override double GetResult()
        {
            if (NumberB == 0) throw new Exception("除数不能为0。");

            return NumberA / NumberB;
        }
    }
}
