using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001AF6 RID: 6902
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroFlickerLightPreset")]
	[UnrealStructLayout(240, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 240)]
	public class UKuroFlickerLightPreset : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06019CAC RID: 105644 RVA: 0x00261815 File Offset: 0x0025FA15
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroFlickerLightPreset._ClassPtr;
		}

		// Token: 0x06019CAD RID: 105645 RVA: 0x00261824 File Offset: 0x0025FA24
		public UKuroFlickerLightPreset() : this(BuiltinUtils.AllocNativeUObject(UKuroFlickerLightPreset.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06019CAE RID: 105646 RVA: 0x0026184C File Offset: 0x0025FA4C
		public UKuroFlickerLightPreset(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroFlickerLightPreset.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006734 RID: 26420
		// (get) Token: 0x06019CAF RID: 105647 RVA: 0x0026187F File Offset: 0x0025FA7F
		// (set) Token: 0x06019CB0 RID: 105648 RVA: 0x0026188F File Offset: 0x0025FA8F
		public unsafe float BaseIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroFlickerLightPreset.__PropertyOffset_BaseIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroFlickerLightPreset.__PropertyOffset_BaseIntensity) = value;
			}
		}

		// Token: 0x17006735 RID: 26421
		// (get) Token: 0x06019CB1 RID: 105649 RVA: 0x002618A0 File Offset: 0x0025FAA0
		// (set) Token: 0x06019CB2 RID: 105650 RVA: 0x002618D9 File Offset: 0x0025FAD9
		public FKuroCurveFloat IntensityCurve
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCurveFloat result;
				if ((result = this._IntensityCurve) == null)
				{
					result = (this._IntensityCurve = new FKuroCurveFloat(base.NativePtr + (IntPtr)UKuroFlickerLightPreset.__PropertyOffset_IntensityCurve, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)UKuroFlickerLightPreset.__PropertyOffset_IntensityCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006736 RID: 26422
		// (get) Token: 0x06019CB3 RID: 105651 RVA: 0x002618FA File Offset: 0x0025FAFA
		// (set) Token: 0x06019CB4 RID: 105652 RVA: 0x0026190A File Offset: 0x0025FB0A
		public unsafe float FlickSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroFlickerLightPreset.__PropertyOffset_FlickSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroFlickerLightPreset.__PropertyOffset_FlickSpeed) = value;
			}
		}

		// Token: 0x06019CB5 RID: 105653 RVA: 0x0026191B File Offset: 0x0025FB1B
		static UKuroFlickerLightPreset()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroFlickerLightPreset");
		}

		// Token: 0x06019CB6 RID: 105654 RVA: 0x00261929 File Offset: 0x0025FB29
		protected UKuroFlickerLightPreset(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400E06C RID: 57452
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroFlickerLightPreset";

		// Token: 0x0400E06D RID: 57453
		private static IntPtr _ClassPtr;

		// Token: 0x0400E06E RID: 57454
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400E06F RID: 57455
		internal static int __PropertyOffset_BaseIntensity;

		// Token: 0x0400E070 RID: 57456
		internal static int __PropertyOffset_IntensityCurve;

		// Token: 0x0400E071 RID: 57457
		[Nullable(2)]
		private FKuroCurveFloat _IntensityCurve;

		// Token: 0x0400E072 RID: 57458
		internal static int __PropertyOffset_FlickSpeed;
	}
}
