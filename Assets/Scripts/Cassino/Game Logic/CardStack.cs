using UnityEngine;
using System.Collections.Generic;

public class CardStack : CardItem
{
    [field: SerializeField] public List<Card> Cards { get; private set; }
    [field: SerializeField] public bool Fixed { get; private set; }

    public CardStack(List<Card> cards, int value, bool @fixed) : base(value)
    {
        Cards = cards;
        Fixed = @fixed;
    }
}