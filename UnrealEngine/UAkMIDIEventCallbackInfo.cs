using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020000C8 RID: 200
	[UnrealObjectPath("/Script/AkAudio.AkMIDIEventCallbackInfo")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UAkMIDIEventCallbackInfo : UAkEventCallbackInfo, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06000EDE RID: 3806 RVA: 0x00016FE8 File Offset: 0x000151E8
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAkMIDIEventCallbackInfo._ClassPtr;
		}

		// Token: 0x06000EDF RID: 3807 RVA: 0x00016FF4 File Offset: 0x000151F4
		public UAkMIDIEventCallbackInfo() : this(BuiltinUtils.AllocNativeUObject(UAkMIDIEventCallbackInfo.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06000EE0 RID: 3808 RVA: 0x0001701C File Offset: 0x0001521C
		[NullableContext(1)]
		public UAkMIDIEventCallbackInfo(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAkMIDIEventCallbackInfo.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06000EE1 RID: 3809 RVA: 0x00017050 File Offset: 0x00015250
		[SkipLocalsInit]
		public new unsafe EAkMidiEventType GetType()
		{
			UAkMIDIEventCallbackInfo.__GetType_FunctionParams* ptr = stackalloc UAkMIDIEventCallbackInfo.__GetType_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UAkMIDIEventCallbackInfo.__GetType_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UAkMIDIEventCallbackInfo.__GetType_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UAkMIDIEventCallbackInfo.__GetType_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06000EE2 RID: 3810 RVA: 0x00017098 File Offset: 0x00015298
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe bool GetNoteOn(ref FAkMidiNoteOnOff AsNoteOn)
		{
			UAkMIDIEventCallbackInfo.__GetNoteOn_FunctionParams* ptr = stackalloc UAkMIDIEventCallbackInfo.__GetNoteOn_FunctionParams[(UIntPtr)20] + 15L / (long)sizeof(UAkMIDIEventCallbackInfo.__GetNoteOn_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UAkMIDIEventCallbackInfo.__GetNoteOn_NativeFunctionPtr, (void*)ptr, 1);
			if (AsNoteOn != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FAkMidiNoteOnOff.StaticStruct(), &ptr->AsNoteOn, AsNoteOn.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UAkMIDIEventCallbackInfo.__GetNoteOn_NativeFunctionPtr, (void*)ptr);
			if (AsNoteOn != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FAkMidiNoteOnOff.StaticStruct(), AsNoteOn.NativePtr, &ptr->AsNoteOn, 1, false);
			}
			return ptr->__Result;
		}

		// Token: 0x06000EE3 RID: 3811 RVA: 0x00017128 File Offset: 0x00015328
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe bool GetNoteOff(ref FAkMidiNoteOnOff AsNoteOff)
		{
			UAkMIDIEventCallbackInfo.__GetNoteOff_FunctionParams* ptr = stackalloc UAkMIDIEventCallbackInfo.__GetNoteOff_FunctionParams[(UIntPtr)20] + 15L / (long)sizeof(UAkMIDIEventCallbackInfo.__GetNoteOff_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UAkMIDIEventCallbackInfo.__GetNoteOff_NativeFunctionPtr, (void*)ptr, 1);
			if (AsNoteOff != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FAkMidiNoteOnOff.StaticStruct(), &ptr->AsNoteOff, AsNoteOff.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UAkMIDIEventCallbackInfo.__GetNoteOff_NativeFunctionPtr, (void*)ptr);
			if (AsNoteOff != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FAkMidiNoteOnOff.StaticStruct(), AsNoteOff.NativePtr, &ptr->AsNoteOff, 1, false);
			}
			return ptr->__Result;
		}

		// Token: 0x06000EE4 RID: 3812 RVA: 0x000171B8 File Offset: 0x000153B8
		[SkipLocalsInit]
		public unsafe byte GetChannel()
		{
			UAkMIDIEventCallbackInfo.__GetChannel_FunctionParams* ptr = stackalloc UAkMIDIEventCallbackInfo.__GetChannel_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UAkMIDIEventCallbackInfo.__GetChannel_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UAkMIDIEventCallbackInfo.__GetChannel_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UAkMIDIEventCallbackInfo.__GetChannel_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06000EE5 RID: 3813 RVA: 0x000171FD File Offset: 0x000153FD
		static UAkMIDIEventCallbackInfo()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AkAudio.AkMIDIEventCallbackInfo");
		}

		// Token: 0x06000EE6 RID: 3814 RVA: 0x0001720B File Offset: 0x0001540B
		protected UAkMIDIEventCallbackInfo(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040002E7 RID: 743
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AkAudio.AkMIDIEventCallbackInfo";

		// Token: 0x040002E8 RID: 744
		private static IntPtr _ClassPtr;

		// Token: 0x040002E9 RID: 745
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040002EA RID: 746
		private static IntPtr __GetType_NativeFunctionPtr;

		// Token: 0x040002EB RID: 747
		private static IntPtr __GetNoteOn_NativeFunctionPtr;

		// Token: 0x040002EC RID: 748
		private static IntPtr __GetNoteOff_NativeFunctionPtr;

		// Token: 0x040002ED RID: 749
		private static IntPtr __GetChannel_NativeFunctionPtr;

		// Token: 0x02000901 RID: 2305
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __GetType_FunctionParams
		{
			// Token: 0x040057D8 RID: 22488
			[FieldOffset(0)]
			public EAkMidiEventType __Result;
		}

		// Token: 0x02000902 RID: 2306
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 5)]
		protected ref struct __GetNoteOn_FunctionParams
		{
			// Token: 0x040057D9 RID: 22489
			[FieldOffset(0)]
			public byte AsNoteOn;

			// Token: 0x040057DA RID: 22490
			[FieldOffset(4)]
			public bool __Result;
		}

		// Token: 0x02000903 RID: 2307
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 5)]
		protected ref struct __GetNoteOff_FunctionParams
		{
			// Token: 0x040057DB RID: 22491
			[FieldOffset(0)]
			public byte AsNoteOff;

			// Token: 0x040057DC RID: 22492
			[FieldOffset(4)]
			public bool __Result;
		}

		// Token: 0x02000904 RID: 2308
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __GetChannel_FunctionParams
		{
			// Token: 0x040057DD RID: 22493
			[FieldOffset(0)]
			public byte __Result;
		}
	}
}
