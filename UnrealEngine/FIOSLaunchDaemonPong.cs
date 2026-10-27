using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001FA8 RID: 8104
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LaunchDaemonMessages.IOSLaunchDaemonPong")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 72)]
	public class FIOSLaunchDaemonPong : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601EBF6 RID: 125942 RVA: 0x002DB63D File Offset: 0x002D983D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FIOSLaunchDaemonPong._ScriptStructPtr != 0) ? FIOSLaunchDaemonPong._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LaunchDaemonMessages.IOSLaunchDaemonPong", ref FIOSLaunchDaemonPong._ScriptStructPtr);
		}

		// Token: 0x17007A79 RID: 31353
		// (get) Token: 0x0601EBF7 RID: 125943 RVA: 0x002DB661 File Offset: 0x002D9861
		// (set) Token: 0x0601EBF8 RID: 125944 RVA: 0x002DB675 File Offset: 0x002D9875
		public unsafe string DeviceID
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FIOSLaunchDaemonPong.__PropertyOffset_DeviceID)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FIOSLaunchDaemonPong.__PropertyOffset_DeviceID)), value);
			}
		}

		// Token: 0x17007A7A RID: 31354
		// (get) Token: 0x0601EBF9 RID: 125945 RVA: 0x002DB68A File Offset: 0x002D988A
		// (set) Token: 0x0601EBFA RID: 125946 RVA: 0x002DB69E File Offset: 0x002D989E
		public unsafe string DeviceName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FIOSLaunchDaemonPong.__PropertyOffset_DeviceName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FIOSLaunchDaemonPong.__PropertyOffset_DeviceName)), value);
			}
		}

		// Token: 0x17007A7B RID: 31355
		// (get) Token: 0x0601EBFB RID: 125947 RVA: 0x002DB6B3 File Offset: 0x002D98B3
		// (set) Token: 0x0601EBFC RID: 125948 RVA: 0x002DB6C7 File Offset: 0x002D98C7
		public unsafe string DeviceStatus
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FIOSLaunchDaemonPong.__PropertyOffset_DeviceStatus)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FIOSLaunchDaemonPong.__PropertyOffset_DeviceStatus)), value);
			}
		}

		// Token: 0x17007A7C RID: 31356
		// (get) Token: 0x0601EBFD RID: 125949 RVA: 0x002DB6DC File Offset: 0x002D98DC
		// (set) Token: 0x0601EBFE RID: 125950 RVA: 0x002DB6F0 File Offset: 0x002D98F0
		public unsafe string DeviceType
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FIOSLaunchDaemonPong.__PropertyOffset_DeviceType)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FIOSLaunchDaemonPong.__PropertyOffset_DeviceType)), value);
			}
		}

		// Token: 0x17007A7D RID: 31357
		// (get) Token: 0x0601EBFF RID: 125951 RVA: 0x002DB705 File Offset: 0x002D9905
		// (set) Token: 0x0601EC00 RID: 125952 RVA: 0x002DB715 File Offset: 0x002D9915
		public unsafe bool bCanPowerOff
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FIOSLaunchDaemonPong.__PropertyOffset_bCanPowerOff) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FIOSLaunchDaemonPong.__PropertyOffset_bCanPowerOff) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007A7E RID: 31358
		// (get) Token: 0x0601EC01 RID: 125953 RVA: 0x002DB726 File Offset: 0x002D9926
		// (set) Token: 0x0601EC02 RID: 125954 RVA: 0x002DB736 File Offset: 0x002D9936
		public unsafe bool bCanPowerOn
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FIOSLaunchDaemonPong.__PropertyOffset_bCanPowerOn) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FIOSLaunchDaemonPong.__PropertyOffset_bCanPowerOn) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007A7F RID: 31359
		// (get) Token: 0x0601EC03 RID: 125955 RVA: 0x002DB747 File Offset: 0x002D9947
		// (set) Token: 0x0601EC04 RID: 125956 RVA: 0x002DB757 File Offset: 0x002D9957
		public unsafe bool bCanReboot
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FIOSLaunchDaemonPong.__PropertyOffset_bCanReboot) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FIOSLaunchDaemonPong.__PropertyOffset_bCanReboot) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601EC05 RID: 125957 RVA: 0x002DB768 File Offset: 0x002D9968
		public FIOSLaunchDaemonPong()
		{
		}

		// Token: 0x0601EC06 RID: 125958 RVA: 0x002DB770 File Offset: 0x002D9970
		public FIOSLaunchDaemonPong(string DeviceID, string DeviceName, string DeviceStatus, string DeviceType, bool bCanPowerOff, bool bCanPowerOn, bool bCanReboot)
		{
			this.DeviceID = DeviceID;
			this.DeviceName = DeviceName;
			this.DeviceStatus = DeviceStatus;
			this.DeviceType = DeviceType;
			this.bCanPowerOff = bCanPowerOff;
			this.bCanPowerOn = bCanPowerOn;
			this.bCanReboot = bCanReboot;
		}

		// Token: 0x0601EC07 RID: 125959 RVA: 0x002DB7AD File Offset: 0x002D99AD
		protected override IntPtr GetUStructPtr()
		{
			return FIOSLaunchDaemonPong.StaticStruct();
		}

		// Token: 0x0601EC08 RID: 125960 RVA: 0x002DB7B9 File Offset: 0x002D99B9
		[NullableContext(2)]
		public FIOSLaunchDaemonPong(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601EC09 RID: 125961 RVA: 0x002DB7C3 File Offset: 0x002D99C3
		public FIOSLaunchDaemonPong(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601EC0A RID: 125962 RVA: 0x002DB7CE File Offset: 0x002D99CE
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FIOSLaunchDaemonPong(Pointer, false, true);
		}

		// Token: 0x0601EC0B RID: 125963 RVA: 0x002DB7D8 File Offset: 0x002D99D8
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FIOSLaunchDaemonPong(Pointer, MemoryOwner);
		}

		// Token: 0x040109FF RID: 68095
		public const string __ObjectPath = "/Script/LaunchDaemonMessages.IOSLaunchDaemonPong";

		// Token: 0x04010A00 RID: 68096
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010A01 RID: 68097
		internal static int __PropertyOffset_DeviceID;

		// Token: 0x04010A02 RID: 68098
		internal static int __PropertyOffset_DeviceName;

		// Token: 0x04010A03 RID: 68099
		internal static int __PropertyOffset_DeviceStatus;

		// Token: 0x04010A04 RID: 68100
		internal static int __PropertyOffset_DeviceType;

		// Token: 0x04010A05 RID: 68101
		internal static int __PropertyOffset_bCanPowerOff;

		// Token: 0x04010A06 RID: 68102
		internal static int __PropertyOffset_bCanPowerOn;

		// Token: 0x04010A07 RID: 68103
		internal static int __PropertyOffset_bCanReboot;
	}
}
