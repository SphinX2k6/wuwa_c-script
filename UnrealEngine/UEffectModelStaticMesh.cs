using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003CE RID: 974
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplay.EffectModelStaticMesh")]
	[UnrealStructLayout(1624, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1624)]
	public class UEffectModelStaticMesh : UEffectModelBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600606C RID: 24684 RVA: 0x000897A1 File Offset: 0x000879A1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UEffectModelStaticMesh._ClassPtr;
		}

		// Token: 0x0600606D RID: 24685 RVA: 0x000897B0 File Offset: 0x000879B0
		public UEffectModelStaticMesh() : this(BuiltinUtils.AllocNativeUObject(UEffectModelStaticMesh.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600606E RID: 24686 RVA: 0x000897D8 File Offset: 0x000879D8
		public UEffectModelStaticMesh(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UEffectModelStaticMesh.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170013A8 RID: 5032
		// (get) Token: 0x0600606F RID: 24687 RVA: 0x0008980C File Offset: 0x00087A0C
		// (set) Token: 0x06006070 RID: 24688 RVA: 0x00089845 File Offset: 0x00087A45
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

		// Token: 0x170013A9 RID: 5033
		// (get) Token: 0x06006071 RID: 24689 RVA: 0x00089868 File Offset: 0x00087A68
		// (set) Token: 0x06006072 RID: 24690 RVA: 0x000898A1 File Offset: 0x00087AA1
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

		// Token: 0x170013AA RID: 5034
		// (get) Token: 0x06006073 RID: 24691 RVA: 0x000898C4 File Offset: 0x00087AC4
		// (set) Token: 0x06006074 RID: 24692 RVA: 0x000898FD File Offset: 0x00087AFD
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

		// Token: 0x170013AB RID: 5035
		// (get) Token: 0x06006075 RID: 24693 RVA: 0x0008991E File Offset: 0x00087B1E
		// (set) Token: 0x06006076 RID: 24694 RVA: 0x00089932 File Offset: 0x00087B32
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

		// Token: 0x170013AC RID: 5036
		// (get) Token: 0x06006077 RID: 24695 RVA: 0x00089947 File Offset: 0x00087B47
		// (set) Token: 0x06006078 RID: 24696 RVA: 0x00089957 File Offset: 0x00087B57
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

		// Token: 0x170013AD RID: 5037
		// (get) Token: 0x06006079 RID: 24697 RVA: 0x00089968 File Offset: 0x00087B68
		// (set) Token: 0x0600607A RID: 24698 RVA: 0x0008997C File Offset: 0x00087B7C
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

		// Token: 0x170013AE RID: 5038
		// (get) Token: 0x0600607B RID: 24699 RVA: 0x00089994 File Offset: 0x00087B94
		// (set) Token: 0x0600607C RID: 24700 RVA: 0x000899CD File Offset: 0x00087BCD
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

		// Token: 0x170013AF RID: 5039
		// (get) Token: 0x0600607D RID: 24701 RVA: 0x000899DC File Offset: 0x00087BDC
		// (set) Token: 0x0600607E RID: 24702 RVA: 0x00089A15 File Offset: 0x00087C15
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

		// Token: 0x170013B0 RID: 5040
		// (get) Token: 0x0600607F RID: 24703 RVA: 0x00089A24 File Offset: 0x00087C24
		// (set) Token: 0x06006080 RID: 24704 RVA: 0x00089A5D File Offset: 0x00087C5D
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

		// Token: 0x170013B1 RID: 5041
		// (get) Token: 0x06006081 RID: 24705 RVA: 0x00089A6B File Offset: 0x00087C6B
		// (set) Token: 0x06006082 RID: 24706 RVA: 0x00089A7B File Offset: 0x00087C7B
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

		// Token: 0x170013B2 RID: 5042
		// (get) Token: 0x06006083 RID: 24707 RVA: 0x00089A8C File Offset: 0x00087C8C
		// (set) Token: 0x06006084 RID: 24708 RVA: 0x00089A9C File Offset: 0x00087C9C
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

		// Token: 0x170013B3 RID: 5043
		// (get) Token: 0x06006085 RID: 24709 RVA: 0x00089AAD File Offset: 0x00087CAD
		// (set) Token: 0x06006086 RID: 24710 RVA: 0x00089ABD File Offset: 0x00087CBD
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

		// Token: 0x170013B4 RID: 5044
		// (get) Token: 0x06006087 RID: 24711 RVA: 0x00089ACE File Offset: 0x00087CCE
		// (set) Token: 0x06006088 RID: 24712 RVA: 0x00089ADE File Offset: 0x00087CDE
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

		// Token: 0x170013B5 RID: 5045
		// (get) Token: 0x06006089 RID: 24713 RVA: 0x00089AEF File Offset: 0x00087CEF
		// (set) Token: 0x0600608A RID: 24714 RVA: 0x00089AFF File Offset: 0x00087CFF
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

		// Token: 0x170013B6 RID: 5046
		// (get) Token: 0x0600608B RID: 24715 RVA: 0x00089B10 File Offset: 0x00087D10
		// (set) Token: 0x0600608C RID: 24716 RVA: 0x00089B20 File Offset: 0x00087D20
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

		// Token: 0x170013B7 RID: 5047
		// (get) Token: 0x0600608D RID: 24717 RVA: 0x00089B31 File Offset: 0x00087D31
		// (set) Token: 0x0600608E RID: 24718 RVA: 0x00089B41 File Offset: 0x00087D41
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

		// Token: 0x170013B8 RID: 5048
		// (get) Token: 0x0600608F RID: 24719 RVA: 0x00089B52 File Offset: 0x00087D52
		// (set) Token: 0x06006090 RID: 24720 RVA: 0x00089B62 File Offset: 0x00087D62
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

		// Token: 0x06006091 RID: 24721 RVA: 0x00089B73 File Offset: 0x00087D73
		static UEffectModelStaticMesh()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.EffectModelStaticMesh");
		}

		// Token: 0x06006092 RID: 24722 RVA: 0x00089B81 File Offset: 0x00087D81
		protected UEffectModelStaticMesh(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040028FF RID: 10495
		public new const string __ObjectPath = "/Script/KuroGameplay.EffectModelStaticMesh";

		// Token: 0x04002900 RID: 10496
		private static IntPtr _ClassPtr;

		// Token: 0x04002901 RID: 10497
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04002902 RID: 10498
		internal static int __PropertyOffset_Location;

		// Token: 0x04002903 RID: 10499
		[Nullable(2)]
		private FKuroCurveVector _Location;

		// Token: 0x04002904 RID: 10500
		internal static int __PropertyOffset_Rotation;

		// Token: 0x04002905 RID: 10501
		[Nullable(2)]
		private FKuroCurveVector _Rotation;

		// Token: 0x04002906 RID: 10502
		internal static int __PropertyOffset_Scale;

		// Token: 0x04002907 RID: 10503
		[Nullable(2)]
		private FKuroCurveVector _Scale;

		// Token: 0x04002908 RID: 10504
		internal static int __PropertyOffset_StaticMeshRef;

		// Token: 0x04002909 RID: 10505
		internal static int __PropertyOffset_UseMultipleMaterialSlots;

		// Token: 0x0400290A RID: 10506
		internal static int __PropertyOffset_MaterialOverrideRef;

		// Token: 0x0400290B RID: 10507
		internal static int __PropertyOffset_MaterialOverrideArrayRef;

		// Token: 0x0400290C RID: 10508
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInstance> _MaterialOverrideArrayRef;

		// Token: 0x0400290D RID: 10509
		internal static int __PropertyOffset_MaterialFloatParameters;

		// Token: 0x0400290E RID: 10510
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, FKuroCurveFloat> _MaterialFloatParameters;

		// Token: 0x0400290F RID: 10511
		internal static int __PropertyOffset_MaterialColorParameters;

		// Token: 0x04002910 RID: 10512
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, FKuroCurveLinearColor> _MaterialColorParameters;

		// Token: 0x04002911 RID: 10513
		internal static int __PropertyOffset_ReceiveDecal;

		// Token: 0x04002912 RID: 10514
		internal static int __PropertyOffset_EnableCollision;

		// Token: 0x04002913 RID: 10515
		internal static int __PropertyOffset_CastShadow;

		// Token: 0x04002914 RID: 10516
		internal static int __PropertyOffset_TranslucencySortPriority;

		// Token: 0x04002915 RID: 10517
		internal static int __PropertyOffset_EnableScreenSizeCullRatioOverride;

		// Token: 0x04002916 RID: 10518
		internal static int __PropertyOffset_ScreenSizeCullRatio;

		// Token: 0x04002917 RID: 10519
		internal static int __PropertyOffset_AcceptExternalNiagaraParameter;

		// Token: 0x04002918 RID: 10520
		internal static int __PropertyOffset_bForceRenderInBurst;
	}
}
