using System;
using Terraria;
using TerrariaApi.Server;
using TShockAPI;
using Microsoft.Xna.Framework;

namespace PluginTemplate
{
    public class PluginTemplate : TerrariaPlugin
    {
        public override string Name => "PluginTemplate";
        public override string Author => "Your name here";
        public override string Description => "Change me!";
        public override Version Version => new Version(1,0,0);

        public PluginTemplate(Main game) : base(game)
        {
            
        }
        // Your initalization code(such as reading config files, registering hooks etc) should go here.
        public override void Initialize()
        {
            ServerApi.Hooks.NetGreetPlayer.Register(this, GreetPlayer);
        }

        private void GreetPlayer(GreetPlayerEventArgs  e)
        {
            TSPlayer.All.SendMessage($"Hello {e.Who}", Color.DarkBlue);
        }
    }
}