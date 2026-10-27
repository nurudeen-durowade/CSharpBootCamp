using System;
using System.Collections.Generic;

namespace MiniBankingPractice.Models;

public class DataContainer<T>
{
    public T Value { get; set; }

    public DataContainer(T value)
    {
        Value = value;
    }
}