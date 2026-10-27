using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020018AD RID: 6317
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplay.EffectModelTrail")]
	[UnrealStructLayout(720, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 720)]
	public class UEffectModelTrail : UEffectModelBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06017600 RID: 95744 RVA: 0x002229AA File Offset: 0x00220BAA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UEffectModelTrail._ClassPtr;
		}

		// Token: 0x06017601 RID: 95745 RVA: 0x002229B8 File Offset: 0x00220BB8
		public UEffectModelTrail() : this(BuiltinUtils.AllocNativeUObject(UEffectModelTrail.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06017602 RID: 95746 RVA: 0x002229E0 File Offset: 0x00220BE0
		public UEffectModelTrail(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UEffectModelTrail.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005E7E RID: 24190
		// (get) Token: 0x06017603 RID: 95747 RVA: 0x00222A13 File Offset: 0x00220C13
		// (set) Token: 0x06017604 RID: 95748 RVA: 0x00222A23 File Offset: 0x00220C23
		public unsafe bool AttachToBones
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelTrail.__PropertyOffset_AttachToBones) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelTrail.__PropertyOffset_AttachToBones) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005E7F RID: 24191
		// (get) Token: 0x06017605 RID: 95749 RVA: 0x00222A34 File Offset: 0x00220C34
		// (set) Token: 0x06017606 RID: 95750 RVA: 0x00222A6D File Offset: 0x00220C6D
		public TArray<FName> AttachBoneNames
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._AttachBoneNames) == null)
				{
					result = (this._AttachBoneNames = new TArray<FName>(base.NativePtr + (IntPtr)UEffectModelTrail.__PropertyOffset_AttachBoneNames, this));
				}
				return result;
			}
			set
			{
				this.AttachBoneNames.CopyAssign(value);
			}
		}

		// Token: 0x17005E80 RID: 24192
		// (get) Token: 0x06017607 RID: 95751 RVA: 0x00222A7C File Offset: 0x00220C7C
		// (set) Token: 0x06017608 RID: 95752 RVA: 0x00222AB5 File Offset: 0x00220CB5
		public TArray<FVector> RelativeLocations
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._RelativeLocations) == null)
				{
					result = (this._RelativeLocations = new TArray<FVector>(base.NativePtr + (IntPtr)UEffectModelTrail.__PropertyOffset_RelativeLocations, this));
				}
				return result;
			}
			set
			{
				this.RelativeLocations.CopyAssign(value);
			}
		}

		// Token: 0x17005E81 RID: 24193
		// (get) Token: 0x06017609 RID: 95753 RVA: 0x00222AC4 File Offset: 0x00220CC4
		// (set) Token: 0x0601760A RID: 95754 RVA: 0x00222AFD File Offset: 0x00220CFD
		public TMap<int, FKuroCurveVector> LocationsCurve
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, FKuroCurveVector> result;
				if ((result = this._LocationsCurve) == null)
				{
					result = (this._LocationsCurve = new TMap<int, FKuroCurveVector>(base.NativePtr + (IntPtr)UEffectModelTrail.__PropertyOffset_LocationsCurve, this));
				}
				return result;
			}
			set
			{
				this.LocationsCurve.CopyAssign(value);
			}
		}

		// Token: 0x17005E82 RID: 24194
		// (get) Token: 0x0601760B RID: 95755 RVA: 0x00222B0B File Offset: 0x00220D0B
		// (set) Token: 0x0601760C RID: 95756 RVA: 0x00222B1F File Offset: 0x00220D1F
		[Nullable(2)]
		public unsafe UMaterialInstance Material
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + UEffectModelTrail.__PropertyOffset_Material);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UEffectModelTrail.__PropertyOffset_Material, value);
			}
		}

		// Token: 0x17005E83 RID: 24195
		// (get) Token: 0x0601760D RID: 95757 RVA: 0x00222B34 File Offset: 0x00220D34
		// (set) Token: 0x0601760E RID: 95758 RVA: 0x00222B44 File Offset: 0x00220D44
		public unsafe float UnitLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelTrail.__PropertyOffset_UnitLength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelTrail.__PropertyOffset_UnitLength) = value;
			}
		}

		// Token: 0x17005E84 RID: 24196
		// (get) Token: 0x0601760F RID: 95759 RVA: 0x00222B58 File Offset: 0x00220D58
		// (set) Token: 0x06017610 RID: 95760 RVA: 0x00222B91 File Offset: 0x00220D91
		public FKuroCurveFloat DissipateSpeed
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._DissipateSpeed) == null)
				{
					result = (this._DissipateSpeed = new FKuroCurveFloat(base.NativePtr + (IntPtr)UEffectModelTrail.__PropertyOffset_DissipateSpeed, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelTrail.__PropertyOffset_DissipateSpeed, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005E85 RID: 24197
		// (get) Token: 0x06017611 RID: 95761 RVA: 0x00222BB4 File Offset: 0x00220DB4
		// (set) Token: 0x06017612 RID: 95762 RVA: 0x00222BED File Offset: 0x00220DED
		public FKuroCurveFloat Alpha
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._Alpha) == null)
				{
					result = (this._Alpha = new FKuroCurveFloat(base.NativePtr + (IntPtr)UEffectModelTrail.__PropertyOffset_Alpha, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelTrail.__PropertyOffset_Alpha, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005E86 RID: 24198
		// (get) Token: 0x06017613 RID: 95763 RVA: 0x00222C10 File Offset: 0x00220E10
		// (set) Token: 0x06017614 RID: 95764 RVA: 0x00222C49 File Offset: 0x00220E49
		public TMap<FName, FKuroCurveFloat> FloatParameters
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FKuroCurveFloat> result;
				if ((result = this._FloatParameters) == null)
				{
					result = (this._FloatParameters = new TMap<FName, FKuroCurveFloat>(base.NativePtr + (IntPtr)UEffectModelTrail.__PropertyOffset_FloatParameters, this));
				}
				return result;
			}
			set
			{
				this.FloatParameters.CopyAssign(value);
			}
		}

		// Token: 0x17005E87 RID: 24199
		// (get) Token: 0x06017615 RID: 95765 RVA: 0x00222C58 File Offset: 0x00220E58
		// (set) Token: 0x06017616 RID: 95766 RVA: 0x00222C91 File Offset: 0x00220E91
		public TMap<FName, FKuroCurveLinearColor> ColorParameters
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FKuroCurveLinearColor> result;
				if ((result = this._ColorParameters) == null)
				{
					result = (this._ColorParameters = new TMap<FName, FKuroCurveLinearColor>(base.NativePtr + (IntPtr)UEffectModelTrail.__PropertyOffset_ColorParameters, this));
				}
				return result;
			}
			set
			{
				this.ColorParameters.CopyAssign(value);
			}
		}

		// Token: 0x17005E88 RID: 24200
		// (get) Token: 0x06017617 RID: 95767 RVA: 0x00222C9F File Offset: 0x00220E9F
		// (set) Token: 0x06017618 RID: 95768 RVA: 0x00222CAF File Offset: 0x00220EAF
		public unsafe bool DestroyAtOnce
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelTrail.__PropertyOffset_DestroyAtOnce) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelTrail.__PropertyOffset_DestroyAtOnce) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005E89 RID: 24201
		// (get) Token: 0x06017619 RID: 95769 RVA: 0x00222CC0 File Offset: 0x00220EC0
		// (set) Token: 0x0601761A RID: 95770 RVA: 0x00222CD0 File Offset: 0x00220ED0
		public unsafe float DissipateSpeedAfterDead
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelTrail.__PropertyOffset_DissipateSpeedAfterDead);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelTrail.__PropertyOffset_DissipateSpeedAfterDead) = value;
			}
		}

		// Token: 0x0601761B RID: 95771 RVA: 0x00222CE1 File Offset: 0x00220EE1
		static UEffectModelTrail()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.EffectModelTrail");
		}

		// Token: 0x0601761C RID: 95772 RVA: 0x00222CEF File Offset: 0x00220EEF
		protected UEffectModelTrail(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400CB5A RID: 52058
		public new const string __ObjectPath = "/Script/KuroGameplay.EffectModelTrail";

		// Token: 0x0400CB5B RID: 52059
		private static IntPtr _ClassPtr;

		// Token: 0x0400CB5C RID: 52060
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400CB5D RID: 52061
		internal static int __PropertyOffset_AttachToBones;

		// Token: 0x0400CB5E RID: 52062
		internal static int __PropertyOffset_AttachBoneNames;

		// Token: 0x0400CB5F RID: 52063
		[Nullable(2)]
		private TArray<FName> _AttachBoneNames;

		// Token: 0x0400CB60 RID: 52064
		internal static int __PropertyOffset_RelativeLocations;

		// Token: 0x0400CB61 RID: 52065
		[Nullable(2)]
		private TArray<FVector> _RelativeLocations;

		// Token: 0x0400CB62 RID: 52066
		internal static int __PropertyOffset_LocationsCurve;

		// Token: 0x0400CB63 RID: 52067
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<int, FKuroCurveVector> _LocationsCurve;

		// Token: 0x0400CB64 RID: 52068
		internal static int __PropertyOffset_Material;

		// Token: 0x0400CB65 RID: 52069
		internal static int __PropertyOffset_UnitLength;

		// Token: 0x0400CB66 RID: 52070
		internal static int __PropertyOffset_DissipateSpeed;

		// Token: 0x0400CB67 RID: 52071
		[Nullable(2)]
		private FKuroCurveFloat _DissipateSpeed;

		// Token: 0x0400CB68 RID: 52072
		internal static int __PropertyOffset_Alpha;

		// Token: 0x0400CB69 RID: 52073
		[Nullable(2)]
		private FKuroCurveFloat _Alpha;

		// Token: 0x0400CB6A RID: 52074
		internal static int __PropertyOffset_FloatParameters;

		// Token: 0x0400CB6B RID: 52075
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, FKuroCurveFloat> _FloatParameters;

		// Token: 0x0400CB6C RID: 52076
		internal static int __PropertyOffset_ColorParameters;

		// Token: 0x0400CB6D RID: 52077
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, FKuroCurveLinearColor> _ColorParameters;

		// Token: 0x0400CB6E RID: 52078
		internal static int __PropertyOffset_DestroyAtOnce;

		// Token: 0x0400CB6F RID: 52079
		internal static int __PropertyOffset_DissipateSpeedAfterDead;
	}
}
