using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000225 RID: 549
	[UnrealObjectPath("/Script/AkAudio.AkMIDIEventCallbackInfo")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UAkMIDIEventCallbackInfo : UAkEventCallbackInfo, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06002050 RID: 8272 RVA: 0x0002FD53 File Offset: 0x0002DF53
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAkMIDIEventCallbackInfo._ClassPtr;
		}

		// Token: 0x06002051 RID: 8273 RVA: 0x0002FD60 File Offset: 0x0002DF60
		public UAkMIDIEventCallbackInfo() : this(BuiltinUtils.AllocNativeUObject(UAkMIDIEventCallbackInfo.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06002052 RID: 8274 RVA: 0x0002FD88 File Offset: 0x0002DF88
		[NullableContext(1)]
		public UAkMIDIEventCallbackInfo(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAkMIDIEventCallbackInfo.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06002053 RID: 8275 RVA: 0x0002FDBC File Offset: 0x0002DFBC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public new unsafe EAkMidiEventType GetType()
		{
			UAkMIDIEventCallbackInfo.__GetType_FunctionParams* ptr = stackalloc UAkMIDIEventCallbackInfo.__GetType_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UAkMIDIEventCallbackInfo.__GetType_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UAkMIDIEventCallbackInfo.__GetType_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UAkMIDIEventCallbackInfo.__GetType_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06002054 RID: 8276 RVA: 0x0002FE04 File Offset: 0x0002E004
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool GetProgramChange(ref FAkMidiProgramChange AsProgramChange)
		{
			UAkMIDIEventCallbackInfo.__GetProgramChange_FunctionParams* ptr = stackalloc UAkMIDIEventCallbackInfo.__GetProgramChange_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UAkMIDIEventCallbackInfo.__GetProgramChange_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UAkMIDIEventCallbackInfo.__GetProgramChange_NativeFunctionPtr, (void*)ptr, 1);
			if (AsProgramChange != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FAkMidiProgramChange.StaticStruct(), &ptr->AsProgramChange, AsProgramChange.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UAkMIDIEventCallbackInfo.__GetProgramChange_NativeFunctionPtr, (void*)ptr, 0);
			if (AsProgramChange != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FAkMidiProgramChange.StaticStruct(), AsProgramChange.NativePtr, &ptr->AsProgramChange, 1, false);
			}
			return ptr->__Result;
		}

		// Token: 0x06002055 RID: 8277 RVA: 0x0002FE94 File Offset: 0x0002E094
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool GetPitchBend(ref FAkMidiPitchBend AsPitchBend)
		{
			UAkMIDIEventCallbackInfo.__GetPitchBend_FunctionParams* ptr = stackalloc UAkMIDIEventCallbackInfo.__GetPitchBend_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(UAkMIDIEventCallbackInfo.__GetPitchBend_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UAkMIDIEventCallbackInfo.__GetPitchBend_NativeFunctionPtr, (void*)ptr, 1);
			if (AsPitchBend != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FAkMidiPitchBend.StaticStruct(), &ptr->AsPitchBend, AsPitchBend.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UAkMIDIEventCallbackInfo.__GetPitchBend_NativeFunctionPtr, (void*)ptr, 0);
			if (AsPitchBend != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FAkMidiPitchBend.StaticStruct(), AsPitchBend.NativePtr, &ptr->AsPitchBend, 1, false);
			}
			return ptr->__Result;
		}

		// Token: 0x06002056 RID: 8278 RVA: 0x0002FF24 File Offset: 0x0002E124
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool GetNoteOn(ref FAkMidiNoteOnOff AsNoteOn)
		{
			UAkMIDIEventCallbackInfo.__GetNoteOn_FunctionParams* ptr = stackalloc UAkMIDIEventCallbackInfo.__GetNoteOn_FunctionParams[(UIntPtr)20] + 15L / (long)sizeof(UAkMIDIEventCallbackInfo.__GetNoteOn_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UAkMIDIEventCallbackInfo.__GetNoteOn_NativeFunctionPtr, (void*)ptr, 1);
			if (AsNoteOn != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FAkMidiNoteOnOff.StaticStruct(), &ptr->AsNoteOn, AsNoteOn.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UAkMIDIEventCallbackInfo.__GetNoteOn_NativeFunctionPtr, (void*)ptr, 0);
			if (AsNoteOn != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FAkMidiNoteOnOff.StaticStruct(), AsNoteOn.NativePtr, &ptr->AsNoteOn, 1, false);
			}
			return ptr->__Result;
		}

		// Token: 0x06002057 RID: 8279 RVA: 0x0002FFB4 File Offset: 0x0002E1B4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool GetNoteOff(ref FAkMidiNoteOnOff AsNoteOff)
		{
			UAkMIDIEventCallbackInfo.__GetNoteOff_FunctionParams* ptr = stackalloc UAkMIDIEventCallbackInfo.__GetNoteOff_FunctionParams[(UIntPtr)20] + 15L / (long)sizeof(UAkMIDIEventCallbackInfo.__GetNoteOff_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UAkMIDIEventCallbackInfo.__GetNoteOff_NativeFunctionPtr, (void*)ptr, 1);
			if (AsNoteOff != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FAkMidiNoteOnOff.StaticStruct(), &ptr->AsNoteOff, AsNoteOff.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UAkMIDIEventCallbackInfo.__GetNoteOff_NativeFunctionPtr, (void*)ptr, 0);
			if (AsNoteOff != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FAkMidiNoteOnOff.StaticStruct(), AsNoteOff.NativePtr, &ptr->AsNoteOff, 1, false);
			}
			return ptr->__Result;
		}

		// Token: 0x06002058 RID: 8280 RVA: 0x00030044 File Offset: 0x0002E244
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool GetNoteAftertouch(ref FAkMidiNoteAftertouch AsNoteAftertouch)
		{
			UAkMIDIEventCallbackInfo.__GetNoteAftertouch_FunctionParams* ptr = stackalloc UAkMIDIEventCallbackInfo.__GetNoteAftertouch_FunctionParams[(UIntPtr)20] + 15L / (long)sizeof(UAkMIDIEventCallbackInfo.__GetNoteAftertouch_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UAkMIDIEventCallbackInfo.__GetNoteAftertouch_NativeFunctionPtr, (void*)ptr, 1);
			if (AsNoteAftertouch != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FAkMidiNoteAftertouch.StaticStruct(), &ptr->AsNoteAftertouch, AsNoteAftertouch.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UAkMIDIEventCallbackInfo.__GetNoteAftertouch_NativeFunctionPtr, (void*)ptr, 0);
			if (AsNoteAftertouch != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FAkMidiNoteAftertouch.StaticStruct(), AsNoteAftertouch.NativePtr, &ptr->AsNoteAftertouch, 1, false);
			}
			return ptr->__Result;
		}

		// Token: 0x06002059 RID: 8281 RVA: 0x000300D4 File Offset: 0x0002E2D4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool GetGeneric(ref FAkMidiGeneric AsGeneric)
		{
			UAkMIDIEventCallbackInfo.__GetGeneric_FunctionParams* ptr = stackalloc UAkMIDIEventCallbackInfo.__GetGeneric_FunctionParams[(UIntPtr)20] + 15L / (long)sizeof(UAkMIDIEventCallbackInfo.__GetGeneric_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UAkMIDIEventCallbackInfo.__GetGeneric_NativeFunctionPtr, (void*)ptr, 1);
			if (AsGeneric != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FAkMidiGeneric.StaticStruct(), &ptr->AsGeneric, AsGeneric.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UAkMIDIEventCallbackInfo.__GetGeneric_NativeFunctionPtr, (void*)ptr, 0);
			if (AsGeneric != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FAkMidiGeneric.StaticStruct(), AsGeneric.NativePtr, &ptr->AsGeneric, 1, false);
			}
			return ptr->__Result;
		}

		// Token: 0x0600205A RID: 8282 RVA: 0x00030164 File Offset: 0x0002E364
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool GetChannelAftertouch(ref FAkMidiChannelAftertouch AsChannelAftertouch)
		{
			UAkMIDIEventCallbackInfo.__GetChannelAftertouch_FunctionParams* ptr = stackalloc UAkMIDIEventCallbackInfo.__GetChannelAftertouch_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UAkMIDIEventCallbackInfo.__GetChannelAftertouch_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UAkMIDIEventCallbackInfo.__GetChannelAftertouch_NativeFunctionPtr, (void*)ptr, 1);
			if (AsChannelAftertouch != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FAkMidiChannelAftertouch.StaticStruct(), &ptr->AsChannelAftertouch, AsChannelAftertouch.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UAkMIDIEventCallbackInfo.__GetChannelAftertouch_NativeFunctionPtr, (void*)ptr, 0);
			if (AsChannelAftertouch != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FAkMidiChannelAftertouch.StaticStruct(), AsChannelAftertouch.NativePtr, &ptr->AsChannelAftertouch, 1, false);
			}
			return ptr->__Result;
		}

		// Token: 0x0600205B RID: 8283 RVA: 0x000301F4 File Offset: 0x0002E3F4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe byte GetChannel()
		{
			UAkMIDIEventCallbackInfo.__GetChannel_FunctionParams* ptr = stackalloc UAkMIDIEventCallbackInfo.__GetChannel_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UAkMIDIEventCallbackInfo.__GetChannel_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UAkMIDIEventCallbackInfo.__GetChannel_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UAkMIDIEventCallbackInfo.__GetChannel_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0600205C RID: 8284 RVA: 0x0003023C File Offset: 0x0002E43C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool GetCc(ref FAkMidiCc AsCc)
		{
			UAkMIDIEventCallbackInfo.__GetCc_FunctionParams* ptr = stackalloc UAkMIDIEventCallbackInfo.__GetCc_FunctionParams[(UIntPtr)20] + 15L / (long)sizeof(UAkMIDIEventCallbackInfo.__GetCc_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UAkMIDIEventCallbackInfo.__GetCc_NativeFunctionPtr, (void*)ptr, 1);
			if (AsCc != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FAkMidiCc.StaticStruct(), &ptr->AsCc, AsCc.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UAkMIDIEventCallbackInfo.__GetCc_NativeFunctionPtr, (void*)ptr, 0);
			if (AsCc != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FAkMidiCc.StaticStruct(), AsCc.NativePtr, &ptr->AsCc, 1, false);
			}
			return ptr->__Result;
		}

		// Token: 0x0600205D RID: 8285 RVA: 0x000302CA File Offset: 0x0002E4CA
		static UAkMIDIEventCallbackInfo()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AkAudio.AkMIDIEventCallbackInfo");
		}

		// Token: 0x0600205E RID: 8286 RVA: 0x000302D8 File Offset: 0x0002E4D8
		protected UAkMIDIEventCallbackInfo(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000AD2 RID: 2770
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AkAudio.AkMIDIEventCallbackInfo";

		// Token: 0x04000AD3 RID: 2771
		private static IntPtr _ClassPtr;

		// Token: 0x04000AD4 RID: 2772
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000AD5 RID: 2773
		private static IntPtr __GetType_NativeFunctionPtr;

		// Token: 0x04000AD6 RID: 2774
		private static IntPtr __GetProgramChange_NativeFunctionPtr;

		// Token: 0x04000AD7 RID: 2775
		private static IntPtr __GetPitchBend_NativeFunctionPtr;

		// Token: 0x04000AD8 RID: 2776
		private static IntPtr __GetNoteOn_NativeFunctionPtr;

		// Token: 0x04000AD9 RID: 2777
		private static IntPtr __GetNoteOff_NativeFunctionPtr;

		// Token: 0x04000ADA RID: 2778
		private static IntPtr __GetNoteAftertouch_NativeFunctionPtr;

		// Token: 0x04000ADB RID: 2779
		private static IntPtr __GetGeneric_NativeFunctionPtr;

		// Token: 0x04000ADC RID: 2780
		private static IntPtr __GetChannelAftertouch_NativeFunctionPtr;

		// Token: 0x04000ADD RID: 2781
		private static IntPtr __GetChannel_NativeFunctionPtr;

		// Token: 0x04000ADE RID: 2782
		private static IntPtr __GetCc_NativeFunctionPtr;

		// Token: 0x02002B7D RID: 11133
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __GetType_FunctionParams
		{
			// Token: 0x04016408 RID: 91144
			[FieldOffset(0)]
			public EAkMidiEventType __Result;
		}

		// Token: 0x02002B7E RID: 11134
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetProgramChange_FunctionParams
		{
			// Token: 0x04016409 RID: 91145
			[FieldOffset(0)]
			public byte AsProgramChange;

			// Token: 0x0401640A RID: 91146
			[FieldOffset(3)]
			public bool __Result;
		}

		// Token: 0x02002B7F RID: 11135
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __GetPitchBend_FunctionParams
		{
			// Token: 0x0401640B RID: 91147
			[FieldOffset(0)]
			public byte AsPitchBend;

			// Token: 0x0401640C RID: 91148
			[FieldOffset(8)]
			public bool __Result;
		}

		// Token: 0x02002B80 RID: 11136
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 5)]
		protected ref struct __GetNoteOn_FunctionParams
		{
			// Token: 0x0401640D RID: 91149
			[FieldOffset(0)]
			public byte AsNoteOn;

			// Token: 0x0401640E RID: 91150
			[FieldOffset(4)]
			public bool __Result;
		}

		// Token: 0x02002B81 RID: 11137
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 5)]
		protected ref struct __GetNoteOff_FunctionParams
		{
			// Token: 0x0401640F RID: 91151
			[FieldOffset(0)]
			public byte AsNoteOff;

			// Token: 0x04016410 RID: 91152
			[FieldOffset(4)]
			public bool __Result;
		}

		// Token: 0x02002B82 RID: 11138
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 5)]
		protected ref struct __GetNoteAftertouch_FunctionParams
		{
			// Token: 0x04016411 RID: 91153
			[FieldOffset(0)]
			public byte AsNoteAftertouch;

			// Token: 0x04016412 RID: 91154
			[FieldOffset(4)]
			public bool __Result;
		}

		// Token: 0x02002B83 RID: 11139
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 5)]
		protected ref struct __GetGeneric_FunctionParams
		{
			// Token: 0x04016413 RID: 91155
			[FieldOffset(0)]
			public byte AsGeneric;

			// Token: 0x04016414 RID: 91156
			[FieldOffset(4)]
			public bool __Result;
		}

		// Token: 0x02002B84 RID: 11140
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetChannelAftertouch_FunctionParams
		{
			// Token: 0x04016415 RID: 91157
			[FieldOffset(0)]
			public byte AsChannelAftertouch;

			// Token: 0x04016416 RID: 91158
			[FieldOffset(3)]
			public bool __Result;
		}

		// Token: 0x02002B85 RID: 11141
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __GetChannel_FunctionParams
		{
			// Token: 0x04016417 RID: 91159
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02002B86 RID: 11142
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 5)]
		protected ref struct __GetCc_FunctionParams
		{
			// Token: 0x04016418 RID: 91160
			[FieldOffset(0)]
			public byte AsCc;

			// Token: 0x04016419 RID: 91161
			[FieldOffset(4)]
			public bool __Result;
		}
	}
}
