﻿using System.Numerics;
using System.Runtime.InteropServices;
using AltV.Net.Client.Elements.Interfaces;
using AltV.Net.Data;
using AltV.Net.Elements.Entities;
using AltV.Net.Shared.Elements.Entities;

namespace AltV.Net.Client.Elements.Entities
{
    public class Player : Entity, IPlayer
    {
        private static IntPtr GetEntityPointer(ICore core, IntPtr playerNativePointer)
        {
            unsafe
            {
                return core.Library.Shared.Player_GetEntity(playerNativePointer);
            }
        }

        public IntPtr PlayerNativePointer { get; private set; }
        public override IntPtr NativePointer => PlayerNativePointer;

        public Player(ICore core, IntPtr playerPointer, uint id) : base(core, GetEntityPointer(core, playerPointer), id, BaseObjectType.Player)
        {
            PlayerNativePointer = playerPointer;
        }

        public Player(ICore core, IntPtr playerPointer, uint id, BaseObjectType baseObjectType) : base(core, GetEntityPointer(core, playerPointer), id, baseObjectType)
        {
            PlayerNativePointer = playerPointer;
        }

        public virtual bool IsLocal => false;
        public void AddFilter(IAudioFilter filter)
        {
            unsafe
            {
                CheckIfEntityExists();
                Core.Library.Client.Player_AddFilter(PlayerNativePointer, filter.AudioFilterNativePointer);
            }
        }

        public void RemoveFilter()
        {
            unsafe
            {
                CheckIfEntityExists();
                Core.Library.Client.Player_RemoveFilter(PlayerNativePointer);
            }
        }

        public IAudioFilter GetFilter()
        {
            unsafe
            {
                CheckIfEntityExistsOrCached();
                var ptr = Core.Library.Client.Player_GetFilter(PlayerNativePointer);
                if (ptr == IntPtr.Zero) return null;

                return Alt.CoreImpl.PoolManager.AudioFilter.Get(ptr);
            }
        }

        public string TaskData
        {
            get
            {
                unsafe
                {
                    CheckIfEntityExistsOrCached();
                    var size = 0;
                    return Core.PtrToStringUtf8AndFree(
                        Core.Library.Client.Player_GetTaskData(PlayerNativePointer, &size), size);
                }
            }
        }

        public IVehicle? Vehicle
        {
            get
            {
                unsafe
                {
                    CheckIfEntityExistsOrCached();
                    var ptr = Core.Library.Shared.Player_GetVehicle(PlayerNativePointer);
                    if (ptr == IntPtr.Zero) return null;

                    return Alt.CoreImpl.PoolManager.Vehicle.Get(ptr);
                }
            }
        }
        ISharedVehicle ISharedPlayer.Vehicle => Vehicle!;

        public bool IsInVehicle
        {
            get
            {
                unsafe
                {
                    CheckIfEntityExistsOrCached();
                    return Core.Library.Shared.Player_IsInVehicle(PlayerNativePointer) == 1;
                }
            }
        }

        public string Name
        {
            get
            {
                unsafe
                {
                    CheckIfEntityExistsOrCached();
                    int size = 0;
                    var str = Alt.CoreImpl.Library.Shared.Player_GetName(this.PlayerNativePointer, &size);
                    var stringResult = Marshal.PtrToStringUTF8(str, size);
                    Core.Library.Shared.FreeString(str);
                    return stringResult;
                }
            }
        }

        public Position AimPosition
        {
            get
            {
                unsafe
                {
                    CheckIfEntityExistsOrCached();
                    var position = Vector3.Zero;
                    this.Core.Library.Shared.Player_GetAimPos(this.PlayerNativePointer, &position);
                    return position;
                }
            }
        }

        public ushort Armor
        {
            get
            {
                unsafe
                {
                    CheckIfEntityExistsOrCached();
                    return this.Core.Library.Shared.Player_GetArmor(this.PlayerNativePointer);
                }
            }
        }

        public uint CurrentWeapon
        {
            get
            {
                unsafe
                {
                    CheckIfEntityExistsOrCached();
                    return this.Core.Library.Shared.Player_GetCurrentWeapon(this.PlayerNativePointer);
                }
            }
        }

        public Position EntityAimOffset
        {
            get
            {
                unsafe
                {
                    CheckIfEntityExistsOrCached();
                    var position = Vector3.Zero;
                    this.Core.Library.Shared.Player_GetEntityAimOffset(this.PlayerNativePointer, &position);
                    return position;
                }
            }
        }

        public IEntity? EntityAimingAt
        {
            get
            {
                unsafe
                {
                    CheckIfEntityExistsOrCached();
                    BaseObjectType type = BaseObjectType.Undefined;
                    var ptr = this.Core.Library.Shared.Player_GetEntityAimingAt(this.PlayerNativePointer, &type);
                    if (ptr == IntPtr.Zero) return null;

                    var entity = (IEntity)Core.PoolManager.Get(ptr, type);
                    return entity;
                }
            }
        }

        public void GetCurrentWeaponComponents(out uint[] weaponComponents)
        {
            unsafe
            {
                CheckIfEntityExists();
                var ptr = IntPtr.Zero;
                uint size = 0;
                Core.Library.Shared.Player_GetCurrentWeaponComponents(PlayerNativePointer, &ptr, &size);


                var uintArray = new UIntArray
                {
                    data = ptr,
                    size = size,
                    capacity = size
                };

                var result = uintArray.ToArray();

                Core.Library.Shared.FreeUInt32Array(ptr);

                weaponComponents = result;
            }
        }

        public bool IsParachuting
        {
            get
            {
                unsafe
                {
                    CheckIfEntityExistsOrCached();
                    return this.Core.Library.Shared.Player_IsParachuting(this.PlayerNativePointer) == 1;
                }
            }
        }

        public bool IsInWater 
        {
            get
            {
                unsafe
                {
                    CheckIfEntityExistsOrCached();
                    return this.Core.Library.Shared.Player_IsInWater(this.PlayerNativePointer) == 1;
                }
            }
        }

        ISharedEntity ISharedPlayer.EntityAimingAt => EntityAimingAt!;

        public bool IsFlashlightActive
        {
            get
            {
                unsafe
                {
                    CheckIfEntityExistsOrCached();
                    return this.Core.Library.Shared.Player_IsFlashlightActive(this.PlayerNativePointer) == 1;
                }
            }
        }

        public Rotation HeadRotation
        {
            get
            {
                unsafe
                {
                    CheckIfEntityExistsOrCached();
                    var position = Rotation.Zero;
                    this.Core.Library.Shared.Player_GetHeadRotation(this.PlayerNativePointer, &position);
                    return position;
                }
            }
        }

        public ushort Health
        {
            get
            {
                unsafe
                {
                    CheckIfEntityExistsOrCached();
                    return this.Core.Library.Shared.Player_GetHealth(this.PlayerNativePointer);
                }
            }
        }

        public bool IsAiming
        {
            get
            {
                unsafe
                {
                    CheckIfEntityExistsOrCached();
                    return this.Core.Library.Shared.Player_IsAiming(this.PlayerNativePointer) == 1;
                }
            }
        }

        public bool IsDead
        {
            get
            {
                unsafe
                {
                    CheckIfEntityExistsOrCached();
                    return this.Core.Library.Shared.Player_IsDead(this.PlayerNativePointer) == 1;
                }
            }
        }

        public bool IsInRagdoll
        {
            get
            {
                unsafe
                {
                    CheckIfEntityExistsOrCached();
                    return this.Core.Library.Shared.Player_IsInRagdoll(this.PlayerNativePointer) == 1;
                }
            }
        }

        public bool IsReloading
        {
            get
            {
                unsafe
                {
                    CheckIfEntityExistsOrCached();
                    return this.Core.Library.Shared.Player_IsReloading(this.PlayerNativePointer) == 1;
                }
            }
        }

        public bool IsEnteringVehicle
        {
            get
            {
                unsafe
                {
                    CheckIfEntityExistsOrCached();
                    return this.Core.Library.Shared.Player_IsEnteringVehicle(this.PlayerNativePointer) == 1;
                }
            }
        }
        public bool IsLeavingVehicle
        {
            get
            {
                unsafe
                {
                    CheckIfEntityExistsOrCached();
                    return this.Core.Library.Shared.Player_IsLeavingVehicle(this.PlayerNativePointer) == 1;
                }
            }
        }
        public bool IsOnLadder
        {
            get
            {
                unsafe
                {
                    CheckIfEntityExistsOrCached();
                    return this.Core.Library.Shared.Player_IsOnLadder(this.PlayerNativePointer) == 1;
                }
            }
        }
        public bool IsInMelee
        {
            get
            {
                unsafe
                {
                    CheckIfEntityExistsOrCached();
                    return this.Core.Library.Shared.Player_IsInMelee(this.PlayerNativePointer) == 1;
                }
            }
        }
        public bool IsInCover
        {
            get
            {
                unsafe
                {
                    CheckIfEntityExistsOrCached();
                    return this.Core.Library.Shared.Player_IsInCover(this.PlayerNativePointer) == 1;
                }
            }
        }

        public bool IsTalking
        {
            get
            {
                unsafe
                {
                    CheckIfEntityExistsOrCached();
                    return this.Core.Library.Client.Player_IsTalking(this.PlayerNativePointer) == 1;
                }
            }
        }

        public ushort MaxArmor
        {
            get
            {
                unsafe
                {
                    CheckIfEntityExistsOrCached();
                    return this.Core.Library.Shared.Player_GetMaxArmor(this.PlayerNativePointer);
                }
            }
        }

        public ushort MaxHealth
        {
            get
            {
                unsafe
                {
                    CheckIfEntityExistsOrCached();
                    return this.Core.Library.Shared.Player_GetMaxHealth(this.PlayerNativePointer);
                }
            }
        }

        public float MicLevel
        {
            get
            {
                unsafe
                {
                    CheckIfEntityExistsOrCached();
                    return this.Core.Library.Client.Player_GetMicLevel(this.PlayerNativePointer);
                }
            }
        }

        public float MoveSpeed
        {
            get
            {
                unsafe
                {
                    CheckIfEntityExistsOrCached();
                    return this.Core.Library.Shared.Player_GetMoveSpeed(this.PlayerNativePointer);
                }
            }
        }

        public float ForwardSpeed
        {
            get
            {
                unsafe
                {
                    CheckIfEntityExistsOrCached();
                    return this.Core.Library.Shared.Player_GetForwardSpeed(this.PlayerNativePointer);
                }
            }
        }

        public float StrafeSpeed
        {
            get
            {
                unsafe
                {
                    CheckIfEntityExistsOrCached();
                    return this.Core.Library.Shared.Player_GetStrafeSpeed(this.PlayerNativePointer);
                }
            }
        }

        public float NonSpatialVolume
        {
            get
            {
                unsafe
                {
                    CheckIfEntityExistsOrCached();
                    return this.Core.Library.Client.Player_GetNonSpatialVolume(this.PlayerNativePointer);
                }
            }
            set
            {
                unsafe
                {
                    CheckIfEntityExists();
                    this.Core.Library.Client.Player_SetNonSpatialVolume(this.PlayerNativePointer, value);
                }
            }
        }

        public byte Seat
        {
            get
            {
                unsafe
                {
                    CheckIfEntityExistsOrCached();
                    return this.Core.Library.Shared.Player_GetSeat(this.PlayerNativePointer);
                }
            }
        }

        public float SpatialVolume
        {
            get
            {
                unsafe
                {
                    CheckIfEntityExistsOrCached();
                    return this.Core.Library.Client.Player_GetSpatialVolume(this.PlayerNativePointer);
                }
            }
            set
            {
                unsafe
                {
                    CheckIfEntityExists();
                    this.Core.Library.Client.Player_SetSpatialVolume(this.PlayerNativePointer, value);
                }
            }
        }

        public bool IsSpawned
        {
            get
            {
                unsafe
                {
                    CheckIfEntityExistsOrCached();
                    return Core.Library.Shared.Player_IsSpawned(PlayerNativePointer) == 1;
                }
            }
        }

        public uint CurrentAnimationDict
        {
            get
            {
                unsafe
                {
                    CheckIfEntityExistsOrCached();
                    return Core.Library.Shared.Player_GetCurrentAnimationDict(PlayerNativePointer);
                }
            }
        }

        public uint CurrentAnimationName
        {
            get
            {
                unsafe
                {
                    CheckIfEntityExistsOrCached();
                    return Core.Library.Shared.Player_GetCurrentAnimationName(PlayerNativePointer);
                }
            }
        }

        public override void SetCached(IntPtr cachedPlayer)
        {
            this.PlayerNativePointer = cachedPlayer;
            base.SetCached(GetEntityPointer(Core, cachedPlayer));
        }

    }
}