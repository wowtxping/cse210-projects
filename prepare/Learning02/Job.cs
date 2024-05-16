public class Job
{
    public string _Company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;
    
    public Job(string company, string jobtitle, int startyear, int endyear)
    {
        _Company = company;
        _jobTitle = jobtitle;
        _startYear = startyear;
        _endYear = endyear;
    }

    public void Display()
    {
        Console.WriteLine($"{_jobTitle} {_Company} {_startYear}-{_endYear}");
    }
}