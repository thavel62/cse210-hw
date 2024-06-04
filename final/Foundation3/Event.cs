public abstract class Event
{
    private string title;
    private string description;
    private DateTime date;
    private DateTime time;
    private Address address;

    protected Event(string title, string description, DateTime date, DateTime time, Address address)
    {
        this.title = title;
        this.description = description;
        this.date = date;
        this.time = time;
        this.address = address;
    }

    public virtual string GetStandardDetails()
    {
        return $"Title: {title}\nDescription: {description}\nDate: {date.ToShortDateString()}\nTime: {time.ToShortTimeString()}\nAddress: {address}";
    }

    public abstract string GetFullDetails();

    public virtual string GetShortDescription()
    {
        return $"Type: {this.GetType().Name}\nTitle: {title}\nDate: {date.ToShortDateString()}";
    }
}
