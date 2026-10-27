using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000844 RID: 2116
	[UnrealObjectPath("/Script/Engine.AnimStreamable")]
	[UnrealStructLayout(648, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 648)]
	public class UAnimStreamable : UAnimSequenceBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060071FA RID: 29178 RVA: 0x000A33A2 File Offset: 0x000A15A2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAnimStreamable._ClassPtr;
		}

		// Token: 0x060071FB RID: 29179 RVA: 0x000A33B0 File Offset: 0x000A15B0
		public UAnimStreamable() : this(BuiltinUtils.AllocNativeUObject(UAnimStreamable.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060071FC RID: 29180 RVA: 0x000A33D8 File Offset: 0x000A15D8
		[NullableContext(1)]
		public UAnimStreamable(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAnimStreamable.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001AD1 RID: 6865
		// (get) Token: 0x060071FD RID: 29181 RVA: 0x000A340B File Offset: 0x000A160B
		// (set) Token: 0x060071FE RID: 29182 RVA: 0x000A341B File Offset: 0x000A161B
		public unsafe int NumFrames
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimStreamable.__PropertyOffset_NumFrames);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimStreamable.__PropertyOffset_NumFrames) = value;
			}
		}

		// Token: 0x17001AD2 RID: 6866
		// (get) Token: 0x060071FF RID: 29183 RVA: 0x000A342C File Offset: 0x000A162C
		// (set) Token: 0x06007200 RID: 29184 RVA: 0x000A343C File Offset: 0x000A163C
		public unsafe EAnimInterpolationType Interpolation
		{
			get
			{
				return (EAnimInterpolationType)(*(base.NativePtr + (IntPtr)UAnimStreamable.__PropertyOffset_Interpolation));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimStreamable.__PropertyOffset_Interpolation) = (byte)value;
			}
		}

		// Token: 0x17001AD3 RID: 6867
		// (get) Token: 0x06007201 RID: 29185 RVA: 0x000A344D File Offset: 0x000A164D
		// (set) Token: 0x06007202 RID: 29186 RVA: 0x000A3461 File Offset: 0x000A1661
		public unsafe FName RetargetSource
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimStreamable.__PropertyOffset_RetargetSource);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimStreamable.__PropertyOffset_RetargetSource) = value;
			}
		}

		// Token: 0x17001AD4 RID: 6868
		// (get) Token: 0x06007203 RID: 29187 RVA: 0x000A3476 File Offset: 0x000A1676
		// (set) Token: 0x06007204 RID: 29188 RVA: 0x000A348A File Offset: 0x000A168A
		[Nullable(2)]
		public unsafe UAnimBoneCompressionSettings BoneCompressionSettings
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAnimBoneCompressionSettings>(base.NativePtr / (IntPtr)sizeof(void*) + UAnimStreamable.__PropertyOffset_BoneCompressionSettings);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UAnimStreamable.__PropertyOffset_BoneCompressionSettings, value);
			}
		}

		// Token: 0x17001AD5 RID: 6869
		// (get) Token: 0x06007205 RID: 29189 RVA: 0x000A349F File Offset: 0x000A169F
		// (set) Token: 0x06007206 RID: 29190 RVA: 0x000A34B3 File Offset: 0x000A16B3
		[Nullable(2)]
		public unsafe UAnimCurveCompressionSettings CurveCompressionSettings
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAnimCurveCompressionSettings>(base.NativePtr / (IntPtr)sizeof(void*) + UAnimStreamable.__PropertyOffset_CurveCompressionSettings);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UAnimStreamable.__PropertyOffset_CurveCompressionSettings, value);
			}
		}

		// Token: 0x17001AD6 RID: 6870
		// (get) Token: 0x06007207 RID: 29191 RVA: 0x000A34C8 File Offset: 0x000A16C8
		// (set) Token: 0x06007208 RID: 29192 RVA: 0x000A34D8 File Offset: 0x000A16D8
		public unsafe bool bEnableRootMotion
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimStreamable.__PropertyOffset_bEnableRootMotion) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimStreamable.__PropertyOffset_bEnableRootMotion) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001AD7 RID: 6871
		// (get) Token: 0x06007209 RID: 29193 RVA: 0x000A34E9 File Offset: 0x000A16E9
		// (set) Token: 0x0600720A RID: 29194 RVA: 0x000A34FD File Offset: 0x000A16FD
		public unsafe TEnumAsByte<ERootMotionRootLock> RootMotionRootLock
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimStreamable.__PropertyOffset_RootMotionRootLock);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimStreamable.__PropertyOffset_RootMotionRootLock) = value;
			}
		}

		// Token: 0x17001AD8 RID: 6872
		// (get) Token: 0x0600720B RID: 29195 RVA: 0x000A3512 File Offset: 0x000A1712
		// (set) Token: 0x0600720C RID: 29196 RVA: 0x000A3522 File Offset: 0x000A1722
		public unsafe bool bForceRootLock
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimStreamable.__PropertyOffset_bForceRootLock) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimStreamable.__PropertyOffset_bForceRootLock) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001AD9 RID: 6873
		// (get) Token: 0x0600720D RID: 29197 RVA: 0x000A3533 File Offset: 0x000A1733
		// (set) Token: 0x0600720E RID: 29198 RVA: 0x000A3543 File Offset: 0x000A1743
		public unsafe bool bUseNormalizedRootMotionScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimStreamable.__PropertyOffset_bUseNormalizedRootMotionScale) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimStreamable.__PropertyOffset_bUseNormalizedRootMotionScale) = (value ? 1 : 0);
			}
		}

		// Token: 0x0600720F RID: 29199 RVA: 0x000A3554 File Offset: 0x000A1754
		static UAnimStreamable()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.AnimStreamable");
		}

		// Token: 0x06007210 RID: 29200 RVA: 0x000A3562 File Offset: 0x000A1762
		protected UAnimStreamable(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040036BC RID: 14012
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.AnimStreamable";

		// Token: 0x040036BD RID: 14013
		private static IntPtr _ClassPtr;

		// Token: 0x040036BE RID: 14014
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040036BF RID: 14015
		internal static int __PropertyOffset_NumFrames;

		// Token: 0x040036C0 RID: 14016
		internal static int __PropertyOffset_Interpolation;

		// Token: 0x040036C1 RID: 14017
		internal static int __PropertyOffset_RetargetSource;

		// Token: 0x040036C2 RID: 14018
		internal static int __PropertyOffset_BoneCompressionSettings;

		// Token: 0x040036C3 RID: 14019
		internal static int __PropertyOffset_CurveCompressionSettings;

		// Token: 0x040036C4 RID: 14020
		internal static int __PropertyOffset_bEnableRootMotion;

		// Token: 0x040036C5 RID: 14021
		internal static int __PropertyOffset_RootMotionRootLock;

		// Token: 0x040036C6 RID: 14022
		internal static int __PropertyOffset_bForceRootLock;

		// Token: 0x040036C7 RID: 14023
		internal static int __PropertyOffset_bUseNormalizedRootMotionScale;
	}
}
