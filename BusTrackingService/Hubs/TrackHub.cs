namespace BusTrackingService.Hubs;

public class TrackHub : Hub
{
    public async Task SendBusTrack(int id, string busNumber, decimal latitude, decimal longitude)
    {
        await Clients.All.SendAsync("ReceiveBusTrack", id, busNumber, latitude, longitude);
    }
}
