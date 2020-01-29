using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filmy.Systems
{
    
    public abstract class SystemOfSth<T> : iSystem<T>
    {
        List<T> Data;
        public void DodajElement(T u) {
            Data.Add(u);
        }
        public void UsunElement(T u) {

            Data.Remove(u);
        }

    }

