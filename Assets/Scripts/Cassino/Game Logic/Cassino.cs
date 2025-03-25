using UnityEngine;
using System.Collections.Generic;

public class Cassino : MonoBehaviour
{
    [SerializeField] private Board _board;
    [SerializeField] private Player[] _players;
    [SerializeField] private List<CardItem> _selectedTableCards;
    [SerializeField] private List<CardItem> _groupedTableCards;
    [SerializeField] private Card _selectedHandCard;
    [SerializeField] private int _groupValue;

    #region Monobehaviour Callbacks
    private void Awake()
    {
        _selectedTableCards = new List<CardItem>(13);
        _groupedTableCards = new List<CardItem>(13);
        _board = new Board();
    }

    private void OnEnable()
    {
        
    }

    private void OnDisable()
    {
        
    }

    #endregion

    #region UI Event Callbacks

    /// <summary>
    /// Response to a Card/Stack being clicked:<br />
    /// Selects/Deselects the table card item that was clicked on
    /// </summary>
    /// <param name="cardItem">The card item that was clicked on</param>
    /// <param name="selected">The new selected state of the card item</param>
    private void OnClickedTableCard(CardItem cardItem, bool selected)
    {
        if (selected && !_selectedTableCards.Contains(cardItem))
            _selectedTableCards.Add(cardItem);
        else
            _selectedTableCards.Remove(cardItem);
    }

    /// <summary>
    /// Response to the user clicking on the Drop button:<br />
    /// Drops the currently selected hand card onto the table unless that card 
    /// is tied to a stack or the player has a stack on the board that must be 
    /// picked up first. Does nothing is no hand card is selected.
    /// </summary>
    public void OnDrop()
    {
        if (_selectedHandCard == null)
            return;

        Debug.Log("Dropped a card!");
    }

    /// <summary>
    /// Response to the player clicking on the Set Group Value button:<br />
    /// Sets the target group value to the value of the selected hand card
    /// </summary>
    public void OnSetGroupValue() => _groupValue = _selectedHandCard.Value;

    /// <summary>
    /// Response to the player clicking on the Group button:<br />
    /// Attempts to group together the selected cards. Notifies the user if
    /// the grouping is invalid.
    /// </summary>
    public void OnGroup()
    {
        Debug.Log("Attempted to group the selected cards");
    }

    /// <summary>
    /// Response to the player clicking on the Stack button:<br />
    /// Attempts to create a card stack on the table using the selected and 
    /// grouped cards. Notifies the user if the card stack is invalid.
    /// </summary>
    public void OnStack()
    {
        Debug.Log("Attempted to stack the grouped cards");
    }

    /// <summary>
    /// Response to the player clicking on the Collect button:<br />
    /// Attempts to collect all the selected and grouped cards using the 
    /// selected hand card. Notifies the user if the collection is invalid.
    /// </summary>
    public void OnCollect()
    {
        Debug.Log("Attempted to collect the selected and grouped cards");
    }

    #endregion

    #region Helper Functions

    /// <summary>
    /// Validates that the selected cards can be grouped together based 
    /// on the target group value.
    /// </summary>
    /// <returns>True if valid, false otherwise</returns>
    private bool GroupIsValid()
    {
        return true;
    }

    /// <summary>
    /// Validates that the selected and grouped cards create a valid stack.
    /// </summary>
    /// <returns>True if valid, false otherwise</returns>
    private bool StackIsValid()
    {
        return true;
    }

    /// <summary>
    /// Validates that the selected and grouped cards can be collected using 
    /// the selected hand card.
    /// </summary>
    /// <returns>True if valid, false otherwise</returns>
    private bool CollectionIsValid()
    {
        return true;
    }

    #endregion
}