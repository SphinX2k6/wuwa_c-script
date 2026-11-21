using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020004B0 RID: 1200
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroAnimNotify")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UKuroAnimNotify : UAnimNotify, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006EEA RID: 28394 RVA: 0x000A42DA File Offset: 0x000A24DA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroAnimNotify._ClassPtr;
		}

		// Token: 0x06006EEB RID: 28395 RVA: 0x000A42E8 File Offset: 0x000A24E8
		public UKuroAnimNotify() : this(BuiltinUtils.AllocNativeUObject(UKuroAnimNotify.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006EEC RID: 28396 RVA: 0x000A4310 File Offset: 0x000A2510
		[NullableContext(1)]
		public UKuroAnimNotify(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroAnimNotify.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170015AE RID: 5550
		// (get) Token: 0x06006EED RID: 28397 RVA: 0x000A4343 File Offset: 0x000A2543
		// (set) Token: 0x06006EEE RID: 28398 RVA: 0x000A4353 File Offset: 0x000A2553
		public unsafe int exportIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimNotify.__PropertyOffset_exportIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimNotify.__PropertyOffset_exportIndex) = value;
			}
		}

		// Token: 0x06006EEF RID: 28399 RVA: 0x000A4364 File Offset: 0x000A2564
		public virtual bool K2_ValidateAssets()
		{
			return UKuroAnimNotify.__K2_ValidateAssets_Internal(base.NativePtr);
		}

		// Token: 0x06006EF0 RID: 28400 RVA: 0x000A4371 File Offset: 0x000A2571
		public virtual bool K2_PostChangeProperty(FName PropertyName)
		{
			return UKuroAnimNotify.__K2_PostChangeProperty_Internal(base.NativePtr, PropertyName);
		}

		// Token: 0x06006EF1 RID: 28401 RVA: 0x000A437F File Offset: 0x000A257F
		[NullableContext(2)]
		public virtual bool K2_NotifyConditionCheck(USkeletalMeshComponent MeshComp, UAnimSequenceBase Animation)
		{
			return UKuroAnimNotify.__K2_NotifyConditionCheck_Internal(base.NativePtr, (MeshComp != null) ? MeshComp.NativePtr : IntPtr.Zero, (Animation != null) ? Animation.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06006EF2 RID: 28402 RVA: 0x000A43AC File Offset: 0x000A25AC
		[NullableContext(2)]
		protected virtual bool K2_NotifyConditionCheck_Implementation(USkeletalMeshComponent MeshComp, UAnimSequenceBase Animation)
		{
			return UKuroAnimNotify.__K2_NotifyConditionCheck_Implementation_Internal(base.NativePtr, (MeshComp != null) ? MeshComp.NativePtr : IntPtr.Zero, (Animation != null) ? Animation.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06006EF3 RID: 28403 RVA: 0x000A43D9 File Offset: 0x000A25D9
		[NullableContext(2)]
		public virtual bool K2_Notify(USkeletalMeshComponent MeshComp, UAnimSequenceBase Animation)
		{
			return UKuroAnimNotify.__K2_Notify_Internal(base.NativePtr, (MeshComp != null) ? MeshComp.NativePtr : IntPtr.Zero, (Animation != null) ? Animation.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06006EF4 RID: 28404
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __K2_ValidateAssets_Internal(IntPtr @this);

		// Token: 0x06006EF5 RID: 28405
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __K2_PostChangeProperty_Internal(IntPtr @this, FName PropertyName);

		// Token: 0x06006EF6 RID: 28406
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __K2_NotifyConditionCheck_Internal(IntPtr @this, IntPtr MeshComp, IntPtr Animation);

		// Token: 0x06006EF7 RID: 28407
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __K2_NotifyConditionCheck_Implementation_Internal(IntPtr @this, IntPtr MeshComp, IntPtr Animation);

		// Token: 0x06006EF8 RID: 28408
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __K2_Notify_Internal(IntPtr @this, IntPtr MeshComp, IntPtr Animation);

		// Token: 0x06006EF9 RID: 28409 RVA: 0x000A4406 File Offset: 0x000A2606
		static UKuroAnimNotify()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroAnimNotify");
		}

		// Token: 0x06006EFA RID: 28410 RVA: 0x000A4414 File Offset: 0x000A2614
		protected UKuroAnimNotify(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003001 RID: 12289
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroAnimNotify";

		// Token: 0x04003002 RID: 12290
		private static IntPtr _ClassPtr;

		// Token: 0x04003003 RID: 12291
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003004 RID: 12292
		internal static int __PropertyOffset_exportIndex;

		// Token: 0x02000BF9 RID: 3065
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __K2_ValidateAssets_FunctionParams
		{
			// Token: 0x04005E18 RID: 24088
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02000BFA RID: 3066
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __K2_PostChangeProperty_FunctionParams
		{
			// Token: 0x04005E19 RID: 24089
			[FieldOffset(0)]
			public FName PropertyName;

			// Token: 0x04005E1A RID: 24090
			[FieldOffset(12)]
			public bool __Result;
		}

		// Token: 0x02000BFB RID: 3067
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __K2_NotifyConditionCheck_FunctionParams
		{
			// Token: 0x04005E1B RID: 24091
			[FieldOffset(0)]
			public IntPtr MeshComp;

			// Token: 0x04005E1C RID: 24092
			[FieldOffset(8)]
			public IntPtr Animation;

			// Token: 0x04005E1D RID: 24093
			[FieldOffset(16)]
			public bool __Result;
		}

		// Token: 0x02000BFC RID: 3068
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __K2_Notify_FunctionParams
		{
			// Token: 0x04005E1E RID: 24094
			[FieldOffset(0)]
			public IntPtr MeshComp;

			// Token: 0x04005E1F RID: 24095
			[FieldOffset(8)]
			public IntPtr Animation;

			// Token: 0x04005E20 RID: 24096
			[FieldOffset(16)]
			public bool __Result;
		}
	}
}
