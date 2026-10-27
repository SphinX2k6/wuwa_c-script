using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020021DC RID: 8668
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UIToggleGroupComponent")]
	[UnrealStructLayout(328, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 328)]
	public class UUIToggleGroupComponent : UActorComponent, IUnrealUObject, IUnrealObject, ILGUIPointerEnterExitInterface, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x0602109D RID: 135325 RVA: 0x0030BC40 File Offset: 0x00309E40
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIToggleGroupComponent._ClassPtr;
		}

		// Token: 0x0602109E RID: 135326 RVA: 0x0030BC4C File Offset: 0x00309E4C
		int ILGUIPointerEnterExitInterface.InterfaceOffset()
		{
			return UUIToggleGroupComponent.__InterfaceOffset_ILGUIPointerEnterExitInterface;
		}

		// Token: 0x0602109F RID: 135327 RVA: 0x0030BC54 File Offset: 0x00309E54
		public UUIToggleGroupComponent() : this(BuiltinUtils.AllocNativeUObject(UUIToggleGroupComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060210A0 RID: 135328 RVA: 0x0030BC7C File Offset: 0x00309E7C
		[NullableContext(1)]
		public UUIToggleGroupComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUIToggleGroupComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170080F8 RID: 33016
		// (get) Token: 0x060210A1 RID: 135329 RVA: 0x0030BCAF File Offset: 0x00309EAF
		// (set) Token: 0x060210A2 RID: 135330 RVA: 0x0030BCC3 File Offset: 0x00309EC3
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<UUIToggleComponent> LastSelect
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UUIToggleGroupComponent.__PropertyOffset_LastSelect);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UUIToggleGroupComponent.__PropertyOffset_LastSelect) = value;
			}
		}

		// Token: 0x170080F9 RID: 33017
		// (get) Token: 0x060210A3 RID: 135331 RVA: 0x0030BCD8 File Offset: 0x00309ED8
		// (set) Token: 0x060210A4 RID: 135332 RVA: 0x0030BD11 File Offset: 0x00309F11
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TArray<TWeakObjectPtr<UUIToggleComponent>> ToggleCollection
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			get
			{
				base.FastCheckIsValid();
				TArray<TWeakObjectPtr<UUIToggleComponent>> result;
				if ((result = this._ToggleCollection) == null)
				{
					result = (this._ToggleCollection = new TArray<TWeakObjectPtr<UUIToggleComponent>>(base.NativePtr + (IntPtr)UUIToggleGroupComponent.__PropertyOffset_ToggleCollection, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			set
			{
				this.ToggleCollection.CopyAssign(value);
			}
		}

		// Token: 0x170080FA RID: 33018
		// (get) Token: 0x060210A5 RID: 135333 RVA: 0x0030BD1F File Offset: 0x00309F1F
		// (set) Token: 0x060210A6 RID: 135334 RVA: 0x0030BD2F File Offset: 0x00309F2F
		public unsafe bool bAllowNoneSelected
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIToggleGroupComponent.__PropertyOffset_bAllowNoneSelected) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIToggleGroupComponent.__PropertyOffset_bAllowNoneSelected) = (value ? 1 : 0);
			}
		}

		// Token: 0x170080FB RID: 33019
		// (get) Token: 0x060210A7 RID: 135335 RVA: 0x0030BD40 File Offset: 0x00309F40
		// (set) Token: 0x060210A8 RID: 135336 RVA: 0x0030BD79 File Offset: 0x00309F79
		[Nullable(1)]
		public FLGUIDrawableEvent OnToggle
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FLGUIDrawableEvent result;
				if ((result = this._OnToggle) == null)
				{
					result = (this._OnToggle = new FLGUIDrawableEvent(base.NativePtr + (IntPtr)UUIToggleGroupComponent.__PropertyOffset_OnToggle, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FLGUIDrawableEvent.StaticStruct(), base.NativePtr + (IntPtr)UUIToggleGroupComponent.__PropertyOffset_OnToggle, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170080FC RID: 33020
		// (get) Token: 0x060210A9 RID: 135337 RVA: 0x0030BD9A File Offset: 0x00309F9A
		// (set) Token: 0x060210AA RID: 135338 RVA: 0x0030BDAA File Offset: 0x00309FAA
		public unsafe bool AllowEventBubbleUp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIToggleGroupComponent.__PropertyOffset_AllowEventBubbleUp) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIToggleGroupComponent.__PropertyOffset_AllowEventBubbleUp) = (value ? 1 : 0);
			}
		}

		// Token: 0x170080FD RID: 33021
		// (get) Token: 0x060210AB RID: 135339 RVA: 0x0030BDBB File Offset: 0x00309FBB
		// (set) Token: 0x060210AC RID: 135340 RVA: 0x0030BDCF File Offset: 0x00309FCF
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<UUIToggleComponent> Selected
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UUIToggleGroupComponent.__PropertyOffset_Selected);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UUIToggleGroupComponent.__PropertyOffset_Selected) = value;
			}
		}

		// Token: 0x170080FE RID: 33022
		// (get) Token: 0x060210AD RID: 135341 RVA: 0x0030BDE4 File Offset: 0x00309FE4
		// (set) Token: 0x060210AE RID: 135342 RVA: 0x0030BDF8 File Offset: 0x00309FF8
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<UUIToggleComponent> Highlighted
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UUIToggleGroupComponent.__PropertyOffset_Highlighted);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UUIToggleGroupComponent.__PropertyOffset_Highlighted) = value;
			}
		}

		// Token: 0x170080FF RID: 33023
		// (get) Token: 0x060210AF RID: 135343 RVA: 0x0030BE10 File Offset: 0x0030A010
		// (set) Token: 0x060210B0 RID: 135344 RVA: 0x0030BE49 File Offset: 0x0030A049
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TArray<TWeakObjectPtr<UUIToggleComponent>> SelectableComponents
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			get
			{
				base.FastCheckIsValid();
				TArray<TWeakObjectPtr<UUIToggleComponent>> result;
				if ((result = this._SelectableComponents) == null)
				{
					result = (this._SelectableComponents = new TArray<TWeakObjectPtr<UUIToggleComponent>>(base.NativePtr + (IntPtr)UUIToggleGroupComponent.__PropertyOffset_SelectableComponents, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			set
			{
				this.SelectableComponents.CopyAssign(value);
			}
		}

		// Token: 0x060210B1 RID: 135345 RVA: 0x0030BE57 File Offset: 0x0030A057
		public void UnregisterToggleEvent(in FLGUIDelegateHandleWrapper InDelegateHandle)
		{
			UUIToggleGroupComponent.__UnregisterToggleEvent_Internal(base.NativePtr, (InDelegateHandle ?? new FLGUIDelegateHandleWrapper()).NativePtr);
		}

		// Token: 0x060210B2 RID: 135346 RVA: 0x0030BE74 File Offset: 0x0030A074
		public void SetSelection(UUIToggleComponent Target)
		{
			UUIToggleGroupComponent.__SetSelection_Internal(base.NativePtr, (Target != null) ? Target.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060210B3 RID: 135347 RVA: 0x0030BE91 File Offset: 0x0030A091
		public void SetAllowNoneSelected(bool InBool)
		{
			UUIToggleGroupComponent.__SetAllowNoneSelected_Internal(base.NativePtr, InBool);
		}

		// Token: 0x060210B4 RID: 135348 RVA: 0x0030BE9F File Offset: 0x0030A09F
		[NullableContext(1)]
		public FLGUIDelegateHandleWrapper RegisterToggleEvent([Nullable(2)] in FLGUIToggleGroupDynamicDelegate InDelegate)
		{
			IntPtr nativePtr = base.NativePtr;
			FLGUIToggleGroupDynamicDelegate flguitoggleGroupDynamicDelegate = InDelegate;
			return new FLGUIDelegateHandleWrapper(UUIToggleGroupComponent.__RegisterToggleEvent_Internal(nativePtr, (flguitoggleGroupDynamicDelegate != null) ? flguitoggleGroupDynamicDelegate.NativePtr : ((IntPtr)0)), null);
		}

		// Token: 0x060210B5 RID: 135349 RVA: 0x0030BEC1 File Offset: 0x0030A0C1
		public void OnComponentUnselected()
		{
			UUIToggleGroupComponent.__OnComponentUnselected_Internal(base.NativePtr);
		}

		// Token: 0x060210B6 RID: 135350 RVA: 0x0030BECE File Offset: 0x0030A0CE
		public void OnComponentUnhighlighted()
		{
			UUIToggleGroupComponent.__OnComponentUnhighlighted_Internal(base.NativePtr);
		}

		// Token: 0x060210B7 RID: 135351 RVA: 0x0030BEDB File Offset: 0x0030A0DB
		public void OnComponentSelected(UUIToggleComponent Component)
		{
			UUIToggleGroupComponent.__OnComponentSelected_Internal(base.NativePtr, (Component != null) ? Component.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060210B8 RID: 135352 RVA: 0x0030BEF8 File Offset: 0x0030A0F8
		public void OnComponentHighlighted(UUIToggleComponent Component)
		{
			UUIToggleGroupComponent.__OnComponentHighlighted_Internal(base.NativePtr, (Component != null) ? Component.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060210B9 RID: 135353 RVA: 0x0030BF15 File Offset: 0x0030A115
		public int GetToggleIndex(UUIToggleComponent InComp)
		{
			return UUIToggleGroupComponent.__GetToggleIndex_Internal(base.NativePtr, (InComp != null) ? InComp.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060210BA RID: 135354 RVA: 0x0030BF32 File Offset: 0x0030A132
		public UUIToggleComponent GetToggleByIndex(int InIndex)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UUIToggleComponent>(UUIToggleGroupComponent.__GetToggleByIndex_Internal(base.NativePtr, InIndex));
		}

		// Token: 0x060210BB RID: 135355 RVA: 0x0030BF45 File Offset: 0x0030A145
		public UUIToggleComponent GetSelectedItem()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UUIToggleComponent>(UUIToggleGroupComponent.__GetSelectedItem_Internal(base.NativePtr));
		}

		// Token: 0x060210BC RID: 135356 RVA: 0x0030BF57 File Offset: 0x0030A157
		public bool GetAllowNoneSelected()
		{
			return UUIToggleGroupComponent.__GetAllowNoneSelected_Internal(base.NativePtr);
		}

		// Token: 0x060210BD RID: 135357 RVA: 0x0030BF64 File Offset: 0x0030A164
		public void ClearSelection()
		{
			UUIToggleGroupComponent.__ClearSelection_Internal(base.NativePtr);
		}

		// Token: 0x060210BE RID: 135358
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnregisterToggleEvent_Internal(IntPtr @this, IntPtr InDelegateHandle);

		// Token: 0x060210BF RID: 135359
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSelection_Internal(IntPtr @this, IntPtr Target);

		// Token: 0x060210C0 RID: 135360
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAllowNoneSelected_Internal(IntPtr @this, bool InBool);

		// Token: 0x060210C1 RID: 135361
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __RegisterToggleEvent_Internal(IntPtr @this, IntPtr InDelegate);

		// Token: 0x060210C2 RID: 135362
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnComponentUnselected_Internal(IntPtr @this);

		// Token: 0x060210C3 RID: 135363
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnComponentUnhighlighted_Internal(IntPtr @this);

		// Token: 0x060210C4 RID: 135364
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnComponentSelected_Internal(IntPtr @this, IntPtr Component);

		// Token: 0x060210C5 RID: 135365
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnComponentHighlighted_Internal(IntPtr @this, IntPtr Component);

		// Token: 0x060210C6 RID: 135366
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetToggleIndex_Internal(IntPtr @this, IntPtr InComp);

		// Token: 0x060210C7 RID: 135367
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetToggleByIndex_Internal(IntPtr @this, int InIndex);

		// Token: 0x060210C8 RID: 135368
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetSelectedItem_Internal(IntPtr @this);

		// Token: 0x060210C9 RID: 135369
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetAllowNoneSelected_Internal(IntPtr @this);

		// Token: 0x060210CA RID: 135370
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearSelection_Internal(IntPtr @this);

		// Token: 0x060210CB RID: 135371 RVA: 0x0030BF71 File Offset: 0x0030A171
		static UUIToggleGroupComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIToggleGroupComponent");
		}

		// Token: 0x060210CC RID: 135372 RVA: 0x0030BF7F File Offset: 0x0030A17F
		protected UUIToggleGroupComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011A12 RID: 72210
		internal static int __InterfaceOffset_ILGUIPointerEnterExitInterface;

		// Token: 0x04011A13 RID: 72211
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UIToggleGroupComponent";

		// Token: 0x04011A14 RID: 72212
		private static IntPtr _ClassPtr;

		// Token: 0x04011A15 RID: 72213
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011A16 RID: 72214
		internal static int __PropertyOffset_LastSelect;

		// Token: 0x04011A17 RID: 72215
		internal static int __PropertyOffset_ToggleCollection;

		// Token: 0x04011A18 RID: 72216
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TArray<TWeakObjectPtr<UUIToggleComponent>> _ToggleCollection;

		// Token: 0x04011A19 RID: 72217
		internal static int __PropertyOffset_bAllowNoneSelected;

		// Token: 0x04011A1A RID: 72218
		internal static int __PropertyOffset_OnToggle;

		// Token: 0x04011A1B RID: 72219
		private FLGUIDrawableEvent _OnToggle;

		// Token: 0x04011A1C RID: 72220
		internal static int __PropertyOffset_AllowEventBubbleUp;

		// Token: 0x04011A1D RID: 72221
		internal static int __PropertyOffset_Selected;

		// Token: 0x04011A1E RID: 72222
		internal static int __PropertyOffset_Highlighted;

		// Token: 0x04011A1F RID: 72223
		internal static int __PropertyOffset_SelectableComponents;

		// Token: 0x04011A20 RID: 72224
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TArray<TWeakObjectPtr<UUIToggleComponent>> _SelectableComponents;
	}
}
