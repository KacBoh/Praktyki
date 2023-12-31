﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace idź_na_ryby_2._0
{
    internal class Game
    {
        private List<Player> players;
        private Dictionary<Values, Player> books;
        private Deck stock;
        private TextBox textBoxOnForm;
        public Game(string playerName, IEnumerable<string> opponentNames, TextBox textBoxOnForm)
        {
            Random random = new Random();
            this.textBoxOnForm = textBoxOnForm;
            players = new List<Player>();   
            players.Add(new Player(playerName, random, textBoxOnForm));
            foreach(string player in opponentNames)
            {
                players.Add(new Player(player ,random , textBoxOnForm));
            }
            books = new Dictionary<Values, Player>();
            stock = new Deck();
            Deal();
            players[0].SortHand();
        }

        private void Deal()
        {
            stock.Shuffle();
            for(int i = 0;i<5;i++)
            {
                foreach(Player player in players)
                {
                    player.TakeCard(stock.Deal());
                }
            }
        }

        public bool PlayOneRound(int selectedPlayerCard)
        {
            Values cardToAskFor = players[0].Peek(selectedPlayerCard).Value;
            for(int i =0; i < players.Count;i++)
            {
                if (i == 0)
                {
                    players[0].AskForACard(players, 0, stock, cardToAskFor);
                }
                else players[i].AskForACard(players, i, stock);

                if (PullOutBooks(players[i]))
                {
                    textBoxOnForm.Text += players[i].Name + " ciągnie karty" + Environment.NewLine;
                    int card = 1;
                    while (card <= 5 && stock.Count > 0)
                    {
                        players[i].TakeCard(stock.Deal());
                        card++;
                    }
                }

                players[0].SortHand();
                if (stock.Count == 0)
                {
                    textBoxOnForm.Text = "Na kupce nie ma żadnych kart. Gra skończona!" + Environment.NewLine;
                    return true;
                }
            }
            return false;
        }

        public bool PullOutBooks(Player player)
        {
            IEnumerable<Values> booksPulled = player.PullOutBooks();
            foreach(Values value in booksPulled)
            {
                books.Add(value, player);
            }
            if(player.CardCount == 0)
            {
                return true;
            }

            return false;
        }

        public string DescribeBooks()
        {
            string whoHasWhichBooks = "";
            foreach (Values value in books.Keys) 
               whoHasWhichBooks += books[value].Name + " ma grupę " + Card.Plural(value,0) + Environment.NewLine;
            return whoHasWhichBooks;
        }

        public string GetWinnerName()
        {
            Dictionary<string , int> winners = new Dictionary<string, int>();
            foreach(Values value in books.Keys)
            {
                string name = books[value].Name;
                if(winners.ContainsKey(name))
                {
                    winners[name]++;
                }
                else winners.Add(name, 1);
            }
            int mostBooks = 0;
            foreach(string name in winners.Keys)
            {
                if (winners[name] > mostBooks) mostBooks = winners[name];
            }
            bool tie = false;
            string winnerList = "";
            foreach(string name in winners.Keys)
            {
                if (winners[name] == mostBooks)
                {
                    if(!String.IsNullOrEmpty(winnerList))
                    {
                        winnerList += " i ";
                        tie = true;
                    }
                    winnerList += name;
                }
            }
            winnerList += ": " + mostBooks + " grupy ";
            if (tie)
            {
                return "remis pomiędzy " + winnerList;
            }
            else return winnerList;

        }

        public IEnumerable<string> GetPlayerCardNames()
        {
            return players[0].GetCardNames();
        }

        public string DescribePlayerHands()
        {
            string Description = "";
            for (int  i = 0; i < players.Count; i++)
            {
                Description += players[i].Name + " ma " + players[i].CardCount;
                //if (players[i].CardCount == 0)
                Description += " Kart.\r\n";
                //else if (players[i].CardCount == 1)
            }
            Description += "Na kupce zostało: " + stock.Count + "\r\n";
            return Description;
        }
    }
}
