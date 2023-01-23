using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace user_panel
{
    public class zone
    {
        private int id;
        private string nom;
        private appartement appartement;

        public zone(int id, string nom, appartement appartement)
        {
            this.id = id;
            this.nom = nom;
            this.appartement= appartement;
        }
        public int getId()
        {
            return id;
        }
        public string getNom()
        {
                return nom;
        }
        public appartement GetAppartement()
        {
            return appartement;
        }

        public void  setId(int id)
        {
            this.id = id;
        }
        public void setNom(string nom)
        {
                this.nom = nom;
        }
        public void setAppartement(appartement appartement)
        {
            this.appartement=appartement;
        }
    }   
}
