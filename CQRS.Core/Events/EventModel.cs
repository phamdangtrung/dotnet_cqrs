using MongoDB.Bson.Serialization.Attributes;

namespace CQRS.Core.Events;
public class EventModel
{
    [BsonId]
    [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
    public string Id { get; set; } = string.Empty;
    public DateTime Timestamp { get; set; }
    public Guid AggregateIdentifier { get; set; } = Guid.Empty;
    public string AggregateType { get; set; } = string.Empty;
    public int Version { get; set; }
    public string EventType { get; set; } = string.Empty;
    public BaseEvent EventData { get; set; }
}
