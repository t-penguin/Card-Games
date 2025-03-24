using UnityEngine;

[System.Serializable]
public class Card : CardItem
{
    [field: SerializeField] public Rank Rank { get; private set; }
    [field: SerializeField] public Suit Suit { get; private set; }
    [field: SerializeField] public bool FaceUp { get; private set; }

    public Card(Rank rank, Suit suit) : base((int)rank)
    {
        Rank = rank;
        Suit = suit;
        FaceUp = false;
    }

    public void FlipOver() => FaceUp = !FaceUp;
}