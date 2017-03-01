namespace Collectively.Messages.Events.Remarks.Models
{
    public class RemarkLocation
    {
        public string Address { get; }
        public double Latitude { get; }
        public double Longitude { get; }

        protected RemarkLocation()
        {
        }

        public RemarkLocation(string address, double latitude, double longitude)
        {
            Address = address;
            Latitude = latitude;
            Longitude = longitude;
        }
    }
}