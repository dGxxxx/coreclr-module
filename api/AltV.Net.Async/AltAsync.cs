using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using AltV.Net.Async.Events;
using AltV.Net.Elements.Args;
using AltV.Net.Events;
using AltV.Net.Native;
using AltV.Net.Shared.Utils;

namespace AltV.Net.Async
{
    public static partial class AltAsync
    {
        internal static AsyncCore CoreImpl;

        internal static AltVAsync AltVAsync;

        public static event CheckpointAsyncDelegate OnCheckpoint
        {
            add => CoreImpl.CheckpointAsyncEventHandler.Add(value);
            remove => CoreImpl.CheckpointAsyncEventHandler.Remove(value);
        }

        public static event BaseObjectCreateAsyncDelegate OnBaseObjectCreate
        {
            add => CoreImpl.BaseObjectCreateAsyncEventHandler.Add(value);
            remove => CoreImpl.BaseObjectCreateAsyncEventHandler.Remove(value);
        }

        public static event BaseObjectRemoveAsyncDelegate OnBaseObjectRemove
        {
            add => CoreImpl.BaseObjectRemoveAsyncEventHandler.Add(value);
            remove => CoreImpl.BaseObjectRemoveAsyncEventHandler.Remove(value);
        }

        public static event PlayerConnectAsyncDelegate OnPlayerConnect
        {
            add => CoreImpl.PlayerConnectAsyncEventHandler.Add(value);
            remove => CoreImpl.PlayerConnectAsyncEventHandler.Remove(value);
        }

        public static event PlayerDamageAsyncDelegate OnPlayerDamage
        {
            add => CoreImpl.PlayerDamageAsyncEventHandler.Add(value);
            remove => CoreImpl.PlayerDamageAsyncEventHandler.Remove(value);
        }

        public static event PlayerDeadAsyncDelegate OnPlayerDead
        {
            add => CoreImpl.PlayerDeadAsyncEventHandler.Add(value);
            remove => CoreImpl.PlayerDeadAsyncEventHandler.Remove(value);
        }

        public static event PlayerHealAsyncDelegate OnPlayerHeal
        {
            add => CoreImpl.PlayerHealAsyncEventHandler.Add(value);
            remove => CoreImpl.PlayerHealAsyncEventHandler.Remove(value);
        }

        public static event ExplosionAsyncDelegate OnExplosion
        {
            add => CoreImpl.ExplosionAsyncEventHandler.Add(value);
            remove => CoreImpl.ExplosionAsyncEventHandler.Remove(value);
        }

        public static event WeaponDamageAsyncDelegate OnWeaponDamage
        {
            add => CoreImpl.WeaponDamageAsyncEventHandler.Add(value);
            remove => CoreImpl.WeaponDamageAsyncEventHandler.Remove(value);
        }

        public static event PlayerChangeVehicleSeatAsyncDelegate OnPlayerChangeVehicleSeat
        {
            add => CoreImpl.PlayerChangeVehicleSeatAsyncEventHandler.Add(value);
            remove => CoreImpl.PlayerChangeVehicleSeatAsyncEventHandler.Remove(value);
        }

        public static event PlayerEnterVehicleAsyncDelegate OnPlayerEnterVehicle
        {
            add => CoreImpl.PlayerEnterVehicleAsyncEventHandler.Add(value);
            remove => CoreImpl.PlayerEnterVehicleAsyncEventHandler.Remove(value);
        }

        public static event PlayerEnteringVehicleAsyncDelegate OnPlayerEnteringVehicle
        {
            add => CoreImpl.PlayerEnteringVehicleAsyncEventHandler.Add(value);
            remove => CoreImpl.PlayerEnteringVehicleAsyncEventHandler.Remove(value);
        }

        public static event PlayerLeaveVehicleAsyncDelegate OnPlayerLeaveVehicle
        {
            add => CoreImpl.PlayerLeaveVehicleAsyncEventHandler.Add(value);
            remove => CoreImpl.PlayerLeaveVehicleAsyncEventHandler.Remove(value);
        }

        public static event PlayerDisconnectAsyncDelegate OnPlayerDisconnect
        {
            add => CoreImpl.PlayerDisconnectAsyncEventHandler.Add(value);
            remove => CoreImpl.PlayerDisconnectAsyncEventHandler.Remove(value);
        }

        public static event PlayerRemoveAsyncDelegate OnPlayerRemove
        {
            add => CoreImpl.PlayerRemoveAsyncEventHandler.Add(value);
            remove => CoreImpl.PlayerRemoveAsyncEventHandler.Remove(value);
        }

        public static event VehicleRemoveAsyncDelegate OnVehicleRemove
        {
            add => CoreImpl.VehicleRemoveAsyncEventHandler.Add(value);
            remove => CoreImpl.VehicleRemoveAsyncEventHandler.Remove(value);
        }

        public static event PedRemoveAsyncDelegate OnPedRemove
        {
            add => CoreImpl.PedRemoveAsyncEventHandler.Add(value);
            remove => CoreImpl.PedRemoveAsyncEventHandler.Remove(value);
        }

        public static event PlayerClientEventAsyncDelegate OnPlayerEvent
        {
            add => CoreImpl.PlayerClientEventAsyncEventHandler.Add(value);
            remove => CoreImpl.PlayerClientEventAsyncEventHandler.Remove(value);
        }

        public static event ConsoleCommandAsyncDelegate OnConsoleCommand
        {
            add => CoreImpl.ConsoleCommandAsyncEventHandler.Add(value);
            remove => CoreImpl.ConsoleCommandAsyncEventHandler.Remove(value);
        }

        public static event MetaDataChangeAsyncDelegate OnMetaDataChange
        {
            add => CoreImpl.MetaDataChangeAsyncEventHandler.Add(value);
            remove => CoreImpl.MetaDataChangeAsyncEventHandler.Remove(value);
        }

        public static event MetaDataChangeAsyncDelegate OnSyncedMetaDataChange
        {
            add => CoreImpl.SyncedMetaDataChangeAsyncEventHandler.Add(value);
            remove => CoreImpl.SyncedMetaDataChangeAsyncEventHandler.Remove(value);
        }

        public static event ColShapeAsyncDelegate OnColShape
        {
            add => CoreImpl.ColShapeAsyncEventHandler.Add(value);
            remove => CoreImpl.ColShapeAsyncEventHandler.Remove(value);
        }

        public static event VehicleDestroyAsyncDelegate OnVehicleDestroy
        {
            add => CoreImpl.VehicleDestroyAsyncEventHandler.Add(value);
            remove => CoreImpl.VehicleDestroyAsyncEventHandler.Remove(value);
        }

        public static event FireAsyncDelegate OnFire
        {
            add => CoreImpl.FireAsyncEventHandler.Add(value);
            remove => CoreImpl.FireAsyncEventHandler.Remove(value);
        }

        public static event StartProjectileAsyncDelegate OnStartProjectile
        {
            add => CoreImpl.StartProjectileAsyncEventHandler.Add(value);
            remove => CoreImpl.StartProjectileAsyncEventHandler.Remove(value);
        }

        public static event PlayerWeaponChangeAsyncDelegate OnPlayerWeaponChange
        {
            add => CoreImpl.PlayerWeaponChangeAsyncEventHandler.Add(value);
            remove => CoreImpl.PlayerWeaponChangeAsyncEventHandler.Remove(value);
        }

        public static event NetOwnerChangeAsyncDelegate OnNetworkOwnerChange
        {
            add => CoreImpl.NetOwnerChangeAsyncEventHandler.Add(value);
            remove => CoreImpl.NetOwnerChangeAsyncEventHandler.Remove(value);
        }

        public static event VehicleAttachAsyncDelegate OnVehicleAttach
        {
            add => CoreImpl.VehicleAttachAsyncEventHandler.Add(value);
            remove => CoreImpl.VehicleAttachAsyncEventHandler.Remove(value);
        }

        public static event VehicleDetachAsyncDelegate OnVehicleDetach
        {
            add => CoreImpl.VehicleDetachAsyncEventHandler.Add(value);
            remove => CoreImpl.VehicleDetachAsyncEventHandler.Remove(value);
        }

        public static event VehicleDamageAsyncDelegate OnVehicleDamage
        {
            add => CoreImpl.VehicleDamageAsyncEventHandler.Add(value);
            remove => CoreImpl.VehicleDamageAsyncEventHandler.Remove(value);
        }

        public static event VehicleHornAsyncDelegate OnVehicleHorn
        {
            add => CoreImpl.VehicleHornAsyncEventHandler.Add(value);
            remove => CoreImpl.VehicleHornAsyncEventHandler.Remove(value);
        }

        public static event ConnectionQueueAddAsyncDelegate OnConnectionQueueAdd
        {
            add => CoreImpl.ConnectionQueueAddAsyncEventHandler.Add(value);
            remove => CoreImpl.ConnectionQueueAddAsyncEventHandler.Remove(value);
        }

        public static event ConnectionQueueRemoveAsyncDelegate OnConnectionQueueRemove
        {
            add => CoreImpl.ConnectionQueueRemoveAsyncEventHandler.Add(value);
            remove => CoreImpl.ConnectionQueueRemoveAsyncEventHandler.Remove(value);
        }

        public static event ServerStartedAsyncDelegate OnServerStarted
        {
            add => CoreImpl.ServerStartedAsyncEventHandler.Add(value);
            remove => CoreImpl.ServerStartedAsyncEventHandler.Remove(value);
        }

        public static event PlayerRequestControlAsyncDelegate OnPlayerRequestControl
        {
            add => CoreImpl.PlayerRequestControlAsyncEventHandler.Add(value);
            remove => CoreImpl.PlayerRequestControlAsyncEventHandler.Remove(value);
        }

        public static event PlayerChangeAnimationAsyncDelegate OnPlayerChangeAnimation
        {
            add => CoreImpl.PlayerChangeAnimationAsyncEventHandler.Add(value);
            remove => CoreImpl.PlayerChangeAnimationAsyncEventHandler.Remove(value);
        }

        public static event PlayerChangeInteriorAsyncDelegate OnPlayerChangeInterior
        {
            add => CoreImpl.PlayerChangeInteriorAsyncEventHandler.Add(value);
            remove => CoreImpl.PlayerChangeInteriorAsyncEventHandler.Remove(value);
        }

        public static event PlayerDimensionChangeAsyncDelegate OnPlayerDimensionChange
        {
            add => CoreImpl.PlayerDimensionChangeAsyncEventHandler.Add(value);
            remove => CoreImpl.PlayerDimensionChangeAsyncEventHandler.Remove(value);
        }

        public static event VehicleSirenAsyncDelegate OnVehicleSiren
        {
            add => CoreImpl.VehicleSirenAsyncEventHandler.Add(value);
            remove => CoreImpl.VehicleSirenAsyncEventHandler.Remove(value);
        }

        public static event PlayerSpawnAsyncDelegate OnPlayerSpawn
        {
            add => CoreImpl.PlayerSpawnAsyncEventHandler.Add(value);
            remove => CoreImpl.PlayerSpawnAsyncEventHandler.Remove(value);
        }

        public static event RequestSyncedSceneAsyncEventDelegate OnRequestSyncedScene
        {
            add => CoreImpl.RequestSyncedSceneAsyncEventHandler.Add(value);
            remove => CoreImpl.RequestSyncedSceneAsyncEventHandler.Remove(value);
        }

        public static event StartSyncedSceneAsyncEventDelegate OnStartSyncedScene
        {
            add => CoreImpl.StartSyncedSceneAsyncEventHandler.Add(value);
            remove => CoreImpl.StartSyncedSceneAsyncEventHandler.Remove(value);
        }

        public static event StopSyncedSceneAsyncEventDelegate OnStopSyncedScene
        {
            add => CoreImpl.StopSyncedSceneAsyncEventHandler.Add(value);
            remove => CoreImpl.StopSyncedSceneAsyncEventHandler.Remove(value);
        }

        public static event UpdateSyncedSceneAsyncEventDelegate OnUpdateSyncedScene
        {
            add => CoreImpl.UpdateSyncedSceneAsyncEventHandler.Add(value);
            remove => CoreImpl.UpdateSyncedSceneAsyncEventHandler.Remove(value);
        }

        public static event ClientRequestObjectAsyncEventDelegate OnClientRequestObject
        {
            add => CoreImpl.ClientRequestObjectAsyncEventHandler.Add(value);
            remove => CoreImpl.ClientRequestObjectAsyncEventHandler.Remove(value);
        }

        public static event ClientDeleteObjectAsyncEventDelegate OnClientDeleteObject
        {
            add => CoreImpl.ClientDeleteObjectAsyncEventHandler.Add(value);
            remove => CoreImpl.ClientDeleteObjectAsyncEventHandler.Remove(value);
        }

        public static event GivePedScriptedTaskAsyncDelegate OnGivePedScriptedTask
        {
            add => CoreImpl.GivePedScriptedTaskAsyncEventHandler.Add(value);
            remove => CoreImpl.GivePedScriptedTaskAsyncEventHandler.Remove(value);
        }

        public static event PedDamageAsyncDelegate OnPedDamage
        {
            add => CoreImpl.PedDamageAsyncEventHandler.Add(value);
            remove => CoreImpl.PedDamageAsyncEventHandler.Remove(value);
        }

        public static event PedDeadAsyncDelegate OnPedDead
        {
            add => CoreImpl.PedDeadAsyncEventHandler.Add(value);
            remove => CoreImpl.PedDeadAsyncEventHandler.Remove(value);
        }

        public static event PedHealAsyncDelegate OnPedHeal
        {
            add => CoreImpl.PedHealAsyncEventHandler.Add(value);
            remove => CoreImpl.PedHealAsyncEventHandler.Remove(value);
        }

        public static event PlayerStartTalkingAsyncDelegate OnPlayerStartTalking
        {
            add => CoreImpl.PlayerStartTalkingAsyncEventHandler.Add(value);
            remove => CoreImpl.PlayerStartTalkingAsyncEventHandler.Remove(value);
        }

        public static event PlayerStopTalkingAsyncDelegate OnPlayerStopTalking
        {
            add => CoreImpl.PlayerStopTalkingAsyncEventHandler.Add(value);
            remove => CoreImpl.PlayerStopTalkingAsyncEventHandler.Remove(value);
        }

        public static event ScriptRpcAsyncDelegate OnScriptRpc
        {
            add => CoreImpl.ScriptRpcAsyncEventHandler.Add(value);
            remove => CoreImpl.ScriptRpcAsyncEventHandler.Remove(value);
        }

        public static event ScriptRpcAnswerAsyncDelegate OnScriptRpcAnswer
        {
            add => CoreImpl.ScriptRpcAnswerAsyncEventHandler.Add(value);
            remove => CoreImpl.ScriptRpcAnswerAsyncEventHandler.Remove(value);
        }

        public static event PlayerConnectDeniedAsyncDelegate OnPlayerConnectDenied
        {
            add => CoreImpl.PlayerConnectDeniedAsyncEventHandler.Add(value);
            remove => CoreImpl.PlayerConnectDeniedAsyncEventHandler.Remove(value);
        }

        public static event ResourceEventAsyncDelegate OnResourceStart
        {
            add => CoreImpl.ResourceStartAsyncEventHandler.Add(value);
            remove => CoreImpl.ResourceStartAsyncEventHandler.Remove(value);
        }

        public static event ResourceEventAsyncDelegate OnResourceStop
        {
            add => CoreImpl.ResourceStopAsyncEventHandler.Add(value);
            remove => CoreImpl.ResourceStopAsyncEventHandler.Remove(value);
        }

        public static event ResourceEventAsyncDelegate OnResourceError
        {
            add => CoreImpl.ResourceErrorAsyncEventHandler.Add(value);
            remove => CoreImpl.ResourceErrorAsyncEventHandler.Remove(value);
        }

        public static async void Log(string message)
        {
            var messagePtr = MemoryUtils.StringToHGlobalUtf8(message);
            await Do(() => Alt.CoreImpl.LogInfo(messagePtr));
            Marshal.FreeHGlobal(messagePtr);
        }

        public static async void Emit(string eventName, params object[] args)
        {
            var size = args.Length;
            var mValues = new MValueConst[size];
            Alt.CoreImpl.CreateMValues(mValues, args);
            var eventNamePtr = MemoryUtils.StringToHGlobalUtf8(eventName);
            await Do(() => Alt.CoreImpl.TriggerLocalEvent(eventNamePtr, mValues));
            Marshal.FreeHGlobal(eventNamePtr);
            for (var i = 0; i < size; i++)
            {
                mValues[i].Dispose();
            }
        }

        public static async void EmitAllClients(string eventName, params object[] args)
        {
            var size = args.Length;
            var mValues = new MValueConst[size];
            Alt.CoreImpl.CreateMValues(mValues, args);
            var eventNamePtr = MemoryUtils.StringToHGlobalUtf8(eventName);
            await Do(() => Alt.CoreImpl.TriggerClientEventForAll(eventNamePtr, mValues));
            Marshal.FreeHGlobal(eventNamePtr);
            for (var i = 0; i < size; i++)
            {
                mValues[i].Dispose();
            }
        }

        public static async void EmitUnreliableAllClients(string eventName, params object[] args)
        {
            var size = args.Length;
            var mValues = new MValueConst[size];
            Alt.CoreImpl.CreateMValues(mValues, args);
            var eventNamePtr = MemoryUtils.StringToHGlobalUtf8(eventName);
            await Do(() => Alt.CoreImpl.TriggerClientEventUnreliableForAll(eventNamePtr, mValues));
            Marshal.FreeHGlobal(eventNamePtr);
            for (var i = 0; i < size; i++)
            {
                mValues[i].Dispose();
            }
        }

        [Conditional("DEBUG")]
        private static void CheckIfAsyncResource()
        {
            if (AltVAsync == null)
            {
                throw new InvalidOperationException(
                    "Resource doesn't extends AsyncResource. Please read https://fabianterhorst.github.io/coreclr-module/articles/async.html#setup-async-module");
            }
        }

        internal static void Setup(AltVAsync altVAsync)
        {
            AltVAsync = altVAsync;
        }

        internal static void Setup(AsyncCore core)
        {
            CoreImpl = core;
        }

        public static Task Do(Action action)
        {
            CheckIfAsyncResource();
            return AltVAsync.Schedule(action);
        }

        public static Task Do(Task task)
        {
            throw new ArgumentException("AltAsync.Do should never have async code inside");
        }

        public static Task Do(Func<Task> task)
        {
            throw new ArgumentException("AltAsync.Do should never have async code inside");
        }

        public static void RunOnMainThreadBlocking(Action action, SemaphoreSlim semaphoreSlim)
        {
            CheckIfAsyncResource();
            AltVAsync.ScheduleBlocking(action, semaphoreSlim);
        }

        public static void RunOnMainThreadBlockingThrows(Action action, SemaphoreSlim semaphoreSlim)
        {
            CheckIfAsyncResource();
            AltVAsync.ScheduleBlockingThrows(action, semaphoreSlim);
        }

        public static Task Do(Action<object> action, object value)
        {
            CheckIfAsyncResource();
            return AltVAsync.Schedule(action, value);
        }

        public static Task<TResult> Do<TResult>(Func<TResult> action)
        {
            CheckIfAsyncResource();
            return AltVAsync.Schedule(action);
        }

        public static Task<TResult> Do<TResult>(Func<object, TResult> action, object value)
        {
            CheckIfAsyncResource();
            return AltVAsync.Schedule(action, value);
        }

        public static void RunOnMainThread(Action action)
        {
            CheckIfAsyncResource();
            AltVAsync.ScheduleNoneTask(action);
        }

        public static void RunOnMainThread(Action<object> action, object value)
        {
            CheckIfAsyncResource();
            AltVAsync.ScheduleNoneTask(action, value);
        }
    }
}