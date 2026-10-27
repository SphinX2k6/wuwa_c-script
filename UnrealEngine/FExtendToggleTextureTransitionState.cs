using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002011 RID: 8209
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.ExtendToggleTextureTransitionState")]
	[UnrealStructLayout(512, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 512)]
	public class FExtendToggleTextureTransitionState : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601EEFC RID: 126716 RVA: 0x002DFF7C File Offset: 0x002DE17C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FExtendToggleTextureTransitionState._ScriptStructPtr != 0) ? FExtendToggleTextureTransitionState._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LGUI.ExtendToggleTextureTransitionState", ref FExtendToggleTextureTransitionState._ScriptStructPtr);
		}

		// Token: 0x17007B29 RID: 31529
		// (get) Token: 0x0601EEFD RID: 126717 RVA: 0x002DFFA0 File Offset: 0x002DE1A0
		// (set) Token: 0x0601EEFE RID: 126718 RVA: 0x002DFFE3 File Offset: 0x002DE1E3
		public FTextureTransitionOfState UnCheckUnHoverState
		{
			get
			{
				base.FastCheckIsValid();
				FTextureTransitionOfState result;
				if ((result = this._UnCheckUnHoverState) == null)
				{
					result = (this._UnCheckUnHoverState = new FTextureTransitionOfState(base.NativePtr + (IntPtr)FExtendToggleTextureTransitionState.__PropertyOffset_UnCheckUnHoverState, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FTextureTransitionOfState.StaticStruct(), base.NativePtr + (IntPtr)FExtendToggleTextureTransitionState.__PropertyOffset_UnCheckUnHoverState, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007B2A RID: 31530
		// (get) Token: 0x0601EEFF RID: 126719 RVA: 0x002E0004 File Offset: 0x002DE204
		// (set) Token: 0x0601EF00 RID: 126720 RVA: 0x002E0047 File Offset: 0x002DE247
		public FTextureTransitionOfState UnCheckHoverState
		{
			get
			{
				base.FastCheckIsValid();
				FTextureTransitionOfState result;
				if ((result = this._UnCheckHoverState) == null)
				{
					result = (this._UnCheckHoverState = new FTextureTransitionOfState(base.NativePtr + (IntPtr)FExtendToggleTextureTransitionState.__PropertyOffset_UnCheckHoverState, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FTextureTransitionOfState.StaticStruct(), base.NativePtr + (IntPtr)FExtendToggleTextureTransitionState.__PropertyOffset_UnCheckHoverState, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007B2B RID: 31531
		// (get) Token: 0x0601EF01 RID: 126721 RVA: 0x002E0068 File Offset: 0x002DE268
		// (set) Token: 0x0601EF02 RID: 126722 RVA: 0x002E00AB File Offset: 0x002DE2AB
		public FTextureTransitionOfState UnCheckPressedState
		{
			get
			{
				base.FastCheckIsValid();
				FTextureTransitionOfState result;
				if ((result = this._UnCheckPressedState) == null)
				{
					result = (this._UnCheckPressedState = new FTextureTransitionOfState(base.NativePtr + (IntPtr)FExtendToggleTextureTransitionState.__PropertyOffset_UnCheckPressedState, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FTextureTransitionOfState.StaticStruct(), base.NativePtr + (IntPtr)FExtendToggleTextureTransitionState.__PropertyOffset_UnCheckPressedState, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007B2C RID: 31532
		// (get) Token: 0x0601EF03 RID: 126723 RVA: 0x002E00CC File Offset: 0x002DE2CC
		// (set) Token: 0x0601EF04 RID: 126724 RVA: 0x002E010F File Offset: 0x002DE30F
		public FTextureTransitionOfState CheckUnHoverState
		{
			get
			{
				base.FastCheckIsValid();
				FTextureTransitionOfState result;
				if ((result = this._CheckUnHoverState) == null)
				{
					result = (this._CheckUnHoverState = new FTextureTransitionOfState(base.NativePtr + (IntPtr)FExtendToggleTextureTransitionState.__PropertyOffset_CheckUnHoverState, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FTextureTransitionOfState.StaticStruct(), base.NativePtr + (IntPtr)FExtendToggleTextureTransitionState.__PropertyOffset_CheckUnHoverState, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007B2D RID: 31533
		// (get) Token: 0x0601EF05 RID: 126725 RVA: 0x002E0130 File Offset: 0x002DE330
		// (set) Token: 0x0601EF06 RID: 126726 RVA: 0x002E0173 File Offset: 0x002DE373
		public FTextureTransitionOfState CheckHoverState
		{
			get
			{
				base.FastCheckIsValid();
				FTextureTransitionOfState result;
				if ((result = this._CheckHoverState) == null)
				{
					result = (this._CheckHoverState = new FTextureTransitionOfState(base.NativePtr + (IntPtr)FExtendToggleTextureTransitionState.__PropertyOffset_CheckHoverState, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FTextureTransitionOfState.StaticStruct(), base.NativePtr + (IntPtr)FExtendToggleTextureTransitionState.__PropertyOffset_CheckHoverState, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007B2E RID: 31534
		// (get) Token: 0x0601EF07 RID: 126727 RVA: 0x002E0194 File Offset: 0x002DE394
		// (set) Token: 0x0601EF08 RID: 126728 RVA: 0x002E01D7 File Offset: 0x002DE3D7
		public FTextureTransitionOfState CheckPressedState
		{
			get
			{
				base.FastCheckIsValid();
				FTextureTransitionOfState result;
				if ((result = this._CheckPressedState) == null)
				{
					result = (this._CheckPressedState = new FTextureTransitionOfState(base.NativePtr + (IntPtr)FExtendToggleTextureTransitionState.__PropertyOffset_CheckPressedState, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FTextureTransitionOfState.StaticStruct(), base.NativePtr + (IntPtr)FExtendToggleTextureTransitionState.__PropertyOffset_CheckPressedState, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007B2F RID: 31535
		// (get) Token: 0x0601EF09 RID: 126729 RVA: 0x002E01F8 File Offset: 0x002DE3F8
		// (set) Token: 0x0601EF0A RID: 126730 RVA: 0x002E023B File Offset: 0x002DE43B
		public FTextureTransitionOfState UnDetermineUnHoverState
		{
			get
			{
				base.FastCheckIsValid();
				FTextureTransitionOfState result;
				if ((result = this._UnDetermineUnHoverState) == null)
				{
					result = (this._UnDetermineUnHoverState = new FTextureTransitionOfState(base.NativePtr + (IntPtr)FExtendToggleTextureTransitionState.__PropertyOffset_UnDetermineUnHoverState, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FTextureTransitionOfState.StaticStruct(), base.NativePtr + (IntPtr)FExtendToggleTextureTransitionState.__PropertyOffset_UnDetermineUnHoverState, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007B30 RID: 31536
		// (get) Token: 0x0601EF0B RID: 126731 RVA: 0x002E025C File Offset: 0x002DE45C
		// (set) Token: 0x0601EF0C RID: 126732 RVA: 0x002E029F File Offset: 0x002DE49F
		public FTextureTransitionOfState UnDetermineHoverState
		{
			get
			{
				base.FastCheckIsValid();
				FTextureTransitionOfState result;
				if ((result = this._UnDetermineHoverState) == null)
				{
					result = (this._UnDetermineHoverState = new FTextureTransitionOfState(base.NativePtr + (IntPtr)FExtendToggleTextureTransitionState.__PropertyOffset_UnDetermineHoverState, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FTextureTransitionOfState.StaticStruct(), base.NativePtr + (IntPtr)FExtendToggleTextureTransitionState.__PropertyOffset_UnDetermineHoverState, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007B31 RID: 31537
		// (get) Token: 0x0601EF0D RID: 126733 RVA: 0x002E02C0 File Offset: 0x002DE4C0
		// (set) Token: 0x0601EF0E RID: 126734 RVA: 0x002E0303 File Offset: 0x002DE503
		public FTextureTransitionOfState UnDeterminePressedState
		{
			get
			{
				base.FastCheckIsValid();
				FTextureTransitionOfState result;
				if ((result = this._UnDeterminePressedState) == null)
				{
					result = (this._UnDeterminePressedState = new FTextureTransitionOfState(base.NativePtr + (IntPtr)FExtendToggleTextureTransitionState.__PropertyOffset_UnDeterminePressedState, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FTextureTransitionOfState.StaticStruct(), base.NativePtr + (IntPtr)FExtendToggleTextureTransitionState.__PropertyOffset_UnDeterminePressedState, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007B32 RID: 31538
		// (get) Token: 0x0601EF0F RID: 126735 RVA: 0x002E0324 File Offset: 0x002DE524
		// (set) Token: 0x0601EF10 RID: 126736 RVA: 0x002E033D File Offset: 0x002DE53D
		public unsafe bool bEnableUnDetermined
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FExtendToggleTextureTransitionState.__PropertyOffset_bEnableUnDetermined) & FExtendToggleTextureTransitionState.__PropertyMask_bEnableUnDetermined) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FExtendToggleTextureTransitionState.__PropertyOffset_bEnableUnDetermined) = ((*(base.NativePtr + (IntPtr)FExtendToggleTextureTransitionState.__PropertyOffset_bEnableUnDetermined) & ~FExtendToggleTextureTransitionState.__PropertyMask_bEnableUnDetermined) | (value ? FExtendToggleTextureTransitionState.__PropertyMask_bEnableUnDetermined : 0));
			}
		}

		// Token: 0x17007B33 RID: 31539
		// (get) Token: 0x0601EF11 RID: 126737 RVA: 0x002E036D File Offset: 0x002DE56D
		// (set) Token: 0x0601EF12 RID: 126738 RVA: 0x002E0386 File Offset: 0x002DE586
		public unsafe bool bCustomUnCheckedHover
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FExtendToggleTextureTransitionState.__PropertyOffset_bCustomUnCheckedHover) & FExtendToggleTextureTransitionState.__PropertyMask_bCustomUnCheckedHover) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FExtendToggleTextureTransitionState.__PropertyOffset_bCustomUnCheckedHover) = ((*(base.NativePtr + (IntPtr)FExtendToggleTextureTransitionState.__PropertyOffset_bCustomUnCheckedHover) & ~FExtendToggleTextureTransitionState.__PropertyMask_bCustomUnCheckedHover) | (value ? FExtendToggleTextureTransitionState.__PropertyMask_bCustomUnCheckedHover : 0));
			}
		}

		// Token: 0x17007B34 RID: 31540
		// (get) Token: 0x0601EF13 RID: 126739 RVA: 0x002E03B6 File Offset: 0x002DE5B6
		// (set) Token: 0x0601EF14 RID: 126740 RVA: 0x002E03CF File Offset: 0x002DE5CF
		public unsafe bool bCustomUnCheckedPressed
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FExtendToggleTextureTransitionState.__PropertyOffset_bCustomUnCheckedPressed) & FExtendToggleTextureTransitionState.__PropertyMask_bCustomUnCheckedPressed) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FExtendToggleTextureTransitionState.__PropertyOffset_bCustomUnCheckedPressed) = ((*(base.NativePtr + (IntPtr)FExtendToggleTextureTransitionState.__PropertyOffset_bCustomUnCheckedPressed) & ~FExtendToggleTextureTransitionState.__PropertyMask_bCustomUnCheckedPressed) | (value ? FExtendToggleTextureTransitionState.__PropertyMask_bCustomUnCheckedPressed : 0));
			}
		}

		// Token: 0x17007B35 RID: 31541
		// (get) Token: 0x0601EF15 RID: 126741 RVA: 0x002E03FF File Offset: 0x002DE5FF
		// (set) Token: 0x0601EF16 RID: 126742 RVA: 0x002E0418 File Offset: 0x002DE618
		public unsafe bool bCustomCheckedHover
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FExtendToggleTextureTransitionState.__PropertyOffset_bCustomCheckedHover) & FExtendToggleTextureTransitionState.__PropertyMask_bCustomCheckedHover) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FExtendToggleTextureTransitionState.__PropertyOffset_bCustomCheckedHover) = ((*(base.NativePtr + (IntPtr)FExtendToggleTextureTransitionState.__PropertyOffset_bCustomCheckedHover) & ~FExtendToggleTextureTransitionState.__PropertyMask_bCustomCheckedHover) | (value ? FExtendToggleTextureTransitionState.__PropertyMask_bCustomCheckedHover : 0));
			}
		}

		// Token: 0x17007B36 RID: 31542
		// (get) Token: 0x0601EF17 RID: 126743 RVA: 0x002E0448 File Offset: 0x002DE648
		// (set) Token: 0x0601EF18 RID: 126744 RVA: 0x002E0461 File Offset: 0x002DE661
		public unsafe bool bCustomCheckedPressed
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FExtendToggleTextureTransitionState.__PropertyOffset_bCustomCheckedPressed) & FExtendToggleTextureTransitionState.__PropertyMask_bCustomCheckedPressed) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FExtendToggleTextureTransitionState.__PropertyOffset_bCustomCheckedPressed) = ((*(base.NativePtr + (IntPtr)FExtendToggleTextureTransitionState.__PropertyOffset_bCustomCheckedPressed) & ~FExtendToggleTextureTransitionState.__PropertyMask_bCustomCheckedPressed) | (value ? FExtendToggleTextureTransitionState.__PropertyMask_bCustomCheckedPressed : 0));
			}
		}

		// Token: 0x17007B37 RID: 31543
		// (get) Token: 0x0601EF19 RID: 126745 RVA: 0x002E0491 File Offset: 0x002DE691
		// (set) Token: 0x0601EF1A RID: 126746 RVA: 0x002E04AA File Offset: 0x002DE6AA
		public unsafe bool bCustomUnDeterminedHover
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FExtendToggleTextureTransitionState.__PropertyOffset_bCustomUnDeterminedHover) & FExtendToggleTextureTransitionState.__PropertyMask_bCustomUnDeterminedHover) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FExtendToggleTextureTransitionState.__PropertyOffset_bCustomUnDeterminedHover) = ((*(base.NativePtr + (IntPtr)FExtendToggleTextureTransitionState.__PropertyOffset_bCustomUnDeterminedHover) & ~FExtendToggleTextureTransitionState.__PropertyMask_bCustomUnDeterminedHover) | (value ? FExtendToggleTextureTransitionState.__PropertyMask_bCustomUnDeterminedHover : 0));
			}
		}

		// Token: 0x17007B38 RID: 31544
		// (get) Token: 0x0601EF1B RID: 126747 RVA: 0x002E04DA File Offset: 0x002DE6DA
		// (set) Token: 0x0601EF1C RID: 126748 RVA: 0x002E04F3 File Offset: 0x002DE6F3
		public unsafe bool bCustomUnDeterminePressed
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FExtendToggleTextureTransitionState.__PropertyOffset_bCustomUnDeterminePressed) & FExtendToggleTextureTransitionState.__PropertyMask_bCustomUnDeterminePressed) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FExtendToggleTextureTransitionState.__PropertyOffset_bCustomUnDeterminePressed) = ((*(base.NativePtr + (IntPtr)FExtendToggleTextureTransitionState.__PropertyOffset_bCustomUnDeterminePressed) & ~FExtendToggleTextureTransitionState.__PropertyMask_bCustomUnDeterminePressed) | (value ? FExtendToggleTextureTransitionState.__PropertyMask_bCustomUnDeterminePressed : 0));
			}
		}

		// Token: 0x0601EF1D RID: 126749 RVA: 0x002E0523 File Offset: 0x002DE723
		public FExtendToggleTextureTransitionState()
		{
		}

		// Token: 0x0601EF1E RID: 126750 RVA: 0x002E052C File Offset: 0x002DE72C
		public FExtendToggleTextureTransitionState(FTextureTransitionOfState UnCheckUnHoverState, FTextureTransitionOfState UnCheckHoverState, FTextureTransitionOfState UnCheckPressedState, FTextureTransitionOfState CheckUnHoverState, FTextureTransitionOfState CheckHoverState, FTextureTransitionOfState CheckPressedState, FTextureTransitionOfState UnDetermineUnHoverState, FTextureTransitionOfState UnDetermineHoverState, FTextureTransitionOfState UnDeterminePressedState, bool bEnableUnDetermined, bool bCustomUnCheckedHover, bool bCustomUnCheckedPressed, bool bCustomCheckedHover, bool bCustomCheckedPressed, bool bCustomUnDeterminedHover, bool bCustomUnDeterminePressed)
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

		// Token: 0x0601EF1F RID: 126751 RVA: 0x002E05BC File Offset: 0x002DE7BC
		protected override IntPtr GetUStructPtr()
		{
			return FExtendToggleTextureTransitionState.StaticStruct();
		}

		// Token: 0x0601EF20 RID: 126752 RVA: 0x002E05C8 File Offset: 0x002DE7C8
		[NullableContext(2)]
		public FExtendToggleTextureTransitionState(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601EF21 RID: 126753 RVA: 0x002E05D2 File Offset: 0x002DE7D2
		public FExtendToggleTextureTransitionState(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601EF22 RID: 126754 RVA: 0x002E05DD File Offset: 0x002DE7DD
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FExtendToggleTextureTransitionState(Pointer, false, true);
		}

		// Token: 0x0601EF23 RID: 126755 RVA: 0x002E05E7 File Offset: 0x002DE7E7
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FExtendToggleTextureTransitionState(Pointer, MemoryOwner);
		}

		// Token: 0x04010D16 RID: 68886
		public const string __ObjectPath = "/Script/LGUI.ExtendToggleTextureTransitionState";

		// Token: 0x04010D17 RID: 68887
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010D18 RID: 68888
		internal static int __PropertyOffset_UnCheckUnHoverState;

		// Token: 0x04010D19 RID: 68889
		[Nullable(2)]
		private FTextureTransitionOfState _UnCheckUnHoverState;

		// Token: 0x04010D1A RID: 68890
		internal static int __PropertyOffset_UnCheckHoverState;

		// Token: 0x04010D1B RID: 68891
		[Nullable(2)]
		private FTextureTransitionOfState _UnCheckHoverState;

		// Token: 0x04010D1C RID: 68892
		internal static int __PropertyOffset_UnCheckPressedState;

		// Token: 0x04010D1D RID: 68893
		[Nullable(2)]
		private FTextureTransitionOfState _UnCheckPressedState;

		// Token: 0x04010D1E RID: 68894
		internal static int __PropertyOffset_CheckUnHoverState;

		// Token: 0x04010D1F RID: 68895
		[Nullable(2)]
		private FTextureTransitionOfState _CheckUnHoverState;

		// Token: 0x04010D20 RID: 68896
		internal static int __PropertyOffset_CheckHoverState;

		// Token: 0x04010D21 RID: 68897
		[Nullable(2)]
		private FTextureTransitionOfState _CheckHoverState;

		// Token: 0x04010D22 RID: 68898
		internal static int __PropertyOffset_CheckPressedState;

		// Token: 0x04010D23 RID: 68899
		[Nullable(2)]
		private FTextureTransitionOfState _CheckPressedState;

		// Token: 0x04010D24 RID: 68900
		internal static int __PropertyOffset_UnDetermineUnHoverState;

		// Token: 0x04010D25 RID: 68901
		[Nullable(2)]
		private FTextureTransitionOfState _UnDetermineUnHoverState;

		// Token: 0x04010D26 RID: 68902
		internal static int __PropertyOffset_UnDetermineHoverState;

		// Token: 0x04010D27 RID: 68903
		[Nullable(2)]
		private FTextureTransitionOfState _UnDetermineHoverState;

		// Token: 0x04010D28 RID: 68904
		internal static int __PropertyOffset_UnDeterminePressedState;

		// Token: 0x04010D29 RID: 68905
		[Nullable(2)]
		private FTextureTransitionOfState _UnDeterminePressedState;

		// Token: 0x04010D2A RID: 68906
		internal static int __PropertyOffset_bEnableUnDetermined;

		// Token: 0x04010D2B RID: 68907
		internal static byte __PropertyMask_bEnableUnDetermined;

		// Token: 0x04010D2C RID: 68908
		internal static int __PropertyOffset_bCustomUnCheckedHover;

		// Token: 0x04010D2D RID: 68909
		internal static byte __PropertyMask_bCustomUnCheckedHover;

		// Token: 0x04010D2E RID: 68910
		internal static int __PropertyOffset_bCustomUnCheckedPressed;

		// Token: 0x04010D2F RID: 68911
		internal static byte __PropertyMask_bCustomUnCheckedPressed;

		// Token: 0x04010D30 RID: 68912
		internal static int __PropertyOffset_bCustomCheckedHover;

		// Token: 0x04010D31 RID: 68913
		internal static byte __PropertyMask_bCustomCheckedHover;

		// Token: 0x04010D32 RID: 68914
		internal static int __PropertyOffset_bCustomCheckedPressed;

		// Token: 0x04010D33 RID: 68915
		internal static byte __PropertyMask_bCustomCheckedPressed;

		// Token: 0x04010D34 RID: 68916
		internal static int __PropertyOffset_bCustomUnDeterminedHover;

		// Token: 0x04010D35 RID: 68917
		internal static byte __PropertyMask_bCustomUnDeterminedHover;

		// Token: 0x04010D36 RID: 68918
		internal static int __PropertyOffset_bCustomUnDeterminePressed;

		// Token: 0x04010D37 RID: 68919
		internal static byte __PropertyMask_bCustomUnDeterminePressed;
	}
}
