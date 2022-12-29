namespace WebApplication1.Models
{
    public class Team
    {
        public int Id { get; set; }
#pragma warning disable CS8618 // Non-nullable property 'Name' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public string Name { get; set; }
#pragma warning restore CS8618 // Non-nullable property 'Name' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
#pragma warning disable CS8618 // Non-nullable property 'Description' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public string Description { get; set; }
#pragma warning restore CS8618 // Non-nullable property 'Description' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
#pragma warning disable CS8618 // Non-nullable property 'Photo' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.
        public string Photo { get; set; }
#pragma warning restore CS8618 // Non-nullable property 'Photo' must contain a non-null value when exiting constructor. Consider declaring the property as nullable.

    }
}
