﻿using System;
using System.Collections.Generic;
using NuGet.Packaging;
using Twest2.Data;
using Twest2.Models;

namespace Twest2.Controllers
{
	public class HelperClass
	{
		public List<List<string>> SortPlayersToGroups(ApplicationDbContext _db)
		{
            IEnumerable<Player> objPlayersList = _db.Players;
            List<string> GroupA = (from player in objPlayersList where player.Group == "A" & player.EnrolledToTournament.ToLower() == "yes" select player.FirstName + " " + player.LastName).ToList();
            List<string> GroupB = (from player in objPlayersList where player.Group == "B" & player.EnrolledToTournament.ToLower() == "yes" select player.FirstName + " " + player.LastName).ToList();
            List<string> GroupC = (from player in objPlayersList where player.Group == "C" & player.EnrolledToTournament.ToLower() == "yes" select player.FirstName + " " + player.LastName).ToList();
            List<List<string>> groups = new List<List<string>>
            {
                GroupA, GroupB, GroupC
            };
            return groups;
        }

        public List<List<string>> CreateSingleGroupPlays(ApplicationDbContext _db, List<string> singleGroup)
        {
            List<List<string>> groupPlays = new List<List<string>>();
            for (var i = 0; i < singleGroup.Count; i++)
            {
                string player = singleGroup[i]; //take player
                List<string> singlePlayInfo = new List<string>(); //list
                for (var j = i+1; j < singleGroup.Count; j++) 
                {
                    string nextPlayer = singleGroup[j];
                    singlePlayInfo.Add(player);
                    singlePlayInfo.Add(nextPlayer);
                    groupPlays.Add(singlePlayInfo);
                    singlePlayInfo = new List<string>(); //nullify list
                }
                //in latter iterations, pair it with all other and add to list

            }
            //List<List<string>> groups = new List<List<string>>
            //{
            //    GroupA, GroupB, GroupC
            //};
            //check for duplicat pairs!!!!
            return groupPlays;
        }
    }
}
