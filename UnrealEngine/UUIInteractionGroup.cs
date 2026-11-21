using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200070B RID: 1803
	[UnrealObjectPath("/Script/LGUI.UIInteractionGroup")]
	[UnrealStructLayout(216, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 216)]
	public class UUIInteractionGroup : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060099BC RID: 39356 RVA: 0x000E71BB File Offset: 0x000E53BB
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIInteractionGroup._ClassPtr;
		}

		// Token: 0x060099BD RID: 39357 RVA: 0x000E71C8 File Offset: 0x000E53C8
		public UUIInteractionGroup() : this(BuiltinUtils.AllocNativeUObject(UUIInteractionGroup.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060099BE RID: 39358 RVA: 0x000E71F0 File Offset: 0x000E53F0
		[NullableContext(1)]
		public UUIInteractionGroup(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUIInteractionGroup.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001C92 RID: 7314
		// (get) Token: 0x060099BF RID: 39359 RVA: 0x000E7223 File Offset: 0x000E5423
		// (set) Token: 0x060099C0 RID: 39360 RVA: 0x000E7233 File Offset: 0x000E5433
		public unsafe bool bInteractable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIInteractionGroup.__PropertyOffset_bInteractable) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIInteractionGroup.__PropertyOffset_bInteractable) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001C93 RID: 7315
		// (get) Token: 0x060099C1 RID: 39361 RVA: 0x000E7244 File Offset: 0x000E5444
		// (set) Token: 0x060099C2 RID: 39362 RVA: 0x000E7254 File Offset: 0x000E5454
		public unsafe bool bIgnoreParentGroup
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIInteractionGroup.__PropertyOffset_bIgnoreParentGroup) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIInteractionGroup.__PropertyOffset_bIgnoreParentGroup) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001C94 RID: 7316
		// (get) Token: 0x060099C3 RID: 39363 RVA: 0x000E7265 File Offset: 0x000E5465
		// (set) Token: 0x060099C4 RID: 39364 RVA: 0x000E7275 File Offset: 0x000E5475
		public unsafe bool bGroupEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIInteractionGroup.__PropertyOffset_bGroupEnabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIInteractionGroup.__PropertyOffset_bGroupEnabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001C95 RID: 7317
		// (get) Token: 0x060099C5 RID: 39365 RVA: 0x000E7286 File Offset: 0x000E5486
		// (set) Token: 0x060099C6 RID: 39366 RVA: 0x000E729A File Offset: 0x000E549A
		[Nullable(2)]
		public unsafe UUIItem CacheUIItem
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UUIItem>(base.NativePtr / (IntPtr)sizeof(void*) + UUIInteractionGroup.__PropertyOffset_CacheUIItem);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UUIInteractionGroup.__PropertyOffset_CacheUIItem, value);
			}
		}

		// Token: 0x060099C7 RID: 39367 RVA: 0x000E72AF File Offset: 0x000E54AF
		public void SetInteractable(bool value)
		{
			UUIInteractionGroup.__SetInteractable_Internal(base.NativePtr, value);
		}

		// Token: 0x060099C8 RID: 39368 RVA: 0x000E72BD File Offset: 0x000E54BD
		public void SetIgnoreParentGroup(bool value)
		{
			UUIInteractionGroup.__SetIgnoreParentGroup_Internal(base.NativePtr, value);
		}

		// Token: 0x060099C9 RID: 39369 RVA: 0x000E72CB File Offset: 0x000E54CB
		public bool IsGroupEnabled()
		{
			return UUIInteractionGroup.__IsGroupEnabled_Internal(base.NativePtr);
		}

		// Token: 0x060099CA RID: 39370 RVA: 0x000E72D8 File Offset: 0x000E54D8
		public bool GetInteractable()
		{
			return UUIInteractionGroup.__GetInteractable_Internal(base.NativePtr);
		}

		// Token: 0x060099CB RID: 39371 RVA: 0x000E72E5 File Offset: 0x000E54E5
		public bool GetIgnoreParentGroup()
		{
			return UUIInteractionGroup.__GetIgnoreParentGroup_Internal(base.NativePtr);
		}

		// Token: 0x060099CC RID: 39372
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetInteractable_Internal(IntPtr @this, bool value);

		// Token: 0x060099CD RID: 39373
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetIgnoreParentGroup_Internal(IntPtr @this, bool value);

		// Token: 0x060099CE RID: 39374
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsGroupEnabled_Internal(IntPtr @this);

		// Token: 0x060099CF RID: 39375
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetInteractable_Internal(IntPtr @this);

		// Token: 0x060099D0 RID: 39376
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetIgnoreParentGroup_Internal(IntPtr @this);

		// Token: 0x060099D1 RID: 39377 RVA: 0x000E72F2 File Offset: 0x000E54F2
		static UUIInteractionGroup()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIInteractionGroup");
		}

		// Token: 0x060099D2 RID: 39378 RVA: 0x000E7300 File Offset: 0x000E5500
		protected UUIInteractionGroup(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040042BC RID: 17084
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UIInteractionGroup";

		// Token: 0x040042BD RID: 17085
		private static IntPtr _ClassPtr;

		// Token: 0x040042BE RID: 17086
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040042BF RID: 17087
		internal static int __PropertyOffset_bInteractable;

		// Token: 0x040042C0 RID: 17088
		internal static int __PropertyOffset_bIgnoreParentGroup;

		// Token: 0x040042C1 RID: 17089
		internal static int __PropertyOffset_bGroupEnabled;

		// Token: 0x040042C2 RID: 17090
		internal static int __PropertyOffset_CacheUIItem;
	}
}
