using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentConnection.MemoNerd.Domain
{
    enum CardListType { Language, History, Picture, Formulas }; //TODO: Add more types if required

    public class Card
    {
        Word frontSide, backSide;
    }

    public class Word
    {
        string word;
        string language; //ISO codes
    }

    public class CardList
    {
        List<string> Category;
        List<Card> Cards;
    }

    public class User
    {
        string username;
        string password; //hashed password
        List<CardList> cardLists;
    }
}
