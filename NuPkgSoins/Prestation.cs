// <copyright file="Prestation.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ClassesMetier
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Prestation
    {
        private string libelle;

        /// <summary>
        /// Gets property du libelle de la prestation
        /// (lecture seule)
        /// </summary>
        public string Libelle
        {
            get { return this.libelle; }
        }

        /// <summary>
        /// Gets property de la date des soins
        /// (lecture seule)
        /// </summary>
        public DateTime DateHeureSoin { get; }

        public string HeureSoin()
        {
            return this.DateHeureSoin.Hour + "h" + this.DateHeureSoin.Minute + " - " + this.DateHeureSoin.ToShortTimeString();
        }

        /// <summary>
        /// Gets property de l'objet intervenant ayant réalisé la prestation
        /// (lecture seule)
        /// </summary>
        public Intervenant UnIntervenant { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Prestation"/> class.
        /// Constructeur
        /// </summary>
        /// <param name="libelle">objet de la classe</param>
        /// <param name="uneDateHeure">dans le construc</param>
        /// <param name="unIntervenant">instantation</param>
        public Prestation(string libelle, DateTime uneDateHeure, Intervenant unIntervenant)
        {
            this.libelle = libelle;
            this.DateHeureSoin = uneDateHeure;
            this.UnIntervenant = unIntervenant;
        }

        /// <summary>
        /// fonction qui compare 2 dates au format DateHeure
        /// Attention ici, on ne compare que les dates.
        /// 2 dates seront égales si leur JJ/MM/AAAA  sont égaux, quelle que soit l'heure
        /// </summary>
        /// <param name="unePrestation">Prestation qu'a recu un client</param>
        /// <returns>
        ///     0 les dates sont égales
        ///     1 si la date de la prestation courante est postérieure à la date de la prestation unePrestation
        ///     -1 si la date de la prestation courante est antérieure à la date de la prestation unePrestation
        ///
        /// </returns>
        public int CompareTo(Prestation unePrestation)
        {
            // if(this.DateHeureSoin.Date > unePrestation.DateHeureSoin.Date) {
            //    return 1;
            // }
            // else
            // {
            //    if (this.DateHeureSoin.Date == unePrestation.DateHeureSoin.Date)
            //    {
            //        return 0;
            //    }
            //    else
            //    {
            //        return -1;
            //    }
            // }
            // bien mieux
            return this.DateHeureSoin.Date.CompareTo(unePrestation.DateHeureSoin.Date);
        }

        /// <summary>
        /// Effectue la somme de 2 nombres.
        /// </summary>
        /// <param name="a">entier1 à additionner</param>
        /// <param name="b">entier2 à additionner</param>
        /// <returns>entier égal à la somme des deux entiers passés en paramètre</returns>
        public int SommePourRien(int a, int b)
        {
            return a + b;
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return this.libelle + " - " + this.DateHeureSoin.ToString();
        }
    }
}
