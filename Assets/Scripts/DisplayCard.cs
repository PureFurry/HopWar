using UnityEngine;
using UnityEngine.UI;

public class DisplayCard : MonoBehaviour
{
    public Card card;
    public Image cardImage;
    public GameObject cardBackPrefab; // Yeni bir özellik ekledik
    public Text nameText;
    public Text idText;
    public Text healthText;
    public Text attackText;
    public Text descriptionText;

    private GameObject cardBack; // Yeni bir özellik ekledik

    void Start()
    {
        // Kartýn ön yüzü için gerekli olan bileþenlerin güncellenmesi
        cardImage.sprite = card.image;
        nameText.text = card.cardName;
        idText.text = "ID: " + card.id.ToString();
        healthText.text = "Health: " + card.health.ToString();
        attackText.text = "Attack: " + card.attack.ToString();
        descriptionText.text = card.description;

        // Kartýn arka yüzü için bir prefab örneði oluþturma
        cardBack = Instantiate(card.cardBackPrefab, transform);
        cardBack.SetActive(false); // Kartýn arka yüzünü varsayýlan olarak gizli hale getir

    }

    // Kartýn ön yüzünü göstermek için bir iþlev
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

    // Kartýn arka yüzünü göstermek için bir iþlev
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
