﻿using System;
using System.Security.Principal;
using Core.Menu;
using Core.Models;
using Games.Core;
using Games;

namespace GamingDesktopApp;
internal class Program
{
    static void Main(string[] args)
    {
        bool autorizationIn = false;
        string? menu = "";
        User? user = null;
        Menu.MenuStart(autorizationIn, menu, user);
        
    }
}
