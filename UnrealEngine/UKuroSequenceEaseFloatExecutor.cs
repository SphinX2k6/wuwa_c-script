using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200190A RID: 6410
	[UnrealObjectPath("/Script/KuroGameplay.KuroSequenceEaseFloatExecutor")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class UKuroSequenceEaseFloatExecutor : UKuroSequenceEaseExecutor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06017C88 RID: 97416 RVA: 0x0022D7A9 File Offset: 0x0022B9A9
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroSequenceEaseFloatExecutor._ClassPtr;
		}

		// Token: 0x06017C89 RID: 97417 RVA: 0x0022D7B8 File Offset: 0x0022B9B8
		public UKuroSequenceEaseFloatExecutor() : this(BuiltinUtils.AllocNativeUObject(UKuroSequenceEaseFloatExecutor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06017C8A RID: 97418 RVA: 0x0022D7E0 File Offset: 0x0022B9E0
		[NullableContext(1)]
		public UKuroSequenceEaseFloatExecutor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroSequenceEaseFloatExecutor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005FB1 RID: 24497
		// (get) Token: 0x06017C8B RID: 97419 RVA: 0x0022D813 File Offset: 0x0022BA13
		// (set) Token: 0x06017C8C RID: 97420 RVA: 0x0022D827 File Offset: 0x0022BA27
		[Nullable(2)]
		public unsafe UCurveFloat EaseCurve
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroSequenceEaseFloatExecutor.__PropertyOffset_EaseCurve);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroSequenceEaseFloatExecutor.__PropertyOffset_EaseCurve, value);
			}
		}

		// Token: 0x06017C8D RID: 97421 RVA: 0x0022D83C File Offset: 0x0022BA3C
		public float GetTargetValue()
		{
			return UKuroSequenceEaseFloatExecutor.__GetTargetValue_Internal(base.NativePtr);
		}

		// Token: 0x06017C8E RID: 97422 RVA: 0x0022D849 File Offset: 0x0022BA49
		public float GetStartValue()
		{
			return UKuroSequenceEaseFloatExecutor.__GetStartValue_Internal(base.NativePtr);
		}

		// Token: 0x06017C8F RID: 97423 RVA: 0x0022D856 File Offset: 0x0022BA56
		public float GetDuration()
		{
			return UKuroSequenceEaseFloatExecutor.__GetDuration_Internal(base.NativePtr);
		}

		// Token: 0x06017C90 RID: 97424
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetTargetValue_Internal(IntPtr @this);

		// Token: 0x06017C91 RID: 97425
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetStartValue_Internal(IntPtr @this);

		// Token: 0x06017C92 RID: 97426
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetDuration_Internal(IntPtr @this);

		// Token: 0x06017C93 RID: 97427 RVA: 0x0022D863 File Offset: 0x0022BA63
		static UKuroSequenceEaseFloatExecutor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.KuroSequenceEaseFloatExecutor");
		}

		// Token: 0x06017C94 RID: 97428 RVA: 0x0022D871 File Offset: 0x0022BA71
		protected UKuroSequenceEaseFloatExecutor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400CE65 RID: 52837
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameplay.KuroSequenceEaseFloatExecutor";

		// Token: 0x0400CE66 RID: 52838
		private static IntPtr _ClassPtr;

		// Token: 0x0400CE67 RID: 52839
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400CE68 RID: 52840
		internal static int __PropertyOffset_EaseCurve;
	}
}
