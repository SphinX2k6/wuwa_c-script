using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200213B RID: 8507
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UIDraggableComponent")]
	[UnrealStructLayout(768, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 768)]
	public class UUIDraggableComponent : ULGUIBehaviour, IUnrealUObject, IUnrealObject, ILGUIPointerDownUpInterface, IUnrealNativeInterface, IUnrealInterface, ILGUIPointerDragInterface, ILGUIPointerScrollInterface, ILGUIPointerEnterExitInterface, ILGUIPointerInterruptInterface
	{
		// Token: 0x06020069 RID: 131177 RVA: 0x002FA049 File Offset: 0x002F8249
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIDraggableComponent._ClassPtr;
		}

		// Token: 0x0602006A RID: 131178 RVA: 0x002FA055 File Offset: 0x002F8255
		int ILGUIPointerDownUpInterface.InterfaceOffset()
		{
			return UUIDraggableComponent.__InterfaceOffset_ILGUIPointerDownUpInterface;
		}

		// Token: 0x0602006B RID: 131179 RVA: 0x002FA05C File Offset: 0x002F825C
		int ILGUIPointerDragInterface.InterfaceOffset()
		{
			return UUIDraggableComponent.__InterfaceOffset_ILGUIPointerDragInterface;
		}

		// Token: 0x0602006C RID: 131180 RVA: 0x002FA063 File Offset: 0x002F8263
		int ILGUIPointerScrollInterface.InterfaceOffset()
		{
			return UUIDraggableComponent.__InterfaceOffset_ILGUIPointerScrollInterface;
		}

		// Token: 0x0602006D RID: 131181 RVA: 0x002FA06A File Offset: 0x002F826A
		int ILGUIPointerEnterExitInterface.InterfaceOffset()
		{
			return UUIDraggableComponent.__InterfaceOffset_ILGUIPointerEnterExitInterface;
		}

		// Token: 0x0602006E RID: 131182 RVA: 0x002FA071 File Offset: 0x002F8271
		int ILGUIPointerInterruptInterface.InterfaceOffset()
		{
			return UUIDraggableComponent.__InterfaceOffset_ILGUIPointerInterruptInterface;
		}

		// Token: 0x0602006F RID: 131183 RVA: 0x002FA078 File Offset: 0x002F8278
		public UUIDraggableComponent() : this(BuiltinUtils.AllocNativeUObject(UUIDraggableComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020070 RID: 131184 RVA: 0x002FA0A0 File Offset: 0x002F82A0
		public UUIDraggableComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUIDraggableComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007DCE RID: 32206
		// (get) Token: 0x06020071 RID: 131185 RVA: 0x002FA0D4 File Offset: 0x002F82D4
		// (set) Token: 0x06020072 RID: 131186 RVA: 0x002FA10D File Offset: 0x002F830D
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

		// Token: 0x17007DCF RID: 32207
		// (get) Token: 0x06020073 RID: 131187 RVA: 0x002FA130 File Offset: 0x002F8330
		// (set) Token: 0x06020074 RID: 131188 RVA: 0x002FA169 File Offset: 0x002F8369
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

		// Token: 0x17007DD0 RID: 32208
		// (get) Token: 0x06020075 RID: 131189 RVA: 0x002FA18C File Offset: 0x002F838C
		// (set) Token: 0x06020076 RID: 131190 RVA: 0x002FA1C5 File Offset: 0x002F83C5
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

		// Token: 0x17007DD1 RID: 32209
		// (get) Token: 0x06020077 RID: 131191 RVA: 0x002FA1E8 File Offset: 0x002F83E8
		// (set) Token: 0x06020078 RID: 131192 RVA: 0x002FA221 File Offset: 0x002F8421
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

		// Token: 0x17007DD2 RID: 32210
		// (get) Token: 0x06020079 RID: 131193 RVA: 0x002FA244 File Offset: 0x002F8444
		// (set) Token: 0x0602007A RID: 131194 RVA: 0x002FA27D File Offset: 0x002F847D
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

		// Token: 0x17007DD3 RID: 32211
		// (get) Token: 0x0602007B RID: 131195 RVA: 0x002FA2A0 File Offset: 0x002F84A0
		// (set) Token: 0x0602007C RID: 131196 RVA: 0x002FA2D9 File Offset: 0x002F84D9
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

		// Token: 0x17007DD4 RID: 32212
		// (get) Token: 0x0602007D RID: 131197 RVA: 0x002FA2FC File Offset: 0x002F84FC
		// (set) Token: 0x0602007E RID: 131198 RVA: 0x002FA335 File Offset: 0x002F8535
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

		// Token: 0x17007DD5 RID: 32213
		// (get) Token: 0x0602007F RID: 131199 RVA: 0x002FA358 File Offset: 0x002F8558
		// (set) Token: 0x06020080 RID: 131200 RVA: 0x002FA391 File Offset: 0x002F8591
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

		// Token: 0x17007DD6 RID: 32214
		// (get) Token: 0x06020081 RID: 131201 RVA: 0x002FA3B4 File Offset: 0x002F85B4
		// (set) Token: 0x06020082 RID: 131202 RVA: 0x002FA3ED File Offset: 0x002F85ED
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

		// Token: 0x17007DD7 RID: 32215
		// (get) Token: 0x06020083 RID: 131203 RVA: 0x002FA40E File Offset: 0x002F860E
		// (set) Token: 0x06020084 RID: 131204 RVA: 0x002FA41E File Offset: 0x002F861E
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

		// Token: 0x17007DD8 RID: 32216
		// (get) Token: 0x06020085 RID: 131205 RVA: 0x002FA42F File Offset: 0x002F862F
		// (set) Token: 0x06020086 RID: 131206 RVA: 0x002FA43F File Offset: 0x002F863F
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

		// Token: 0x17007DD9 RID: 32217
		// (get) Token: 0x06020087 RID: 131207 RVA: 0x002FA450 File Offset: 0x002F8650
		// (set) Token: 0x06020088 RID: 131208 RVA: 0x002FA489 File Offset: 0x002F8689
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

		// Token: 0x17007DDA RID: 32218
		// (get) Token: 0x06020089 RID: 131209 RVA: 0x002FA4AC File Offset: 0x002F86AC
		// (set) Token: 0x0602008A RID: 131210 RVA: 0x002FA4E5 File Offset: 0x002F86E5
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

		// Token: 0x0602008B RID: 131211 RVA: 0x002FA506 File Offset: 0x002F8706
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void NotifyNavigateToPrev()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UUIDraggableComponent.__NotifyNavigateToPrev_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602008C RID: 131212 RVA: 0x002FA51B File Offset: 0x002F871B
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void NotifyNavigateToNext()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UUIDraggableComponent.__NotifyNavigateToNext_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0602008D RID: 131213 RVA: 0x002FA530 File Offset: 0x002F8730
		static UUIDraggableComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIDraggableComponent");
		}

		// Token: 0x0602008E RID: 131214 RVA: 0x002FA53E File Offset: 0x002F873E
		protected UUIDraggableComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040113DC RID: 70620
		internal static int __InterfaceOffset_ILGUIPointerDownUpInterface;

		// Token: 0x040113DD RID: 70621
		internal static int __InterfaceOffset_ILGUIPointerDragInterface;

		// Token: 0x040113DE RID: 70622
		internal static int __InterfaceOffset_ILGUIPointerScrollInterface;

		// Token: 0x040113DF RID: 70623
		internal static int __InterfaceOffset_ILGUIPointerEnterExitInterface;

		// Token: 0x040113E0 RID: 70624
		internal static int __InterfaceOffset_ILGUIPointerInterruptInterface;

		// Token: 0x040113E1 RID: 70625
		public new const string __ObjectPath = "/Script/LGUI.UIDraggableComponent";

		// Token: 0x040113E2 RID: 70626
		private static IntPtr _ClassPtr;

		// Token: 0x040113E3 RID: 70627
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040113E4 RID: 70628
		internal static int __PropertyOffset_OnPointerDownCallBack;

		// Token: 0x040113E5 RID: 70629
		[Nullable(2)]
		private FLGUIDraggableDynamicDelegate _OnPointerDownCallBack;

		// Token: 0x040113E6 RID: 70630
		internal static int __PropertyOffset_OnPointerUpCallBack;

		// Token: 0x040113E7 RID: 70631
		[Nullable(2)]
		private FLGUIDraggableDynamicDelegate _OnPointerUpCallBack;

		// Token: 0x040113E8 RID: 70632
		internal static int __PropertyOffset_OnPointerCancelCallBack;

		// Token: 0x040113E9 RID: 70633
		[Nullable(2)]
		private FLGUIDraggableDynamicDelegate _OnPointerCancelCallBack;

		// Token: 0x040113EA RID: 70634
		internal static int __PropertyOffset_OnPointerBeginDragCallBack;

		// Token: 0x040113EB RID: 70635
		[Nullable(2)]
		private FLGUIDraggableDynamicDelegate _OnPointerBeginDragCallBack;

		// Token: 0x040113EC RID: 70636
		internal static int __PropertyOffset_OnPointerDragCallBack;

		// Token: 0x040113ED RID: 70637
		[Nullable(2)]
		private FLGUIDraggableDynamicDelegate _OnPointerDragCallBack;

		// Token: 0x040113EE RID: 70638
		internal static int __PropertyOffset_OnPointerEndDragCallBack;

		// Token: 0x040113EF RID: 70639
		[Nullable(2)]
		private FLGUIDraggableDynamicDelegate _OnPointerEndDragCallBack;

		// Token: 0x040113F0 RID: 70640
		internal static int __PropertyOffset_OnPointerScrollCallBack;

		// Token: 0x040113F1 RID: 70641
		[Nullable(2)]
		private FLGUIDraggableDynamicDelegate _OnPointerScrollCallBack;

		// Token: 0x040113F2 RID: 70642
		internal static int __PropertyOffset_OnUIDimensionsChangedCallBack;

		// Token: 0x040113F3 RID: 70643
		[Nullable(2)]
		private FLGUIDraggableDynamicDelegateTwoParams _OnUIDimensionsChangedCallBack;

		// Token: 0x040113F4 RID: 70644
		internal static int __PropertyOffset_NeedInterruptDelegate;

		// Token: 0x040113F5 RID: 70645
		[Nullable(2)]
		private FLGUIDraggableNeedInterruptDelegate _NeedInterruptDelegate;

		// Token: 0x040113F6 RID: 70646
		internal static int __PropertyOffset_bNeedInterrupt;

		// Token: 0x040113F7 RID: 70647
		internal static int __PropertyOffset_AllowEventBubbleUp;

		// Token: 0x040113F8 RID: 70648
		internal static int __PropertyOffset_NavigateToPrevDelegate;

		// Token: 0x040113F9 RID: 70649
		[Nullable(2)]
		private FLGUIDraggableNavigateToPrevDelegate _NavigateToPrevDelegate;

		// Token: 0x040113FA RID: 70650
		internal static int __PropertyOffset_NavigateToNextDelegate;

		// Token: 0x040113FB RID: 70651
		[Nullable(2)]
		private FLGUIDraggableNavigateToNextDelegate _NavigateToNextDelegate;

		// Token: 0x040113FC RID: 70652
		private static IntPtr __NotifyNavigateToPrev_NativeFunctionPtr;

		// Token: 0x040113FD RID: 70653
		private static IntPtr __NotifyNavigateToNext_NativeFunctionPtr;
	}
}
