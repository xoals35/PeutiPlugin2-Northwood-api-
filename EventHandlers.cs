using PluginAPI;
using PluginAPI.Commands;
using PluginAPI.Core;
using PluginAPI.Enums;
using PluginAPI.Events;
using PluginAPI.Loader;
using PluginAPI.Roles;
using MapGeneration;
using CommandSystem;
using InventorySystem.Items.Pickups;
using PluginAPI.Core.Items;
using PlayerRoles.Voice;
using PlayerRoles;
using PluginAPI.Core.Attributes;
using PluginAPI.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Reflection;
using PlayerStatsSystem;
using Respawning;
using Unity;
using System.ComponentModel.Design;
using Respawning.NamingRules;
using PlayerRoles.FirstPersonControl.Spawnpoints;
using System.Runtime.Remoting.Messaging;
using PlayerRoles.PlayableScps.Scp049;
using RemoteAdmin.Communication;
using MapGeneration.Distributors;
using System.Data;
using RoundRestarting;
using UnityEngine;
using static Respawning.RespawnEffectsController;
using System.Linq;




namespace NwapiPluginPeuti
{

    public class EventHandlers
    {


        [PluginEvent]
        public void OnWarheadStart(WarheadStartEvent ev)
        {
            if (ev.Player == null)
                Map.Broadcast(9, $"<size=33><color=red>알파 탄두</color> 폭파 절차가 발동되었습니다.\n남아있는 인원은 신속히 대피하시기 바랍니다.</size>");
            else
                Map.Broadcast(9, $"<size=33><color=red>알파 탄두</color> 폭파 절차가 발동되었습니다.\n남아있는 인원은 신속히 대피하시기 바랍니다. 실행한사람: {ev.Player.Nickname}</size> ");
        }

        [PluginEvent]
        public void OnWarheadStop(WarheadStopEvent ev)
        {
            if (ev.Player == null)
                Map.Broadcast(8, $"<size=33><color=red>폭파 절차</color>가 취소되었습니다. 시스템을 재가동합니다.</size>");
            else
                Map.Broadcast(8, $"<size=33><color=red>폭파 절차</color>가 취소되었습니다. 시스템을 재가동합니다. 중지한사람: {ev.Player.Nickname}</size> ");
        }

        [PluginEvent]
        public void OnWarheadDetonation(WarheadDetonationEvent ev)
        {
            Map.Broadcast(8, $"<size=40><color=red>핵폭탄</color>이 터졌습니다.</size>");
        }

        [PluginEvent(ServerEventType.CassieAnnouncesScpTermination)]
        void OnCassieAnnouncScpTermination(Player scp, DamageHandlerBase damage, string announcement)
        {
            Map.Broadcast(5, $"{scp.Role}이 격리되었습니다 원인 {damage}");
        }


        [PluginEvent(ServerEventType.PlayerDeath)]
        void OnPlayerDied(Player player, Player attacker, DamageHandlerBase damageHandler)
        {
            if (attacker == null)
                Log.Info($"{player.Nickname} 사망, 원인 {damageHandler}");
            else
                player.SendBroadcast($"{attacker.Nickname}/(역할: {attacker.Role})가 {player.Nickname}/(역할: {player.Role})님을 죽였습니다.", 5);
        }




    }

}









