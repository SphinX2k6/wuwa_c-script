using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200071D RID: 1821
	[UnrealObjectPath("/Script/LGUI.UIScrollbarComponent")]
	[UnrealStructLayout(1160, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1160)]
	public class UUIScrollbarComponent : UUISelectableComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06009CB9 RID: 40121 RVA: 0x000E9F1B File Offset: 0x000E811B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIScrollbarComponent._ClassPtr;
		}

		// Token: 0x06009CBA RID: 40122 RVA: 0x000E9F28 File Offset: 0x000E8128
		public UUIScrollbarComponent() : this(BuiltinUtils.AllocNativeUObject(UUIScrollbarComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06009CBB RID: 40123 RVA: 0x000E9F50 File Offset: 0x000E8150
		[NullableContext(1)]
		public UUIScrollbarComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUIScrollbarComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001D12 RID: 7442
		// (get) Token: 0x06009CBC RID: 40124 RVA: 0x000E9F83 File Offset: 0x000E8183
		// (set) Token: 0x06009CBD RID: 40125 RVA: 0x000E9F93 File Offset: 0x000E8193
		public unsafe float Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIScrollbarComponent.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIScrollbarComponent.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x17001D13 RID: 7443
		// (get) Token: 0x06009CBE RID: 40126 RVA: 0x000E9FA4 File Offset: 0x000E81A4
		// (set) Token: 0x06009CBF RID: 40127 RVA: 0x000E9FB4 File Offset: 0x000E81B4
		public unsafe float Size
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIScrollbarComponent.__PropertyOffset_Size);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIScrollbarComponent.__PropertyOffset_Size) = value;
			}
		}

		// Token: 0x17001D14 RID: 7444
		// (get) Token: 0x06009CC0 RID: 40128 RVA: 0x000E9FC5 File Offset: 0x000E81C5
		// (set) Token: 0x06009CC1 RID: 40129 RVA: 0x000E9FD9 File Offset: 0x000E81D9
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<AUIBaseActor> HandleActor
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UUIScrollbarComponent.__PropertyOffset_HandleActor);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UUIScrollbarComponent.__PropertyOffset_HandleActor) = value;
			}
		}

		// Token: 0x17001D15 RID: 7445
		// (get) Token: 0x06009CC2 RID: 40130 RVA: 0x000E9FEE File Offset: 0x000E81EE
		// (set) Token: 0x06009CC3 RID: 40131 RVA: 0x000EA002 File Offset: 0x000E8202
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<UUIItem> Handle
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UUIScrollbarComponent.__PropertyOffset_Handle);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UUIScrollbarComponent.__PropertyOffset_Handle) = value;
			}
		}

		// Token: 0x17001D16 RID: 7446
		// (get) Token: 0x06009CC4 RID: 40132 RVA: 0x000EA017 File Offset: 0x000E8217
		// (set) Token: 0x06009CC5 RID: 40133 RVA: 0x000EA02B File Offset: 0x000E822B
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<UUIItem> HandleArea
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UUIScrollbarComponent.__PropertyOffset_HandleArea);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UUIScrollbarComponent.__PropertyOffset_HandleArea) = value;
			}
		}

		// Token: 0x17001D17 RID: 7447
		// (get) Token: 0x06009CC6 RID: 40134 RVA: 0x000EA040 File Offset: 0x000E8240
		// (set) Token: 0x06009CC7 RID: 40135 RVA: 0x000EA054 File Offset: 0x000E8254
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<AActor> ScrollViewBackgroundActor
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UUIScrollbarComponent.__PropertyOffset_ScrollViewBackgroundActor);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UUIScrollbarComponent.__PropertyOffset_ScrollViewBackgroundActor) = value;
			}
		}

		// Token: 0x17001D18 RID: 7448
		// (get) Token: 0x06009CC8 RID: 40136 RVA: 0x000EA069 File Offset: 0x000E8269
		// (set) Token: 0x06009CC9 RID: 40137 RVA: 0x000EA07D File Offset: 0x000E827D
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<UUIItem> ScrollViewBackgroundComponent
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UUIScrollbarComponent.__PropertyOffset_ScrollViewBackgroundComponent);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UUIScrollbarComponent.__PropertyOffset_ScrollViewBackgroundComponent) = value;
			}
		}

		// Token: 0x17001D19 RID: 7449
		// (get) Token: 0x06009CCA RID: 40138 RVA: 0x000EA092 File Offset: 0x000E8292
		// (set) Token: 0x06009CCB RID: 40139 RVA: 0x000EA0A2 File Offset: 0x000E82A2
		public unsafe bool MainScrollbar
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIScrollbarComponent.__PropertyOffset_MainScrollbar) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIScrollbarComponent.__PropertyOffset_MainScrollbar) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001D1A RID: 7450
		// (get) Token: 0x06009CCC RID: 40140 RVA: 0x000EA0B3 File Offset: 0x000E82B3
		// (set) Token: 0x06009CCD RID: 40141 RVA: 0x000EA0C3 File Offset: 0x000E82C3
		public unsafe int ViewId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIScrollbarComponent.__PropertyOffset_ViewId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIScrollbarComponent.__PropertyOffset_ViewId) = value;
			}
		}

		// Token: 0x06009CCE RID: 40142 RVA: 0x000EA0D4 File Offset: 0x000E82D4
		[NullableContext(2)]
		public void UnregisterSlideEvent(in FLGUIDelegateHandleWrapper InDelegateHandle)
		{
			UUIScrollbarComponent.__UnregisterSlideEvent_Internal(base.NativePtr, (InDelegateHandle ?? new FLGUIDelegateHandleWrapper()).NativePtr);
		}

		// Token: 0x06009CCF RID: 40143 RVA: 0x000EA0F1 File Offset: 0x000E82F1
		public void SetValueAndSize(float InValue, float InSize, bool FireEvent = true)
		{
			UUIScrollbarComponent.__SetValueAndSize_Internal(base.NativePtr, InValue, InSize, FireEvent);
		}

		// Token: 0x06009CD0 RID: 40144 RVA: 0x000EA101 File Offset: 0x000E8301
		public void SetValue(float InValue, bool FireEvent = true)
		{
			UUIScrollbarComponent.__SetValue_Internal(base.NativePtr, InValue, FireEvent);
		}

		// Token: 0x06009CD1 RID: 40145 RVA: 0x000EA110 File Offset: 0x000E8310
		public void SetSize(float InSize)
		{
			UUIScrollbarComponent.__SetSize_Internal(base.NativePtr, InSize);
		}

		// Token: 0x06009CD2 RID: 40146 RVA: 0x000EA11E File Offset: 0x000E831E
		[NullableContext(2)]
		public static void SetScrollbarDelegate(in FLGUIScrollbarDelegate Delegate)
		{
			FLGUIScrollbarDelegate flguiscrollbarDelegate = Delegate;
			UUIScrollbarComponent.__SetScrollbarDelegate_Internal((flguiscrollbarDelegate != null) ? flguiscrollbarDelegate.NativePtr : ((IntPtr)0));
		}

		// Token: 0x06009CD3 RID: 40147
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void ResetScrollbarDelegate();

		// Token: 0x06009CD4 RID: 40148 RVA: 0x000EA134 File Offset: 0x000E8334
		[NullableContext(1)]
		public FLGUIDelegateHandleWrapper RegisterSlideEvent([Nullable(2)] in FLGUIScrollbarDynamicDelegate InDelegate)
		{
			IntPtr nativePtr = base.NativePtr;
			FLGUIScrollbarDynamicDelegate flguiscrollbarDynamicDelegate = InDelegate;
			return new FLGUIDelegateHandleWrapper(UUIScrollbarComponent.__RegisterSlideEvent_Internal(nativePtr, (flguiscrollbarDynamicDelegate != null) ? flguiscrollbarDynamicDelegate.NativePtr : ((IntPtr)0)), null);
		}

		// Token: 0x06009CD5 RID: 40149 RVA: 0x000EA156 File Offset: 0x000E8356
		public float GetValue()
		{
			return UUIScrollbarComponent.__GetValue_Internal(base.NativePtr);
		}

		// Token: 0x06009CD6 RID: 40150 RVA: 0x000EA163 File Offset: 0x000E8363
		public float GetSize()
		{
			return UUIScrollbarComponent.__GetSize_Internal(base.NativePtr);
		}

		// Token: 0x06009CD7 RID: 40151 RVA: 0x000EA170 File Offset: 0x000E8370
		public void ChangeSchedule(ELGUINavigationDirection InDirection)
		{
			UUIScrollbarComponent.__ChangeSchedule_Internal(base.NativePtr, InDirection);
		}

		// Token: 0x06009CD8 RID: 40152
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnregisterSlideEvent_Internal(IntPtr @this, IntPtr InDelegateHandle);

		// Token: 0x06009CD9 RID: 40153
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetValueAndSize_Internal(IntPtr @this, float InValue, float InSize, bool FireEvent);

		// Token: 0x06009CDA RID: 40154
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetValue_Internal(IntPtr @this, float InValue, bool FireEvent);

		// Token: 0x06009CDB RID: 40155
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSize_Internal(IntPtr @this, float InSize);

		// Token: 0x06009CDC RID: 40156
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetScrollbarDelegate_Internal(IntPtr Delegate);

		// Token: 0x06009CDD RID: 40157
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __RegisterSlideEvent_Internal(IntPtr @this, IntPtr InDelegate);

		// Token: 0x06009CDE RID: 40158
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetValue_Internal(IntPtr @this);

		// Token: 0x06009CDF RID: 40159
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetSize_Internal(IntPtr @this);

		// Token: 0x06009CE0 RID: 40160
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ChangeSchedule_Internal(IntPtr @this, ELGUINavigationDirection InDirection);

		// Token: 0x06009CE1 RID: 40161 RVA: 0x000EA17E File Offset: 0x000E837E
		static UUIScrollbarComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIScrollbarComponent");
		}

		// Token: 0x06009CE2 RID: 40162 RVA: 0x000EA18C File Offset: 0x000E838C
		protected UUIScrollbarComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04004393 RID: 17299
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UIScrollbarComponent";

		// Token: 0x04004394 RID: 17300
		private static IntPtr _ClassPtr;

		// Token: 0x04004395 RID: 17301
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04004396 RID: 17302
		internal static int __PropertyOffset_Value;

		// Token: 0x04004397 RID: 17303
		internal static int __PropertyOffset_Size;

		// Token: 0x04004398 RID: 17304
		internal static int __PropertyOffset_HandleActor;

		// Token: 0x04004399 RID: 17305
		internal static int __PropertyOffset_Handle;

		// Token: 0x0400439A RID: 17306
		internal static int __PropertyOffset_HandleArea;

		// Token: 0x0400439B RID: 17307
		internal static int __PropertyOffset_ScrollViewBackgroundActor;

		// Token: 0x0400439C RID: 17308
		internal static int __PropertyOffset_ScrollViewBackgroundComponent;

		// Token: 0x0400439D RID: 17309
		internal static int __PropertyOffset_MainScrollbar;

		// Token: 0x0400439E RID: 17310
		internal static int __PropertyOffset_ViewId;
	}
}
