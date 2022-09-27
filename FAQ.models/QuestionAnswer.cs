namespace FAQ.models;

public class QuestionAnswer : IEntity
{
    public int id { get; set; }
    public List<Tag>? tags { get; set; }
    public string question { get; set; }
    public string answer { get; set; }

    public QuestionAnswer(int id, List<Tag>? tags, string question, string answer)
    {
        this.id = id;
        this.tags = tags;
        this.question = question;
        this.answer = answer;
    }
}

