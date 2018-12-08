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
        public Language Add(Language langue)
        {
            try
            {
                bdc.Languages.Add(langue);
                bdc.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
            return langue;
        }
    }
}
