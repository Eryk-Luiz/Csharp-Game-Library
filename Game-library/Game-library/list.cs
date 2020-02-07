using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_library
{
    public static  class list
    {
        
        
        public static void lista(int count)
        {
            GameBanner game = new GameBanner();
            List<GameBanner> list = new List<GameBanner>();




            for (int i = 0; i < count; i++)
            {
                game.genre = "Action";
                game.title = "Resident Evil";
                game.description = "Horror Game";
                list.Add(game);
            }
        }

    }



    }

