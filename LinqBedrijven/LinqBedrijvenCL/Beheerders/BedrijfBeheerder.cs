using LinqBedrijvenCL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqBedrijvenCL.Interfaces;

namespace LinqBedrijvenCL.Beheerders
{
    public class BedrijfBeheerder
    {
        private readonly IBedrijfRepository _repo;
        private readonly List<Bedrijf> _bedrijven;
        public void GetBedrijvenOpNaam() => _bedrijven.OrderBy(b => b.Naam);
        public void GetBedrijvenOpOprichtjaarDesc() => _bedrijven.OrderByDescending(b => b.Oprichtjaar).Select(b => (b.Naam, b.Oprichtjaar));
        public void GetTop10BedrijvenOpAantalWerknemers() => _bedrijven.OrderByDescending(b => b.Werknemers.Count).Select(b => (b.Naam, b.Werknemers.Count)).Take(10);
        public void GetAantalMedewerkersPerGemeente() => _bedrijven.SelectMany(b => b.Werknemers).GroupBy(m => m.Woonplaats).Select(g => (g.Key, g.Count()));
        public void GetMedewerkersOpGemeente(string gemeente) => _bedrijven.SelectMany(b => b.Werknemers).Where(m => m.Woonplaats == gemeente).Select(g => (g.Voornaam, g.Woonplaats));
        public void GetBedrijvenPerSector() => _bedrijven.GroupBy(b => b.Sector).Select(s => (s.Key, s.Count()));
        public void GetBedrijvenPerIndustrie() => _bedrijven.GroupBy(b => b.Industrie).Select(i => (i.Key, i.Select(b => b.Naam)));
        //private readonly IBedrijfRepository _repository;
        //private readonly List<Bedrijf> _bedrijven;

        //public BedrijfBeheerder(IBedrijfRepository repository, string pad)
        //{
        //    _repository = repository;
        //    _bedrijven = repository.LeesBedrijven(pad);
        //}

        //public IEnumerable<Bedrijf> GetAlleBedrijven() =>
        //    _bedrijven.OrderBy(b => b.Naam);

        //public IEnumerable<(string Naam, int Jaar)> GetBedrijvenOpOprichtingsjaar() =>
        //    _bedrijven.OrderBy(b => b.JaarOpricht)
        //              .Select(b => (b.Naam, b.JaarOpricht));

        //public IEnumerable<(string Naam, int Werknemers)> GetTop10Grootste() =>
        //    _bedrijven.OrderByDescending(b => b.AantalWerknemers)
        //              .Take(10)
        //              .Select(b => (b.Naam, b.AantalWerknemers));

        //public IEnumerable<(string Gemeente, int Aantal)> GetWerknemersPerGemeente() =>
        //    _bedrijven.SelectMany(b => b.Werknemers)
        //              .GroupBy(w => w.Woonplaats)
        //              .Select(g => (g.Key, g.Count()));

        //public IEnumerable<Werknemer> GetWerknemersInGemeente(string gemeente) =>
        //    _bedrijven.SelectMany(b => b.Werknemers)
        //              .Where(w => w.Woonplaats.Equals(gemeente, StringComparison.OrdinalIgnoreCase));

        //public IEnumerable<(string Sector, int Bedrijven)> GetAantalBedrijvenPerSector() =>
        //    _bedrijven.GroupBy(b => b.Sector)
        //              .Select(g => (g.Key, g.Count()));

        //public IEnumerable<(string Industrie, List<string> Bedrijven)> GetBedrijvenPerIndustrie() =>
        //    _bedrijven.GroupBy(b => b.Industrie)
        //              .Select(g => (g.Key, g.Select(b => b.Naam).ToList()));

        //public IEnumerable<Werknemer> GetWerknemersMetZelfdeNaam() =>
        //    _bedrijven.SelectMany(b => b.Werknemers)
        //              .GroupBy(w => (w.Voornaam, w.Achternaam))
        //              .Where(g => g.Count() > 1)
        //              .SelectMany(g => g);

        //public (int Jonger25, int Tussen25en50, int Ouder50) GetLeeftijdsverdeling()
        //{
        //    var werknemers = _bedrijven.SelectMany(b => b.Werknemers);
        //    int jong = werknemers.Count(w => w.Leeftijd < 25);
        //    int midden = werknemers.Count(w => w.Leeftijd >= 25 && w.Leeftijd <= 50);
        //    int oud = werknemers.Count(w => w.Leeftijd > 50);
        //    return (jong, midden, oud);
        //}
    }
}
