namespace BusTrackingService.Hubs;

public class TrackHub : Hub
{
    public async Task SendBusTrack(int id, string busNumber, decimal latitude, decimal longitude)
    {
        await Clients.Client(Context.ConnectionId).SendAsync("ReceiveBusTrack", id, busNumber, latitude, longitude);

        // Расскомментировать в случае нужды или тестирования

        //await Clients.All.SendAsync("ReceiveBusTrack", id, busNumber, latitude, longitude);
        //await Clients.AllExcept(new List<string> { Context.ConnectionId }).SendAsync("ReceiveBusTrack", id, busNumber, latitude, longitude);
        //await Clients.Others.SendAsync("ReceiveBusTrack", id, busNumber, latitude, longitude);

        // Конец фрагмента
    }
}
