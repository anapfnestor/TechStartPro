using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductManager
{
    public class MDISingleton
    {
        private MDISingleton() { }

        private static mdiProductManager instanceMDIPrincipal;

        public static mdiProductManager instanciaMDI()
        {
            if (instanceMDIPrincipal == null)
            {
                instanceMDIPrincipal = new mdiProductManager();
                return instanceMDIPrincipal;
            }
            return instanceMDIPrincipal;
        }

        
    }
}
