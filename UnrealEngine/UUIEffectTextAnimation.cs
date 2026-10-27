using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200214F RID: 8527
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UIEffectTextAnimation")]
	[UnrealStructLayout(304, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 304)]
	public class UUIEffectTextAnimation : UUIGeometryModifierBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020260 RID: 131680 RVA: 0x002FC7D3 File Offset: 0x002FA9D3
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIEffectTextAnimation._ClassPtr;
		}

		// Token: 0x06020261 RID: 131681 RVA: 0x002FC7E0 File Offset: 0x002FA9E0
		public UUIEffectTextAnimation() : this(BuiltinUtils.AllocNativeUObject(UUIEffectTextAnimation.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020262 RID: 131682 RVA: 0x002FC808 File Offset: 0x002FAA08
		[NullableContext(1)]
		public UUIEffectTextAnimation(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUIEffectTextAnimation.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007E31 RID: 32305
		// (get) Token: 0x06020263 RID: 131683 RVA: 0x002FC83B File Offset: 0x002FAA3B
		// (set) Token: 0x06020264 RID: 131684 RVA: 0x002FC84F File Offset: 0x002FAA4F
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

		// Token: 0x17007E32 RID: 32306
		// (get) Token: 0x06020265 RID: 131685 RVA: 0x002FC864 File Offset: 0x002FAA64
		// (set) Token: 0x06020266 RID: 131686 RVA: 0x002FC89D File Offset: 0x002FAA9D
		[Nullable(1)]
		public TArray<UUIEffectTextAnimation_Property> properties
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UUIEffectTextAnimation_Property> result;
				if ((result = this._properties) == null)
				{
					result = (this._properties = new TArray<UUIEffectTextAnimation_Property>(base.NativePtr + (IntPtr)UUIEffectTextAnimation.__PropertyOffset_properties, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.properties.CopyAssign(value);
			}
		}

		// Token: 0x17007E33 RID: 32307
		// (get) Token: 0x06020267 RID: 131687 RVA: 0x002FC8AB File Offset: 0x002FAAAB
		// (set) Token: 0x06020268 RID: 131688 RVA: 0x002FC8BF File Offset: 0x002FAABF
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

		// Token: 0x06020269 RID: 131689 RVA: 0x002FC8D4 File Offset: 0x002FAAD4
		public void SetSelectorOffset(float value)
		{
			UUIEffectTextAnimation.__SetSelectorOffset_Internal(base.NativePtr, value);
		}

		// Token: 0x0602026A RID: 131690 RVA: 0x002FC8E2 File Offset: 0x002FAAE2
		public void SetSelector(UUIEffectTextAnimation_Selector value)
		{
			UUIEffectTextAnimation.__SetSelector_Internal(base.NativePtr, (value != null) ? value.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0602026B RID: 131691 RVA: 0x002FC8FF File Offset: 0x002FAAFF
		public void SetProperty(int index, UUIEffectTextAnimation_Property value)
		{
			UUIEffectTextAnimation.__SetProperty_Internal(base.NativePtr, index, (value != null) ? value.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0602026C RID: 131692 RVA: 0x002FC91D File Offset: 0x002FAB1D
		public void SetProperties([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<UUIEffectTextAnimation_Property> value)
		{
			UUIEffectTextAnimation.__SetProperties_Internal(base.NativePtr, (value ?? new TArray<UUIEffectTextAnimation_Property>()).NativePtr);
		}

		// Token: 0x0602026D RID: 131693 RVA: 0x002FC93A File Offset: 0x002FAB3A
		public float GetSelectorOffset()
		{
			return UUIEffectTextAnimation.__GetSelectorOffset_Internal(base.NativePtr);
		}

		// Token: 0x0602026E RID: 131694 RVA: 0x002FC947 File Offset: 0x002FAB47
		public UUIEffectTextAnimation_Selector GetSelector()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UUIEffectTextAnimation_Selector>(UUIEffectTextAnimation.__GetSelector_Internal(base.NativePtr));
		}

		// Token: 0x0602026F RID: 131695 RVA: 0x002FC959 File Offset: 0x002FAB59
		public UUIEffectTextAnimation_Property GetProperty(int index)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UUIEffectTextAnimation_Property>(UUIEffectTextAnimation.__GetProperty_Internal(base.NativePtr, index));
		}

		// Token: 0x06020270 RID: 131696 RVA: 0x002FC96C File Offset: 0x002FAB6C
		[NullableContext(1)]
		public TArray<UUIEffectTextAnimation_Property> GetProperties()
		{
			return new TArray<UUIEffectTextAnimation_Property>(UUIEffectTextAnimation.__GetProperties_Internal(base.NativePtr), null);
		}

		// Token: 0x06020271 RID: 131697
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSelectorOffset_Internal(IntPtr @this, float value);

		// Token: 0x06020272 RID: 131698
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSelector_Internal(IntPtr @this, IntPtr value);

		// Token: 0x06020273 RID: 131699
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetProperty_Internal(IntPtr @this, int index, IntPtr value);

		// Token: 0x06020274 RID: 131700
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetProperties_Internal(IntPtr @this, IntPtr value);

		// Token: 0x06020275 RID: 131701
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetSelectorOffset_Internal(IntPtr @this);

		// Token: 0x06020276 RID: 131702
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetSelector_Internal(IntPtr @this);

		// Token: 0x06020277 RID: 131703
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetProperty_Internal(IntPtr @this, int index);

		// Token: 0x06020278 RID: 131704
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetProperties_Internal(IntPtr @this);

		// Token: 0x06020279 RID: 131705 RVA: 0x002FC97F File Offset: 0x002FAB7F
		static UUIEffectTextAnimation()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIEffectTextAnimation");
		}

		// Token: 0x0602027A RID: 131706 RVA: 0x002FC98D File Offset: 0x002FAB8D
		protected UUIEffectTextAnimation(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040114AB RID: 70827
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UIEffectTextAnimation";

		// Token: 0x040114AC RID: 70828
		private static IntPtr _ClassPtr;

		// Token: 0x040114AD RID: 70829
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040114AE RID: 70830
		internal static int __PropertyOffset_selector;

		// Token: 0x040114AF RID: 70831
		internal static int __PropertyOffset_properties;

		// Token: 0x040114B0 RID: 70832
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UUIEffectTextAnimation_Property> _properties;

		// Token: 0x040114B1 RID: 70833
		internal static int __PropertyOffset_textTargetObject;
	}
}
