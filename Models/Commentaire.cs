using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AppliAsp.NET.Models
{
    public class Commentaire
    {
        #region Attributs
        
        private int commentaireId;
        private string texte;
        private Projet projet;
        #endregion
        #region Properties
       
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CommentaireId
        {
            get { return commentaireId; }
            set { commentaireId = value; }
        }

        
        [MaxLength(200)]
        public string Texte
        {
            get { return texte; }
            set { texte = value; }
        }
       

        public virtual Projet Projet
        {
            get { return projet; }
            set { projet = value; }
        }
        #endregion

        #region Constructor
        public Commentaire()
        {

        }

        public Commentaire(int commentaireId, string texte, Projet projet)
        {
            this.commentaireId = commentaireId;
            this.texte = texte;
            this.projet = projet;
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