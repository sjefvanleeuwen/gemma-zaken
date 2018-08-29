using App.Metrics;
using App.Metrics.ReservoirSampling.ExponentialDecay;
using App.Metrics.Timer;

namespace drc.Metrics
{
    public class DrcRegistry
    {
        public static TimerOptions ZaakInformatieObjectReadAsync => new TimerOptions
        {
            Name = "ZaakInformatieObject ReadAsync",
            MeasurementUnit = Unit.Items,
            DurationUnit = TimeUnit.Milliseconds,
            RateUnit = TimeUnit.Milliseconds,
            Reservoir = () => new DefaultForwardDecayingReservoir(sampleSize: 1028, alpha: 0.015)
        };

        public static TimerOptions ZaakInformatieObjectListAsync => new TimerOptions
        {
            Name = "ZaakInformatieObject ListAsync",
            MeasurementUnit = Unit.Items,
            DurationUnit = TimeUnit.Milliseconds,
            RateUnit = TimeUnit.Milliseconds,
            Reservoir = () => new DefaultForwardDecayingReservoir(sampleSize: 1028, alpha: 0.015)
        };

        public static TimerOptions ZaakInformatieObjectCreateAsync => new TimerOptions
        {
            Name = "ZaakInformatieObject CreateAsync",
            MeasurementUnit = Unit.Items,
            DurationUnit = TimeUnit.Milliseconds,
            RateUnit = TimeUnit.Milliseconds,
            Reservoir = () => new DefaultForwardDecayingReservoir(sampleSize: 1028, alpha: 0.015)
        };

        public static TimerOptions EnkelvoudiginformatieobjectReadAsync => new TimerOptions
        {
            Name = "Enkelvoudiginformatieobject ReadAsync",
            MeasurementUnit = Unit.Items,
            DurationUnit = TimeUnit.Milliseconds,
            RateUnit = TimeUnit.Milliseconds,
            Reservoir = () => new DefaultForwardDecayingReservoir(sampleSize: 1028, alpha: 0.015)
        };

        public static TimerOptions EnkelvoudiginformatieobjectListAsync => new TimerOptions
        {
            Name = "Enkelvoudiginformatieobject ListAsync",
            MeasurementUnit = Unit.Items,
            DurationUnit = TimeUnit.Milliseconds,
            RateUnit = TimeUnit.Milliseconds,
            Reservoir = () => new DefaultForwardDecayingReservoir(sampleSize: 1028, alpha: 0.015)
        };

        public static TimerOptions EnkelvoudiginformatieobjectCreateAsync => new TimerOptions
        {
            Name = "Enkelvoudiginformatieobject CreateAsync",
            MeasurementUnit = Unit.Items,
            DurationUnit = TimeUnit.Milliseconds,
            RateUnit = TimeUnit.Milliseconds,
            Reservoir = () => new DefaultForwardDecayingReservoir(sampleSize: 1028, alpha: 0.015)
        };
    }
}