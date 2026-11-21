using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000707 RID: 1799
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UIGeometryModifierWithRenderableBase")]
	[UnrealStructLayout(264, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 264)]
	public abstract class UUIGeometryModifierWithRenderableBase : UUIGeometryModifierBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06009919 RID: 39193 RVA: 0x000E698D File Offset: 0x000E4B8D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIGeometryModifierWithRenderableBase._ClassPtr;
		}

		// Token: 0x17001C76 RID: 7286
		// (get) Token: 0x0600991A RID: 39194 RVA: 0x000E6999 File Offset: 0x000E4B99
		// (set) Token: 0x0600991B RID: 39195 RVA: 0x000E69A9 File Offset: 0x000E4BA9
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

		// Token: 0x17001C77 RID: 7287
		// (get) Token: 0x0600991C RID: 39196 RVA: 0x000E69BA File Offset: 0x000E4BBA
		// (set) Token: 0x0600991D RID: 39197 RVA: 0x000E69CE File Offset: 0x000E4BCE
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

		// Token: 0x0600991E RID: 39198 RVA: 0x000E69E3 File Offset: 0x000E4BE3
		public void SetUseCustomMaterial(bool newValue)
		{
			UUIGeometryModifierWithRenderableBase.__SetUseCustomMaterial_Internal(base.NativePtr, newValue);
		}

		// Token: 0x0600991F RID: 39199 RVA: 0x000E69F1 File Offset: 0x000E4BF1
		public void SetCustomMaterial(UMaterialInterface newMaterial)
		{
			UUIGeometryModifierWithRenderableBase.__SetCustomMaterial_Internal(base.NativePtr, (newMaterial != null) ? newMaterial.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06009920 RID: 39200 RVA: 0x000E6A0E File Offset: 0x000E4C0E
		public bool GetUseCustomMaterial()
		{
			return UUIGeometryModifierWithRenderableBase.__GetUseCustomMaterial_Internal(base.NativePtr);
		}

		// Token: 0x06009921 RID: 39201 RVA: 0x000E6A1B File Offset: 0x000E4C1B
		public UMaterialInterface GetCustomMaterial()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UMaterialInterface>(UUIGeometryModifierWithRenderableBase.__GetCustomMaterial_Internal(base.NativePtr));
		}

		// Token: 0x06009922 RID: 39202
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUseCustomMaterial_Internal(IntPtr @this, bool newValue);

		// Token: 0x06009923 RID: 39203
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCustomMaterial_Internal(IntPtr @this, IntPtr newMaterial);

		// Token: 0x06009924 RID: 39204
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetUseCustomMaterial_Internal(IntPtr @this);

		// Token: 0x06009925 RID: 39205
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetCustomMaterial_Internal(IntPtr @this);

		// Token: 0x06009926 RID: 39206 RVA: 0x000E6A2D File Offset: 0x000E4C2D
		static UUIGeometryModifierWithRenderableBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIGeometryModifierWithRenderableBase");
		}

		// Token: 0x06009927 RID: 39207 RVA: 0x000E6A3C File Offset: 0x000E4C3C
		protected UUIGeometryModifierWithRenderableBase() : this(BuiltinUtils.AllocNativeUObject(UUIGeometryModifierWithRenderableBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06009928 RID: 39208 RVA: 0x000E6A64 File Offset: 0x000E4C64
		protected UUIGeometryModifierWithRenderableBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04004293 RID: 17043
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UIGeometryModifierWithRenderableBase";

		// Token: 0x04004294 RID: 17044
		private static IntPtr _ClassPtr;

		// Token: 0x04004295 RID: 17045
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04004296 RID: 17046
		internal static int __PropertyOffset_bUseCustomMaterial;

		// Token: 0x04004297 RID: 17047
		internal static int __PropertyOffset_customMaterial;
	}
}
