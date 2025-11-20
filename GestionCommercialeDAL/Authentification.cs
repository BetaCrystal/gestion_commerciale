<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using GestionCommercialeBO;
=======
﻿using GestionCommercialeBO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
>>>>>>> f8d224008bb874cc497a689787bf50114e583130

/*
 * Cette classe permet de gérer l'authentification des utilisateurs en vérifiant leurs identifiants et mots de passe.
 * Elle gère les requêtes SQL de l'authentification d'un utilisateur.
 */

namespace GestionCommercialeDAL
{
    public class Authentification
    {
        //Trouve l'utilisateur dans la base de données. Renvoie true si trouvé, false sinon.
        public bool FindUser(Utilisateur utilisateur)
        {
            string identifiant = utilisateur.GetIdentifiant();
            string mdp = utilisateur.GetMdp();
            bool userFound = false;

            //Vérifie si les champs sont vides
            /*if (string.IsNullOrEmpty(identifiant) || string.IsNullOrEmpty(mdp))
            {
                throw new ArgumentException("Identifiant ou mot de passe vide.");
            }*/
            //if //Connexion à la base de données pour récupérer l'utilisateur
            //{
<<<<<<< HEAD
                SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = maConnexion;
                cmd.CommandText = "SELECT * FROM Authentification WHERE nom_utilisateur = @identifiant AND mot_de_passe_utilisateur = @mdp";
                cmd.Parameters.AddWithValue("@identifiant", identifiant);
                cmd.Parameters.AddWithValue("@mdp", mdp);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read()) //Lit les données récupérées depuis la requête SQL
                {
                    userFound = true; //Renvoie true s'il y a des données (donc si l'utilisateur existe)
                }
                else
                {
                    userFound = false; //Renvoie false s'il n'y a aucune donnée.
                }
                reader.Close();
                ConnexionBD.GetConnexionBD().CloseConnexion();
=======
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = "SELECT * FROM Authentification WHERE nom_utilisateur = @identifiant AND mot_de_passe_utilisateur = @mdp";
            cmd.Parameters.AddWithValue("@identifiant", identifiant);
            cmd.Parameters.AddWithValue("@mdp", mdp);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read()) //Lit les données récupérées depuis la requête SQL
            {
                userFound = true; //Renvoie true s'il y a des données (donc si l'utilisateur existe)
            }
            else
            {
                userFound = false; //Renvoie false s'il n'y a aucune donnée.
            }
            reader.Close();
            ConnexionBD.GetConnexionBD().CloseConnexion();
>>>>>>> f8d224008bb874cc497a689787bf50114e583130
            //}
            return userFound;
        }
    }
}
