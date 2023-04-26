using UnityEngine;
using UnityEngine.UI;

public class DisplayCard : MonoBehaviour
{
    public Card card;
    public Image cardImage;
    public GameObject cardBackPrefab; // Yeni bir �zellik ekledik
    public Text nameText;
    public Text idText;
    public Text healthText;
    public Text attackText;
    public Text descriptionText;

    private GameObject cardBack; // Yeni bir �zellik ekledik

    void Start()
    {
        // Kart�n �n y�z� i�in gerekli olan bile�enlerin g�ncellenmesi
        cardImage.sprite = card.image;
        nameText.text = card.cardName;
        idText.text = "ID: " + card.id.ToString();
        healthText.text = "Health: " + card.health.ToString();
        attackText.text = "Attack: " + card.attack.ToString();
        descriptionText.text = card.description;

        // Kart�n arka y�z� i�in bir prefab �rne�i olu�turma
        cardBack = Instantiate(card.cardBackPrefab, transform);
        cardBack.SetActive(false); // Kart�n arka y�z�n� varsay�lan olarak gizli hale getir

    }

    // Kart�n �n y�z�n� g�stermek i�in bir i�lev
    public void ShowFront()
    {
        cardImage.enabled = true;
        nameText.enabled = true;
        idText.enabled = true;
        healthText.enabled = true;
        attackText.enabled = true;
        descriptionText.enabled = true;

        cardBack.SetActive(false);
    }

    // Kart�n arka y�z�n� g�stermek i�in bir i�lev
    public void ShowBack()
    {
        cardImage.enabled = false;
        nameText.enabled = false;
        idText.enabled = false;
        healthText.enabled = false;
        attackText.enabled = false;
        descriptionText.enabled = false;

        cardBack.SetActive(true);
    }
}
