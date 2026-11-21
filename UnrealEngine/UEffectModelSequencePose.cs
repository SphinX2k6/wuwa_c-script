using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003CC RID: 972
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplay.EffectModelSequencePose")]
	[UnrealStructLayout(400, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 400)]
	public class UEffectModelSequencePose : UEffectModelBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600602A RID: 24618 RVA: 0x00089151 File Offset: 0x00087351
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UEffectModelSequencePose._ClassPtr;
		}

		// Token: 0x0600602B RID: 24619 RVA: 0x00089160 File Offset: 0x00087360
		public UEffectModelSequencePose() : this(BuiltinUtils.AllocNativeUObject(UEffectModelSequencePose.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600602C RID: 24620 RVA: 0x00089188 File Offset: 0x00087388
		public UEffectModelSequencePose(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UEffectModelSequencePose.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700138C RID: 5004
		// (get) Token: 0x0600602D RID: 24621 RVA: 0x000891BB File Offset: 0x000873BB
		// (set) Token: 0x0600602E RID: 24622 RVA: 0x000891CB File Offset: 0x000873CB
		public unsafe float SequenceTimeRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelSequencePose.__PropertyOffset_SequenceTimeRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelSequencePose.__PropertyOffset_SequenceTimeRange) = value;
			}
		}

		// Token: 0x1700138D RID: 5005
		// (get) Token: 0x0600602F RID: 24623 RVA: 0x000891DC File Offset: 0x000873DC
		// (set) Token: 0x06006030 RID: 24624 RVA: 0x000891F0 File Offset: 0x000873F0
		[Nullable(2)]
		public unsafe UMaterialInterface DefaultMaterialToUse
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + UEffectModelSequencePose.__PropertyOffset_DefaultMaterialToUse);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UEffectModelSequencePose.__PropertyOffset_DefaultMaterialToUse, value);
			}
		}

		// Token: 0x1700138E RID: 5006
		// (get) Token: 0x06006031 RID: 24625 RVA: 0x00089205 File Offset: 0x00087405
		// (set) Token: 0x06006032 RID: 24626 RVA: 0x00089215 File Offset: 0x00087415
		public unsafe bool bIncludeOutline
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelSequencePose.__PropertyOffset_bIncludeOutline) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelSequencePose.__PropertyOffset_bIncludeOutline) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700138F RID: 5007
		// (get) Token: 0x06006033 RID: 24627 RVA: 0x00089226 File Offset: 0x00087426
		// (set) Token: 0x06006034 RID: 24628 RVA: 0x00089236 File Offset: 0x00087436
		public unsafe bool bAutoSetCharacterTexture
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelSequencePose.__PropertyOffset_bAutoSetCharacterTexture) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelSequencePose.__PropertyOffset_bAutoSetCharacterTexture) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001390 RID: 5008
		// (get) Token: 0x06006035 RID: 24629 RVA: 0x00089248 File Offset: 0x00087448
		// (set) Token: 0x06006036 RID: 24630 RVA: 0x00089281 File Offset: 0x00087481
		public TMap<string, UMaterialInterface> ExtraMaterialsToUse
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, UMaterialInterface> result;
				if ((result = this._ExtraMaterialsToUse) == null)
				{
					result = (this._ExtraMaterialsToUse = new TMap<string, UMaterialInterface>(base.NativePtr + (IntPtr)UEffectModelSequencePose.__PropertyOffset_ExtraMaterialsToUse, this));
				}
				return result;
			}
			set
			{
				this.ExtraMaterialsToUse.CopyAssign(value);
			}
		}

		// Token: 0x17001391 RID: 5009
		// (get) Token: 0x06006037 RID: 24631 RVA: 0x00089290 File Offset: 0x00087490
		// (set) Token: 0x06006038 RID: 24632 RVA: 0x000892C9 File Offset: 0x000874C9
		public TMap<FName, FKuroCurveFloat> FloatParametersCurve
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FKuroCurveFloat> result;
				if ((result = this._FloatParametersCurve) == null)
				{
					result = (this._FloatParametersCurve = new TMap<FName, FKuroCurveFloat>(base.NativePtr + (IntPtr)UEffectModelSequencePose.__PropertyOffset_FloatParametersCurve, this));
				}
				return result;
			}
			set
			{
				this.FloatParametersCurve.CopyAssign(value);
			}
		}

		// Token: 0x17001392 RID: 5010
		// (get) Token: 0x06006039 RID: 24633 RVA: 0x000892D8 File Offset: 0x000874D8
		// (set) Token: 0x0600603A RID: 24634 RVA: 0x00089311 File Offset: 0x00087511
		public TMap<FName, FKuroCurveLinearColor> ColorParametersCurve
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FKuroCurveLinearColor> result;
				if ((result = this._ColorParametersCurve) == null)
				{
					result = (this._ColorParametersCurve = new TMap<FName, FKuroCurveLinearColor>(base.NativePtr + (IntPtr)UEffectModelSequencePose.__PropertyOffset_ColorParametersCurve, this));
				}
				return result;
			}
			set
			{
				this.ColorParametersCurve.CopyAssign(value);
			}
		}

		// Token: 0x17001393 RID: 5011
		// (get) Token: 0x0600603B RID: 24635 RVA: 0x0008931F File Offset: 0x0008751F
		// (set) Token: 0x0600603C RID: 24636 RVA: 0x0008932F File Offset: 0x0008752F
		public unsafe int MaxPose
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelSequencePose.__PropertyOffset_MaxPose);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelSequencePose.__PropertyOffset_MaxPose) = value;
			}
		}

		// Token: 0x0600603D RID: 24637 RVA: 0x00089340 File Offset: 0x00087540
		static UEffectModelSequencePose()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.EffectModelSequencePose");
		}

		// Token: 0x0600603E RID: 24638 RVA: 0x0008934E File Offset: 0x0008754E
		protected UEffectModelSequencePose(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040028D4 RID: 10452
		public new const string __ObjectPath = "/Script/KuroGameplay.EffectModelSequencePose";

		// Token: 0x040028D5 RID: 10453
		private static IntPtr _ClassPtr;

		// Token: 0x040028D6 RID: 10454
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040028D7 RID: 10455
		internal static int __PropertyOffset_SequenceTimeRange;

		// Token: 0x040028D8 RID: 10456
		internal static int __PropertyOffset_DefaultMaterialToUse;

		// Token: 0x040028D9 RID: 10457
		internal static int __PropertyOffset_bIncludeOutline;

		// Token: 0x040028DA RID: 10458
		internal static int __PropertyOffset_bAutoSetCharacterTexture;

		// Token: 0x040028DB RID: 10459
		internal static int __PropertyOffset_ExtraMaterialsToUse;

		// Token: 0x040028DC RID: 10460
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<string, UMaterialInterface> _ExtraMaterialsToUse;

		// Token: 0x040028DD RID: 10461
		internal static int __PropertyOffset_FloatParametersCurve;

		// Token: 0x040028DE RID: 10462
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, FKuroCurveFloat> _FloatParametersCurve;

		// Token: 0x040028DF RID: 10463
		internal static int __PropertyOffset_ColorParametersCurve;

		// Token: 0x040028E0 RID: 10464
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, FKuroCurveLinearColor> _ColorParametersCurve;

		// Token: 0x040028E1 RID: 10465
		internal static int __PropertyOffset_MaxPose;
	}
}
