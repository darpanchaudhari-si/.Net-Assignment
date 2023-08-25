using RacerWebApi.Model;
namespace RacerWebApi.Repository
{
    public class RacerRpositrory :IRacerRepository
    {


        public List<Racer> racerList = new List<Racer>()
        {
            new Racer(){Id = 11,FirstName = "Niki", LastName = "Lauda",Country = "Austria", Wins = 15 },
            new Racer(){Id=12,FirstName="Joe",LastName="Hyden",Country="USA",Wins=30 },
            new Racer(){Id=13,FirstName="Zaroon",LastName="Stylus",Country="France",Wins=10 },
            new Racer(){Id=14,FirstName="Henry",LastName="Brad",Country="USA",Wins=40 },
            new Racer(){Id=15,FirstName="Nikil",LastName="patil",Country="USA",Wins=50 },
            new Racer(){Id=15,FirstName="Nikil",LastName="Hyden",Country="France",Wins=10 },

        };
    }
    public List<Racer> GetRacers()
    {
        return racerList;
    }
    // Get single racer ,search by Id
    public Racer GetRacer(int id)
    {
        return racerList.SingleOrDefault(ref=> ref.Id == id);
    } 
    public Racer updateracer( Racer racer)
    {
        throw new NotImplementedException();
    }
    public Racer AddRacer( Racer racer)
    {
        if (racer!=null)
        racerList.Add(racer);
        return racer;
    }
}
