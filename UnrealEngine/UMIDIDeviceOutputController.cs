using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020022ED RID: 8941
	[UnrealObjectPath("/Script/MIDIDevice.MIDIDeviceOutputController")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UMIDIDeviceOutputController : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021E6F RID: 138863 RVA: 0x00321B23 File Offset: 0x0031FD23
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMIDIDeviceOutputController._ClassPtr;
		}

		// Token: 0x06021E70 RID: 138864 RVA: 0x00321B30 File Offset: 0x0031FD30
		public UMIDIDeviceOutputController() : this(BuiltinUtils.AllocNativeUObject(UMIDIDeviceOutputController.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021E71 RID: 138865 RVA: 0x00321B58 File Offset: 0x0031FD58
		[NullableContext(1)]
		public UMIDIDeviceOutputController(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMIDIDeviceOutputController.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008335 RID: 33589
		// (get) Token: 0x06021E72 RID: 138866 RVA: 0x00321B8B File Offset: 0x0031FD8B
		// (set) Token: 0x06021E73 RID: 138867 RVA: 0x00321B9B File Offset: 0x0031FD9B
		public unsafe int DeviceID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMIDIDeviceOutputController.__PropertyOffset_DeviceID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMIDIDeviceOutputController.__PropertyOffset_DeviceID) = value;
			}
		}

		// Token: 0x17008336 RID: 33590
		// (get) Token: 0x06021E74 RID: 138868 RVA: 0x00321BAC File Offset: 0x0031FDAC
		// (set) Token: 0x06021E75 RID: 138869 RVA: 0x00321BC0 File Offset: 0x0031FDC0
		[Nullable(1)]
		public unsafe string DeviceName
		{
			[NullableContext(1)]
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UMIDIDeviceOutputController.__PropertyOffset_DeviceName)));
			}
			[NullableContext(1)]
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UMIDIDeviceOutputController.__PropertyOffset_DeviceName)), value);
			}
		}

		// Token: 0x06021E76 RID: 138870 RVA: 0x00321BD8 File Offset: 0x0031FDD8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SendMIDIProgramChange(int Channel, int ProgramNumber)
		{
			UMIDIDeviceOutputController.__SendMIDIProgramChange_FunctionParams* ptr = stackalloc UMIDIDeviceOutputController.__SendMIDIProgramChange_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UMIDIDeviceOutputController.__SendMIDIProgramChange_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMIDIDeviceOutputController.__SendMIDIProgramChange_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Channel = Channel;
			ptr->ProgramNumber = ProgramNumber;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMIDIDeviceOutputController.__SendMIDIProgramChange_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06021E77 RID: 138871 RVA: 0x00321C28 File Offset: 0x0031FE28
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SendMIDIPitchBend(int Channel, int Pitch)
		{
			UMIDIDeviceOutputController.__SendMIDIPitchBend_FunctionParams* ptr = stackalloc UMIDIDeviceOutputController.__SendMIDIPitchBend_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UMIDIDeviceOutputController.__SendMIDIPitchBend_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMIDIDeviceOutputController.__SendMIDIPitchBend_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Channel = Channel;
			ptr->Pitch = Pitch;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMIDIDeviceOutputController.__SendMIDIPitchBend_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06021E78 RID: 138872 RVA: 0x00321C78 File Offset: 0x0031FE78
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SendMIDINoteOn(int Channel, int Note, int Velocity)
		{
			UMIDIDeviceOutputController.__SendMIDINoteOn_FunctionParams* ptr = stackalloc UMIDIDeviceOutputController.__SendMIDINoteOn_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(UMIDIDeviceOutputController.__SendMIDINoteOn_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMIDIDeviceOutputController.__SendMIDINoteOn_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Channel = Channel;
			ptr->Note = Note;
			ptr->Velocity = Velocity;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMIDIDeviceOutputController.__SendMIDINoteOn_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06021E79 RID: 138873 RVA: 0x00321CD0 File Offset: 0x0031FED0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SendMIDINoteOff(int Channel, int Note, int Velocity)
		{
			UMIDIDeviceOutputController.__SendMIDINoteOff_FunctionParams* ptr = stackalloc UMIDIDeviceOutputController.__SendMIDINoteOff_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(UMIDIDeviceOutputController.__SendMIDINoteOff_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMIDIDeviceOutputController.__SendMIDINoteOff_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Channel = Channel;
			ptr->Note = Note;
			ptr->Velocity = Velocity;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMIDIDeviceOutputController.__SendMIDINoteOff_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06021E7A RID: 138874 RVA: 0x00321D28 File Offset: 0x0031FF28
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SendMIDINoteAftertouch(int Channel, int Note, float Amount)
		{
			UMIDIDeviceOutputController.__SendMIDINoteAftertouch_FunctionParams* ptr = stackalloc UMIDIDeviceOutputController.__SendMIDINoteAftertouch_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(UMIDIDeviceOutputController.__SendMIDINoteAftertouch_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMIDIDeviceOutputController.__SendMIDINoteAftertouch_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Channel = Channel;
			ptr->Note = Note;
			ptr->Amount = Amount;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMIDIDeviceOutputController.__SendMIDINoteAftertouch_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06021E7B RID: 138875 RVA: 0x00321D80 File Offset: 0x0031FF80
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SendMIDIEvent(EMIDIEventType EventType, int Channel, int data1, int data2)
		{
			UMIDIDeviceOutputController.__SendMIDIEvent_FunctionParams* ptr = stackalloc UMIDIDeviceOutputController.__SendMIDIEvent_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UMIDIDeviceOutputController.__SendMIDIEvent_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMIDIDeviceOutputController.__SendMIDIEvent_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EventType = EventType;
			ptr->Channel = Channel;
			ptr->data1 = data1;
			ptr->data2 = data2;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMIDIDeviceOutputController.__SendMIDIEvent_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06021E7C RID: 138876 RVA: 0x00321DE0 File Offset: 0x0031FFE0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SendMIDIControlChange(int Channel, int Type, int Value)
		{
			UMIDIDeviceOutputController.__SendMIDIControlChange_FunctionParams* ptr = stackalloc UMIDIDeviceOutputController.__SendMIDIControlChange_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(UMIDIDeviceOutputController.__SendMIDIControlChange_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMIDIDeviceOutputController.__SendMIDIControlChange_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Channel = Channel;
			ptr->Type = Type;
			ptr->Value = Value;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMIDIDeviceOutputController.__SendMIDIControlChange_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06021E7D RID: 138877 RVA: 0x00321E38 File Offset: 0x00320038
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SendMIDIChannelAftertouch(int Channel, float Amount)
		{
			UMIDIDeviceOutputController.__SendMIDIChannelAftertouch_FunctionParams* ptr = stackalloc UMIDIDeviceOutputController.__SendMIDIChannelAftertouch_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UMIDIDeviceOutputController.__SendMIDIChannelAftertouch_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMIDIDeviceOutputController.__SendMIDIChannelAftertouch_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Channel = Channel;
			ptr->Amount = Amount;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMIDIDeviceOutputController.__SendMIDIChannelAftertouch_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06021E7E RID: 138878 RVA: 0x00321E86 File Offset: 0x00320086
		static UMIDIDeviceOutputController()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MIDIDevice.MIDIDeviceOutputController");
		}

		// Token: 0x06021E7F RID: 138879 RVA: 0x00321E94 File Offset: 0x00320094
		protected UMIDIDeviceOutputController(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012176 RID: 74102
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MIDIDevice.MIDIDeviceOutputController";

		// Token: 0x04012177 RID: 74103
		private static IntPtr _ClassPtr;

		// Token: 0x04012178 RID: 74104
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012179 RID: 74105
		internal static int __PropertyOffset_DeviceID;

		// Token: 0x0401217A RID: 74106
		internal static int __PropertyOffset_DeviceName;

		// Token: 0x0401217B RID: 74107
		private static IntPtr __SendMIDIProgramChange_NativeFunctionPtr;

		// Token: 0x0401217C RID: 74108
		private static IntPtr __SendMIDIPitchBend_NativeFunctionPtr;

		// Token: 0x0401217D RID: 74109
		private static IntPtr __SendMIDINoteOn_NativeFunctionPtr;

		// Token: 0x0401217E RID: 74110
		private static IntPtr __SendMIDINoteOff_NativeFunctionPtr;

		// Token: 0x0401217F RID: 74111
		private static IntPtr __SendMIDINoteAftertouch_NativeFunctionPtr;

		// Token: 0x04012180 RID: 74112
		private static IntPtr __SendMIDIEvent_NativeFunctionPtr;

		// Token: 0x04012181 RID: 74113
		private static IntPtr __SendMIDIControlChange_NativeFunctionPtr;

		// Token: 0x04012182 RID: 74114
		private static IntPtr __SendMIDIChannelAftertouch_NativeFunctionPtr;

		// Token: 0x02003626 RID: 13862
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __SendMIDIProgramChange_FunctionParams
		{
			// Token: 0x040176BE RID: 95934
			[FieldOffset(0)]
			public int Channel;

			// Token: 0x040176BF RID: 95935
			[FieldOffset(4)]
			public int ProgramNumber;
		}

		// Token: 0x02003627 RID: 13863
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __SendMIDIPitchBend_FunctionParams
		{
			// Token: 0x040176C0 RID: 95936
			[FieldOffset(0)]
			public int Channel;

			// Token: 0x040176C1 RID: 95937
			[FieldOffset(4)]
			public int Pitch;
		}

		// Token: 0x02003628 RID: 13864
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __SendMIDINoteOn_FunctionParams
		{
			// Token: 0x040176C2 RID: 95938
			[FieldOffset(0)]
			public int Channel;

			// Token: 0x040176C3 RID: 95939
			[FieldOffset(4)]
			public int Note;

			// Token: 0x040176C4 RID: 95940
			[FieldOffset(8)]
			public int Velocity;
		}

		// Token: 0x02003629 RID: 13865
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __SendMIDINoteOff_FunctionParams
		{
			// Token: 0x040176C5 RID: 95941
			[FieldOffset(0)]
			public int Channel;

			// Token: 0x040176C6 RID: 95942
			[FieldOffset(4)]
			public int Note;

			// Token: 0x040176C7 RID: 95943
			[FieldOffset(8)]
			public int Velocity;
		}

		// Token: 0x0200362A RID: 13866
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __SendMIDINoteAftertouch_FunctionParams
		{
			// Token: 0x040176C8 RID: 95944
			[FieldOffset(0)]
			public int Channel;

			// Token: 0x040176C9 RID: 95945
			[FieldOffset(4)]
			public int Note;

			// Token: 0x040176CA RID: 95946
			[FieldOffset(8)]
			public float Amount;
		}

		// Token: 0x0200362B RID: 13867
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SendMIDIEvent_FunctionParams
		{
			// Token: 0x040176CB RID: 95947
			[FieldOffset(0)]
			public EMIDIEventType EventType;

			// Token: 0x040176CC RID: 95948
			[FieldOffset(4)]
			public int Channel;

			// Token: 0x040176CD RID: 95949
			[FieldOffset(8)]
			public int data1;

			// Token: 0x040176CE RID: 95950
			[FieldOffset(12)]
			public int data2;
		}

		// Token: 0x0200362C RID: 13868
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __SendMIDIControlChange_FunctionParams
		{
			// Token: 0x040176CF RID: 95951
			[FieldOffset(0)]
			public int Channel;

			// Token: 0x040176D0 RID: 95952
			[FieldOffset(4)]
			public int Type;

			// Token: 0x040176D1 RID: 95953
			[FieldOffset(8)]
			public int Value;
		}

		// Token: 0x0200362D RID: 13869
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __SendMIDIChannelAftertouch_FunctionParams
		{
			// Token: 0x040176D2 RID: 95954
			[FieldOffset(0)]
			public int Channel;

			// Token: 0x040176D3 RID: 95955
			[FieldOffset(4)]
			public float Amount;
		}
	}
}
