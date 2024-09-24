using AltV.Net.Events;

namespace AltV.Net
{
    public static partial class Alt
    {
        public static event CheckpointDelegate OnCheckpoint
        {
            add => ((Core)CoreImpl).CheckpointEventHandler.Add(value);
            remove => ((Core)CoreImpl).CheckpointEventHandler.Remove(value);
        }

        /// <summary>
        /// Player connect event handler
        /// <example>
        /// <code>
        /// Alt.OnPlayerConnect += (player, reason) => {
        ///   Console.WriteLine($"{player.Name} connected.");
        /// };
        /// </code>
        /// </example>
        /// </summary>
        public static event PlayerConnectDelegate OnPlayerConnect
        {
            add => ((Core)CoreImpl).PlayerConnectEventHandler.Add(value);
            remove => ((Core)CoreImpl).PlayerConnectEventHandler.Remove(value);
        }

        public static event BaseObjectCreateDelegate OnBaseObjectCreate
        {
            add => ((Core)CoreImpl).BaseObjectCreateEventHandler.Add(value);
            remove => ((Core)CoreImpl).BaseObjectCreateEventHandler.Remove(value);
        }

        public static event BaseObjectRemoveDelegate OnBaseObjectRemove
        {
            add => ((Core)CoreImpl).BaseObjectRemoveEventHandler.Add(value);
            remove => ((Core)CoreImpl).BaseObjectRemoveEventHandler.Remove(value);
        }

        public static event PlayerConnectDeniedDelegate OnPlayerConnectDenied
        {
            add => ((Core)CoreImpl).PlayerConnectDeniedEventHandler.Add(value);
            remove => ((Core)CoreImpl).PlayerConnectDeniedEventHandler.Remove(value);
        }

        public static event ResourceEventDelegate OnAnyResourceStart
        {
            add => ((Core)CoreImpl).ResourceStartEventHandler.Add(value);
            remove => ((Core)CoreImpl).ResourceStartEventHandler.Remove(value);
        }

        public static event ResourceEventDelegate OnAnyResourceStop
        {
            add => ((Core)CoreImpl).ResourceStopEventHandler.Add(value);
            remove => ((Core)CoreImpl).ResourceStopEventHandler.Remove(value);
        }

        public static event ResourceEventDelegate OnAnyResourceError
        {
            add => ((Core)CoreImpl).ResourceErrorEventHandler.Add(value);
            remove => ((Core)CoreImpl).ResourceErrorEventHandler.Remove(value);
        }

        public static event PlayerDamageDelegate OnPlayerDamage
        {
            add => ((Core)CoreImpl).PlayerDamageEventHandler.Add(value);
            remove => ((Core)CoreImpl).PlayerDamageEventHandler.Remove(value);
        }

        public static event PlayerDeadDelegate OnPlayerDead
        {
            add => ((Core)CoreImpl).PlayerDeadEventHandler.Add(value);
            remove => ((Core)CoreImpl).PlayerDeadEventHandler.Remove(value);
        }

        public static event PlayerHealDelegate OnPlayerHeal
        {
            add => ((Core)CoreImpl).PlayerHealEventHandler.Add(value);
            remove => ((Core)CoreImpl).PlayerHealEventHandler.Remove(value);
        }

        public static event ExplosionDelegate OnExplosion
        {
            add => ((Core)CoreImpl).ExplosionEventHandler.Add(value);
            remove => ((Core)CoreImpl).ExplosionEventHandler.Remove(value);
        }

        /// <summary>
        /// Weapon damage event handler
        /// <example>
        /// <code>
        /// Alt.OnWeaponDamage += (player, target, weapon, damage, shotOffset, bodyPart) => {
        ///   Console.WriteLine($"{player.Name} got damaged.");
        ///   return true; // return false will cancel the weapon damage event and player won't receive damage.
        ///   return 5; // return a number will set the new damage
        /// };
        /// </code>
        /// </example>
        /// </summary>
        public static event WeaponDamageDelegate OnWeaponDamage
        {
            add => ((Core)CoreImpl).WeaponDamageEventHandler.Add(value);
            remove => ((Core)CoreImpl).WeaponDamageEventHandler.Remove(value);
        }

        public static event PlayerDisconnectDelegate OnPlayerDisconnect
        {
            add => ((Core)CoreImpl).PlayerDisconnectEventHandler.Add(value);
            remove => ((Core)CoreImpl).PlayerDisconnectEventHandler.Remove(value);
        }

        public static event PlayerRemoveDelegate OnPlayerRemove
        {
            add => ((Core)CoreImpl).PlayerRemoveEventHandler.Add(value);
            remove => ((Core)CoreImpl).PlayerRemoveEventHandler.Remove(value);
        }

        public static event VehicleRemoveDelegate OnVehicleRemove
        {
            add => ((Core)CoreImpl).VehicleRemoveEventHandler.Add(value);
            remove => ((Core)CoreImpl).VehicleRemoveEventHandler.Remove(value);
        }

        public static event PedRemoveDelegate OnPedRemove
        {
            add => ((Core)CoreImpl).PedRemoveEventHandler.Add(value);
            remove => ((Core)CoreImpl).PedRemoveEventHandler.Remove(value);
        }

        public static event PlayerChangeVehicleSeatDelegate OnPlayerChangeVehicleSeat
        {
            add => ((Core)CoreImpl).PlayerChangeVehicleSeatEventHandler.Add(value);
            remove => ((Core)CoreImpl).PlayerChangeVehicleSeatEventHandler.Remove(value);
        }

        public static event PlayerEnterVehicleDelegate OnPlayerEnterVehicle
        {
            add => ((Core)CoreImpl).PlayerEnterVehicleEventHandler.Add(value);
            remove => ((Core)CoreImpl).PlayerEnterVehicleEventHandler.Remove(value);
        }

        public static event PlayerEnteringVehicleDelegate OnPlayerEnteringVehicle
        {
            add => ((Core)CoreImpl).PlayerEnteringVehicleEventHandler.Add(value);
            remove => ((Core)CoreImpl).PlayerEnteringVehicleEventHandler.Remove(value);
        }

        public static event PlayerLeaveVehicleDelegate OnPlayerLeaveVehicle
        {
            add => ((Core)CoreImpl).PlayerLeaveVehicleEventHandler.Add(value);
            remove => ((Core)CoreImpl).PlayerLeaveVehicleEventHandler.Remove(value);
        }

        public static event PlayerClientEventDelegate OnPlayerEvent
        {
            add => ((Core)CoreImpl).PlayerClientEventEventHandler.Add(value);
            remove => ((Core)CoreImpl).PlayerClientEventEventHandler.Remove(value);
        }

        public static event PlayerClientCustomEventDelegate OnPlayerCustomEvent
        {
            add => ((Core)CoreImpl).PlayerClientCustomEventEventHandler.Add(value);
            remove => ((Core)CoreImpl).PlayerClientCustomEventEventHandler.Remove(value);
        }

        public static event ServerEventEventDelegate OnServerEvent
        {
            add => ((Core)CoreImpl).ServerEventEventHandler.Add(value);
            remove => ((Core)CoreImpl).ServerEventEventHandler.Remove(value);
        }

        public static event ServerCustomEventEventDelegate OnServerCustomEvent
        {
            add => ((Core)CoreImpl).ServerCustomEventEventHandler.Add(value);
            remove => ((Core)CoreImpl).ServerCustomEventEventHandler.Remove(value);
        }

        public static event ConsoleCommandDelegate OnConsoleCommand
        {
            add => ((Core)CoreImpl).ConsoleCommandEventHandler.Add(value);
            remove => ((Core)CoreImpl).ConsoleCommandEventHandler.Remove(value);
        }

        /// <summary>
        /// Event that is invoked when the meta data of an entity has changed.
        /// </summary>
        /// <remarks>Meta data is accessible across different serverside resources.</remarks>
        public static event MetaDataChangeDelegate OnMetaDataChange
        {
            add => ((Core)CoreImpl).MetaDataChangeEventHandler.Add(value);
            remove => ((Core)CoreImpl).MetaDataChangeEventHandler.Remove(value);
        }

        /// <summary>
        /// Event that is invoked when the synced meta data of an entity has changed.
        /// </summary>
        /// <remarks>Synced meta data is accessible across different serverside resources and to all clients without range limitation.</remarks>
        public static event MetaDataChangeDelegate OnSyncedMetaDataChange
        {
            add => ((Core)CoreImpl).SyncedMetaDataChangeEventHandler.Add(value);
            remove => ((Core)CoreImpl).SyncedMetaDataChangeEventHandler.Remove(value);
        }

        public static event ColShapeDelegate OnColShape
        {
            add => ((Core)CoreImpl).ColShapeEventHandler.Add(value);
            remove => ((Core)CoreImpl).ColShapeEventHandler.Remove(value);
        }

        public static event VehicleDestroyDelegate OnVehicleDestroy
        {
            add => ((Core)CoreImpl).VehicleDestroyEventHandler.Add(value);
            remove => ((Core)CoreImpl).VehicleDestroyEventHandler.Remove(value);
        }

        public static event FireDelegate OnFire
        {
            add => ((Core)CoreImpl).FireEventHandler.Add(value);
            remove => ((Core)CoreImpl).FireEventHandler.Remove(value);
        }

        public static event StartProjectileDelegate OnStartProjectile
        {
            add => ((Core)CoreImpl).StartProjectileEventHandler.Add(value);
            remove => ((Core)CoreImpl).StartProjectileEventHandler.Remove(value);
        }

        public static event PlayerWeaponChangeDelegate OnPlayerWeaponChange
        {
            add => ((Core)CoreImpl).PlayerWeaponChangeEventHandler.Add(value);
            remove => ((Core)CoreImpl).PlayerWeaponChangeEventHandler.Remove(value);
        }

        public static event NetOwnerChangeDelegate OnNetworkOwnerChange
        {
            add => ((Core)CoreImpl).NetOwnerChangeEventHandler.Add(value);
            remove => ((Core)CoreImpl).NetOwnerChangeEventHandler.Remove(value);
        }

        public static event VehicleAttachDelegate OnVehicleAttach
        {
            add => ((Core)CoreImpl).VehicleAttachEventHandler.Add(value);
            remove => ((Core)CoreImpl).VehicleAttachEventHandler.Remove(value);
        }

        public static event VehicleDetachDelegate OnVehicleDetach
        {
            add => ((Core)CoreImpl).VehicleDetachEventHandler.Add(value);
            remove => ((Core)CoreImpl).VehicleDetachEventHandler.Remove(value);
        }

        public static event VehicleDamageDelegate OnVehicleDamage
        {
            add => ((Core)CoreImpl).VehicleDamageEventHandler.Add(value);
            remove => ((Core)CoreImpl).VehicleDamageEventHandler.Remove(value);
        }

        public static event VehicleHornDelegate OnVehicleHorn
        {
            add => ((Core)CoreImpl).VehicleHornEventHandler.Add(value);
            remove => ((Core)CoreImpl).VehicleHornEventHandler.Remove(value);
        }

        public static event ConnectionQueueAddDelegate OnConnectionQueueAdd
        {
            add => ((Core)CoreImpl).ConnectionQueueAddHandler.Add(value);
            remove => ((Core)CoreImpl).ConnectionQueueAddHandler.Remove(value);
        }

        public static event ConnectionQueueRemoveDelegate OnConnectionQueueRemove
        {
            add => ((Core)CoreImpl).ConnectionQueueRemoveHandler.Add(value);
            remove => ((Core)CoreImpl).ConnectionQueueRemoveHandler.Remove(value);
        }

        public static event ServerStartedDelegate OnServerStarted
        {
            add => ((Core)CoreImpl).ServerStartedHandler.Add(value);
            remove => ((Core)CoreImpl).ServerStartedHandler.Remove(value);
        }

        public static event PlayerRequestControlDelegate OnPlayerRequestControl
        {
            add => ((Core)CoreImpl).PlayerRequestControlHandler.Add(value);
            remove => ((Core)CoreImpl).PlayerRequestControlHandler.Remove(value);
        }

        public static event PlayerChangeAnimationDelegate OnPlayerChangeAnimation
        {
            add => ((Core)CoreImpl).PlayerChangeAnimationHandler.Add(value);
            remove => ((Core)CoreImpl).PlayerChangeAnimationHandler.Remove(value);
        }

        public static event PlayerChangeInteriorDelegate OnPlayerChangeInterior
        {
            add => ((Core)CoreImpl).PlayerChangeInteriorHandler.Add(value);
            remove => ((Core)CoreImpl).PlayerChangeInteriorHandler.Remove(value);
        }

        public static event PlayerDimensionChangeDelegate OnPlayerDimensionChange
        {
            add => ((Core)CoreImpl).PlayerDimensionChangeHandler.Add(value);
            remove => ((Core)CoreImpl).PlayerDimensionChangeHandler.Remove(value);
        }

        public static event VehicleSirenDelegate OnVehicleSiren
        {
            add => ((Core)CoreImpl).VehicleSirenHandler.Add(value);
            remove => ((Core)CoreImpl).VehicleSirenHandler.Remove(value);
        }

        public static event PlayerSpawnDelegate OnPlayerSpawn
        {
            add => ((Core)CoreImpl).PlayerSpawnHandler.Add(value);
            remove => ((Core)CoreImpl).PlayerSpawnHandler.Remove(value);
        }

        public static event RequestSyncedSceneDelegate OnRequestSyncScene
        {
            add => ((Core)CoreImpl).RequestSyncedSceneHandler.Add(value);
            remove => ((Core)CoreImpl).RequestSyncedSceneHandler.Remove(value);
        }

        public static event StartSyncedSceneDelegate OnStartSyncedScene
        {
            add => ((Core)CoreImpl).StartSyncedSceneHandler.Add(value);
            remove => ((Core)CoreImpl).StartSyncedSceneHandler.Remove(value);
        }

        public static event StopSyncedSceneDelegate OnStopSyncedScene
        {
            add => ((Core)CoreImpl).StopSyncedSceneHandler.Add(value);
            remove => ((Core)CoreImpl).StopSyncedSceneHandler.Remove(value);
        }

        public static event UpdateSyncedSceneDelegate OnUpdateSyncedScene
        {
            add => ((Core)CoreImpl).UpdateSyncedSceneHandler.Add(value);
            remove => ((Core)CoreImpl).UpdateSyncedSceneHandler.Remove(value);
        }

        public static event ClientRequestObjectDelegate OnClientRequestObject
        {
            add => ((Core)CoreImpl).ClientRequestObjectHandler.Add(value);
            remove => ((Core)CoreImpl).ClientRequestObjectHandler.Remove(value);
        }

        public static event ClientDeleteObjectDelegate OnClientDeleteObject
        {
            add => ((Core)CoreImpl).ClientDeleteObjectHandler.Add(value);
            remove => ((Core)CoreImpl).ClientDeleteObjectHandler.Remove(value);
        }

        public static event GivePedScriptedTaskDelegate OnGivePedScriptedTask
        {
            add => ((Core)CoreImpl).GivePedScriptedTaskHandler.Add(value);
            remove => ((Core)CoreImpl).GivePedScriptedTaskHandler.Remove(value);
        }

        public static event PedDamageDelegate OnPedDamage
        {
            add => ((Core)CoreImpl).PedDamageEventHandler.Add(value);
            remove => ((Core)CoreImpl).PedDamageEventHandler.Remove(value);
        }

        public static event PedDeadDelegate OnPedDead
        {
            add => ((Core)CoreImpl).PedDeadEventHandler.Add(value);
            remove => ((Core)CoreImpl).PedDeadEventHandler.Remove(value);
        }

        public static event PedHealDelegate OnPedHeal
        {
            add => ((Core)CoreImpl).PedHealEventHandler.Add(value);
            remove => ((Core)CoreImpl).PedHealEventHandler.Remove(value);
        }

        public static event PlayerStartTalkingDelegate OnPlayerStartTalking
        {
            add => ((Core)CoreImpl).PlayerStartTalkingHandler.Add(value);
            remove => ((Core)CoreImpl).PlayerStartTalkingHandler.Remove(value);
        }

        public static event PlayerStopTalkingDelegate OnPlayerStopTalking
        {
            add => ((Core)CoreImpl).PlayerStopTalkingHandler.Add(value);
            remove => ((Core)CoreImpl).PlayerStopTalkingHandler.Remove(value);
        }

        public static event ScriptRpcDelegate OnScriptRPC
        {
            add => ((Core)CoreImpl).ScriptRpcHandler.Add(value);
            remove => ((Core)CoreImpl).ScriptRpcHandler.Remove(value);
        }

        public static event ScriptRpcAnswerDelegate OnScriptRPCAnswer
        {
            add => ((Core)CoreImpl).ScriptRpcAnswerHandler.Add(value);
            remove => ((Core)CoreImpl).ScriptRpcAnswerHandler.Remove(value);
        }
    }
}