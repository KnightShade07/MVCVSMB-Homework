using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCVSMB_Homework.Models
{
    public class VideoGame
    {
        /// <summary>
        /// The ID of the game given by the Database
        /// </summary>
        public int GameID { get; set; }

        /// <summary>
        /// The name of the game.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// The rating of the game given by the ESRB
        /// </summary>
        [Display(Name ="ESRB Rating: ")]//these dont use ; at the end.
        public char ESRBRating { get; set; }

        /// <summary>
        /// The systems that the game is on
        /// </summary>

        public string Systems { get; set; }

        /// <summary>
        /// The price of the game.
        /// </summary>
        public decimal Price { get; set; }

        


    }
}
