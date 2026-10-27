using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001AA7 RID: 6823
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroAnimNotifyState")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UKuroAnimNotifyState : UAnimNotifyState, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601941D RID: 103453 RVA: 0x00255AB5 File Offset: 0x00253CB5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroAnimNotifyState._ClassPtr;
		}

		// Token: 0x0601941E RID: 103454 RVA: 0x00255AC4 File Offset: 0x00253CC4
		public UKuroAnimNotifyState() : this(BuiltinUtils.AllocNativeUObject(UKuroAnimNotifyState.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601941F RID: 103455 RVA: 0x00255AEC File Offset: 0x00253CEC
		[NullableContext(1)]
		public UKuroAnimNotifyState(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroAnimNotifyState.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170064B2 RID: 25778
		// (get) Token: 0x06019420 RID: 103456 RVA: 0x00255B1F File Offset: 0x00253D1F
		// (set) Token: 0x06019421 RID: 103457 RVA: 0x00255B2F File Offset: 0x00253D2F
		public unsafe int exportIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimNotifyState.__PropertyOffset_exportIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimNotifyState.__PropertyOffset_exportIndex) = value;
			}
		}

		// Token: 0x06019422 RID: 103458 RVA: 0x00255B40 File Offset: 0x00253D40
		public virtual bool K2_ValidateAssets()
		{
			return UKuroAnimNotifyState.__K2_ValidateAssets_Internal(base.NativePtr);
		}

		// Token: 0x06019423 RID: 103459 RVA: 0x00255B4D File Offset: 0x00253D4D
		public virtual bool K2_PostChangeProperty(FName PropertyName)
		{
			return UKuroAnimNotifyState.__K2_PostChangeProperty_Internal(base.NativePtr, PropertyName);
		}

		// Token: 0x06019424 RID: 103460 RVA: 0x00255B5B File Offset: 0x00253D5B
		[NullableContext(2)]
		public virtual bool K2_NotifyTickConditionCheck(USkeletalMeshComponent MeshComp, UAnimSequenceBase Animation, float FrameDeltaTime)
		{
			return UKuroAnimNotifyState.__K2_NotifyTickConditionCheck_Internal(base.NativePtr, (MeshComp != null) ? MeshComp.NativePtr : IntPtr.Zero, (Animation != null) ? Animation.NativePtr : IntPtr.Zero, FrameDeltaTime);
		}

		// Token: 0x06019425 RID: 103461 RVA: 0x00255B89 File Offset: 0x00253D89
		[NullableContext(2)]
		protected virtual bool K2_NotifyTickConditionCheck_Implementation(USkeletalMeshComponent MeshComp, UAnimSequenceBase Animation, float FrameDeltaTime)
		{
			return UKuroAnimNotifyState.__K2_NotifyTickConditionCheck_Implementation_Internal(base.NativePtr, (MeshComp != null) ? MeshComp.NativePtr : IntPtr.Zero, (Animation != null) ? Animation.NativePtr : IntPtr.Zero, FrameDeltaTime);
		}

		// Token: 0x06019426 RID: 103462 RVA: 0x00255BB7 File Offset: 0x00253DB7
		[NullableContext(2)]
		public virtual bool K2_NotifyTick(USkeletalMeshComponent MeshComp, UAnimSequenceBase Animation, float FrameDeltaTime)
		{
			return UKuroAnimNotifyState.__K2_NotifyTick_Internal(base.NativePtr, (MeshComp != null) ? MeshComp.NativePtr : IntPtr.Zero, (Animation != null) ? Animation.NativePtr : IntPtr.Zero, FrameDeltaTime);
		}

		// Token: 0x06019427 RID: 103463 RVA: 0x00255BE5 File Offset: 0x00253DE5
		[NullableContext(2)]
		public virtual bool K2_NotifyEndConditionCheck(USkeletalMeshComponent MeshComp, UAnimSequenceBase Animation)
		{
			return UKuroAnimNotifyState.__K2_NotifyEndConditionCheck_Internal(base.NativePtr, (MeshComp != null) ? MeshComp.NativePtr : IntPtr.Zero, (Animation != null) ? Animation.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06019428 RID: 103464 RVA: 0x00255C12 File Offset: 0x00253E12
		[NullableContext(2)]
		protected virtual bool K2_NotifyEndConditionCheck_Implementation(USkeletalMeshComponent MeshComp, UAnimSequenceBase Animation)
		{
			return UKuroAnimNotifyState.__K2_NotifyEndConditionCheck_Implementation_Internal(base.NativePtr, (MeshComp != null) ? MeshComp.NativePtr : IntPtr.Zero, (Animation != null) ? Animation.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06019429 RID: 103465 RVA: 0x00255C3F File Offset: 0x00253E3F
		[NullableContext(2)]
		public virtual bool K2_NotifyEnd(USkeletalMeshComponent MeshComp, UAnimSequenceBase Animation)
		{
			return UKuroAnimNotifyState.__K2_NotifyEnd_Internal(base.NativePtr, (MeshComp != null) ? MeshComp.NativePtr : IntPtr.Zero, (Animation != null) ? Animation.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601942A RID: 103466 RVA: 0x00255C6C File Offset: 0x00253E6C
		[NullableContext(2)]
		public virtual bool K2_NotifyBeginConditionCheck(USkeletalMeshComponent MeshComp, UAnimSequenceBase Animation, float TotalDuration)
		{
			return UKuroAnimNotifyState.__K2_NotifyBeginConditionCheck_Internal(base.NativePtr, (MeshComp != null) ? MeshComp.NativePtr : IntPtr.Zero, (Animation != null) ? Animation.NativePtr : IntPtr.Zero, TotalDuration);
		}

		// Token: 0x0601942B RID: 103467 RVA: 0x00255C9A File Offset: 0x00253E9A
		[NullableContext(2)]
		protected virtual bool K2_NotifyBeginConditionCheck_Implementation(USkeletalMeshComponent MeshComp, UAnimSequenceBase Animation, float TotalDuration)
		{
			return UKuroAnimNotifyState.__K2_NotifyBeginConditionCheck_Implementation_Internal(base.NativePtr, (MeshComp != null) ? MeshComp.NativePtr : IntPtr.Zero, (Animation != null) ? Animation.NativePtr : IntPtr.Zero, TotalDuration);
		}

		// Token: 0x0601942C RID: 103468 RVA: 0x00255CC8 File Offset: 0x00253EC8
		[NullableContext(2)]
		public virtual bool K2_NotifyBegin(USkeletalMeshComponent MeshComp, UAnimSequenceBase Animation, float TotalDuration)
		{
			return UKuroAnimNotifyState.__K2_NotifyBegin_Internal(base.NativePtr, (MeshComp != null) ? MeshComp.NativePtr : IntPtr.Zero, (Animation != null) ? Animation.NativePtr : IntPtr.Zero, TotalDuration);
		}

		// Token: 0x0601942D RID: 103469
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __K2_ValidateAssets_Internal(IntPtr @this);

		// Token: 0x0601942E RID: 103470
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __K2_PostChangeProperty_Internal(IntPtr @this, FName PropertyName);

		// Token: 0x0601942F RID: 103471
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __K2_NotifyTickConditionCheck_Internal(IntPtr @this, IntPtr MeshComp, IntPtr Animation, float FrameDeltaTime);

		// Token: 0x06019430 RID: 103472
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __K2_NotifyTickConditionCheck_Implementation_Internal(IntPtr @this, IntPtr MeshComp, IntPtr Animation, float FrameDeltaTime);

		// Token: 0x06019431 RID: 103473
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __K2_NotifyTick_Internal(IntPtr @this, IntPtr MeshComp, IntPtr Animation, float FrameDeltaTime);

		// Token: 0x06019432 RID: 103474
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __K2_NotifyEndConditionCheck_Internal(IntPtr @this, IntPtr MeshComp, IntPtr Animation);

		// Token: 0x06019433 RID: 103475
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __K2_NotifyEndConditionCheck_Implementation_Internal(IntPtr @this, IntPtr MeshComp, IntPtr Animation);

		// Token: 0x06019434 RID: 103476
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __K2_NotifyEnd_Internal(IntPtr @this, IntPtr MeshComp, IntPtr Animation);

		// Token: 0x06019435 RID: 103477
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __K2_NotifyBeginConditionCheck_Internal(IntPtr @this, IntPtr MeshComp, IntPtr Animation, float TotalDuration);

		// Token: 0x06019436 RID: 103478
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __K2_NotifyBeginConditionCheck_Implementation_Internal(IntPtr @this, IntPtr MeshComp, IntPtr Animation, float TotalDuration);

		// Token: 0x06019437 RID: 103479
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __K2_NotifyBegin_Internal(IntPtr @this, IntPtr MeshComp, IntPtr Animation, float TotalDuration);

		// Token: 0x06019438 RID: 103480 RVA: 0x00255CF6 File Offset: 0x00253EF6
		static UKuroAnimNotifyState()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroAnimNotifyState");
		}

		// Token: 0x06019439 RID: 103481 RVA: 0x00255D04 File Offset: 0x00253F04
		protected UKuroAnimNotifyState(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400DC6C RID: 56428
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroAnimNotifyState";

		// Token: 0x0400DC6D RID: 56429
		private static IntPtr _ClassPtr;

		// Token: 0x0400DC6E RID: 56430
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400DC6F RID: 56431
		internal static int __PropertyOffset_exportIndex;

		// Token: 0x02003128 RID: 12584
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __K2_ValidateAssets_FunctionParams
		{
			// Token: 0x04016F27 RID: 93991
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02003129 RID: 12585
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __K2_PostChangeProperty_FunctionParams
		{
			// Token: 0x04016F28 RID: 93992
			[FieldOffset(0)]
			public FName PropertyName;

			// Token: 0x04016F29 RID: 93993
			[FieldOffset(12)]
			public bool __Result;
		}

		// Token: 0x0200312A RID: 12586
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __K2_NotifyTickConditionCheck_FunctionParams
		{
			// Token: 0x04016F2A RID: 93994
			[FieldOffset(0)]
			public IntPtr MeshComp;

			// Token: 0x04016F2B RID: 93995
			[FieldOffset(8)]
			public IntPtr Animation;

			// Token: 0x04016F2C RID: 93996
			[FieldOffset(16)]
			public float FrameDeltaTime;

			// Token: 0x04016F2D RID: 93997
			[FieldOffset(20)]
			public bool __Result;
		}

		// Token: 0x0200312B RID: 12587
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __K2_NotifyTick_FunctionParams
		{
			// Token: 0x04016F2E RID: 93998
			[FieldOffset(0)]
			public IntPtr MeshComp;

			// Token: 0x04016F2F RID: 93999
			[FieldOffset(8)]
			public IntPtr Animation;

			// Token: 0x04016F30 RID: 94000
			[FieldOffset(16)]
			public float FrameDeltaTime;

			// Token: 0x04016F31 RID: 94001
			[FieldOffset(20)]
			public bool __Result;
		}

		// Token: 0x0200312C RID: 12588
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __K2_NotifyEndConditionCheck_FunctionParams
		{
			// Token: 0x04016F32 RID: 94002
			[FieldOffset(0)]
			public IntPtr MeshComp;

			// Token: 0x04016F33 RID: 94003
			[FieldOffset(8)]
			public IntPtr Animation;

			// Token: 0x04016F34 RID: 94004
			[FieldOffset(16)]
			public bool __Result;
		}

		// Token: 0x0200312D RID: 12589
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __K2_NotifyEnd_FunctionParams
		{
			// Token: 0x04016F35 RID: 94005
			[FieldOffset(0)]
			public IntPtr MeshComp;

			// Token: 0x04016F36 RID: 94006
			[FieldOffset(8)]
			public IntPtr Animation;

			// Token: 0x04016F37 RID: 94007
			[FieldOffset(16)]
			public bool __Result;
		}

		// Token: 0x0200312E RID: 12590
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __K2_NotifyBeginConditionCheck_FunctionParams
		{
			// Token: 0x04016F38 RID: 94008
			[FieldOffset(0)]
			public IntPtr MeshComp;

			// Token: 0x04016F39 RID: 94009
			[FieldOffset(8)]
			public IntPtr Animation;

			// Token: 0x04016F3A RID: 94010
			[FieldOffset(16)]
			public float TotalDuration;

			// Token: 0x04016F3B RID: 94011
			[FieldOffset(20)]
			public bool __Result;
		}

		// Token: 0x0200312F RID: 12591
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __K2_NotifyBegin_FunctionParams
		{
			// Token: 0x04016F3C RID: 94012
			[FieldOffset(0)]
			public IntPtr MeshComp;

			// Token: 0x04016F3D RID: 94013
			[FieldOffset(8)]
			public IntPtr Animation;

			// Token: 0x04016F3E RID: 94014
			[FieldOffset(16)]
			public float TotalDuration;

			// Token: 0x04016F3F RID: 94015
			[FieldOffset(20)]
			public bool __Result;
		}
	}
}
