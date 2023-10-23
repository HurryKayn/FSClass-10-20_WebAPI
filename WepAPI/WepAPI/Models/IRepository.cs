namespace WepAPI.Models
{
    public interface IRepository
    {
        IEnumerable<GiocatoreBasketAmatoriale> GetAll();
        GiocatoreBasketAmatoriale GetById(int id);
        GiocatoreBasketAmatoriale Add(GiocatoreBasketAmatoriale giocatore);
        GiocatoreBasketAmatoriale Update(GiocatoreBasketAmatoriale giocatore);
        void Delete(int id);

    }
}
