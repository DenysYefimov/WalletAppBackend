namespace WalletAppBackend.Data.Entities
{
    public class BaseNamedEntity : BaseEntity
    {
        public BaseNamedEntity(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
}
