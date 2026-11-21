using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006F0 RID: 1776
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UIDraggableComponent")]
	[UnrealStructLayout(768, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 768)]
	public class UUIDraggableComponent : ULGUIBehaviour, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060096D9 RID: 38617 RVA: 0x000E38FB File Offset: 0x000E1AFB
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIDraggableComponent._ClassPtr;
		}

		// Token: 0x060096DA RID: 38618 RVA: 0x000E3908 File Offset: 0x000E1B08
		public UUIDraggableComponent() : this(BuiltinUtils.AllocNativeUObject(UUIDraggableComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060096DB RID: 38619 RVA: 0x000E3930 File Offset: 0x000E1B30
		public UUIDraggableComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUIDraggableComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001C00 RID: 7168
		// (get) Token: 0x060096DC RID: 38620 RVA: 0x000E3964 File Offset: 0x000E1B64
		// (set) Token: 0x060096DD RID: 38621 RVA: 0x000E399D File Offset: 0x000E1B9D
		public FLGUIDraggableDynamicDelegate OnPointerDownCallBack
		{
			get
			{
				base.FastCheckIsValid();
				FLGUIDraggableDynamicDelegate result;
				if ((result = this._OnPointerDownCallBack) == null)
				{
					result = (this._OnPointerDownCallBack = new FLGUIDraggableDynamicDelegate(base.NativePtr + (IntPtr)UUIDraggableComponent.__PropertyOffset_OnPointerDownCallBack, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UUIDraggableComponent.__PropertyOffset_OnPointerDownCallBack, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17001C01 RID: 7169
		// (get) Token: 0x060096DE RID: 38622 RVA: 0x000E39C0 File Offset: 0x000E1BC0
		// (set) Token: 0x060096DF RID: 38623 RVA: 0x000E39F9 File Offset: 0x000E1BF9
		public FLGUIDraggableDynamicDelegate OnPointerUpCallBack
		{
			get
			{
				base.FastCheckIsValid();
				FLGUIDraggableDynamicDelegate result;
				if ((result = this._OnPointerUpCallBack) == null)
				{
					result = (this._OnPointerUpCallBack = new FLGUIDraggableDynamicDelegate(base.NativePtr + (IntPtr)UUIDraggableComponent.__PropertyOffset_OnPointerUpCallBack, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UUIDraggableComponent.__PropertyOffset_OnPointerUpCallBack, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17001C02 RID: 7170
		// (get) Token: 0x060096E0 RID: 38624 RVA: 0x000E3A1C File Offset: 0x000E1C1C
		// (set) Token: 0x060096E1 RID: 38625 RVA: 0x000E3A55 File Offset: 0x000E1C55
		public FLGUIDraggableDynamicDelegate OnPointerCancelCallBack
		{
			get
			{
				base.FastCheckIsValid();
				FLGUIDraggableDynamicDelegate result;
				if ((result = this._OnPointerCancelCallBack) == null)
				{
					result = (this._OnPointerCancelCallBack = new FLGUIDraggableDynamicDelegate(base.NativePtr + (IntPtr)UUIDraggableComponent.__PropertyOffset_OnPointerCancelCallBack, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UUIDraggableComponent.__PropertyOffset_OnPointerCancelCallBack, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17001C03 RID: 7171
		// (get) Token: 0x060096E2 RID: 38626 RVA: 0x000E3A78 File Offset: 0x000E1C78
		// (set) Token: 0x060096E3 RID: 38627 RVA: 0x000E3AB1 File Offset: 0x000E1CB1
		public FLGUIDraggableDynamicDelegate OnPointerBeginDragCallBack
		{
			get
			{
				base.FastCheckIsValid();
				FLGUIDraggableDynamicDelegate result;
				if ((result = this._OnPointerBeginDragCallBack) == null)
				{
					result = (this._OnPointerBeginDragCallBack = new FLGUIDraggableDynamicDelegate(base.NativePtr + (IntPtr)UUIDraggableComponent.__PropertyOffset_OnPointerBeginDragCallBack, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UUIDraggableComponent.__PropertyOffset_OnPointerBeginDragCallBack, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17001C04 RID: 7172
		// (get) Token: 0x060096E4 RID: 38628 RVA: 0x000E3AD4 File Offset: 0x000E1CD4
		// (set) Token: 0x060096E5 RID: 38629 RVA: 0x000E3B0D File Offset: 0x000E1D0D
		public FLGUIDraggableDynamicDelegate OnPointerDragCallBack
		{
			get
			{
				base.FastCheckIsValid();
				FLGUIDraggableDynamicDelegate result;
				if ((result = this._OnPointerDragCallBack) == null)
				{
					result = (this._OnPointerDragCallBack = new FLGUIDraggableDynamicDelegate(base.NativePtr + (IntPtr)UUIDraggableComponent.__PropertyOffset_OnPointerDragCallBack, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UUIDraggableComponent.__PropertyOffset_OnPointerDragCallBack, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17001C05 RID: 7173
		// (get) Token: 0x060096E6 RID: 38630 RVA: 0x000E3B30 File Offset: 0x000E1D30
		// (set) Token: 0x060096E7 RID: 38631 RVA: 0x000E3B69 File Offset: 0x000E1D69
		public FLGUIDraggableDynamicDelegate OnPointerEndDragCallBack
		{
			get
			{
				base.FastCheckIsValid();
				FLGUIDraggableDynamicDelegate result;
				if ((result = this._OnPointerEndDragCallBack) == null)
				{
					result = (this._OnPointerEndDragCallBack = new FLGUIDraggableDynamicDelegate(base.NativePtr + (IntPtr)UUIDraggableComponent.__PropertyOffset_OnPointerEndDragCallBack, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UUIDraggableComponent.__PropertyOffset_OnPointerEndDragCallBack, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17001C06 RID: 7174
		// (get) Token: 0x060096E8 RID: 38632 RVA: 0x000E3B8C File Offset: 0x000E1D8C
		// (set) Token: 0x060096E9 RID: 38633 RVA: 0x000E3BC5 File Offset: 0x000E1DC5
		public FLGUIDraggableDynamicDelegate OnPointerScrollCallBack
		{
			get
			{
				base.FastCheckIsValid();
				FLGUIDraggableDynamicDelegate result;
				if ((result = this._OnPointerScrollCallBack) == null)
				{
					result = (this._OnPointerScrollCallBack = new FLGUIDraggableDynamicDelegate(base.NativePtr + (IntPtr)UUIDraggableComponent.__PropertyOffset_OnPointerScrollCallBack, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UUIDraggableComponent.__PropertyOffset_OnPointerScrollCallBack, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17001C07 RID: 7175
		// (get) Token: 0x060096EA RID: 38634 RVA: 0x000E3BE8 File Offset: 0x000E1DE8
		// (set) Token: 0x060096EB RID: 38635 RVA: 0x000E3C21 File Offset: 0x000E1E21
		public FLGUIDraggableDynamicDelegateTwoParams OnUIDimensionsChangedCallBack
		{
			get
			{
				base.FastCheckIsValid();
				FLGUIDraggableDynamicDelegateTwoParams result;
				if ((result = this._OnUIDimensionsChangedCallBack) == null)
				{
					result = (this._OnUIDimensionsChangedCallBack = new FLGUIDraggableDynamicDelegateTwoParams(base.NativePtr + (IntPtr)UUIDraggableComponent.__PropertyOffset_OnUIDimensionsChangedCallBack, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UUIDraggableComponent.__PropertyOffset_OnUIDimensionsChangedCallBack, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17001C08 RID: 7176
		// (get) Token: 0x060096EC RID: 38636 RVA: 0x000E3C44 File Offset: 0x000E1E44
		// (set) Token: 0x060096ED RID: 38637 RVA: 0x000E3C7D File Offset: 0x000E1E7D
		public FLGUIDraggableNeedInterruptDelegate NeedInterruptDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FLGUIDraggableNeedInterruptDelegate result;
				if ((result = this._NeedInterruptDelegate) == null)
				{
					result = (this._NeedInterruptDelegate = new FLGUIDraggableNeedInterruptDelegate(base.NativePtr + (IntPtr)UUIDraggableComponent.__PropertyOffset_NeedInterruptDelegate, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UUIDraggableComponent.__PropertyOffset_NeedInterruptDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17001C09 RID: 7177
		// (get) Token: 0x060096EE RID: 38638 RVA: 0x000E3C9E File Offset: 0x000E1E9E
		// (set) Token: 0x060096EF RID: 38639 RVA: 0x000E3CAE File Offset: 0x000E1EAE
		public unsafe bool bNeedInterrupt
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIDraggableComponent.__PropertyOffset_bNeedInterrupt) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIDraggableComponent.__PropertyOffset_bNeedInterrupt) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001C0A RID: 7178
		// (get) Token: 0x060096F0 RID: 38640 RVA: 0x000E3CBF File Offset: 0x000E1EBF
		// (set) Token: 0x060096F1 RID: 38641 RVA: 0x000E3CCF File Offset: 0x000E1ECF
		public unsafe bool AllowEventBubbleUp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIDraggableComponent.__PropertyOffset_AllowEventBubbleUp) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIDraggableComponent.__PropertyOffset_AllowEventBubbleUp) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001C0B RID: 7179
		// (get) Token: 0x060096F2 RID: 38642 RVA: 0x000E3CE0 File Offset: 0x000E1EE0
		// (set) Token: 0x060096F3 RID: 38643 RVA: 0x000E3D19 File Offset: 0x000E1F19
		public FLGUIDraggableNavigateToPrevDelegate NavigateToPrevDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FLGUIDraggableNavigateToPrevDelegate result;
				if ((result = this._NavigateToPrevDelegate) == null)
				{
					result = (this._NavigateToPrevDelegate = new FLGUIDraggableNavigateToPrevDelegate(base.NativePtr + (IntPtr)UUIDraggableComponent.__PropertyOffset_NavigateToPrevDelegate, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UUIDraggableComponent.__PropertyOffset_NavigateToPrevDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17001C0C RID: 7180
		// (get) Token: 0x060096F4 RID: 38644 RVA: 0x000E3D3C File Offset: 0x000E1F3C
		// (set) Token: 0x060096F5 RID: 38645 RVA: 0x000E3D75 File Offset: 0x000E1F75
		public FLGUIDraggableNavigateToNextDelegate NavigateToNextDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FLGUIDraggableNavigateToNextDelegate result;
				if ((result = this._NavigateToNextDelegate) == null)
				{
					result = (this._NavigateToNextDelegate = new FLGUIDraggableNavigateToNextDelegate(base.NativePtr + (IntPtr)UUIDraggableComponent.__PropertyOffset_NavigateToNextDelegate, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UUIDraggableComponent.__PropertyOffset_NavigateToNextDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x060096F6 RID: 38646 RVA: 0x000E3D96 File Offset: 0x000E1F96
		[SkipLocalsInit]
		public void NotifyNavigateToPrev()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UUIDraggableComponent.__NotifyNavigateToPrev_NativeFunctionPtr, null);
		}

		// Token: 0x060096F7 RID: 38647 RVA: 0x000E3DAA File Offset: 0x000E1FAA
		[SkipLocalsInit]
		public void NotifyNavigateToNext()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UUIDraggableComponent.__NotifyNavigateToNext_NativeFunctionPtr, null);
		}

		// Token: 0x060096F8 RID: 38648 RVA: 0x000E3DBE File Offset: 0x000E1FBE
		static UUIDraggableComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIDraggableComponent");
		}

		// Token: 0x060096F9 RID: 38649 RVA: 0x000E3DCC File Offset: 0x000E1FCC
		protected UUIDraggableComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400419F RID: 16799
		public new const string __ObjectPath = "/Script/LGUI.UIDraggableComponent";

		// Token: 0x040041A0 RID: 16800
		private static IntPtr _ClassPtr;

		// Token: 0x040041A1 RID: 16801
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040041A2 RID: 16802
		internal static int __PropertyOffset_OnPointerDownCallBack;

		// Token: 0x040041A3 RID: 16803
		[Nullable(2)]
		private FLGUIDraggableDynamicDelegate _OnPointerDownCallBack;

		// Token: 0x040041A4 RID: 16804
		internal static int __PropertyOffset_OnPointerUpCallBack;

		// Token: 0x040041A5 RID: 16805
		[Nullable(2)]
		private FLGUIDraggableDynamicDelegate _OnPointerUpCallBack;

		// Token: 0x040041A6 RID: 16806
		internal static int __PropertyOffset_OnPointerCancelCallBack;

		// Token: 0x040041A7 RID: 16807
		[Nullable(2)]
		private FLGUIDraggableDynamicDelegate _OnPointerCancelCallBack;

		// Token: 0x040041A8 RID: 16808
		internal static int __PropertyOffset_OnPointerBeginDragCallBack;

		// Token: 0x040041A9 RID: 16809
		[Nullable(2)]
		private FLGUIDraggableDynamicDelegate _OnPointerBeginDragCallBack;

		// Token: 0x040041AA RID: 16810
		internal static int __PropertyOffset_OnPointerDragCallBack;

		// Token: 0x040041AB RID: 16811
		[Nullable(2)]
		private FLGUIDraggableDynamicDelegate _OnPointerDragCallBack;

		// Token: 0x040041AC RID: 16812
		internal static int __PropertyOffset_OnPointerEndDragCallBack;

		// Token: 0x040041AD RID: 16813
		[Nullable(2)]
		private FLGUIDraggableDynamicDelegate _OnPointerEndDragCallBack;

		// Token: 0x040041AE RID: 16814
		internal static int __PropertyOffset_OnPointerScrollCallBack;

		// Token: 0x040041AF RID: 16815
		[Nullable(2)]
		private FLGUIDraggableDynamicDelegate _OnPointerScrollCallBack;

		// Token: 0x040041B0 RID: 16816
		internal static int __PropertyOffset_OnUIDimensionsChangedCallBack;

		// Token: 0x040041B1 RID: 16817
		[Nullable(2)]
		private FLGUIDraggableDynamicDelegateTwoParams _OnUIDimensionsChangedCallBack;

		// Token: 0x040041B2 RID: 16818
		internal static int __PropertyOffset_NeedInterruptDelegate;

		// Token: 0x040041B3 RID: 16819
		[Nullable(2)]
		private FLGUIDraggableNeedInterruptDelegate _NeedInterruptDelegate;

		// Token: 0x040041B4 RID: 16820
		internal static int __PropertyOffset_bNeedInterrupt;

		// Token: 0x040041B5 RID: 16821
		internal static int __PropertyOffset_AllowEventBubbleUp;

		// Token: 0x040041B6 RID: 16822
		internal static int __PropertyOffset_NavigateToPrevDelegate;

		// Token: 0x040041B7 RID: 16823
		[Nullable(2)]
		private FLGUIDraggableNavigateToPrevDelegate _NavigateToPrevDelegate;

		// Token: 0x040041B8 RID: 16824
		internal static int __PropertyOffset_NavigateToNextDelegate;

		// Token: 0x040041B9 RID: 16825
		[Nullable(2)]
		private FLGUIDraggableNavigateToNextDelegate _NavigateToNextDelegate;

		// Token: 0x040041BA RID: 16826
		private static IntPtr __NotifyNavigateToPrev_NativeFunctionPtr;

		// Token: 0x040041BB RID: 16827
		private static IntPtr __NotifyNavigateToNext_NativeFunctionPtr;
	}
}
