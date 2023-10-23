using Microsoft.AspNetCore.DataProtection.KeyManagement;

namespace WepAPI.Models
{
    public class Repository : IRepository
    {
        Dictionary<int, GiocatoreBasketAmatoriale> elencoGiocatori;

        public Repository()
        {
            int i = 0;
            elencoGiocatori = new Dictionary<int, GiocatoreBasketAmatoriale>();
            {
                i++;
                var g = new GiocatoreBasketAmatoriale
                {
                    GiocatoreId = i,
                    Nome = "Anna Barbieri",
                    Eta = 19,
                    Altezza = 1.85m
                };
                elencoGiocatori.Add(i, g);
            }            
            {
                i++;
                var g = new GiocatoreBasketAmatoriale
                {
                    GiocatoreId = i,
                    Nome = "Luca Barbieri",
                    Eta = 21,
                    Altezza = 1.93m
                };
                elencoGiocatori.Add(i, g);
            }
            {
                i++;
                var g = new GiocatoreBasketAmatoriale
                {
                    GiocatoreId = i,
                    Nome = "Antonio Sarti",
                    Eta = 21,
                    Altezza = 1.88m
                };
                elencoGiocatori.Add(i, g);
            }
            {
                i++;
                var g = new GiocatoreBasketAmatoriale
                {
                    GiocatoreId = i,
                    Nome = "Alessia Sciolla",
                    Eta = 23,
                    Altezza = 1.80m
                };
                elencoGiocatori.Add(i, g);
            }

            {
                i++;
                var g = new GiocatoreBasketAmatoriale
                {
                    GiocatoreId = i,
                    Nome = "Lucia Alba",
                    Eta = 17,
                    Altezza = 1.82m
                };
                elencoGiocatori.Add(i, g);
            }

            {
                i++;
                var g = new GiocatoreBasketAmatoriale
                {
                    GiocatoreId = i,
                    Nome = "Luca Rossi",
                    Eta = 18,
                    Altezza = 1.97m
                };
                elencoGiocatori.Add(i, g);
            }

        }

        public GiocatoreBasketAmatoriale Add(GiocatoreBasketAmatoriale giocatore)
        {
            int key = 1;
            while (elencoGiocatori.ContainsKey(key)) { key++; }
            elencoGiocatori.Add(key, giocatore);
            giocatore.GiocatoreId = key;
            return giocatore;
        }

        public void Delete(int id)
        {
            if (elencoGiocatori.ContainsKey(id))
            {
                elencoGiocatori.Remove(id);
            }
        }

        public IEnumerable<GiocatoreBasketAmatoriale> GetAll()
        {
            return elencoGiocatori.Values;
        }

        public GiocatoreBasketAmatoriale GetById(int id)
        {
            if (elencoGiocatori.ContainsKey(id))
            {
                return elencoGiocatori[id];
            }
            return null;
        }

        public GiocatoreBasketAmatoriale Update(GiocatoreBasketAmatoriale giocatore)
        {
            if (elencoGiocatori.ContainsKey(giocatore.GiocatoreId))
            {
                elencoGiocatori[giocatore.GiocatoreId] = giocatore;
                return giocatore;
            }
            return null;
        }
    }
}
