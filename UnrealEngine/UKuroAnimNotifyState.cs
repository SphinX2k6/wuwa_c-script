using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020004B1 RID: 1201
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroAnimNotifyState")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UKuroAnimNotifyState : UAnimNotifyState, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006EFB RID: 28411 RVA: 0x000A441D File Offset: 0x000A261D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroAnimNotifyState._ClassPtr;
		}

		// Token: 0x06006EFC RID: 28412 RVA: 0x000A442C File Offset: 0x000A262C
		public UKuroAnimNotifyState() : this(BuiltinUtils.AllocNativeUObject(UKuroAnimNotifyState.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006EFD RID: 28413 RVA: 0x000A4454 File Offset: 0x000A2654
		[NullableContext(1)]
		public UKuroAnimNotifyState(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroAnimNotifyState.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170015AF RID: 5551
		// (get) Token: 0x06006EFE RID: 28414 RVA: 0x000A4487 File Offset: 0x000A2687
		// (set) Token: 0x06006EFF RID: 28415 RVA: 0x000A4497 File Offset: 0x000A2697
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

		// Token: 0x06006F00 RID: 28416 RVA: 0x000A44A8 File Offset: 0x000A26A8
		public virtual bool K2_ValidateAssets()
		{
			return UKuroAnimNotifyState.__K2_ValidateAssets_Internal(base.NativePtr);
		}

		// Token: 0x06006F01 RID: 28417 RVA: 0x000A44B5 File Offset: 0x000A26B5
		public virtual bool K2_PostChangeProperty(FName PropertyName)
		{
			return UKuroAnimNotifyState.__K2_PostChangeProperty_Internal(base.NativePtr, PropertyName);
		}

		// Token: 0x06006F02 RID: 28418 RVA: 0x000A44C3 File Offset: 0x000A26C3
		[NullableContext(2)]
		public virtual bool K2_NotifyTickConditionCheck(USkeletalMeshComponent MeshComp, UAnimSequenceBase Animation, float FrameDeltaTime)
		{
			return UKuroAnimNotifyState.__K2_NotifyTickConditionCheck_Internal(base.NativePtr, (MeshComp != null) ? MeshComp.NativePtr : IntPtr.Zero, (Animation != null) ? Animation.NativePtr : IntPtr.Zero, FrameDeltaTime);
		}

		// Token: 0x06006F03 RID: 28419 RVA: 0x000A44F1 File Offset: 0x000A26F1
		[NullableContext(2)]
		protected virtual bool K2_NotifyTickConditionCheck_Implementation(USkeletalMeshComponent MeshComp, UAnimSequenceBase Animation, float FrameDeltaTime)
		{
			return UKuroAnimNotifyState.__K2_NotifyTickConditionCheck_Implementation_Internal(base.NativePtr, (MeshComp != null) ? MeshComp.NativePtr : IntPtr.Zero, (Animation != null) ? Animation.NativePtr : IntPtr.Zero, FrameDeltaTime);
		}

		// Token: 0x06006F04 RID: 28420 RVA: 0x000A451F File Offset: 0x000A271F
		[NullableContext(2)]
		public virtual bool K2_NotifyTick(USkeletalMeshComponent MeshComp, UAnimSequenceBase Animation, float FrameDeltaTime)
		{
			return UKuroAnimNotifyState.__K2_NotifyTick_Internal(base.NativePtr, (MeshComp != null) ? MeshComp.NativePtr : IntPtr.Zero, (Animation != null) ? Animation.NativePtr : IntPtr.Zero, FrameDeltaTime);
		}

		// Token: 0x06006F05 RID: 28421 RVA: 0x000A454D File Offset: 0x000A274D
		[NullableContext(2)]
		public virtual bool K2_NotifyEndConditionCheck(USkeletalMeshComponent MeshComp, UAnimSequenceBase Animation)
		{
			return UKuroAnimNotifyState.__K2_NotifyEndConditionCheck_Internal(base.NativePtr, (MeshComp != null) ? MeshComp.NativePtr : IntPtr.Zero, (Animation != null) ? Animation.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06006F06 RID: 28422 RVA: 0x000A457A File Offset: 0x000A277A
		[NullableContext(2)]
		protected virtual bool K2_NotifyEndConditionCheck_Implementation(USkeletalMeshComponent MeshComp, UAnimSequenceBase Animation)
		{
			return UKuroAnimNotifyState.__K2_NotifyEndConditionCheck_Implementation_Internal(base.NativePtr, (MeshComp != null) ? MeshComp.NativePtr : IntPtr.Zero, (Animation != null) ? Animation.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06006F07 RID: 28423 RVA: 0x000A45A7 File Offset: 0x000A27A7
		[NullableContext(2)]
		public virtual bool K2_NotifyEnd(USkeletalMeshComponent MeshComp, UAnimSequenceBase Animation)
		{
			return UKuroAnimNotifyState.__K2_NotifyEnd_Internal(base.NativePtr, (MeshComp != null) ? MeshComp.NativePtr : IntPtr.Zero, (Animation != null) ? Animation.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06006F08 RID: 28424 RVA: 0x000A45D4 File Offset: 0x000A27D4
		[NullableContext(2)]
		public virtual bool K2_NotifyBeginConditionCheck(USkeletalMeshComponent MeshComp, UAnimSequenceBase Animation, float TotalDuration)
		{
			return UKuroAnimNotifyState.__K2_NotifyBeginConditionCheck_Internal(base.NativePtr, (MeshComp != null) ? MeshComp.NativePtr : IntPtr.Zero, (Animation != null) ? Animation.NativePtr : IntPtr.Zero, TotalDuration);
		}

		// Token: 0x06006F09 RID: 28425 RVA: 0x000A4602 File Offset: 0x000A2802
		[NullableContext(2)]
		protected virtual bool K2_NotifyBeginConditionCheck_Implementation(USkeletalMeshComponent MeshComp, UAnimSequenceBase Animation, float TotalDuration)
		{
			return UKuroAnimNotifyState.__K2_NotifyBeginConditionCheck_Implementation_Internal(base.NativePtr, (MeshComp != null) ? MeshComp.NativePtr : IntPtr.Zero, (Animation != null) ? Animation.NativePtr : IntPtr.Zero, TotalDuration);
		}

		// Token: 0x06006F0A RID: 28426 RVA: 0x000A4630 File Offset: 0x000A2830
		[NullableContext(2)]
		public virtual bool K2_NotifyBegin(USkeletalMeshComponent MeshComp, UAnimSequenceBase Animation, float TotalDuration)
		{
			return UKuroAnimNotifyState.__K2_NotifyBegin_Internal(base.NativePtr, (MeshComp != null) ? MeshComp.NativePtr : IntPtr.Zero, (Animation != null) ? Animation.NativePtr : IntPtr.Zero, TotalDuration);
		}

		// Token: 0x06006F0B RID: 28427
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __K2_ValidateAssets_Internal(IntPtr @this);

		// Token: 0x06006F0C RID: 28428
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __K2_PostChangeProperty_Internal(IntPtr @this, FName PropertyName);

		// Token: 0x06006F0D RID: 28429
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __K2_NotifyTickConditionCheck_Internal(IntPtr @this, IntPtr MeshComp, IntPtr Animation, float FrameDeltaTime);

		// Token: 0x06006F0E RID: 28430
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __K2_NotifyTickConditionCheck_Implementation_Internal(IntPtr @this, IntPtr MeshComp, IntPtr Animation, float FrameDeltaTime);

		// Token: 0x06006F0F RID: 28431
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __K2_NotifyTick_Internal(IntPtr @this, IntPtr MeshComp, IntPtr Animation, float FrameDeltaTime);

		// Token: 0x06006F10 RID: 28432
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __K2_NotifyEndConditionCheck_Internal(IntPtr @this, IntPtr MeshComp, IntPtr Animation);

		// Token: 0x06006F11 RID: 28433
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __K2_NotifyEndConditionCheck_Implementation_Internal(IntPtr @this, IntPtr MeshComp, IntPtr Animation);

		// Token: 0x06006F12 RID: 28434
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __K2_NotifyEnd_Internal(IntPtr @this, IntPtr MeshComp, IntPtr Animation);

		// Token: 0x06006F13 RID: 28435
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __K2_NotifyBeginConditionCheck_Internal(IntPtr @this, IntPtr MeshComp, IntPtr Animation, float TotalDuration);

		// Token: 0x06006F14 RID: 28436
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __K2_NotifyBeginConditionCheck_Implementation_Internal(IntPtr @this, IntPtr MeshComp, IntPtr Animation, float TotalDuration);

		// Token: 0x06006F15 RID: 28437
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __K2_NotifyBegin_Internal(IntPtr @this, IntPtr MeshComp, IntPtr Animation, float TotalDuration);

		// Token: 0x06006F16 RID: 28438 RVA: 0x000A465E File Offset: 0x000A285E
		static UKuroAnimNotifyState()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroAnimNotifyState");
		}

		// Token: 0x06006F17 RID: 28439 RVA: 0x000A466C File Offset: 0x000A286C
		protected UKuroAnimNotifyState(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003005 RID: 12293
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroAnimNotifyState";

		// Token: 0x04003006 RID: 12294
		private static IntPtr _ClassPtr;

		// Token: 0x04003007 RID: 12295
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003008 RID: 12296
		internal static int __PropertyOffset_exportIndex;

		// Token: 0x02000BFD RID: 3069
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __K2_ValidateAssets_FunctionParams
		{
			// Token: 0x04005E21 RID: 24097
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02000BFE RID: 3070
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __K2_PostChangeProperty_FunctionParams
		{
			// Token: 0x04005E22 RID: 24098
			[FieldOffset(0)]
			public FName PropertyName;

			// Token: 0x04005E23 RID: 24099
			[FieldOffset(12)]
			public bool __Result;
		}

		// Token: 0x02000BFF RID: 3071
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __K2_NotifyTickConditionCheck_FunctionParams
		{
			// Token: 0x04005E24 RID: 24100
			[FieldOffset(0)]
			public IntPtr MeshComp;

			// Token: 0x04005E25 RID: 24101
			[FieldOffset(8)]
			public IntPtr Animation;

			// Token: 0x04005E26 RID: 24102
			[FieldOffset(16)]
			public float FrameDeltaTime;

			// Token: 0x04005E27 RID: 24103
			[FieldOffset(20)]
			public bool __Result;
		}

		// Token: 0x02000C00 RID: 3072
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __K2_NotifyTick_FunctionParams
		{
			// Token: 0x04005E28 RID: 24104
			[FieldOffset(0)]
			public IntPtr MeshComp;

			// Token: 0x04005E29 RID: 24105
			[FieldOffset(8)]
			public IntPtr Animation;

			// Token: 0x04005E2A RID: 24106
			[FieldOffset(16)]
			public float FrameDeltaTime;

			// Token: 0x04005E2B RID: 24107
			[FieldOffset(20)]
			public bool __Result;
		}

		// Token: 0x02000C01 RID: 3073
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __K2_NotifyEndConditionCheck_FunctionParams
		{
			// Token: 0x04005E2C RID: 24108
			[FieldOffset(0)]
			public IntPtr MeshComp;

			// Token: 0x04005E2D RID: 24109
			[FieldOffset(8)]
			public IntPtr Animation;

			// Token: 0x04005E2E RID: 24110
			[FieldOffset(16)]
			public bool __Result;
		}

		// Token: 0x02000C02 RID: 3074
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __K2_NotifyEnd_FunctionParams
		{
			// Token: 0x04005E2F RID: 24111
			[FieldOffset(0)]
			public IntPtr MeshComp;

			// Token: 0x04005E30 RID: 24112
			[FieldOffset(8)]
			public IntPtr Animation;

			// Token: 0x04005E31 RID: 24113
			[FieldOffset(16)]
			public bool __Result;
		}

		// Token: 0x02000C03 RID: 3075
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __K2_NotifyBeginConditionCheck_FunctionParams
		{
			// Token: 0x04005E32 RID: 24114
			[FieldOffset(0)]
			public IntPtr MeshComp;

			// Token: 0x04005E33 RID: 24115
			[FieldOffset(8)]
			public IntPtr Animation;

			// Token: 0x04005E34 RID: 24116
			[FieldOffset(16)]
			public float TotalDuration;

			// Token: 0x04005E35 RID: 24117
			[FieldOffset(20)]
			public bool __Result;
		}

		// Token: 0x02000C04 RID: 3076
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __K2_NotifyBegin_FunctionParams
		{
			// Token: 0x04005E36 RID: 24118
			[FieldOffset(0)]
			public IntPtr MeshComp;

			// Token: 0x04005E37 RID: 24119
			[FieldOffset(8)]
			public IntPtr Animation;

			// Token: 0x04005E38 RID: 24120
			[FieldOffset(16)]
			public float TotalDuration;

			// Token: 0x04005E39 RID: 24121
			[FieldOffset(20)]
			public bool __Result;
		}
	}
}
