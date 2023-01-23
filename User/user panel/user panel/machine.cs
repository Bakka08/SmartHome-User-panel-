using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace user_panel
{
    public class machine
    {
        private int id;
        private string nom;
        private int  status;
        private zone z;


        public machine(int id, string nom, int status,zone z)
        {
            this.id = id;
            this.nom = nom;
            this.status = status;
            this.z = z;

        }
        public int getId() { return id; }   
        public string getNom() { return nom; }
        public int getStatus() { return status; }

        public zone  GetZone() { return z; }

        public void setId(int id) { this.id = id;}
        public void setNom(string nom)
        {
            this.nom = nom;
        }
        public void setStatus(int status)
        {
            this.status = status;
        }
        public void setZ(zone z)
        {
            this.z = z;
        }
    }
}
