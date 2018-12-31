using Serveur_Cinema.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Serveur_Cinema
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "ILanguageService" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface ILanguageService
    {
        [OperationContract]
        Language Addlangage(Language Langue);
        [OperationContract]
        Actor Addactor(Actor Act);
        [OperationContract]
        Store Addstore(Store str);
        [OperationContract]
        Address Addadresse(Address ad);
        [OperationContract]
        List<Store> Listestore();
        [OperationContract]
        Film Addfilm(Film fl);
        [OperationContract]
        List<Film> Filmparstore(int id);
        [OperationContract]
        Payement Addpayement(Payement paye);
        [OperationContract]
        void Modifyfilm(Film F);
        [OperationContract]
        void Modifyaddress(Address a);
        [OperationContract]
        Category Addcategorie(Category cat);
        [OperationContract]
        void Modifycategorie(Category c);
        List<Payement> Listepayement();
        [OperationContract]
        Staff Addstaff(Staff s);

    }
}
