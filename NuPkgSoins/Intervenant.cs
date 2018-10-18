// <copyright file="Intervenant.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ClassesMetier
{
    using System.Collections.ObjectModel;

    public class Intervenant
    {
        private string nom;

        /// <summary>
        /// Gets instanciation de nom
        /// </summary>
        public string Nom
        {
            get { return this.nom; }
        }

        /// <summary>
        /// Gets declaration de prenom
        /// </summary>
        public string Prenom { get; }

        public Collection<Prestation> LesPrestations { get; set; }

        public Intervenant(string nom, string prenom)
        {
            this.nom = nom;
            this.Prenom = prenom;
            this.LesPrestations = new Collection<Prestation>();
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return "Intervenant : " + this.Nom + " - " + this.Prenom;
        }

        public virtual string AfficheIntervenantComplet()
        {
            return this.ToString() + this.SesInterventions();
        }

        protected string SesInterventions()
        {
            string chaine = string.Empty;
            foreach (Prestation unePrestation in this.LesPrestations)
            {
                chaine += "\n\t" + unePrestation;
            }

            return chaine;
        }

        ///////
        public void AjoutePrestation(Prestation prestation)
        {
            this.LesPrestations.Add(prestation);
        }
    }
}
