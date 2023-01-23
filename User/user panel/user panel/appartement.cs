using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace user_panel
{
    public class appartement
    {
        private int id;
        private string adress;

        public appartement(int id, string adress)
        {
            this.id = id;
            this.adress = adress;
        }
        public int getId()
        {
            return id;
        }
        public string getAdress()
        {
                return adress;
        }
        public void setAdress(string adress)
        {
            this.adress = adress;

        }
        public void setId(int id )
        {
            this.id = id;

        }

    }
}
