using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002165 RID: 8549
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UIEventTriggerComponent")]
	[UnrealStructLayout(912, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 912)]
	public class UUIEventTriggerComponent : UActorComponent, IUnrealUObject, IUnrealObject, ILGUIPointerEnterExitInterface, IUnrealNativeInterface, IUnrealInterface, ILGUIPointerDownUpInterface, ILGUIPointerClickInterface, ILGUIPointerDragInterface, ILGUIPointerDragDropInterface, ILGUIPointerScrollInterface, ILGUIPointerSelectDeselectInterface
	{
		// Token: 0x060203D3 RID: 132051 RVA: 0x002FDDF3 File Offset: 0x002FBFF3
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIEventTriggerComponent._ClassPtr;
		}

		// Token: 0x060203D4 RID: 132052 RVA: 0x002FDDFF File Offset: 0x002FBFFF
		int ILGUIPointerEnterExitInterface.InterfaceOffset()
		{
			return UUIEventTriggerComponent.__InterfaceOffset_ILGUIPointerEnterExitInterface;
		}

		// Token: 0x060203D5 RID: 132053 RVA: 0x002FDE06 File Offset: 0x002FC006
		int ILGUIPointerDownUpInterface.InterfaceOffset()
		{
			return UUIEventTriggerComponent.__InterfaceOffset_ILGUIPointerDownUpInterface;
		}

		// Token: 0x060203D6 RID: 132054 RVA: 0x002FDE0D File Offset: 0x002FC00D
		int ILGUIPointerClickInterface.InterfaceOffset()
		{
			return UUIEventTriggerComponent.__InterfaceOffset_ILGUIPointerClickInterface;
		}

		// Token: 0x060203D7 RID: 132055 RVA: 0x002FDE14 File Offset: 0x002FC014
		int ILGUIPointerDragInterface.InterfaceOffset()
		{
			return UUIEventTriggerComponent.__InterfaceOffset_ILGUIPointerDragInterface;
		}

		// Token: 0x060203D8 RID: 132056 RVA: 0x002FDE1B File Offset: 0x002FC01B
		int ILGUIPointerDragDropInterface.InterfaceOffset()
		{
			return UUIEventTriggerComponent.__InterfaceOffset_ILGUIPointerDragDropInterface;
		}

		// Token: 0x060203D9 RID: 132057 RVA: 0x002FDE22 File Offset: 0x002FC022
		int ILGUIPointerScrollInterface.InterfaceOffset()
		{
			return UUIEventTriggerComponent.__InterfaceOffset_ILGUIPointerScrollInterface;
		}

		// Token: 0x060203DA RID: 132058 RVA: 0x002FDE29 File Offset: 0x002FC029
		int ILGUIPointerSelectDeselectInterface.InterfaceOffset()
		{
			return UUIEventTriggerComponent.__InterfaceOffset_ILGUIPointerSelectDeselectInterface;
		}

		// Token: 0x060203DB RID: 132059 RVA: 0x002FDE30 File Offset: 0x002FC030
		public UUIEventTriggerComponent() : this(BuiltinUtils.AllocNativeUObject(UUIEventTriggerComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060203DC RID: 132060 RVA: 0x002FDE58 File Offset: 0x002FC058
		public UUIEventTriggerComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUIEventTriggerComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007E62 RID: 32354
		// (get) Token: 0x060203DD RID: 132061 RVA: 0x002FDE8B File Offset: 0x002FC08B
		// (set) Token: 0x060203DE RID: 132062 RVA: 0x002FDE9B File Offset: 0x002FC09B
		public unsafe bool AllowEventBubbleUp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIEventTriggerComponent.__PropertyOffset_AllowEventBubbleUp) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIEventTriggerComponent.__PropertyOffset_AllowEventBubbleUp) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007E63 RID: 32355
		// (get) Token: 0x060203DF RID: 132063 RVA: 0x002FDEAC File Offset: 0x002FC0AC
		// (set) Token: 0x060203E0 RID: 132064 RVA: 0x002FDEE5 File Offset: 0x002FC0E5
		public FLGUIDrawableEvent OnPointerEnter
		{
			get
			{
				base.FastCheckIsValid();
				FLGUIDrawableEvent result;
				if ((result = this._OnPointerEnter) == null)
				{
					result = (this._OnPointerEnter = new FLGUIDrawableEvent(base.NativePtr + (IntPtr)UUIEventTriggerComponent.__PropertyOffset_OnPointerEnter, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FLGUIDrawableEvent.StaticStruct(), base.NativePtr + (IntPtr)UUIEventTriggerComponent.__PropertyOffset_OnPointerEnter, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007E64 RID: 32356
		// (get) Token: 0x060203E1 RID: 132065 RVA: 0x002FDF08 File Offset: 0x002FC108
		// (set) Token: 0x060203E2 RID: 132066 RVA: 0x002FDF41 File Offset: 0x002FC141
		public FLGUIDrawableEvent OnPointerExit
		{
			get
			{
				base.FastCheckIsValid();
				FLGUIDrawableEvent result;
				if ((result = this._OnPointerExit) == null)
				{
					result = (this._OnPointerExit = new FLGUIDrawableEvent(base.NativePtr + (IntPtr)UUIEventTriggerComponent.__PropertyOffset_OnPointerExit, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FLGUIDrawableEvent.StaticStruct(), base.NativePtr + (IntPtr)UUIEventTriggerComponent.__PropertyOffset_OnPointerExit, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007E65 RID: 32357
		// (get) Token: 0x060203E3 RID: 132067 RVA: 0x002FDF64 File Offset: 0x002FC164
		// (set) Token: 0x060203E4 RID: 132068 RVA: 0x002FDF9D File Offset: 0x002FC19D
		public FLGUIDrawableEvent OnPointerDown
		{
			get
			{
				base.FastCheckIsValid();
				FLGUIDrawableEvent result;
				if ((result = this._OnPointerDown) == null)
				{
					result = (this._OnPointerDown = new FLGUIDrawableEvent(base.NativePtr + (IntPtr)UUIEventTriggerComponent.__PropertyOffset_OnPointerDown, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FLGUIDrawableEvent.StaticStruct(), base.NativePtr + (IntPtr)UUIEventTriggerComponent.__PropertyOffset_OnPointerDown, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007E66 RID: 32358
		// (get) Token: 0x060203E5 RID: 132069 RVA: 0x002FDFC0 File Offset: 0x002FC1C0
		// (set) Token: 0x060203E6 RID: 132070 RVA: 0x002FDFF9 File Offset: 0x002FC1F9
		public FLGUIDrawableEvent OnPointerUp
		{
			get
			{
				base.FastCheckIsValid();
				FLGUIDrawableEvent result;
				if ((result = this._OnPointerUp) == null)
				{
					result = (this._OnPointerUp = new FLGUIDrawableEvent(base.NativePtr + (IntPtr)UUIEventTriggerComponent.__PropertyOffset_OnPointerUp, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FLGUIDrawableEvent.StaticStruct(), base.NativePtr + (IntPtr)UUIEventTriggerComponent.__PropertyOffset_OnPointerUp, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007E67 RID: 32359
		// (get) Token: 0x060203E7 RID: 132071 RVA: 0x002FE01C File Offset: 0x002FC21C
		// (set) Token: 0x060203E8 RID: 132072 RVA: 0x002FE055 File Offset: 0x002FC255
		public FLGUIDrawableEvent OnPointerCancel
		{
			get
			{
				base.FastCheckIsValid();
				FLGUIDrawableEvent result;
				if ((result = this._OnPointerCancel) == null)
				{
					result = (this._OnPointerCancel = new FLGUIDrawableEvent(base.NativePtr + (IntPtr)UUIEventTriggerComponent.__PropertyOffset_OnPointerCancel, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FLGUIDrawableEvent.StaticStruct(), base.NativePtr + (IntPtr)UUIEventTriggerComponent.__PropertyOffset_OnPointerCancel, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007E68 RID: 32360
		// (get) Token: 0x060203E9 RID: 132073 RVA: 0x002FE078 File Offset: 0x002FC278
		// (set) Token: 0x060203EA RID: 132074 RVA: 0x002FE0B1 File Offset: 0x002FC2B1
		public FLGUIDrawableEvent OnPointerClick
		{
			get
			{
				base.FastCheckIsValid();
				FLGUIDrawableEvent result;
				if ((result = this._OnPointerClick) == null)
				{
					result = (this._OnPointerClick = new FLGUIDrawableEvent(base.NativePtr + (IntPtr)UUIEventTriggerComponent.__PropertyOffset_OnPointerClick, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FLGUIDrawableEvent.StaticStruct(), base.NativePtr + (IntPtr)UUIEventTriggerComponent.__PropertyOffset_OnPointerClick, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007E69 RID: 32361
		// (get) Token: 0x060203EB RID: 132075 RVA: 0x002FE0D4 File Offset: 0x002FC2D4
		// (set) Token: 0x060203EC RID: 132076 RVA: 0x002FE10D File Offset: 0x002FC30D
		public FLGUIDrawableEvent OnPointerBeginDrag
		{
			get
			{
				base.FastCheckIsValid();
				FLGUIDrawableEvent result;
				if ((result = this._OnPointerBeginDrag) == null)
				{
					result = (this._OnPointerBeginDrag = new FLGUIDrawableEvent(base.NativePtr + (IntPtr)UUIEventTriggerComponent.__PropertyOffset_OnPointerBeginDrag, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FLGUIDrawableEvent.StaticStruct(), base.NativePtr + (IntPtr)UUIEventTriggerComponent.__PropertyOffset_OnPointerBeginDrag, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007E6A RID: 32362
		// (get) Token: 0x060203ED RID: 132077 RVA: 0x002FE130 File Offset: 0x002FC330
		// (set) Token: 0x060203EE RID: 132078 RVA: 0x002FE169 File Offset: 0x002FC369
		public FLGUIDrawableEvent OnPointerDrag
		{
			get
			{
				base.FastCheckIsValid();
				FLGUIDrawableEvent result;
				if ((result = this._OnPointerDrag) == null)
				{
					result = (this._OnPointerDrag = new FLGUIDrawableEvent(base.NativePtr + (IntPtr)UUIEventTriggerComponent.__PropertyOffset_OnPointerDrag, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FLGUIDrawableEvent.StaticStruct(), base.NativePtr + (IntPtr)UUIEventTriggerComponent.__PropertyOffset_OnPointerDrag, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007E6B RID: 32363
		// (get) Token: 0x060203EF RID: 132079 RVA: 0x002FE18C File Offset: 0x002FC38C
		// (set) Token: 0x060203F0 RID: 132080 RVA: 0x002FE1C5 File Offset: 0x002FC3C5
		public FLGUIDrawableEvent OnPointerEndDrag
		{
			get
			{
				base.FastCheckIsValid();
				FLGUIDrawableEvent result;
				if ((result = this._OnPointerEndDrag) == null)
				{
					result = (this._OnPointerEndDrag = new FLGUIDrawableEvent(base.NativePtr + (IntPtr)UUIEventTriggerComponent.__PropertyOffset_OnPointerEndDrag, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FLGUIDrawableEvent.StaticStruct(), base.NativePtr + (IntPtr)UUIEventTriggerComponent.__PropertyOffset_OnPointerEndDrag, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007E6C RID: 32364
		// (get) Token: 0x060203F1 RID: 132081 RVA: 0x002FE1E8 File Offset: 0x002FC3E8
		// (set) Token: 0x060203F2 RID: 132082 RVA: 0x002FE221 File Offset: 0x002FC421
		public FLGUIDrawableEvent OnPointerDragEnter_DEPRECATED
		{
			get
			{
				base.FastCheckIsValid();
				FLGUIDrawableEvent result;
				if ((result = this._OnPointerDragEnter_DEPRECATED) == null)
				{
					result = (this._OnPointerDragEnter_DEPRECATED = new FLGUIDrawableEvent(base.NativePtr + (IntPtr)UUIEventTriggerComponent.__PropertyOffset_OnPointerDragEnter_DEPRECATED, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FLGUIDrawableEvent.StaticStruct(), base.NativePtr + (IntPtr)UUIEventTriggerComponent.__PropertyOffset_OnPointerDragEnter_DEPRECATED, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007E6D RID: 32365
		// (get) Token: 0x060203F3 RID: 132083 RVA: 0x002FE244 File Offset: 0x002FC444
		// (set) Token: 0x060203F4 RID: 132084 RVA: 0x002FE27D File Offset: 0x002FC47D
		public FLGUIDrawableEvent OnPointerDragExit_DEPRECATED
		{
			get
			{
				base.FastCheckIsValid();
				FLGUIDrawableEvent result;
				if ((result = this._OnPointerDragExit_DEPRECATED) == null)
				{
					result = (this._OnPointerDragExit_DEPRECATED = new FLGUIDrawableEvent(base.NativePtr + (IntPtr)UUIEventTriggerComponent.__PropertyOffset_OnPointerDragExit_DEPRECATED, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FLGUIDrawableEvent.StaticStruct(), base.NativePtr + (IntPtr)UUIEventTriggerComponent.__PropertyOffset_OnPointerDragExit_DEPRECATED, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007E6E RID: 32366
		// (get) Token: 0x060203F5 RID: 132085 RVA: 0x002FE2A0 File Offset: 0x002FC4A0
		// (set) Token: 0x060203F6 RID: 132086 RVA: 0x002FE2D9 File Offset: 0x002FC4D9
		public FLGUIDrawableEvent OnPointerDragDrop
		{
			get
			{
				base.FastCheckIsValid();
				FLGUIDrawableEvent result;
				if ((result = this._OnPointerDragDrop) == null)
				{
					result = (this._OnPointerDragDrop = new FLGUIDrawableEvent(base.NativePtr + (IntPtr)UUIEventTriggerComponent.__PropertyOffset_OnPointerDragDrop, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FLGUIDrawableEvent.StaticStruct(), base.NativePtr + (IntPtr)UUIEventTriggerComponent.__PropertyOffset_OnPointerDragDrop, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007E6F RID: 32367
		// (get) Token: 0x060203F7 RID: 132087 RVA: 0x002FE2FC File Offset: 0x002FC4FC
		// (set) Token: 0x060203F8 RID: 132088 RVA: 0x002FE335 File Offset: 0x002FC535
		public FLGUIDrawableEvent OnPointerScroll
		{
			get
			{
				base.FastCheckIsValid();
				FLGUIDrawableEvent result;
				if ((result = this._OnPointerScroll) == null)
				{
					result = (this._OnPointerScroll = new FLGUIDrawableEvent(base.NativePtr + (IntPtr)UUIEventTriggerComponent.__PropertyOffset_OnPointerScroll, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FLGUIDrawableEvent.StaticStruct(), base.NativePtr + (IntPtr)UUIEventTriggerComponent.__PropertyOffset_OnPointerScroll, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007E70 RID: 32368
		// (get) Token: 0x060203F9 RID: 132089 RVA: 0x002FE358 File Offset: 0x002FC558
		// (set) Token: 0x060203FA RID: 132090 RVA: 0x002FE391 File Offset: 0x002FC591
		public FLGUIDrawableEvent OnPointerSelect
		{
			get
			{
				base.FastCheckIsValid();
				FLGUIDrawableEvent result;
				if ((result = this._OnPointerSelect) == null)
				{
					result = (this._OnPointerSelect = new FLGUIDrawableEvent(base.NativePtr + (IntPtr)UUIEventTriggerComponent.__PropertyOffset_OnPointerSelect, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FLGUIDrawableEvent.StaticStruct(), base.NativePtr + (IntPtr)UUIEventTriggerComponent.__PropertyOffset_OnPointerSelect, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007E71 RID: 32369
		// (get) Token: 0x060203FB RID: 132091 RVA: 0x002FE3B4 File Offset: 0x002FC5B4
		// (set) Token: 0x060203FC RID: 132092 RVA: 0x002FE3ED File Offset: 0x002FC5ED
		public FLGUIDrawableEvent OnPointerDeselect
		{
			get
			{
				base.FastCheckIsValid();
				FLGUIDrawableEvent result;
				if ((result = this._OnPointerDeselect) == null)
				{
					result = (this._OnPointerDeselect = new FLGUIDrawableEvent(base.NativePtr + (IntPtr)UUIEventTriggerComponent.__PropertyOffset_OnPointerDeselect, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FLGUIDrawableEvent.StaticStruct(), base.NativePtr + (IntPtr)UUIEventTriggerComponent.__PropertyOffset_OnPointerDeselect, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060203FD RID: 132093 RVA: 0x002FE40E File Offset: 0x002FC60E
		[NullableContext(2)]
		public void UnregisterOnPointerUp(in FLGUIDelegateHandleWrapper InDelegateHandle)
		{
			UUIEventTriggerComponent.__UnregisterOnPointerUp_Internal(base.NativePtr, (InDelegateHandle ?? new FLGUIDelegateHandleWrapper()).NativePtr);
		}

		// Token: 0x060203FE RID: 132094 RVA: 0x002FE42B File Offset: 0x002FC62B
		[NullableContext(2)]
		public void UnregisterOnPointerSelect(in FLGUIDelegateHandleWrapper InDelegateHandle)
		{
			UUIEventTriggerComponent.__UnregisterOnPointerSelect_Internal(base.NativePtr, (InDelegateHandle ?? new FLGUIDelegateHandleWrapper()).NativePtr);
		}

		// Token: 0x060203FF RID: 132095 RVA: 0x002FE448 File Offset: 0x002FC648
		[NullableContext(2)]
		public void UnregisterOnPointerScroll(in FLGUIDelegateHandleWrapper InDelegateHandle)
		{
			UUIEventTriggerComponent.__UnregisterOnPointerScroll_Internal(base.NativePtr, (InDelegateHandle ?? new FLGUIDelegateHandleWrapper()).NativePtr);
		}

		// Token: 0x06020400 RID: 132096 RVA: 0x002FE465 File Offset: 0x002FC665
		[NullableContext(2)]
		public void UnregisterOnPointerExit(in FLGUIDelegateHandleWrapper InDelegateHandle)
		{
			UUIEventTriggerComponent.__UnregisterOnPointerExit_Internal(base.NativePtr, (InDelegateHandle ?? new FLGUIDelegateHandleWrapper()).NativePtr);
		}

		// Token: 0x06020401 RID: 132097 RVA: 0x002FE482 File Offset: 0x002FC682
		[NullableContext(2)]
		public void UnregisterOnPointerEnter(in FLGUIDelegateHandleWrapper InDelegateHandle)
		{
			UUIEventTriggerComponent.__UnregisterOnPointerEnter_Internal(base.NativePtr, (InDelegateHandle ?? new FLGUIDelegateHandleWrapper()).NativePtr);
		}

		// Token: 0x06020402 RID: 132098 RVA: 0x002FE49F File Offset: 0x002FC69F
		[NullableContext(2)]
		public void UnregisterOnPointerEndDrag(in FLGUIDelegateHandleWrapper InDelegateHandle)
		{
			UUIEventTriggerComponent.__UnregisterOnPointerEndDrag_Internal(base.NativePtr, (InDelegateHandle ?? new FLGUIDelegateHandleWrapper()).NativePtr);
		}

		// Token: 0x06020403 RID: 132099 RVA: 0x002FE4BC File Offset: 0x002FC6BC
		[NullableContext(2)]
		public void UnregisterOnPointerDragExit(in FLGUIDelegateHandleWrapper InDelegateHandle)
		{
			UUIEventTriggerComponent.__UnregisterOnPointerDragExit_Internal(base.NativePtr, (InDelegateHandle ?? new FLGUIDelegateHandleWrapper()).NativePtr);
		}

		// Token: 0x06020404 RID: 132100 RVA: 0x002FE4D9 File Offset: 0x002FC6D9
		[NullableContext(2)]
		public void UnregisterOnPointerDragEnter(in FLGUIDelegateHandleWrapper InDelegateHandle)
		{
			UUIEventTriggerComponent.__UnregisterOnPointerDragEnter_Internal(base.NativePtr, (InDelegateHandle ?? new FLGUIDelegateHandleWrapper()).NativePtr);
		}

		// Token: 0x06020405 RID: 132101 RVA: 0x002FE4F6 File Offset: 0x002FC6F6
		[NullableContext(2)]
		public void UnregisterOnPointerDragDrop(in FLGUIDelegateHandleWrapper InDelegateHandle)
		{
			UUIEventTriggerComponent.__UnregisterOnPointerDragDrop_Internal(base.NativePtr, (InDelegateHandle ?? new FLGUIDelegateHandleWrapper()).NativePtr);
		}

		// Token: 0x06020406 RID: 132102 RVA: 0x002FE513 File Offset: 0x002FC713
		[NullableContext(2)]
		public void UnregisterOnPointerDrag(in FLGUIDelegateHandleWrapper InDelegateHandle)
		{
			UUIEventTriggerComponent.__UnregisterOnPointerDrag_Internal(base.NativePtr, (InDelegateHandle ?? new FLGUIDelegateHandleWrapper()).NativePtr);
		}

		// Token: 0x06020407 RID: 132103 RVA: 0x002FE530 File Offset: 0x002FC730
		[NullableContext(2)]
		public void UnregisterOnPointerDown(in FLGUIDelegateHandleWrapper InDelegateHandle)
		{
			UUIEventTriggerComponent.__UnregisterOnPointerDown_Internal(base.NativePtr, (InDelegateHandle ?? new FLGUIDelegateHandleWrapper()).NativePtr);
		}

		// Token: 0x06020408 RID: 132104 RVA: 0x002FE54D File Offset: 0x002FC74D
		[NullableContext(2)]
		public void UnregisterOnPointerDeselect(in FLGUIDelegateHandleWrapper InDelegateHandle)
		{
			UUIEventTriggerComponent.__UnregisterOnPointerDeselect_Internal(base.NativePtr, (InDelegateHandle ?? new FLGUIDelegateHandleWrapper()).NativePtr);
		}

		// Token: 0x06020409 RID: 132105 RVA: 0x002FE56A File Offset: 0x002FC76A
		[NullableContext(2)]
		public void UnregisterOnPointerClick(in FLGUIDelegateHandleWrapper InDelegateHandle)
		{
			UUIEventTriggerComponent.__UnregisterOnPointerClick_Internal(base.NativePtr, (InDelegateHandle ?? new FLGUIDelegateHandleWrapper()).NativePtr);
		}

		// Token: 0x0602040A RID: 132106 RVA: 0x002FE587 File Offset: 0x002FC787
		[NullableContext(2)]
		public void UnregisterOnPointerBeginDrag(in FLGUIDelegateHandleWrapper InDelegateHandle)
		{
			UUIEventTriggerComponent.__UnregisterOnPointerBeginDrag_Internal(base.NativePtr, (InDelegateHandle ?? new FLGUIDelegateHandleWrapper()).NativePtr);
		}

		// Token: 0x0602040B RID: 132107 RVA: 0x002FE5A4 File Offset: 0x002FC7A4
		public FLGUIDelegateHandleWrapper RegisterOnPointerUp([Nullable(2)] in FLGUIPointerEventDynamicDelegate InDelegate)
		{
			IntPtr nativePtr = base.NativePtr;
			FLGUIPointerEventDynamicDelegate flguipointerEventDynamicDelegate = InDelegate;
			return new FLGUIDelegateHandleWrapper(UUIEventTriggerComponent.__RegisterOnPointerUp_Internal(nativePtr, (flguipointerEventDynamicDelegate != null) ? flguipointerEventDynamicDelegate.NativePtr : ((IntPtr)0)), null);
		}

		// Token: 0x0602040C RID: 132108 RVA: 0x002FE5C6 File Offset: 0x002FC7C6
		public FLGUIDelegateHandleWrapper RegisterOnPointerSelect([Nullable(2)] in FLGUIBaseEventDynamicDelegate InDelegate)
		{
			IntPtr nativePtr = base.NativePtr;
			FLGUIBaseEventDynamicDelegate flguibaseEventDynamicDelegate = InDelegate;
			return new FLGUIDelegateHandleWrapper(UUIEventTriggerComponent.__RegisterOnPointerSelect_Internal(nativePtr, (flguibaseEventDynamicDelegate != null) ? flguibaseEventDynamicDelegate.NativePtr : ((IntPtr)0)), null);
		}

		// Token: 0x0602040D RID: 132109 RVA: 0x002FE5E8 File Offset: 0x002FC7E8
		public FLGUIDelegateHandleWrapper RegisterOnPointerScroll([Nullable(2)] in FLGUIPointerEventDynamicDelegate InDelegate)
		{
			IntPtr nativePtr = base.NativePtr;
			FLGUIPointerEventDynamicDelegate flguipointerEventDynamicDelegate = InDelegate;
			return new FLGUIDelegateHandleWrapper(UUIEventTriggerComponent.__RegisterOnPointerScroll_Internal(nativePtr, (flguipointerEventDynamicDelegate != null) ? flguipointerEventDynamicDelegate.NativePtr : ((IntPtr)0)), null);
		}

		// Token: 0x0602040E RID: 132110 RVA: 0x002FE60A File Offset: 0x002FC80A
		public FLGUIDelegateHandleWrapper RegisterOnPointerExit([Nullable(2)] in FLGUIPointerEventDynamicDelegate InDelegate)
		{
			IntPtr nativePtr = base.NativePtr;
			FLGUIPointerEventDynamicDelegate flguipointerEventDynamicDelegate = InDelegate;
			return new FLGUIDelegateHandleWrapper(UUIEventTriggerComponent.__RegisterOnPointerExit_Internal(nativePtr, (flguipointerEventDynamicDelegate != null) ? flguipointerEventDynamicDelegate.NativePtr : ((IntPtr)0)), null);
		}

		// Token: 0x0602040F RID: 132111 RVA: 0x002FE62C File Offset: 0x002FC82C
		public FLGUIDelegateHandleWrapper RegisterOnPointerEnter([Nullable(2)] in FLGUIPointerEventDynamicDelegate InDelegate)
		{
			IntPtr nativePtr = base.NativePtr;
			FLGUIPointerEventDynamicDelegate flguipointerEventDynamicDelegate = InDelegate;
			return new FLGUIDelegateHandleWrapper(UUIEventTriggerComponent.__RegisterOnPointerEnter_Internal(nativePtr, (flguipointerEventDynamicDelegate != null) ? flguipointerEventDynamicDelegate.NativePtr : ((IntPtr)0)), null);
		}

		// Token: 0x06020410 RID: 132112 RVA: 0x002FE64E File Offset: 0x002FC84E
		public FLGUIDelegateHandleWrapper RegisterOnPointerEndDrag([Nullable(2)] in FLGUIPointerEventDynamicDelegate InDelegate)
		{
			IntPtr nativePtr = base.NativePtr;
			FLGUIPointerEventDynamicDelegate flguipointerEventDynamicDelegate = InDelegate;
			return new FLGUIDelegateHandleWrapper(UUIEventTriggerComponent.__RegisterOnPointerEndDrag_Internal(nativePtr, (flguipointerEventDynamicDelegate != null) ? flguipointerEventDynamicDelegate.NativePtr : ((IntPtr)0)), null);
		}

		// Token: 0x06020411 RID: 132113 RVA: 0x002FE670 File Offset: 0x002FC870
		public FLGUIDelegateHandleWrapper RegisterOnPointerDragExit([Nullable(2)] in FLGUIPointerEventDynamicDelegate InDelegate)
		{
			IntPtr nativePtr = base.NativePtr;
			FLGUIPointerEventDynamicDelegate flguipointerEventDynamicDelegate = InDelegate;
			return new FLGUIDelegateHandleWrapper(UUIEventTriggerComponent.__RegisterOnPointerDragExit_Internal(nativePtr, (flguipointerEventDynamicDelegate != null) ? flguipointerEventDynamicDelegate.NativePtr : ((IntPtr)0)), null);
		}

		// Token: 0x06020412 RID: 132114 RVA: 0x002FE692 File Offset: 0x002FC892
		public FLGUIDelegateHandleWrapper RegisterOnPointerDragEnter([Nullable(2)] in FLGUIPointerEventDynamicDelegate InDelegate)
		{
			IntPtr nativePtr = base.NativePtr;
			FLGUIPointerEventDynamicDelegate flguipointerEventDynamicDelegate = InDelegate;
			return new FLGUIDelegateHandleWrapper(UUIEventTriggerComponent.__RegisterOnPointerDragEnter_Internal(nativePtr, (flguipointerEventDynamicDelegate != null) ? flguipointerEventDynamicDelegate.NativePtr : ((IntPtr)0)), null);
		}

		// Token: 0x06020413 RID: 132115 RVA: 0x002FE6B4 File Offset: 0x002FC8B4
		public FLGUIDelegateHandleWrapper RegisterOnPointerDragDrop([Nullable(2)] in FLGUIPointerEventDynamicDelegate InDelegate)
		{
			IntPtr nativePtr = base.NativePtr;
			FLGUIPointerEventDynamicDelegate flguipointerEventDynamicDelegate = InDelegate;
			return new FLGUIDelegateHandleWrapper(UUIEventTriggerComponent.__RegisterOnPointerDragDrop_Internal(nativePtr, (flguipointerEventDynamicDelegate != null) ? flguipointerEventDynamicDelegate.NativePtr : ((IntPtr)0)), null);
		}

		// Token: 0x06020414 RID: 132116 RVA: 0x002FE6D6 File Offset: 0x002FC8D6
		public FLGUIDelegateHandleWrapper RegisterOnPointerDrag([Nullable(2)] in FLGUIPointerEventDynamicDelegate InDelegate)
		{
			IntPtr nativePtr = base.NativePtr;
			FLGUIPointerEventDynamicDelegate flguipointerEventDynamicDelegate = InDelegate;
			return new FLGUIDelegateHandleWrapper(UUIEventTriggerComponent.__RegisterOnPointerDrag_Internal(nativePtr, (flguipointerEventDynamicDelegate != null) ? flguipointerEventDynamicDelegate.NativePtr : ((IntPtr)0)), null);
		}

		// Token: 0x06020415 RID: 132117 RVA: 0x002FE6F8 File Offset: 0x002FC8F8
		public FLGUIDelegateHandleWrapper RegisterOnPointerDown([Nullable(2)] in FLGUIPointerEventDynamicDelegate InDelegate)
		{
			IntPtr nativePtr = base.NativePtr;
			FLGUIPointerEventDynamicDelegate flguipointerEventDynamicDelegate = InDelegate;
			return new FLGUIDelegateHandleWrapper(UUIEventTriggerComponent.__RegisterOnPointerDown_Internal(nativePtr, (flguipointerEventDynamicDelegate != null) ? flguipointerEventDynamicDelegate.NativePtr : ((IntPtr)0)), null);
		}

		// Token: 0x06020416 RID: 132118 RVA: 0x002FE71A File Offset: 0x002FC91A
		public FLGUIDelegateHandleWrapper RegisterOnPointerDeselect([Nullable(2)] in FLGUIBaseEventDynamicDelegate InDelegate)
		{
			IntPtr nativePtr = base.NativePtr;
			FLGUIBaseEventDynamicDelegate flguibaseEventDynamicDelegate = InDelegate;
			return new FLGUIDelegateHandleWrapper(UUIEventTriggerComponent.__RegisterOnPointerDeselect_Internal(nativePtr, (flguibaseEventDynamicDelegate != null) ? flguibaseEventDynamicDelegate.NativePtr : ((IntPtr)0)), null);
		}

		// Token: 0x06020417 RID: 132119 RVA: 0x002FE73C File Offset: 0x002FC93C
		public FLGUIDelegateHandleWrapper RegisterOnPointerClick([Nullable(2)] in FLGUIPointerEventDynamicDelegate InDelegate)
		{
			IntPtr nativePtr = base.NativePtr;
			FLGUIPointerEventDynamicDelegate flguipointerEventDynamicDelegate = InDelegate;
			return new FLGUIDelegateHandleWrapper(UUIEventTriggerComponent.__RegisterOnPointerClick_Internal(nativePtr, (flguipointerEventDynamicDelegate != null) ? flguipointerEventDynamicDelegate.NativePtr : ((IntPtr)0)), null);
		}

		// Token: 0x06020418 RID: 132120 RVA: 0x002FE75E File Offset: 0x002FC95E
		public FLGUIDelegateHandleWrapper RegisterOnPointerBeginDrag([Nullable(2)] in FLGUIPointerEventDynamicDelegate InDelegate)
		{
			IntPtr nativePtr = base.NativePtr;
			FLGUIPointerEventDynamicDelegate flguipointerEventDynamicDelegate = InDelegate;
			return new FLGUIDelegateHandleWrapper(UUIEventTriggerComponent.__RegisterOnPointerBeginDrag_Internal(nativePtr, (flguipointerEventDynamicDelegate != null) ? flguipointerEventDynamicDelegate.NativePtr : ((IntPtr)0)), null);
		}

		// Token: 0x06020419 RID: 132121
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnregisterOnPointerUp_Internal(IntPtr @this, IntPtr InDelegateHandle);

		// Token: 0x0602041A RID: 132122
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnregisterOnPointerSelect_Internal(IntPtr @this, IntPtr InDelegateHandle);

		// Token: 0x0602041B RID: 132123
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnregisterOnPointerScroll_Internal(IntPtr @this, IntPtr InDelegateHandle);

		// Token: 0x0602041C RID: 132124
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnregisterOnPointerExit_Internal(IntPtr @this, IntPtr InDelegateHandle);

		// Token: 0x0602041D RID: 132125
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnregisterOnPointerEnter_Internal(IntPtr @this, IntPtr InDelegateHandle);

		// Token: 0x0602041E RID: 132126
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnregisterOnPointerEndDrag_Internal(IntPtr @this, IntPtr InDelegateHandle);

		// Token: 0x0602041F RID: 132127
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnregisterOnPointerDragExit_Internal(IntPtr @this, IntPtr InDelegateHandle);

		// Token: 0x06020420 RID: 132128
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnregisterOnPointerDragEnter_Internal(IntPtr @this, IntPtr InDelegateHandle);

		// Token: 0x06020421 RID: 132129
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnregisterOnPointerDragDrop_Internal(IntPtr @this, IntPtr InDelegateHandle);

		// Token: 0x06020422 RID: 132130
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnregisterOnPointerDrag_Internal(IntPtr @this, IntPtr InDelegateHandle);

		// Token: 0x06020423 RID: 132131
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnregisterOnPointerDown_Internal(IntPtr @this, IntPtr InDelegateHandle);

		// Token: 0x06020424 RID: 132132
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnregisterOnPointerDeselect_Internal(IntPtr @this, IntPtr InDelegateHandle);

		// Token: 0x06020425 RID: 132133
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnregisterOnPointerClick_Internal(IntPtr @this, IntPtr InDelegateHandle);

		// Token: 0x06020426 RID: 132134
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnregisterOnPointerBeginDrag_Internal(IntPtr @this, IntPtr InDelegateHandle);

		// Token: 0x06020427 RID: 132135
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __RegisterOnPointerUp_Internal(IntPtr @this, IntPtr InDelegate);

		// Token: 0x06020428 RID: 132136
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __RegisterOnPointerSelect_Internal(IntPtr @this, IntPtr InDelegate);

		// Token: 0x06020429 RID: 132137
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __RegisterOnPointerScroll_Internal(IntPtr @this, IntPtr InDelegate);

		// Token: 0x0602042A RID: 132138
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __RegisterOnPointerExit_Internal(IntPtr @this, IntPtr InDelegate);

		// Token: 0x0602042B RID: 132139
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __RegisterOnPointerEnter_Internal(IntPtr @this, IntPtr InDelegate);

		// Token: 0x0602042C RID: 132140
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __RegisterOnPointerEndDrag_Internal(IntPtr @this, IntPtr InDelegate);

		// Token: 0x0602042D RID: 132141
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __RegisterOnPointerDragExit_Internal(IntPtr @this, IntPtr InDelegate);

		// Token: 0x0602042E RID: 132142
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __RegisterOnPointerDragEnter_Internal(IntPtr @this, IntPtr InDelegate);

		// Token: 0x0602042F RID: 132143
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __RegisterOnPointerDragDrop_Internal(IntPtr @this, IntPtr InDelegate);

		// Token: 0x06020430 RID: 132144
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __RegisterOnPointerDrag_Internal(IntPtr @this, IntPtr InDelegate);

		// Token: 0x06020431 RID: 132145
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __RegisterOnPointerDown_Internal(IntPtr @this, IntPtr InDelegate);

		// Token: 0x06020432 RID: 132146
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __RegisterOnPointerDeselect_Internal(IntPtr @this, IntPtr InDelegate);

		// Token: 0x06020433 RID: 132147
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __RegisterOnPointerClick_Internal(IntPtr @this, IntPtr InDelegate);

		// Token: 0x06020434 RID: 132148
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __RegisterOnPointerBeginDrag_Internal(IntPtr @this, IntPtr InDelegate);

		// Token: 0x06020435 RID: 132149 RVA: 0x002FE780 File Offset: 0x002FC980
		static UUIEventTriggerComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIEventTriggerComponent");
		}

		// Token: 0x06020436 RID: 132150 RVA: 0x002FE78E File Offset: 0x002FC98E
		protected UUIEventTriggerComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011526 RID: 70950
		internal static int __InterfaceOffset_ILGUIPointerEnterExitInterface;

		// Token: 0x04011527 RID: 70951
		internal static int __InterfaceOffset_ILGUIPointerDownUpInterface;

		// Token: 0x04011528 RID: 70952
		internal static int __InterfaceOffset_ILGUIPointerClickInterface;

		// Token: 0x04011529 RID: 70953
		internal static int __InterfaceOffset_ILGUIPointerDragInterface;

		// Token: 0x0401152A RID: 70954
		internal static int __InterfaceOffset_ILGUIPointerDragDropInterface;

		// Token: 0x0401152B RID: 70955
		internal static int __InterfaceOffset_ILGUIPointerScrollInterface;

		// Token: 0x0401152C RID: 70956
		internal static int __InterfaceOffset_ILGUIPointerSelectDeselectInterface;

		// Token: 0x0401152D RID: 70957
		public new const string __ObjectPath = "/Script/LGUI.UIEventTriggerComponent";

		// Token: 0x0401152E RID: 70958
		private static IntPtr _ClassPtr;

		// Token: 0x0401152F RID: 70959
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011530 RID: 70960
		internal static int __PropertyOffset_AllowEventBubbleUp;

		// Token: 0x04011531 RID: 70961
		internal static int __PropertyOffset_OnPointerEnter;

		// Token: 0x04011532 RID: 70962
		[Nullable(2)]
		private FLGUIDrawableEvent _OnPointerEnter;

		// Token: 0x04011533 RID: 70963
		internal static int __PropertyOffset_OnPointerExit;

		// Token: 0x04011534 RID: 70964
		[Nullable(2)]
		private FLGUIDrawableEvent _OnPointerExit;

		// Token: 0x04011535 RID: 70965
		internal static int __PropertyOffset_OnPointerDown;

		// Token: 0x04011536 RID: 70966
		[Nullable(2)]
		private FLGUIDrawableEvent _OnPointerDown;

		// Token: 0x04011537 RID: 70967
		internal static int __PropertyOffset_OnPointerUp;

		// Token: 0x04011538 RID: 70968
		[Nullable(2)]
		private FLGUIDrawableEvent _OnPointerUp;

		// Token: 0x04011539 RID: 70969
		internal static int __PropertyOffset_OnPointerCancel;

		// Token: 0x0401153A RID: 70970
		[Nullable(2)]
		private FLGUIDrawableEvent _OnPointerCancel;

		// Token: 0x0401153B RID: 70971
		internal static int __PropertyOffset_OnPointerClick;

		// Token: 0x0401153C RID: 70972
		[Nullable(2)]
		private FLGUIDrawableEvent _OnPointerClick;

		// Token: 0x0401153D RID: 70973
		internal static int __PropertyOffset_OnPointerBeginDrag;

		// Token: 0x0401153E RID: 70974
		[Nullable(2)]
		private FLGUIDrawableEvent _OnPointerBeginDrag;

		// Token: 0x0401153F RID: 70975
		internal static int __PropertyOffset_OnPointerDrag;

		// Token: 0x04011540 RID: 70976
		[Nullable(2)]
		private FLGUIDrawableEvent _OnPointerDrag;

		// Token: 0x04011541 RID: 70977
		internal static int __PropertyOffset_OnPointerEndDrag;

		// Token: 0x04011542 RID: 70978
		[Nullable(2)]
		private FLGUIDrawableEvent _OnPointerEndDrag;

		// Token: 0x04011543 RID: 70979
		internal static int __PropertyOffset_OnPointerDragEnter_DEPRECATED;

		// Token: 0x04011544 RID: 70980
		[Nullable(2)]
		private FLGUIDrawableEvent _OnPointerDragEnter_DEPRECATED;

		// Token: 0x04011545 RID: 70981
		internal static int __PropertyOffset_OnPointerDragExit_DEPRECATED;

		// Token: 0x04011546 RID: 70982
		[Nullable(2)]
		private FLGUIDrawableEvent _OnPointerDragExit_DEPRECATED;

		// Token: 0x04011547 RID: 70983
		internal static int __PropertyOffset_OnPointerDragDrop;

		// Token: 0x04011548 RID: 70984
		[Nullable(2)]
		private FLGUIDrawableEvent _OnPointerDragDrop;

		// Token: 0x04011549 RID: 70985
		internal static int __PropertyOffset_OnPointerScroll;

		// Token: 0x0401154A RID: 70986
		[Nullable(2)]
		private FLGUIDrawableEvent _OnPointerScroll;

		// Token: 0x0401154B RID: 70987
		internal static int __PropertyOffset_OnPointerSelect;

		// Token: 0x0401154C RID: 70988
		[Nullable(2)]
		private FLGUIDrawableEvent _OnPointerSelect;

		// Token: 0x0401154D RID: 70989
		internal static int __PropertyOffset_OnPointerDeselect;

		// Token: 0x0401154E RID: 70990
		[Nullable(2)]
		private FLGUIDrawableEvent _OnPointerDeselect;
	}
}
