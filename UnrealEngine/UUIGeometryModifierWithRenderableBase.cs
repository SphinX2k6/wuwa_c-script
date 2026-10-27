using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002174 RID: 8564
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UIGeometryModifierWithRenderableBase")]
	[UnrealStructLayout(264, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 264)]
	public abstract class UUIGeometryModifierWithRenderableBase : UUIGeometryModifierBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602054E RID: 132430 RVA: 0x00300321 File Offset: 0x002FE521
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIGeometryModifierWithRenderableBase._ClassPtr;
		}

		// Token: 0x17007EBE RID: 32446
		// (get) Token: 0x0602054F RID: 132431 RVA: 0x0030032D File Offset: 0x002FE52D
		// (set) Token: 0x06020550 RID: 132432 RVA: 0x0030033D File Offset: 0x002FE53D
		public unsafe bool bUseCustomMaterial
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIGeometryModifierWithRenderableBase.__PropertyOffset_bUseCustomMaterial) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIGeometryModifierWithRenderableBase.__PropertyOffset_bUseCustomMaterial) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007EBF RID: 32447
		// (get) Token: 0x06020551 RID: 132433 RVA: 0x0030034E File Offset: 0x002FE54E
		// (set) Token: 0x06020552 RID: 132434 RVA: 0x00300362 File Offset: 0x002FE562
		public unsafe UMaterialInterface customMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + UUIGeometryModifierWithRenderableBase.__PropertyOffset_customMaterial);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UUIGeometryModifierWithRenderableBase.__PropertyOffset_customMaterial, value);
			}
		}

		// Token: 0x17007EC0 RID: 32448
		// (get) Token: 0x06020553 RID: 132435 RVA: 0x00300377 File Offset: 0x002FE577
		// (set) Token: 0x06020554 RID: 132436 RVA: 0x0030038B File Offset: 0x002FE58B
		public unsafe UUIEffectRenderable effectRenderable
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UUIEffectRenderable>(base.NativePtr / (IntPtr)sizeof(void*) + UUIGeometryModifierWithRenderableBase.__PropertyOffset_effectRenderable);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UUIGeometryModifierWithRenderableBase.__PropertyOffset_effectRenderable, value);
			}
		}

		// Token: 0x06020555 RID: 132437 RVA: 0x003003A0 File Offset: 0x002FE5A0
		public void SetUseCustomMaterial(bool newValue)
		{
			UUIGeometryModifierWithRenderableBase.__SetUseCustomMaterial_Internal(base.NativePtr, newValue);
		}

		// Token: 0x06020556 RID: 132438 RVA: 0x003003AE File Offset: 0x002FE5AE
		public void SetCustomMaterial(UMaterialInterface newMaterial)
		{
			UUIGeometryModifierWithRenderableBase.__SetCustomMaterial_Internal(base.NativePtr, (newMaterial != null) ? newMaterial.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06020557 RID: 132439 RVA: 0x003003CB File Offset: 0x002FE5CB
		public bool GetUseCustomMaterial()
		{
			return UUIGeometryModifierWithRenderableBase.__GetUseCustomMaterial_Internal(base.NativePtr);
		}

		// Token: 0x06020558 RID: 132440 RVA: 0x003003D8 File Offset: 0x002FE5D8
		public UMaterialInterface GetCustomMaterial()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UMaterialInterface>(UUIGeometryModifierWithRenderableBase.__GetCustomMaterial_Internal(base.NativePtr));
		}

		// Token: 0x06020559 RID: 132441
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUseCustomMaterial_Internal(IntPtr @this, bool newValue);

		// Token: 0x0602055A RID: 132442
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCustomMaterial_Internal(IntPtr @this, IntPtr newMaterial);

		// Token: 0x0602055B RID: 132443
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetUseCustomMaterial_Internal(IntPtr @this);

		// Token: 0x0602055C RID: 132444
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetCustomMaterial_Internal(IntPtr @this);

		// Token: 0x0602055D RID: 132445 RVA: 0x003003EA File Offset: 0x002FE5EA
		static UUIGeometryModifierWithRenderableBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIGeometryModifierWithRenderableBase");
		}

		// Token: 0x0602055E RID: 132446 RVA: 0x003003F8 File Offset: 0x002FE5F8
		protected UUIGeometryModifierWithRenderableBase() : this(BuiltinUtils.AllocNativeUObject(UUIGeometryModifierWithRenderableBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602055F RID: 132447 RVA: 0x00300420 File Offset: 0x002FE620
		protected UUIGeometryModifierWithRenderableBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040115E9 RID: 71145
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UIGeometryModifierWithRenderableBase";

		// Token: 0x040115EA RID: 71146
		private static IntPtr _ClassPtr;

		// Token: 0x040115EB RID: 71147
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040115EC RID: 71148
		internal static int __PropertyOffset_bUseCustomMaterial;

		// Token: 0x040115ED RID: 71149
		internal static int __PropertyOffset_customMaterial;

		// Token: 0x040115EE RID: 71150
		internal static int __PropertyOffset_effectRenderable;
	}
}
