using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "New Card", menuName = "Card")]
public class Card : ScriptableObject
{
    public string cardName;
    public int id;
    public int health;
    public int attack;
    public string description;
    public Sprite image;
    public GameObject cardBackPrefab;
}
