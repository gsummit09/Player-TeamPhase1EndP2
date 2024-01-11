using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player_Team_EndPhase1Pro2
{
    public class OneDayTeam : ITeam
    {
        private List<Player> players;
        public OneDayTeam() { players = new List<Player>(); }
        public void AddPlayer(Player player)
        {
            if(players.Count < 11)
            {
                players.Add(player);
                Console.WriteLine($"Player {player.Id} added to the team successfully.");
            }
            else
            {
                Console.WriteLine("The team cannot have more than 11 players.");
            }
           // throw new NotImplementedException();
        }

        public List<Player> GetAllPlayers()
        {
            return players.ToList();
            //throw new NotImplementedException();
        }

        public Player GetPlayerById(int playerId)
        {
            return players.FirstOrDefault(p => p.Id == playerId);
            //throw new NotImplementedException();
        }

        public List<Player> GetPlayersByName(string playerName)
        {
            return players.Where(p => p.Name.Equals(playerName, StringComparison.OrdinalIgnoreCase)).ToList();   
            //throw new NotImplementedException();
        }

        public void RemovePlayer(int playerId)
        {
            Player playerToRemove = players.FirstOrDefault(p => p.Id == playerId);
            if(playerToRemove != null)
            {
                players.Remove(playerToRemove);
                Console.WriteLine($"Player {playerToRemove.Id} removed from the team.");
            }
            else
            {
                Console.WriteLine($"Player with Id {playerId} not found in the team.");
            }
           // throw new NotImplementedException();
        }
    }
}
