using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001AA8 RID: 6824
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroANSCurveTrailDecal")]
	[UnrealStructLayout(160, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 160)]
	public class UKuroANSCurveTrailDecal : UKuroAnimNotifyState, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601943A RID: 103482 RVA: 0x00255D0D File Offset: 0x00253F0D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroANSCurveTrailDecal._ClassPtr;
		}

		// Token: 0x0601943B RID: 103483 RVA: 0x00255D1C File Offset: 0x00253F1C
		public UKuroANSCurveTrailDecal() : this(BuiltinUtils.AllocNativeUObject(UKuroANSCurveTrailDecal.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601943C RID: 103484 RVA: 0x00255D44 File Offset: 0x00253F44
		[NullableContext(1)]
		public UKuroANSCurveTrailDecal(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroANSCurveTrailDecal.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170064B3 RID: 25779
		// (get) Token: 0x0601943D RID: 103485 RVA: 0x00255D77 File Offset: 0x00253F77
		// (set) Token: 0x0601943E RID: 103486 RVA: 0x00255D8B File Offset: 0x00253F8B
		public unsafe FName AttachSocketName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroANSCurveTrailDecal.__PropertyOffset_AttachSocketName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroANSCurveTrailDecal.__PropertyOffset_AttachSocketName) = value;
			}
		}

		// Token: 0x170064B4 RID: 25780
		// (get) Token: 0x0601943F RID: 103487 RVA: 0x00255DA0 File Offset: 0x00253FA0
		// (set) Token: 0x06019440 RID: 103488 RVA: 0x00255DB4 File Offset: 0x00253FB4
		public unsafe FTransform AttachTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroANSCurveTrailDecal.__PropertyOffset_AttachTransform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroANSCurveTrailDecal.__PropertyOffset_AttachTransform) = value;
			}
		}

		// Token: 0x170064B5 RID: 25781
		// (get) Token: 0x06019441 RID: 103489 RVA: 0x00255DC9 File Offset: 0x00253FC9
		// (set) Token: 0x06019442 RID: 103490 RVA: 0x00255DDD File Offset: 0x00253FDD
		[Nullable(2)]
		public unsafe UKuroCurveTrailDecalConfig Config
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroCurveTrailDecalConfig>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroANSCurveTrailDecal.__PropertyOffset_Config);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroANSCurveTrailDecal.__PropertyOffset_Config, value);
			}
		}

		// Token: 0x06019443 RID: 103491 RVA: 0x00255DF2 File Offset: 0x00253FF2
		static UKuroANSCurveTrailDecal()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroANSCurveTrailDecal");
		}

		// Token: 0x06019444 RID: 103492 RVA: 0x00255E00 File Offset: 0x00254000
		protected UKuroANSCurveTrailDecal(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400DC70 RID: 56432
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroANSCurveTrailDecal";

		// Token: 0x0400DC71 RID: 56433
		private static IntPtr _ClassPtr;

		// Token: 0x0400DC72 RID: 56434
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400DC73 RID: 56435
		internal static int __PropertyOffset_AttachSocketName;

		// Token: 0x0400DC74 RID: 56436
		internal static int __PropertyOffset_AttachTransform;

		// Token: 0x0400DC75 RID: 56437
		internal static int __PropertyOffset_Config;
	}
}
