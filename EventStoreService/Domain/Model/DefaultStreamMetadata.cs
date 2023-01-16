using EventStore.Client;

namespace EventStoreService.Domain.Model;

public class DefaultStreamMetadata
{
    public Dictionary<string, StreamMetadataParams>? MetadataForTypes { get; set; } =
        new Dictionary<string, StreamMetadataParams>();
}