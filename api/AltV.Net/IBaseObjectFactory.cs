using System;
using AltV.Net.Elements.Entities;

namespace AltV.Net
{
    public interface IBaseObjectFactory<out TBaseObject> where TBaseObject : IBaseObject
    {
        TBaseObject Create(ICore core, IntPtr baseObjectPointer, uint id);
    }
}