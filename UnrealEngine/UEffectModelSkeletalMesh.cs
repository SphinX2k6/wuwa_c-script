using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020018AB RID: 6315
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplay.EffectModelSkeletalMesh")]
	[UnrealStructLayout(1632, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1632)]
	public class UEffectModelSkeletalMesh : UEffectModelBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060175AE RID: 95662 RVA: 0x0022219B File Offset: 0x0022039B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UEffectModelSkeletalMesh._ClassPtr;
		}

		// Token: 0x060175AF RID: 95663 RVA: 0x002221A8 File Offset: 0x002203A8
		public UEffectModelSkeletalMesh() : this(BuiltinUtils.AllocNativeUObject(UEffectModelSkeletalMesh.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060175B0 RID: 95664 RVA: 0x002221D0 File Offset: 0x002203D0
		public UEffectModelSkeletalMesh(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UEffectModelSkeletalMesh.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005E5A RID: 24154
		// (get) Token: 0x060175B1 RID: 95665 RVA: 0x00222203 File Offset: 0x00220403
		// (set) Token: 0x060175B2 RID: 95666 RVA: 0x00222217 File Offset: 0x00220417
		[Nullable(2)]
		public unsafe USkeletalMesh SkeletalMeshRef
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMesh>(base.NativePtr / (IntPtr)sizeof(void*) + UEffectModelSkeletalMesh.__PropertyOffset_SkeletalMeshRef);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UEffectModelSkeletalMesh.__PropertyOffset_SkeletalMeshRef, value);
			}
		}

		// Token: 0x17005E5B RID: 24155
		// (get) Token: 0x060175B3 RID: 95667 RVA: 0x0022222C File Offset: 0x0022042C
		// (set) Token: 0x060175B4 RID: 95668 RVA: 0x00222240 File Offset: 0x00220440
		[Nullable(2)]
		public unsafe UAnimationAsset AnimationRef
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAnimationAsset>(base.NativePtr / (IntPtr)sizeof(void*) + UEffectModelSkeletalMesh.__PropertyOffset_AnimationRef);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UEffectModelSkeletalMesh.__PropertyOffset_AnimationRef, value);
			}
		}

		// Token: 0x17005E5C RID: 24156
		// (get) Token: 0x060175B5 RID: 95669 RVA: 0x00222255 File Offset: 0x00220455
		// (set) Token: 0x060175B6 RID: 95670 RVA: 0x00222265 File Offset: 0x00220465
		public unsafe int LodBias
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelSkeletalMesh.__PropertyOffset_LodBias);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelSkeletalMesh.__PropertyOffset_LodBias) = value;
			}
		}

		// Token: 0x17005E5D RID: 24157
		// (get) Token: 0x060175B7 RID: 95671 RVA: 0x00222276 File Offset: 0x00220476
		// (set) Token: 0x060175B8 RID: 95672 RVA: 0x00222286 File Offset: 0x00220486
		public unsafe bool bForceLod0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelSkeletalMesh.__PropertyOffset_bForceLod0) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelSkeletalMesh.__PropertyOffset_bForceLod0) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005E5E RID: 24158
		// (get) Token: 0x060175B9 RID: 95673 RVA: 0x00222298 File Offset: 0x00220498
		// (set) Token: 0x060175BA RID: 95674 RVA: 0x002222D1 File Offset: 0x002204D1
		public TArray<UMaterialInterface> ReplaceMaterials
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInterface> result;
				if ((result = this._ReplaceMaterials) == null)
				{
					result = (this._ReplaceMaterials = new TArray<UMaterialInterface>(base.NativePtr + (IntPtr)UEffectModelSkeletalMesh.__PropertyOffset_ReplaceMaterials, this));
				}
				return result;
			}
			set
			{
				this.ReplaceMaterials.CopyAssign(value);
			}
		}

		// Token: 0x17005E5F RID: 24159
		// (get) Token: 0x060175BB RID: 95675 RVA: 0x002222DF File Offset: 0x002204DF
		// (set) Token: 0x060175BC RID: 95676 RVA: 0x002222EF File Offset: 0x002204EF
		public unsafe bool Looping
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelSkeletalMesh.__PropertyOffset_Looping) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelSkeletalMesh.__PropertyOffset_Looping) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005E60 RID: 24160
		// (get) Token: 0x060175BD RID: 95677 RVA: 0x00222300 File Offset: 0x00220500
		// (set) Token: 0x060175BE RID: 95678 RVA: 0x00222310 File Offset: 0x00220510
		public unsafe bool Playing
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelSkeletalMesh.__PropertyOffset_Playing) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelSkeletalMesh.__PropertyOffset_Playing) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005E61 RID: 24161
		// (get) Token: 0x060175BF RID: 95679 RVA: 0x00222324 File Offset: 0x00220524
		// (set) Token: 0x060175C0 RID: 95680 RVA: 0x0022235D File Offset: 0x0022055D
		public FKuroCurveVector Location
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveVector result;
				if ((result = this._Location) == null)
				{
					result = (this._Location = new FKuroCurveVector(base.NativePtr + (IntPtr)UEffectModelSkeletalMesh.__PropertyOffset_Location, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveVector.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelSkeletalMesh.__PropertyOffset_Location, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005E62 RID: 24162
		// (get) Token: 0x060175C1 RID: 95681 RVA: 0x00222380 File Offset: 0x00220580
		// (set) Token: 0x060175C2 RID: 95682 RVA: 0x002223B9 File Offset: 0x002205B9
		public FKuroCurveVector Rotation
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveVector result;
				if ((result = this._Rotation) == null)
				{
					result = (this._Rotation = new FKuroCurveVector(base.NativePtr + (IntPtr)UEffectModelSkeletalMesh.__PropertyOffset_Rotation, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveVector.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelSkeletalMesh.__PropertyOffset_Rotation, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005E63 RID: 24163
		// (get) Token: 0x060175C3 RID: 95683 RVA: 0x002223DC File Offset: 0x002205DC
		// (set) Token: 0x060175C4 RID: 95684 RVA: 0x00222415 File Offset: 0x00220615
		public FKuroCurveVector Scale
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveVector result;
				if ((result = this._Scale) == null)
				{
					result = (this._Scale = new FKuroCurveVector(base.NativePtr + (IntPtr)UEffectModelSkeletalMesh.__PropertyOffset_Scale, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveVector.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelSkeletalMesh.__PropertyOffset_Scale, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005E64 RID: 24164
		// (get) Token: 0x060175C5 RID: 95685 RVA: 0x00222436 File Offset: 0x00220636
		// (set) Token: 0x060175C6 RID: 95686 RVA: 0x00222446 File Offset: 0x00220646
		public unsafe bool EnableCollision
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelSkeletalMesh.__PropertyOffset_EnableCollision) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelSkeletalMesh.__PropertyOffset_EnableCollision) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005E65 RID: 24165
		// (get) Token: 0x060175C7 RID: 95687 RVA: 0x00222457 File Offset: 0x00220657
		// (set) Token: 0x060175C8 RID: 95688 RVA: 0x00222467 File Offset: 0x00220667
		public unsafe float HideFrames
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelSkeletalMesh.__PropertyOffset_HideFrames);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelSkeletalMesh.__PropertyOffset_HideFrames) = value;
			}
		}

		// Token: 0x17005E66 RID: 24166
		// (get) Token: 0x060175C9 RID: 95689 RVA: 0x00222478 File Offset: 0x00220678
		// (set) Token: 0x060175CA RID: 95690 RVA: 0x00222488 File Offset: 0x00220688
		public unsafe bool CastShadow
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelSkeletalMesh.__PropertyOffset_CastShadow) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelSkeletalMesh.__PropertyOffset_CastShadow) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005E67 RID: 24167
		// (get) Token: 0x060175CB RID: 95691 RVA: 0x00222499 File Offset: 0x00220699
		// (set) Token: 0x060175CC RID: 95692 RVA: 0x002224A9 File Offset: 0x002206A9
		public unsafe bool ForbidCastToonShadow
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelSkeletalMesh.__PropertyOffset_ForbidCastToonShadow) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelSkeletalMesh.__PropertyOffset_ForbidCastToonShadow) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005E68 RID: 24168
		// (get) Token: 0x060175CD RID: 95693 RVA: 0x002224BA File Offset: 0x002206BA
		// (set) Token: 0x060175CE RID: 95694 RVA: 0x002224CA File Offset: 0x002206CA
		public unsafe bool bForceRenderInBurst
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelSkeletalMesh.__PropertyOffset_bForceRenderInBurst) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelSkeletalMesh.__PropertyOffset_bForceRenderInBurst) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005E69 RID: 24169
		// (get) Token: 0x060175CF RID: 95695 RVA: 0x002224DC File Offset: 0x002206DC
		// (set) Token: 0x060175D0 RID: 95696 RVA: 0x00222515 File Offset: 0x00220715
		public TMap<FName, FKuroCurveFloat> FloatParameters
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FKuroCurveFloat> result;
				if ((result = this._FloatParameters) == null)
				{
					result = (this._FloatParameters = new TMap<FName, FKuroCurveFloat>(base.NativePtr + (IntPtr)UEffectModelSkeletalMesh.__PropertyOffset_FloatParameters, this));
				}
				return result;
			}
			set
			{
				this.FloatParameters.CopyAssign(value);
			}
		}

		// Token: 0x17005E6A RID: 24170
		// (get) Token: 0x060175D1 RID: 95697 RVA: 0x00222524 File Offset: 0x00220724
		// (set) Token: 0x060175D2 RID: 95698 RVA: 0x0022255D File Offset: 0x0022075D
		public TMap<FName, FKuroCurveLinearColor> ColorParameters
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FKuroCurveLinearColor> result;
				if ((result = this._ColorParameters) == null)
				{
					result = (this._ColorParameters = new TMap<FName, FKuroCurveLinearColor>(base.NativePtr + (IntPtr)UEffectModelSkeletalMesh.__PropertyOffset_ColorParameters, this));
				}
				return result;
			}
			set
			{
				this.ColorParameters.CopyAssign(value);
			}
		}

		// Token: 0x17005E6B RID: 24171
		// (get) Token: 0x060175D3 RID: 95699 RVA: 0x0022256B File Offset: 0x0022076B
		// (set) Token: 0x060175D4 RID: 95700 RVA: 0x0022257B File Offset: 0x0022077B
		public unsafe bool bStopAnimWhenHidden
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelSkeletalMesh.__PropertyOffset_bStopAnimWhenHidden) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelSkeletalMesh.__PropertyOffset_bStopAnimWhenHidden) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005E6C RID: 24172
		// (get) Token: 0x060175D5 RID: 95701 RVA: 0x0022258C File Offset: 0x0022078C
		// (set) Token: 0x060175D6 RID: 95702 RVA: 0x0022259C File Offset: 0x0022079C
		public unsafe bool bSyncOwnerMaterialController
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelSkeletalMesh.__PropertyOffset_bSyncOwnerMaterialController) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelSkeletalMesh.__PropertyOffset_bSyncOwnerMaterialController) = (value ? 1 : 0);
			}
		}

		// Token: 0x060175D7 RID: 95703 RVA: 0x002225AD File Offset: 0x002207AD
		static UEffectModelSkeletalMesh()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.EffectModelSkeletalMesh");
		}

		// Token: 0x060175D8 RID: 95704 RVA: 0x002225BB File Offset: 0x002207BB
		protected UEffectModelSkeletalMesh(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400CB24 RID: 52004
		public new const string __ObjectPath = "/Script/KuroGameplay.EffectModelSkeletalMesh";

		// Token: 0x0400CB25 RID: 52005
		private static IntPtr _ClassPtr;

		// Token: 0x0400CB26 RID: 52006
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400CB27 RID: 52007
		internal static int __PropertyOffset_SkeletalMeshRef;

		// Token: 0x0400CB28 RID: 52008
		internal static int __PropertyOffset_AnimationRef;

		// Token: 0x0400CB29 RID: 52009
		internal static int __PropertyOffset_LodBias;

		// Token: 0x0400CB2A RID: 52010
		internal static int __PropertyOffset_bForceLod0;

		// Token: 0x0400CB2B RID: 52011
		internal static int __PropertyOffset_ReplaceMaterials;

		// Token: 0x0400CB2C RID: 52012
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInterface> _ReplaceMaterials;

		// Token: 0x0400CB2D RID: 52013
		internal static int __PropertyOffset_Looping;

		// Token: 0x0400CB2E RID: 52014
		internal static int __PropertyOffset_Playing;

		// Token: 0x0400CB2F RID: 52015
		internal static int __PropertyOffset_Location;

		// Token: 0x0400CB30 RID: 52016
		[Nullable(2)]
		private FKuroCurveVector _Location;

		// Token: 0x0400CB31 RID: 52017
		internal static int __PropertyOffset_Rotation;

		// Token: 0x0400CB32 RID: 52018
		[Nullable(2)]
		private FKuroCurveVector _Rotation;

		// Token: 0x0400CB33 RID: 52019
		internal static int __PropertyOffset_Scale;

		// Token: 0x0400CB34 RID: 52020
		[Nullable(2)]
		private FKuroCurveVector _Scale;

		// Token: 0x0400CB35 RID: 52021
		internal static int __PropertyOffset_EnableCollision;

		// Token: 0x0400CB36 RID: 52022
		internal static int __PropertyOffset_HideFrames;

		// Token: 0x0400CB37 RID: 52023
		internal static int __PropertyOffset_CastShadow;

		// Token: 0x0400CB38 RID: 52024
		internal static int __PropertyOffset_ForbidCastToonShadow;

		// Token: 0x0400CB39 RID: 52025
		internal static int __PropertyOffset_bForceRenderInBurst;

		// Token: 0x0400CB3A RID: 52026
		internal static int __PropertyOffset_FloatParameters;

		// Token: 0x0400CB3B RID: 52027
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, FKuroCurveFloat> _FloatParameters;

		// Token: 0x0400CB3C RID: 52028
		internal static int __PropertyOffset_ColorParameters;

		// Token: 0x0400CB3D RID: 52029
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, FKuroCurveLinearColor> _ColorParameters;

		// Token: 0x0400CB3E RID: 52030
		internal static int __PropertyOffset_bStopAnimWhenHidden;

		// Token: 0x0400CB3F RID: 52031
		internal static int __PropertyOffset_bSyncOwnerMaterialController;
	}
}
