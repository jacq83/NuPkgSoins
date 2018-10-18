// <copyright file="IntervenantExterne.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ClassesMetier
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class IntervenantExterne : Intervenant
    {
        private readonly string specialite;

        public string Specialite
        {
            get { return this.specialite; }
        }

        public string Adresse { get; }

        public string Tel { get; }

        ////////////////////////////////

        public IntervenantExterne(string nom, string prenom, string specialite, string adresse, string tel)
            : base(nom, prenom)
        {
            this.specialite = specialite;
            this.Adresse = adresse;
            this.Tel = tel;
        }

        public new string AfficheIntervenantComplet()
        {
            return this.ToString() + this.SesInterventions();
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return base.ToString() + " Spécialité : " + this.Specialite + "\n\t\t  " + this.Adresse + " - " + this.Tel;
        }
    }
}
