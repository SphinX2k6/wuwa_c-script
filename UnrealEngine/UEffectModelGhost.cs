using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020018A0 RID: 6304
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplay.EffectModelGhost")]
	[UnrealStructLayout(472, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 472)]
	public class UEffectModelGhost : UEffectModelBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06017372 RID: 95090 RVA: 0x0021DC32 File Offset: 0x0021BE32
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UEffectModelGhost._ClassPtr;
		}

		// Token: 0x06017373 RID: 95091 RVA: 0x0021DC40 File Offset: 0x0021BE40
		public UEffectModelGhost() : this(BuiltinUtils.AllocNativeUObject(UEffectModelGhost.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06017374 RID: 95092 RVA: 0x0021DC68 File Offset: 0x0021BE68
		public UEffectModelGhost(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UEffectModelGhost.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005D59 RID: 23897
		// (get) Token: 0x06017375 RID: 95093 RVA: 0x0021DC9B File Offset: 0x0021BE9B
		// (set) Token: 0x06017376 RID: 95094 RVA: 0x0021DCAF File Offset: 0x0021BEAF
		[Nullable(2)]
		public unsafe UMaterialInstance MaterialRef
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstance>(base.NativePtr / (IntPtr)sizeof(void*) + UEffectModelGhost.__PropertyOffset_MaterialRef);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UEffectModelGhost.__PropertyOffset_MaterialRef, value);
			}
		}

		// Token: 0x17005D5A RID: 23898
		// (get) Token: 0x06017377 RID: 95095 RVA: 0x0021DCC4 File Offset: 0x0021BEC4
		// (set) Token: 0x06017378 RID: 95096 RVA: 0x0021DCFD File Offset: 0x0021BEFD
		public TArray<EEffectModelGhostCppComponent> MeshComponentsToUse
		{
			get
			{
				base.FastCheckIsValid();
				TArray<EEffectModelGhostCppComponent> result;
				if ((result = this._MeshComponentsToUse) == null)
				{
					result = (this._MeshComponentsToUse = new TArray<EEffectModelGhostCppComponent>(base.NativePtr + (IntPtr)UEffectModelGhost.__PropertyOffset_MeshComponentsToUse, this));
				}
				return result;
			}
			set
			{
				this.MeshComponentsToUse.CopyAssign(value);
			}
		}

		// Token: 0x17005D5B RID: 23899
		// (get) Token: 0x06017379 RID: 95097 RVA: 0x0021DD0C File Offset: 0x0021BF0C
		// (set) Token: 0x0601737A RID: 95098 RVA: 0x0021DD45 File Offset: 0x0021BF45
		public TArray<FName> CustomComponentNames
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._CustomComponentNames) == null)
				{
					result = (this._CustomComponentNames = new TArray<FName>(base.NativePtr + (IntPtr)UEffectModelGhost.__PropertyOffset_CustomComponentNames, this));
				}
				return result;
			}
			set
			{
				this.CustomComponentNames.CopyAssign(value);
			}
		}

		// Token: 0x17005D5C RID: 23900
		// (get) Token: 0x0601737B RID: 95099 RVA: 0x0021DD54 File Offset: 0x0021BF54
		// (set) Token: 0x0601737C RID: 95100 RVA: 0x0021DD8D File Offset: 0x0021BF8D
		public FKuroCurveFloat AlphaCurve
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._AlphaCurve) == null)
				{
					result = (this._AlphaCurve = new FKuroCurveFloat(base.NativePtr + (IntPtr)UEffectModelGhost.__PropertyOffset_AlphaCurve, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UEffectModelGhost.__PropertyOffset_AlphaCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17005D5D RID: 23901
		// (get) Token: 0x0601737D RID: 95101 RVA: 0x0021DDB0 File Offset: 0x0021BFB0
		// (set) Token: 0x0601737E RID: 95102 RVA: 0x0021DDE9 File Offset: 0x0021BFE9
		public TMap<FName, FKuroCurveFloat> FloatParameters
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FKuroCurveFloat> result;
				if ((result = this._FloatParameters) == null)
				{
					result = (this._FloatParameters = new TMap<FName, FKuroCurveFloat>(base.NativePtr + (IntPtr)UEffectModelGhost.__PropertyOffset_FloatParameters, this));
				}
				return result;
			}
			set
			{
				this.FloatParameters.CopyAssign(value);
			}
		}

		// Token: 0x17005D5E RID: 23902
		// (get) Token: 0x0601737F RID: 95103 RVA: 0x0021DDF8 File Offset: 0x0021BFF8
		// (set) Token: 0x06017380 RID: 95104 RVA: 0x0021DE31 File Offset: 0x0021C031
		public TMap<FName, FKuroCurveLinearColor> ColorParameters
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FKuroCurveLinearColor> result;
				if ((result = this._ColorParameters) == null)
				{
					result = (this._ColorParameters = new TMap<FName, FKuroCurveLinearColor>(base.NativePtr + (IntPtr)UEffectModelGhost.__PropertyOffset_ColorParameters, this));
				}
				return result;
			}
			set
			{
				this.ColorParameters.CopyAssign(value);
			}
		}

		// Token: 0x06017381 RID: 95105 RVA: 0x0021DE3F File Offset: 0x0021C03F
		static UEffectModelGhost()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.EffectModelGhost");
		}

		// Token: 0x06017382 RID: 95106 RVA: 0x0021DE4D File Offset: 0x0021C04D
		protected UEffectModelGhost(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400C97A RID: 51578
		public new const string __ObjectPath = "/Script/KuroGameplay.EffectModelGhost";

		// Token: 0x0400C97B RID: 51579
		private static IntPtr _ClassPtr;

		// Token: 0x0400C97C RID: 51580
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400C97D RID: 51581
		internal static int __PropertyOffset_MaterialRef;

		// Token: 0x0400C97E RID: 51582
		internal static int __PropertyOffset_MeshComponentsToUse;

		// Token: 0x0400C97F RID: 51583
		[Nullable(2)]
		private TArray<EEffectModelGhostCppComponent> _MeshComponentsToUse;

		// Token: 0x0400C980 RID: 51584
		internal static int __PropertyOffset_CustomComponentNames;

		// Token: 0x0400C981 RID: 51585
		[Nullable(2)]
		private TArray<FName> _CustomComponentNames;

		// Token: 0x0400C982 RID: 51586
		internal static int __PropertyOffset_AlphaCurve;

		// Token: 0x0400C983 RID: 51587
		[Nullable(2)]
		private FKuroCurveFloat _AlphaCurve;

		// Token: 0x0400C984 RID: 51588
		internal static int __PropertyOffset_FloatParameters;

		// Token: 0x0400C985 RID: 51589
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, FKuroCurveFloat> _FloatParameters;

		// Token: 0x0400C986 RID: 51590
		internal static int __PropertyOffset_ColorParameters;

		// Token: 0x0400C987 RID: 51591
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, FKuroCurveLinearColor> _ColorParameters;
	}
}
