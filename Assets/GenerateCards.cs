using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;

public class GenerateCards : MonoBehaviour
{
    [SerializeField] GameObject[] tiles; // this needs to not be serialized
    [SerializeField] Card[] cardObjects;
    [SerializeField] GameObject cover;
    List<Card> cards = new List<Card>();
    List<Card> selectedCards = new List<Card>();
    Card selectedCard;

    private void Awake()
    {
        print(cardObjects.Length);
        cards = cardObjects.ToList();
        print(cards.Count);
    }
    private void Start()
    {
        for (int i = 0; i<tiles.Length; i++)
        {
            SelectCard(tiles[i]);   
        }
    }

    void SelectCard(GameObject tile)
    {
        if (cards.Count != 0)
        {
            selectedCard = cards[Random.Range(0, cards.Count - 1)]; // do I need the -1?
            string cardName = selectedCard.name;
            if (selectedCards.Contains(selectedCard))
            {
                CreateCard(tile);
                print("removed" + selectedCard + " from cards");
                cards.Remove(selectedCard);
            }
            else
            {
                CreateCard(tile);
                print("added " + selectedCard + " to selected cards");
                selectedCards.Add(selectedCard);
            }
        }
        else
        {
            print("The cards list is empty!");
        }
    }

    public void CreateCard(GameObject tile)
    {
        Card cardInstance = Instantiate(selectedCard, tile.transform.position, Quaternion.identity);
        cardInstance.transform.SetParent(tile.transform);
        GameObject coverCard = Instantiate(cover, tile.transform.position, Quaternion.identity);
        coverCard.transform.SetParent(tile.transform);
    }

}
