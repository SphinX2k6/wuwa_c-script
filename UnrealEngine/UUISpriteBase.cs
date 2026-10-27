using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020021BC RID: 8636
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UISpriteBase")]
	[UnrealStructLayout(2224, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2224)]
	public abstract class UUISpriteBase : UUIBatchGeometryRenderable, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020DED RID: 134637 RVA: 0x00308DD6 File Offset: 0x00306FD6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUISpriteBase._ClassPtr;
		}

		// Token: 0x17008064 RID: 32868
		// (get) Token: 0x06020DEE RID: 134638 RVA: 0x00308DE2 File Offset: 0x00306FE2
		// (set) Token: 0x06020DEF RID: 134639 RVA: 0x00308DF6 File Offset: 0x00306FF6
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

		// Token: 0x17008065 RID: 32869
		// (get) Token: 0x06020DF0 RID: 134640 RVA: 0x00308E0B File Offset: 0x0030700B
		// (set) Token: 0x06020DF1 RID: 134641 RVA: 0x00308E1B File Offset: 0x0030701B
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

		// Token: 0x06020DF2 RID: 134642 RVA: 0x00308E2C File Offset: 0x0030702C
		public void SetSprite(ULGUISpriteData_BaseObject newSprite, bool setSize = true)
		{
			UUISpriteBase.__SetSprite_Internal(base.NativePtr, (newSprite != null) ? newSprite.NativePtr : IntPtr.Zero, setSize);
		}

		// Token: 0x06020DF3 RID: 134643 RVA: 0x00308E4A File Offset: 0x0030704A
		public void SetSizeFromSpriteData()
		{
			UUISpriteBase.__SetSizeFromSpriteData_Internal(base.NativePtr);
		}

		// Token: 0x06020DF4 RID: 134644 RVA: 0x00308E57 File Offset: 0x00307057
		public ULGUISpriteData_BaseObject GetSprite()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULGUISpriteData_BaseObject>(UUISpriteBase.__GetSprite_Internal(base.NativePtr));
		}

		// Token: 0x06020DF5 RID: 134645
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSprite_Internal(IntPtr @this, IntPtr newSprite, bool setSize);

		// Token: 0x06020DF6 RID: 134646
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSizeFromSpriteData_Internal(IntPtr @this);

		// Token: 0x06020DF7 RID: 134647
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetSprite_Internal(IntPtr @this);

		// Token: 0x06020DF8 RID: 134648 RVA: 0x00308E69 File Offset: 0x00307069
		static UUISpriteBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UISpriteBase");
		}

		// Token: 0x06020DF9 RID: 134649 RVA: 0x00308E78 File Offset: 0x00307078
		protected UUISpriteBase() : this(BuiltinUtils.AllocNativeUObject(UUISpriteBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020DFA RID: 134650 RVA: 0x00308EA0 File Offset: 0x003070A0
		protected UUISpriteBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040118DA RID: 71898
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UISpriteBase";

		// Token: 0x040118DB RID: 71899
		private static IntPtr _ClassPtr;

		// Token: 0x040118DC RID: 71900
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040118DD RID: 71901
		internal static int __PropertyOffset_sprite;

		// Token: 0x040118DE RID: 71902
		internal static int __PropertyOffset_bNotUseDynamicSpriteAtlas;
	}
}
