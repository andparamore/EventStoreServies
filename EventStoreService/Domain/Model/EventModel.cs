using Google.Protobuf.WellKnownTypes;

namespace EventStoreService.Domain.Model;

public class RecordModel
{
    public TimeSpan Time { get; set; } = TimeSpan.FromMilliseconds(DateTime.UtcNow.Millisecond);
    
    public Guid RequestId { get; set; }
    
    public Guid EntityId { get; set; }
    
    public string EntityName { get; set; } = String.Empty;
    
    public string EntitySnapshot { get; set; } = String.Empty;
}