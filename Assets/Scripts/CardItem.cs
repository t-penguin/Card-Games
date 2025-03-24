using UnityEngine;

[System.Serializable]
public class CardItem
{
    [field : SerializeField] public int Value { get; private set; }

    public CardItem(int value)
    {
        Value = value;
    }
}