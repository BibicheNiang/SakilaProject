using Serveur_Cinema.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Serveur_Cinema
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "LanguageService" à la fois dans le code et le fichier de configuration.
    public class LanguageService : ILanguageService
    {
        BDContext bdc = new BDContext();
        public Language Addlangage(Language langue)
        {
            try
            {
                bdc.Languages.Add(langue);
                bdc.SaveChanges();
                return langue;
            }
            catch (Exception)
            {

                throw;
                return null;
            }
            
        }
        public Actor Addactor(Actor Act)
        {
            try
            {
                bdc.Actors.Add(Act);
                bdc.SaveChanges();
                return Act;
            }
            catch (Exception)
            {
                throw;
                return null;
            }
            

        }

        public Store Addstore(Store str)
        {
            try
            {
                bdc.Stores.Add(str);
                bdc.SaveChanges();
                return str;
            }
            catch (Exception)
            {
                throw;
                return null;
            }

        }
        public Address Addadresse(Address ad)
        {
            try
            {
                bdc.Addresses.Add(ad);
                bdc.SaveChanges();
                return ad;

            }
            catch (Exception)
            {
                throw;
                return null;

            }
            
        }
        public List<Store> Listestore()
        {
            try
            {
                return bdc.Stores.ToList();
            }
            catch
            {
                return null;
            }


        }

    }
}
