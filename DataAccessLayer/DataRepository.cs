using DataAccessLayer.DataContext;
using DataAccessLayer.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccessLayer
{
    public class DataRepository
    {
        public IList<Klant> GetKlanten()
        {
            using(var context = new BakkerijDataContext())
            {
                return context.Klanten.ToList();
            }
        }

        public Klant GetKlantById(int id)
        {
            using (var context = new BakkerijDataContext())
            {
                return context.Klanten.SingleOrDefault(t => t.Id.Equals(id));
            }
        }

        public int InsertKlant(Klant klant)
        {
            if (klant == null)
                throw new ArgumentNullException("Klant mag niet leeg zijn.");

            using (var context = new BakkerijDataContext())
            {
                context.Klanten.Add(klant);
                return context.SaveChanges();
            }
        }

        public void UpdateKlant(Klant klant)
        {
            using (var context = new BakkerijDataContext())
            {
                context.Update<Klant>(klant);
                context.SaveChanges();
            }
        }

        public void DeleteKlant(int id)
        {
            using (var context = new BakkerijDataContext())
            {
                var klant = context.Klanten.Single(k => k.Id == id);
                context.Remove(klant);
                context.SaveChanges();
            }
        }

        public IList<Medewerker> GetMedewerkers()
        {
            using (var context = new BakkerijDataContext())
            {
                return context.Medewerkers.ToList();
            }
        }

        public Medewerker GetMedewerkerById(int id)
        {
            using (var context = new BakkerijDataContext())
            {
                return context.Medewerkers.SingleOrDefault(t => t.Id.Equals(id));
            }
        }

        public int InsertMedewerker(Medewerker medewerker)
        {
            if (medewerker == null)
                throw new ArgumentNullException("Medewerker mag niet leeg zijn.");

            using (var context = new BakkerijDataContext())
            {
                context.Medewerkers.Add(medewerker);
                return context.SaveChanges();
            }
        }

        public void UpdateMedewerker(Medewerker medewerker)
        {
            using (var context = new BakkerijDataContext())
            {
                context.Update<Medewerker>(medewerker);
                context.SaveChanges();
            }
        }

        public IList<Product> GetProducten()
        {
            using (var context = new BakkerijDataContext())
            {
                return context.Producten.ToList();
            }
        }

        public Product GetProductById(int id)
        {
            using (var context = new BakkerijDataContext())
            {
                return context.Producten.SingleOrDefault(t => t.Id.Equals(id));
            }
        }

        public int InsertProduct(Product product)
        {
            if (product == null)
                throw new ArgumentNullException("Product mag niet leeg zijn.");

            using (var context = new BakkerijDataContext())
            {
                context.Producten.Add(product);
                return context.SaveChanges();
            }
        }

        public void UpdateProduct(Product product)
        {
            using (var context = new BakkerijDataContext())
            {
                context.Update<Product>(product);
                context.SaveChanges();
            }
        }

        public void DeleteProduct(int id)
        {
            using (var context = new BakkerijDataContext())
            {
                var product = context.Producten.Single(k => k.Id == id);
                context.Remove(product);
                context.SaveChanges();
            }
        }
    }
}
