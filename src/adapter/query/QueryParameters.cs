namespace communication.dds.api.adapter.query
{
    public abstract class QueryParameters : Parameters
    {
        public abstract string Sql92Query { get; }
    }
}