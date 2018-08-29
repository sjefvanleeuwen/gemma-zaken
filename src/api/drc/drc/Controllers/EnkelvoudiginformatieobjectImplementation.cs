using System.Linq;
using drc.Models;
using App.Metrics;
using drc.Metrics;
using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace drc.Controllers
{
    public class EnkelvoudiginformatieobjectImplementation : IEnkelvoudiginformatieobjectController
    {
        private DataContext _db;
        public IMetrics Metrics;

        public EnkelvoudiginformatieobjectImplementation(DataContext context, IMetrics metrics) {
            _db = context;
            Metrics = metrics;
        }

        public EnkelvoudigInformatieObject Create(EnkelvoudigInformatieObject body)
        {
            using (Metrics.Measure.Timer.Time(DrcRegistry.EnkelvoudiginformatieobjectCreateAsync))
            {
                _db.Add(body);
                _db.SaveChanges();
                return body;
            }
        }

        public ObservableCollection<EnkelvoudigInformatieObject> List()
        {
            using (Metrics.Measure.Timer.Time(DrcRegistry.EnkelvoudiginformatieobjectListAsync))
            {
                return new ObservableCollection<EnkelvoudigInformatieObject>(from p in _db.EnkelvoudiginformatieObjecten select p);
            }
        }

        public EnkelvoudigInformatieObject Read(Guid uuid)
        {
            using (Metrics.Measure.Timer.Time(DrcRegistry.EnkelvoudiginformatieobjectReadAsync))
            {
                return (from p in _db.EnkelvoudiginformatieObjecten where (p.Identificatie == uuid.ToString()) select p ).SingleOrDefault();
            }
        }
    }
}