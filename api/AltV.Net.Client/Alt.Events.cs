using AltV.Net.CApi.ClientEvents;
using AltV.Net.Client.Elements.Interfaces;
using AltV.Net.Client.Elements.Pools;
using AltV.Net.Client.Events;
using AltV.Net.Elements.Args;

namespace AltV.Net.Client
{
    public partial class Alt
    {
        public static event TickDelegate OnTick
        {
            add => ((Core)CoreImpl).TickEventHandler.Add(value);
            remove => ((Core)CoreImpl).TickEventHandler.Remove(value);
        }

        public static event ConsoleCommandDelegate OnConsoleCommand
        {
            add => ((Core)CoreImpl).ConsoleCommandEventHandler.Add(value);
            remove => ((Core)CoreImpl).ConsoleCommandEventHandler.Remove(value);
        }

        public static event PlayerSpawnDelegate OnPlayerSpawn
        {
            add => ((Core)CoreImpl).SpawnEventHandler.Add(value);
            remove => ((Core)CoreImpl).SpawnEventHandler.Remove(value);
        }

        public static event PlayerDisconnectDelegate OnPlayerDisconnect
        {
            add => ((Core)CoreImpl).DisconnectEventHandler.Add(value);
            remove => ((Core)CoreImpl).DisconnectEventHandler.Remove(value);
        }

        public static event PlayerEnterVehicleDelegate OnPlayerEnterVehicle
        {
            add => ((Core)CoreImpl).EnterVehicleEventHandler.Add(value);
            remove => ((Core)CoreImpl).EnterVehicleEventHandler.Remove(value);
        }

        public static event GameEntityCreateDelegate OnGameEntityCreate
        {
            add => ((Core)CoreImpl).GameEntityCreateEventHandler.Add(value);
            remove => ((Core)CoreImpl).GameEntityCreateEventHandler.Remove(value);
        }

        public static event GameEntityDestroyDelegate OnGameEntityDestroy
        {
            add => ((Core)CoreImpl).GameEntityDestroyEventHandler.Add(value);
            remove => ((Core)CoreImpl).GameEntityDestroyEventHandler.Remove(value);
        }

        public static event AnyResourceErrorDelegate OnAnyResourceError
        {
            add => ((Core)CoreImpl).AnyResourceErrorEventHandler.Add(value);
            remove => ((Core)CoreImpl).AnyResourceErrorEventHandler.Remove(value);
        }

        public static event AnyResourceStartDelegate OnAnyResourceStart
        {
            add => ((Core)CoreImpl).AnyResourceStartEventHandler.Add(value);
            remove => ((Core)CoreImpl).AnyResourceStartEventHandler.Remove(value);
        }

        public static event AnyResourceStopDelegate OnAnyResourceStop
        {
            add => ((Core)CoreImpl).AnyResourceStopEventHandler.Add(value);
            remove => ((Core)CoreImpl).AnyResourceStopEventHandler.Remove(value);
        }

        public static event KeyUpDelegate OnKeyUp
        {
            add => ((Core)CoreImpl).KeyUpEventHandler.Add(value);
            remove => ((Core)CoreImpl).KeyUpEventHandler.Remove(value);
        }

        public static event KeyDownDelegate OnKeyDown
        {
            add => ((Core)CoreImpl).KeyDownEventHandler.Add(value);
            remove => ((Core)CoreImpl).KeyDownEventHandler.Remove(value);
        }

        public static event ConnectionCompleteDelegate OnConnectionComplete
        {
            add => ((Core)CoreImpl).ConnectionCompleteEventHandler.Add(value);
            remove => ((Core)CoreImpl).ConnectionCompleteEventHandler.Remove(value);
        }

        public static event PlayerChangeVehicleSeatDelegate OnPlayerChangeVehicleSeat
        {
            add => ((Core)CoreImpl).PlayerChangeVehicleSeatEventHandler.Add(value);
            remove => ((Core)CoreImpl).PlayerChangeVehicleSeatEventHandler.Remove(value);
        }

        public static event PlayerLeaveVehicleDelegate OnPlayerLeaveVehicle
        {
            add => ((Core)CoreImpl).PlayerLeaveVehicleEventHandler.Add(value);
            remove => ((Core)CoreImpl).PlayerLeaveVehicleEventHandler.Remove(value);
        }

        public static event PlayerWeaponShootDelegate OnPlayerWeaponShoot
        {
            add => ((Core)CoreImpl).PlayerWeaponShootEventHandler.Add(value);
            remove => ((Core)CoreImpl).PlayerWeaponShootEventHandler.Remove(value);
        }

        public static event PlayerWeaponChangeDelegate OnPlayerWeaponChange
        {
            add => ((Core)CoreImpl).PlayerWeaponChangeEventHandler.Add(value);
            remove => ((Core)CoreImpl).PlayerWeaponChangeEventHandler.Remove(value);
        }

        public static event GlobalMetaChangeDelegate OnGlobalMetaChange
        {
            add => ((Core)CoreImpl).GlobalMetaChangeEventHandler.Add(value);
            remove => ((Core)CoreImpl).GlobalMetaChangeEventHandler.Remove(value);
        }

        public static event GlobalSyncedMetaChangeDelegate OnGlobalSyncedMetaChange
        {
            add => ((Core)CoreImpl).GlobalSyncedMetaChangeEventHandler.Add(value);
            remove => ((Core)CoreImpl).GlobalSyncedMetaChangeEventHandler.Remove(value);
        }

        public static event LocalMetaChangeDelegate OnLocalMetaChange
        {
            add => ((Core)CoreImpl).LocalMetaChangeEventHandler.Add(value);
            remove => ((Core)CoreImpl).LocalMetaChangeEventHandler.Remove(value);
        }

        public static event StreamSyncedMetaChangeDelegate OnStreamSyncedMetaChange
        {
            add => ((Core)CoreImpl).StreamSyncedMetaChangeEventHandler.Add(value);
            remove => ((Core)CoreImpl).StreamSyncedMetaChangeEventHandler.Remove(value);
        }

        public static event SyncedMetaChangeDelegate OnSyncedMetaChange
        {
            add => ((Core)CoreImpl).SyncedMetaChangeEventHandler.Add(value);
            remove => ((Core)CoreImpl).SyncedMetaChangeEventHandler.Remove(value);
        }

        public static event TaskChangeDelegate OnTaskChange
        {
            add => ((Core)CoreImpl).TaskChangeEventHandler.Add(value);
            remove => ((Core)CoreImpl).TaskChangeEventHandler.Remove(value);
        }

        public static event WindowResolutionChangeDelegate OnWindowResolutionChange
        {
            add => ((Core)CoreImpl).WindowResolutionChangeEventHandler.Add(value);
            remove => ((Core)CoreImpl).WindowResolutionChangeEventHandler.Remove(value);
        }

        public static event WindowFocusChangeDelegate OnWindowFocusChange
        {
            add => ((Core)CoreImpl).WindowFocusChangeEventHandler.Add(value);
            remove => ((Core)CoreImpl).WindowFocusChangeEventHandler.Remove(value);
        }

        public static event RemoveEntityDelegate OnRemoveEntity
        {
            add => ((Core)CoreImpl).RemoveEntityEventHandler.Add(value);
            remove => ((Core)CoreImpl).RemoveEntityEventHandler.Remove(value);
        }

        public static event NetOwnerChangeDelegate OnNetOwnerChange
        {
            add => ((Core)CoreImpl).NetOwnerChangeEventHandler.Add(value);
            remove => ((Core)CoreImpl).NetOwnerChangeEventHandler.Remove(value);
        }

        public static event PlayerChangeAnimationDelegate OnPLayerChangeAnimation
        {
            add => ((Core)CoreImpl).PlayerChangeAnimationEventHandler.Add(value);
            remove => ((Core)CoreImpl).PlayerChangeAnimationEventHandler.Remove(value);
        }

        public static event PlayerChangeInteriorDelegate OnPlayerChangeInterior
        {
            add => ((Core)CoreImpl).PlayerChangeInteriorEventHandler.Add(value);
            remove => ((Core)CoreImpl).PlayerChangeInteriorEventHandler.Remove(value);
        }

        public static event WeaponDamageDelegate OnWeaponDamage
        {
            add => ((Core)CoreImpl).WeaponDamageEventHandler.Add(value);
            remove => ((Core)CoreImpl).WeaponDamageEventHandler.Remove(value);
        }

        public static event WorldObjectPositionChangeDelegate OnWorldObjectPositionChange
        {
            add => ((Core)CoreImpl).WorldObjectPositionChangeEventHandler.Add(value);
            remove => ((Core)CoreImpl).WorldObjectPositionChangeEventHandler.Remove(value);
        }

        public static event WorldObjectStreamInDelegate OnWorldObjectStreamIn
        {
            add => ((Core)CoreImpl).WorldObjectStreamInEventHandler.Add(value);
            remove => ((Core)CoreImpl).WorldObjectStreamInEventHandler.Remove(value);
        }

        public static event WorldObjectStreamOutDelegate OnWorldObjectStreamOut
        {
            add => ((Core)CoreImpl).WorldObjectStreamOutEventHandler.Add(value);
            remove => ((Core)CoreImpl).WorldObjectStreamOutEventHandler.Remove(value);
        }

        public static event ColShapeDelegate OnColShape
        {
            add => ((Core)CoreImpl).ColShapeEventHandler.Add(value);
            remove => ((Core)CoreImpl).ColShapeEventHandler.Remove(value);
        }

        public static event CheckpointDelegate OnCheckpoint
        {
            add => ((Core)CoreImpl).CheckpointEventHandler.Add(value);
            remove => ((Core)CoreImpl).CheckpointEventHandler.Remove(value);
        }

        public static event MetaChangeDelegate OnMetaChange
        {
            add => ((Core)CoreImpl).MetaChangeEventHandler.Add(value);
            remove => ((Core)CoreImpl).MetaChangeEventHandler.Remove(value);
        }


        public static event PlayerStartEnterVehicleDelegate OnPlayerStartEnterVehicle
        {
            add => ((Core)CoreImpl).PlayerStartEnterVehicleEventHandler.Add(value);
            remove => ((Core)CoreImpl).PlayerStartEnterVehicleEventHandler.Remove(value);
        }


        public static event PlayerStartLeaveVehicleDelegate OnPlayerStartLeaveVehicle
        {
            add => ((Core)CoreImpl).PlayerStartLeaveVehicleEventHandler.Add(value);
            remove => ((Core)CoreImpl).PlayerStartLeaveVehicleEventHandler.Remove(value);
        }


        public static event EntityHitEntityDelegate OnEntityHitEntity
        {
            add => ((Core)CoreImpl).EntityHitEntityEventHandler.Add(value);
            remove => ((Core)CoreImpl).EntityHitEntityEventHandler.Remove(value);
        }


        public static event PlayerBulletHitDelegate OnPlayerBulletHit
        {
            add => ((Core)CoreImpl).PlayerBulletHitEventHandler.Add(value);
            remove => ((Core)CoreImpl).PlayerBulletHitEventHandler.Remove(value);
        }

        public static event VoiceConnectionDelegate OnVoiceConnection
        {
            add => ((Core)CoreImpl).VoiceConnectionEventHandler.Add(value);
            remove => ((Core)CoreImpl).VoiceConnectionEventHandler.Remove(value);
        }

        public static event ScriptRPCAnswerDelegate OnScriptRPCAnswer
        {
            add => ((Core)CoreImpl).ScriptRPCAnswerHandler.Add(value);
            remove => ((Core)CoreImpl).ScriptRPCAnswerHandler.Remove(value);
        }

        public static event ScriptRPCDelegate OnScriptRPC
        {
            add => ((Core)CoreImpl).ScriptRPCHandler.Add(value);
            remove => ((Core)CoreImpl).ScriptRPCHandler.Remove(value);
        }

        public static Function OnServer(string eventName, Function function) => ((Core)CoreImpl).AddServerEventListener(eventName, function);

        public static Function OnServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(string eventName, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> function) => ((Core)CoreImpl).AddServerEventListener(eventName, Function.Create(CoreImpl, function));
        public static Function OnServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(string eventName, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> function) => ((Core)CoreImpl).AddServerEventListener(eventName, Function.Create(CoreImpl, function));
        public static Function OnServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(string eventName, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> function) => ((Core)CoreImpl).AddServerEventListener(eventName, Function.Create(CoreImpl, function));
        public static Function OnServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(string eventName, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> function) => ((Core)CoreImpl).AddServerEventListener(eventName, Function.Create(CoreImpl, function));
        public static Function OnServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(string eventName, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> function) => ((Core)CoreImpl).AddServerEventListener(eventName, Function.Create(CoreImpl, function));
        public static Function OnServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(string eventName, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> function) => ((Core)CoreImpl).AddServerEventListener(eventName, Function.Create(CoreImpl, function));
        public static Function OnServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(string eventName, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> function) => ((Core)CoreImpl).AddServerEventListener(eventName, Function.Create(CoreImpl, function));
        public static Function OnServer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(string eventName, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> function) => ((Core)CoreImpl).AddServerEventListener(eventName, Function.Create(CoreImpl, function));
        public static Function OnServer<T1, T2, T3, T4, T5, T6, T7, T8>(string eventName, Action<T1, T2, T3, T4, T5, T6, T7, T8> function) => ((Core)CoreImpl).AddServerEventListener(eventName, Function.Create(CoreImpl, function));
        public static Function OnServer<T1, T2, T3, T4, T5, T6, T7>(string eventName, Action<T1, T2, T3, T4, T5, T6, T7> function) => ((Core)CoreImpl).AddServerEventListener(eventName, Function.Create(CoreImpl, function));
        public static Function OnServer<T1, T2, T3, T4, T5, T6>(string eventName, Action<T1, T2, T3, T4, T5, T6> function) => ((Core)CoreImpl).AddServerEventListener(eventName, Function.Create(CoreImpl, function));
        public static Function OnServer<T1, T2, T3, T4, T5>(string eventName, Action<T1, T2, T3, T4, T5> function) => ((Core)CoreImpl).AddServerEventListener(eventName, Function.Create(CoreImpl, function));
        public static Function OnServer<T1, T2, T3, T4>(string eventName, Action<T1, T2, T3, T4> function) => ((Core)CoreImpl).AddServerEventListener(eventName, Function.Create(CoreImpl, function));
        public static Function OnServer<T1, T2, T3>(string eventName, Action<T1, T2, T3> function) => ((Core)CoreImpl).AddServerEventListener(eventName, Function.Create(CoreImpl, function));
        public static Function OnServer<T1, T2>(string eventName, Action<T1, T2> function) => ((Core)CoreImpl).AddServerEventListener(eventName, Function.Create(CoreImpl, function));
        public static Function OnServer<T1>(string eventName, Action<T1> function) => ((Core)CoreImpl).AddServerEventListener(eventName, Function.Create(CoreImpl, function));
        public static Function OnServer(string eventName, Action function) => ((Core)CoreImpl).AddServerEventListener(eventName, Function.Create(CoreImpl, function));
        public static Function OnServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(string eventName, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> function) => ((Core)CoreImpl).AddServerEventListener(eventName, Function.Create(CoreImpl, function));
        public static Function OnServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(string eventName, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> function) => ((Core)CoreImpl).AddServerEventListener(eventName, Function.Create(CoreImpl, function));
        public static Function OnServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(string eventName, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> function) => ((Core)CoreImpl).AddServerEventListener(eventName, Function.Create(CoreImpl, function));
        public static Function OnServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(string eventName, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> function) => ((Core)CoreImpl).AddServerEventListener(eventName, Function.Create(CoreImpl, function));
        public static Function OnServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(string eventName, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> function) => ((Core)CoreImpl).AddServerEventListener(eventName, Function.Create(CoreImpl, function));
        public static Function OnServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(string eventName, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> function) => ((Core)CoreImpl).AddServerEventListener(eventName, Function.Create(CoreImpl, function));
        public static Function OnServer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(string eventName, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> function) => ((Core)CoreImpl).AddServerEventListener(eventName, Function.Create(CoreImpl, function));
        public static Function OnServer<T1, T2, T3, T4, T5, T6, T7, T8, T9>(string eventName, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9> function) => ((Core)CoreImpl).AddServerEventListener(eventName, Function.Create(CoreImpl, function));
        public static Function OnServer<T1, T2, T3, T4, T5, T6, T7, T8>(string eventName, Func<T1, T2, T3, T4, T5, T6, T7, T8> function) => ((Core)CoreImpl).AddServerEventListener(eventName, Function.Create(CoreImpl, function));
        public static Function OnServer<T1, T2, T3, T4, T5, T6, T7>(string eventName, Func<T1, T2, T3, T4, T5, T6, T7> function) => ((Core)CoreImpl).AddServerEventListener(eventName, Function.Create(CoreImpl, function));
        public static Function OnServer<T1, T2, T3, T4, T5, T6>(string eventName, Func<T1, T2, T3, T4, T5, T6> function) => ((Core)CoreImpl).AddServerEventListener(eventName, Function.Create(CoreImpl, function));
        public static Function OnServer<T1, T2, T3, T4, T5>(string eventName, Func<T1, T2, T3, T4, T5> function) => ((Core)CoreImpl).AddServerEventListener(eventName, Function.Create(CoreImpl, function));
        public static Function OnServer<T1, T2, T3, T4>(string eventName, Func<T1, T2, T3, T4> function) => ((Core)CoreImpl).AddServerEventListener(eventName, Function.Create(CoreImpl, function));
        public static Function OnServer<T1, T2, T3>(string eventName, Func<T1, T2, T3> function) => ((Core)CoreImpl).AddServerEventListener(eventName, Function.Create(CoreImpl, function));
        public static Function OnServer<T1, T2>(string eventName, Func<T1, T2> function) => ((Core)CoreImpl).AddServerEventListener(eventName, Function.Create(CoreImpl, function));
        public static Function OnServer<T1>(string eventName, Func<T1> function) => ((Core)CoreImpl).AddServerEventListener(eventName, Function.Create(CoreImpl, function));
        public static bool OffServer(string eventName, Function function) => ((Core)CoreImpl).RemoveServerEventListener(eventName, function);

        public static Function OnClient(string eventName, Function function) => ((Core)CoreImpl).AddClientEventListener(eventName, function);
        public static Function OnClient<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(string eventName, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> function) => ((Core)CoreImpl).AddClientEventListener(eventName, Function.Create(CoreImpl, function));
        public static Function OnClient<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(string eventName, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> function) => ((Core)CoreImpl).AddClientEventListener(eventName, Function.Create(CoreImpl, function));
        public static Function OnClient<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(string eventName, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> function) => ((Core)CoreImpl).AddClientEventListener(eventName, Function.Create(CoreImpl, function));
        public static Function OnClient<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(string eventName, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> function) => ((Core)CoreImpl).AddClientEventListener(eventName, Function.Create(CoreImpl, function));
        public static Function OnClient<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(string eventName, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> function) => ((Core)CoreImpl).AddClientEventListener(eventName, Function.Create(CoreImpl, function));
        public static Function OnClient<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(string eventName, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> function) => ((Core)CoreImpl).AddClientEventListener(eventName, Function.Create(CoreImpl, function));
        public static Function OnClient<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(string eventName, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> function) => ((Core)CoreImpl).AddClientEventListener(eventName, Function.Create(CoreImpl, function));
        public static Function OnClient<T1, T2, T3, T4, T5, T6, T7, T8, T9>(string eventName, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> function) => ((Core)CoreImpl).AddClientEventListener(eventName, Function.Create(CoreImpl, function));
        public static Function OnClient<T1, T2, T3, T4, T5, T6, T7, T8>(string eventName, Action<T1, T2, T3, T4, T5, T6, T7, T8> function) => ((Core)CoreImpl).AddClientEventListener(eventName, Function.Create(CoreImpl, function));
        public static Function OnClient<T1, T2, T3, T4, T5, T6, T7>(string eventName, Action<T1, T2, T3, T4, T5, T6, T7> function) => ((Core)CoreImpl).AddClientEventListener(eventName, Function.Create(CoreImpl, function));
        public static Function OnClient<T1, T2, T3, T4, T5, T6>(string eventName, Action<T1, T2, T3, T4, T5, T6> function) => ((Core)CoreImpl).AddClientEventListener(eventName, Function.Create(CoreImpl, function));
        public static Function OnClient<T1, T2, T3, T4, T5>(string eventName, Action<T1, T2, T3, T4, T5> function) => ((Core)CoreImpl).AddClientEventListener(eventName, Function.Create(CoreImpl, function));
        public static Function OnClient<T1, T2, T3, T4>(string eventName, Action<T1, T2, T3, T4> function) => ((Core)CoreImpl).AddClientEventListener(eventName, Function.Create(CoreImpl, function));
        public static Function OnClient<T1, T2, T3>(string eventName, Action<T1, T2, T3> function) => ((Core)CoreImpl).AddClientEventListener(eventName, Function.Create(CoreImpl, function));
        public static Function OnClient<T1, T2>(string eventName, Action<T1, T2> function) => ((Core)CoreImpl).AddClientEventListener(eventName, Function.Create(CoreImpl, function));
        public static Function OnClient<T1>(string eventName, Action<T1> function) => ((Core)CoreImpl).AddClientEventListener(eventName, Function.Create(CoreImpl, function));
        public static Function OnClient(string eventName, Action function) => ((Core)CoreImpl).AddClientEventListener(eventName, Function.Create(CoreImpl, function));
        public static Function OnClient<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(string eventName, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> function) => ((Core)CoreImpl).AddClientEventListener(eventName, Function.Create(CoreImpl, function));
        public static Function OnClient<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(string eventName, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> function) => ((Core)CoreImpl).AddClientEventListener(eventName, Function.Create(CoreImpl, function));
        public static Function OnClient<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(string eventName, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> function) => ((Core)CoreImpl).AddClientEventListener(eventName, Function.Create(CoreImpl, function));
        public static Function OnClient<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(string eventName, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> function) => ((Core)CoreImpl).AddClientEventListener(eventName, Function.Create(CoreImpl, function));
        public static Function OnClient<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(string eventName, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> function) => ((Core)CoreImpl).AddClientEventListener(eventName, Function.Create(CoreImpl, function));
        public static Function OnClient<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(string eventName, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> function) => ((Core)CoreImpl).AddClientEventListener(eventName, Function.Create(CoreImpl, function));
        public static Function OnClient<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(string eventName, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> function) => ((Core)CoreImpl).AddClientEventListener(eventName, Function.Create(CoreImpl, function));
        public static Function OnClient<T1, T2, T3, T4, T5, T6, T7, T8, T9>(string eventName, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9> function) => ((Core)CoreImpl).AddClientEventListener(eventName, Function.Create(CoreImpl, function));
        public static Function OnClient<T1, T2, T3, T4, T5, T6, T7, T8>(string eventName, Func<T1, T2, T3, T4, T5, T6, T7, T8> function) => ((Core)CoreImpl).AddClientEventListener(eventName, Function.Create(CoreImpl, function));
        public static Function OnClient<T1, T2, T3, T4, T5, T6, T7>(string eventName, Func<T1, T2, T3, T4, T5, T6, T7> function) => ((Core)CoreImpl).AddClientEventListener(eventName, Function.Create(CoreImpl, function));
        public static Function OnClient<T1, T2, T3, T4, T5, T6>(string eventName, Func<T1, T2, T3, T4, T5, T6> function) => ((Core)CoreImpl).AddClientEventListener(eventName, Function.Create(CoreImpl, function));
        public static Function OnClient<T1, T2, T3, T4, T5>(string eventName, Func<T1, T2, T3, T4, T5> function) => ((Core)CoreImpl).AddClientEventListener(eventName, Function.Create(CoreImpl, function));
        public static Function OnClient<T1, T2, T3, T4>(string eventName, Func<T1, T2, T3, T4> function) => ((Core)CoreImpl).AddClientEventListener(eventName, Function.Create(CoreImpl, function));
        public static Function OnClient<T1, T2, T3>(string eventName, Func<T1, T2, T3> function) => ((Core)CoreImpl).AddClientEventListener(eventName, Function.Create(CoreImpl, function));
        public static Function OnClient<T1, T2>(string eventName, Func<T1, T2> function) => ((Core)CoreImpl).AddClientEventListener(eventName, Function.Create(CoreImpl, function));
        public static Function OnClient<T1>(string eventName, Func<T1> function) => ((Core)CoreImpl).AddClientEventListener(eventName, Function.Create(CoreImpl, function));
        public static bool OffClient(string eventName, Function function) => ((Core)CoreImpl).RemoveClientEventListener(eventName, function);

        #region WebView

        public static Function On(this IWebView webView, string eventName, Function function) => ((Core)CoreImpl).AddWebViewEventListener(webView.WebViewNativePointer, eventName, function);
        public static Function On<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this IWebView webView, string eventName, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> function) =>
            ((Core)CoreImpl).AddWebViewEventListener(webView.WebViewNativePointer, eventName, Function.Create(CoreImpl, function));
        public static Function On<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this IWebView webView, string eventName, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> function) =>
            ((Core)CoreImpl).AddWebViewEventListener(webView.WebViewNativePointer, eventName, Function.Create(CoreImpl, function));
        public static Function On<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this IWebView webView, string eventName, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> function) =>
            ((Core)CoreImpl).AddWebViewEventListener(webView.WebViewNativePointer, eventName, Function.Create(CoreImpl, function));
        public static Function On<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this IWebView webView, string eventName, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> function) => ((Core)CoreImpl).AddWebViewEventListener(webView.WebViewNativePointer, eventName, Function.Create(CoreImpl, function));
        public static Function On<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this IWebView webView, string eventName, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> function) => ((Core)CoreImpl).AddWebViewEventListener(webView.WebViewNativePointer, eventName, Function.Create(CoreImpl, function));
        public static Function On<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this IWebView webView, string eventName, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> function) => ((Core)CoreImpl).AddWebViewEventListener(webView.WebViewNativePointer, eventName, Function.Create(CoreImpl, function));
        public static Function On<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this IWebView webView, string eventName, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> function) => ((Core)CoreImpl).AddWebViewEventListener(webView.WebViewNativePointer, eventName, Function.Create(CoreImpl, function));
        public static Function On<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this IWebView webView, string eventName, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> function) => ((Core)CoreImpl).AddWebViewEventListener(webView.WebViewNativePointer, eventName, Function.Create(CoreImpl, function));
        public static Function On<T1, T2, T3, T4, T5, T6, T7, T8>(this IWebView webView, string eventName, Action<T1, T2, T3, T4, T5, T6, T7, T8> function) => ((Core)CoreImpl).AddWebViewEventListener(webView.WebViewNativePointer, eventName, Function.Create(CoreImpl, function));
        public static Function On<T1, T2, T3, T4, T5, T6, T7>(this IWebView webView, string eventName, Action<T1, T2, T3, T4, T5, T6, T7> function) => ((Core)CoreImpl).AddWebViewEventListener(webView.WebViewNativePointer, eventName, Function.Create(CoreImpl, function));
        public static Function On<T1, T2, T3, T4, T5, T6>(this IWebView webView, string eventName, Action<T1, T2, T3, T4, T5, T6> function) => ((Core)CoreImpl).AddWebViewEventListener(webView.WebViewNativePointer, eventName, Function.Create(CoreImpl, function));
        public static Function On<T1, T2, T3, T4, T5>(this IWebView webView, string eventName, Action<T1, T2, T3, T4, T5> function) => ((Core)CoreImpl).AddWebViewEventListener(webView.WebViewNativePointer, eventName, Function.Create(CoreImpl, function));
        public static Function On<T1, T2, T3, T4>(this IWebView webView, string eventName, Action<T1, T2, T3, T4> function) => ((Core)CoreImpl).AddWebViewEventListener(webView.WebViewNativePointer, eventName, Function.Create(CoreImpl, function));
        public static Function On<T1, T2, T3>(this IWebView webView, string eventName, Action<T1, T2, T3> function) => ((Core)CoreImpl).AddWebViewEventListener(webView.WebViewNativePointer, eventName, Function.Create(CoreImpl, function));
        public static Function On<T1, T2>(this IWebView webView, string eventName, Action<T1, T2> function) => ((Core)CoreImpl).AddWebViewEventListener(webView.WebViewNativePointer, eventName, Function.Create(CoreImpl, function));
        public static Function On<T1>(this IWebView webView, string eventName, Action<T1> function) => ((Core)CoreImpl).AddWebViewEventListener(webView.WebViewNativePointer, eventName, Function.Create(CoreImpl, function));
        public static Function On(this IWebView webView, string eventName, Action function) => ((Core)CoreImpl).AddWebViewEventListener(webView.WebViewNativePointer, eventName, Function.Create(CoreImpl, function));
        public static Function On<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this IWebView webView, string eventName, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> function) =>
            ((Core)CoreImpl).AddWebViewEventListener(webView.WebViewNativePointer, eventName, Function.Create(CoreImpl, function));
        public static Function On<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this IWebView webView, string eventName, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> function) =>
            ((Core)CoreImpl).AddWebViewEventListener(webView.WebViewNativePointer, eventName, Function.Create(CoreImpl, function));
        public static Function On<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this IWebView webView, string eventName, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> function) => ((Core)CoreImpl).AddWebViewEventListener(webView.WebViewNativePointer, eventName, Function.Create(CoreImpl, function));
        public static Function On<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this IWebView webView, string eventName, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> function) => ((Core)CoreImpl).AddWebViewEventListener(webView.WebViewNativePointer, eventName, Function.Create(CoreImpl, function));
        public static Function On<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this IWebView webView, string eventName, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> function) => ((Core)CoreImpl).AddWebViewEventListener(webView.WebViewNativePointer, eventName, Function.Create(CoreImpl, function));
        public static Function On<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this IWebView webView, string eventName, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> function) => ((Core)CoreImpl).AddWebViewEventListener(webView.WebViewNativePointer, eventName, Function.Create(CoreImpl, function));
        public static Function On<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this IWebView webView, string eventName, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> function) => ((Core)CoreImpl).AddWebViewEventListener(webView.WebViewNativePointer, eventName, Function.Create(CoreImpl, function));
        public static Function On<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this IWebView webView, string eventName, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9> function) => ((Core)CoreImpl).AddWebViewEventListener(webView.WebViewNativePointer, eventName, Function.Create(CoreImpl, function));
        public static Function On<T1, T2, T3, T4, T5, T6, T7, T8>(this IWebView webView, string eventName, Func<T1, T2, T3, T4, T5, T6, T7, T8> function) => ((Core)CoreImpl).AddWebViewEventListener(webView.WebViewNativePointer, eventName, Function.Create(CoreImpl, function));
        public static Function On<T1, T2, T3, T4, T5, T6, T7>(this IWebView webView, string eventName, Func<T1, T2, T3, T4, T5, T6, T7> function) => ((Core)CoreImpl).AddWebViewEventListener(webView.WebViewNativePointer, eventName, Function.Create(CoreImpl, function));
        public static Function On<T1, T2, T3, T4, T5, T6>(this IWebView webView, string eventName, Func<T1, T2, T3, T4, T5, T6> function) => ((Core)CoreImpl).AddWebViewEventListener(webView.WebViewNativePointer, eventName, Function.Create(CoreImpl, function));
        public static Function On<T1, T2, T3, T4, T5>(this IWebView webView, string eventName, Func<T1, T2, T3, T4, T5> function) => ((Core)CoreImpl).AddWebViewEventListener(webView.WebViewNativePointer, eventName, Function.Create(CoreImpl, function));
        public static Function On<T1, T2, T3, T4>(this IWebView webView, string eventName, Func<T1, T2, T3, T4> function) => ((Core)CoreImpl).AddWebViewEventListener(webView.WebViewNativePointer, eventName, Function.Create(CoreImpl, function));
        public static Function On<T1, T2, T3>(this IWebView webView, string eventName, Func<T1, T2, T3> function) => ((Core)CoreImpl).AddWebViewEventListener(webView.WebViewNativePointer, eventName, Function.Create(CoreImpl, function));
        public static Function On<T1, T2>(this IWebView webView, string eventName, Func<T1, T2> function) => ((Core)CoreImpl).AddWebViewEventListener(webView.WebViewNativePointer, eventName, Function.Create(CoreImpl, function));
        public static Function On<T1>(this IWebView webView, string eventName, Func<T1> function) => ((Core)CoreImpl).AddWebViewEventListener(webView.WebViewNativePointer, eventName, Function.Create(CoreImpl, function));
        public static bool Off(this IWebView webView, string eventName, Function function) => ((Core)CoreImpl).RemoveWebViewEventListener(webView.WebViewNativePointer, eventName, function);

        #endregion

        #region RmlElement

        public static Function OnRmlEvent(this IRmlElement rmlElement, string eventName, Action<Dictionary<string, MValueConst>> function) => ((Core)CoreImpl).AddRmlElementEventListener(rmlElement.RmlElementNativePointer, eventName, Function.Create(CoreImpl, function));
        public static bool OffRmlEvent(this IRmlElement rmlElement, string eventName, Function function) => ((Core)CoreImpl).RemoveRmlElementEventListener(rmlElement.RmlElementNativePointer, eventName, function);
        #endregion

        #region Websocket

        public static Function On(this IWebSocketClient webSocketClient, string eventName, Function function) => ((Core)CoreImpl).AddWebSocketEventListener(webSocketClient.WebSocketClientNativePointer, eventName, function);
        public static Function On<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this IWebSocketClient webSocketClient, string eventName, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> function) =>
            ((Core)CoreImpl).AddWebSocketEventListener(webSocketClient.WebSocketClientNativePointer, eventName, Function.Create(CoreImpl, function));
        public static Function On<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this IWebSocketClient webSocketClient, string eventName, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> function) =>
            ((Core)CoreImpl).AddWebSocketEventListener(webSocketClient.WebSocketClientNativePointer, eventName, Function.Create(CoreImpl, function));
        public static Function On<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this IWebSocketClient webSocketClient, string eventName, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> function) =>
            ((Core)CoreImpl).AddWebSocketEventListener(webSocketClient.WebSocketClientNativePointer, eventName, Function.Create(CoreImpl, function));
        public static Function On<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this IWebSocketClient webSocketClient, string eventName, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> function) =>
            ((Core)CoreImpl).AddWebSocketEventListener(webSocketClient.WebSocketClientNativePointer, eventName, Function.Create(CoreImpl, function));
        public static Function On<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this IWebSocketClient webSocketClient, string eventName, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> function) =>
            ((Core)CoreImpl).AddWebSocketEventListener(webSocketClient.WebSocketClientNativePointer, eventName, Function.Create(CoreImpl, function));
        public static Function On<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this IWebSocketClient webSocketClient, string eventName, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> function) =>
            ((Core)CoreImpl).AddWebSocketEventListener(webSocketClient.WebSocketClientNativePointer, eventName, Function.Create(CoreImpl, function));
        public static Function On<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this IWebSocketClient webSocketClient, string eventName, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> function) => ((Core)CoreImpl).AddWebSocketEventListener(webSocketClient.WebSocketClientNativePointer, eventName, Function.Create(CoreImpl, function));
        public static Function On<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this IWebSocketClient webSocketClient, string eventName, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> function) => ((Core)CoreImpl).AddWebSocketEventListener(webSocketClient.WebSocketClientNativePointer, eventName, Function.Create(CoreImpl, function));
        public static Function On<T1, T2, T3, T4, T5, T6, T7, T8>(this IWebSocketClient webSocketClient, string eventName, Action<T1, T2, T3, T4, T5, T6, T7, T8> function) => ((Core)CoreImpl).AddWebSocketEventListener(webSocketClient.WebSocketClientNativePointer, eventName, Function.Create(CoreImpl, function));
        public static Function On<T1, T2, T3, T4, T5, T6, T7>(this IWebSocketClient webSocketClient, string eventName, Action<T1, T2, T3, T4, T5, T6, T7> function) => ((Core)CoreImpl).AddWebSocketEventListener(webSocketClient.WebSocketClientNativePointer, eventName, Function.Create(CoreImpl, function));
        public static Function On<T1, T2, T3, T4, T5, T6>(this IWebSocketClient webSocketClient, string eventName, Action<T1, T2, T3, T4, T5, T6> function) => ((Core)CoreImpl).AddWebSocketEventListener(webSocketClient.WebSocketClientNativePointer, eventName, Function.Create(CoreImpl, function));
        public static Function On<T1, T2, T3, T4, T5>(this IWebSocketClient webSocketClient, string eventName, Action<T1, T2, T3, T4, T5> function) => ((Core)CoreImpl).AddWebSocketEventListener(webSocketClient.WebSocketClientNativePointer, eventName, Function.Create(CoreImpl, function));
        public static Function On<T1, T2, T3, T4>(this IWebSocketClient webSocketClient, string eventName, Action<T1, T2, T3, T4> function) => ((Core)CoreImpl).AddWebSocketEventListener(webSocketClient.WebSocketClientNativePointer, eventName, Function.Create(CoreImpl, function));
        public static Function On<T1, T2, T3>(this IWebSocketClient webSocketClient, string eventName, Action<T1, T2, T3> function) => ((Core)CoreImpl).AddWebSocketEventListener(webSocketClient.WebSocketClientNativePointer, eventName, Function.Create(CoreImpl, function));
        public static Function On<T1, T2>(this IWebSocketClient webSocketClient, string eventName, Action<T1, T2> function) => ((Core)CoreImpl).AddWebSocketEventListener(webSocketClient.WebSocketClientNativePointer, eventName, Function.Create(CoreImpl, function));
        public static Function On<T1>(this IWebSocketClient webSocketClient, string eventName, Action<T1> function) => ((Core)CoreImpl).AddWebSocketEventListener(webSocketClient.WebSocketClientNativePointer, eventName, Function.Create(CoreImpl, function));
        public static Function On(this IWebSocketClient webSocketClient, string eventName, Action function) => ((Core)CoreImpl).AddWebSocketEventListener(webSocketClient.WebSocketClientNativePointer, eventName, Function.Create(CoreImpl, function));
        public static Function On<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this IWebSocketClient webSocketClient, string eventName, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> function) =>
            ((Core)CoreImpl).AddWebSocketEventListener(webSocketClient.WebSocketClientNativePointer, eventName, Function.Create(CoreImpl, function));
        public static Function On<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this IWebSocketClient webSocketClient, string eventName, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> function) =>
            ((Core)CoreImpl).AddWebSocketEventListener(webSocketClient.WebSocketClientNativePointer, eventName, Function.Create(CoreImpl, function));
        public static Function On<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this IWebSocketClient webSocketClient, string eventName, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> function) =>
            ((Core)CoreImpl).AddWebSocketEventListener(webSocketClient.WebSocketClientNativePointer, eventName, Function.Create(CoreImpl, function));
        public static Function On<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this IWebSocketClient webSocketClient, string eventName, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> function) =>
            ((Core)CoreImpl).AddWebSocketEventListener(webSocketClient.WebSocketClientNativePointer, eventName, Function.Create(CoreImpl, function));
        public static Function On<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this IWebSocketClient webSocketClient, string eventName, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> function) =>
            ((Core)CoreImpl).AddWebSocketEventListener(webSocketClient.WebSocketClientNativePointer, eventName, Function.Create(CoreImpl, function));
        public static Function On<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this IWebSocketClient webSocketClient, string eventName, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> function) =>
            ((Core)CoreImpl).AddWebSocketEventListener(webSocketClient.WebSocketClientNativePointer, eventName, Function.Create(CoreImpl, function));
        public static Function On<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this IWebSocketClient webSocketClient, string eventName, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> function) => ((Core)CoreImpl).AddWebSocketEventListener(webSocketClient.WebSocketClientNativePointer, eventName, Function.Create(CoreImpl, function));
        public static Function On<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this IWebSocketClient webSocketClient, string eventName, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9> function) => ((Core)CoreImpl).AddWebSocketEventListener(webSocketClient.WebSocketClientNativePointer, eventName, Function.Create(CoreImpl, function));
        public static Function On<T1, T2, T3, T4, T5, T6, T7, T8>(this IWebSocketClient webSocketClient, string eventName, Func<T1, T2, T3, T4, T5, T6, T7, T8> function) => ((Core)CoreImpl).AddWebSocketEventListener(webSocketClient.WebSocketClientNativePointer, eventName, Function.Create(CoreImpl, function));
        public static Function On<T1, T2, T3, T4, T5, T6, T7>(this IWebSocketClient webSocketClient, string eventName, Func<T1, T2, T3, T4, T5, T6, T7> function) => ((Core)CoreImpl).AddWebSocketEventListener(webSocketClient.WebSocketClientNativePointer, eventName, Function.Create(CoreImpl, function));
        public static Function On<T1, T2, T3, T4, T5, T6>(this IWebSocketClient webSocketClient, string eventName, Func<T1, T2, T3, T4, T5, T6> function) => ((Core)CoreImpl).AddWebSocketEventListener(webSocketClient.WebSocketClientNativePointer, eventName, Function.Create(CoreImpl, function));
        public static Function On<T1, T2, T3, T4, T5>(this IWebSocketClient webSocketClient, string eventName, Func<T1, T2, T3, T4, T5> function) => ((Core)CoreImpl).AddWebSocketEventListener(webSocketClient.WebSocketClientNativePointer, eventName, Function.Create(CoreImpl, function));
        public static Function On<T1, T2, T3, T4>(this IWebSocketClient webSocketClient, string eventName, Func<T1, T2, T3, T4> function) => ((Core)CoreImpl).AddWebSocketEventListener(webSocketClient.WebSocketClientNativePointer, eventName, Function.Create(CoreImpl, function));
        public static Function On<T1, T2, T3>(this IWebSocketClient webSocketClient, string eventName, Func<T1, T2, T3> function) => ((Core)CoreImpl).AddWebSocketEventListener(webSocketClient.WebSocketClientNativePointer, eventName, Function.Create(CoreImpl, function));
        public static Function On<T1, T2>(this IWebSocketClient webSocketClient, string eventName, Func<T1, T2> function) => ((Core)CoreImpl).AddWebSocketEventListener(webSocketClient.WebSocketClientNativePointer, eventName, Function.Create(CoreImpl, function));
        public static Function On<T1>(this IWebSocketClient webSocketClient, string eventName, Func<T1> function) => ((Core)CoreImpl).AddWebSocketEventListener(webSocketClient.WebSocketClientNativePointer, eventName, Function.Create(CoreImpl, function));
        public static bool Off(this IWebSocketClient webSocketClient, string eventName, Function function) => ((Core)CoreImpl).RemoveWebSocketEventListener(webSocketClient.WebSocketClientNativePointer, eventName, function);

        #endregion

        #region Audio

        public static Function On(this IAudio audio, string eventName, Function function) => ((Core)CoreImpl).AddAudioEventListener(audio.AudioNativePointer, eventName, function);
        public static Function On<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this IAudio audio, string eventName, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> function) =>
            ((Core)CoreImpl).AddAudioEventListener(audio.AudioNativePointer, eventName, Function.Create(CoreImpl, function));
        public static Function On<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this IAudio audio, string eventName, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> function) =>
            ((Core)CoreImpl).AddAudioEventListener(audio.AudioNativePointer, eventName, Function.Create(CoreImpl, function));
        public static Function On<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this IAudio audio, string eventName, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> function) =>
            ((Core)CoreImpl).AddAudioEventListener(audio.AudioNativePointer, eventName, Function.Create(CoreImpl, function));
        public static Function On<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this IAudio audio, string eventName, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> function) => ((Core)CoreImpl).AddAudioEventListener(audio.AudioNativePointer, eventName, Function.Create(CoreImpl, function));
        public static Function On<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this IAudio audio, string eventName, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> function) => ((Core)CoreImpl).AddAudioEventListener(audio.AudioNativePointer, eventName, Function.Create(CoreImpl, function));
        public static Function On<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this IAudio audio, string eventName, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> function) => ((Core)CoreImpl).AddAudioEventListener(audio.AudioNativePointer, eventName, Function.Create(CoreImpl, function));
        public static Function On<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this IAudio audio, string eventName, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> function) => ((Core)CoreImpl).AddAudioEventListener(audio.AudioNativePointer, eventName, Function.Create(CoreImpl, function));
        public static Function On<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this IAudio audio, string eventName, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> function) => ((Core)CoreImpl).AddAudioEventListener(audio.AudioNativePointer, eventName, Function.Create(CoreImpl, function));
        public static Function On<T1, T2, T3, T4, T5, T6, T7, T8>(this IAudio audio, string eventName, Action<T1, T2, T3, T4, T5, T6, T7, T8> function) => ((Core)CoreImpl).AddAudioEventListener(audio.AudioNativePointer, eventName, Function.Create(CoreImpl, function));
        public static Function On<T1, T2, T3, T4, T5, T6, T7>(this IAudio audio, string eventName, Action<T1, T2, T3, T4, T5, T6, T7> function) => ((Core)CoreImpl).AddAudioEventListener(audio.AudioNativePointer, eventName, Function.Create(CoreImpl, function));
        public static Function On<T1, T2, T3, T4, T5, T6>(this IAudio audio, string eventName, Action<T1, T2, T3, T4, T5, T6> function) => ((Core)CoreImpl).AddAudioEventListener(audio.AudioNativePointer, eventName, Function.Create(CoreImpl, function));
        public static Function On<T1, T2, T3, T4, T5>(this IAudio audio, string eventName, Action<T1, T2, T3, T4, T5> function) => ((Core)CoreImpl).AddAudioEventListener(audio.AudioNativePointer, eventName, Function.Create(CoreImpl, function));
        public static Function On<T1, T2, T3, T4>(this IAudio audio, string eventName, Action<T1, T2, T3, T4> function) => ((Core)CoreImpl).AddAudioEventListener(audio.AudioNativePointer, eventName, Function.Create(CoreImpl, function));
        public static Function On<T1, T2, T3>(this IAudio audio, string eventName, Action<T1, T2, T3> function) => ((Core)CoreImpl).AddAudioEventListener(audio.AudioNativePointer, eventName, Function.Create(CoreImpl, function));
        public static Function On<T1, T2>(this IAudio audio, string eventName, Action<T1, T2> function) => ((Core)CoreImpl).AddAudioEventListener(audio.AudioNativePointer, eventName, Function.Create(CoreImpl, function));
        public static Function On<T1>(this IAudio audio, string eventName, Action<T1> function) => ((Core)CoreImpl).AddAudioEventListener(audio.AudioNativePointer, eventName, Function.Create(CoreImpl, function));
        public static Function On(this IAudio audio, string eventName, Action function) => ((Core)CoreImpl).AddAudioEventListener(audio.AudioNativePointer, eventName, Function.Create(CoreImpl, function));
        public static Function On<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this IAudio audio, string eventName, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> function) =>
            ((Core)CoreImpl).AddAudioEventListener(audio.AudioNativePointer, eventName, Function.Create(CoreImpl, function));
        public static Function On<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this IAudio audio, string eventName, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> function) =>
            ((Core)CoreImpl).AddAudioEventListener(audio.AudioNativePointer, eventName, Function.Create(CoreImpl, function));
        public static Function On<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this IAudio audio, string eventName, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> function) => ((Core)CoreImpl).AddAudioEventListener(audio.AudioNativePointer, eventName, Function.Create(CoreImpl, function));
        public static Function On<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this IAudio audio, string eventName, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> function) => ((Core)CoreImpl).AddAudioEventListener(audio.AudioNativePointer, eventName, Function.Create(CoreImpl, function));
        public static Function On<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this IAudio audio, string eventName, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> function) => ((Core)CoreImpl).AddAudioEventListener(audio.AudioNativePointer, eventName, Function.Create(CoreImpl, function));
        public static Function On<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this IAudio audio, string eventName, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> function) => ((Core)CoreImpl).AddAudioEventListener(audio.AudioNativePointer, eventName, Function.Create(CoreImpl, function));
        public static Function On<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this IAudio audio, string eventName, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> function) => ((Core)CoreImpl).AddAudioEventListener(audio.AudioNativePointer, eventName, Function.Create(CoreImpl, function));
        public static Function On<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this IAudio audio, string eventName, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9> function) => ((Core)CoreImpl).AddAudioEventListener(audio.AudioNativePointer, eventName, Function.Create(CoreImpl, function));
        public static Function On<T1, T2, T3, T4, T5, T6, T7, T8>(this IAudio audio, string eventName, Func<T1, T2, T3, T4, T5, T6, T7, T8> function) => ((Core)CoreImpl).AddAudioEventListener(audio.AudioNativePointer, eventName, Function.Create(CoreImpl, function));
        public static Function On<T1, T2, T3, T4, T5, T6, T7>(this IAudio audio, string eventName, Func<T1, T2, T3, T4, T5, T6, T7> function) => ((Core)CoreImpl).AddAudioEventListener(audio.AudioNativePointer, eventName, Function.Create(CoreImpl, function));
        public static Function On<T1, T2, T3, T4, T5, T6>(this IAudio audio, string eventName, Func<T1, T2, T3, T4, T5, T6> function) => ((Core)CoreImpl).AddAudioEventListener(audio.AudioNativePointer, eventName, Function.Create(CoreImpl, function));
        public static Function On<T1, T2, T3, T4, T5>(this IAudio audio, string eventName, Func<T1, T2, T3, T4, T5> function) => ((Core)CoreImpl).AddAudioEventListener(audio.AudioNativePointer, eventName, Function.Create(CoreImpl, function));
        public static Function On<T1, T2, T3, T4>(this IAudio audio, string eventName, Func<T1, T2, T3, T4> function) => ((Core)CoreImpl).AddAudioEventListener(audio.AudioNativePointer, eventName, Function.Create(CoreImpl, function));
        public static Function On<T1, T2, T3>(this IAudio audio, string eventName, Func<T1, T2, T3> function) => ((Core)CoreImpl).AddAudioEventListener(audio.AudioNativePointer, eventName, Function.Create(CoreImpl, function));
        public static Function On<T1, T2>(this IAudio audio, string eventName, Func<T1, T2> function) => ((Core)CoreImpl).AddAudioEventListener(audio.AudioNativePointer, eventName, Function.Create(CoreImpl, function));
        public static Function On<T1>(this IAudio audio, string eventName, Func<T1> function) => ((Core)CoreImpl).AddAudioEventListener(audio.AudioNativePointer, eventName, Function.Create(CoreImpl, function));
        public static bool Off(this IAudio audio, string eventName, Function function) => ((Core)CoreImpl).RemoveAudioEventListener(audio.AudioNativePointer, eventName, function);

        #endregion
    }
}