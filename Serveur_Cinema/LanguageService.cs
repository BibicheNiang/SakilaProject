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
            }


        }
        public Film Addfilm(Film fl)
        {
            try
            {
                bdc.Films.Add(fl);
                bdc.SaveChanges();
                return fl;
            }
            catch (Exception)
            {

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

        public List<Film> Filmparstore(int id)
        {
            try
            {
                return (from f in bdc.Films
                        join i in bdc.Inventories on f.FilmId equals i.FilmId
                        join s in bdc.Stores on i.StoreId equals s.StoreId
                        where s.StoreId == id
                        select f).ToList();

            }
            catch
            {
                return null;
            }
        }
        public Payement Addpayement(Payement paye)
        {
            try
            {
                bdc.Payements.Add(paye);
                bdc.SaveChanges();
                return paye;
            }
            catch (Exception)
            {

                return null;
            }


        }
        public void Modifyfilm(Film F)
        {
            Film fe = (from p in bdc.Films where p.FilmId == F.FilmId select p).FirstOrDefault();
            if (fe != null)
            {
                fe.Title = F.Title;
                fe.Description = F.Description;
                fe.Release_Year = F.Release_Year;
                fe.Rental_Duration = F.Rental_Duration;
                fe.Rental_Rate = F.Rental_Rate;
                fe.Length = F.Length;
                fe.Replacement_Cost = F.Replacement_Cost;
                fe.Rating = F.Rating;
                fe.Special_Features = F.Special_Features;
                fe.Last_Update = F.Last_Update;
                bdc.SaveChanges();
            }



        }
        public void Modifyaddress(Address a)
        {
            Address A = (from ad in bdc.Addresses where ad.AddressId == a.AddressId select ad).FirstOrDefault();
            if (A != null)
            {
                A.Adresse_Name1 = a.Adresse_Name1;
                A.Adresse_Name2 = a.Adresse_Name2;
                A.District = a.District;
                A.Postal_Code = a.Postal_Code;
                A.Phone = a.Phone;
                A.Last_Update = a.Last_Update;
                bdc.SaveChanges();
            }
        }
        public Category Addcategorie(Category cat)
        {
            try
            {
                bdc.Categories.Add(cat);
                bdc.SaveChanges();
                return cat;
            }
            catch (Exception)
            {

                return null;
            }
        }
        public void Modifycategorie(Category c)
        {
            Category ct = (from cat in bdc.Categories where cat.CategoryId == c.CategoryId select cat).FirstOrDefault();
            if (ct != null)
            {
                ct.Category_Name = c.Category_Name;
                ct.Last_Update = c.Last_Update;
                bdc.SaveChanges();
            }
        }
        public List<Payement> Listepayement()
        {
            try
            {
                return bdc.Payements.ToList();
            }
            catch
            {
                return null;
            }


        }

        public Staff Addstaff(Staff s)
        {
            try
            {
                bdc.Staffs.Add(s);
                bdc.SaveChanges();
                return s;
            }
            catch (Exception)
            {

                return null;
            }


        }

    }
}
