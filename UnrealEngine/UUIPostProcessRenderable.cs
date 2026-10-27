using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200219A RID: 8602
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UIPostProcessRenderable")]
	[UnrealStructLayout(1776, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1776)]
	public abstract class UUIPostProcessRenderable : UUIBaseRenderable, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060209F2 RID: 133618 RVA: 0x00304869 File Offset: 0x00302A69
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIPostProcessRenderable._ClassPtr;
		}

		// Token: 0x17007F83 RID: 32643
		// (get) Token: 0x060209F3 RID: 133619 RVA: 0x00304875 File Offset: 0x00302A75
		// (set) Token: 0x060209F4 RID: 133620 RVA: 0x00304889 File Offset: 0x00302A89
		public unsafe UTexture2D maskTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + UUIPostProcessRenderable.__PropertyOffset_maskTexture);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UUIPostProcessRenderable.__PropertyOffset_maskTexture, value);
			}
		}

		// Token: 0x060209F5 RID: 133621 RVA: 0x0030489E File Offset: 0x00302A9E
		public void SetMaskTexture(UTexture2D newValue)
		{
			UUIPostProcessRenderable.__SetMaskTexture_Internal(base.NativePtr, (newValue != null) ? newValue.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060209F6 RID: 133622 RVA: 0x003048BB File Offset: 0x00302ABB
		public UTexture2D GetMaskTexture()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UTexture2D>(UUIPostProcessRenderable.__GetMaskTexture_Internal(base.NativePtr));
		}

		// Token: 0x060209F7 RID: 133623
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMaskTexture_Internal(IntPtr @this, IntPtr newValue);

		// Token: 0x060209F8 RID: 133624
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetMaskTexture_Internal(IntPtr @this);

		// Token: 0x060209F9 RID: 133625 RVA: 0x003048CD File Offset: 0x00302ACD
		static UUIPostProcessRenderable()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIPostProcessRenderable");
		}

		// Token: 0x060209FA RID: 133626 RVA: 0x003048DC File Offset: 0x00302ADC
		protected UUIPostProcessRenderable() : this(BuiltinUtils.AllocNativeUObject(UUIPostProcessRenderable.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060209FB RID: 133627 RVA: 0x00304904 File Offset: 0x00302B04
		protected UUIPostProcessRenderable(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011753 RID: 71507
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UIPostProcessRenderable";

		// Token: 0x04011754 RID: 71508
		private static IntPtr _ClassPtr;

		// Token: 0x04011755 RID: 71509
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011756 RID: 71510
		internal static int __PropertyOffset_maskTexture;
	}
}
