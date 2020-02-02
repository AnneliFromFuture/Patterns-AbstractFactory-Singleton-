namespace Abstract_factory.Interfaces
{
    public interface IDetectorsFactory
    {
        ISensor CreateSensor();

        IPlace CreatePlace();

        ISignal CreateSignal();
    }
}
