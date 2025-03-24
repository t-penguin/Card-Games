using System;
using UnityEngine;
using Random = UnityEngine.Random;

[Serializable]
public class Deck
{
    [field: SerializeField] public Card[] Cards { get; private set; }
    [SerializeField] private int _topIndex;

    public Deck()
    {
        Cards = new Card[52];
        _topIndex = 0;

        int index = 0;
        foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            foreach (Rank rank in Enum.GetValues(typeof(Rank)))
                Cards[index++] = new Card(rank, suit);
    }

    public void Shuffle()
    {
        _topIndex = 0;
        for (int i = 0; i < 52; i++)
        {
            int r = Random.Range(i, 52);
            Card temp = Cards[i];
            Cards[i] = Cards[r];
            Cards[r] = temp;
        }
    }

    public Card TakeTopCard()
    {
        if (_topIndex >= 52)
            return null;

        return Cards[_topIndex++];
    }
}