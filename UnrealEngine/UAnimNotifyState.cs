using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200017D RID: 381
	[UnrealObjectPath("/Script/Engine.AnimNotifyState")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public abstract class UAnimNotifyState : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600183F RID: 6207 RVA: 0x000250A0 File Offset: 0x000232A0
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAnimNotifyState._ClassPtr;
		}

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x06001840 RID: 6208 RVA: 0x000250AC File Offset: 0x000232AC
		// (set) Token: 0x06001841 RID: 6209 RVA: 0x000250BC File Offset: 0x000232BC
		public unsafe bool bOnlyTriggerInMainAnim
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimNotifyState.__PropertyOffset_bOnlyTriggerInMainAnim) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimNotifyState.__PropertyOffset_bOnlyTriggerInMainAnim) = (value ? 1 : 0);
			}
		}

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x06001842 RID: 6210 RVA: 0x000250CD File Offset: 0x000232CD
		// (set) Token: 0x06001843 RID: 6211 RVA: 0x000250DD File Offset: 0x000232DD
		public unsafe bool NeedSimulateBegin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimNotifyState.__PropertyOffset_NeedSimulateBegin) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimNotifyState.__PropertyOffset_NeedSimulateBegin) = (value ? 1 : 0);
			}
		}

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x06001844 RID: 6212 RVA: 0x000250EE File Offset: 0x000232EE
		// (set) Token: 0x06001845 RID: 6213 RVA: 0x000250FE File Offset: 0x000232FE
		public unsafe bool NeedSimulateTick
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimNotifyState.__PropertyOffset_NeedSimulateTick) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimNotifyState.__PropertyOffset_NeedSimulateTick) = (value ? 1 : 0);
			}
		}

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x06001846 RID: 6214 RVA: 0x0002510F File Offset: 0x0002330F
		// (set) Token: 0x06001847 RID: 6215 RVA: 0x0002511F File Offset: 0x0002331F
		public unsafe bool NeedSimulateEnd
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimNotifyState.__PropertyOffset_NeedSimulateEnd) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimNotifyState.__PropertyOffset_NeedSimulateEnd) = (value ? 1 : 0);
			}
		}

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x06001848 RID: 6216 RVA: 0x00025130 File Offset: 0x00023330
		// (set) Token: 0x06001849 RID: 6217 RVA: 0x00025140 File Offset: 0x00023340
		public unsafe bool bRestartWithReplay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimNotifyState.__PropertyOffset_bRestartWithReplay) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimNotifyState.__PropertyOffset_bRestartWithReplay) = (value ? 1 : 0);
			}
		}

		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x0600184A RID: 6218 RVA: 0x00025151 File Offset: 0x00023351
		// (set) Token: 0x0600184B RID: 6219 RVA: 0x00025161 File Offset: 0x00023361
		public unsafe float CurrentTimeLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimNotifyState.__PropertyOffset_CurrentTimeLength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimNotifyState.__PropertyOffset_CurrentTimeLength) = value;
			}
		}

		// Token: 0x0600184C RID: 6220 RVA: 0x00025172 File Offset: 0x00023372
		[NullableContext(2)]
		public virtual bool Received_NotifyTick(USkeletalMeshComponent MeshComp, UAnimSequenceBase Animation, float FrameDeltaTime)
		{
			return UAnimNotifyState.__Received_NotifyTick_Internal(base.NativePtr, (MeshComp != null) ? MeshComp.NativePtr : IntPtr.Zero, (Animation != null) ? Animation.NativePtr : IntPtr.Zero, FrameDeltaTime);
		}

		// Token: 0x0600184D RID: 6221 RVA: 0x000251A0 File Offset: 0x000233A0
		[NullableContext(2)]
		public virtual bool Received_NotifyEnd(USkeletalMeshComponent MeshComp, UAnimSequenceBase Animation)
		{
			return UAnimNotifyState.__Received_NotifyEnd_Internal(base.NativePtr, (MeshComp != null) ? MeshComp.NativePtr : IntPtr.Zero, (Animation != null) ? Animation.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600184E RID: 6222 RVA: 0x000251CD File Offset: 0x000233CD
		[NullableContext(2)]
		public virtual bool Received_NotifyBegin(USkeletalMeshComponent MeshComp, UAnimSequenceBase Animation, float TotalDuration)
		{
			return UAnimNotifyState.__Received_NotifyBegin_Internal(base.NativePtr, (MeshComp != null) ? MeshComp.NativePtr : IntPtr.Zero, (Animation != null) ? Animation.NativePtr : IntPtr.Zero, TotalDuration);
		}

		// Token: 0x0600184F RID: 6223 RVA: 0x000251FB File Offset: 0x000233FB
		[NullableContext(1)]
		public virtual string GetNotifyName()
		{
			return FString.ToStringAndDeleteNativePtr(UAnimNotifyState.__GetNotifyName_Internal(base.NativePtr));
		}

		// Token: 0x06001850 RID: 6224 RVA: 0x0002520D File Offset: 0x0002340D
		[NullableContext(1)]
		protected virtual string GetNotifyName_Implementation()
		{
			return FString.ToStringAndDeleteNativePtr(UAnimNotifyState.__GetNotifyName_Implementation_Internal(base.NativePtr));
		}

		// Token: 0x06001851 RID: 6225 RVA: 0x0002521F File Offset: 0x0002341F
		public float GetCurrentTriggerOffsetInThisNotifyTick()
		{
			return UAnimNotifyState.__GetCurrentTriggerOffsetInThisNotifyTick_Internal(base.NativePtr);
		}

		// Token: 0x06001852 RID: 6226 RVA: 0x0002522C File Offset: 0x0002342C
		public float GetCurrentTimeLength()
		{
			return UAnimNotifyState.__GetCurrentTimeLength_Internal(base.NativePtr);
		}

		// Token: 0x06001853 RID: 6227
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Received_NotifyTick_Internal(IntPtr @this, IntPtr MeshComp, IntPtr Animation, float FrameDeltaTime);

		// Token: 0x06001854 RID: 6228
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Received_NotifyEnd_Internal(IntPtr @this, IntPtr MeshComp, IntPtr Animation);

		// Token: 0x06001855 RID: 6229
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Received_NotifyBegin_Internal(IntPtr @this, IntPtr MeshComp, IntPtr Animation, float TotalDuration);

		// Token: 0x06001856 RID: 6230
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetNotifyName_Internal(IntPtr @this);

		// Token: 0x06001857 RID: 6231
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetNotifyName_Implementation_Internal(IntPtr @this);

		// Token: 0x06001858 RID: 6232
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetCurrentTriggerOffsetInThisNotifyTick_Internal(IntPtr @this);

		// Token: 0x06001859 RID: 6233
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetCurrentTimeLength_Internal(IntPtr @this);

		// Token: 0x0600185A RID: 6234 RVA: 0x00025239 File Offset: 0x00023439
		static UAnimNotifyState()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.AnimNotifyState");
		}

		// Token: 0x0600185B RID: 6235 RVA: 0x00025248 File Offset: 0x00023448
		protected UAnimNotifyState() : this(BuiltinUtils.AllocNativeUObject(UAnimNotifyState.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600185C RID: 6236 RVA: 0x00025270 File Offset: 0x00023470
		protected UAnimNotifyState(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040007AE RID: 1966
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.AnimNotifyState";

		// Token: 0x040007AF RID: 1967
		private static IntPtr _ClassPtr;

		// Token: 0x040007B0 RID: 1968
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040007B1 RID: 1969
		internal static int __PropertyOffset_bOnlyTriggerInMainAnim;

		// Token: 0x040007B2 RID: 1970
		internal static int __PropertyOffset_NeedSimulateBegin;

		// Token: 0x040007B3 RID: 1971
		internal static int __PropertyOffset_NeedSimulateTick;

		// Token: 0x040007B4 RID: 1972
		internal static int __PropertyOffset_NeedSimulateEnd;

		// Token: 0x040007B5 RID: 1973
		internal static int __PropertyOffset_bRestartWithReplay;

		// Token: 0x040007B6 RID: 1974
		internal static int __PropertyOffset_CurrentTimeLength;

		// Token: 0x0200096A RID: 2410
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __Received_NotifyTick_FunctionParams
		{
			// Token: 0x04005898 RID: 22680
			[FieldOffset(0)]
			public IntPtr MeshComp;

			// Token: 0x04005899 RID: 22681
			[FieldOffset(8)]
			public IntPtr Animation;

			// Token: 0x0400589A RID: 22682
			[FieldOffset(16)]
			public float FrameDeltaTime;

			// Token: 0x0400589B RID: 22683
			[FieldOffset(20)]
			public bool __Result;
		}

		// Token: 0x0200096B RID: 2411
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __Received_NotifyEnd_FunctionParams
		{
			// Token: 0x0400589C RID: 22684
			[FieldOffset(0)]
			public IntPtr MeshComp;

			// Token: 0x0400589D RID: 22685
			[FieldOffset(8)]
			public IntPtr Animation;

			// Token: 0x0400589E RID: 22686
			[FieldOffset(16)]
			public bool __Result;
		}

		// Token: 0x0200096C RID: 2412
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __Received_NotifyBegin_FunctionParams
		{
			// Token: 0x0400589F RID: 22687
			[FieldOffset(0)]
			public IntPtr MeshComp;

			// Token: 0x040058A0 RID: 22688
			[FieldOffset(8)]
			public IntPtr Animation;

			// Token: 0x040058A1 RID: 22689
			[FieldOffset(16)]
			public float TotalDuration;

			// Token: 0x040058A2 RID: 22690
			[FieldOffset(20)]
			public bool __Result;
		}

		// Token: 0x0200096D RID: 2413
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetNotifyName_FunctionParams
		{
			// Token: 0x040058A3 RID: 22691
			[FieldOffset(0)]
			public FString __Result;
		}
	}
}
