using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000724 RID: 1828
	[UnrealObjectPath("/Script/LGUI.UISizeControlByOther")]
	[UnrealStructLayout(440, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 440)]
	public class UUISizeControlByOther : UUILayoutBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06009E6A RID: 40554 RVA: 0x000EB8BD File Offset: 0x000E9ABD
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUISizeControlByOther._ClassPtr;
		}

		// Token: 0x06009E6B RID: 40555 RVA: 0x000EB8CC File Offset: 0x000E9ACC
		public UUISizeControlByOther() : this(BuiltinUtils.AllocNativeUObject(UUISizeControlByOther.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06009E6C RID: 40556 RVA: 0x000EB8F4 File Offset: 0x000E9AF4
		[NullableContext(1)]
		public UUISizeControlByOther(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUISizeControlByOther.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001D61 RID: 7521
		// (get) Token: 0x06009E6D RID: 40557 RVA: 0x000EB927 File Offset: 0x000E9B27
		// (set) Token: 0x06009E6E RID: 40558 RVA: 0x000EB93B File Offset: 0x000E9B3B
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<AUIBaseActor> TargetActor
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UUISizeControlByOther.__PropertyOffset_TargetActor);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UUISizeControlByOther.__PropertyOffset_TargetActor) = value;
			}
		}

		// Token: 0x17001D62 RID: 7522
		// (get) Token: 0x06009E6F RID: 40559 RVA: 0x000EB950 File Offset: 0x000E9B50
		// (set) Token: 0x06009E70 RID: 40560 RVA: 0x000EB960 File Offset: 0x000E9B60
		public unsafe bool ControlWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUISizeControlByOther.__PropertyOffset_ControlWidth) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUISizeControlByOther.__PropertyOffset_ControlWidth) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001D63 RID: 7523
		// (get) Token: 0x06009E71 RID: 40561 RVA: 0x000EB971 File Offset: 0x000E9B71
		// (set) Token: 0x06009E72 RID: 40562 RVA: 0x000EB981 File Offset: 0x000E9B81
		public unsafe bool ControlHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUISizeControlByOther.__PropertyOffset_ControlHeight) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUISizeControlByOther.__PropertyOffset_ControlHeight) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001D64 RID: 7524
		// (get) Token: 0x06009E73 RID: 40563 RVA: 0x000EB992 File Offset: 0x000E9B92
		// (set) Token: 0x06009E74 RID: 40564 RVA: 0x000EB9A2 File Offset: 0x000E9BA2
		public unsafe bool UseWidthRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUISizeControlByOther.__PropertyOffset_UseWidthRange) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUISizeControlByOther.__PropertyOffset_UseWidthRange) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001D65 RID: 7525
		// (get) Token: 0x06009E75 RID: 40565 RVA: 0x000EB9B3 File Offset: 0x000E9BB3
		// (set) Token: 0x06009E76 RID: 40566 RVA: 0x000EB9C3 File Offset: 0x000E9BC3
		public unsafe bool UseHeightRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUISizeControlByOther.__PropertyOffset_UseHeightRange) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUISizeControlByOther.__PropertyOffset_UseHeightRange) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001D66 RID: 7526
		// (get) Token: 0x06009E77 RID: 40567 RVA: 0x000EB9D4 File Offset: 0x000E9BD4
		// (set) Token: 0x06009E78 RID: 40568 RVA: 0x000EB9E4 File Offset: 0x000E9BE4
		public unsafe int MaxWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUISizeControlByOther.__PropertyOffset_MaxWidth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUISizeControlByOther.__PropertyOffset_MaxWidth) = value;
			}
		}

		// Token: 0x17001D67 RID: 7527
		// (get) Token: 0x06009E79 RID: 40569 RVA: 0x000EB9F5 File Offset: 0x000E9BF5
		// (set) Token: 0x06009E7A RID: 40570 RVA: 0x000EBA05 File Offset: 0x000E9C05
		public unsafe int MinWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUISizeControlByOther.__PropertyOffset_MinWidth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUISizeControlByOther.__PropertyOffset_MinWidth) = value;
			}
		}

		// Token: 0x17001D68 RID: 7528
		// (get) Token: 0x06009E7B RID: 40571 RVA: 0x000EBA16 File Offset: 0x000E9C16
		// (set) Token: 0x06009E7C RID: 40572 RVA: 0x000EBA26 File Offset: 0x000E9C26
		public unsafe int MaxHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUISizeControlByOther.__PropertyOffset_MaxHeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUISizeControlByOther.__PropertyOffset_MaxHeight) = value;
			}
		}

		// Token: 0x17001D69 RID: 7529
		// (get) Token: 0x06009E7D RID: 40573 RVA: 0x000EBA37 File Offset: 0x000E9C37
		// (set) Token: 0x06009E7E RID: 40574 RVA: 0x000EBA47 File Offset: 0x000E9C47
		public unsafe int MinHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUISizeControlByOther.__PropertyOffset_MinHeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUISizeControlByOther.__PropertyOffset_MinHeight) = value;
			}
		}

		// Token: 0x17001D6A RID: 7530
		// (get) Token: 0x06009E7F RID: 40575 RVA: 0x000EBA58 File Offset: 0x000E9C58
		// (set) Token: 0x06009E80 RID: 40576 RVA: 0x000EBA68 File Offset: 0x000E9C68
		public unsafe float AdditionalWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUISizeControlByOther.__PropertyOffset_AdditionalWidth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUISizeControlByOther.__PropertyOffset_AdditionalWidth) = value;
			}
		}

		// Token: 0x17001D6B RID: 7531
		// (get) Token: 0x06009E81 RID: 40577 RVA: 0x000EBA79 File Offset: 0x000E9C79
		// (set) Token: 0x06009E82 RID: 40578 RVA: 0x000EBA89 File Offset: 0x000E9C89
		public unsafe float AdditionalHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUISizeControlByOther.__PropertyOffset_AdditionalHeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUISizeControlByOther.__PropertyOffset_AdditionalHeight) = value;
			}
		}

		// Token: 0x17001D6C RID: 7532
		// (get) Token: 0x06009E83 RID: 40579 RVA: 0x000EBA9A File Offset: 0x000E9C9A
		// (set) Token: 0x06009E84 RID: 40580 RVA: 0x000EBAAA File Offset: 0x000E9CAA
		public unsafe bool bSizeZeroWhenNotActive
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUISizeControlByOther.__PropertyOffset_bSizeZeroWhenNotActive) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUISizeControlByOther.__PropertyOffset_bSizeZeroWhenNotActive) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001D6D RID: 7533
		// (get) Token: 0x06009E85 RID: 40581 RVA: 0x000EBABB File Offset: 0x000E9CBB
		// (set) Token: 0x06009E86 RID: 40582 RVA: 0x000EBACF File Offset: 0x000E9CCF
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<UUIItem> TargetUIItem
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UUISizeControlByOther.__PropertyOffset_TargetUIItem);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UUISizeControlByOther.__PropertyOffset_TargetUIItem) = value;
			}
		}

		// Token: 0x06009E87 RID: 40583 RVA: 0x000EBAE4 File Offset: 0x000E9CE4
		[NullableContext(2)]
		public void SetTargetActor(AUIBaseActor NewTargetActor)
		{
			UUISizeControlByOther.__SetTargetActor_Internal(base.NativePtr, (NewTargetActor != null) ? NewTargetActor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06009E88 RID: 40584 RVA: 0x000EBB01 File Offset: 0x000E9D01
		public void SetControlWidth(bool value)
		{
			UUISizeControlByOther.__SetControlWidth_Internal(base.NativePtr, value);
		}

		// Token: 0x06009E89 RID: 40585 RVA: 0x000EBB0F File Offset: 0x000E9D0F
		public void SetControlHeight(bool value)
		{
			UUISizeControlByOther.__SetControlHeight_Internal(base.NativePtr, value);
		}

		// Token: 0x06009E8A RID: 40586 RVA: 0x000EBB1D File Offset: 0x000E9D1D
		public void SetAdditionalWidth(float value)
		{
			UUISizeControlByOther.__SetAdditionalWidth_Internal(base.NativePtr, value);
		}

		// Token: 0x06009E8B RID: 40587 RVA: 0x000EBB2B File Offset: 0x000E9D2B
		public void SetAdditionalHeight(float value)
		{
			UUISizeControlByOther.__SetAdditionalHeight_Internal(base.NativePtr, value);
		}

		// Token: 0x06009E8C RID: 40588 RVA: 0x000EBB39 File Offset: 0x000E9D39
		[NullableContext(2)]
		public AUIBaseActor GetTargetActor()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AUIBaseActor>(UUISizeControlByOther.__GetTargetActor_Internal(base.NativePtr));
		}

		// Token: 0x06009E8D RID: 40589 RVA: 0x000EBB4B File Offset: 0x000E9D4B
		public bool GetControlWidth()
		{
			return UUISizeControlByOther.__GetControlWidth_Internal(base.NativePtr);
		}

		// Token: 0x06009E8E RID: 40590 RVA: 0x000EBB58 File Offset: 0x000E9D58
		public bool GetControlHeight()
		{
			return UUISizeControlByOther.__GetControlHeight_Internal(base.NativePtr);
		}

		// Token: 0x06009E8F RID: 40591 RVA: 0x000EBB65 File Offset: 0x000E9D65
		public float GetAdditionalWidth()
		{
			return UUISizeControlByOther.__GetAdditionalWidth_Internal(base.NativePtr);
		}

		// Token: 0x06009E90 RID: 40592 RVA: 0x000EBB72 File Offset: 0x000E9D72
		public float GetAdditionalHeight()
		{
			return UUISizeControlByOther.__GetAdditionalHeight_Internal(base.NativePtr);
		}

		// Token: 0x06009E91 RID: 40593
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTargetActor_Internal(IntPtr @this, IntPtr NewTargetActor);

		// Token: 0x06009E92 RID: 40594
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetControlWidth_Internal(IntPtr @this, bool value);

		// Token: 0x06009E93 RID: 40595
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetControlHeight_Internal(IntPtr @this, bool value);

		// Token: 0x06009E94 RID: 40596
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAdditionalWidth_Internal(IntPtr @this, float value);

		// Token: 0x06009E95 RID: 40597
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAdditionalHeight_Internal(IntPtr @this, float value);

		// Token: 0x06009E96 RID: 40598
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetTargetActor_Internal(IntPtr @this);

		// Token: 0x06009E97 RID: 40599
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetControlWidth_Internal(IntPtr @this);

		// Token: 0x06009E98 RID: 40600
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetControlHeight_Internal(IntPtr @this);

		// Token: 0x06009E99 RID: 40601
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetAdditionalWidth_Internal(IntPtr @this);

		// Token: 0x06009E9A RID: 40602
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetAdditionalHeight_Internal(IntPtr @this);

		// Token: 0x06009E9B RID: 40603 RVA: 0x000EBB7F File Offset: 0x000E9D7F
		static UUISizeControlByOther()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UISizeControlByOther");
		}

		// Token: 0x06009E9C RID: 40604 RVA: 0x000EBB8D File Offset: 0x000E9D8D
		protected UUISizeControlByOther(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04004401 RID: 17409
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UISizeControlByOther";

		// Token: 0x04004402 RID: 17410
		private static IntPtr _ClassPtr;

		// Token: 0x04004403 RID: 17411
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04004404 RID: 17412
		internal static int __PropertyOffset_TargetActor;

		// Token: 0x04004405 RID: 17413
		internal static int __PropertyOffset_ControlWidth;

		// Token: 0x04004406 RID: 17414
		internal static int __PropertyOffset_ControlHeight;

		// Token: 0x04004407 RID: 17415
		internal static int __PropertyOffset_UseWidthRange;

		// Token: 0x04004408 RID: 17416
		internal static int __PropertyOffset_UseHeightRange;

		// Token: 0x04004409 RID: 17417
		internal static int __PropertyOffset_MaxWidth;

		// Token: 0x0400440A RID: 17418
		internal static int __PropertyOffset_MinWidth;

		// Token: 0x0400440B RID: 17419
		internal static int __PropertyOffset_MaxHeight;

		// Token: 0x0400440C RID: 17420
		internal static int __PropertyOffset_MinHeight;

		// Token: 0x0400440D RID: 17421
		internal static int __PropertyOffset_AdditionalWidth;

		// Token: 0x0400440E RID: 17422
		internal static int __PropertyOffset_AdditionalHeight;

		// Token: 0x0400440F RID: 17423
		internal static int __PropertyOffset_bSizeZeroWhenNotActive;

		// Token: 0x04004410 RID: 17424
		internal static int __PropertyOffset_TargetUIItem;
	}
}
