public class Assignment
{
    private string _studentName;
    private string _topic;

    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }
// Gettter for the private member variables so they can be accessible later to the child classes
    public string GetStudentName() // getter for _studentName
    {
        return _studentName;
    }
    public string GetTopic() // getter for _topic
    {
        return _topic;
    }
    public string GetSummary() // getter for the summary aka _studentName + " " + _topic
    {
        return _studentName + " " + _topic;
    }









}