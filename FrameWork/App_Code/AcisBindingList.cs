using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

public class AcisBindingList<T> : BindingList<T>
{
    protected override void RemoveItem(int index)
    {
        base.RemoveItem(index);
    }

    public AcisBindingList()
    {

    }

    public AcisBindingList(IList <T> List)
    {
        foreach (var item in List)
        {
            this.Add(item);
        }
    }
}