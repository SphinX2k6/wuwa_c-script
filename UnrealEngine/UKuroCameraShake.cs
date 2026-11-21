using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020002F8 RID: 760
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroAnim.KuroCameraShake")]
	[UnrealStructLayout(464, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 464)]
	public class UKuroCameraShake : UMatineeCameraShake, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600526E RID: 21102 RVA: 0x0007348E File Offset: 0x0007168E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroCameraShake._ClassPtr;
		}

		// Token: 0x0600526F RID: 21103 RVA: 0x0007349C File Offset: 0x0007169C
		public UKuroCameraShake() : this(BuiltinUtils.AllocNativeUObject(UKuroCameraShake.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06005270 RID: 21104 RVA: 0x000734C4 File Offset: 0x000716C4
		[NullableContext(1)]
		public UKuroCameraShake(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroCameraShake.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001062 RID: 4194
		// (get) Token: 0x06005271 RID: 21105 RVA: 0x000734F7 File Offset: 0x000716F7
		// (set) Token: 0x06005272 RID: 21106 RVA: 0x0007350B File Offset: 0x0007170B
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

		// Token: 0x17001063 RID: 4195
		// (get) Token: 0x06005273 RID: 21107 RVA: 0x00073520 File Offset: 0x00071720
		// (set) Token: 0x06005274 RID: 21108 RVA: 0x00073534 File Offset: 0x00071734
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

		// Token: 0x17001064 RID: 4196
		// (get) Token: 0x06005275 RID: 21109 RVA: 0x00073549 File Offset: 0x00071749
		// (set) Token: 0x06005276 RID: 21110 RVA: 0x00073562 File Offset: 0x00071762
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

		// Token: 0x17001065 RID: 4197
		// (get) Token: 0x06005277 RID: 21111 RVA: 0x00073592 File Offset: 0x00071792
		// (set) Token: 0x06005278 RID: 21112 RVA: 0x000735A6 File Offset: 0x000717A6
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

		// Token: 0x06005279 RID: 21113 RVA: 0x000735BB File Offset: 0x000717BB
		static UKuroCameraShake()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroAnim.KuroCameraShake");
		}

		// Token: 0x0600527A RID: 21114 RVA: 0x000735C9 File Offset: 0x000717C9
		protected UKuroCameraShake(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400218F RID: 8591
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroAnim.KuroCameraShake";

		// Token: 0x04002190 RID: 8592
		private static IntPtr _ClassPtr;

		// Token: 0x04002191 RID: 8593
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04002192 RID: 8594
		internal static int __PropertyOffset_BlendInCustomCurve;

		// Token: 0x04002193 RID: 8595
		internal static int __PropertyOffset_BlendOutCustomCurve;

		// Token: 0x04002194 RID: 8596
		internal static int __PropertyOffset_bIsUseCurveVector;

		// Token: 0x04002195 RID: 8597
		internal static byte __PropertyMask_bIsUseCurveVector;

		// Token: 0x04002196 RID: 8598
		internal static int __PropertyOffset_BlendCurveVector;
	}
}
