using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002157 RID: 8535
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UIEffectTextAnimation_PropertyWithEase")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public abstract class UUIEffectTextAnimation_PropertyWithEase : UUIEffectTextAnimation_Property, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060202ED RID: 131821 RVA: 0x002FD071 File Offset: 0x002FB271
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIEffectTextAnimation_PropertyWithEase._ClassPtr;
		}

		// Token: 0x17007E44 RID: 32324
		// (get) Token: 0x060202EE RID: 131822 RVA: 0x002FD07D File Offset: 0x002FB27D
		// (set) Token: 0x060202EF RID: 131823 RVA: 0x002FD08D File Offset: 0x002FB28D
		public unsafe LTweenEase easeType
		{
			get
			{
				return (LTweenEase)(*(base.NativePtr + (IntPtr)UUIEffectTextAnimation_PropertyWithEase.__PropertyOffset_easeType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIEffectTextAnimation_PropertyWithEase.__PropertyOffset_easeType) = (byte)value;
			}
		}

		// Token: 0x17007E45 RID: 32325
		// (get) Token: 0x060202F0 RID: 131824 RVA: 0x002FD09E File Offset: 0x002FB29E
		// (set) Token: 0x060202F1 RID: 131825 RVA: 0x002FD0B2 File Offset: 0x002FB2B2
		public unsafe UCurveFloat easeCurve
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + UUIEffectTextAnimation_PropertyWithEase.__PropertyOffset_easeCurve);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UUIEffectTextAnimation_PropertyWithEase.__PropertyOffset_easeCurve, value);
			}
		}

		// Token: 0x060202F2 RID: 131826 RVA: 0x002FD0C7 File Offset: 0x002FB2C7
		public void SetEaseType(LTweenEase value)
		{
			UUIEffectTextAnimation_PropertyWithEase.__SetEaseType_Internal(base.NativePtr, value);
		}

		// Token: 0x060202F3 RID: 131827 RVA: 0x002FD0D5 File Offset: 0x002FB2D5
		public void SetEaseCurve(UCurveFloat value)
		{
			UUIEffectTextAnimation_PropertyWithEase.__SetEaseCurve_Internal(base.NativePtr, (value != null) ? value.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060202F4 RID: 131828 RVA: 0x002FD0F2 File Offset: 0x002FB2F2
		public LTweenEase GetEaseType()
		{
			return UUIEffectTextAnimation_PropertyWithEase.__GetEaseType_Internal(base.NativePtr);
		}

		// Token: 0x060202F5 RID: 131829 RVA: 0x002FD0FF File Offset: 0x002FB2FF
		public UCurveFloat GetCurveFloat()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UCurveFloat>(UUIEffectTextAnimation_PropertyWithEase.__GetCurveFloat_Internal(base.NativePtr));
		}

		// Token: 0x060202F6 RID: 131830
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetEaseType_Internal(IntPtr @this, LTweenEase value);

		// Token: 0x060202F7 RID: 131831
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetEaseCurve_Internal(IntPtr @this, IntPtr value);

		// Token: 0x060202F8 RID: 131832
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern LTweenEase __GetEaseType_Internal(IntPtr @this);

		// Token: 0x060202F9 RID: 131833
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetCurveFloat_Internal(IntPtr @this);

		// Token: 0x060202FA RID: 131834 RVA: 0x002FD111 File Offset: 0x002FB311
		static UUIEffectTextAnimation_PropertyWithEase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIEffectTextAnimation_PropertyWithEase");
		}

		// Token: 0x060202FB RID: 131835 RVA: 0x002FD120 File Offset: 0x002FB320
		protected UUIEffectTextAnimation_PropertyWithEase() : this(BuiltinUtils.AllocNativeUObject(UUIEffectTextAnimation_PropertyWithEase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060202FC RID: 131836 RVA: 0x002FD148 File Offset: 0x002FB348
		protected UUIEffectTextAnimation_PropertyWithEase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040114D7 RID: 70871
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UIEffectTextAnimation_PropertyWithEase";

		// Token: 0x040114D8 RID: 70872
		private static IntPtr _ClassPtr;

		// Token: 0x040114D9 RID: 70873
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040114DA RID: 70874
		internal static int __PropertyOffset_easeType;

		// Token: 0x040114DB RID: 70875
		internal static int __PropertyOffset_easeCurve;
	}
}
