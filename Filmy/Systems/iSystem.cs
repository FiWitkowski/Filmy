using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Filmy.User;

namespace Filmy.Systems
{
    public interface iSystem<T>
    {
        
        void DodajElement(T u);
        void UsunElement(T u); 

    }
}
