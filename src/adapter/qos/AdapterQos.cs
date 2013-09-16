using communication.dds.api.adapter.qos.enums;

namespace communication.dds.api.adapter.qos
{
    public abstract class AdapterQos
    {
        public abstract PersistenceTypeEnum PersistenceType { get; }

        public abstract MessageReliabilityTypeEnum MessageReliabilityType { get; }
    }
}