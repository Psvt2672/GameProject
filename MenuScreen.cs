﻿using Game12;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThanaNita.MonoGameTnt;

namespace GameProject
{
    public class MenuScreen : Actor
    {
        ExitNotifier exitNotifier;

        public MenuScreen(Vector2 screenSize, ExitNotifier exitNotifier)
        {
            this.exitNotifier = exitNotifier;

            //Start button
            var startButton = new Button("Simvoni.ttf", 50, Color.Brown, "Start", new Vector2(300, 100));
            startButton.Position = new Vector2(screenSize.X/2 , screenSize.Y/2 - 200);
            this.Add(startButton);

            //Exit button
            var exitButton = new Button("Simvoni.ttf", 50, Color.Brown, "Exit", new Vector2(300, 100));
            exitButton.Position = new Vector2(screenSize.X / 2, screenSize.Y / 2);
            exitButton.ButtonClicked += GameExit;
            this.Add(exitButton);
        }

        public override void Act(float deltaTime)
        {
            base.Act(deltaTime);
        }

        public void GameExit(GenericButton button)
        {
            AddAction(new RunAction(() => exitNotifier(this, 0)));
        }
    }
}
