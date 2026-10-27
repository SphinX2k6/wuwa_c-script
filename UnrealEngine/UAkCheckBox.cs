using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020001F8 RID: 504
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AkAudio.AkCheckBox")]
	[UnrealStructLayout(3624, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 3624)]
	public class UAkCheckBox : UContentWidget, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001D91 RID: 7569 RVA: 0x0002BF3F File Offset: 0x0002A13F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAkCheckBox._ClassPtr;
		}

		// Token: 0x06001D92 RID: 7570 RVA: 0x0002BF4C File Offset: 0x0002A14C
		public UAkCheckBox() : this(BuiltinUtils.AllocNativeUObject(UAkCheckBox.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001D93 RID: 7571 RVA: 0x0002BF74 File Offset: 0x0002A174
		public UAkCheckBox(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAkCheckBox.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700076E RID: 1902
		// (get) Token: 0x06001D94 RID: 7572 RVA: 0x0002BFA7 File Offset: 0x0002A1A7
		// (set) Token: 0x06001D95 RID: 7573 RVA: 0x0002BFB7 File Offset: 0x0002A1B7
		public unsafe ECheckBoxState CheckedState
		{
			get
			{
				return (ECheckBoxState)(*(base.NativePtr + (IntPtr)UAkCheckBox.__PropertyOffset_CheckedState));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAkCheckBox.__PropertyOffset_CheckedState) = (byte)value;
			}
		}

		// Token: 0x1700076F RID: 1903
		// (get) Token: 0x06001D96 RID: 7574 RVA: 0x0002BFC8 File Offset: 0x0002A1C8
		// (set) Token: 0x06001D97 RID: 7575 RVA: 0x0002C001 File Offset: 0x0002A201
		public FGetCheckBoxState CheckedStateDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FGetCheckBoxState result;
				if ((result = this._CheckedStateDelegate) == null)
				{
					result = (this._CheckedStateDelegate = new FGetCheckBoxState(base.NativePtr + (IntPtr)UAkCheckBox.__PropertyOffset_CheckedStateDelegate, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAkCheckBox.__PropertyOffset_CheckedStateDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17000770 RID: 1904
		// (get) Token: 0x06001D98 RID: 7576 RVA: 0x0002C024 File Offset: 0x0002A224
		// (set) Token: 0x06001D99 RID: 7577 RVA: 0x0002C05D File Offset: 0x0002A25D
		public FCheckBoxStyle WidgetStyle
		{
			get
			{
				base.FastCheckIsValid();
				FCheckBoxStyle result;
				if ((result = this._WidgetStyle) == null)
				{
					result = (this._WidgetStyle = new FCheckBoxStyle(base.NativePtr + (IntPtr)UAkCheckBox.__PropertyOffset_WidgetStyle, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCheckBoxStyle.StaticStruct(), base.NativePtr + (IntPtr)UAkCheckBox.__PropertyOffset_WidgetStyle, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000771 RID: 1905
		// (get) Token: 0x06001D9A RID: 7578 RVA: 0x0002C07E File Offset: 0x0002A27E
		// (set) Token: 0x06001D9B RID: 7579 RVA: 0x0002C092 File Offset: 0x0002A292
		[Nullable(0)]
		public unsafe TEnumAsByte<EHorizontalAlignment> HorizontalAlignment
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UAkCheckBox.__PropertyOffset_HorizontalAlignment);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UAkCheckBox.__PropertyOffset_HorizontalAlignment) = value;
			}
		}

		// Token: 0x17000772 RID: 1906
		// (get) Token: 0x06001D9C RID: 7580 RVA: 0x0002C0A7 File Offset: 0x0002A2A7
		// (set) Token: 0x06001D9D RID: 7581 RVA: 0x0002C0B7 File Offset: 0x0002A2B7
		public unsafe bool IsFocusable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAkCheckBox.__PropertyOffset_IsFocusable) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAkCheckBox.__PropertyOffset_IsFocusable) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000773 RID: 1907
		// (get) Token: 0x06001D9E RID: 7582 RVA: 0x0002C0C8 File Offset: 0x0002A2C8
		// (set) Token: 0x06001D9F RID: 7583 RVA: 0x0002C101 File Offset: 0x0002A301
		public FAkBoolPropertyToControl ThePropertyToControl
		{
			get
			{
				base.FastCheckIsValid();
				FAkBoolPropertyToControl result;
				if ((result = this._ThePropertyToControl) == null)
				{
					result = (this._ThePropertyToControl = new FAkBoolPropertyToControl(base.NativePtr + (IntPtr)UAkCheckBox.__PropertyOffset_ThePropertyToControl, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAkBoolPropertyToControl.StaticStruct(), base.NativePtr + (IntPtr)UAkCheckBox.__PropertyOffset_ThePropertyToControl, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000774 RID: 1908
		// (get) Token: 0x06001DA0 RID: 7584 RVA: 0x0002C124 File Offset: 0x0002A324
		// (set) Token: 0x06001DA1 RID: 7585 RVA: 0x0002C15D File Offset: 0x0002A35D
		public FAkWwiseItemToControl ItemToControl
		{
			get
			{
				base.FastCheckIsValid();
				FAkWwiseItemToControl result;
				if ((result = this._ItemToControl) == null)
				{
					result = (this._ItemToControl = new FAkWwiseItemToControl(base.NativePtr + (IntPtr)UAkCheckBox.__PropertyOffset_ItemToControl, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAkWwiseItemToControl.StaticStruct(), base.NativePtr + (IntPtr)UAkCheckBox.__PropertyOffset_ItemToControl, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000775 RID: 1909
		// (get) Token: 0x06001DA2 RID: 7586 RVA: 0x0002C180 File Offset: 0x0002A380
		// (set) Token: 0x06001DA3 RID: 7587 RVA: 0x0002C1B9 File Offset: 0x0002A3B9
		public FAkOnCheckBoxComponentStateChanged AkOnCheckStateChanged
		{
			get
			{
				base.FastCheckIsValid();
				FAkOnCheckBoxComponentStateChanged result;
				if ((result = this._AkOnCheckStateChanged) == null)
				{
					result = (this._AkOnCheckStateChanged = new FAkOnCheckBoxComponentStateChanged(base.NativePtr + (IntPtr)UAkCheckBox.__PropertyOffset_AkOnCheckStateChanged, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAkCheckBox.__PropertyOffset_AkOnCheckStateChanged, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17000776 RID: 1910
		// (get) Token: 0x06001DA4 RID: 7588 RVA: 0x0002C1DC File Offset: 0x0002A3DC
		// (set) Token: 0x06001DA5 RID: 7589 RVA: 0x0002C215 File Offset: 0x0002A415
		public FOnWwiseItemDropDetected OnItemDropped
		{
			get
			{
				base.FastCheckIsValid();
				FOnWwiseItemDropDetected result;
				if ((result = this._OnItemDropped) == null)
				{
					result = (this._OnItemDropped = new FOnWwiseItemDropDetected(base.NativePtr + (IntPtr)UAkCheckBox.__PropertyOffset_OnItemDropped, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAkCheckBox.__PropertyOffset_OnItemDropped, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17000777 RID: 1911
		// (get) Token: 0x06001DA6 RID: 7590 RVA: 0x0002C238 File Offset: 0x0002A438
		// (set) Token: 0x06001DA7 RID: 7591 RVA: 0x0002C271 File Offset: 0x0002A471
		public FOnBoolPropertyDropDetected OnPropertyDropped
		{
			get
			{
				base.FastCheckIsValid();
				FOnBoolPropertyDropDetected result;
				if ((result = this._OnPropertyDropped) == null)
				{
					result = (this._OnPropertyDropped = new FOnBoolPropertyDropDetected(base.NativePtr + (IntPtr)UAkCheckBox.__PropertyOffset_OnPropertyDropped, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAkCheckBox.__PropertyOffset_OnPropertyDropped, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x06001DA8 RID: 7592 RVA: 0x0002C292 File Offset: 0x0002A492
		public void SetIsChecked(bool InIsChecked)
		{
			UAkCheckBox.__SetIsChecked_Internal(base.NativePtr, InIsChecked);
		}

		// Token: 0x06001DA9 RID: 7593 RVA: 0x0002C2A0 File Offset: 0x0002A4A0
		public void SetCheckedState(ECheckBoxState InCheckedState)
		{
			UAkCheckBox.__SetCheckedState_Internal(base.NativePtr, InCheckedState);
		}

		// Token: 0x06001DAA RID: 7594 RVA: 0x0002C2AE File Offset: 0x0002A4AE
		public void SetAkItemId(in FGuid ItemId)
		{
			UAkCheckBox.__SetAkItemId_Internal(base.NativePtr, ItemId);
		}

		// Token: 0x06001DAB RID: 7595 RVA: 0x0002C2BC File Offset: 0x0002A4BC
		public unsafe void SetAkBoolProperty(string ItemProperty)
		{
			FString fstring = FString.AllocTemp(ItemProperty);
			UAkCheckBox.__SetAkBoolProperty_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06001DAC RID: 7596 RVA: 0x0002C2E6 File Offset: 0x0002A4E6
		public bool IsPressed()
		{
			return UAkCheckBox.__IsPressed_Internal(base.NativePtr);
		}

		// Token: 0x06001DAD RID: 7597 RVA: 0x0002C2F3 File Offset: 0x0002A4F3
		public bool IsChecked()
		{
			return UAkCheckBox.__IsChecked_Internal(base.NativePtr);
		}

		// Token: 0x06001DAE RID: 7598 RVA: 0x0002C300 File Offset: 0x0002A500
		public ECheckBoxState GetCheckedState()
		{
			return UAkCheckBox.__GetCheckedState_Internal(base.NativePtr);
		}

		// Token: 0x06001DAF RID: 7599 RVA: 0x0002C30D File Offset: 0x0002A50D
		public string GetAkProperty()
		{
			return FString.ToStringAndDeleteNativePtr(UAkCheckBox.__GetAkProperty_Internal(base.NativePtr));
		}

		// Token: 0x06001DB0 RID: 7600 RVA: 0x0002C31F File Offset: 0x0002A51F
		public FGuid GetAkItemId()
		{
			return UAkCheckBox.__GetAkItemId_Internal(base.NativePtr);
		}

		// Token: 0x06001DB1 RID: 7601
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetIsChecked_Internal(IntPtr @this, bool InIsChecked);

		// Token: 0x06001DB2 RID: 7602
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCheckedState_Internal(IntPtr @this, ECheckBoxState InCheckedState);

		// Token: 0x06001DB3 RID: 7603
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAkItemId_Internal(IntPtr @this, in FGuid ItemId);

		// Token: 0x06001DB4 RID: 7604
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAkBoolProperty_Internal(IntPtr @this, in FString ItemProperty);

		// Token: 0x06001DB5 RID: 7605
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsPressed_Internal(IntPtr @this);

		// Token: 0x06001DB6 RID: 7606
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsChecked_Internal(IntPtr @this);

		// Token: 0x06001DB7 RID: 7607
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern ECheckBoxState __GetCheckedState_Internal(IntPtr @this);

		// Token: 0x06001DB8 RID: 7608
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetAkProperty_Internal(IntPtr @this);

		// Token: 0x06001DB9 RID: 7609
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FGuid __GetAkItemId_Internal(IntPtr @this);

		// Token: 0x06001DBA RID: 7610 RVA: 0x0002C32C File Offset: 0x0002A52C
		static UAkCheckBox()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AkAudio.AkCheckBox");
		}

		// Token: 0x06001DBB RID: 7611 RVA: 0x0002C33A File Offset: 0x0002A53A
		protected UAkCheckBox(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040009C2 RID: 2498
		public new const string __ObjectPath = "/Script/AkAudio.AkCheckBox";

		// Token: 0x040009C3 RID: 2499
		private static IntPtr _ClassPtr;

		// Token: 0x040009C4 RID: 2500
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040009C5 RID: 2501
		internal static int __PropertyOffset_CheckedState;

		// Token: 0x040009C6 RID: 2502
		internal static int __PropertyOffset_CheckedStateDelegate;

		// Token: 0x040009C7 RID: 2503
		[Nullable(2)]
		private FGetCheckBoxState _CheckedStateDelegate;

		// Token: 0x040009C8 RID: 2504
		internal static int __PropertyOffset_WidgetStyle;

		// Token: 0x040009C9 RID: 2505
		[Nullable(2)]
		private FCheckBoxStyle _WidgetStyle;

		// Token: 0x040009CA RID: 2506
		internal static int __PropertyOffset_HorizontalAlignment;

		// Token: 0x040009CB RID: 2507
		internal static int __PropertyOffset_IsFocusable;

		// Token: 0x040009CC RID: 2508
		internal static int __PropertyOffset_ThePropertyToControl;

		// Token: 0x040009CD RID: 2509
		[Nullable(2)]
		private FAkBoolPropertyToControl _ThePropertyToControl;

		// Token: 0x040009CE RID: 2510
		internal static int __PropertyOffset_ItemToControl;

		// Token: 0x040009CF RID: 2511
		[Nullable(2)]
		private FAkWwiseItemToControl _ItemToControl;

		// Token: 0x040009D0 RID: 2512
		internal static int __PropertyOffset_AkOnCheckStateChanged;

		// Token: 0x040009D1 RID: 2513
		[Nullable(2)]
		private FAkOnCheckBoxComponentStateChanged _AkOnCheckStateChanged;

		// Token: 0x040009D2 RID: 2514
		internal static int __PropertyOffset_OnItemDropped;

		// Token: 0x040009D3 RID: 2515
		[Nullable(2)]
		private FOnWwiseItemDropDetected _OnItemDropped;

		// Token: 0x040009D4 RID: 2516
		internal static int __PropertyOffset_OnPropertyDropped;

		// Token: 0x040009D5 RID: 2517
		[Nullable(2)]
		private FOnBoolPropertyDropDetected _OnPropertyDropped;
	}
}
