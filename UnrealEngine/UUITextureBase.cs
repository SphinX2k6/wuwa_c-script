using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020021D5 RID: 8661
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UITextureBase")]
	[UnrealStructLayout(2256, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2256)]
	public abstract class UUITextureBase : UUIBatchGeometryRenderable, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021021 RID: 135201 RVA: 0x0030B317 File Offset: 0x00309517
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUITextureBase._ClassPtr;
		}

		// Token: 0x170080DD RID: 32989
		// (get) Token: 0x06021022 RID: 135202 RVA: 0x0030B323 File Offset: 0x00309523
		// (set) Token: 0x06021023 RID: 135203 RVA: 0x0030B337 File Offset: 0x00309537
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

		// Token: 0x06021024 RID: 135204 RVA: 0x0030B34C File Offset: 0x0030954C
		public void SetTexture(UTexture newTexture)
		{
			UUITextureBase.__SetTexture_Internal(base.NativePtr, (newTexture != null) ? newTexture.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06021025 RID: 135205 RVA: 0x0030B369 File Offset: 0x00309569
		public void SetSizeFromTexture()
		{
			UUITextureBase.__SetSizeFromTexture_Internal(base.NativePtr);
		}

		// Token: 0x06021026 RID: 135206 RVA: 0x0030B378 File Offset: 0x00309578
		[NullableContext(1)]
		public unsafe void SetDynamicAtlasTextureAsync(string InAtlasTag, [Nullable(2)] FSoftObjectPath InSoftObjectPath)
		{
			FString fstring = FString.AllocTemp(InAtlasTag);
			UUITextureBase.__SetDynamicAtlasTextureAsync_Internal(base.NativePtr, fstring, (InSoftObjectPath ?? new FSoftObjectPath()).NativePtr);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06021027 RID: 135207 RVA: 0x0030B3B1 File Offset: 0x003095B1
		public void OnDynamicAtlasSlotBuilt(in FDynamicAtlasSlotManagedHandle ManagedHandle)
		{
			UUITextureBase.__OnDynamicAtlasSlotBuilt_Internal(base.NativePtr, (ManagedHandle ?? new FDynamicAtlasSlotManagedHandle()).NativePtr);
		}

		// Token: 0x06021028 RID: 135208 RVA: 0x0030B3CE File Offset: 0x003095CE
		public UTexture GetTexture()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UTexture>(UUITextureBase.__GetTexture_Internal(base.NativePtr));
		}

		// Token: 0x06021029 RID: 135209
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTexture_Internal(IntPtr @this, IntPtr newTexture);

		// Token: 0x0602102A RID: 135210
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSizeFromTexture_Internal(IntPtr @this);

		// Token: 0x0602102B RID: 135211
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDynamicAtlasTextureAsync_Internal(IntPtr @this, in FString InAtlasTag, IntPtr InSoftObjectPath);

		// Token: 0x0602102C RID: 135212
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnDynamicAtlasSlotBuilt_Internal(IntPtr @this, IntPtr ManagedHandle);

		// Token: 0x0602102D RID: 135213
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetTexture_Internal(IntPtr @this);

		// Token: 0x0602102E RID: 135214 RVA: 0x0030B3E0 File Offset: 0x003095E0
		static UUITextureBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UITextureBase");
		}

		// Token: 0x0602102F RID: 135215 RVA: 0x0030B3F0 File Offset: 0x003095F0
		protected UUITextureBase() : this(BuiltinUtils.AllocNativeUObject(UUITextureBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021030 RID: 135216 RVA: 0x0030B418 File Offset: 0x00309618
		protected UUITextureBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040119DA RID: 72154
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UITextureBase";

		// Token: 0x040119DB RID: 72155
		private static IntPtr _ClassPtr;

		// Token: 0x040119DC RID: 72156
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040119DD RID: 72157
		internal static int __PropertyOffset_texture;
	}
}
