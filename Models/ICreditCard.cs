namespace Models;

public enum CardIssuers
{
    Visa,
    MasterCard,
    AmericanExpress,
    Discover,
    JCB,
    DinersClub
}

public interface ICreditCard
{
    public Guid CreditCardId { get; set; }

    public CardIssuers Issuer { get; set; }
    public string Number { get; set; }
    public string ExpirationYear { get; set; }
    public string ExpirationMonth { get; set; }
    public string CardHolderName { get; set; }
}


