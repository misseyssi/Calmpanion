using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class QuoteButton : MonoBehaviour
{
    public TMP_Text quoteText;

    private string[] quotes = {
        "It is not the mountain we conquer but ourselves. — Sir Edmund Hillary",
        "Grab a coffee. Journal your intentions. Get to work. Create miracles. — Elyse Santilli",
        "Too many people overvalue what they are not and undervalue what they are. — Malcolm S. Forbes",
        "To accept ourselves as we are means to value our imperfections as much as our perfections. — Sandra Bierig",
        "Self-care means giving yourself permission to pause. — Cecilia Tran",
        "Everyone thinks of changing the world, but no one thinks of changing himself. — Leo Tolstoy",
        "The most creative act you will ever undertake is the act of creating yourself. — Deepak Chopra"
    };

    private int currentIndex = 0;

    private void Start()
    {
        // Set the initial quote
        UpdateQuote();
    }

    public void OnButtonClick()
    {
        // Increment the index to get the next quote
        currentIndex = (currentIndex + 1) % quotes.Length;

        // Update the quote text
        UpdateQuote();
    }

    private void UpdateQuote()
    {
        // Set the quote text to the current quote
        quoteText.text = quotes[currentIndex];
    }
}