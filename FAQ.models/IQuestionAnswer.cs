namespace FAQ.models
{
    public interface IQuestionAnswer
    {
        int id { get; set; }
        List<Tag> tags { get; set; }
        string question { get; set; }
        string answer { get; set; }
    }
}