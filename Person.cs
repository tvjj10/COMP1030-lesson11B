class person : IContact, IEmailable
{
    public string FirstName;
    public string LastName;
    public string PhoneNumber;
    public string EmailAddress;

    public bool SendEmail()
    {
        // TODO Send via SMTP Server
        return true;
    }

    public string ShowContatcInfo()
    {
        return $"{FirstName} {LastName}: {PhoneNumber}";
    }
}