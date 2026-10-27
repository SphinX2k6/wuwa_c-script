using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002010 RID: 8208
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.ExtendToggleTextTransitionState")]
	[UnrealStructLayout(368, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 368)]
	public class FExtendToggleTextTransitionState : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601EED4 RID: 126676 RVA: 0x002DF908 File Offset: 0x002DDB08
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FExtendToggleTextTransitionState._ScriptStructPtr != 0) ? FExtendToggleTextTransitionState._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LGUI.ExtendToggleTextTransitionState", ref FExtendToggleTextTransitionState._ScriptStructPtr);
		}

		// Token: 0x17007B19 RID: 31513
		// (get) Token: 0x0601EED5 RID: 126677 RVA: 0x002DF92C File Offset: 0x002DDB2C
		// (set) Token: 0x0601EED6 RID: 126678 RVA: 0x002DF96F File Offset: 0x002DDB6F
		public FTextTransitionInfoOfState UnCheckUnHoverState
		{
			get
			{
				base.FastCheckIsValid();
				FTextTransitionInfoOfState result;
				if ((result = this._UnCheckUnHoverState) == null)
				{
					result = (this._UnCheckUnHoverState = new FTextTransitionInfoOfState(base.NativePtr + (IntPtr)FExtendToggleTextTransitionState.__PropertyOffset_UnCheckUnHoverState, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FTextTransitionInfoOfState.StaticStruct(), base.NativePtr + (IntPtr)FExtendToggleTextTransitionState.__PropertyOffset_UnCheckUnHoverState, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007B1A RID: 31514
		// (get) Token: 0x0601EED7 RID: 126679 RVA: 0x002DF990 File Offset: 0x002DDB90
		// (set) Token: 0x0601EED8 RID: 126680 RVA: 0x002DF9D3 File Offset: 0x002DDBD3
		public FTextTransitionInfoOfState UnCheckHoverState
		{
			get
			{
				base.FastCheckIsValid();
				FTextTransitionInfoOfState result;
				if ((result = this._UnCheckHoverState) == null)
				{
					result = (this._UnCheckHoverState = new FTextTransitionInfoOfState(base.NativePtr + (IntPtr)FExtendToggleTextTransitionState.__PropertyOffset_UnCheckHoverState, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FTextTransitionInfoOfState.StaticStruct(), base.NativePtr + (IntPtr)FExtendToggleTextTransitionState.__PropertyOffset_UnCheckHoverState, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007B1B RID: 31515
		// (get) Token: 0x0601EED9 RID: 126681 RVA: 0x002DF9F4 File Offset: 0x002DDBF4
		// (set) Token: 0x0601EEDA RID: 126682 RVA: 0x002DFA37 File Offset: 0x002DDC37
		public FTextTransitionInfoOfState UnCheckPressedState
		{
			get
			{
				base.FastCheckIsValid();
				FTextTransitionInfoOfState result;
				if ((result = this._UnCheckPressedState) == null)
				{
					result = (this._UnCheckPressedState = new FTextTransitionInfoOfState(base.NativePtr + (IntPtr)FExtendToggleTextTransitionState.__PropertyOffset_UnCheckPressedState, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FTextTransitionInfoOfState.StaticStruct(), base.NativePtr + (IntPtr)FExtendToggleTextTransitionState.__PropertyOffset_UnCheckPressedState, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007B1C RID: 31516
		// (get) Token: 0x0601EEDB RID: 126683 RVA: 0x002DFA58 File Offset: 0x002DDC58
		// (set) Token: 0x0601EEDC RID: 126684 RVA: 0x002DFA9B File Offset: 0x002DDC9B
		public FTextTransitionInfoOfState CheckUnHoverState
		{
			get
			{
				base.FastCheckIsValid();
				FTextTransitionInfoOfState result;
				if ((result = this._CheckUnHoverState) == null)
				{
					result = (this._CheckUnHoverState = new FTextTransitionInfoOfState(base.NativePtr + (IntPtr)FExtendToggleTextTransitionState.__PropertyOffset_CheckUnHoverState, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FTextTransitionInfoOfState.StaticStruct(), base.NativePtr + (IntPtr)FExtendToggleTextTransitionState.__PropertyOffset_CheckUnHoverState, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007B1D RID: 31517
		// (get) Token: 0x0601EEDD RID: 126685 RVA: 0x002DFABC File Offset: 0x002DDCBC
		// (set) Token: 0x0601EEDE RID: 126686 RVA: 0x002DFAFF File Offset: 0x002DDCFF
		public FTextTransitionInfoOfState CheckHoverState
		{
			get
			{
				base.FastCheckIsValid();
				FTextTransitionInfoOfState result;
				if ((result = this._CheckHoverState) == null)
				{
					result = (this._CheckHoverState = new FTextTransitionInfoOfState(base.NativePtr + (IntPtr)FExtendToggleTextTransitionState.__PropertyOffset_CheckHoverState, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FTextTransitionInfoOfState.StaticStruct(), base.NativePtr + (IntPtr)FExtendToggleTextTransitionState.__PropertyOffset_CheckHoverState, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007B1E RID: 31518
		// (get) Token: 0x0601EEDF RID: 126687 RVA: 0x002DFB20 File Offset: 0x002DDD20
		// (set) Token: 0x0601EEE0 RID: 126688 RVA: 0x002DFB63 File Offset: 0x002DDD63
		public FTextTransitionInfoOfState CheckPressedState
		{
			get
			{
				base.FastCheckIsValid();
				FTextTransitionInfoOfState result;
				if ((result = this._CheckPressedState) == null)
				{
					result = (this._CheckPressedState = new FTextTransitionInfoOfState(base.NativePtr + (IntPtr)FExtendToggleTextTransitionState.__PropertyOffset_CheckPressedState, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FTextTransitionInfoOfState.StaticStruct(), base.NativePtr + (IntPtr)FExtendToggleTextTransitionState.__PropertyOffset_CheckPressedState, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007B1F RID: 31519
		// (get) Token: 0x0601EEE1 RID: 126689 RVA: 0x002DFB84 File Offset: 0x002DDD84
		// (set) Token: 0x0601EEE2 RID: 126690 RVA: 0x002DFBC7 File Offset: 0x002DDDC7
		public FTextTransitionInfoOfState UnDetermineUnHoverState
		{
			get
			{
				base.FastCheckIsValid();
				FTextTransitionInfoOfState result;
				if ((result = this._UnDetermineUnHoverState) == null)
				{
					result = (this._UnDetermineUnHoverState = new FTextTransitionInfoOfState(base.NativePtr + (IntPtr)FExtendToggleTextTransitionState.__PropertyOffset_UnDetermineUnHoverState, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FTextTransitionInfoOfState.StaticStruct(), base.NativePtr + (IntPtr)FExtendToggleTextTransitionState.__PropertyOffset_UnDetermineUnHoverState, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007B20 RID: 31520
		// (get) Token: 0x0601EEE3 RID: 126691 RVA: 0x002DFBE8 File Offset: 0x002DDDE8
		// (set) Token: 0x0601EEE4 RID: 126692 RVA: 0x002DFC2B File Offset: 0x002DDE2B
		public FTextTransitionInfoOfState UnDetermineHoverState
		{
			get
			{
				base.FastCheckIsValid();
				FTextTransitionInfoOfState result;
				if ((result = this._UnDetermineHoverState) == null)
				{
					result = (this._UnDetermineHoverState = new FTextTransitionInfoOfState(base.NativePtr + (IntPtr)FExtendToggleTextTransitionState.__PropertyOffset_UnDetermineHoverState, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FTextTransitionInfoOfState.StaticStruct(), base.NativePtr + (IntPtr)FExtendToggleTextTransitionState.__PropertyOffset_UnDetermineHoverState, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007B21 RID: 31521
		// (get) Token: 0x0601EEE5 RID: 126693 RVA: 0x002DFC4C File Offset: 0x002DDE4C
		// (set) Token: 0x0601EEE6 RID: 126694 RVA: 0x002DFC8F File Offset: 0x002DDE8F
		public FTextTransitionInfoOfState UnDeterminePressedState
		{
			get
			{
				base.FastCheckIsValid();
				FTextTransitionInfoOfState result;
				if ((result = this._UnDeterminePressedState) == null)
				{
					result = (this._UnDeterminePressedState = new FTextTransitionInfoOfState(base.NativePtr + (IntPtr)FExtendToggleTextTransitionState.__PropertyOffset_UnDeterminePressedState, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FTextTransitionInfoOfState.StaticStruct(), base.NativePtr + (IntPtr)FExtendToggleTextTransitionState.__PropertyOffset_UnDeterminePressedState, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007B22 RID: 31522
		// (get) Token: 0x0601EEE7 RID: 126695 RVA: 0x002DFCB0 File Offset: 0x002DDEB0
		// (set) Token: 0x0601EEE8 RID: 126696 RVA: 0x002DFCC9 File Offset: 0x002DDEC9
		public unsafe bool bEnableUnDetermined
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FExtendToggleTextTransitionState.__PropertyOffset_bEnableUnDetermined) & FExtendToggleTextTransitionState.__PropertyMask_bEnableUnDetermined) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FExtendToggleTextTransitionState.__PropertyOffset_bEnableUnDetermined) = ((*(base.NativePtr + (IntPtr)FExtendToggleTextTransitionState.__PropertyOffset_bEnableUnDetermined) & ~FExtendToggleTextTransitionState.__PropertyMask_bEnableUnDetermined) | (value ? FExtendToggleTextTransitionState.__PropertyMask_bEnableUnDetermined : 0));
			}
		}

		// Token: 0x17007B23 RID: 31523
		// (get) Token: 0x0601EEE9 RID: 126697 RVA: 0x002DFCF9 File Offset: 0x002DDEF9
		// (set) Token: 0x0601EEEA RID: 126698 RVA: 0x002DFD12 File Offset: 0x002DDF12
		public unsafe bool bCustomUnCheckedHover
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FExtendToggleTextTransitionState.__PropertyOffset_bCustomUnCheckedHover) & FExtendToggleTextTransitionState.__PropertyMask_bCustomUnCheckedHover) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FExtendToggleTextTransitionState.__PropertyOffset_bCustomUnCheckedHover) = ((*(base.NativePtr + (IntPtr)FExtendToggleTextTransitionState.__PropertyOffset_bCustomUnCheckedHover) & ~FExtendToggleTextTransitionState.__PropertyMask_bCustomUnCheckedHover) | (value ? FExtendToggleTextTransitionState.__PropertyMask_bCustomUnCheckedHover : 0));
			}
		}

		// Token: 0x17007B24 RID: 31524
		// (get) Token: 0x0601EEEB RID: 126699 RVA: 0x002DFD42 File Offset: 0x002DDF42
		// (set) Token: 0x0601EEEC RID: 126700 RVA: 0x002DFD5B File Offset: 0x002DDF5B
		public unsafe bool bCustomUnCheckedPressed
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FExtendToggleTextTransitionState.__PropertyOffset_bCustomUnCheckedPressed) & FExtendToggleTextTransitionState.__PropertyMask_bCustomUnCheckedPressed) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FExtendToggleTextTransitionState.__PropertyOffset_bCustomUnCheckedPressed) = ((*(base.NativePtr + (IntPtr)FExtendToggleTextTransitionState.__PropertyOffset_bCustomUnCheckedPressed) & ~FExtendToggleTextTransitionState.__PropertyMask_bCustomUnCheckedPressed) | (value ? FExtendToggleTextTransitionState.__PropertyMask_bCustomUnCheckedPressed : 0));
			}
		}

		// Token: 0x17007B25 RID: 31525
		// (get) Token: 0x0601EEED RID: 126701 RVA: 0x002DFD8B File Offset: 0x002DDF8B
		// (set) Token: 0x0601EEEE RID: 126702 RVA: 0x002DFDA4 File Offset: 0x002DDFA4
		public unsafe bool bCustomCheckedHover
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FExtendToggleTextTransitionState.__PropertyOffset_bCustomCheckedHover) & FExtendToggleTextTransitionState.__PropertyMask_bCustomCheckedHover) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FExtendToggleTextTransitionState.__PropertyOffset_bCustomCheckedHover) = ((*(base.NativePtr + (IntPtr)FExtendToggleTextTransitionState.__PropertyOffset_bCustomCheckedHover) & ~FExtendToggleTextTransitionState.__PropertyMask_bCustomCheckedHover) | (value ? FExtendToggleTextTransitionState.__PropertyMask_bCustomCheckedHover : 0));
			}
		}

		// Token: 0x17007B26 RID: 31526
		// (get) Token: 0x0601EEEF RID: 126703 RVA: 0x002DFDD4 File Offset: 0x002DDFD4
		// (set) Token: 0x0601EEF0 RID: 126704 RVA: 0x002DFDED File Offset: 0x002DDFED
		public unsafe bool bCustomCheckedPressed
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FExtendToggleTextTransitionState.__PropertyOffset_bCustomCheckedPressed) & FExtendToggleTextTransitionState.__PropertyMask_bCustomCheckedPressed) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FExtendToggleTextTransitionState.__PropertyOffset_bCustomCheckedPressed) = ((*(base.NativePtr + (IntPtr)FExtendToggleTextTransitionState.__PropertyOffset_bCustomCheckedPressed) & ~FExtendToggleTextTransitionState.__PropertyMask_bCustomCheckedPressed) | (value ? FExtendToggleTextTransitionState.__PropertyMask_bCustomCheckedPressed : 0));
			}
		}

		// Token: 0x17007B27 RID: 31527
		// (get) Token: 0x0601EEF1 RID: 126705 RVA: 0x002DFE1D File Offset: 0x002DE01D
		// (set) Token: 0x0601EEF2 RID: 126706 RVA: 0x002DFE36 File Offset: 0x002DE036
		public unsafe bool bCustomUnDeterminedHover
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FExtendToggleTextTransitionState.__PropertyOffset_bCustomUnDeterminedHover) & FExtendToggleTextTransitionState.__PropertyMask_bCustomUnDeterminedHover) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FExtendToggleTextTransitionState.__PropertyOffset_bCustomUnDeterminedHover) = ((*(base.NativePtr + (IntPtr)FExtendToggleTextTransitionState.__PropertyOffset_bCustomUnDeterminedHover) & ~FExtendToggleTextTransitionState.__PropertyMask_bCustomUnDeterminedHover) | (value ? FExtendToggleTextTransitionState.__PropertyMask_bCustomUnDeterminedHover : 0));
			}
		}

		// Token: 0x17007B28 RID: 31528
		// (get) Token: 0x0601EEF3 RID: 126707 RVA: 0x002DFE66 File Offset: 0x002DE066
		// (set) Token: 0x0601EEF4 RID: 126708 RVA: 0x002DFE7F File Offset: 0x002DE07F
		public unsafe bool bCustomUnDeterminePressed
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FExtendToggleTextTransitionState.__PropertyOffset_bCustomUnDeterminePressed) & FExtendToggleTextTransitionState.__PropertyMask_bCustomUnDeterminePressed) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FExtendToggleTextTransitionState.__PropertyOffset_bCustomUnDeterminePressed) = ((*(base.NativePtr + (IntPtr)FExtendToggleTextTransitionState.__PropertyOffset_bCustomUnDeterminePressed) & ~FExtendToggleTextTransitionState.__PropertyMask_bCustomUnDeterminePressed) | (value ? FExtendToggleTextTransitionState.__PropertyMask_bCustomUnDeterminePressed : 0));
			}
		}

		// Token: 0x0601EEF5 RID: 126709 RVA: 0x002DFEAF File Offset: 0x002DE0AF
		public FExtendToggleTextTransitionState()
		{
		}

		// Token: 0x0601EEF6 RID: 126710 RVA: 0x002DFEB8 File Offset: 0x002DE0B8
		public FExtendToggleTextTransitionState(FTextTransitionInfoOfState UnCheckUnHoverState, FTextTransitionInfoOfState UnCheckHoverState, FTextTransitionInfoOfState UnCheckPressedState, FTextTransitionInfoOfState CheckUnHoverState, FTextTransitionInfoOfState CheckHoverState, FTextTransitionInfoOfState CheckPressedState, FTextTransitionInfoOfState UnDetermineUnHoverState, FTextTransitionInfoOfState UnDetermineHoverState, FTextTransitionInfoOfState UnDeterminePressedState, bool bEnableUnDetermined, bool bCustomUnCheckedHover, bool bCustomUnCheckedPressed, bool bCustomCheckedHover, bool bCustomCheckedPressed, bool bCustomUnDeterminedHover, bool bCustomUnDeterminePressed)
		{
			this.UnCheckUnHoverState = UnCheckUnHoverState;
			this.UnCheckHoverState = UnCheckHoverState;
			this.UnCheckPressedState = UnCheckPressedState;
			this.CheckUnHoverState = CheckUnHoverState;
			this.CheckHoverState = CheckHoverState;
			this.CheckPressedState = CheckPressedState;
			this.UnDetermineUnHoverState = UnDetermineUnHoverState;
			this.UnDetermineHoverState = UnDetermineHoverState;
			this.UnDeterminePressedState = UnDeterminePressedState;
			this.bEnableUnDetermined = bEnableUnDetermined;
			this.bCustomUnCheckedHover = bCustomUnCheckedHover;
			this.bCustomUnCheckedPressed = bCustomUnCheckedPressed;
			this.bCustomCheckedHover = bCustomCheckedHover;
			this.bCustomCheckedPressed = bCustomCheckedPressed;
			this.bCustomUnDeterminedHover = bCustomUnDeterminedHover;
			this.bCustomUnDeterminePressed = bCustomUnDeterminePressed;
		}

		// Token: 0x0601EEF7 RID: 126711 RVA: 0x002DFF48 File Offset: 0x002DE148
		protected override IntPtr GetUStructPtr()
		{
			return FExtendToggleTextTransitionState.StaticStruct();
		}

		// Token: 0x0601EEF8 RID: 126712 RVA: 0x002DFF54 File Offset: 0x002DE154
		[NullableContext(2)]
		public FExtendToggleTextTransitionState(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601EEF9 RID: 126713 RVA: 0x002DFF5E File Offset: 0x002DE15E
		public FExtendToggleTextTransitionState(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601EEFA RID: 126714 RVA: 0x002DFF69 File Offset: 0x002DE169
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FExtendToggleTextTransitionState(Pointer, false, true);
		}

		// Token: 0x0601EEFB RID: 126715 RVA: 0x002DFF73 File Offset: 0x002DE173
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FExtendToggleTextTransitionState(Pointer, MemoryOwner);
		}

		// Token: 0x04010CF4 RID: 68852
		public const string __ObjectPath = "/Script/LGUI.ExtendToggleTextTransitionState";

		// Token: 0x04010CF5 RID: 68853
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010CF6 RID: 68854
		internal static int __PropertyOffset_UnCheckUnHoverState;

		// Token: 0x04010CF7 RID: 68855
		[Nullable(2)]
		private FTextTransitionInfoOfState _UnCheckUnHoverState;

		// Token: 0x04010CF8 RID: 68856
		internal static int __PropertyOffset_UnCheckHoverState;

		// Token: 0x04010CF9 RID: 68857
		[Nullable(2)]
		private FTextTransitionInfoOfState _UnCheckHoverState;

		// Token: 0x04010CFA RID: 68858
		internal static int __PropertyOffset_UnCheckPressedState;

		// Token: 0x04010CFB RID: 68859
		[Nullable(2)]
		private FTextTransitionInfoOfState _UnCheckPressedState;

		// Token: 0x04010CFC RID: 68860
		internal static int __PropertyOffset_CheckUnHoverState;

		// Token: 0x04010CFD RID: 68861
		[Nullable(2)]
		private FTextTransitionInfoOfState _CheckUnHoverState;

		// Token: 0x04010CFE RID: 68862
		internal static int __PropertyOffset_CheckHoverState;

		// Token: 0x04010CFF RID: 68863
		[Nullable(2)]
		private FTextTransitionInfoOfState _CheckHoverState;

		// Token: 0x04010D00 RID: 68864
		internal static int __PropertyOffset_CheckPressedState;

		// Token: 0x04010D01 RID: 68865
		[Nullable(2)]
		private FTextTransitionInfoOfState _CheckPressedState;

		// Token: 0x04010D02 RID: 68866
		internal static int __PropertyOffset_UnDetermineUnHoverState;

		// Token: 0x04010D03 RID: 68867
		[Nullable(2)]
		private FTextTransitionInfoOfState _UnDetermineUnHoverState;

		// Token: 0x04010D04 RID: 68868
		internal static int __PropertyOffset_UnDetermineHoverState;

		// Token: 0x04010D05 RID: 68869
		[Nullable(2)]
		private FTextTransitionInfoOfState _UnDetermineHoverState;

		// Token: 0x04010D06 RID: 68870
		internal static int __PropertyOffset_UnDeterminePressedState;

		// Token: 0x04010D07 RID: 68871
		[Nullable(2)]
		private FTextTransitionInfoOfState _UnDeterminePressedState;

		// Token: 0x04010D08 RID: 68872
		internal static int __PropertyOffset_bEnableUnDetermined;

		// Token: 0x04010D09 RID: 68873
		internal static byte __PropertyMask_bEnableUnDetermined;

		// Token: 0x04010D0A RID: 68874
		internal static int __PropertyOffset_bCustomUnCheckedHover;

		// Token: 0x04010D0B RID: 68875
		internal static byte __PropertyMask_bCustomUnCheckedHover;

		// Token: 0x04010D0C RID: 68876
		internal static int __PropertyOffset_bCustomUnCheckedPressed;

		// Token: 0x04010D0D RID: 68877
		internal static byte __PropertyMask_bCustomUnCheckedPressed;

		// Token: 0x04010D0E RID: 68878
		internal static int __PropertyOffset_bCustomCheckedHover;

		// Token: 0x04010D0F RID: 68879
		internal static byte __PropertyMask_bCustomCheckedHover;

		// Token: 0x04010D10 RID: 68880
		internal static int __PropertyOffset_bCustomCheckedPressed;

		// Token: 0x04010D11 RID: 68881
		internal static byte __PropertyMask_bCustomCheckedPressed;

		// Token: 0x04010D12 RID: 68882
		internal static int __PropertyOffset_bCustomUnDeterminedHover;

		// Token: 0x04010D13 RID: 68883
		internal static byte __PropertyMask_bCustomUnDeterminedHover;

		// Token: 0x04010D14 RID: 68884
		internal static int __PropertyOffset_bCustomUnDeterminePressed;

		// Token: 0x04010D15 RID: 68885
		internal static byte __PropertyMask_bCustomUnDeterminePressed;
	}
}
