using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000736 RID: 1846
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UITextureBase")]
	[UnrealStructLayout(2256, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2256)]
	public abstract class UUITextureBase : UUIBatchGeometryRenderable, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A0FA RID: 41210 RVA: 0x000EE29F File Offset: 0x000EC49F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUITextureBase._ClassPtr;
		}

		// Token: 0x17001DFA RID: 7674
		// (get) Token: 0x0600A0FB RID: 41211 RVA: 0x000EE2AB File Offset: 0x000EC4AB
		// (set) Token: 0x0600A0FC RID: 41212 RVA: 0x000EE2BF File Offset: 0x000EC4BF
		public unsafe UTexture texture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + UUITextureBase.__PropertyOffset_texture);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UUITextureBase.__PropertyOffset_texture, value);
			}
		}

		// Token: 0x0600A0FD RID: 41213 RVA: 0x000EE2D4 File Offset: 0x000EC4D4
		public void SetTexture(UTexture newTexture)
		{
			UUITextureBase.__SetTexture_Internal(base.NativePtr, (newTexture != null) ? newTexture.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600A0FE RID: 41214 RVA: 0x000EE2F1 File Offset: 0x000EC4F1
		public void SetSizeFromTexture()
		{
			UUITextureBase.__SetSizeFromTexture_Internal(base.NativePtr);
		}

		// Token: 0x0600A0FF RID: 41215 RVA: 0x000EE300 File Offset: 0x000EC500
		[NullableContext(1)]
		public unsafe void SetDynamicAtlasTextureAsync(string InAtlasTag, [Nullable(2)] FSoftObjectPath InSoftObjectPath)
		{
			FString fstring = FString.AllocTemp(InAtlasTag);
			UUITextureBase.__SetDynamicAtlasTextureAsync_Internal(base.NativePtr, fstring, (InSoftObjectPath ?? new FSoftObjectPath()).NativePtr);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0600A100 RID: 41216 RVA: 0x000EE339 File Offset: 0x000EC539
		public UTexture GetTexture()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UTexture>(UUITextureBase.__GetTexture_Internal(base.NativePtr));
		}

		// Token: 0x0600A101 RID: 41217
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTexture_Internal(IntPtr @this, IntPtr newTexture);

		// Token: 0x0600A102 RID: 41218
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSizeFromTexture_Internal(IntPtr @this);

		// Token: 0x0600A103 RID: 41219
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDynamicAtlasTextureAsync_Internal(IntPtr @this, in FString InAtlasTag, IntPtr InSoftObjectPath);

		// Token: 0x0600A104 RID: 41220
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetTexture_Internal(IntPtr @this);

		// Token: 0x0600A105 RID: 41221 RVA: 0x000EE34B File Offset: 0x000EC54B
		static UUITextureBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UITextureBase");
		}

		// Token: 0x0600A106 RID: 41222 RVA: 0x000EE35C File Offset: 0x000EC55C
		protected UUITextureBase() : this(BuiltinUtils.AllocNativeUObject(UUITextureBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A107 RID: 41223 RVA: 0x000EE384 File Offset: 0x000EC584
		protected UUITextureBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040044F3 RID: 17651
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UITextureBase";

		// Token: 0x040044F4 RID: 17652
		private static IntPtr _ClassPtr;

		// Token: 0x040044F5 RID: 17653
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040044F6 RID: 17654
		internal static int __PropertyOffset_texture;
	}
}
