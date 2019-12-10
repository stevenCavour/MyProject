using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AppliAsp.NET.Models
{
    public class Employe
    {
        #region Attributs
        private int employeId;
        private string nom;
        private string prenom;
        private ICollection<Projet> projets;
        #endregion

        #region Properties

       
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmployeiD
        {
            get { return employeId; }
            set { employeId = value; }
        }
      
        [Required]
        public string  Nom
        {
            get { return nom; }
            set { nom = value; }
        }
       
        [Required]
        [DisplayName("Prénom")]
        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }


        

        public virtual ICollection<Projet> Projets
        {
            get { return projets; }
            set { projets = value; }
        }
        #endregion

        #region Constructor
        public Employe()
        {

        }

        public Employe(int employeId, string nom, string prenom,
            ICollection<Projet> projets)
        {
            this.employeId = employeId;
            this.nom = nom;
            this.prenom = prenom;
            this.projets = projets;
        }

        #endregion

        #region Functions
        public override string ToString()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        #endregion
    }
}