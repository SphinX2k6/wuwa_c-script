using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002A01 RID: 10753
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/UMG.WidgetInteractionComponent")]
	[UnrealStructLayout(1104, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1104)]
	public class UWidgetInteractionComponent : USceneComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06027F54 RID: 163668 RVA: 0x003CD858 File Offset: 0x003CBA58
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UWidgetInteractionComponent._ClassPtr;
		}

		// Token: 0x06027F55 RID: 163669 RVA: 0x003CD864 File Offset: 0x003CBA64
		public UWidgetInteractionComponent() : this(BuiltinUtils.AllocNativeUObject(UWidgetInteractionComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06027F56 RID: 163670 RVA: 0x003CD88C File Offset: 0x003CBA8C
		[NullableContext(1)]
		public UWidgetInteractionComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UWidgetInteractionComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170098AE RID: 39086
		// (get) Token: 0x06027F57 RID: 163671 RVA: 0x003CD8C0 File Offset: 0x003CBAC0
		// (set) Token: 0x06027F58 RID: 163672 RVA: 0x003CD8F9 File Offset: 0x003CBAF9
		[Nullable(1)]
		public FOnHoveredWidgetChanged OnHoveredWidgetChanged
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FOnHoveredWidgetChanged result;
				if ((result = this._OnHoveredWidgetChanged) == null)
				{
					result = (this._OnHoveredWidgetChanged = new FOnHoveredWidgetChanged(base.NativePtr + (IntPtr)UWidgetInteractionComponent.__PropertyOffset_OnHoveredWidgetChanged, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UWidgetInteractionComponent.__PropertyOffset_OnHoveredWidgetChanged, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170098AF RID: 39087
		// (get) Token: 0x06027F59 RID: 163673 RVA: 0x003CD91A File Offset: 0x003CBB1A
		// (set) Token: 0x06027F5A RID: 163674 RVA: 0x003CD92A File Offset: 0x003CBB2A
		public unsafe int VirtualUserIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UWidgetInteractionComponent.__PropertyOffset_VirtualUserIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWidgetInteractionComponent.__PropertyOffset_VirtualUserIndex) = value;
			}
		}

		// Token: 0x170098B0 RID: 39088
		// (get) Token: 0x06027F5B RID: 163675 RVA: 0x003CD93B File Offset: 0x003CBB3B
		// (set) Token: 0x06027F5C RID: 163676 RVA: 0x003CD94B File Offset: 0x003CBB4B
		public unsafe int PointerIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UWidgetInteractionComponent.__PropertyOffset_PointerIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWidgetInteractionComponent.__PropertyOffset_PointerIndex) = value;
			}
		}

		// Token: 0x170098B1 RID: 39089
		// (get) Token: 0x06027F5D RID: 163677 RVA: 0x003CD95C File Offset: 0x003CBB5C
		// (set) Token: 0x06027F5E RID: 163678 RVA: 0x003CD970 File Offset: 0x003CBB70
		[Nullable(0)]
		public unsafe TEnumAsByte<ECollisionChannel> TraceChannel
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UWidgetInteractionComponent.__PropertyOffset_TraceChannel);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UWidgetInteractionComponent.__PropertyOffset_TraceChannel) = value;
			}
		}

		// Token: 0x170098B2 RID: 39090
		// (get) Token: 0x06027F5F RID: 163679 RVA: 0x003CD985 File Offset: 0x003CBB85
		// (set) Token: 0x06027F60 RID: 163680 RVA: 0x003CD995 File Offset: 0x003CBB95
		public unsafe float InteractionDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UWidgetInteractionComponent.__PropertyOffset_InteractionDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWidgetInteractionComponent.__PropertyOffset_InteractionDistance) = value;
			}
		}

		// Token: 0x170098B3 RID: 39091
		// (get) Token: 0x06027F61 RID: 163681 RVA: 0x003CD9A6 File Offset: 0x003CBBA6
		// (set) Token: 0x06027F62 RID: 163682 RVA: 0x003CD9B6 File Offset: 0x003CBBB6
		public unsafe EWidgetInteractionSource InteractionSource
		{
			get
			{
				return (EWidgetInteractionSource)(*(base.NativePtr + (IntPtr)UWidgetInteractionComponent.__PropertyOffset_InteractionSource));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWidgetInteractionComponent.__PropertyOffset_InteractionSource) = (byte)value;
			}
		}

		// Token: 0x170098B4 RID: 39092
		// (get) Token: 0x06027F63 RID: 163683 RVA: 0x003CD9C7 File Offset: 0x003CBBC7
		// (set) Token: 0x06027F64 RID: 163684 RVA: 0x003CD9D7 File Offset: 0x003CBBD7
		public unsafe bool bEnableHitTesting
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UWidgetInteractionComponent.__PropertyOffset_bEnableHitTesting) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWidgetInteractionComponent.__PropertyOffset_bEnableHitTesting) = (value ? 1 : 0);
			}
		}

		// Token: 0x170098B5 RID: 39093
		// (get) Token: 0x06027F65 RID: 163685 RVA: 0x003CD9E8 File Offset: 0x003CBBE8
		// (set) Token: 0x06027F66 RID: 163686 RVA: 0x003CD9F8 File Offset: 0x003CBBF8
		public unsafe bool bShowDebug
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UWidgetInteractionComponent.__PropertyOffset_bShowDebug) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWidgetInteractionComponent.__PropertyOffset_bShowDebug) = (value ? 1 : 0);
			}
		}

		// Token: 0x170098B6 RID: 39094
		// (get) Token: 0x06027F67 RID: 163687 RVA: 0x003CDA09 File Offset: 0x003CBC09
		// (set) Token: 0x06027F68 RID: 163688 RVA: 0x003CDA19 File Offset: 0x003CBC19
		public unsafe float DebugSphereLineThickness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UWidgetInteractionComponent.__PropertyOffset_DebugSphereLineThickness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWidgetInteractionComponent.__PropertyOffset_DebugSphereLineThickness) = value;
			}
		}

		// Token: 0x170098B7 RID: 39095
		// (get) Token: 0x06027F69 RID: 163689 RVA: 0x003CDA2A File Offset: 0x003CBC2A
		// (set) Token: 0x06027F6A RID: 163690 RVA: 0x003CDA3A File Offset: 0x003CBC3A
		public unsafe float DebugLineThickness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UWidgetInteractionComponent.__PropertyOffset_DebugLineThickness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWidgetInteractionComponent.__PropertyOffset_DebugLineThickness) = value;
			}
		}

		// Token: 0x170098B8 RID: 39096
		// (get) Token: 0x06027F6B RID: 163691 RVA: 0x003CDA4B File Offset: 0x003CBC4B
		// (set) Token: 0x06027F6C RID: 163692 RVA: 0x003CDA5F File Offset: 0x003CBC5F
		public unsafe FLinearColor DebugColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UWidgetInteractionComponent.__PropertyOffset_DebugColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWidgetInteractionComponent.__PropertyOffset_DebugColor) = value;
			}
		}

		// Token: 0x170098B9 RID: 39097
		// (get) Token: 0x06027F6D RID: 163693 RVA: 0x003CDA74 File Offset: 0x003CBC74
		// (set) Token: 0x06027F6E RID: 163694 RVA: 0x003CDAAD File Offset: 0x003CBCAD
		[Nullable(1)]
		public FHitResult CustomHitResult
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FHitResult result;
				if ((result = this._CustomHitResult) == null)
				{
					result = (this._CustomHitResult = new FHitResult(base.NativePtr + (IntPtr)UWidgetInteractionComponent.__PropertyOffset_CustomHitResult, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), base.NativePtr + (IntPtr)UWidgetInteractionComponent.__PropertyOffset_CustomHitResult, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170098BA RID: 39098
		// (get) Token: 0x06027F6F RID: 163695 RVA: 0x003CDACE File Offset: 0x003CBCCE
		// (set) Token: 0x06027F70 RID: 163696 RVA: 0x003CDAE2 File Offset: 0x003CBCE2
		public unsafe FVector2D LocalHitLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UWidgetInteractionComponent.__PropertyOffset_LocalHitLocation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWidgetInteractionComponent.__PropertyOffset_LocalHitLocation) = value;
			}
		}

		// Token: 0x170098BB RID: 39099
		// (get) Token: 0x06027F71 RID: 163697 RVA: 0x003CDAF7 File Offset: 0x003CBCF7
		// (set) Token: 0x06027F72 RID: 163698 RVA: 0x003CDB0B File Offset: 0x003CBD0B
		public unsafe FVector2D LastLocalHitLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UWidgetInteractionComponent.__PropertyOffset_LastLocalHitLocation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWidgetInteractionComponent.__PropertyOffset_LastLocalHitLocation) = value;
			}
		}

		// Token: 0x170098BC RID: 39100
		// (get) Token: 0x06027F73 RID: 163699 RVA: 0x003CDB20 File Offset: 0x003CBD20
		// (set) Token: 0x06027F74 RID: 163700 RVA: 0x003CDB34 File Offset: 0x003CBD34
		public unsafe UWidgetComponent HoveredWidgetComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UWidgetComponent>(base.NativePtr / (IntPtr)sizeof(void*) + UWidgetInteractionComponent.__PropertyOffset_HoveredWidgetComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UWidgetInteractionComponent.__PropertyOffset_HoveredWidgetComponent, value);
			}
		}

		// Token: 0x170098BD RID: 39101
		// (get) Token: 0x06027F75 RID: 163701 RVA: 0x003CDB4C File Offset: 0x003CBD4C
		// (set) Token: 0x06027F76 RID: 163702 RVA: 0x003CDB85 File Offset: 0x003CBD85
		[Nullable(1)]
		public FHitResult LastHitResult
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FHitResult result;
				if ((result = this._LastHitResult) == null)
				{
					result = (this._LastHitResult = new FHitResult(base.NativePtr + (IntPtr)UWidgetInteractionComponent.__PropertyOffset_LastHitResult, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), base.NativePtr + (IntPtr)UWidgetInteractionComponent.__PropertyOffset_LastHitResult, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170098BE RID: 39102
		// (get) Token: 0x06027F77 RID: 163703 RVA: 0x003CDBA6 File Offset: 0x003CBDA6
		// (set) Token: 0x06027F78 RID: 163704 RVA: 0x003CDBB6 File Offset: 0x003CBDB6
		public unsafe bool bIsHoveredWidgetInteractable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UWidgetInteractionComponent.__PropertyOffset_bIsHoveredWidgetInteractable) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWidgetInteractionComponent.__PropertyOffset_bIsHoveredWidgetInteractable) = (value ? 1 : 0);
			}
		}

		// Token: 0x170098BF RID: 39103
		// (get) Token: 0x06027F79 RID: 163705 RVA: 0x003CDBC7 File Offset: 0x003CBDC7
		// (set) Token: 0x06027F7A RID: 163706 RVA: 0x003CDBD7 File Offset: 0x003CBDD7
		public unsafe bool bIsHoveredWidgetFocusable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UWidgetInteractionComponent.__PropertyOffset_bIsHoveredWidgetFocusable) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWidgetInteractionComponent.__PropertyOffset_bIsHoveredWidgetFocusable) = (value ? 1 : 0);
			}
		}

		// Token: 0x170098C0 RID: 39104
		// (get) Token: 0x06027F7B RID: 163707 RVA: 0x003CDBE8 File Offset: 0x003CBDE8
		// (set) Token: 0x06027F7C RID: 163708 RVA: 0x003CDBF8 File Offset: 0x003CBDF8
		public unsafe bool bIsHoveredWidgetHitTestVisible
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UWidgetInteractionComponent.__PropertyOffset_bIsHoveredWidgetHitTestVisible) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWidgetInteractionComponent.__PropertyOffset_bIsHoveredWidgetHitTestVisible) = (value ? 1 : 0);
			}
		}

		// Token: 0x06027F7D RID: 163709 RVA: 0x003CDC09 File Offset: 0x003CBE09
		public void SetFocus(UWidget FocusWidget)
		{
			UWidgetInteractionComponent.__SetFocus_Internal(base.NativePtr, (FocusWidget != null) ? FocusWidget.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06027F7E RID: 163710 RVA: 0x003CDC26 File Offset: 0x003CBE26
		public void SetCustomHitResult(in FHitResult HitResult)
		{
			UWidgetInteractionComponent.__SetCustomHitResult_Internal(base.NativePtr, (HitResult ?? new FHitResult()).NativePtr);
		}

		// Token: 0x06027F7F RID: 163711 RVA: 0x003CDC44 File Offset: 0x003CBE44
		[NullableContext(1)]
		public unsafe bool SendKeyChar(string Characters, bool bRepeat = false)
		{
			FString fstring = FString.AllocTemp(Characters);
			bool result = UWidgetInteractionComponent.__SendKeyChar_Internal(base.NativePtr, fstring, bRepeat);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06027F80 RID: 163712 RVA: 0x003CDC6F File Offset: 0x003CBE6F
		public void ScrollWheel(float ScrollDelta)
		{
			UWidgetInteractionComponent.__ScrollWheel_Internal(base.NativePtr, ScrollDelta);
		}

		// Token: 0x06027F81 RID: 163713 RVA: 0x003CDC7D File Offset: 0x003CBE7D
		public void ReleasePointerKey(FKey Key)
		{
			UWidgetInteractionComponent.__ReleasePointerKey_Internal(base.NativePtr, (Key ?? new FKey()).NativePtr);
		}

		// Token: 0x06027F82 RID: 163714 RVA: 0x003CDC99 File Offset: 0x003CBE99
		public bool ReleaseKey(FKey Key)
		{
			return UWidgetInteractionComponent.__ReleaseKey_Internal(base.NativePtr, (Key ?? new FKey()).NativePtr);
		}

		// Token: 0x06027F83 RID: 163715 RVA: 0x003CDCB5 File Offset: 0x003CBEB5
		public void PressPointerKey(FKey Key)
		{
			UWidgetInteractionComponent.__PressPointerKey_Internal(base.NativePtr, (Key ?? new FKey()).NativePtr);
		}

		// Token: 0x06027F84 RID: 163716 RVA: 0x003CDCD1 File Offset: 0x003CBED1
		public bool PressKey(FKey Key, bool bRepeat = false)
		{
			return UWidgetInteractionComponent.__PressKey_Internal(base.NativePtr, (Key ?? new FKey()).NativePtr, bRepeat);
		}

		// Token: 0x06027F85 RID: 163717 RVA: 0x003CDCEE File Offset: 0x003CBEEE
		public bool PressAndReleaseKey(FKey Key)
		{
			return UWidgetInteractionComponent.__PressAndReleaseKey_Internal(base.NativePtr, (Key ?? new FKey()).NativePtr);
		}

		// Token: 0x06027F86 RID: 163718 RVA: 0x003CDD0A File Offset: 0x003CBF0A
		public bool IsOverInteractableWidget()
		{
			return UWidgetInteractionComponent.__IsOverInteractableWidget_Internal(base.NativePtr);
		}

		// Token: 0x06027F87 RID: 163719 RVA: 0x003CDD17 File Offset: 0x003CBF17
		public bool IsOverHitTestVisibleWidget()
		{
			return UWidgetInteractionComponent.__IsOverHitTestVisibleWidget_Internal(base.NativePtr);
		}

		// Token: 0x06027F88 RID: 163720 RVA: 0x003CDD24 File Offset: 0x003CBF24
		public bool IsOverFocusableWidget()
		{
			return UWidgetInteractionComponent.__IsOverFocusableWidget_Internal(base.NativePtr);
		}

		// Token: 0x06027F89 RID: 163721 RVA: 0x003CDD31 File Offset: 0x003CBF31
		[NullableContext(1)]
		public FHitResult GetLastHitResult()
		{
			return new FHitResult(UWidgetInteractionComponent.__GetLastHitResult_Internal(base.NativePtr), null);
		}

		// Token: 0x06027F8A RID: 163722 RVA: 0x003CDD44 File Offset: 0x003CBF44
		public UWidgetComponent GetHoveredWidgetComponent()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UWidgetComponent>(UWidgetInteractionComponent.__GetHoveredWidgetComponent_Internal(base.NativePtr));
		}

		// Token: 0x06027F8B RID: 163723 RVA: 0x003CDD56 File Offset: 0x003CBF56
		public FVector2D Get2DHitLocation()
		{
			return UWidgetInteractionComponent.__Get2DHitLocation_Internal(base.NativePtr);
		}

		// Token: 0x06027F8C RID: 163724
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFocus_Internal(IntPtr @this, IntPtr FocusWidget);

		// Token: 0x06027F8D RID: 163725
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCustomHitResult_Internal(IntPtr @this, IntPtr HitResult);

		// Token: 0x06027F8E RID: 163726
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SendKeyChar_Internal(IntPtr @this, in FString Characters, bool bRepeat);

		// Token: 0x06027F8F RID: 163727
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ScrollWheel_Internal(IntPtr @this, float ScrollDelta);

		// Token: 0x06027F90 RID: 163728
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReleasePointerKey_Internal(IntPtr @this, IntPtr Key);

		// Token: 0x06027F91 RID: 163729
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __ReleaseKey_Internal(IntPtr @this, IntPtr Key);

		// Token: 0x06027F92 RID: 163730
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PressPointerKey_Internal(IntPtr @this, IntPtr Key);

		// Token: 0x06027F93 RID: 163731
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __PressKey_Internal(IntPtr @this, IntPtr Key, bool bRepeat);

		// Token: 0x06027F94 RID: 163732
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __PressAndReleaseKey_Internal(IntPtr @this, IntPtr Key);

		// Token: 0x06027F95 RID: 163733
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsOverInteractableWidget_Internal(IntPtr @this);

		// Token: 0x06027F96 RID: 163734
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsOverHitTestVisibleWidget_Internal(IntPtr @this);

		// Token: 0x06027F97 RID: 163735
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsOverFocusableWidget_Internal(IntPtr @this);

		// Token: 0x06027F98 RID: 163736
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetLastHitResult_Internal(IntPtr @this);

		// Token: 0x06027F99 RID: 163737
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetHoveredWidgetComponent_Internal(IntPtr @this);

		// Token: 0x06027F9A RID: 163738
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __Get2DHitLocation_Internal(IntPtr @this);

		// Token: 0x06027F9B RID: 163739 RVA: 0x003CDD63 File Offset: 0x003CBF63
		static UWidgetInteractionComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.WidgetInteractionComponent");
		}

		// Token: 0x06027F9C RID: 163740 RVA: 0x003CDD71 File Offset: 0x003CBF71
		protected UWidgetInteractionComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015D12 RID: 89362
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/UMG.WidgetInteractionComponent";

		// Token: 0x04015D13 RID: 89363
		private static IntPtr _ClassPtr;

		// Token: 0x04015D14 RID: 89364
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015D15 RID: 89365
		internal static int __PropertyOffset_OnHoveredWidgetChanged;

		// Token: 0x04015D16 RID: 89366
		private FOnHoveredWidgetChanged _OnHoveredWidgetChanged;

		// Token: 0x04015D17 RID: 89367
		internal static int __PropertyOffset_VirtualUserIndex;

		// Token: 0x04015D18 RID: 89368
		internal static int __PropertyOffset_PointerIndex;

		// Token: 0x04015D19 RID: 89369
		internal static int __PropertyOffset_TraceChannel;

		// Token: 0x04015D1A RID: 89370
		internal static int __PropertyOffset_InteractionDistance;

		// Token: 0x04015D1B RID: 89371
		internal static int __PropertyOffset_InteractionSource;

		// Token: 0x04015D1C RID: 89372
		internal static int __PropertyOffset_bEnableHitTesting;

		// Token: 0x04015D1D RID: 89373
		internal static int __PropertyOffset_bShowDebug;

		// Token: 0x04015D1E RID: 89374
		internal static int __PropertyOffset_DebugSphereLineThickness;

		// Token: 0x04015D1F RID: 89375
		internal static int __PropertyOffset_DebugLineThickness;

		// Token: 0x04015D20 RID: 89376
		internal static int __PropertyOffset_DebugColor;

		// Token: 0x04015D21 RID: 89377
		internal static int __PropertyOffset_CustomHitResult;

		// Token: 0x04015D22 RID: 89378
		private FHitResult _CustomHitResult;

		// Token: 0x04015D23 RID: 89379
		internal static int __PropertyOffset_LocalHitLocation;

		// Token: 0x04015D24 RID: 89380
		internal static int __PropertyOffset_LastLocalHitLocation;

		// Token: 0x04015D25 RID: 89381
		internal static int __PropertyOffset_HoveredWidgetComponent;

		// Token: 0x04015D26 RID: 89382
		internal static int __PropertyOffset_LastHitResult;

		// Token: 0x04015D27 RID: 89383
		private FHitResult _LastHitResult;

		// Token: 0x04015D28 RID: 89384
		internal static int __PropertyOffset_bIsHoveredWidgetInteractable;

		// Token: 0x04015D29 RID: 89385
		internal static int __PropertyOffset_bIsHoveredWidgetFocusable;

		// Token: 0x04015D2A RID: 89386
		internal static int __PropertyOffset_bIsHoveredWidgetHitTestVisible;
	}
}
