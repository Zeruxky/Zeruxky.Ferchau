namespace Zeruxky.Ferchau.Domain
{
    public record CustomerId
    {
        private readonly Guid value;

        public CustomerId(Guid value)
        {
            this.value = value;
        }

        public static CustomerId NewId() => new(Guid.NewGuid());

        public static explicit operator CustomerId(Guid value) => new(value);

        public static implicit operator Guid(CustomerId id) => id.value;

        public override string ToString() => this.value.ToString();
    }
}