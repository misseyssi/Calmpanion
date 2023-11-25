using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RandomWordDisplay : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro;

    private string[] quotes = { "\"Life is a great big canvas, and you should throw all the paint on it you can.\" - Danny Kaye",
            "\"You only live once, but if you do it right, once is enough.\" - Joe Lewis",
            "\"It is often the small steps, not the giant leaps, that bring about the most lasting change.\" - Queen Elizabeth II",
        "\"There is always light. If only we're brave enough to see it. If only we're brave enough to be it.\" - Amanda Gorman",
        "\"Don’t let anyone ever make you feel like you don’t deserve what you want.\" - Heath Ledger",
        "\"It’s ok to get lost, as long as you find your way back.\" - Jennifer Niven",
        "\"Life owes you nothing. You owe yourself everything.\" - Corey Taylor",
        "\"There is still a lot to learn and there is always great stuff out there. Even mistakes can be wonderful.\" - Robin Williams",
        "\"You’re braver than you believe, stronger than you seem, and smarter than you think.\" - A.A Milne",
        "\"Go confidently in the direction of your dreams. Live the life you have imagined.\" - Henry David Thoreau",
        "\"Act as if what you do makes a difference. It does.\" - William James",
        "\"Believe you can and you're halfway there.\" - Theodore Roosevelt",
        "\"Whatever you want to do, do it now. There are only so many tomorrows.\" - Michael Landon",
        "\"Don’t just survive. Shine.\" - Tom Fletcher",
        "\"If you're lucky enough to be different, never change.\" - Taylor Swift",
        "\"Be patient with yourself. Self-growth is tender; it’s holy ground. There’s no greater investment.\" - Stephen Covey",
        "\"Self-care means giving yourself permission to pause.\" - Cecilia Tran",
        "\"Life is like walking, you take one step at a time.\" - Taylor Swift",
        "\"Do something nice for yourself today. Find some quiet, sit in stillness, breathe. Put your problems on pause. You deserve a break.\" - Akiroq Brost",
        "\"The most creative act you will ever undertake is the act of creating yourself.\" - Deepak Chopra",
        "\"To accept ourselves as we are means to value our imperfections as much as our perfections.\" - Sandra Bierig",
        "\"Breathe. Let go. And remind yourself that this very moment is the only one you know you have for sure.\" - Oprah Winfrey",
        "\"Too many people overvalue what they are not and undervalue what they are.\" - Malcolm S. Forbes",
        "\"It is not the mountain we conquer but ourselves.\" - Sir Edmund Hillary",
        "\"You matter. How you feel matters. What you say, do, and think matters. It all matters.\" - Richelle E. Goodrich",
        "\"If you were born with the weakness to fall, you were born with the strength to rise.\" - Rupi Kaur",
        "\"To anyone out there who’s hurting — it’s not a sign of weakness to ask for help. It’s a sign of strength.\" - Barack Obama",
        "\"You are so much stronger than you realize. Don’t let anyone ever tell you that you’re not. Not even you.\" - J.W. Lynne",
        "\"Life is waiting for you. You might be stuck here for a while, but the world isn’t going anywhere. Hang in there if you can. Life is always worth it.\" - Matt Haig"

};


    void Start()
    {
        // Call the function to change the displayed text
        ChangeText();
    }

    void ChangeText()
    {
        // Pick a random index from the 'quotes' array
        int randomIndex = Random.Range(0, quotes.Length);

        // Set the TextMeshPro text to the randomly chosen quote
        textMeshPro.text = quotes[randomIndex];
    }

}
