class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string title, string description, string date, string time, Address address, string speaker, int capacity)
        : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public string GetDetailedEventInfo()
    {
        return $"{GetEventSummary()}\nEvent Type: Lecture\nSpeaker: {_speaker}\nCapacity: {_capacity}";
    }

     public string ShortSummary()
    {
        return $"Lecture: {_title} on {_date} at {_address.AllTogether()} "; 
    }



}