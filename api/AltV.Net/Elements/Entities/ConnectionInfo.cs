using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using AltV.Net.CApi.ServerEvents;
using AltV.Net.Data;
using AltV.Net.Native;
using AltV.Net.Shared.Utils;

namespace AltV.Net.Elements.Entities;

public class ConnectionInfo : BaseObject, IConnectionInfo
{
    public IntPtr ConnectionInfoNativePointer { get; }
    public override IntPtr NativePointer => ConnectionInfoNativePointer;

    private static IntPtr GetBaseObjectPointer(ICore core, IntPtr virtualEntityGroupNativePointer)
    {
        unsafe
        {
            return core.Library.Server.ConnectionInfo_GetBaseObject(virtualEntityGroupNativePointer);
        }
    }

    public static uint GetId(IntPtr pointer)
    {
        unsafe
        {
            return Alt.CoreImpl.Library.Server.ConnectionInfo_GetID(pointer);
        }
    }


    public ConnectionInfo(ICore core, IntPtr nativePointer, uint id) : base(core,
        GetBaseObjectPointer(core, nativePointer), BaseObjectType.ConnectionInfo, id)
    {
        ConnectionInfoNativePointer = nativePointer;
    }

    public string Name
    {
        get
        {
            unsafe
            {
                var size = 0;
                return Core.PtrToStringUtf8AndFree(
                    Core.Library.Server.ConnectionInfo_GetName(ConnectionInfoNativePointer, &size), size);
            }
        }
    }

    public ulong SocialId
    {
        get
        {
            unsafe
            {
                return Core.Library.Server.ConnectionInfo_GetSocialId(ConnectionInfoNativePointer);
            }
        }
    }

    public ulong HardwareIdHash
    {
        get
        {
            unsafe
            {
                return Core.Library.Server.ConnectionInfo_GetHwIdHash(ConnectionInfoNativePointer);
            }
        }
    }

    public ulong HardwareIdExHash
    {
        get
        {
            unsafe
            {
                return Core.Library.Server.ConnectionInfo_GetHwIdExHash(ConnectionInfoNativePointer);
            }
        }
    }

    public string HardwareId3
    {
        get
        {
            unsafe
            {
                var size = 0;
                return Core.PtrToStringUtf8AndFree(
                    Core.Library.Server.ConnectionInfo_GetHwid3(ConnectionInfoNativePointer, &size), size);
            }
        }
    }

    public string AuthToken
    {
        get
        {
            unsafe
            {
                var size = 0;
                return Core.PtrToStringUtf8AndFree(
                    Core.Library.Server.ConnectionInfo_GetAuthToken(ConnectionInfoNativePointer, &size), size);
            }
        }
    }

    public bool IsDebug
    {
        get
        {
            unsafe
            {
                return Core.Library.Server.ConnectionInfo_GetIsDebug(ConnectionInfoNativePointer) == 1;
            }
        }
    }

    public string Branch
    {
        get
        {
            unsafe
            {
                var size = 0;
                return Core.PtrToStringUtf8AndFree(
                    Core.Library.Server.ConnectionInfo_GetBranch(ConnectionInfoNativePointer, &size), size);
            }
        }
    }

    public ushort VersionMajor
    {
        get
        {
            unsafe
            {
                return Core.Library.Server.ConnectionInfo_GetVersionMajor(ConnectionInfoNativePointer);
            }
        }
    }

    public ushort VersionMinor
    {
        get
        {
            unsafe
            {
                return Core.Library.Server.ConnectionInfo_GetVersionMinor(ConnectionInfoNativePointer);
            }
        }
    }

    public string CdnUrl
    {
        get
        {
            unsafe
            {
                var size = 0;
                return Core.PtrToStringUtf8AndFree(
                    Core.Library.Server.ConnectionInfo_GetCdnUrl(ConnectionInfoNativePointer, &size), size);
            }
        }
    }

    public ulong PasswordHash
    {
        get
        {
            unsafe
            {
                return Core.Library.Server.ConnectionInfo_GetPasswordHash(ConnectionInfoNativePointer);
            }
        }
    }

    public string Ip
    {
        get
        {
            unsafe
            {
                var size = 0;
                return Core.PtrToStringUtf8AndFree(
                    Core.Library.Server.ConnectionInfo_GetIp(ConnectionInfoNativePointer, &size), size);
            }
        }
    }

    public long DiscordUserId
    {
        get
        {
            unsafe
            {
                return Core.Library.Server.ConnectionInfo_GetDiscordUserID(ConnectionInfoNativePointer);
            }
        }
    }

    public string SocialName
    {
        get
        {
            unsafe
            {
                var size = 0;
                return Core.PtrToStringUtf8AndFree(
                    Core.Library.Server.ConnectionInfo_GetSocialName(ConnectionInfoNativePointer, &size), size);
            }
        }
    }

    public string Text
    {
        get
        {
            unsafe
            {
                var size = 0;
                return Core.PtrToStringUtf8AndFree(
                    Core.Library.Server.ConnectionInfo_GetText(ConnectionInfoNativePointer, &size), size);
            }
        }
        set
        {
            unsafe
            {
                CheckIfEntityExists();
                var stringPtr = MemoryUtils.StringToHGlobalUtf8(value);
                Core.Library.Server.ConnectionInfo_SetText(ConnectionInfoNativePointer, stringPtr);
                Marshal.FreeHGlobal(stringPtr);
            }
        }
    }

    public bool IsAccepted
    {
        get
        {
            unsafe
            {
                return Core.Library.Server.ConnectionInfo_IsAccepted(ConnectionInfoNativePointer) == 1;
            }
        }
    }

    public void Accept(bool sendNames = true)
    {
        unsafe
        {
            Core.Library.Server.ConnectionInfo_Accept(ConnectionInfoNativePointer, sendNames ? (byte)1 : (byte)0);
        }
    }

    public void Decline(string reason)
    {
        unsafe
        {
            var stringPtr = MemoryUtils.StringToHGlobalUtf8(reason);
            Core.Library.Server.ConnectionInfo_Decline(ConnectionInfoNativePointer, stringPtr);
            Marshal.FreeHGlobal(stringPtr);
        }
    }

    public string CloudId
    {
        get
        {
            unsafe
            {
                var size = 0;
                return Core.PtrToStringUtf8AndFree(
                    Core.Library.Server.ConnectionInfo_GetCloudID(ConnectionInfoNativePointer, &size), size);
            }
        }
    }

    public CloudAuthResult CloudAuthResult
    {
        get
        {
            unsafe
            {
                return (CloudAuthResult)Core.Library.Server.ConnectionInfo_GetCloudAuthResult(
                    ConnectionInfoNativePointer);
            }
        }
    }
}