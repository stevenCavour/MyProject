using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AppliAsp.NET.Models
{
    public class Projet
    {
        #region Attributs
        private int projetId;
        private string intitule;
        private DateTime dateDebut;
        private DateTime dateLivraison;
        private int nombrejour;
        private string description;
        private ICollection<Employe> employes;
        private ICollection<Commentaire> commentaires;
        #endregion

        #region Properties

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProjetId
        {
            get { return projetId; }
            set { projetId = value; }
        }
        
        [Required]
        [DisplayName("Intitule")]
        [RegularExpression(@"^[A-Z]{2}\d{5}$")]
        public  string Intitule
        { 
            get { return intitule; }
            set { intitule= value; }
        }
        
        [DataType(DataType.Date)]
        [DisplayName("Date de début")]
        [DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}",ApplyFormatInEditMode =true)]
        public DateTime DateDebut
        {
            get { return dateDebut; }
            set { dateDebut = value; }
        }

        

        public DateTime DateLivraison
        {
            get { return dateLivraison; }
            set { dateLivraison = value; }
        }

      

        public int NombreJour
        {
            get { return nombrejour; }
            set { nombrejour = value; }
        }

        
        [Required]
        [MaxLength(200)]
        public  string Description
        {
            get { return description; }
            set { description = value; }
        }
        



        public virtual ICollection<Employe> Employes
        {
            get { return employes ; }
            set { employes = value; }
        }
        

        public virtual ICollection<Commentaire> Commentaires

        {
            get { return commentaires; }
            set { commentaires = value; }
        }

        

       

        #endregion
        #region Constructor
        public Projet()
        {

        }

        public Projet(int projetId, string intitule, DateTime dateDebut, DateTime dateLivraison,
            int nombrejour,string description, ICollection<Employe> employes, ICollection<Commentaire> commentaires)
        {
            this.projetId = projetId;
            this.intitule = intitule;
            this.dateDebut = dateDebut;
            this.dateLivraison = dateLivraison;
            this.nombrejour = nombrejour;
            this.description = description;
            this.employes = employes;
            this.commentaires = commentaires;
        }


        #endregion
        #region Function
        public override string ToString()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
        #endregion
    }
}