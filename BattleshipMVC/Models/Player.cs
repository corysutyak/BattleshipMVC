﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BattleshipMVC.Models
{
    public class Player
    {
        UpperBoard upBoard;

        public Player()
        {
            upBoard = new UpperBoard();
        }
    }
}