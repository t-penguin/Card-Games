using System.Collections.Generic;
using UnityEngine;

public class BoardUI : MonoBehaviour
{
    [SerializeField] private GameObject _cardPrefab;
    [SerializeField] private Transform _board;
    [SerializeField] private RectTransform[] _tableItems;

    private Dictionary<string, Sprite> _cardSprites;

    private const string CARD_SPRITES_PATH = "Textures/Cards";

    #region Monobehaviour Callbacks

    private void Awake()
    {
        _cardSprites = new Dictionary<string, Sprite>();
        LoadCardSprites(CARD_SPRITES_PATH);
    }

    private void OnEnable()
    {
        
    }

    private void OnDisable()
    {
        
    }

    #endregion

    #region Event Callbacks

    private void OnCardDropped(Card card) => AddCardToTable(card);

    #endregion

    #region Helper Functions

    private void AddCardToTable(Card card)
    {
        
    }

    /// <summary>
    /// Retrieves sprites for all the cards from the Textures folder in Resources. 
    /// Stores these sprites into a dictionary for quick retrieval.
    /// </summary>
    /// <param name="path">The path to the sliced spritesheet containing all the card sprites</param>
    private void LoadCardSprites(string path)
    {
        Sprite[] sprites = Resources.LoadAll<Sprite>(path);

        foreach (Sprite sprite in sprites)
            _cardSprites.Add(sprite.name, sprite);
    }

    #endregion
}