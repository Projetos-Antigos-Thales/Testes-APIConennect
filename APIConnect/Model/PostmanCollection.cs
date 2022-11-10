namespace APIConnect.Model
{
    public class PostmanCollection
    {
        public List<Item>? Item { get; set; }
    }

    public class Item
    {
        public string? Name { get; set; }
        public Request? Request { get; set; }
    }

    public class Request
    {
        public string? Method { get; set; }
        public Body? Body { get; set; }
        public Url? Url { get; set; }
        public List<Header>? Header { get; set; }
    }

    public class Header
    {
        public string? Key { get; set; }
        public string? Value { get; set; }
        public string? Type { get; set; }
    }

    public class Body
    {
        public string? Raw { get; set; }
    }

    public class Url
    {
        public string? Raw { get; set; }
    }
}
