public class LegoRepository 
{
    private string connectionString;

    public LegoRepository(string connectionString)
    {
        this.connectionString = connectionString;
    }

    public LegoTheme GetLegoTheme(string name)
    {

    }

    //init db
    public void WriteLegoThemes(List<LegoTheme> legoThemes)
    {
	
    }
}