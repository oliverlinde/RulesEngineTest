namespace FAQ.models;
public class FAQ
{
    public int id { get; set; }
    public Category category { get; set; }
    public string question { get; set; }
    public string answer { get; set; }

    public FAQ(int id, Category category, string question, string answer)
    {
        this.id = id;
        this.category = category;
        this.question = question;
        this.answer = answer;
    }
}

