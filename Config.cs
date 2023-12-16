namespace NwapiPluginPeuti
{
    using MapGeneration;
    using PlayerRoles;
    using System.Collections.Generic;
    using System.ComponentModel;

    public class Config
    {
        [Description("핵이 시작되었을때 매세지")]
        public string WarheadStartText { get; set; } = "<size=40><color=red>핵폭탄</color>이 실행되었습니다</size>";

        [Description("핵폭탄이 중지되었을때 매세지")]
        public string WarheadStopText { get; set; } = "<size=40><color=red>핵폭탄</color>이 중지되었습니다.</size>";

        [Description("핵폭탄 터졌을때 매세지")]
        public string WarheadDetonationText { get; set; } = "핵폭탄이 터졌습니다.";


    }
}