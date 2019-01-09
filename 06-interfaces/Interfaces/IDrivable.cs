using System;
using System.Collections.Generic;
using System.Text;

namespace _06_interfaces.Interfaces
{
    public interface IDrivable
    {
        // Vinicio - no access modifiers here in the interface
        void Start();

        void Stop();

        void ChangeOrientation(float angle);
    }
}