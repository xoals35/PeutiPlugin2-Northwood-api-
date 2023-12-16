namespace NwapiPluginPeuti
{
    using PluginAPI.Core.Attributes;
    using PluginAPI.Enums;
    using PluginAPI.Events;
    using System;

    public class Lobby
    {
        public static Lobby Instance { get; private set; }

        [PluginConfig("Config.yml")]
        public static Config Config;

        [PluginPriority(LoadPriority.Highest)]
        [PluginEntryPoint("PeutiPlugin", "1.0.0", "다양한 기능이 포함된 플러그인 입니다!", "Peuti")]
        public void LoadPlugin()
        {
            Instance = this;
            EventManager.RegisterEvents<EventHandlers>(this);
        }
    }
}