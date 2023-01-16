using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Team
    {
        string name;

        /// <summary>
        /// List of players of the Team
        /// </summary>
        List<Player> players;

        /// <summary>
        /// Team captain
        /// </summary>
        Player? captain;
        
        /// <summary>
        /// Maximum number of players for each role
        /// </summary>
        const int MAX_RISERVA_PLAYERS = 3;
        const int MAX_ROSA_PLAYERS = 11;

        public Team(string name)
        {
            players = new List<Player>();
            this.name = name;
        }

        /// <summary>
        /// Adding player to a Team
        /// 
        /// We can have a maximum of MAX_ROSA_PLAYERS rosa's players and MAX_RISERVA_PLAYERS riserva's player
        /// </summary>
        /// <param name="player"></param>
        /// <returns>True if player has been inserted</returns>
        public bool AddPlayer(Player player)
        {

            int n_player = 0;
            foreach (Player p in players)
            {
                n_player++;
            }
            switch (player.role)
            {
                case Player.ERole.Rosa:
                    if (MAX_ROSA_PLAYERS < n_player)
                        players.Add(player);                    
                    else 
                        Console.WriteLine("La rosa è piena");

                    break;
                case Player.ERole.Riserva
                    if(MAX_RISERVA_PLAYERS < )

                : break;
            }
        }

        /// <summary>
        /// Setting captain of the Team
        /// 
        /// Captain must be in the Rosa role
        /// </summary>
        /// <param name="captain"></param>
        /// <returns>True if captain has been setted</returns>
        public bool AddCaptain(Player captain)
        {
            // TODO T.3
        }

        /// <summary>
        /// Get a list of players of the team
        /// </summary>
        /// <returns></returns>
        public string GetPlayers()
        {
            
        }

        public string Name { get { return name; } }

        public Player? Captain { get { return captain; } }
    }
}
