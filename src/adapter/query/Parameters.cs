namespace communication.dds.api.adapter.query
{
    public abstract class Parameters
    {
        public abstract string TopicName { get; }

        public abstract string Partition { get; }
    }
}