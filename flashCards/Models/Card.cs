using System;
using System.ComponentModel;
using System.Text;

public class Card {

    public enum CardCategory{
        Geography,
        Hisotry, 
        Science
    }

    public string Question { get; set; }
    public string Answer { get; set; }
    public CardCategory Category { get; set; }

    public Card(string question, string answer, CardCategory category) 
    {
        Question = question.Trim();
        Answer = answer.Trim();
        Category = category;
    }

}


