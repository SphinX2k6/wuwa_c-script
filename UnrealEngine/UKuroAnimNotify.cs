using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001AA6 RID: 6822
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroAnimNotify")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UKuroAnimNotify : UAnimNotify, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601940C RID: 103436 RVA: 0x00255972 File Offset: 0x00253B72
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroAnimNotify._ClassPtr;
		}

		// Token: 0x0601940D RID: 103437 RVA: 0x00255980 File Offset: 0x00253B80
		public UKuroAnimNotify() : this(BuiltinUtils.AllocNativeUObject(UKuroAnimNotify.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601940E RID: 103438 RVA: 0x002559A8 File Offset: 0x00253BA8
		[NullableContext(1)]
		public UKuroAnimNotify(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroAnimNotify.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170064B1 RID: 25777
		// (get) Token: 0x0601940F RID: 103439 RVA: 0x002559DB File Offset: 0x00253BDB
		// (set) Token: 0x06019410 RID: 103440 RVA: 0x002559EB File Offset: 0x00253BEB
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

		// Token: 0x06019411 RID: 103441 RVA: 0x002559FC File Offset: 0x00253BFC
		public virtual bool K2_ValidateAssets()
		{
			return UKuroAnimNotify.__K2_ValidateAssets_Internal(base.NativePtr);
		}

		// Token: 0x06019412 RID: 103442 RVA: 0x00255A09 File Offset: 0x00253C09
		public virtual bool K2_PostChangeProperty(FName PropertyName)
		{
			return UKuroAnimNotify.__K2_PostChangeProperty_Internal(base.NativePtr, PropertyName);
		}

		// Token: 0x06019413 RID: 103443 RVA: 0x00255A17 File Offset: 0x00253C17
		[NullableContext(2)]
		public virtual bool K2_NotifyConditionCheck(USkeletalMeshComponent MeshComp, UAnimSequenceBase Animation)
		{
			return UKuroAnimNotify.__K2_NotifyConditionCheck_Internal(base.NativePtr, (MeshComp != null) ? MeshComp.NativePtr : IntPtr.Zero, (Animation != null) ? Animation.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06019414 RID: 103444 RVA: 0x00255A44 File Offset: 0x00253C44
		[NullableContext(2)]
		protected virtual bool K2_NotifyConditionCheck_Implementation(USkeletalMeshComponent MeshComp, UAnimSequenceBase Animation)
		{
			return UKuroAnimNotify.__K2_NotifyConditionCheck_Implementation_Internal(base.NativePtr, (MeshComp != null) ? MeshComp.NativePtr : IntPtr.Zero, (Animation != null) ? Animation.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06019415 RID: 103445 RVA: 0x00255A71 File Offset: 0x00253C71
		[NullableContext(2)]
		public virtual bool K2_Notify(USkeletalMeshComponent MeshComp, UAnimSequenceBase Animation)
		{
			return UKuroAnimNotify.__K2_Notify_Internal(base.NativePtr, (MeshComp != null) ? MeshComp.NativePtr : IntPtr.Zero, (Animation != null) ? Animation.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06019416 RID: 103446
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __K2_ValidateAssets_Internal(IntPtr @this);

		// Token: 0x06019417 RID: 103447
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __K2_PostChangeProperty_Internal(IntPtr @this, FName PropertyName);

		// Token: 0x06019418 RID: 103448
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __K2_NotifyConditionCheck_Internal(IntPtr @this, IntPtr MeshComp, IntPtr Animation);

		// Token: 0x06019419 RID: 103449
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __K2_NotifyConditionCheck_Implementation_Internal(IntPtr @this, IntPtr MeshComp, IntPtr Animation);

		// Token: 0x0601941A RID: 103450
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __K2_Notify_Internal(IntPtr @this, IntPtr MeshComp, IntPtr Animation);

		// Token: 0x0601941B RID: 103451 RVA: 0x00255A9E File Offset: 0x00253C9E
		static UKuroAnimNotify()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroAnimNotify");
		}

		// Token: 0x0601941C RID: 103452 RVA: 0x00255AAC File Offset: 0x00253CAC
		protected UKuroAnimNotify(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400DC68 RID: 56424
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroAnimNotify";

		// Token: 0x0400DC69 RID: 56425
		private static IntPtr _ClassPtr;

		// Token: 0x0400DC6A RID: 56426
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400DC6B RID: 56427
		internal static int __PropertyOffset_exportIndex;

		// Token: 0x02003124 RID: 12580
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __K2_ValidateAssets_FunctionParams
		{
			// Token: 0x04016F1E RID: 93982
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02003125 RID: 12581
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __K2_PostChangeProperty_FunctionParams
		{
			// Token: 0x04016F1F RID: 93983
			[FieldOffset(0)]
			public FName PropertyName;

			// Token: 0x04016F20 RID: 93984
			[FieldOffset(12)]
			public bool __Result;
		}

		// Token: 0x02003126 RID: 12582
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __K2_NotifyConditionCheck_FunctionParams
		{
			// Token: 0x04016F21 RID: 93985
			[FieldOffset(0)]
			public IntPtr MeshComp;

			// Token: 0x04016F22 RID: 93986
			[FieldOffset(8)]
			public IntPtr Animation;

			// Token: 0x04016F23 RID: 93987
			[FieldOffset(16)]
			public bool __Result;
		}

		// Token: 0x02003127 RID: 12583
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __K2_Notify_FunctionParams
		{
			// Token: 0x04016F24 RID: 93988
			[FieldOffset(0)]
			public IntPtr MeshComp;

			// Token: 0x04016F25 RID: 93989
			[FieldOffset(8)]
			public IntPtr Animation;

			// Token: 0x04016F26 RID: 93990
			[FieldOffset(16)]
			public bool __Result;
		}
	}
}
