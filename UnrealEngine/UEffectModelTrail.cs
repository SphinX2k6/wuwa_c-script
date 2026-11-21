using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003CF RID: 975
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplay.EffectModelTrail")]
	[UnrealStructLayout(720, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 720)]
	public class UEffectModelTrail : UEffectModelBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006093 RID: 24723 RVA: 0x00089B8A File Offset: 0x00087D8A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UEffectModelTrail._ClassPtr;
		}

		// Token: 0x06006094 RID: 24724 RVA: 0x00089B98 File Offset: 0x00087D98
		public UEffectModelTrail() : this(BuiltinUtils.AllocNativeUObject(UEffectModelTrail.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006095 RID: 24725 RVA: 0x00089BC0 File Offset: 0x00087DC0
		public UEffectModelTrail(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UEffectModelTrail.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170013B9 RID: 5049
		// (get) Token: 0x06006096 RID: 24726 RVA: 0x00089BF3 File Offset: 0x00087DF3
		// (set) Token: 0x06006097 RID: 24727 RVA: 0x00089C03 File Offset: 0x00087E03
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

		// Token: 0x170013BA RID: 5050
		// (get) Token: 0x06006098 RID: 24728 RVA: 0x00089C14 File Offset: 0x00087E14
		// (set) Token: 0x06006099 RID: 24729 RVA: 0x00089C4D File Offset: 0x00087E4D
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

		// Token: 0x170013BB RID: 5051
		// (get) Token: 0x0600609A RID: 24730 RVA: 0x00089C5C File Offset: 0x00087E5C
		// (set) Token: 0x0600609B RID: 24731 RVA: 0x00089C95 File Offset: 0x00087E95
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

		// Token: 0x170013BC RID: 5052
		// (get) Token: 0x0600609C RID: 24732 RVA: 0x00089CA4 File Offset: 0x00087EA4
		// (set) Token: 0x0600609D RID: 24733 RVA: 0x00089CDD File Offset: 0x00087EDD
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

		// Token: 0x170013BD RID: 5053
		// (get) Token: 0x0600609E RID: 24734 RVA: 0x00089CEB File Offset: 0x00087EEB
		// (set) Token: 0x0600609F RID: 24735 RVA: 0x00089CFF File Offset: 0x00087EFF
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

		// Token: 0x170013BE RID: 5054
		// (get) Token: 0x060060A0 RID: 24736 RVA: 0x00089D14 File Offset: 0x00087F14
		// (set) Token: 0x060060A1 RID: 24737 RVA: 0x00089D24 File Offset: 0x00087F24
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

		// Token: 0x170013BF RID: 5055
		// (get) Token: 0x060060A2 RID: 24738 RVA: 0x00089D38 File Offset: 0x00087F38
		// (set) Token: 0x060060A3 RID: 24739 RVA: 0x00089D71 File Offset: 0x00087F71
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

		// Token: 0x170013C0 RID: 5056
		// (get) Token: 0x060060A4 RID: 24740 RVA: 0x00089D94 File Offset: 0x00087F94
		// (set) Token: 0x060060A5 RID: 24741 RVA: 0x00089DCD File Offset: 0x00087FCD
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

		// Token: 0x170013C1 RID: 5057
		// (get) Token: 0x060060A6 RID: 24742 RVA: 0x00089DF0 File Offset: 0x00087FF0
		// (set) Token: 0x060060A7 RID: 24743 RVA: 0x00089E29 File Offset: 0x00088029
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

		// Token: 0x170013C2 RID: 5058
		// (get) Token: 0x060060A8 RID: 24744 RVA: 0x00089E38 File Offset: 0x00088038
		// (set) Token: 0x060060A9 RID: 24745 RVA: 0x00089E71 File Offset: 0x00088071
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

		// Token: 0x170013C3 RID: 5059
		// (get) Token: 0x060060AA RID: 24746 RVA: 0x00089E7F File Offset: 0x0008807F
		// (set) Token: 0x060060AB RID: 24747 RVA: 0x00089E8F File Offset: 0x0008808F
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

		// Token: 0x170013C4 RID: 5060
		// (get) Token: 0x060060AC RID: 24748 RVA: 0x00089EA0 File Offset: 0x000880A0
		// (set) Token: 0x060060AD RID: 24749 RVA: 0x00089EB0 File Offset: 0x000880B0
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

		// Token: 0x060060AE RID: 24750 RVA: 0x00089EC1 File Offset: 0x000880C1
		static UEffectModelTrail()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.EffectModelTrail");
		}

		// Token: 0x060060AF RID: 24751 RVA: 0x00089ECF File Offset: 0x000880CF
		protected UEffectModelTrail(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002919 RID: 10521
		public new const string __ObjectPath = "/Script/KuroGameplay.EffectModelTrail";

		// Token: 0x0400291A RID: 10522
		private static IntPtr _ClassPtr;

		// Token: 0x0400291B RID: 10523
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400291C RID: 10524
		internal static int __PropertyOffset_AttachToBones;

		// Token: 0x0400291D RID: 10525
		internal static int __PropertyOffset_AttachBoneNames;

		// Token: 0x0400291E RID: 10526
		[Nullable(2)]
		private TArray<FName> _AttachBoneNames;

		// Token: 0x0400291F RID: 10527
		internal static int __PropertyOffset_RelativeLocations;

		// Token: 0x04002920 RID: 10528
		[Nullable(2)]
		private TArray<FVector> _RelativeLocations;

		// Token: 0x04002921 RID: 10529
		internal static int __PropertyOffset_LocationsCurve;

		// Token: 0x04002922 RID: 10530
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<int, FKuroCurveVector> _LocationsCurve;

		// Token: 0x04002923 RID: 10531
		internal static int __PropertyOffset_Material;

		// Token: 0x04002924 RID: 10532
		internal static int __PropertyOffset_UnitLength;

		// Token: 0x04002925 RID: 10533
		internal static int __PropertyOffset_DissipateSpeed;

		// Token: 0x04002926 RID: 10534
		[Nullable(2)]
		private FKuroCurveFloat _DissipateSpeed;

		// Token: 0x04002927 RID: 10535
		internal static int __PropertyOffset_Alpha;

		// Token: 0x04002928 RID: 10536
		[Nullable(2)]
		private FKuroCurveFloat _Alpha;

		// Token: 0x04002929 RID: 10537
		internal static int __PropertyOffset_FloatParameters;

		// Token: 0x0400292A RID: 10538
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, FKuroCurveFloat> _FloatParameters;

		// Token: 0x0400292B RID: 10539
		internal static int __PropertyOffset_ColorParameters;

		// Token: 0x0400292C RID: 10540
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, FKuroCurveLinearColor> _ColorParameters;

		// Token: 0x0400292D RID: 10541
		internal static int __PropertyOffset_DestroyAtOnce;

		// Token: 0x0400292E RID: 10542
		internal static int __PropertyOffset_DissipateSpeedAfterDead;
	}
}
