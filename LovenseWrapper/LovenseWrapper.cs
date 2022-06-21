// ----------------------------------------------------------------------------
// Generated with CppSharp
// Curated manually :) to avaid exposing internal methods and properties ...
// Brought to you by CamModelTools 
// MIT license
// ----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;
using __CallingConvention = global::System.Runtime.InteropServices.CallingConvention;
using __IntPtr = global::System.IntPtr;

namespace LovenseWrapper
{
    namespace CLovenseToy
    {
        public enum CmdType
        {
            COMMAND_UNKNOWN = -1,
            COMMAND_CONNECT_TOY = 0,
            COMMAND_DISCONNECT_TOY = 1,
            /// <summary>
            /// <para>-Power off!</para>
            /// <para>- param Key = no parameter</para>
            /// </summary>
            COMMAND_POWER_OFF = 100,
            /// <summary>
            /// <para>- Vibrate the toy .The parameter must be between 0 and 20!</para>
            /// <para>- Supported toys = all</para>
            /// </summary>
            COMMAND_VIBRATE = 101,
            /// <summary>
            /// <para>- Rotate the toy .The parameter must be between 0 and 20!</para>
            /// <para>- Supported toys = Nora</para>
            /// </summary>
            COMMAND_ROTATE = 102,
            /// <summary>
            /// <para>- Rotate clockwise .The parameter must be between 0 and 20!</para>
            /// <para>- Supported toys = Nora</para>
            /// </summary>
            COMMAND_ROTATE_CLOCKWISE = 103,
            /// <summary>
            /// <para>- Rotate anti-clockwise .The parameter must be between 0 and 20!</para>
            /// <para>- Supported toys = Nora</para>
            /// </summary>
            COMMAND_ROTATE_ANTI_CLOCKWISE = 104,
            /// <summary>
            /// <para>- Change the rotation direction</para>
            /// <para>- param Key = no parameter</para>
            /// <para>- Supported toys = Nora</para>
            /// </summary>
            COMMAND_ROTATE_CHANGE = 105,
            /// <summary>
            /// <para>- Activate the first vibrator at level n .The parameter must be between 0 and 20!</para>
            /// <para>- param Key = kSendCommandParamKey_VibrateLevel</para>
            /// <para>- Supported toys = Edge</para>
            /// </summary>
            COMMAND_VIBRATE1 = 113,
            /// <summary>
            /// <para>- Activate the second vibrator at level n .The parameter must be between 0 and 20!</para>
            /// <para>- param Key = kSendCommandParamKey_VibrateLevel</para>
            /// <para>- Supported toys = Edge</para>
            /// </summary>
            COMMAND_VIBRATE2 = 114,
            /// <summary>
            /// <para>- Vibrate the toy at level n, and flash the light at the same time .The parameter must be between 0 and 20!</para>
            /// <para>- param key = kSendCommandParamKey_VibrateLevel: vibration level (between 1~3)</para>
            /// <para>- param key = kSendCommandParamKey_FlashLevel: Flashing frequency (per second). Between 0~9</para>
            /// <para>- Supported toys = Ambi / Domi / Osci</para>
            /// </summary>
            COMMAND_VIBRATE_FLASH = 120,
            /// <summary>
            /// <para>- Flash the light 3 times</para>
            /// <para>- param Key = no parameter</para>
            /// <para>- Supported toys = all</para>
            /// </summary>
            COMMAND_FLASH = 201,
            /// <summary>
            /// <para>- Turn off the light (saved permanently)</para>
            /// <para>- param Key = no parameter</para>
            /// <para>- Supported toys = Lush / Hush / Edge</para>
            /// </summary>
            COMMAND_LIGHT_OFF = 210,
            /// <summary>
            /// <para>- Turn on the light (saved permanently)</para>
            /// <para>- param Key = no parameter</para>
            /// <para>- Supported toys = Lush / Hush / Edge</para>
            /// </summary>
            COMMAND_LIGHT_ON = 211,
            /// <summary>
            /// <para>Get the light status (1: on, 0:off)</para>
            /// <para>- param Key = no parameter</para>
            /// <para>Supported toys = Lush  Hush  Edge</para>
            /// </summary>
            COMMAND_GET_LIGHT_STATUS = 212,
            /// <summary>
            /// <para>- Turn off the AID light (saved permanently)</para>
            /// <para>- param Key = no parameter</para>
            /// <para>- Supported toys = Domi</para>
            /// </summary>
            COMMAND_ALIGHT_OFF = 220,
            /// <summary>
            /// <para>- Turn on the AID light (saved permanently)</para>
            /// <para>- param Key = no parameter</para>
            /// <para>- Supported toys = Domi</para>
            /// </summary>
            COMMAND_ALIGHT_ON = 221,
            /// <summary>
            /// <para>Get the AID light status (1: on, 0:off)</para>
            /// <para>- param Key = no parameter</para>
            /// <para>Supported toys = Domi</para>
            /// </summary>
            COMMAND_GET_ALIGHT_STATUS = 222,
            /// <summary>
            /// <para>- Get battery status,</para>
            /// <para>- param Key = no parameter</para>
            /// <para>Supported toys = all</para>
            /// </summary>
            COMMAND_GET_BATTERY = 300,
            /// <summary>
            /// <para>Get device/toy information</para>
            /// <para>- param Key = no parameter</para>
            /// <para>Supported toys = all</para>
            /// </summary>
            COMMAND_GET_DEVICE_TYPE = 310,
            /// <summary>
            /// <para>Inflatable n seconds. The parameter must be between (1-3)</para>
            /// <para>Supported toys = Max</para>
            /// </summary>
            COMMAND_AIR_IN = 330,
            /// <summary>
            /// <para>Deflation n seconds. The parameter must be between (1-3)</para>
            /// <para>Supported toys = Max</para>
            /// </summary>
            COMMAND_AIR_OUT = 331,
            /// <summary>
            /// <para>Cycle inflation for n seconds, deflation for n seconds, 0 for stop!</para>
            /// <para>The parameter must be between (0-3)</para>
            /// <para>Supported toys = Max</para>
            /// </summary>
            COMMAND_AIR_AUTO = 332,
            /// <summary>
            /// <para>Start tracking the toy movement (0-4)</para>
            /// <para>- param Key = no parameter</para>
            /// <para>Supported toys = Max,Nora</para>
            /// </summary>
            COMMAND_START_MOVE = 400,
            /// <summary>
            /// <para>Start tracking the toy movement (0-4)</para>
            /// <para>- param Key = no parameter</para>
            /// <para>Supported toys = Max,Nora</para>
            /// </summary>
            COMMAND_STOP_MOVE = 401
        }

        public enum Error
        {
            TOYERR_UNKNOWN = -1,
            TOYERR_SUCCESS = 0,
            TOYERR_ABORT = 1001,
            TOYERR_HID_INIT_FAILED = 1002,
            TOYERR_HID_DONGLE_NOT_FOUND = 1003,
            TOYERR_HID_GET_DONGLE_ID_ERROR = 1004,
            TOYERR_TOY_NOT_CONNECTED = 1005,
            TOYERR_PARAM_ERROR = 1006,
            TOYERR_INVALID_CMD = 1007,
            TOYERR_INVALIDTOKEN = 1008,
            TOYERR_COM_READ_ERROR = 1009,
            TOYERR_COM_WRITE_ERROR = 1010,
            TOYERR_COM_NOT_FOUND_ERROR = 1011,
            TOYERR_HID_READ_ERROR = 1012,
            TOYERR_HID_WRITE_ERROR = 1013,
            TOYERR_DONGLE_NO_FOUND_ERROR = 1014,
            TOYERR_HID_OPEN_FAILED_ERROR = 1015,
            TOYERR_COM_OPEN_FAILED_ERROR = 1016,
            TOYERR_DEVICE_WRITE_FAILED = 1017,
            TOYERR_DEVICE_READ_FAILED = 1018,
            TOYERR_DEVICE_IS_SEARCHING = 1019
        }
    }

    namespace Delegates
    {
        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(__CallingConvention.Cdecl)]
        internal unsafe delegate void Action___IntPtr(__IntPtr __instance);

        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(__CallingConvention.Cdecl)]
        internal unsafe delegate void Action___IntPtr___IntPtr(__IntPtr __instance, __IntPtr arg1);

        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(__CallingConvention.Cdecl)]
        internal unsafe delegate void Action___IntPtr_int(__IntPtr __instance, int arg1);

        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(__CallingConvention.Cdecl)]
        internal unsafe delegate void Action___IntPtr_int_string8(__IntPtr __instance, int arg1, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(CppSharp.Runtime.UTF8Marshaller))] string arg2);

        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(__CallingConvention.Cdecl)]
        internal unsafe delegate void Action___IntPtr_string8_bool(__IntPtr __instance, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(CppSharp.Runtime.UTF8Marshaller))] string arg1, [MarshalAs(UnmanagedType.I1)] bool arg2);

        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(__CallingConvention.Cdecl)]
        internal unsafe delegate void Action___IntPtr_string8_LovenseWrapper_CLovenseToy_CmdType_string8_LovenseWrapper_CLovenseToy_Error(__IntPtr __instance, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(CppSharp.Runtime.UTF8Marshaller))] string arg1, global::LovenseWrapper.CLovenseToy.CmdType arg2, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(CppSharp.Runtime.UTF8Marshaller))] string arg3, global::LovenseWrapper.CLovenseToy.Error arg4);
        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(__CallingConvention.Cdecl)]
        internal unsafe delegate __IntPtr Func___IntPtr___IntPtr(__IntPtr __instance);

        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(__CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.I1)]
        internal unsafe delegate bool Func_bool___IntPtr(__IntPtr __instance);

        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(__CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.I1)]
        internal unsafe delegate bool Func_bool___IntPtr_string8(__IntPtr __instance, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(CppSharp.Runtime.UTF8Marshaller))] string arg1);

        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(__CallingConvention.Cdecl)]
        internal unsafe delegate int Func_int___IntPtr(__IntPtr __instance);

        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(__CallingConvention.Cdecl)]
        internal unsafe delegate int Func_int___IntPtr_string8(__IntPtr __instance, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(CppSharp.Runtime.UTF8Marshaller))] string arg1);

        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(__CallingConvention.Cdecl)]
        internal unsafe delegate int Func_int___IntPtr_string8_intPtr(__IntPtr __instance, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(CppSharp.Runtime.UTF8Marshaller))] string arg1, int* arg2);

        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(__CallingConvention.Cdecl)]
        internal unsafe delegate int Func_int___IntPtr_string8_LovenseWrapper_CLovenseToy_CmdType_int(__IntPtr __instance, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(CppSharp.Runtime.UTF8Marshaller))] string arg1, global::LovenseWrapper.CLovenseToy.CmdType arg2, int arg3);
        [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(__CallingConvention.Cdecl)]
        internal unsafe delegate global::LovenseWrapper.LVSToyType Func_LovenseWrapper_LVSToyType___IntPtr(__IntPtr __instance);
    }

    /// <summary>
    /// enum {
    /// HID USB Dongle
    /// SERIAL COM USB Dongle
    /// }
    /// </summary>
    public enum DongleType
    {
        /// <summary>HID USB Dongle</summary>
        DONGLE_HID_TYPE = 0,
        /// <summary>SERIAL COM USB Dongle</summary>
        DONGLE_BLE_TYPE = 1
    }

    public enum LVSToyType
    {
        LVS_UNKNOWN = 0,
        LVS_MAX = 1,
        LVS_NORA = 2,
        LVS_HUSH = 3,
        LVS_LUSH = 4,
        LVS_AMBI = 5,
        LVS_DOMI = 6,
        LVS_SECRET = 7,
        LVS_EDGE = 8,
        LVS_OSCI = 9,
        LVS_DONGLE = 10,
        LVS_DIAMO = 11,
        LVS_MISSION = 12,
        LVS_V01 = 13,
        LVS_DOLCE = 14,
        LVS_XMACHINE = 15,
        LVS_HYPHY = 16,
        LVS_CALOR = 17,
        LVS_FERRI = 18
    }

    // --------------------------------------------------------------------------------
    /// <summary>
    /// Instantiate the LovenseToyManager
    /// </summary>
    // --------------------------------------------------------------------------------
    public unsafe abstract partial class CLovenseToyManager : IDisposable
    {
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LovenseWrapper.CLovenseToyManager> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LovenseWrapper.CLovenseToyManager>();

        internal bool __ownsNativeInstance;

        internal CLovenseToyManager(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new __IntPtr(native);
        }

        internal CLovenseToyManager()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::LovenseWrapper.CLovenseToyManager.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            __Internal.ctor(__Instance);
            SetupVTables(GetType().FullName == "LovenseWrapper.CLovenseToyManager");
        }

        internal CLovenseToyManager(global::LovenseWrapper.CLovenseToyManager _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::LovenseWrapper.CLovenseToyManager.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            if (ReferenceEquals(_0, null))
                throw new global::System.ArgumentNullException("_0", "Cannot be null because it is a C++ reference (&).");
            var __arg0 = _0.__Instance;
            __Internal.cctor(__Instance, __arg0);
            SetupVTables(GetType().FullName == "LovenseWrapper.CLovenseToyManager");
        }

        /// <summary>Stop searching for toys</summary>
        public abstract int StopSearchToy
        {
            get;
        }

        internal __IntPtr __Instance { get; private set; }

        // ********************************************************************************
        /// <summary>
        /// Connect a toy
        /// </summary>
        /// <param name="szToyID"><para>toy ID</para>
        /// <para>If Successful connection successfully, will call LovenseToyConnectedStatus;</para></param>
        /// <returns></returns>
        // <created>CMT,21/06/2022</created>
        // <changed>CMT,21/06/2022</changed>
        // ********************************************************************************
        public abstract int ConnectToToy(string szToyID);

        // ********************************************************************************
        /// <summary>
        /// DisConnect a toy
        /// </summary>
        /// <param name="szToyID"><para>toy ID</para>
        /// <para>return Successfully disconnected, will call LovenseToyConnectedStatus;</para></param>
        /// <returns></returns>
        // <created>CMT,21/06/2022</created>
        // <changed>CMT,21/06/2022</changed>
        // ********************************************************************************
        public abstract int DisConnectedToy(string szToyID);

        // ********************************************************************************
        /// <summary>
        /// Dispose LovenseToyManager
        /// </summary>
        // <created>CMT,21/06/2022</created>
        // <changed>CMT,21/06/2022</changed>
        // ********************************************************************************
        public void Dispose()
        {
            Dispose(disposing: true, callNativeDtor: __ownsNativeInstance);
        }

        // ********************************************************************************
        /// <summary>
        /// Get toy battery
        /// </summary>
        /// <param name="szToyID"><para>toy ID</para>
        /// <para>return 0</para></param>
        /// <param name="battery_out"></param>
        /// <returns></returns>
        // <created>CMT,21/06/2022</created>
        // <changed>CMT,21/06/2022</changed>
        // ********************************************************************************
        public abstract int GetToyBattery(string szToyID, ref int battery_out);

        // ********************************************************************************
        /// <summary>
        /// Subscription notification
        /// </summary>
        /// <param name="lovenseNotify"></param>
        // <created>CMT,21/06/2022</created>
        // <changed>CMT,21/06/2022</changed>
        // ********************************************************************************
        public abstract void RegisterEventCallBack(global::LovenseWrapper.ILovenseSDKNotify lovenseNotify);

        /// <summary>Send a command to the toy</summary>
        /// <param name="szToyID">toy ID</param>
        /// <param name="cmd">command</param>
        /// <param name="nParam">command parameters</param>
        public abstract int SendCommand(string szToyID, global::LovenseWrapper.CLovenseToy.CmdType cmd, int nParam);

        // ********************************************************************************
        /// <summary>
        /// Pass your token into Lovense framework
        /// </summary>
        /// <param name="szToken"></param>
        /// <returns></returns>
        // <created>CMT,21/06/2022</created>
        // <changed>CMT,21/06/2022</changed>
        // ********************************************************************************
        public abstract bool SetDeveloperToken(string szToken);

        // ********************************************************************************
        /// <summary>
        /// Search for Lovense toys
        /// </summary>
        /// <returns>result of the search start</returns>
        // <created>CMT,21/06/2022</created>
        // <changed>CMT,21/06/2022</changed>
        // ********************************************************************************
        public abstract int StartSearchToy();

        internal static CLovenseToyManager __CreateInstance(__IntPtr native, bool skipVTables = false)
        {
            return new CLovenseToyManagerInternal(native.ToPointer(), skipVTables);
        }

        internal static CLovenseToyManager __CreateInstance(__Internal native, bool skipVTables = false)
        {
            return new CLovenseToyManagerInternal(native, skipVTables);
        }

        internal static CLovenseToyManager __GetInstance(__IntPtr native)
        {
            if (!NativeToManagedMap.TryGetValue(native, out var managed))
                throw new global::System.Exception("No managed instance was found");
            var result = (CLovenseToyManager)managed;
            if (result.__ownsNativeInstance)
                result.SetupVTables();
            return result;
        }

        internal static CLovenseToyManager __GetOrCreateInstance(__IntPtr native, bool saveInstance = false, bool skipVTables = false)
        {
            if (native == __IntPtr.Zero)
                return null;
            if (NativeToManagedMap.TryGetValue(native, out var managed))
                return (CLovenseToyManager)managed;
            var result = __CreateInstance(native, skipVTables);
            if (saveInstance)
                NativeToManagedMap[native] = result;
            return result;
        }

        // ********************************************************************************
        /// <summary>
        /// ..
        /// </summary>
        /// <param name="disposing"></param>
        /// <param name="callNativeDtor"></param>
        // <created>CMT,21/06/2022</created>
        // <changed>CMT,21/06/2022</changed>
        // ********************************************************************************
        internal protected virtual void Dispose(bool disposing, bool callNativeDtor)
        {
            if (__Instance == IntPtr.Zero)
                return;
            NativeToManagedMap.TryRemove(__Instance, out _);
            ((global::LovenseWrapper.CLovenseToyManager.__Internal*)__Instance)->vfptr_CLovenseToyManager = __VTables.Tables[0];
            DisposePartial(disposing);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        partial void DisposePartial(bool disposing);

        [StructLayout(LayoutKind.Sequential, Size = 8)]
        internal partial struct __Internal
        {
            internal __IntPtr vfptr_CLovenseToyManager;

            [SuppressUnmanagedCodeSecurity, DllImport("LovenseToys", EntryPoint = "??0CLovenseToyManager@@QEAA@XZ", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern __IntPtr ctor(__IntPtr __instance);

            [SuppressUnmanagedCodeSecurity, DllImport("LovenseToys", EntryPoint = "??0CLovenseToyManager@@QEAA@AEBV0@@Z", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern __IntPtr cctor(__IntPtr __instance, __IntPtr _0);
        }
        #region Virtual table interop

        internal CppSharp.Runtime.VTables __vtables;

        // int ConnectToToy(const char * szToyID) = 0
        private static global::LovenseWrapper.Delegates.Func_int___IntPtr_string8 _ConnectToToyDelegateInstance;

        // int DisConnectedToy(const char *szToyID) = 0
        private static global::LovenseWrapper.Delegates.Func_int___IntPtr_string8 _DisConnectedToyDelegateInstance;

        // int GetToyBattery(const char* szToyID, int *battery_out) = 0
        private static global::LovenseWrapper.Delegates.Func_int___IntPtr_string8_intPtr _GetToyBatteryDelegateInstance;

        // void RegisterEventCallBack(ILovenseSDKNotify * lovenseNotify) = 0
        private static global::LovenseWrapper.Delegates.Action___IntPtr___IntPtr _RegisterEventCallBackDelegateInstance;

        // int SendCommand(const char * szToyID, CLovenseToy::CmdType cmd, int nParam) = 0
        private static global::LovenseWrapper.Delegates.Func_int___IntPtr_string8_LovenseWrapper_CLovenseToy_CmdType_int _SendCommandDelegateInstance;

        // bool SetDeveloperToken(const char *szToken) = 0
        private static global::LovenseWrapper.Delegates.Func_bool___IntPtr_string8 _SetDeveloperTokenDelegateInstance;

        // int StartSearchToy() = 0
        private static global::LovenseWrapper.Delegates.Func_int___IntPtr _StartSearchToyDelegateInstance;

        // int StopSearchToy() = 0
        private static global::LovenseWrapper.Delegates.Func_int___IntPtr _StopSearchToyDelegateInstance;

        internal virtual CppSharp.Runtime.VTables __VTables
        {
            get
            {
                if (__vtables.IsEmpty)
                    __vtables.Tables = new IntPtr[] { *(IntPtr*)(__Instance + 0) };
                return __vtables;
            }

            set
            {
                __vtables = value;
            }
        }

        internal virtual void SetupVTables(bool destructorOnly = false)
        {
            if (__VTables.IsTransient)
                __VTables = VTableLoader.SetupVTables(__Instance, destructorOnly);
        }

        private static int _ConnectToToyDelegateHook(__IntPtr __instance, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(CppSharp.Runtime.UTF8Marshaller))] string szToyID)
        {
            CLovenseToyManager __target = global::LovenseWrapper.CLovenseToyManager.__GetInstance(__instance);
            return __target.ConnectToToy(szToyID);
        }

        private static int _DisConnectedToyDelegateHook(__IntPtr __instance, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(CppSharp.Runtime.UTF8Marshaller))] string szToyID)
        {
            CLovenseToyManager __target = global::LovenseWrapper.CLovenseToyManager.__GetInstance(__instance);
            return __target.DisConnectedToy(szToyID);
        }

        private static int _GetToyBatteryDelegateHook(__IntPtr __instance, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(CppSharp.Runtime.UTF8Marshaller))] string szToyID, int* battery_out)
        {
            CLovenseToyManager __target = global::LovenseWrapper.CLovenseToyManager.__GetInstance(__instance);
            return __target.GetToyBattery(szToyID, ref *battery_out);
        }

        private static void _RegisterEventCallBackDelegateHook(__IntPtr __instance, __IntPtr lovenseNotify)
        {
            CLovenseToyManager __target = global::LovenseWrapper.CLovenseToyManager.__GetInstance(__instance);
            ILovenseSDKNotify __result0 = global::LovenseWrapper.ILovenseSDKNotify.__GetOrCreateInstance(lovenseNotify, false);
            __target.RegisterEventCallBack(__result0);
        }

        private static int _SendCommandDelegateHook(__IntPtr __instance, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(CppSharp.Runtime.UTF8Marshaller))] string szToyID, global::LovenseWrapper.CLovenseToy.CmdType cmd, int nParam)
        {
            CLovenseToyManager __target = global::LovenseWrapper.CLovenseToyManager.__GetInstance(__instance);
            return __target.SendCommand(szToyID, cmd, nParam);
        }

        private static bool _SetDeveloperTokenDelegateHook(__IntPtr __instance, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(CppSharp.Runtime.UTF8Marshaller))] string szToken)
        {
            CLovenseToyManager __target = global::LovenseWrapper.CLovenseToyManager.__GetInstance(__instance);
            return __target.SetDeveloperToken(szToken);
        }
        private static int _StartSearchToyDelegateHook(__IntPtr __instance)
        {
            CLovenseToyManager __target = global::LovenseWrapper.CLovenseToyManager.__GetInstance(__instance);
            return __target.StartSearchToy();
        }
        private static int _StopSearchToyDelegateHook(__IntPtr __instance)
        {
            CLovenseToyManager __target = global::LovenseWrapper.CLovenseToyManager.__GetInstance(__instance);
            return __target.StopSearchToy;
        }
        internal static class VTableLoader
        {
            private static readonly IntPtr*[] ManagedVTables = new IntPtr*[1];
            private static readonly global::System.Collections.Generic.List<CppSharp.Runtime.SafeUnmanagedMemoryHandle>
                SafeHandles = new global::System.Collections.Generic.List<CppSharp.Runtime.SafeUnmanagedMemoryHandle>();

            private static readonly IntPtr[] Thunks = new IntPtr[8];
            private static volatile bool initialized;
            private static CppSharp.Runtime.VTables VTables;
            static VTableLoader()
            {
                _SetDeveloperTokenDelegateInstance += _SetDeveloperTokenDelegateHook;
                _RegisterEventCallBackDelegateInstance += _RegisterEventCallBackDelegateHook;
                _StartSearchToyDelegateInstance += _StartSearchToyDelegateHook;
                _StopSearchToyDelegateInstance += _StopSearchToyDelegateHook;
                _SendCommandDelegateInstance += _SendCommandDelegateHook;
                _ConnectToToyDelegateInstance += _ConnectToToyDelegateHook;
                _DisConnectedToyDelegateInstance += _DisConnectedToyDelegateHook;
                _GetToyBatteryDelegateInstance += _GetToyBatteryDelegateHook;
                Thunks[0] = Marshal.GetFunctionPointerForDelegate(_SetDeveloperTokenDelegateInstance);
                Thunks[1] = Marshal.GetFunctionPointerForDelegate(_RegisterEventCallBackDelegateInstance);
                Thunks[2] = Marshal.GetFunctionPointerForDelegate(_StartSearchToyDelegateInstance);
                Thunks[3] = Marshal.GetFunctionPointerForDelegate(_StopSearchToyDelegateInstance);
                Thunks[4] = Marshal.GetFunctionPointerForDelegate(_SendCommandDelegateInstance);
                Thunks[5] = Marshal.GetFunctionPointerForDelegate(_ConnectToToyDelegateInstance);
                Thunks[6] = Marshal.GetFunctionPointerForDelegate(_DisConnectedToyDelegateInstance);
                Thunks[7] = Marshal.GetFunctionPointerForDelegate(_GetToyBatteryDelegateInstance);
            }

            public static CppSharp.Runtime.VTables SetupVTables(IntPtr instance, bool destructorOnly = false)
            {
                if (!initialized)
                {
                    lock (ManagedVTables)
                    {
                        if (!initialized)
                        {
                            initialized = true;
                            VTables.Tables = new IntPtr[] { *(IntPtr*)(instance + 0) };
                            VTables.Methods = new Delegate[1][];
                            ManagedVTables[0] = CppSharp.Runtime.VTables.CloneTable(SafeHandles, instance, 0, 8);
                            ManagedVTables[0][0] = Thunks[0];
                            ManagedVTables[0][1] = Thunks[1];
                            ManagedVTables[0][2] = Thunks[2];
                            ManagedVTables[0][3] = Thunks[3];
                            ManagedVTables[0][4] = Thunks[4];
                            ManagedVTables[0][5] = Thunks[5];
                            ManagedVTables[0][6] = Thunks[6];
                            ManagedVTables[0][7] = Thunks[7];
                            VTables.Methods[0] = new Delegate[8];
                            if (destructorOnly)
                                return VTables;
                        }
                    }
                }

                *(IntPtr**)(instance + 0) = ManagedVTables[0];
                return VTables;
            }
        }
        #endregion
    }

    // --------------------------------------------------------------------------------
    /// <summary>
    /// Abstract class
    /// Gets instantiated by the event handlers of the callback of the LovenseToyManager
    /// </summary>
    // --------------------------------------------------------------------------------
    public unsafe abstract partial class ILovenseSDKNotify : IDisposable
    {
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LovenseWrapper.ILovenseSDKNotify> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LovenseWrapper.ILovenseSDKNotify>();

        internal bool __ownsNativeInstance;

        internal ILovenseSDKNotify(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new __IntPtr(native);
        }

        internal ILovenseSDKNotify(global::LovenseWrapper.ILovenseSDKNotify _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::LovenseWrapper.ILovenseSDKNotify.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            if (ReferenceEquals(_0, null))
                throw new global::System.ArgumentNullException("_0", "Cannot be null because it is a C++ reference (&).");
            var __arg0 = _0.__Instance;
            __Internal.cctor(__Instance, __arg0);
            SetupVTables(GetType().FullName == "LovenseWrapper.ILovenseSDKNotify");
        }

        // ********************************************************************************
        /// <summary>
        /// Usage: private class LovenseNotify : ILovenseSDKNotify
        /// </summary>
        /// <returns></returns>
        // <created>CMT,21/06/2022</created>
        // <changed>CMT,21/06/2022</changed>
        // ********************************************************************************
        protected ILovenseSDKNotify()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::LovenseWrapper.ILovenseSDKNotify.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            __Internal.ctor(__Instance);
            SetupVTables(GetType().FullName == "LovenseWrapper.ILovenseSDKNotify");
        }

        internal __IntPtr __Instance { get; private set; }

        // ********************************************************************************
        /// <summary>
        /// Dispose instance of ILovenseSDKNotify
        /// </summary>
        // <created>CMT,21/06/2022</created>
        // <changed>CMT,21/06/2022</changed>
        // ********************************************************************************
        public void Dispose()
        {
            Dispose(disposing: true, callNativeDtor: __ownsNativeInstance);
        }

        // ********************************************************************************
        /// <summary>
        /// Usage: public override void LovenseDidSearchEnd() in instance of ILovenseSDKNotify
        /// </summary>
        // <created>CMT,21/06/2022</created>
        // <changed>CMT,21/06/2022</changed>
        // ********************************************************************************
        public abstract void LovenseDidSearchEnd();

        // ********************************************************************************
        /// <summary>
        /// Usage: public override void LovenseDidSearchStart() in instance of ILovenseSDKNotify
        /// </summary>
        // <created>CMT,21/06/2022</created>
        // <changed>CMT,21/06/2022</changed>
        // ********************************************************************************
        public abstract void LovenseDidSearchStart();

        // ********************************************************************************
        /// <summary>
        /// Usage: public override void LovenseDidSendCmdEnd() in instance of ILovenseSDKNotify
        /// </summary>
        // <created>CMT,21/06/2022</created>
        // <changed>CMT,21/06/2022</changed>
        // ********************************************************************************
        public abstract void LovenseDidSendCmdEnd();

        // ********************************************************************************
        /// <summary>
        /// Usage: public override void LovenseDidSendCmdStart() in instance of ILovenseSDKNotify
        /// </summary>
        // <created>CMT,21/06/2022</created>
        // <changed>CMT,21/06/2022</changed>
        // ********************************************************************************
        public abstract void LovenseDidSendCmdStart();

        // ********************************************************************************
        /// <summary>
        /// Usage: public override void LovenseErrorOutPut(int errorCode, string errorMsg)
        /// in instance of ILovenseSDKNotify
        /// </summary>
        /// <param name="errorCode">int errorCode</param>
        /// <param name="errorMsg">string error message</param>
        // <created>CMT,21/06/2022</created>
        // <changed>CMT,21/06/2022</changed>
        // ********************************************************************************
        public abstract void LovenseErrorOutPut(int errorCode, string errorMsg);

        // ********************************************************************************
        /// <summary>
        /// Usage: public override void LovenseSearchingToys(StLovenseToyInfo info)
        /// gets called on every found toy during search
        /// </summary>
        /// <param name="info">returns toy info of found toy</param>
        // <created>CMT,21/06/2022</created>
        // <changed>CMT,21/06/2022</changed>
        // ********************************************************************************
        public abstract void LovenseSearchingToys(global::LovenseWrapper.StLovenseToyInfo info);

        // ********************************************************************************
        /// <summary>
        /// Usage: public override void LovenseSendCmdResult(string szToyID, CmdType cmd, string result, Error errorCode)
        /// </summary>
        /// <param name="szToyID">string ToyId</param>
        /// <param name="cmd">CmdType command sent</param>
        /// <param name="result">string result</param>
        /// <param name="errorCode">Error error code</param>
        // <created>CMT,21/06/2022</created>
        // <changed>CMT,21/06/2022</changed>
        // ********************************************************************************
        public abstract void LovenseSendCmdResult(string szToyID, global::LovenseWrapper.CLovenseToy.CmdType cmd, string result, global::LovenseWrapper.CLovenseToy.Error errorCode);

        // ********************************************************************************
        /// <summary>
        /// Usage: public override void LovenseToyConnectedStatus(string szToyID, bool isConnected)
        /// </summary>
        /// <param name="szToyID">string ToyId</param>
        /// <param name="isConnected">bool connection status</param>
        // <created>CMT,21/06/2022</created>
        // <changed>CMT,21/06/2022</changed>
        // ********************************************************************************
        public abstract void LovenseToyConnectedStatus(string szToyID, bool isConnected);

        internal static ILovenseSDKNotify __CreateInstance(__IntPtr native, bool skipVTables = false)
        {
            return new ILovenseSDKNotifyInternal(native.ToPointer(), skipVTables);
        }

        internal static ILovenseSDKNotify __CreateInstance(__Internal native, bool skipVTables = false)
        {
            return new ILovenseSDKNotifyInternal(native, skipVTables);
        }

        internal static ILovenseSDKNotify __GetInstance(__IntPtr native)
        {
            if (!NativeToManagedMap.TryGetValue(native, out var managed))
                throw new global::System.Exception("No managed instance was found");
            var result = (ILovenseSDKNotify)managed;
            if (result.__ownsNativeInstance)
                result.SetupVTables();
            return result;
        }

        internal static ILovenseSDKNotify __GetOrCreateInstance(__IntPtr native, bool saveInstance = false, bool skipVTables = false)
        {
            if (native == __IntPtr.Zero)
                return null;
            if (NativeToManagedMap.TryGetValue(native, out var managed))
                return (ILovenseSDKNotify)managed;
            var result = __CreateInstance(native, skipVTables);
            if (saveInstance)
                NativeToManagedMap[native] = result;
            return result;
        }

        // ********************************************************************************
        /// <summary>
        /// ..
        /// </summary>
        /// <param name="disposing"></param>
        /// <param name="callNativeDtor"></param>
        // <created>CMT,21/06/2022</created>
        // <changed>CMT,21/06/2022</changed>
        // ********************************************************************************
        internal protected virtual void Dispose(bool disposing, bool callNativeDtor)
        {
            if (__Instance == IntPtr.Zero)
                return;
            NativeToManagedMap.TryRemove(__Instance, out _);
            ((global::LovenseWrapper.ILovenseSDKNotify.__Internal*)__Instance)->vfptr_ILovenseSDKNotify = __VTables.Tables[0];
            DisposePartial(disposing);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        partial void DisposePartial(bool disposing);

        [StructLayout(LayoutKind.Sequential, Size = 8)]
        internal struct __Internal
        {
            internal __IntPtr vfptr_ILovenseSDKNotify;

            [SuppressUnmanagedCodeSecurity, DllImport("LovenseToys", EntryPoint = "??0ILovenseSDKNotify@@QEAA@XZ", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern __IntPtr ctor(__IntPtr __instance);

            [SuppressUnmanagedCodeSecurity, DllImport("LovenseToys", EntryPoint = "??0ILovenseSDKNotify@@QEAA@AEBV0@@Z", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern __IntPtr cctor(__IntPtr __instance, __IntPtr _0);
        }
        #region Virtual table interop

        internal CppSharp.Runtime.VTables __vtables;

        private static global::LovenseWrapper.Delegates.Action___IntPtr _LovenseDidSearchEndDelegateInstance;

        private static global::LovenseWrapper.Delegates.Action___IntPtr _LovenseDidSearchStartDelegateInstance;

        private static global::LovenseWrapper.Delegates.Action___IntPtr _LovenseDidSendCmdEndDelegateInstance;

        private static global::LovenseWrapper.Delegates.Action___IntPtr _LovenseDidSendCmdStartDelegateInstance;

        private static global::LovenseWrapper.Delegates.Action___IntPtr_int_string8 _LovenseErrorOutPutDelegateInstance;

        private static global::LovenseWrapper.Delegates.Action___IntPtr___IntPtr _LovenseSearchingToysDelegateInstance;

        private static global::LovenseWrapper.Delegates.Action___IntPtr_string8_LovenseWrapper_CLovenseToy_CmdType_string8_LovenseWrapper_CLovenseToy_Error _LovenseSendCmdResultDelegateInstance;

        private static global::LovenseWrapper.Delegates.Action___IntPtr_string8_bool _LovenseToyConnectedStatusDelegateInstance;

        internal virtual CppSharp.Runtime.VTables __VTables
        {
            get
            {
                if (__vtables.IsEmpty)
                    __vtables.Tables = new IntPtr[] { *(IntPtr*)(__Instance + 0) };
                return __vtables;
            }

            set
            {
                __vtables = value;
            }
        }

        internal virtual void SetupVTables(bool destructorOnly = false)
        {
            if (__VTables.IsTransient)
                __VTables = VTableLoader.SetupVTables(__Instance, destructorOnly);
        }

        private static void _LovenseDidSearchEndDelegateHook(__IntPtr __instance)
        {
            ILovenseSDKNotify __target = global::LovenseWrapper.ILovenseSDKNotify.__GetInstance(__instance);
            __target.LovenseDidSearchEnd();
        }

        private static void _LovenseDidSearchStartDelegateHook(__IntPtr __instance)
        {
            ILovenseSDKNotify __target = global::LovenseWrapper.ILovenseSDKNotify.__GetInstance(__instance);
            __target.LovenseDidSearchStart();
        }
        private static void _LovenseDidSendCmdEndDelegateHook(__IntPtr __instance)
        {
            ILovenseSDKNotify __target = global::LovenseWrapper.ILovenseSDKNotify.__GetInstance(__instance);
            __target.LovenseDidSendCmdEnd();
        }

        private static void _LovenseDidSendCmdStartDelegateHook(__IntPtr __instance)
        {
            ILovenseSDKNotify __target = global::LovenseWrapper.ILovenseSDKNotify.__GetInstance(__instance);
            __target.LovenseDidSendCmdStart();
        }

        private static void _LovenseErrorOutPutDelegateHook(__IntPtr __instance, int errorCode, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(CppSharp.Runtime.UTF8Marshaller))] string errorMsg)
        {
            ILovenseSDKNotify __target = global::LovenseWrapper.ILovenseSDKNotify.__GetInstance(__instance);
            __target.LovenseErrorOutPut(errorCode, errorMsg);
        }

        private static void _LovenseSearchingToysDelegateHook(__IntPtr __instance, __IntPtr info)
        {
            ILovenseSDKNotify __target = global::LovenseWrapper.ILovenseSDKNotify.__GetInstance(__instance);
            StLovenseToyInfo __result0 = global::LovenseWrapper.StLovenseToyInfo.__GetOrCreateInstance(info, false);
            __target.LovenseSearchingToys(__result0);
        }
        private static void _LovenseSendCmdResultDelegateHook(__IntPtr __instance, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(CppSharp.Runtime.UTF8Marshaller))] string szToyID, global::LovenseWrapper.CLovenseToy.CmdType cmd, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(CppSharp.Runtime.UTF8Marshaller))] string result, global::LovenseWrapper.CLovenseToy.Error errorCode)
        {
            ILovenseSDKNotify __target = global::LovenseWrapper.ILovenseSDKNotify.__GetInstance(__instance);
            __target.LovenseSendCmdResult(szToyID, cmd, result, errorCode);
        }
        private static void _LovenseToyConnectedStatusDelegateHook(__IntPtr __instance, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(CppSharp.Runtime.UTF8Marshaller))] string szToyID, bool isConnected)
        {
            ILovenseSDKNotify __target = global::LovenseWrapper.ILovenseSDKNotify.__GetInstance(__instance);
            __target.LovenseToyConnectedStatus(szToyID, isConnected);
        }

        internal static class VTableLoader
        {
            private static readonly IntPtr*[] ManagedVTables = new IntPtr*[1];
            private static readonly global::System.Collections.Generic.List<CppSharp.Runtime.SafeUnmanagedMemoryHandle>
                SafeHandles = new global::System.Collections.Generic.List<CppSharp.Runtime.SafeUnmanagedMemoryHandle>();

            private static readonly IntPtr[] Thunks = new IntPtr[8];
            private static volatile bool initialized;
            private static CppSharp.Runtime.VTables VTables;
            static VTableLoader()
            {
                _LovenseDidSearchStartDelegateInstance += _LovenseDidSearchStartDelegateHook;
                _LovenseSearchingToysDelegateInstance += _LovenseSearchingToysDelegateHook;
                _LovenseErrorOutPutDelegateInstance += _LovenseErrorOutPutDelegateHook;
                _LovenseDidSearchEndDelegateInstance += _LovenseDidSearchEndDelegateHook;
                _LovenseDidSendCmdStartDelegateInstance += _LovenseDidSendCmdStartDelegateHook;
                _LovenseSendCmdResultDelegateInstance += _LovenseSendCmdResultDelegateHook;
                _LovenseDidSendCmdEndDelegateInstance += _LovenseDidSendCmdEndDelegateHook;
                _LovenseToyConnectedStatusDelegateInstance += _LovenseToyConnectedStatusDelegateHook;
                Thunks[0] = Marshal.GetFunctionPointerForDelegate(_LovenseDidSearchStartDelegateInstance);
                Thunks[1] = Marshal.GetFunctionPointerForDelegate(_LovenseSearchingToysDelegateInstance);
                Thunks[2] = Marshal.GetFunctionPointerForDelegate(_LovenseErrorOutPutDelegateInstance);
                Thunks[3] = Marshal.GetFunctionPointerForDelegate(_LovenseDidSearchEndDelegateInstance);
                Thunks[4] = Marshal.GetFunctionPointerForDelegate(_LovenseDidSendCmdStartDelegateInstance);
                Thunks[5] = Marshal.GetFunctionPointerForDelegate(_LovenseSendCmdResultDelegateInstance);
                Thunks[6] = Marshal.GetFunctionPointerForDelegate(_LovenseDidSendCmdEndDelegateInstance);
                Thunks[7] = Marshal.GetFunctionPointerForDelegate(_LovenseToyConnectedStatusDelegateInstance);
            }

            public static CppSharp.Runtime.VTables SetupVTables(IntPtr instance, bool destructorOnly = false)
            {
                if (!initialized)
                {
                    lock (ManagedVTables)
                    {
                        if (!initialized)
                        {
                            initialized = true;
                            VTables.Tables = new IntPtr[] { *(IntPtr*)(instance + 0) };
                            VTables.Methods = new Delegate[1][];
                            ManagedVTables[0] = CppSharp.Runtime.VTables.CloneTable(SafeHandles, instance, 0, 8);
                            ManagedVTables[0][0] = Thunks[0];
                            ManagedVTables[0][1] = Thunks[1];
                            ManagedVTables[0][2] = Thunks[2];
                            ManagedVTables[0][3] = Thunks[3];
                            ManagedVTables[0][4] = Thunks[4];
                            ManagedVTables[0][5] = Thunks[5];
                            ManagedVTables[0][6] = Thunks[6];
                            ManagedVTables[0][7] = Thunks[7];
                            VTables.Methods[0] = new Delegate[8];
                            if (destructorOnly)
                                return VTables;
                        }
                    }
                }

                *(IntPtr**)(instance + 0) = ManagedVTables[0];
                return VTables;
            }
        }
        #endregion
    }

    // --------------------------------------------------------------------------------
    /// <summary>
    /// ..
    /// </summary>
    // --------------------------------------------------------------------------------
    public unsafe partial class Lovense
    {
        /// <summary>Get the class instance through this export interface!</summary>
        public static global::LovenseWrapper.CLovenseToyManager GetLovenseToyManager()
        {
            var __ret = __Internal.GetLovenseToyManager();
            var __result0 = global::LovenseWrapper.CLovenseToyManager.__GetOrCreateInstance(__ret, false);
            return __result0;
        }

        /// <summary>Release worker context</summary>
        public static void ReleaseLovenseToyManager()
        {
            __Internal.ReleaseLovenseToyManager();
        }

        internal partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity, DllImport("LovenseToys", EntryPoint = "GetLovenseToyManager", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern __IntPtr GetLovenseToyManager();

            [SuppressUnmanagedCodeSecurity, DllImport("LovenseToys", EntryPoint = "ReleaseLovenseToyManager", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void ReleaseLovenseToyManager();
        }
    }

    // --------------------------------------------------------------------------------
    /// <summary>
    /// typedef struct st_lovense_toy_info {
    /// 	char* toy_id;
    /// 	char* toy_name;
    /// 	int toy_battery;
    /// 	int toy_type;
    /// 	bool toy_connected;
    /// }lovense_toy_info_t
    /// struct st_lovense_toy_info {
    /// 	char* toy_id;
    /// 	char* toy_name;
    /// 	int toy_battery;
    /// 	int toy_type;
    /// 	bool toy_connected;
    /// }
    /// </summary>
    // --------------------------------------------------------------------------------
    public unsafe partial class StLovenseToyInfo : IDisposable
    {
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LovenseWrapper.StLovenseToyInfo> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LovenseWrapper.StLovenseToyInfo>();

        internal bool __ownsNativeInstance;

        internal StLovenseToyInfo(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new __IntPtr(native);
        }

       internal StLovenseToyInfo()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::LovenseWrapper.StLovenseToyInfo.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        internal StLovenseToyInfo(global::LovenseWrapper.StLovenseToyInfo _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::LovenseWrapper.StLovenseToyInfo.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::LovenseWrapper.StLovenseToyInfo.__Internal*)__Instance) = *((global::LovenseWrapper.StLovenseToyInfo.__Internal*)_0.__Instance);
        }

        private StLovenseToyInfo(__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        /// <summary>returns the actual charging level of the toy in percent (%)</summary>
        public int ToyBattery
        {
            get
            {
                return ((__Internal*)__Instance)->toy_battery;
            }

            set
            {
                ((__Internal*)__Instance)->toy_battery = value;
            }
        }

        /// <summary>returns <see langword="true"/>if the actual toy is connected, false if not connected</summary>
        public bool ToyConnected
        {
            get
            {
                return ((__Internal*)__Instance)->toy_connected != 0;
            }

            set
            {
                ((__Internal*)__Instance)->toy_connected = (byte)(value ? 1 : 0);
            }
        }

        /// <summary>return a pointer to a char array containing the ToyId</summary>
        public sbyte* ToyId
        {
            get
            {
                return (sbyte*)((__Internal*)__Instance)->toy_id;
            }

            set
            {
                ((__Internal*)__Instance)->toy_id = (__IntPtr)value;
            }
        }

        /// <summary>return a pointer to a char array containing the ToyName</summary>
        public sbyte* ToyName
        {
            get
            {
                return (sbyte*)((__Internal*)__Instance)->toy_name;
            }

            set
            {
                ((__Internal*)__Instance)->toy_name = (__IntPtr)value;
            }
        }

        /// <summary>returns the int value of the ToyType of the actual toy</summary>
        public int ToyType
        {
            get
            {
                return ((__Internal*)__Instance)->toy_type;
            }

            set
            {
                ((__Internal*)__Instance)->toy_type = value;
            }
        }

        internal __IntPtr __Instance { get; private set; }

        // ********************************************************************************
        /// <summary>
        /// Dispose LovenseToyInfo
        /// </summary>
        // <created>CMT,21/06/2022</created>
        // <changed>CMT,21/06/2022</changed>
        // ********************************************************************************
        public void Dispose()
        {
            Dispose(disposing: true, callNativeDtor: __ownsNativeInstance);
        }

        internal static StLovenseToyInfo __CreateInstance(__IntPtr native, bool skipVTables = false)
        {
            return new StLovenseToyInfo(native.ToPointer(), skipVTables);
        }

        internal static StLovenseToyInfo __CreateInstance(__Internal native, bool skipVTables = false)
        {
            return new StLovenseToyInfo(native, skipVTables);
        }

        internal static StLovenseToyInfo __GetOrCreateInstance(__IntPtr native, bool saveInstance = false, bool skipVTables = false)
        {
            if (native == __IntPtr.Zero)
                return null;
            if (NativeToManagedMap.TryGetValue(native, out var managed))
                return (StLovenseToyInfo)managed;
            var result = __CreateInstance(native, skipVTables);
            if (saveInstance)
                NativeToManagedMap[native] = result;
            return result;
        }

        // ********************************************************************************
        /// <summary>
        /// Implementation of Dispose
        /// </summary>
        /// <param name="disposing"></param>
        /// <param name="callNativeDtor"></param>
        // <created>CMT,21/06/2022</created>
        // <changed>CMT,21/06/2022</changed>
        // ********************************************************************************
        internal protected virtual void Dispose(bool disposing, bool callNativeDtor)
        {
            if (__Instance == IntPtr.Zero)
                return;
            NativeToManagedMap.TryRemove(__Instance, out _);
            DisposePartial(disposing);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        private static void* __CopyValue(__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(__Internal));
            *(__Internal*)ret = native;
            return ret.ToPointer();
        }

        partial void DisposePartial(bool disposing);

        [StructLayout(LayoutKind.Sequential, Size = 32)]
        internal partial struct __Internal
        {
            internal __IntPtr toy_id;
            internal __IntPtr toy_name;
            internal int toy_battery;
            internal int toy_type;
            internal byte toy_connected;

            [SuppressUnmanagedCodeSecurity, DllImport("LovenseWrapper", EntryPoint = "??0st_lovense_toy_info@@QEAA@AEBU0@@Z", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern __IntPtr cctor(__IntPtr __instance, __IntPtr _0);
        }
    }

    internal unsafe partial class CLovenseToyManagerInternal : global::LovenseWrapper.CLovenseToyManager, IDisposable
    {
        internal CLovenseToyManagerInternal(__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        internal CLovenseToyManagerInternal(void* native, bool skipVTables = false)
            : base((void*)native)
        {
        }

        /// <summary>Stop searching for toys</summary>
        public override int StopSearchToy
        {
            get
            {
                var ___StopSearchToyDelegate = __VTables.GetMethodDelegate<global::LovenseWrapper.Delegates.Func_int___IntPtr>(0, 3);
                var __ret = ___StopSearchToyDelegate(__Instance);
                return __ret;
            }
        }

        // ********************************************************************************
        /// <summary>
        /// Connect a toy
        /// </summary>
        /// <param name="szToyID"><para>toy ID</para>
        /// <para>If Successful connection successfully, will call LovenseToyConnectedStatus;</para></param>
        /// <returns></returns>
        // <created>CMT,21/06/2022</created>
        // <changed>CMT,21/06/2022</changed>
        // ********************************************************************************
        public override int ConnectToToy(string szToyID)
        {
            var ___ConnectToToyDelegate = __VTables.GetMethodDelegate<global::LovenseWrapper.Delegates.Func_int___IntPtr_string8>(0, 5);
            var __ret = ___ConnectToToyDelegate(__Instance, szToyID);
            return __ret;
        }

        // ********************************************************************************
        /// <summary>
        /// DisConnect a toy
        /// </summary>
        /// <param name="szToyID"><para>toy ID</para>
        /// <para>return Successfully disconnected, will call LovenseToyConnectedStatus;</para></param>
        /// <returns></returns>
        // <created>CMT,21/06/2022</created>
        // <changed>CMT,21/06/2022</changed>
        // ********************************************************************************
        public override int DisConnectedToy(string szToyID)
        {
            var ___DisConnectedToyDelegate = __VTables.GetMethodDelegate<global::LovenseWrapper.Delegates.Func_int___IntPtr_string8>(0, 6);
            var __ret = ___DisConnectedToyDelegate(__Instance, szToyID);
            return __ret;
        }

        // ********************************************************************************
        /// <summary>
        /// Get toy battery
        /// </summary>
        /// <param name="szToyID"><para>toy ID</para>
        /// <para>return 0</para></param>
        /// <param name="battery_out"></param>
        /// <returns></returns>
        // <created>CMT,21/06/2022</created>
        // <changed>CMT,21/06/2022</changed>
        // ********************************************************************************
        public override int GetToyBattery(string szToyID, ref int battery_out)
        {
            var ___GetToyBatteryDelegate = __VTables.GetMethodDelegate<global::LovenseWrapper.Delegates.Func_int___IntPtr_string8_intPtr>(0, 7);
            fixed (int* __battery_out1 = &battery_out)
            {
                var __arg1 = __battery_out1;
                var __ret = ___GetToyBatteryDelegate(__Instance, szToyID, __arg1);
                return __ret;
            }
        }

        // ********************************************************************************
        /// <summary>
        /// Subscription notification
        /// </summary>
        /// <param name="lovenseNotify"></param>
        // <created>CMT,21/06/2022</created>
        // <changed>CMT,21/06/2022</changed>
        // ********************************************************************************
        public override void RegisterEventCallBack(global::LovenseWrapper.ILovenseSDKNotify lovenseNotify)
        {
            var ___RegisterEventCallBackDelegate = __VTables.GetMethodDelegate<global::LovenseWrapper.Delegates.Action___IntPtr___IntPtr>(0, 1);
            var __arg0 = lovenseNotify is null ? __IntPtr.Zero : lovenseNotify.__Instance;
            ___RegisterEventCallBackDelegate(__Instance, __arg0);
        }

        // ********************************************************************************
        /// <summary>
        /// Send a command to the toy
        /// </summary>
        /// <param name="szToyID">toy ID</param>
        /// <param name="cmd">command</param>
        /// <param name="nParam">command parameters</param>
        /// <returns></returns>
        // <created>CMT,21/06/2022</created>
        // <changed>CMT,21/06/2022</changed>
        // ********************************************************************************
        public override int SendCommand(string szToyID, global::LovenseWrapper.CLovenseToy.CmdType cmd, int nParam)
        {
            var ___SendCommandDelegate = __VTables.GetMethodDelegate<global::LovenseWrapper.Delegates.Func_int___IntPtr_string8_LovenseWrapper_CLovenseToy_CmdType_int>(0, 4);
            var __ret = ___SendCommandDelegate(__Instance, szToyID, cmd, nParam);
            return __ret;
        }

        // ********************************************************************************
        /// <summary>
        /// Pass your token into Lovense framework
        /// </summary>
        /// <param name="szToken"></param>
        /// <returns></returns>
        // <created>CMT,21/06/2022</created>
        // <changed>CMT,21/06/2022</changed>
        // ********************************************************************************
        public override bool SetDeveloperToken(string szToken)
        {
            var ___SetDeveloperTokenDelegate = __VTables.GetMethodDelegate<global::LovenseWrapper.Delegates.Func_bool___IntPtr_string8>(0, 0);
            var __ret = ___SetDeveloperTokenDelegate(__Instance, szToken);
            return __ret;
        }

        // ********************************************************************************
        /// <summary>
        /// Search for Lovense toys
        /// </summary>
        /// <returns></returns>
        // <created>CMT,21/06/2022</created>
        // <changed>CMT,21/06/2022</changed>
        // ********************************************************************************
        public override int StartSearchToy()
        {
            var ___StartSearchToyDelegate = __VTables.GetMethodDelegate<global::LovenseWrapper.Delegates.Func_int___IntPtr>(0, 2);
            var __ret = ___StartSearchToyDelegate(__Instance);
            return __ret;
        }

        private static void* __CopyValue(__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(__Internal));
            *(__Internal*)ret = native;
            return ret.ToPointer();
        }
    }

    internal unsafe partial class CToyInfo : IDisposable
    {
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LovenseWrapper.CToyInfo> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::LovenseWrapper.CToyInfo>();

        protected bool __ownsNativeInstance;

        internal CToyInfo(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new __IntPtr(native);
            if (!skipVTables)
                SetupVTables(true);
        }

        internal CToyInfo()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::LovenseWrapper.CToyInfo.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            __Internal.ctor(__Instance);
            SetupVTables(GetType().FullName == "LovenseWrapper.CToyInfo");
        }

        internal CToyInfo(global::LovenseWrapper.CToyInfo _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::LovenseWrapper.CToyInfo.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            if (ReferenceEquals(_0, null))
                throw new global::System.ArgumentNullException("_0", "Cannot be null because it is a C++ reference (&).");
            var __arg0 = _0.__Instance;
            __Internal.cctor(__Instance, __arg0);
            SetupVTables(GetType().FullName == "LovenseWrapper.CToyInfo");
        }

        private CToyInfo(__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public virtual int Bettary
        {
            get
            {
                var ___GetBettaryDelegate = __VTables.GetMethodDelegate<global::LovenseWrapper.Delegates.Func_int___IntPtr>(0, 5);
                var __ret = ___GetBettaryDelegate(__Instance);
                return __ret;
            }
        }

        public virtual bool IsConnected
        {
            get
            {
                var ___IsConnectedDelegate = __VTables.GetMethodDelegate<global::LovenseWrapper.Delegates.Func_bool___IntPtr>(0, 6);
                var __ret = ___IsConnectedDelegate(__Instance);
                return __ret;
            }
        }

        public virtual string ToyFullName
        {
            get
            {
                var ___GetToyFullNameDelegate = __VTables.GetMethodDelegate<global::LovenseWrapper.Delegates.Func___IntPtr___IntPtr>(0, 3);
                var __ret = ___GetToyFullNameDelegate(__Instance);
                var __basicStringRet0 = global::Std.BasicString<sbyte, global::Std.CharTraits<sbyte>, global::Std.Allocator<sbyte>>.__CreateInstance(__ret);
                return global::Std.BasicStringExtensions.Data(__basicStringRet0);
            }

            set
            {
                var __basicString0 = new global::Std.BasicString<sbyte, global::Std.CharTraits<sbyte>, global::Std.Allocator<sbyte>>();
                global::Std.BasicStringExtensions.Assign(__basicString0, value);
                var __arg0 = __basicString0.__Instance;
                __Internal.SetToyFullName(__Instance, __arg0);
                __basicString0.Dispose();
            }
        }

        public virtual string ToyID
        {
            get
            {
                var ___GetToyIDDelegate = __VTables.GetMethodDelegate<global::LovenseWrapper.Delegates.Func___IntPtr___IntPtr>(0, 1);
                var __ret = ___GetToyIDDelegate(__Instance);
                var __basicStringRet0 = global::Std.BasicString<sbyte, global::Std.CharTraits<sbyte>, global::Std.Allocator<sbyte>>.__CreateInstance(__ret);
                return global::Std.BasicStringExtensions.Data(__basicStringRet0);
            }

            set
            {
                var __basicString0 = new global::Std.BasicString<sbyte, global::Std.CharTraits<sbyte>, global::Std.Allocator<sbyte>>();
                global::Std.BasicStringExtensions.Assign(__basicString0, value);
                var __arg0 = __basicString0.__Instance;
                __Internal.SetToyID(__Instance, __arg0);
                __basicString0.Dispose();
            }
        }

        public virtual string ToyName
        {
            get
            {
                var ___GetToyNameDelegate = __VTables.GetMethodDelegate<global::LovenseWrapper.Delegates.Func___IntPtr___IntPtr>(0, 2);
                var __ret = ___GetToyNameDelegate(__Instance);
                var __basicStringRet0 = global::Std.BasicString<sbyte, global::Std.CharTraits<sbyte>, global::Std.Allocator<sbyte>>.__CreateInstance(__ret);
                return global::Std.BasicStringExtensions.Data(__basicStringRet0);
            }

            set
            {
                var __basicString0 = new global::Std.BasicString<sbyte, global::Std.CharTraits<sbyte>, global::Std.Allocator<sbyte>>();
                global::Std.BasicStringExtensions.Assign(__basicString0, value);
                var __arg0 = __basicString0.__Instance;
                __Internal.SetToyName(__Instance, __arg0);
                __basicString0.Dispose();
            }
        }

        public virtual global::LovenseWrapper.LVSToyType ToyType
        {
            get
            {
                var ___GetToyTypeDelegate = __VTables.GetMethodDelegate<global::LovenseWrapper.Delegates.Func_LovenseWrapper_LVSToyType___IntPtr>(0, 7);
                var __ret = ___GetToyTypeDelegate(__Instance);
                return __ret;
            }

            set
            {
                __Internal.SetToyType(__Instance, value);
            }
        }

        public virtual string ToyVersion
        {
            get
            {
                var ___GetToyVersionDelegate = __VTables.GetMethodDelegate<global::LovenseWrapper.Delegates.Func___IntPtr___IntPtr>(0, 4);
                var __ret = ___GetToyVersionDelegate(__Instance);
                var __basicStringRet0 = global::Std.BasicString<sbyte, global::Std.CharTraits<sbyte>, global::Std.Allocator<sbyte>>.__CreateInstance(__ret);
                return global::Std.BasicStringExtensions.Data(__basicStringRet0);
            }

            set
            {
                var __basicString0 = new global::Std.BasicString<sbyte, global::Std.CharTraits<sbyte>, global::Std.Allocator<sbyte>>();
                global::Std.BasicStringExtensions.Assign(__basicString0, value);
                var __arg0 = __basicString0.__Instance;
                __Internal.SetToyVersion(__Instance, __arg0);
                __basicString0.Dispose();
            }
        }

        internal __IntPtr __Instance { get; private set; }

        public void Dispose()
        {
            Dispose(disposing: true, callNativeDtor: __ownsNativeInstance);
        }

        public void SetToyBettary(int bettary)
        {
            __Internal.SetToyBettary(__Instance, bettary);
        }

        public void SetToyConnected(bool connected)
        {
            __Internal.SetToyConnected(__Instance, connected);
        }

        internal static CToyInfo __CreateInstance(__IntPtr native, bool skipVTables = false)
        {
            return new CToyInfo(native.ToPointer(), skipVTables);
        }

        internal static CToyInfo __CreateInstance(__Internal native, bool skipVTables = false)
        {
            return new CToyInfo(native, skipVTables);
        }

        internal static CToyInfo __GetInstance(__IntPtr native)
        {
            if (!NativeToManagedMap.TryGetValue(native, out var managed))
                throw new global::System.Exception("No managed instance was found");
            var result = (CToyInfo)managed;
            if (result.__ownsNativeInstance)
                result.SetupVTables();
            return result;
        }

        internal static CToyInfo __GetOrCreateInstance(__IntPtr native, bool saveInstance = false, bool skipVTables = false)
        {
            if (native == __IntPtr.Zero)
                return null;
            if (NativeToManagedMap.TryGetValue(native, out var managed))
                return (CToyInfo)managed;
            var result = __CreateInstance(native, skipVTables);
            if (saveInstance)
                NativeToManagedMap[native] = result;
            return result;
        }

        internal protected virtual void Dispose(bool disposing, bool callNativeDtor)
        {
            if (__Instance == IntPtr.Zero)
                return;
            NativeToManagedMap.TryRemove(__Instance, out _);
            ((global::LovenseWrapper.CToyInfo.__Internal*)__Instance)->vfptr_CToyInfo = __VTables.Tables[0];
            DisposePartial(disposing);
            if (callNativeDtor)
            {
                var ___dtorDelegate = __VTables.GetMethodDelegate<global::LovenseWrapper.Delegates.Action___IntPtr_int>(0, 0);
                ___dtorDelegate(__Instance, 0);
            }
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        private static void* __CopyValue(__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(__Internal));
            global::LovenseWrapper.CToyInfo.__Internal.cctor(ret, new __IntPtr(&native));
            return ret.ToPointer();
        }

        partial void DisposePartial(bool disposing);

        [StructLayout(LayoutKind.Sequential, Size = 152)]
        internal partial struct __Internal
        {
            internal __IntPtr vfptr_CToyInfo;
            internal global::Std.BasicString.__Internalc__N_std_S_basic_string__C___N_std_S_char_traits__C___N_std_S_allocator__C m_strToyID;
            internal global::Std.BasicString.__Internalc__N_std_S_basic_string__C___N_std_S_char_traits__C___N_std_S_allocator__C m_strToyName;
            internal global::Std.BasicString.__Internalc__N_std_S_basic_string__C___N_std_S_char_traits__C___N_std_S_allocator__C m_strFullName;
            internal global::Std.BasicString.__Internalc__N_std_S_basic_string__C___N_std_S_char_traits__C___N_std_S_allocator__C m_strToyVersion;
            internal byte m_isConnected;
            internal int m_bettary;
            internal global::LovenseWrapper.LVSToyType m_toyType;

            [SuppressUnmanagedCodeSecurity, DllImport("LovenseWrapper", EntryPoint = "??0CToyInfo@@QEAA@XZ", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern __IntPtr ctor(__IntPtr __instance);

            [SuppressUnmanagedCodeSecurity, DllImport("LovenseWrapper", EntryPoint = "??0CToyInfo@@QEAA@AEBV0@@Z", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern __IntPtr cctor(__IntPtr __instance, __IntPtr _0);

            [SuppressUnmanagedCodeSecurity, DllImport("LovenseWrapper", EntryPoint = "?SetToyConnected@CToyInfo@@QEAAX_N@Z", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void SetToyConnected(__IntPtr __instance, bool connected);

            [SuppressUnmanagedCodeSecurity, DllImport("LovenseWrapper", EntryPoint = "?SetToyBettary@CToyInfo@@QEAAXH@Z", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void SetToyBettary(__IntPtr __instance, int bettary);

            [SuppressUnmanagedCodeSecurity, DllImport("LovenseWrapper", EntryPoint = "?SetToyID@CToyInfo@@QEAAXAEBV?$basic_string@DU?$char_traits@D@std@@V?$allocator@D@2@@std@@@Z", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void SetToyID(__IntPtr __instance, __IntPtr toyID);

            [SuppressUnmanagedCodeSecurity, DllImport("LovenseWrapper", EntryPoint = "?SetToyName@CToyInfo@@QEAAXAEBV?$basic_string@DU?$char_traits@D@std@@V?$allocator@D@2@@std@@@Z", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void SetToyName(__IntPtr __instance, __IntPtr toyName);

            [SuppressUnmanagedCodeSecurity, DllImport("LovenseWrapper", EntryPoint = "?SetToyFullName@CToyInfo@@QEAAXAEBV?$basic_string@DU?$char_traits@D@std@@V?$allocator@D@2@@std@@@Z", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void SetToyFullName(__IntPtr __instance, __IntPtr fullName);

            [SuppressUnmanagedCodeSecurity, DllImport("LovenseWrapper", EntryPoint = "?SetToyVersion@CToyInfo@@QEAAXAEBV?$basic_string@DU?$char_traits@D@std@@V?$allocator@D@2@@std@@@Z", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void SetToyVersion(__IntPtr __instance, __IntPtr version);

            [SuppressUnmanagedCodeSecurity, DllImport("LovenseWrapper", EntryPoint = "?SetToyType@CToyInfo@@QEAAXW4LVSToyType@@@Z", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void SetToyType(__IntPtr __instance, global::LovenseWrapper.LVSToyType type);
        }
        #region Virtual table interop

        protected CppSharp.Runtime.VTables __vtables;

        // virtual ~CToyInfo()
        private static global::LovenseWrapper.Delegates.Action___IntPtr_int _dtorDelegateInstance;

        // int GetBettary() const
        private static global::LovenseWrapper.Delegates.Func_int___IntPtr _GetBettaryDelegateInstance;

        // std::string & GetToyFullName() const
        private static global::LovenseWrapper.Delegates.Func___IntPtr___IntPtr _GetToyFullNameDelegateInstance;

        // std::string & GetToyID() const
        private static global::LovenseWrapper.Delegates.Func___IntPtr___IntPtr _GetToyIDDelegateInstance;

        // std::string & GetToyName() const
        private static global::LovenseWrapper.Delegates.Func___IntPtr___IntPtr _GetToyNameDelegateInstance;

        // LVSToyType GetToyType() const
        private static global::LovenseWrapper.Delegates.Func_LovenseWrapper_LVSToyType___IntPtr _GetToyTypeDelegateInstance;

        // std::string & GetToyVersion() const
        private static global::LovenseWrapper.Delegates.Func___IntPtr___IntPtr _GetToyVersionDelegateInstance;

        // bool IsConnected() const
        private static global::LovenseWrapper.Delegates.Func_bool___IntPtr _IsConnectedDelegateInstance;

        internal virtual CppSharp.Runtime.VTables __VTables
        {
            get
            {
                if (__vtables.IsEmpty)
                    __vtables.Tables = new IntPtr[] { *(IntPtr*)(__Instance + 0) };
                return __vtables;
            }

            set
            {
                __vtables = value;
            }
        }

        internal virtual void SetupVTables(bool destructorOnly = false)
        {
            if (__VTables.IsTransient)
                __VTables = VTableLoader.SetupVTables(__Instance, destructorOnly);
        }

        private static void _dtorDelegateHook(__IntPtr __instance, int delete)
        {
            var __target = global::LovenseWrapper.CToyInfo.__GetInstance(__instance);
            __target.Dispose(disposing: true, callNativeDtor: true);
        }
        private static int _GetBettaryDelegateHook(__IntPtr __instance)
        {
            var __target = global::LovenseWrapper.CToyInfo.__GetInstance(__instance);
            return __target.Bettary;
        }

        private static __IntPtr _GetToyFullNameDelegateHook(__IntPtr __instance)
        {
            var __target = global::LovenseWrapper.CToyInfo.__GetInstance(__instance);
            var __ret = __target.ToyFullName;
            var __basicString0 = new global::Std.BasicString<sbyte, global::Std.CharTraits<sbyte>, global::Std.Allocator<sbyte>>();
            global::Std.BasicStringExtensions.Assign(__basicString0, __ret);
            return __basicString0.__Instance;
        }

        private static __IntPtr _GetToyIDDelegateHook(__IntPtr __instance)
        {
            var __target = global::LovenseWrapper.CToyInfo.__GetInstance(__instance);
            var __ret = __target.ToyID;
            var __basicString0 = new global::Std.BasicString<sbyte, global::Std.CharTraits<sbyte>, global::Std.Allocator<sbyte>>();
            global::Std.BasicStringExtensions.Assign(__basicString0, __ret);
            return __basicString0.__Instance;
        }
        private static __IntPtr _GetToyNameDelegateHook(__IntPtr __instance)
        {
            var __target = global::LovenseWrapper.CToyInfo.__GetInstance(__instance);
            var __ret = __target.ToyName;
            var __basicString0 = new global::Std.BasicString<sbyte, global::Std.CharTraits<sbyte>, global::Std.Allocator<sbyte>>();
            global::Std.BasicStringExtensions.Assign(__basicString0, __ret);
            return __basicString0.__Instance;
        }
        private static global::LovenseWrapper.LVSToyType _GetToyTypeDelegateHook(__IntPtr __instance)
        {
            var __target = global::LovenseWrapper.CToyInfo.__GetInstance(__instance);
            var __ret = __target.ToyType;
            return __ret;
        }

        private static __IntPtr _GetToyVersionDelegateHook(__IntPtr __instance)
        {
            var __target = global::LovenseWrapper.CToyInfo.__GetInstance(__instance);
            var __ret = __target.ToyVersion;
            var __basicString0 = new global::Std.BasicString<sbyte, global::Std.CharTraits<sbyte>, global::Std.Allocator<sbyte>>();
            global::Std.BasicStringExtensions.Assign(__basicString0, __ret);
            return __basicString0.__Instance;
        }
        private static bool _IsConnectedDelegateHook(__IntPtr __instance)
        {
            var __target = global::LovenseWrapper.CToyInfo.__GetInstance(__instance);
            return __target.IsConnected;
        }
        internal static class VTableLoader
        {
            private static readonly IntPtr*[] ManagedVTables = new IntPtr*[1];
            private static readonly IntPtr*[] ManagedVTablesDtorOnly = new IntPtr*[1];
            private static readonly global::System.Collections.Generic.List<CppSharp.Runtime.SafeUnmanagedMemoryHandle>
                SafeHandles = new global::System.Collections.Generic.List<CppSharp.Runtime.SafeUnmanagedMemoryHandle>();

            private static readonly IntPtr[] Thunks = new IntPtr[8];
            private static volatile bool initialized;
            private static CppSharp.Runtime.VTables VTables;
            static VTableLoader()
            {
                _dtorDelegateInstance += _dtorDelegateHook;
                _GetToyIDDelegateInstance += _GetToyIDDelegateHook;
                _GetToyNameDelegateInstance += _GetToyNameDelegateHook;
                _GetToyFullNameDelegateInstance += _GetToyFullNameDelegateHook;
                _GetToyVersionDelegateInstance += _GetToyVersionDelegateHook;
                _GetBettaryDelegateInstance += _GetBettaryDelegateHook;
                _IsConnectedDelegateInstance += _IsConnectedDelegateHook;
                _GetToyTypeDelegateInstance += _GetToyTypeDelegateHook;
                Thunks[0] = Marshal.GetFunctionPointerForDelegate(_dtorDelegateInstance);
                Thunks[1] = Marshal.GetFunctionPointerForDelegate(_GetToyIDDelegateInstance);
                Thunks[2] = Marshal.GetFunctionPointerForDelegate(_GetToyNameDelegateInstance);
                Thunks[3] = Marshal.GetFunctionPointerForDelegate(_GetToyFullNameDelegateInstance);
                Thunks[4] = Marshal.GetFunctionPointerForDelegate(_GetToyVersionDelegateInstance);
                Thunks[5] = Marshal.GetFunctionPointerForDelegate(_GetBettaryDelegateInstance);
                Thunks[6] = Marshal.GetFunctionPointerForDelegate(_IsConnectedDelegateInstance);
                Thunks[7] = Marshal.GetFunctionPointerForDelegate(_GetToyTypeDelegateInstance);
            }

            public static CppSharp.Runtime.VTables SetupVTables(IntPtr instance, bool destructorOnly = false)
            {
                if (!initialized)
                {
                    lock (ManagedVTables)
                    {
                        if (!initialized)
                        {
                            initialized = true;
                            VTables.Tables = new IntPtr[] { *(IntPtr*)(instance + 0) };
                            VTables.Methods = new Delegate[1][];
                            ManagedVTablesDtorOnly[0] = CppSharp.Runtime.VTables.CloneTable(SafeHandles, instance, 0, 8);
                            ManagedVTablesDtorOnly[0][0] = Thunks[0];
                            ManagedVTables[0] = CppSharp.Runtime.VTables.CloneTable(SafeHandles, instance, 0, 8);
                            ManagedVTables[0][0] = Thunks[0];
                            ManagedVTables[0][1] = Thunks[1];
                            ManagedVTables[0][2] = Thunks[2];
                            ManagedVTables[0][3] = Thunks[3];
                            ManagedVTables[0][4] = Thunks[4];
                            ManagedVTables[0][5] = Thunks[5];
                            ManagedVTables[0][6] = Thunks[6];
                            ManagedVTables[0][7] = Thunks[7];
                            VTables.Methods[0] = new Delegate[8];
                        }
                    }
                }

                if (destructorOnly)
                {
                    *(IntPtr**)(instance + 0) = ManagedVTablesDtorOnly[0];
                }
                else
                {
                    *(IntPtr**)(instance + 0) = ManagedVTables[0];
                }
                return VTables;
            }
        }
        #endregion
    }

    internal unsafe partial class ILovenseSDKNotifyInternal : global::LovenseWrapper.ILovenseSDKNotify, IDisposable
    {
        internal ILovenseSDKNotifyInternal(__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        internal ILovenseSDKNotifyInternal(void* native, bool skipVTables = false)
            : base((void*)native)
        {
        }

        public override void LovenseDidSearchEnd()
        {
            var ___LovenseDidSearchEndDelegate = __VTables.GetMethodDelegate<global::LovenseWrapper.Delegates.Action___IntPtr>(0, 3);
            ___LovenseDidSearchEndDelegate(__Instance);
        }

        public override void LovenseDidSearchStart()
        {
            var ___LovenseDidSearchStartDelegate = __VTables.GetMethodDelegate<global::LovenseWrapper.Delegates.Action___IntPtr>(0, 0);
            ___LovenseDidSearchStartDelegate(__Instance);
        }

        public override void LovenseDidSendCmdEnd()
        {
            var ___LovenseDidSendCmdEndDelegate = __VTables.GetMethodDelegate<global::LovenseWrapper.Delegates.Action___IntPtr>(0, 6);
            ___LovenseDidSendCmdEndDelegate(__Instance);
        }

        public override void LovenseDidSendCmdStart()
        {
            var ___LovenseDidSendCmdStartDelegate = __VTables.GetMethodDelegate<global::LovenseWrapper.Delegates.Action___IntPtr>(0, 4);
            ___LovenseDidSendCmdStartDelegate(__Instance);
        }

        public override void LovenseErrorOutPut(int errorCode, string errorMsg)
        {
            var ___LovenseErrorOutPutDelegate = __VTables.GetMethodDelegate<global::LovenseWrapper.Delegates.Action___IntPtr_int_string8>(0, 2);
            ___LovenseErrorOutPutDelegate(__Instance, errorCode, errorMsg);
        }

        public override void LovenseSearchingToys(global::LovenseWrapper.StLovenseToyInfo info)
        {
            var ___LovenseSearchingToysDelegate = __VTables.GetMethodDelegate<global::LovenseWrapper.Delegates.Action___IntPtr___IntPtr>(0, 1);
            var __arg0 = info is null ? __IntPtr.Zero : info.__Instance;
            ___LovenseSearchingToysDelegate(__Instance, __arg0);
        }

        public override void LovenseSendCmdResult(string szToyID, global::LovenseWrapper.CLovenseToy.CmdType cmd, string result, global::LovenseWrapper.CLovenseToy.Error errorCode)
        {
            var ___LovenseSendCmdResultDelegate = __VTables.GetMethodDelegate<global::LovenseWrapper.Delegates.Action___IntPtr_string8_LovenseWrapper_CLovenseToy_CmdType_string8_LovenseWrapper_CLovenseToy_Error>(0, 5);
            ___LovenseSendCmdResultDelegate(__Instance, szToyID, cmd, result, errorCode);
        }

        public override void LovenseToyConnectedStatus(string szToyID, bool isConnected)
        {
            var ___LovenseToyConnectedStatusDelegate = __VTables.GetMethodDelegate<global::LovenseWrapper.Delegates.Action___IntPtr_string8_bool>(0, 7);
            ___LovenseToyConnectedStatusDelegate(__Instance, szToyID, isConnected);
        }

        private static void* __CopyValue(__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(__Internal));
            *(__Internal*) ret = native;
            return ret.ToPointer();
        }
    }
}
