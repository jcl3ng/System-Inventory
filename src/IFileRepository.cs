using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Software
{  
    // Interface for saving and loading a generic object to FileRepository.
    interface IFileRepository<T>
    {
        List<T> load();
        void save(List<T> objs);
    }
}
