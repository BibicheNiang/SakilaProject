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
        Film Addfilm(Film fl);
        [OperationContract]
        Staff AddStaff(Staff staf);
        [OperationContract]
        Customer AddCustomer(Customer customer);

        [OperationContract]
        List<Store> Listestore();
       

    }
}
