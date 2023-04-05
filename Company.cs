class Company : IContact, IEmailable{
    public string CompanyName;
    public string DirectorName;
    public string PhoneNumber;
    public string EmailAddress;
    public string DirectorEmailAddress;

    public bool SendEmail()
    {
        return true;
    }

    public string ShowContatcInfo()
    {
        return $"{CompanyName}: {PhoneNumber}";
    }
}