using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020018AA RID: 6314
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplay.EffectModelSequencePose")]
	[UnrealStructLayout(400, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 400)]
	public class UEffectModelSequencePose : UEffectModelBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06017599 RID: 95641 RVA: 0x00221F95 File Offset: 0x00220195
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UEffectModelSequencePose._ClassPtr;
		}

		// Token: 0x0601759A RID: 95642 RVA: 0x00221FA4 File Offset: 0x002201A4
		public UEffectModelSequencePose() : this(BuiltinUtils.AllocNativeUObject(UEffectModelSequencePose.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601759B RID: 95643 RVA: 0x00221FCC File Offset: 0x002201CC
		public UEffectModelSequencePose(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UEffectModelSequencePose.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005E52 RID: 24146
		// (get) Token: 0x0601759C RID: 95644 RVA: 0x00221FFF File Offset: 0x002201FF
		// (set) Token: 0x0601759D RID: 95645 RVA: 0x0022200F File Offset: 0x0022020F
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

		// Token: 0x17005E53 RID: 24147
		// (get) Token: 0x0601759E RID: 95646 RVA: 0x00222020 File Offset: 0x00220220
		// (set) Token: 0x0601759F RID: 95647 RVA: 0x00222034 File Offset: 0x00220234
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

		// Token: 0x17005E54 RID: 24148
		// (get) Token: 0x060175A0 RID: 95648 RVA: 0x00222049 File Offset: 0x00220249
		// (set) Token: 0x060175A1 RID: 95649 RVA: 0x00222059 File Offset: 0x00220259
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

		// Token: 0x17005E55 RID: 24149
		// (get) Token: 0x060175A2 RID: 95650 RVA: 0x0022206A File Offset: 0x0022026A
		// (set) Token: 0x060175A3 RID: 95651 RVA: 0x0022207A File Offset: 0x0022027A
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

		// Token: 0x17005E56 RID: 24150
		// (get) Token: 0x060175A4 RID: 95652 RVA: 0x0022208C File Offset: 0x0022028C
		// (set) Token: 0x060175A5 RID: 95653 RVA: 0x002220C5 File Offset: 0x002202C5
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

		// Token: 0x17005E57 RID: 24151
		// (get) Token: 0x060175A6 RID: 95654 RVA: 0x002220D4 File Offset: 0x002202D4
		// (set) Token: 0x060175A7 RID: 95655 RVA: 0x0022210D File Offset: 0x0022030D
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

		// Token: 0x17005E58 RID: 24152
		// (get) Token: 0x060175A8 RID: 95656 RVA: 0x0022211C File Offset: 0x0022031C
		// (set) Token: 0x060175A9 RID: 95657 RVA: 0x00222155 File Offset: 0x00220355
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

		// Token: 0x17005E59 RID: 24153
		// (get) Token: 0x060175AA RID: 95658 RVA: 0x00222163 File Offset: 0x00220363
		// (set) Token: 0x060175AB RID: 95659 RVA: 0x00222173 File Offset: 0x00220373
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

		// Token: 0x060175AC RID: 95660 RVA: 0x00222184 File Offset: 0x00220384
		static UEffectModelSequencePose()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.EffectModelSequencePose");
		}

		// Token: 0x060175AD RID: 95661 RVA: 0x00222192 File Offset: 0x00220392
		protected UEffectModelSequencePose(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400CB16 RID: 51990
		public new const string __ObjectPath = "/Script/KuroGameplay.EffectModelSequencePose";

		// Token: 0x0400CB17 RID: 51991
		private static IntPtr _ClassPtr;

		// Token: 0x0400CB18 RID: 51992
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400CB19 RID: 51993
		internal static int __PropertyOffset_SequenceTimeRange;

		// Token: 0x0400CB1A RID: 51994
		internal static int __PropertyOffset_DefaultMaterialToUse;

		// Token: 0x0400CB1B RID: 51995
		internal static int __PropertyOffset_bIncludeOutline;

		// Token: 0x0400CB1C RID: 51996
		internal static int __PropertyOffset_bAutoSetCharacterTexture;

		// Token: 0x0400CB1D RID: 51997
		internal static int __PropertyOffset_ExtraMaterialsToUse;

		// Token: 0x0400CB1E RID: 51998
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<string, UMaterialInterface> _ExtraMaterialsToUse;

		// Token: 0x0400CB1F RID: 51999
		internal static int __PropertyOffset_FloatParametersCurve;

		// Token: 0x0400CB20 RID: 52000
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, FKuroCurveFloat> _FloatParametersCurve;

		// Token: 0x0400CB21 RID: 52001
		internal static int __PropertyOffset_ColorParametersCurve;

		// Token: 0x0400CB22 RID: 52002
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, FKuroCurveLinearColor> _ColorParametersCurve;

		// Token: 0x0400CB23 RID: 52003
		internal static int __PropertyOffset_MaxPose;
	}
}
