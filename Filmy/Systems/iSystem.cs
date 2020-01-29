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
        bool UsunElement(T u);

        void Serialize(string path);
        object Deserialize(string path);


    }
}
