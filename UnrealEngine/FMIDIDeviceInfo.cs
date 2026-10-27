using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020022EA RID: 8938
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MIDIDevice.MIDIDeviceInfo")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FMIDIDeviceInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06021E3A RID: 138810 RVA: 0x003212AB File Offset: 0x0031F4AB
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMIDIDeviceInfo._ScriptStructPtr != 0) ? FMIDIDeviceInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MIDIDevice.MIDIDeviceInfo", ref FMIDIDeviceInfo._ScriptStructPtr);
		}

		// Token: 0x17008328 RID: 33576
		// (get) Token: 0x06021E3B RID: 138811 RVA: 0x003212CF File Offset: 0x0031F4CF
		// (set) Token: 0x06021E3C RID: 138812 RVA: 0x003212DF File Offset: 0x0031F4DF
		public unsafe int DeviceID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMIDIDeviceInfo.__PropertyOffset_DeviceID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMIDIDeviceInfo.__PropertyOffset_DeviceID) = value;
			}
		}

		// Token: 0x17008329 RID: 33577
		// (get) Token: 0x06021E3D RID: 138813 RVA: 0x003212F0 File Offset: 0x0031F4F0
		// (set) Token: 0x06021E3E RID: 138814 RVA: 0x00321304 File Offset: 0x0031F504
		public unsafe string DeviceName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FMIDIDeviceInfo.__PropertyOffset_DeviceName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FMIDIDeviceInfo.__PropertyOffset_DeviceName)), value);
			}
		}

		// Token: 0x1700832A RID: 33578
		// (get) Token: 0x06021E3F RID: 138815 RVA: 0x00321319 File Offset: 0x0031F519
		// (set) Token: 0x06021E40 RID: 138816 RVA: 0x00321329 File Offset: 0x0031F529
		public unsafe bool bIsAlreadyInUse
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMIDIDeviceInfo.__PropertyOffset_bIsAlreadyInUse) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMIDIDeviceInfo.__PropertyOffset_bIsAlreadyInUse) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700832B RID: 33579
		// (get) Token: 0x06021E41 RID: 138817 RVA: 0x0032133A File Offset: 0x0031F53A
		// (set) Token: 0x06021E42 RID: 138818 RVA: 0x0032134A File Offset: 0x0031F54A
		public unsafe bool bIsDefaultDevice
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMIDIDeviceInfo.__PropertyOffset_bIsDefaultDevice) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMIDIDeviceInfo.__PropertyOffset_bIsDefaultDevice) = (value ? 1 : 0);
			}
		}

		// Token: 0x06021E43 RID: 138819 RVA: 0x0032135B File Offset: 0x0031F55B
		public FMIDIDeviceInfo()
		{
		}

		// Token: 0x06021E44 RID: 138820 RVA: 0x00321363 File Offset: 0x0031F563
		public FMIDIDeviceInfo(int DeviceID, string DeviceName, bool bIsAlreadyInUse, bool bIsDefaultDevice)
		{
			this.DeviceID = DeviceID;
			this.DeviceName = DeviceName;
			this.bIsAlreadyInUse = bIsAlreadyInUse;
			this.bIsDefaultDevice = bIsDefaultDevice;
		}

		// Token: 0x06021E45 RID: 138821 RVA: 0x00321388 File Offset: 0x0031F588
		protected override IntPtr GetUStructPtr()
		{
			return FMIDIDeviceInfo.StaticStruct();
		}

		// Token: 0x06021E46 RID: 138822 RVA: 0x00321394 File Offset: 0x0031F594
		[NullableContext(2)]
		public FMIDIDeviceInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021E47 RID: 138823 RVA: 0x0032139E File Offset: 0x0031F59E
		public FMIDIDeviceInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021E48 RID: 138824 RVA: 0x003213A9 File Offset: 0x0031F5A9
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMIDIDeviceInfo(Pointer, false, true);
		}

		// Token: 0x06021E49 RID: 138825 RVA: 0x003213B3 File Offset: 0x0031F5B3
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMIDIDeviceInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04012151 RID: 74065
		public const string __ObjectPath = "/Script/MIDIDevice.MIDIDeviceInfo";

		// Token: 0x04012152 RID: 74066
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012153 RID: 74067
		internal static int __PropertyOffset_DeviceID;

		// Token: 0x04012154 RID: 74068
		internal static int __PropertyOffset_DeviceName;

		// Token: 0x04012155 RID: 74069
		internal static int __PropertyOffset_bIsAlreadyInUse;

		// Token: 0x04012156 RID: 74070
		internal static int __PropertyOffset_bIsDefaultDevice;
	}
}
