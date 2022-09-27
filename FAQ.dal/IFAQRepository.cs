namespace FAQ.dal;
using FAQ.models;
public interface IFAQRepository
{
    public void CreateFAQ(FAQ faq);
    public FAQ GetFAQ(int id);
    public void DeleteFAQ(int id);
    public FAQ UpdateFAQ(FAQ faq);
    public IEnumerable<FAQ> GetAllFAQ();
}

