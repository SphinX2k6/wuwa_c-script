using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006FB RID: 1787
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UIEffectTextAnimation")]
	[UnrealStructLayout(304, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 304)]
	public class UUIEffectTextAnimation : UUIGeometryModifierBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06009838 RID: 38968 RVA: 0x000E544F File Offset: 0x000E364F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIEffectTextAnimation._ClassPtr;
		}

		// Token: 0x06009839 RID: 38969 RVA: 0x000E545C File Offset: 0x000E365C
		public UUIEffectTextAnimation() : this(BuiltinUtils.AllocNativeUObject(UUIEffectTextAnimation.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600983A RID: 38970 RVA: 0x000E5484 File Offset: 0x000E3684
		[NullableContext(1)]
		public UUIEffectTextAnimation(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUIEffectTextAnimation.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001C44 RID: 7236
		// (get) Token: 0x0600983B RID: 38971 RVA: 0x000E54B7 File Offset: 0x000E36B7
		// (set) Token: 0x0600983C RID: 38972 RVA: 0x000E54CB File Offset: 0x000E36CB
		public unsafe UUIEffectTextAnimation_Selector selector
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UUIEffectTextAnimation_Selector>(base.NativePtr / (IntPtr)sizeof(void*) + UUIEffectTextAnimation.__PropertyOffset_selector);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UUIEffectTextAnimation.__PropertyOffset_selector, value);
			}
		}

		// Token: 0x17001C45 RID: 7237
		// (get) Token: 0x0600983D RID: 38973 RVA: 0x000E54E0 File Offset: 0x000E36E0
		// (set) Token: 0x0600983E RID: 38974 RVA: 0x000E54F4 File Offset: 0x000E36F4
		public unsafe UUIItem textTargetObject
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UUIItem>(base.NativePtr / (IntPtr)sizeof(void*) + UUIEffectTextAnimation.__PropertyOffset_textTargetObject);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UUIEffectTextAnimation.__PropertyOffset_textTargetObject, value);
			}
		}

		// Token: 0x0600983F RID: 38975 RVA: 0x000E5509 File Offset: 0x000E3709
		public void SetSelectorOffset(float value)
		{
			UUIEffectTextAnimation.__SetSelectorOffset_Internal(base.NativePtr, value);
		}

		// Token: 0x06009840 RID: 38976 RVA: 0x000E5517 File Offset: 0x000E3717
		public void SetSelector(UUIEffectTextAnimation_Selector value)
		{
			UUIEffectTextAnimation.__SetSelector_Internal(base.NativePtr, (value != null) ? value.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06009841 RID: 38977 RVA: 0x000E5534 File Offset: 0x000E3734
		public float GetSelectorOffset()
		{
			return UUIEffectTextAnimation.__GetSelectorOffset_Internal(base.NativePtr);
		}

		// Token: 0x06009842 RID: 38978 RVA: 0x000E5541 File Offset: 0x000E3741
		public UUIEffectTextAnimation_Selector GetSelector()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UUIEffectTextAnimation_Selector>(UUIEffectTextAnimation.__GetSelector_Internal(base.NativePtr));
		}

		// Token: 0x06009843 RID: 38979
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSelectorOffset_Internal(IntPtr @this, float value);

		// Token: 0x06009844 RID: 38980
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSelector_Internal(IntPtr @this, IntPtr value);

		// Token: 0x06009845 RID: 38981
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetSelectorOffset_Internal(IntPtr @this);

		// Token: 0x06009846 RID: 38982
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetSelector_Internal(IntPtr @this);

		// Token: 0x06009847 RID: 38983 RVA: 0x000E5553 File Offset: 0x000E3753
		static UUIEffectTextAnimation()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIEffectTextAnimation");
		}

		// Token: 0x06009848 RID: 38984 RVA: 0x000E5561 File Offset: 0x000E3761
		protected UUIEffectTextAnimation(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04004222 RID: 16930
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UIEffectTextAnimation";

		// Token: 0x04004223 RID: 16931
		private static IntPtr _ClassPtr;

		// Token: 0x04004224 RID: 16932
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04004225 RID: 16933
		internal static int __PropertyOffset_selector;

		// Token: 0x04004226 RID: 16934
		internal static int __PropertyOffset_textTargetObject;
	}
}
