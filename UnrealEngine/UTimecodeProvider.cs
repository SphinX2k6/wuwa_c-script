using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020011E9 RID: 4585
	[UnrealObjectPath("/Script/Engine.TimecodeProvider")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public abstract class UTimecodeProvider : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06010E23 RID: 69155 RVA: 0x0018CB3D File Offset: 0x0018AD3D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTimecodeProvider._ClassPtr;
		}

		// Token: 0x17004200 RID: 16896
		// (get) Token: 0x06010E24 RID: 69156 RVA: 0x0018CB49 File Offset: 0x0018AD49
		// (set) Token: 0x06010E25 RID: 69157 RVA: 0x0018CB59 File Offset: 0x0018AD59
		public unsafe float FrameDelay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTimecodeProvider.__PropertyOffset_FrameDelay);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTimecodeProvider.__PropertyOffset_FrameDelay) = value;
			}
		}

		// Token: 0x06010E26 RID: 69158 RVA: 0x0018CB6A File Offset: 0x0018AD6A
		public FTimecode GetTimecode()
		{
			return UTimecodeProvider.__GetTimecode_Internal(base.NativePtr);
		}

		// Token: 0x06010E27 RID: 69159 RVA: 0x0018CB77 File Offset: 0x0018AD77
		public ETimecodeProviderSynchronizationState GetSynchronizationState()
		{
			return UTimecodeProvider.__GetSynchronizationState_Internal(base.NativePtr);
		}

		// Token: 0x06010E28 RID: 69160 RVA: 0x0018CB84 File Offset: 0x0018AD84
		[NullableContext(1)]
		public FQualifiedFrameTime GetQualifiedFrameTime()
		{
			return new FQualifiedFrameTime(UTimecodeProvider.__GetQualifiedFrameTime_Internal(base.NativePtr), null);
		}

		// Token: 0x06010E29 RID: 69161 RVA: 0x0018CB97 File Offset: 0x0018AD97
		public FFrameRate GetFrameRate()
		{
			return UTimecodeProvider.__GetFrameRate_Internal(base.NativePtr);
		}

		// Token: 0x06010E2A RID: 69162 RVA: 0x0018CBA4 File Offset: 0x0018ADA4
		public FTimecode GetDelayedTimecode()
		{
			return UTimecodeProvider.__GetDelayedTimecode_Internal(base.NativePtr);
		}

		// Token: 0x06010E2B RID: 69163 RVA: 0x0018CBB1 File Offset: 0x0018ADB1
		[NullableContext(1)]
		public FQualifiedFrameTime GetDelayedQualifiedFrameTime()
		{
			return new FQualifiedFrameTime(UTimecodeProvider.__GetDelayedQualifiedFrameTime_Internal(base.NativePtr), null);
		}

		// Token: 0x06010E2C RID: 69164 RVA: 0x0018CBC4 File Offset: 0x0018ADC4
		[NullableContext(2)]
		public bool FetchTimecode(ref FQualifiedFrameTime OutFrameTime)
		{
			return UTimecodeProvider.__FetchTimecode_Internal(base.NativePtr, (OutFrameTime ?? new FQualifiedFrameTime()).NativePtr);
		}

		// Token: 0x06010E2D RID: 69165 RVA: 0x0018CBE1 File Offset: 0x0018ADE1
		public void FetchAndUpdate()
		{
			UTimecodeProvider.__FetchAndUpdate_Internal(base.NativePtr);
		}

		// Token: 0x06010E2E RID: 69166
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTimecode __GetTimecode_Internal(IntPtr @this);

		// Token: 0x06010E2F RID: 69167
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern ETimecodeProviderSynchronizationState __GetSynchronizationState_Internal(IntPtr @this);

		// Token: 0x06010E30 RID: 69168
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetQualifiedFrameTime_Internal(IntPtr @this);

		// Token: 0x06010E31 RID: 69169
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FFrameRate __GetFrameRate_Internal(IntPtr @this);

		// Token: 0x06010E32 RID: 69170
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTimecode __GetDelayedTimecode_Internal(IntPtr @this);

		// Token: 0x06010E33 RID: 69171
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetDelayedQualifiedFrameTime_Internal(IntPtr @this);

		// Token: 0x06010E34 RID: 69172
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __FetchTimecode_Internal(IntPtr @this, IntPtr OutFrameTime);

		// Token: 0x06010E35 RID: 69173
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __FetchAndUpdate_Internal(IntPtr @this);

		// Token: 0x06010E36 RID: 69174 RVA: 0x0018CBEE File Offset: 0x0018ADEE
		static UTimecodeProvider()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.TimecodeProvider");
		}

		// Token: 0x06010E37 RID: 69175 RVA: 0x0018CBFC File Offset: 0x0018ADFC
		protected UTimecodeProvider() : this(BuiltinUtils.AllocNativeUObject(UTimecodeProvider.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06010E38 RID: 69176 RVA: 0x0018CC24 File Offset: 0x0018AE24
		protected UTimecodeProvider(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040090CD RID: 37069
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.TimecodeProvider";

		// Token: 0x040090CE RID: 37070
		private static IntPtr _ClassPtr;

		// Token: 0x040090CF RID: 37071
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040090D0 RID: 37072
		internal static int __PropertyOffset_FrameDelay;
	}
}
