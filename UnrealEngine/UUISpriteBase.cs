using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000729 RID: 1833
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UISpriteBase")]
	[UnrealStructLayout(2224, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2224)]
	public abstract class UUISpriteBase : UUIBatchGeometryRenderable, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06009F49 RID: 40777 RVA: 0x000EC71A File Offset: 0x000EA91A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUISpriteBase._ClassPtr;
		}

		// Token: 0x17001D99 RID: 7577
		// (get) Token: 0x06009F4A RID: 40778 RVA: 0x000EC726 File Offset: 0x000EA926
		// (set) Token: 0x06009F4B RID: 40779 RVA: 0x000EC73A File Offset: 0x000EA93A
		public unsafe ULGUISpriteData_BaseObject sprite
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULGUISpriteData_BaseObject>(base.NativePtr / (IntPtr)sizeof(void*) + UUISpriteBase.__PropertyOffset_sprite);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UUISpriteBase.__PropertyOffset_sprite, value);
			}
		}

		// Token: 0x17001D9A RID: 7578
		// (get) Token: 0x06009F4C RID: 40780 RVA: 0x000EC74F File Offset: 0x000EA94F
		// (set) Token: 0x06009F4D RID: 40781 RVA: 0x000EC75F File Offset: 0x000EA95F
		public unsafe bool bNotUseDynamicSpriteAtlas
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUISpriteBase.__PropertyOffset_bNotUseDynamicSpriteAtlas) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUISpriteBase.__PropertyOffset_bNotUseDynamicSpriteAtlas) = (value ? 1 : 0);
			}
		}

		// Token: 0x06009F4E RID: 40782 RVA: 0x000EC770 File Offset: 0x000EA970
		public void SetSprite(ULGUISpriteData_BaseObject newSprite, bool setSize = true)
		{
			UUISpriteBase.__SetSprite_Internal(base.NativePtr, (newSprite != null) ? newSprite.NativePtr : IntPtr.Zero, setSize);
		}

		// Token: 0x06009F4F RID: 40783 RVA: 0x000EC78E File Offset: 0x000EA98E
		public void SetSizeFromSpriteData()
		{
			UUISpriteBase.__SetSizeFromSpriteData_Internal(base.NativePtr);
		}

		// Token: 0x06009F50 RID: 40784 RVA: 0x000EC79B File Offset: 0x000EA99B
		public ULGUISpriteData_BaseObject GetSprite()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULGUISpriteData_BaseObject>(UUISpriteBase.__GetSprite_Internal(base.NativePtr));
		}

		// Token: 0x06009F51 RID: 40785
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSprite_Internal(IntPtr @this, IntPtr newSprite, bool setSize);

		// Token: 0x06009F52 RID: 40786
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSizeFromSpriteData_Internal(IntPtr @this);

		// Token: 0x06009F53 RID: 40787
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetSprite_Internal(IntPtr @this);

		// Token: 0x06009F54 RID: 40788 RVA: 0x000EC7AD File Offset: 0x000EA9AD
		static UUISpriteBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UISpriteBase");
		}

		// Token: 0x06009F55 RID: 40789 RVA: 0x000EC7BC File Offset: 0x000EA9BC
		protected UUISpriteBase() : this(BuiltinUtils.AllocNativeUObject(UUISpriteBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06009F56 RID: 40790 RVA: 0x000EC7E4 File Offset: 0x000EA9E4
		protected UUISpriteBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04004450 RID: 17488
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UISpriteBase";

		// Token: 0x04004451 RID: 17489
		private static IntPtr _ClassPtr;

		// Token: 0x04004452 RID: 17490
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04004453 RID: 17491
		internal static int __PropertyOffset_sprite;

		// Token: 0x04004454 RID: 17492
		internal static int __PropertyOffset_bNotUseDynamicSpriteAtlas;
	}
}
