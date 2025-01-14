using System;
using AltV.Net.Data;
using AltV.Net.Elements.Entities;
using AltV.Net.FunctionParser;
using AltV.Net.Types;

namespace AltV.Net.Async
{
    public partial class AltAsync
    {
        public static void RegisterEvents(object target)
        {
            ModuleScriptMethodIndexer.Index(target,
                new[]
                {
                    typeof(AsyncServerEventAttribute), typeof(AsyncClientEventAttribute),
                    typeof(AsyncScriptEventAttribute)
                },
                (baseEvent, eventMethod, eventMethodDelegate) =>
                {
                    switch (baseEvent)
                    {
                        case AsyncScriptEventAttribute scriptEvent:
                            var scriptEventType = scriptEvent.EventType;
                            ScriptFunction scriptFunction;
                            switch (scriptEventType)
                            {
                                case ScriptEventType.BaseObjectCreate:
                                {
                                    scriptFunction = ScriptFunction.Create(eventMethodDelegate,
                                        new[] { typeof(IBaseObject) }, isAsync: true);
                                    if (scriptFunction == null) return;
                                    OnBaseObjectCreate += (baseObject) =>
                                    {
                                        var currScriptFunction = scriptFunction.Clone();
                                        currScriptFunction.Set(baseObject);
                                        return currScriptFunction.CallAsync();
                                    };
                                    break;
                                }
                                case ScriptEventType.BaseObjectRemove:
                                {
                                    scriptFunction = ScriptFunction.Create(eventMethodDelegate,
                                        new[] { typeof(IBaseObject) }, isAsync: true);
                                    if (scriptFunction == null) return;
                                    OnBaseObjectRemove += (baseObject) =>
                                    {
                                        var currScriptFunction = scriptFunction.Clone();
                                        currScriptFunction.Set(baseObject);
                                        return currScriptFunction.CallAsync();
                                    };
                                    break;
                                }
                                case ScriptEventType.Checkpoint:
                                {
                                    scriptFunction = ScriptFunction.Create(eventMethodDelegate,
                                        new[] { typeof(ICheckpoint), typeof(IEntity), typeof(bool) }, isAsync: true);
                                    if (scriptFunction == null) return;
                                    OnCheckpoint += (checkpoint, entity, state) =>
                                    {
                                        var currScriptFunction = scriptFunction.Clone();
                                        currScriptFunction.Set(checkpoint);
                                        currScriptFunction.Set(entity);
                                        currScriptFunction.Set(state);
                                        return currScriptFunction.CallAsync();
                                    };
                                    break;
                                }
                                case ScriptEventType.PlayerConnect:
                                {
                                    scriptFunction = ScriptFunction.Create(eventMethodDelegate,
                                        new[] { typeof(IPlayer), typeof(string) }, isAsync: true);
                                    if (scriptFunction == null) return;
                                    OnPlayerConnect += (player, reason) =>
                                    {
                                        var currScriptFunction = scriptFunction.Clone();
                                        currScriptFunction.Set(player);
                                        currScriptFunction.Set(reason);
                                        return currScriptFunction.CallAsync();
                                    };
                                    break;
                                }
                                case ScriptEventType.PlayerDamage:
                                {
                                    scriptFunction = ScriptFunction.Create(eventMethodDelegate,
                                        new[]
                                        {
                                            typeof(IPlayer), typeof(IEntity), typeof(ushort), typeof(ushort),
                                            typeof(ushort), typeof(ushort), typeof(uint), typeof(ushort), typeof(ushort)
                                        }, isAsync: true);
                                    if (scriptFunction == null) return;
                                    OnPlayerDamage += (player, attacker,
                                        oldHealth, oldArmor,
                                        oldMaxHealth, oldMaxArmor,
                                        weapon, healthDamage, armourDamage) =>
                                    {
                                        var currScriptFunction = scriptFunction.Clone();
                                        currScriptFunction.Set(player);
                                        currScriptFunction.Set(attacker);
                                        currScriptFunction.Set(oldHealth);
                                        currScriptFunction.Set(oldArmor);
                                        currScriptFunction.Set(oldMaxHealth);
                                        currScriptFunction.Set(oldMaxArmor);
                                        currScriptFunction.Set(weapon);
                                        currScriptFunction.Set(healthDamage);
                                        currScriptFunction.Set(armourDamage);
                                        return currScriptFunction.CallAsync();
                                    };
                                    break;
                                }
                                case ScriptEventType.PlayerDead:
                                {
                                    scriptFunction = ScriptFunction.Create(eventMethodDelegate,
                                        new[] { typeof(IPlayer), typeof(IEntity), typeof(uint) }, isAsync: true);
                                    if (scriptFunction == null) return;
                                    OnPlayerDead += (player, attacker, weapon) =>
                                    {
                                        var currScriptFunction = scriptFunction.Clone();
                                        currScriptFunction.Set(player);
                                        currScriptFunction.Set(attacker);
                                        currScriptFunction.Set(weapon);
                                        return currScriptFunction.CallAsync();
                                    };
                                    break;
                                }
                                case ScriptEventType.PlayerHeal:
                                {
                                    scriptFunction = ScriptFunction.Create(eventMethodDelegate,
                                        new[] { typeof(IPlayer), typeof(ushort), typeof(ushort), typeof(ushort), typeof(ushort) }, isAsync: true);
                                    if (scriptFunction == null) return;
                                    OnPlayerHeal += (player, oldHealth, newHealth, oldArmour, newArmour) =>
                                    {
                                        var currScriptFunction = scriptFunction.Clone();
                                        currScriptFunction.Set(player);
                                        currScriptFunction.Set(oldHealth);
                                        currScriptFunction.Set(newHealth);
                                        currScriptFunction.Set(oldArmour);
                                        currScriptFunction.Set(newArmour);
                                        return currScriptFunction.CallAsync();
                                    };
                                    break;
                                }
                                case ScriptEventType.PlayerDisconnect:
                                {
                                    scriptFunction = ScriptFunction.Create(eventMethodDelegate,
                                        new[] { typeof(IPlayer), typeof(string) }, isAsync: true);
                                    if (scriptFunction == null) return;
                                    OnPlayerDisconnect += (player, reason) =>
                                    {
                                        var currScriptFunction = scriptFunction.Clone();
                                        currScriptFunction.Set(player);
                                        currScriptFunction.Set(reason);
                                        return currScriptFunction.CallAsync();
                                    };
                                    break;
                                }
                                case ScriptEventType.PlayerRemove:
                                {
                                    scriptFunction =
                                        ScriptFunction.Create(eventMethodDelegate, new[] { typeof(IPlayer) }, isAsync: true);
                                    if (scriptFunction == null) return;
                                    OnPlayerRemove += player =>
                                    {
                                        var currScriptFunction = scriptFunction.Clone();
                                        currScriptFunction.Set(player);
                                        return currScriptFunction.CallAsync();
                                    };
                                    break;
                                }
                                case ScriptEventType.VehicleRemove:
                                {
                                    scriptFunction =
                                        ScriptFunction.Create(eventMethodDelegate, new[] { typeof(IVehicle) }, isAsync: true);
                                    if (scriptFunction == null) return;
                                    OnVehicleRemove += vehicle =>
                                    {
                                        var currScriptFunction = scriptFunction.Clone();
                                        currScriptFunction.Set(vehicle);
                                        return currScriptFunction.CallAsync();
                                    };
                                    break;
                                }
                                case ScriptEventType.PedRemove:
                                {
                                    scriptFunction =
                                        ScriptFunction.Create(eventMethodDelegate, new[] { typeof(IPed) }, isAsync: true);
                                    if (scriptFunction == null) return;
                                    OnPedRemove += ped =>
                                    {
                                        var currScriptFunction = scriptFunction.Clone();
                                        currScriptFunction.Set(ped);
                                        return currScriptFunction.CallAsync();
                                    };
                                    break;
                                }
                                case ScriptEventType.PlayerChangeVehicleSeat:
                                {
                                    scriptFunction =
                                        ScriptFunction.Create(eventMethodDelegate,
                                            new[] { typeof(IVehicle), typeof(IPlayer), typeof(byte), typeof(byte) },
                                            isAsync: true);
                                    if (scriptFunction == null) return;
                                    OnPlayerChangeVehicleSeat += (vehicle, player, seat, newSeat) =>
                                    {
                                        var currScriptFunction = scriptFunction.Clone();
                                        currScriptFunction.Set(vehicle);
                                        currScriptFunction.Set(player);
                                        currScriptFunction.Set(seat);
                                        currScriptFunction.Set(newSeat);
                                        return currScriptFunction.CallAsync();
                                    };
                                    break;
                                }
                                case ScriptEventType.PlayerEnterVehicle:
                                {
                                    scriptFunction =
                                        ScriptFunction.Create(eventMethodDelegate,
                                            new[] { typeof(IVehicle), typeof(IPlayer), typeof(byte) }, isAsync: true);
                                    if (scriptFunction == null) return;
                                    OnPlayerEnterVehicle += (vehicle, player, seat) =>
                                    {
                                        var currScriptFunction = scriptFunction.Clone();
                                        currScriptFunction.Set(vehicle);
                                        currScriptFunction.Set(player);
                                        currScriptFunction.Set(seat);
                                        return currScriptFunction.CallAsync();
                                    };
                                    break;
                                }
                                case ScriptEventType.PlayerEnteringVehicle:
                                {
                                    scriptFunction =
                                        ScriptFunction.Create(eventMethodDelegate,
                                            new[] { typeof(IVehicle), typeof(IPlayer), typeof(byte) }, isAsync: true);
                                    if (scriptFunction == null) return;
                                    OnPlayerEnteringVehicle += (vehicle, player, seat) =>
                                    {
                                        var currScriptFunction = scriptFunction.Clone();
                                        currScriptFunction.Set(vehicle);
                                        currScriptFunction.Set(player);
                                        currScriptFunction.Set(seat);
                                        return currScriptFunction.CallAsync();
                                    };
                                    break;
                                }
                                case ScriptEventType.PlayerLeaveVehicle:
                                {
                                    scriptFunction =
                                        ScriptFunction.Create(eventMethodDelegate,
                                            new[] { typeof(IVehicle), typeof(IPlayer), typeof(byte) }, isAsync: true);
                                    if (scriptFunction == null) return;
                                    OnPlayerLeaveVehicle += (vehicle, player, seat) =>
                                    {
                                        var currScriptFunction = scriptFunction.Clone();
                                        currScriptFunction.Set(vehicle);
                                        currScriptFunction.Set(player);
                                        currScriptFunction.Set(seat);
                                        return currScriptFunction.CallAsync();
                                    };
                                    break;
                                }
                                case ScriptEventType.PlayerEvent:
                                {
                                    scriptFunction =
                                        ScriptFunction.Create(eventMethodDelegate,
                                            new[] { typeof(IPlayer), typeof(string), typeof(object[]) }, isAsync: true);
                                    if (scriptFunction == null) return;
                                    OnPlayerEvent += (player, name, args) =>
                                    {
                                        var currScriptFunction = scriptFunction.Clone();
                                        currScriptFunction.Set(player);
                                        currScriptFunction.Set(name);
                                        currScriptFunction.Set(args);
                                        return currScriptFunction.CallAsync();
                                    };
                                    break;
                                }
                                case ScriptEventType.PlayerCustomEvent:
                                {
                                    Alt.Log("PlayerCustomEvent does not exists in async");
                                    break;
                                }
                                case ScriptEventType.ServerEvent:
                                {
                                    Alt.Log("PlayerCustomEvent does not exists in async");
                                    break;
                                }
                                case ScriptEventType.ServerCustomEvent:
                                {
                                    Alt.Log("PlayerCustomEvent does not exists in async");
                                    break;
                                }
                                case ScriptEventType.ConsoleCommand:
                                {
                                    scriptFunction = ScriptFunction.Create(eventMethodDelegate,
                                        new[] { typeof(string), typeof(string[]) }, isAsync: true);
                                    if (scriptFunction == null) return;
                                    OnConsoleCommand += (name, args) =>
                                    {
                                        var currScriptFunction = scriptFunction.Clone();
                                        currScriptFunction.Set(name);
                                        currScriptFunction.Set(args);
                                        return currScriptFunction.CallAsync();
                                    };
                                    break;
                                }
                                case ScriptEventType.MetaDataChange:
                                {
                                    scriptFunction = ScriptFunction.Create(eventMethodDelegate,
                                        new[] { typeof(IEntity), typeof(string), typeof(object) }, isAsync: true);
                                    if (scriptFunction == null) return;
                                    OnMetaDataChange += (entity, key, value) =>
                                    {
                                        var currScriptFunction = scriptFunction.Clone();
                                        currScriptFunction.Set(entity);
                                        currScriptFunction.Set(key);
                                        currScriptFunction.Set(value);
                                        return currScriptFunction.CallAsync();
                                    };
                                    break;
                                }
                                case ScriptEventType.SyncedMetaDataChange:
                                {
                                    scriptFunction = ScriptFunction.Create(eventMethodDelegate,
                                        new[] { typeof(IEntity), typeof(string), typeof(object) }, isAsync: true);
                                    if (scriptFunction == null) return;
                                    OnSyncedMetaDataChange += (entity, key, value) =>
                                    {
                                        var currScriptFunction = scriptFunction.Clone();
                                        currScriptFunction.Set(entity);
                                        currScriptFunction.Set(key);
                                        currScriptFunction.Set(value);
                                        return currScriptFunction.CallAsync();
                                    };
                                    break;
                                }
                                case ScriptEventType.ColShape:
                                {
                                    scriptFunction = ScriptFunction.Create(eventMethodDelegate,
                                        new[] { typeof(IColShape), typeof(IEntity), typeof(bool) }, isAsync: true);
                                    if (scriptFunction == null) return;
                                    OnColShape += (shape, entity, state) =>
                                    {
                                        var currScriptFunction = scriptFunction.Clone();
                                        currScriptFunction.Set(shape);
                                        currScriptFunction.Set(entity);
                                        currScriptFunction.Set(state);
                                        return currScriptFunction.CallAsync();
                                    };
                                    break;
                                }
                                case ScriptEventType.WeaponDamage:
                                {
                                    scriptFunction = ScriptFunction.Create(eventMethodDelegate,
                                        new[]
                                        {
                                            typeof(IPlayer), typeof(IEntity), typeof(uint), typeof(ushort),
                                            typeof(Position), typeof(BodyPart), typeof(IEntity)
                                        }, isAsync: true);
                                    if (scriptFunction == null) return;
                                    OnWeaponDamage +=
                                        (player, targetEntity, weapon, damage, shotOffset, damageOffset, sourceEntity) =>
                                        {
                                            var currScriptFunction = scriptFunction.Clone();
                                            currScriptFunction.Set(player);
                                            currScriptFunction.Set(targetEntity);
                                            currScriptFunction.Set(weapon);
                                            currScriptFunction.Set(damage);
                                            currScriptFunction.Set(shotOffset);
                                            currScriptFunction.Set(damageOffset);
                                            currScriptFunction.Set(sourceEntity);
                                            return currScriptFunction.CallAsync();
                                        };
                                    break;
                                }
                                case ScriptEventType.VehicleDestroy:
                                {
                                    scriptFunction = ScriptFunction.Create(eventMethodDelegate,
                                        new[]
                                        {
                                            typeof(IVehicle)
                                        }, isAsync: true);
                                    if (scriptFunction == null) return;
                                    OnVehicleDestroy +=
                                        vehicle =>
                                        {
                                            var currScriptFunction = scriptFunction.Clone();
                                            currScriptFunction.Set(vehicle);
                                            return currScriptFunction.CallAsync();
                                        };
                                    break;
                                }
                                case ScriptEventType.Explosion:
                                {
                                    scriptFunction = ScriptFunction.Create(eventMethodDelegate,
                                        new[]
                                        {
                                            typeof(IPlayer), typeof(ExplosionType), typeof(Position), typeof(uint),
                                            typeof(IEntity)
                                        }, isAsync: true);
                                    if (scriptFunction == null) return;
                                    OnExplosion += (player, explosionType, position, explosionFx, targetEntity) =>
                                    {
                                        var currScriptFunction = scriptFunction.Clone();
                                        currScriptFunction.Set(player);
                                        currScriptFunction.Set(explosionType);
                                        currScriptFunction.Set(position);
                                        currScriptFunction.Set(explosionFx);
                                        currScriptFunction.Set(targetEntity);
                                        return currScriptFunction.CallAsync();
                                    };
                                    break;
                                }
                                case ScriptEventType.Fire:
                                {
                                    scriptFunction = ScriptFunction.Create(eventMethodDelegate,
                                        new[]
                                        {
                                            typeof(IPlayer), typeof(FireInfo[])
                                        }, isAsync: true);
                                    if (scriptFunction == null) return;
                                    OnFire += (player, fireInfos) =>
                                    {
                                        var currScriptFunction = scriptFunction.Clone();
                                        currScriptFunction.Set(player);
                                        currScriptFunction.Set(fireInfos);
                                        return currScriptFunction.CallAsync();
                                    };
                                    break;
                                }
                                case ScriptEventType.StartProjectile:
                                {
                                    scriptFunction = ScriptFunction.Create(eventMethodDelegate,
                                        new[]
                                        {
                                            typeof(IPlayer), typeof(Position), typeof(Position), typeof(uint),
                                            typeof(uint)
                                        }, isAsync: true);
                                    if (scriptFunction == null) return;
                                    OnStartProjectile += (player, startPosition, direction, ammoHash, weaponHash) =>
                                    {
                                        var currScriptFunction = scriptFunction.Clone();
                                        currScriptFunction.Set(player);
                                        currScriptFunction.Set(startPosition);
                                        currScriptFunction.Set(direction);
                                        currScriptFunction.Set(ammoHash);
                                        currScriptFunction.Set(weaponHash);
                                        return currScriptFunction.CallAsync();
                                    };
                                    break;
                                }
                                case ScriptEventType.PlayerWeaponChange:
                                {
                                    scriptFunction = ScriptFunction.Create(eventMethodDelegate,
                                        new[]
                                        {
                                            typeof(IPlayer), typeof(uint), typeof(uint)
                                        }, isAsync: true);
                                    if (scriptFunction == null) return;
                                    OnPlayerWeaponChange += (player, oldWeapon, newWeapon) =>
                                    {
                                        var currScriptFunction = scriptFunction.Clone();
                                        currScriptFunction.Set(player);
                                        currScriptFunction.Set(oldWeapon);
                                        currScriptFunction.Set(newWeapon);
                                        return currScriptFunction.CallAsync();
                                    };
                                    break;
                                }
                                case ScriptEventType.NetOwnerChange:
                                {
                                    scriptFunction = ScriptFunction.Create(eventMethodDelegate,
                                        new[]
                                        {
                                            typeof(IEntity), typeof(IPlayer), typeof(IPlayer)
                                        }, isAsync: true);
                                    if (scriptFunction == null) return;
                                    OnNetworkOwnerChange += (targetEntity, oldNetOwner, newNetOwner) =>
                                    {
                                        var currScriptFunction = scriptFunction.Clone();
                                        currScriptFunction.Set(targetEntity);
                                        currScriptFunction.Set(oldNetOwner);
                                        currScriptFunction.Set(newNetOwner);
                                        return currScriptFunction.CallAsync();
                                    };
                                    break;
                                }
                                case ScriptEventType.VehicleAttach:
                                {
                                    scriptFunction = ScriptFunction.Create(eventMethodDelegate,
                                        new[]
                                        {
                                            typeof(IVehicle), typeof(IVehicle)
                                        }, isAsync: true);
                                    if (scriptFunction == null) return;
                                    OnVehicleAttach += (targetVehicle, attachedVehicle) =>
                                    {
                                        var currScriptFunction = scriptFunction.Clone();
                                        currScriptFunction.Set(targetVehicle);
                                        currScriptFunction.Set(attachedVehicle);
                                        return currScriptFunction.CallAsync();
                                    };
                                    break;
                                }
                                case ScriptEventType.VehicleDetach:
                                {
                                    scriptFunction = ScriptFunction.Create(eventMethodDelegate,
                                        new[]
                                        {
                                            typeof(IVehicle), typeof(IVehicle)
                                        }, isAsync: true);
                                    if (scriptFunction == null) return;
                                    OnVehicleDetach += (targetVehicle, detachedVehicle) =>
                                    {
                                        var currScriptFunction = scriptFunction.Clone();
                                        currScriptFunction.Set(targetVehicle);
                                        currScriptFunction.Set(detachedVehicle);
                                        return currScriptFunction.CallAsync();
                                    };
                                    break;
                                }
                                case ScriptEventType.VehicleDamage:
                                {
                                    scriptFunction = ScriptFunction.Create(eventMethodDelegate,
                                        new[]
                                        {
                                            typeof(IVehicle), typeof(IEntity), typeof(uint), typeof(uint),
                                            typeof(uint), typeof(uint), typeof(uint)
                                        }, isAsync: true);
                                    if (scriptFunction == null) return;
                                    OnVehicleDamage +=
                                        (vehicle, targetEntity, bodyHealthDamage, additionalBodyHealthDamage,
                                            engineHealthDamage, petrolTankDamage, weaponHash) =>
                                        {
                                            var currScriptFunction = scriptFunction.Clone();
                                            currScriptFunction.Set(vehicle);
                                            currScriptFunction.Set(targetEntity);
                                            currScriptFunction.Set(bodyHealthDamage);
                                            currScriptFunction.Set(additionalBodyHealthDamage);
                                            currScriptFunction.Set(engineHealthDamage);
                                            currScriptFunction.Set(petrolTankDamage);
                                            currScriptFunction.Set(weaponHash);
                                            return currScriptFunction.CallAsync();
                                        };
                                    break;
                                }
                                case ScriptEventType.VehicleHorn:
                                {
                                    scriptFunction = ScriptFunction.Create(eventMethodDelegate,
                                        new[]
                                        {
                                            typeof(IVehicle), typeof(IPlayer), typeof(bool)
                                        }, isAsync: true);
                                    if (scriptFunction == null) return;
                                    OnVehicleHorn +=
                                        (targetVehicle, reporterPlayer, state) =>
                                        {
                                            var currScriptFunction = scriptFunction.Clone();
                                            currScriptFunction.Set(targetVehicle);
                                            currScriptFunction.Set(reporterPlayer);
                                            currScriptFunction.Set(state);
                                            return currScriptFunction.CallAsync();
                                        };
                                    break;
                                }
                                case ScriptEventType.ConnectionQueueAdd:
                                {
                                    scriptFunction = ScriptFunction.Create(eventMethodDelegate,
                                        new[]
                                        {
                                            typeof(IConnectionInfo)
                                        }, isAsync: true);
                                    if (scriptFunction == null) return;
                                    OnConnectionQueueAdd +=
                                        (connectionInfo) =>
                                        {
                                            var currScriptFunction = scriptFunction.Clone();
                                            currScriptFunction.Set(connectionInfo);
                                            return currScriptFunction.CallAsync();
                                        };
                                    break;
                                }
                                case ScriptEventType.ConnectionQueueRemove:
                                {
                                    scriptFunction = ScriptFunction.Create(eventMethodDelegate,
                                        new[]
                                        {
                                            typeof(IConnectionInfo)
                                        }, isAsync: true);
                                    if (scriptFunction == null) return;
                                    OnConnectionQueueRemove +=
                                        (connectionInfo) =>
                                        {
                                            var currScriptFunction = scriptFunction.Clone();
                                            currScriptFunction.Set(connectionInfo);
                                            return currScriptFunction.CallAsync();
                                        };
                                    break;
                                }
                                case ScriptEventType.ServerStarted:
                                {
                                    scriptFunction = ScriptFunction.Create(eventMethodDelegate,
                                        Array.Empty<Type>(), isAsync: true);
                                    if (scriptFunction == null) return;
                                    OnServerStarted +=
                                        () =>
                                        {
                                            var currScriptFunction = scriptFunction.Clone();
                                            return currScriptFunction.CallAsync();
                                        };
                                    break;
                                }
                                case ScriptEventType.PlayerRequestControl:
                                {
                                    scriptFunction = ScriptFunction.Create(eventMethodDelegate,
                                        new[]
                                        {
                                            typeof(IEntity),
                                            typeof(IPlayer)
                                        }, isAsync: true);
                                    if (scriptFunction == null) return;
                                    OnPlayerRequestControl +=
                                        (entity, player) =>
                                        {
                                            var currScriptFunction = scriptFunction.Clone();
                                            currScriptFunction.Set(entity);
                                            currScriptFunction.Set(player);
                                            return currScriptFunction.CallAsync();
                                        };
                                    break;
                                }
                                case ScriptEventType.PlayerChangeAnimation:
                                {
                                    scriptFunction = ScriptFunction.Create(eventMethodDelegate,
                                        new[]
                                        {
                                            typeof(IEntity), typeof(uint), typeof(uint), typeof(uint), typeof(uint)
                                        }, isAsync: true);
                                    if (scriptFunction == null) return;
                                    OnPlayerChangeAnimation +=
                                        (entity, oldDict, newDict, oldName, newName) =>
                                        {
                                            var currScriptFunction = scriptFunction.Clone();
                                            currScriptFunction.Set(entity);
                                            currScriptFunction.Set(oldDict);
                                            currScriptFunction.Set(newDict);
                                            currScriptFunction.Set(oldName);
                                            currScriptFunction.Set(newName);
                                            return currScriptFunction.CallAsync();
                                        };
                                    break;
                                }
                                case ScriptEventType.PlayerChangeInterior:
                                {
                                    scriptFunction = ScriptFunction.Create(eventMethodDelegate,
                                        new[]
                                        {
                                            typeof(IEntity), typeof(uint), typeof(uint)
                                        }, isAsync: true);
                                    if (scriptFunction == null) return;
                                    OnPlayerChangeInterior +=
                                        (entity, oldIntLoc, newIntLoc) =>
                                        {
                                            var currScriptFunction = scriptFunction.Clone();
                                            currScriptFunction.Set(entity);
                                            currScriptFunction.Set(oldIntLoc);
                                            currScriptFunction.Set(newIntLoc);
                                            return currScriptFunction.CallAsync();
                                        };
                                    break;
                                }
                                case ScriptEventType.PlayerDimensionChange:
                                {
                                    scriptFunction = ScriptFunction.Create(eventMethodDelegate,
                                        new[]
                                        {
                                            typeof(IPlayer), typeof(int), typeof(int)
                                        }, isAsync: true);
                                    if (scriptFunction == null) return;
                                    OnPlayerDimensionChange +=
                                        (entity, oldDimension, newDimension) =>
                                        {
                                            var currScriptFunction = scriptFunction.Clone();
                                            currScriptFunction.Set(entity);
                                            currScriptFunction.Set(oldDimension);
                                            currScriptFunction.Set(newDimension);
                                            return currScriptFunction.CallAsync();
                                        };
                                    break;
                                }
                                case ScriptEventType.VehicleSiren:
                                {
                                    scriptFunction = ScriptFunction.Create(eventMethodDelegate,
                                        new[]
                                        {
                                            typeof(IVehicle), typeof(bool)
                                        }, isAsync: true);
                                    if (scriptFunction == null) return;
                                    OnVehicleSiren +=
                                        (targetVehicle, state) =>
                                        {
                                            var currScriptFunction = scriptFunction.Clone();
                                            currScriptFunction.Set(targetVehicle);
                                            currScriptFunction.Set(state);
                                            return currScriptFunction.CallAsync();
                                        };
                                    break;
                                }
                                case ScriptEventType.PlayerSpawn:
                                {
                                    scriptFunction = ScriptFunction.Create(eventMethodDelegate,
                                        new[]
                                        {
                                            typeof(IPlayer)
                                        }, isAsync: true);
                                    if (scriptFunction == null) return;
                                    OnPlayerSpawn +=
                                        (player) =>
                                        {
                                            var currScriptFunction = scriptFunction.Clone();
                                            currScriptFunction.Set(player);
                                            return currScriptFunction.CallAsync();
                                        };
                                    break;
                                }
                            }

                            break;
                        case AsyncServerEventAttribute @event:
                            var serverEventName = @event.Name ?? eventMethod.Name;
                            CoreImpl.OnServer(serverEventName, Function.Create(CoreImpl, eventMethodDelegate));
                            break;
                        case AsyncClientEventAttribute @event:
                            var clientEventName = @event.Name ?? eventMethod.Name;
                            CoreImpl.OnClient(clientEventName, Function.Create(CoreImpl, eventMethodDelegate));
                            break;
                    }
                });
        }
    }
}