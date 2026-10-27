using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020018AC RID: 6316
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplay.EffectModelStaticMesh")]
	[UnrealStructLayout(1624, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1624)]
	public class UEffectModelStaticMesh : UEffectModelBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060175D9 RID: 95705 RVA: 0x002225C4 File Offset: 0x002207C4
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UEffectModelStaticMesh._ClassPtr;
		}

		// Token: 0x060175DA RID: 95706 RVA: 0x002225D0 File Offset: 0x002207D0
		public UEffectModelStaticMesh() : this(BuiltinUtils.AllocNativeUObject(UEffectModelStaticMesh.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060175DB RID: 95707 RVA: 0x002225F8 File Offset: 0x002207F8
		public UEffectModelStaticMesh(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UEffectModelStaticMesh.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005E6D RID: 24173
		// (get) Token: 0x060175DC RID: 95708 RVA: 0x0022262C File Offset: 0x0022082C
		// (set) Token: 0x060175DD RID: 95709 RVA: 0x00222665 File Offset: 0x00220865
		public FKuroCurveVector Location
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveVector result;
				if ((result = this._Location) == null)
				{
					result = (this._Location = new FKuroCurveVector(base.NativePtr + (IntPtr)UEffectModelStaticMesh.__PropertyOffset_Location, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveVector.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelStaticMesh.__PropertyOffset_Location, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005E6E RID: 24174
		// (get) Token: 0x060175DE RID: 95710 RVA: 0x00222688 File Offset: 0x00220888
		// (set) Token: 0x060175DF RID: 95711 RVA: 0x002226C1 File Offset: 0x002208C1
		public FKuroCurveVector Rotation
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveVector result;
				if ((result = this._Rotation) == null)
				{
					result = (this._Rotation = new FKuroCurveVector(base.NativePtr + (IntPtr)UEffectModelStaticMesh.__PropertyOffset_Rotation, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveVector.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelStaticMesh.__PropertyOffset_Rotation, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005E6F RID: 24175
		// (get) Token: 0x060175E0 RID: 95712 RVA: 0x002226E4 File Offset: 0x002208E4
		// (set) Token: 0x060175E1 RID: 95713 RVA: 0x0022271D File Offset: 0x0022091D
		public FKuroCurveVector Scale
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveVector result;
				if ((result = this._Scale) == null)
				{
					result = (this._Scale = new FKuroCurveVector(base.NativePtr + (IntPtr)UEffectModelStaticMesh.__PropertyOffset_Scale, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveVector.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelStaticMesh.__PropertyOffset_Scale, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005E70 RID: 24176
		// (get) Token: 0x060175E2 RID: 95714 RVA: 0x0022273E File Offset: 0x0022093E
		// (set) Token: 0x060175E3 RID: 95715 RVA: 0x00222752 File Offset: 0x00220952
		[Nullable(2)]
		public unsafe UStaticMesh StaticMeshRef
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + UEffectModelStaticMesh.__PropertyOffset_StaticMeshRef);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UEffectModelStaticMesh.__PropertyOffset_StaticMeshRef, value);
			}
		}

		// Token: 0x17005E71 RID: 24177
		// (get) Token: 0x060175E4 RID: 95716 RVA: 0x00222767 File Offset: 0x00220967
		// (set) Token: 0x060175E5 RID: 95717 RVA: 0x00222777 File Offset: 0x00220977
		public unsafe bool UseMultipleMaterialSlots
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelStaticMesh.__PropertyOffset_UseMultipleMaterialSlots) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelStaticMesh.__PropertyOffset_UseMultipleMaterialSlots) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005E72 RID: 24178
		// (get) Token: 0x060175E6 RID: 95718 RVA: 0x00222788 File Offset: 0x00220988
		// (set) Token: 0x060175E7 RID: 95719 RVA: 0x0022279C File Offset: 0x0022099C
		[Nullable(2)]
		public unsafe UMaterialInstance MaterialOverrideRef
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + UEffectModelStaticMesh.__PropertyOffset_MaterialOverrideRef);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UEffectModelStaticMesh.__PropertyOffset_MaterialOverrideRef, value);
			}
		}

		// Token: 0x17005E73 RID: 24179
		// (get) Token: 0x060175E8 RID: 95720 RVA: 0x002227B4 File Offset: 0x002209B4
		// (set) Token: 0x060175E9 RID: 95721 RVA: 0x002227ED File Offset: 0x002209ED
		public TArray<UMaterialInstance> MaterialOverrideArrayRef
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInstance> result;
				if ((result = this._MaterialOverrideArrayRef) == null)
				{
					result = (this._MaterialOverrideArrayRef = new TArray<UMaterialInstance>(base.NativePtr + (IntPtr)UEffectModelStaticMesh.__PropertyOffset_MaterialOverrideArrayRef, this));
				}
				return result;
			}
			set
			{
				this.MaterialOverrideArrayRef.CopyAssign(value);
			}
		}

		// Token: 0x17005E74 RID: 24180
		// (get) Token: 0x060175EA RID: 95722 RVA: 0x002227FC File Offset: 0x002209FC
		// (set) Token: 0x060175EB RID: 95723 RVA: 0x00222835 File Offset: 0x00220A35
		public TMap<FName, FKuroCurveFloat> MaterialFloatParameters
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FKuroCurveFloat> result;
				if ((result = this._MaterialFloatParameters) == null)
				{
					result = (this._MaterialFloatParameters = new TMap<FName, FKuroCurveFloat>(base.NativePtr + (IntPtr)UEffectModelStaticMesh.__PropertyOffset_MaterialFloatParameters, this));
				}
				return result;
			}
			set
			{
				this.MaterialFloatParameters.CopyAssign(value);
			}
		}

		// Token: 0x17005E75 RID: 24181
		// (get) Token: 0x060175EC RID: 95724 RVA: 0x00222844 File Offset: 0x00220A44
		// (set) Token: 0x060175ED RID: 95725 RVA: 0x0022287D File Offset: 0x00220A7D
		public TMap<FName, FKuroCurveLinearColor> MaterialColorParameters
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FKuroCurveLinearColor> result;
				if ((result = this._MaterialColorParameters) == null)
				{
					result = (this._MaterialColorParameters = new TMap<FName, FKuroCurveLinearColor>(base.NativePtr + (IntPtr)UEffectModelStaticMesh.__PropertyOffset_MaterialColorParameters, this));
				}
				return result;
			}
			set
			{
				this.MaterialColorParameters.CopyAssign(value);
			}
		}

		// Token: 0x17005E76 RID: 24182
		// (get) Token: 0x060175EE RID: 95726 RVA: 0x0022288B File Offset: 0x00220A8B
		// (set) Token: 0x060175EF RID: 95727 RVA: 0x0022289B File Offset: 0x00220A9B
		public unsafe bool ReceiveDecal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelStaticMesh.__PropertyOffset_ReceiveDecal) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelStaticMesh.__PropertyOffset_ReceiveDecal) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005E77 RID: 24183
		// (get) Token: 0x060175F0 RID: 95728 RVA: 0x002228AC File Offset: 0x00220AAC
		// (set) Token: 0x060175F1 RID: 95729 RVA: 0x002228BC File Offset: 0x00220ABC
		public unsafe bool EnableCollision
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelStaticMesh.__PropertyOffset_EnableCollision) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelStaticMesh.__PropertyOffset_EnableCollision) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005E78 RID: 24184
		// (get) Token: 0x060175F2 RID: 95730 RVA: 0x002228CD File Offset: 0x00220ACD
		// (set) Token: 0x060175F3 RID: 95731 RVA: 0x002228DD File Offset: 0x00220ADD
		public unsafe bool CastShadow
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelStaticMesh.__PropertyOffset_CastShadow) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelStaticMesh.__PropertyOffset_CastShadow) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005E79 RID: 24185
		// (get) Token: 0x060175F4 RID: 95732 RVA: 0x002228EE File Offset: 0x00220AEE
		// (set) Token: 0x060175F5 RID: 95733 RVA: 0x002228FE File Offset: 0x00220AFE
		public unsafe float TranslucencySortPriority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelStaticMesh.__PropertyOffset_TranslucencySortPriority);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelStaticMesh.__PropertyOffset_TranslucencySortPriority) = value;
			}
		}

		// Token: 0x17005E7A RID: 24186
		// (get) Token: 0x060175F6 RID: 95734 RVA: 0x0022290F File Offset: 0x00220B0F
		// (set) Token: 0x060175F7 RID: 95735 RVA: 0x0022291F File Offset: 0x00220B1F
		public unsafe bool EnableScreenSizeCullRatioOverride
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelStaticMesh.__PropertyOffset_EnableScreenSizeCullRatioOverride) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelStaticMesh.__PropertyOffset_EnableScreenSizeCullRatioOverride) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005E7B RID: 24187
		// (get) Token: 0x060175F8 RID: 95736 RVA: 0x00222930 File Offset: 0x00220B30
		// (set) Token: 0x060175F9 RID: 95737 RVA: 0x00222940 File Offset: 0x00220B40
		public unsafe float ScreenSizeCullRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelStaticMesh.__PropertyOffset_ScreenSizeCullRatio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelStaticMesh.__PropertyOffset_ScreenSizeCullRatio) = value;
			}
		}

		// Token: 0x17005E7C RID: 24188
		// (get) Token: 0x060175FA RID: 95738 RVA: 0x00222951 File Offset: 0x00220B51
		// (set) Token: 0x060175FB RID: 95739 RVA: 0x00222961 File Offset: 0x00220B61
		public unsafe bool AcceptExternalNiagaraParameter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelStaticMesh.__PropertyOffset_AcceptExternalNiagaraParameter) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelStaticMesh.__PropertyOffset_AcceptExternalNiagaraParameter) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005E7D RID: 24189
		// (get) Token: 0x060175FC RID: 95740 RVA: 0x00222972 File Offset: 0x00220B72
		// (set) Token: 0x060175FD RID: 95741 RVA: 0x00222982 File Offset: 0x00220B82
		public unsafe bool bForceRenderInBurst
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelStaticMesh.__PropertyOffset_bForceRenderInBurst) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelStaticMesh.__PropertyOffset_bForceRenderInBurst) = (value ? 1 : 0);
			}
		}

		// Token: 0x060175FE RID: 95742 RVA: 0x00222993 File Offset: 0x00220B93
		static UEffectModelStaticMesh()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.EffectModelStaticMesh");
		}

		// Token: 0x060175FF RID: 95743 RVA: 0x002229A1 File Offset: 0x00220BA1
		protected UEffectModelStaticMesh(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400CB40 RID: 52032
		public new const string __ObjectPath = "/Script/KuroGameplay.EffectModelStaticMesh";

		// Token: 0x0400CB41 RID: 52033
		private static IntPtr _ClassPtr;

		// Token: 0x0400CB42 RID: 52034
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400CB43 RID: 52035
		internal static int __PropertyOffset_Location;

		// Token: 0x0400CB44 RID: 52036
		[Nullable(2)]
		private FKuroCurveVector _Location;

		// Token: 0x0400CB45 RID: 52037
		internal static int __PropertyOffset_Rotation;

		// Token: 0x0400CB46 RID: 52038
		[Nullable(2)]
		private FKuroCurveVector _Rotation;

		// Token: 0x0400CB47 RID: 52039
		internal static int __PropertyOffset_Scale;

		// Token: 0x0400CB48 RID: 52040
		[Nullable(2)]
		private FKuroCurveVector _Scale;

		// Token: 0x0400CB49 RID: 52041
		internal static int __PropertyOffset_StaticMeshRef;

		// Token: 0x0400CB4A RID: 52042
		internal static int __PropertyOffset_UseMultipleMaterialSlots;

		// Token: 0x0400CB4B RID: 52043
		internal static int __PropertyOffset_MaterialOverrideRef;

		// Token: 0x0400CB4C RID: 52044
		internal static int __PropertyOffset_MaterialOverrideArrayRef;

		// Token: 0x0400CB4D RID: 52045
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInstance> _MaterialOverrideArrayRef;

		// Token: 0x0400CB4E RID: 52046
		internal static int __PropertyOffset_MaterialFloatParameters;

		// Token: 0x0400CB4F RID: 52047
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, FKuroCurveFloat> _MaterialFloatParameters;

		// Token: 0x0400CB50 RID: 52048
		internal static int __PropertyOffset_MaterialColorParameters;

		// Token: 0x0400CB51 RID: 52049
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, FKuroCurveLinearColor> _MaterialColorParameters;

		// Token: 0x0400CB52 RID: 52050
		internal static int __PropertyOffset_ReceiveDecal;

		// Token: 0x0400CB53 RID: 52051
		internal static int __PropertyOffset_EnableCollision;

		// Token: 0x0400CB54 RID: 52052
		internal static int __PropertyOffset_CastShadow;

		// Token: 0x0400CB55 RID: 52053
		internal static int __PropertyOffset_TranslucencySortPriority;

		// Token: 0x0400CB56 RID: 52054
		internal static int __PropertyOffset_EnableScreenSizeCullRatioOverride;

		// Token: 0x0400CB57 RID: 52055
		internal static int __PropertyOffset_ScreenSizeCullRatio;

		// Token: 0x0400CB58 RID: 52056
		internal static int __PropertyOffset_AcceptExternalNiagaraParameter;

		// Token: 0x0400CB59 RID: 52057
		internal static int __PropertyOffset_bForceRenderInBurst;
	}
}
