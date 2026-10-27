using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020022E8 RID: 8936
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MIDIDevice.FoundMIDIDevice")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FFoundMIDIDevice : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06021E19 RID: 138777 RVA: 0x00320FFB File Offset: 0x0031F1FB
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FFoundMIDIDevice._ScriptStructPtr != 0) ? FFoundMIDIDevice._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MIDIDevice.FoundMIDIDevice", ref FFoundMIDIDevice._ScriptStructPtr);
		}

		// Token: 0x1700831E RID: 33566
		// (get) Token: 0x06021E1A RID: 138778 RVA: 0x0032101F File Offset: 0x0031F21F
		// (set) Token: 0x06021E1B RID: 138779 RVA: 0x0032102F File Offset: 0x0031F22F
		public unsafe int DeviceID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFoundMIDIDevice.__PropertyOffset_DeviceID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFoundMIDIDevice.__PropertyOffset_DeviceID) = value;
			}
		}

		// Token: 0x1700831F RID: 33567
		// (get) Token: 0x06021E1C RID: 138780 RVA: 0x00321040 File Offset: 0x0031F240
		// (set) Token: 0x06021E1D RID: 138781 RVA: 0x00321054 File Offset: 0x0031F254
		public unsafe string DeviceName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FFoundMIDIDevice.__PropertyOffset_DeviceName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FFoundMIDIDevice.__PropertyOffset_DeviceName)), value);
			}
		}

		// Token: 0x17008320 RID: 33568
		// (get) Token: 0x06021E1E RID: 138782 RVA: 0x00321069 File Offset: 0x0031F269
		// (set) Token: 0x06021E1F RID: 138783 RVA: 0x00321079 File Offset: 0x0031F279
		public unsafe bool bCanReceiveFrom
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFoundMIDIDevice.__PropertyOffset_bCanReceiveFrom) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFoundMIDIDevice.__PropertyOffset_bCanReceiveFrom) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008321 RID: 33569
		// (get) Token: 0x06021E20 RID: 138784 RVA: 0x0032108A File Offset: 0x0031F28A
		// (set) Token: 0x06021E21 RID: 138785 RVA: 0x0032109A File Offset: 0x0031F29A
		public unsafe bool bCanSendTo
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFoundMIDIDevice.__PropertyOffset_bCanSendTo) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFoundMIDIDevice.__PropertyOffset_bCanSendTo) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008322 RID: 33570
		// (get) Token: 0x06021E22 RID: 138786 RVA: 0x003210AB File Offset: 0x0031F2AB
		// (set) Token: 0x06021E23 RID: 138787 RVA: 0x003210BB File Offset: 0x0031F2BB
		public unsafe bool bIsAlreadyInUse
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFoundMIDIDevice.__PropertyOffset_bIsAlreadyInUse) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFoundMIDIDevice.__PropertyOffset_bIsAlreadyInUse) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008323 RID: 33571
		// (get) Token: 0x06021E24 RID: 138788 RVA: 0x003210CC File Offset: 0x0031F2CC
		// (set) Token: 0x06021E25 RID: 138789 RVA: 0x003210DC File Offset: 0x0031F2DC
		public unsafe bool bIsDefaultInputDevice
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFoundMIDIDevice.__PropertyOffset_bIsDefaultInputDevice) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFoundMIDIDevice.__PropertyOffset_bIsDefaultInputDevice) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008324 RID: 33572
		// (get) Token: 0x06021E26 RID: 138790 RVA: 0x003210ED File Offset: 0x0031F2ED
		// (set) Token: 0x06021E27 RID: 138791 RVA: 0x003210FD File Offset: 0x0031F2FD
		public unsafe bool bIsDefaultOutputDevice
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFoundMIDIDevice.__PropertyOffset_bIsDefaultOutputDevice) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFoundMIDIDevice.__PropertyOffset_bIsDefaultOutputDevice) = (value ? 1 : 0);
			}
		}

		// Token: 0x06021E28 RID: 138792 RVA: 0x0032110E File Offset: 0x0031F30E
		public FFoundMIDIDevice()
		{
		}

		// Token: 0x06021E29 RID: 138793 RVA: 0x00321116 File Offset: 0x0031F316
		public FFoundMIDIDevice(int DeviceID, string DeviceName, bool bCanReceiveFrom, bool bCanSendTo, bool bIsAlreadyInUse, bool bIsDefaultInputDevice, bool bIsDefaultOutputDevice)
		{
			this.DeviceID = DeviceID;
			this.DeviceName = DeviceName;
			this.bCanReceiveFrom = bCanReceiveFrom;
			this.bCanSendTo = bCanSendTo;
			this.bIsAlreadyInUse = bIsAlreadyInUse;
			this.bIsDefaultInputDevice = bIsDefaultInputDevice;
			this.bIsDefaultOutputDevice = bIsDefaultOutputDevice;
		}

		// Token: 0x06021E2A RID: 138794 RVA: 0x00321153 File Offset: 0x0031F353
		protected override IntPtr GetUStructPtr()
		{
			return FFoundMIDIDevice.StaticStruct();
		}

		// Token: 0x06021E2B RID: 138795 RVA: 0x0032115F File Offset: 0x0031F35F
		[NullableContext(2)]
		public FFoundMIDIDevice(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021E2C RID: 138796 RVA: 0x00321169 File Offset: 0x0031F369
		public FFoundMIDIDevice(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021E2D RID: 138797 RVA: 0x00321174 File Offset: 0x0031F374
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FFoundMIDIDevice(Pointer, false, true);
		}

		// Token: 0x06021E2E RID: 138798 RVA: 0x0032117E File Offset: 0x0031F37E
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FFoundMIDIDevice(Pointer, MemoryOwner);
		}

		// Token: 0x04012141 RID: 74049
		public const string __ObjectPath = "/Script/MIDIDevice.FoundMIDIDevice";

		// Token: 0x04012142 RID: 74050
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012143 RID: 74051
		internal static int __PropertyOffset_DeviceID;

		// Token: 0x04012144 RID: 74052
		internal static int __PropertyOffset_DeviceName;

		// Token: 0x04012145 RID: 74053
		internal static int __PropertyOffset_bCanReceiveFrom;

		// Token: 0x04012146 RID: 74054
		internal static int __PropertyOffset_bCanSendTo;

		// Token: 0x04012147 RID: 74055
		internal static int __PropertyOffset_bIsAlreadyInUse;

		// Token: 0x04012148 RID: 74056
		internal static int __PropertyOffset_bIsDefaultInputDevice;

		// Token: 0x04012149 RID: 74057
		internal static int __PropertyOffset_bIsDefaultOutputDevice;
	}
}
