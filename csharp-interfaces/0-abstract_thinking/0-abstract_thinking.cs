﻿using System;

public abstract class Base
{
    public string name = null;

    public override string ToString()
    {
        return name + " is a " + this.GetType();
    }

}