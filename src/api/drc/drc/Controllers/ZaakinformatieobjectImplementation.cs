using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using App.Metrics;
using drc.Models;
using System.Linq;
using drc.Metrics;

namespace drc.Controllers
{
    public class ZaakinformatieobjectImplementation : IZaakinformatieobjectController
    {
        public IMetrics Metrics { get;set; }
        private DataContext _db;

        public ZaakinformatieobjectImplementation(DataContext context, IMetrics metrics)
        {
            Metrics = metrics;
            _db = context;
        }

        public ZaakInformatieObject Create(ZaakInformatieObject body)
        {
            using (Metrics.Measure.Timer.Time(DrcRegistry.ZaakInformatieObjectCreateAsync))
            {
                _db.Add(body);
                _db.SaveChangesAsync();
                return body;
            }
        }

        public ObservableCollection<ZaakInformatieObject> List(string zaak, string informatieobject)
        {
            using (Metrics.Measure.Timer.Time(DrcRegistry.ZaakInformatieObjectListAsync))
            {
                return new ObservableCollection<ZaakInformatieObject>(from p in _db.ZaakInformatieObjecten where (p.Url == zaak && p.Informatieobject == informatieobject) select p);
            }
        }

        public ZaakInformatieObject Read(Guid uuid)
        {
            using (Metrics.Measure.Timer.Time(DrcRegistry.ZaakInformatieObjectReadAsync))
            {
                var informatieObject = (from p in _db.EnkelvoudiginformatieObjecten where (p.Identificatie == uuid.ToString()) select p).Single();
                return (from p in _db.ZaakInformatieObjecten where (p.Informatieobject == informatieObject.Url) select p ).SingleOrDefault();
            }
        }
    }
}