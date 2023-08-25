using RacerWebApi.Model;

namespace RacerWebApi.Repository
{
    public interface IRacerRepository
    {
        List<Racer> GetRacers();
        RacerRpositrory GetRacer(int  id);
        Racer AddRacer(Racer racer);
        Racer Update(Racer racer);

        bool DeleteRacer(Racer racer);
    }
}
