using System;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Player
{
    [field: SerializeField] public string Name { get; private set; }
    [field: SerializeField] public List<Card> Hand { get; private set; }
    [field: SerializeField] public int MaxCards { get; private set; }

    public bool HandIsEmpty { get { return Hand.Count == 0; } }
    public bool HandIsFull { get { return Hand.Count == MaxCards; } }

    public Player(string name, int handSize)
    {
        Name = name;
        Hand = new List<Card>(handSize);
        MaxCards = handSize;
    }

    public void ReceiveCard(Card card)
    {
        if (HandIsFull)
            return;

        Hand.Add(card);
    }

    public void PlayCard(Card card)
    {
        if (HandIsEmpty || Hand.IndexOf(card) == -1)
            return;

        Hand.Remove(card);
    }
}