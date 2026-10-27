using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001660 RID: 5728
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroAnim.KuroCameraShake")]
	[UnrealStructLayout(464, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 464)]
	public class UKuroCameraShake : UMatineeCameraShake, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06014BF6 RID: 84982 RVA: 0x001E82BE File Offset: 0x001E64BE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroCameraShake._ClassPtr;
		}

		// Token: 0x06014BF7 RID: 84983 RVA: 0x001E82CC File Offset: 0x001E64CC
		public UKuroCameraShake() : this(BuiltinUtils.AllocNativeUObject(UKuroCameraShake.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06014BF8 RID: 84984 RVA: 0x001E82F4 File Offset: 0x001E64F4
		[NullableContext(1)]
		public UKuroCameraShake(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroCameraShake.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005208 RID: 21000
		// (get) Token: 0x06014BF9 RID: 84985 RVA: 0x001E8327 File Offset: 0x001E6527
		// (set) Token: 0x06014BFA RID: 84986 RVA: 0x001E8337 File Offset: 0x001E6537
		public unsafe EAlphaBlendOption BlendInMode
		{
			get
			{
				return (EAlphaBlendOption)(*(base.NativePtr + (IntPtr)UKuroCameraShake.__PropertyOffset_BlendInMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCameraShake.__PropertyOffset_BlendInMode) = (byte)value;
			}
		}

		// Token: 0x17005209 RID: 21001
		// (get) Token: 0x06014BFB RID: 84987 RVA: 0x001E8348 File Offset: 0x001E6548
		// (set) Token: 0x06014BFC RID: 84988 RVA: 0x001E835C File Offset: 0x001E655C
		public unsafe UCurveFloat BlendInCustomCurve
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroCameraShake.__PropertyOffset_BlendInCustomCurve);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroCameraShake.__PropertyOffset_BlendInCustomCurve, value);
			}
		}

		// Token: 0x1700520A RID: 21002
		// (get) Token: 0x06014BFD RID: 84989 RVA: 0x001E8371 File Offset: 0x001E6571
		// (set) Token: 0x06014BFE RID: 84990 RVA: 0x001E8381 File Offset: 0x001E6581
		public unsafe EAlphaBlendOption BlendOutMode
		{
			get
			{
				return (EAlphaBlendOption)(*(base.NativePtr + (IntPtr)UKuroCameraShake.__PropertyOffset_BlendOutMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCameraShake.__PropertyOffset_BlendOutMode) = (byte)value;
			}
		}

		// Token: 0x1700520B RID: 21003
		// (get) Token: 0x06014BFF RID: 84991 RVA: 0x001E8392 File Offset: 0x001E6592
		// (set) Token: 0x06014C00 RID: 84992 RVA: 0x001E83A6 File Offset: 0x001E65A6
		public unsafe UCurveFloat BlendOutCustomCurve
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroCameraShake.__PropertyOffset_BlendOutCustomCurve);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroCameraShake.__PropertyOffset_BlendOutCustomCurve, value);
			}
		}

		// Token: 0x1700520C RID: 21004
		// (get) Token: 0x06014C01 RID: 84993 RVA: 0x001E83BB File Offset: 0x001E65BB
		// (set) Token: 0x06014C02 RID: 84994 RVA: 0x001E83D4 File Offset: 0x001E65D4
		public unsafe bool bIsUseCurveVector
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UKuroCameraShake.__PropertyOffset_bIsUseCurveVector) & UKuroCameraShake.__PropertyMask_bIsUseCurveVector) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UKuroCameraShake.__PropertyOffset_bIsUseCurveVector) = ((*(base.NativePtr + (IntPtr)UKuroCameraShake.__PropertyOffset_bIsUseCurveVector) & ~UKuroCameraShake.__PropertyMask_bIsUseCurveVector) | (value ? UKuroCameraShake.__PropertyMask_bIsUseCurveVector : 0));
			}
		}

		// Token: 0x1700520D RID: 21005
		// (get) Token: 0x06014C03 RID: 84995 RVA: 0x001E8404 File Offset: 0x001E6604
		// (set) Token: 0x06014C04 RID: 84996 RVA: 0x001E8418 File Offset: 0x001E6618
		public unsafe UCurveVector BlendCurveVector
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveVector>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroCameraShake.__PropertyOffset_BlendCurveVector);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroCameraShake.__PropertyOffset_BlendCurveVector, value);
			}
		}

		// Token: 0x06014C05 RID: 84997 RVA: 0x001E842D File Offset: 0x001E662D
		static UKuroCameraShake()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroAnim.KuroCameraShake");
		}

		// Token: 0x06014C06 RID: 84998 RVA: 0x001E843B File Offset: 0x001E663B
		protected UKuroCameraShake(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400B4F6 RID: 46326
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroAnim.KuroCameraShake";

		// Token: 0x0400B4F7 RID: 46327
		private static IntPtr _ClassPtr;

		// Token: 0x0400B4F8 RID: 46328
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400B4F9 RID: 46329
		internal static int __PropertyOffset_BlendInMode;

		// Token: 0x0400B4FA RID: 46330
		internal static int __PropertyOffset_BlendInCustomCurve;

		// Token: 0x0400B4FB RID: 46331
		internal static int __PropertyOffset_BlendOutMode;

		// Token: 0x0400B4FC RID: 46332
		internal static int __PropertyOffset_BlendOutCustomCurve;

		// Token: 0x0400B4FD RID: 46333
		internal static int __PropertyOffset_bIsUseCurveVector;

		// Token: 0x0400B4FE RID: 46334
		internal static byte __PropertyMask_bIsUseCurveVector;

		// Token: 0x0400B4FF RID: 46335
		internal static int __PropertyOffset_BlendCurveVector;
	}
}
