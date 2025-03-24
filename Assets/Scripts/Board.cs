using UnityEngine;
using System.Collections.Generic;

[System.Serializable]
public class Board
{
    [field: SerializeField] public Deck Deck { get; private set; }
    [field: SerializeField] public List<CardItem> TableCards { get; private set; }

    public Board()
    {
        TableCards = new List<CardItem>(52);
        Deck = new Deck();
        Deck.Shuffle();
    }
}