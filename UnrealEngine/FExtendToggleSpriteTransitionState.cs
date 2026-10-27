using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200200F RID: 8207
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.ExtendToggleSpriteTransitionState")]
	[UnrealStructLayout(440, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 440)]
	public class FExtendToggleSpriteTransitionState : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601EEAC RID: 126636 RVA: 0x002DF294 File Offset: 0x002DD494
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FExtendToggleSpriteTransitionState._ScriptStructPtr != 0) ? FExtendToggleSpriteTransitionState._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LGUI.ExtendToggleSpriteTransitionState", ref FExtendToggleSpriteTransitionState._ScriptStructPtr);
		}

		// Token: 0x17007B09 RID: 31497
		// (get) Token: 0x0601EEAD RID: 126637 RVA: 0x002DF2B8 File Offset: 0x002DD4B8
		// (set) Token: 0x0601EEAE RID: 126638 RVA: 0x002DF2FB File Offset: 0x002DD4FB
		public FSpriteTransitionOfState UnCheckedUnHoverState
		{
			get
			{
				base.FastCheckIsValid();
				FSpriteTransitionOfState result;
				if ((result = this._UnCheckedUnHoverState) == null)
				{
					result = (this._UnCheckedUnHoverState = new FSpriteTransitionOfState(base.NativePtr + (IntPtr)FExtendToggleSpriteTransitionState.__PropertyOffset_UnCheckedUnHoverState, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSpriteTransitionOfState.StaticStruct(), base.NativePtr + (IntPtr)FExtendToggleSpriteTransitionState.__PropertyOffset_UnCheckedUnHoverState, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007B0A RID: 31498
		// (get) Token: 0x0601EEAF RID: 126639 RVA: 0x002DF31C File Offset: 0x002DD51C
		// (set) Token: 0x0601EEB0 RID: 126640 RVA: 0x002DF35F File Offset: 0x002DD55F
		public FSpriteTransitionOfState UnCheckedHoverState
		{
			get
			{
				base.FastCheckIsValid();
				FSpriteTransitionOfState result;
				if ((result = this._UnCheckedHoverState) == null)
				{
					result = (this._UnCheckedHoverState = new FSpriteTransitionOfState(base.NativePtr + (IntPtr)FExtendToggleSpriteTransitionState.__PropertyOffset_UnCheckedHoverState, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSpriteTransitionOfState.StaticStruct(), base.NativePtr + (IntPtr)FExtendToggleSpriteTransitionState.__PropertyOffset_UnCheckedHoverState, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007B0B RID: 31499
		// (get) Token: 0x0601EEB1 RID: 126641 RVA: 0x002DF380 File Offset: 0x002DD580
		// (set) Token: 0x0601EEB2 RID: 126642 RVA: 0x002DF3C3 File Offset: 0x002DD5C3
		public FSpriteTransitionOfState UnCheckedPressedState
		{
			get
			{
				base.FastCheckIsValid();
				FSpriteTransitionOfState result;
				if ((result = this._UnCheckedPressedState) == null)
				{
					result = (this._UnCheckedPressedState = new FSpriteTransitionOfState(base.NativePtr + (IntPtr)FExtendToggleSpriteTransitionState.__PropertyOffset_UnCheckedPressedState, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSpriteTransitionOfState.StaticStruct(), base.NativePtr + (IntPtr)FExtendToggleSpriteTransitionState.__PropertyOffset_UnCheckedPressedState, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007B0C RID: 31500
		// (get) Token: 0x0601EEB3 RID: 126643 RVA: 0x002DF3E4 File Offset: 0x002DD5E4
		// (set) Token: 0x0601EEB4 RID: 126644 RVA: 0x002DF427 File Offset: 0x002DD627
		public FSpriteTransitionOfState CheckedUnHoverState
		{
			get
			{
				base.FastCheckIsValid();
				FSpriteTransitionOfState result;
				if ((result = this._CheckedUnHoverState) == null)
				{
					result = (this._CheckedUnHoverState = new FSpriteTransitionOfState(base.NativePtr + (IntPtr)FExtendToggleSpriteTransitionState.__PropertyOffset_CheckedUnHoverState, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSpriteTransitionOfState.StaticStruct(), base.NativePtr + (IntPtr)FExtendToggleSpriteTransitionState.__PropertyOffset_CheckedUnHoverState, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007B0D RID: 31501
		// (get) Token: 0x0601EEB5 RID: 126645 RVA: 0x002DF448 File Offset: 0x002DD648
		// (set) Token: 0x0601EEB6 RID: 126646 RVA: 0x002DF48B File Offset: 0x002DD68B
		public FSpriteTransitionOfState CheckedHoverState
		{
			get
			{
				base.FastCheckIsValid();
				FSpriteTransitionOfState result;
				if ((result = this._CheckedHoverState) == null)
				{
					result = (this._CheckedHoverState = new FSpriteTransitionOfState(base.NativePtr + (IntPtr)FExtendToggleSpriteTransitionState.__PropertyOffset_CheckedHoverState, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSpriteTransitionOfState.StaticStruct(), base.NativePtr + (IntPtr)FExtendToggleSpriteTransitionState.__PropertyOffset_CheckedHoverState, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007B0E RID: 31502
		// (get) Token: 0x0601EEB7 RID: 126647 RVA: 0x002DF4AC File Offset: 0x002DD6AC
		// (set) Token: 0x0601EEB8 RID: 126648 RVA: 0x002DF4EF File Offset: 0x002DD6EF
		public FSpriteTransitionOfState CheckedPressedState
		{
			get
			{
				base.FastCheckIsValid();
				FSpriteTransitionOfState result;
				if ((result = this._CheckedPressedState) == null)
				{
					result = (this._CheckedPressedState = new FSpriteTransitionOfState(base.NativePtr + (IntPtr)FExtendToggleSpriteTransitionState.__PropertyOffset_CheckedPressedState, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSpriteTransitionOfState.StaticStruct(), base.NativePtr + (IntPtr)FExtendToggleSpriteTransitionState.__PropertyOffset_CheckedPressedState, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007B0F RID: 31503
		// (get) Token: 0x0601EEB9 RID: 126649 RVA: 0x002DF510 File Offset: 0x002DD710
		// (set) Token: 0x0601EEBA RID: 126650 RVA: 0x002DF553 File Offset: 0x002DD753
		public FSpriteTransitionOfState UnDetermineUnHoverState
		{
			get
			{
				base.FastCheckIsValid();
				FSpriteTransitionOfState result;
				if ((result = this._UnDetermineUnHoverState) == null)
				{
					result = (this._UnDetermineUnHoverState = new FSpriteTransitionOfState(base.NativePtr + (IntPtr)FExtendToggleSpriteTransitionState.__PropertyOffset_UnDetermineUnHoverState, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSpriteTransitionOfState.StaticStruct(), base.NativePtr + (IntPtr)FExtendToggleSpriteTransitionState.__PropertyOffset_UnDetermineUnHoverState, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007B10 RID: 31504
		// (get) Token: 0x0601EEBB RID: 126651 RVA: 0x002DF574 File Offset: 0x002DD774
		// (set) Token: 0x0601EEBC RID: 126652 RVA: 0x002DF5B7 File Offset: 0x002DD7B7
		public FSpriteTransitionOfState UnDetermineHoverState
		{
			get
			{
				base.FastCheckIsValid();
				FSpriteTransitionOfState result;
				if ((result = this._UnDetermineHoverState) == null)
				{
					result = (this._UnDetermineHoverState = new FSpriteTransitionOfState(base.NativePtr + (IntPtr)FExtendToggleSpriteTransitionState.__PropertyOffset_UnDetermineHoverState, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSpriteTransitionOfState.StaticStruct(), base.NativePtr + (IntPtr)FExtendToggleSpriteTransitionState.__PropertyOffset_UnDetermineHoverState, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007B11 RID: 31505
		// (get) Token: 0x0601EEBD RID: 126653 RVA: 0x002DF5D8 File Offset: 0x002DD7D8
		// (set) Token: 0x0601EEBE RID: 126654 RVA: 0x002DF61B File Offset: 0x002DD81B
		public FSpriteTransitionOfState UnDeterminePressedState
		{
			get
			{
				base.FastCheckIsValid();
				FSpriteTransitionOfState result;
				if ((result = this._UnDeterminePressedState) == null)
				{
					result = (this._UnDeterminePressedState = new FSpriteTransitionOfState(base.NativePtr + (IntPtr)FExtendToggleSpriteTransitionState.__PropertyOffset_UnDeterminePressedState, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSpriteTransitionOfState.StaticStruct(), base.NativePtr + (IntPtr)FExtendToggleSpriteTransitionState.__PropertyOffset_UnDeterminePressedState, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007B12 RID: 31506
		// (get) Token: 0x0601EEBF RID: 126655 RVA: 0x002DF63C File Offset: 0x002DD83C
		// (set) Token: 0x0601EEC0 RID: 126656 RVA: 0x002DF655 File Offset: 0x002DD855
		public unsafe bool bEnableUnDetermined
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FExtendToggleSpriteTransitionState.__PropertyOffset_bEnableUnDetermined) & FExtendToggleSpriteTransitionState.__PropertyMask_bEnableUnDetermined) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FExtendToggleSpriteTransitionState.__PropertyOffset_bEnableUnDetermined) = ((*(base.NativePtr + (IntPtr)FExtendToggleSpriteTransitionState.__PropertyOffset_bEnableUnDetermined) & ~FExtendToggleSpriteTransitionState.__PropertyMask_bEnableUnDetermined) | (value ? FExtendToggleSpriteTransitionState.__PropertyMask_bEnableUnDetermined : 0));
			}
		}

		// Token: 0x17007B13 RID: 31507
		// (get) Token: 0x0601EEC1 RID: 126657 RVA: 0x002DF685 File Offset: 0x002DD885
		// (set) Token: 0x0601EEC2 RID: 126658 RVA: 0x002DF69E File Offset: 0x002DD89E
		public unsafe bool bCustomUnCheckedHover
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FExtendToggleSpriteTransitionState.__PropertyOffset_bCustomUnCheckedHover) & FExtendToggleSpriteTransitionState.__PropertyMask_bCustomUnCheckedHover) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FExtendToggleSpriteTransitionState.__PropertyOffset_bCustomUnCheckedHover) = ((*(base.NativePtr + (IntPtr)FExtendToggleSpriteTransitionState.__PropertyOffset_bCustomUnCheckedHover) & ~FExtendToggleSpriteTransitionState.__PropertyMask_bCustomUnCheckedHover) | (value ? FExtendToggleSpriteTransitionState.__PropertyMask_bCustomUnCheckedHover : 0));
			}
		}

		// Token: 0x17007B14 RID: 31508
		// (get) Token: 0x0601EEC3 RID: 126659 RVA: 0x002DF6CE File Offset: 0x002DD8CE
		// (set) Token: 0x0601EEC4 RID: 126660 RVA: 0x002DF6E7 File Offset: 0x002DD8E7
		public unsafe bool bCustomUnCheckedPressed
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FExtendToggleSpriteTransitionState.__PropertyOffset_bCustomUnCheckedPressed) & FExtendToggleSpriteTransitionState.__PropertyMask_bCustomUnCheckedPressed) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FExtendToggleSpriteTransitionState.__PropertyOffset_bCustomUnCheckedPressed) = ((*(base.NativePtr + (IntPtr)FExtendToggleSpriteTransitionState.__PropertyOffset_bCustomUnCheckedPressed) & ~FExtendToggleSpriteTransitionState.__PropertyMask_bCustomUnCheckedPressed) | (value ? FExtendToggleSpriteTransitionState.__PropertyMask_bCustomUnCheckedPressed : 0));
			}
		}

		// Token: 0x17007B15 RID: 31509
		// (get) Token: 0x0601EEC5 RID: 126661 RVA: 0x002DF717 File Offset: 0x002DD917
		// (set) Token: 0x0601EEC6 RID: 126662 RVA: 0x002DF730 File Offset: 0x002DD930
		public unsafe bool bCustomCheckedHover
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FExtendToggleSpriteTransitionState.__PropertyOffset_bCustomCheckedHover) & FExtendToggleSpriteTransitionState.__PropertyMask_bCustomCheckedHover) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FExtendToggleSpriteTransitionState.__PropertyOffset_bCustomCheckedHover) = ((*(base.NativePtr + (IntPtr)FExtendToggleSpriteTransitionState.__PropertyOffset_bCustomCheckedHover) & ~FExtendToggleSpriteTransitionState.__PropertyMask_bCustomCheckedHover) | (value ? FExtendToggleSpriteTransitionState.__PropertyMask_bCustomCheckedHover : 0));
			}
		}

		// Token: 0x17007B16 RID: 31510
		// (get) Token: 0x0601EEC7 RID: 126663 RVA: 0x002DF760 File Offset: 0x002DD960
		// (set) Token: 0x0601EEC8 RID: 126664 RVA: 0x002DF779 File Offset: 0x002DD979
		public unsafe bool bCustomCheckedPressed
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FExtendToggleSpriteTransitionState.__PropertyOffset_bCustomCheckedPressed) & FExtendToggleSpriteTransitionState.__PropertyMask_bCustomCheckedPressed) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FExtendToggleSpriteTransitionState.__PropertyOffset_bCustomCheckedPressed) = ((*(base.NativePtr + (IntPtr)FExtendToggleSpriteTransitionState.__PropertyOffset_bCustomCheckedPressed) & ~FExtendToggleSpriteTransitionState.__PropertyMask_bCustomCheckedPressed) | (value ? FExtendToggleSpriteTransitionState.__PropertyMask_bCustomCheckedPressed : 0));
			}
		}

		// Token: 0x17007B17 RID: 31511
		// (get) Token: 0x0601EEC9 RID: 126665 RVA: 0x002DF7A9 File Offset: 0x002DD9A9
		// (set) Token: 0x0601EECA RID: 126666 RVA: 0x002DF7C2 File Offset: 0x002DD9C2
		public unsafe bool bCustomUnDeterminedHover
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FExtendToggleSpriteTransitionState.__PropertyOffset_bCustomUnDeterminedHover) & FExtendToggleSpriteTransitionState.__PropertyMask_bCustomUnDeterminedHover) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FExtendToggleSpriteTransitionState.__PropertyOffset_bCustomUnDeterminedHover) = ((*(base.NativePtr + (IntPtr)FExtendToggleSpriteTransitionState.__PropertyOffset_bCustomUnDeterminedHover) & ~FExtendToggleSpriteTransitionState.__PropertyMask_bCustomUnDeterminedHover) | (value ? FExtendToggleSpriteTransitionState.__PropertyMask_bCustomUnDeterminedHover : 0));
			}
		}

		// Token: 0x17007B18 RID: 31512
		// (get) Token: 0x0601EECB RID: 126667 RVA: 0x002DF7F2 File Offset: 0x002DD9F2
		// (set) Token: 0x0601EECC RID: 126668 RVA: 0x002DF80B File Offset: 0x002DDA0B
		public unsafe bool bCustomUnDeterminePressed
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FExtendToggleSpriteTransitionState.__PropertyOffset_bCustomUnDeterminePressed) & FExtendToggleSpriteTransitionState.__PropertyMask_bCustomUnDeterminePressed) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FExtendToggleSpriteTransitionState.__PropertyOffset_bCustomUnDeterminePressed) = ((*(base.NativePtr + (IntPtr)FExtendToggleSpriteTransitionState.__PropertyOffset_bCustomUnDeterminePressed) & ~FExtendToggleSpriteTransitionState.__PropertyMask_bCustomUnDeterminePressed) | (value ? FExtendToggleSpriteTransitionState.__PropertyMask_bCustomUnDeterminePressed : 0));
			}
		}

		// Token: 0x0601EECD RID: 126669 RVA: 0x002DF83B File Offset: 0x002DDA3B
		public FExtendToggleSpriteTransitionState()
		{
		}

		// Token: 0x0601EECE RID: 126670 RVA: 0x002DF844 File Offset: 0x002DDA44
		public FExtendToggleSpriteTransitionState(FSpriteTransitionOfState UnCheckedUnHoverState, FSpriteTransitionOfState UnCheckedHoverState, FSpriteTransitionOfState UnCheckedPressedState, FSpriteTransitionOfState CheckedUnHoverState, FSpriteTransitionOfState CheckedHoverState, FSpriteTransitionOfState CheckedPressedState, FSpriteTransitionOfState UnDetermineUnHoverState, FSpriteTransitionOfState UnDetermineHoverState, FSpriteTransitionOfState UnDeterminePressedState, bool bEnableUnDetermined, bool bCustomUnCheckedHover, bool bCustomUnCheckedPressed, bool bCustomCheckedHover, bool bCustomCheckedPressed, bool bCustomUnDeterminedHover, bool bCustomUnDeterminePressed)
		{
			this.UnCheckedUnHoverState = UnCheckedUnHoverState;
			this.UnCheckedHoverState = UnCheckedHoverState;
			this.UnCheckedPressedState = UnCheckedPressedState;
			this.CheckedUnHoverState = CheckedUnHoverState;
			this.CheckedHoverState = CheckedHoverState;
			this.CheckedPressedState = CheckedPressedState;
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

		// Token: 0x0601EECF RID: 126671 RVA: 0x002DF8D4 File Offset: 0x002DDAD4
		protected override IntPtr GetUStructPtr()
		{
			return FExtendToggleSpriteTransitionState.StaticStruct();
		}

		// Token: 0x0601EED0 RID: 126672 RVA: 0x002DF8E0 File Offset: 0x002DDAE0
		[NullableContext(2)]
		public FExtendToggleSpriteTransitionState(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601EED1 RID: 126673 RVA: 0x002DF8EA File Offset: 0x002DDAEA
		public FExtendToggleSpriteTransitionState(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601EED2 RID: 126674 RVA: 0x002DF8F5 File Offset: 0x002DDAF5
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FExtendToggleSpriteTransitionState(Pointer, false, true);
		}

		// Token: 0x0601EED3 RID: 126675 RVA: 0x002DF8FF File Offset: 0x002DDAFF
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FExtendToggleSpriteTransitionState(Pointer, MemoryOwner);
		}

		// Token: 0x04010CD2 RID: 68818
		public const string __ObjectPath = "/Script/LGUI.ExtendToggleSpriteTransitionState";

		// Token: 0x04010CD3 RID: 68819
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010CD4 RID: 68820
		internal static int __PropertyOffset_UnCheckedUnHoverState;

		// Token: 0x04010CD5 RID: 68821
		[Nullable(2)]
		private FSpriteTransitionOfState _UnCheckedUnHoverState;

		// Token: 0x04010CD6 RID: 68822
		internal static int __PropertyOffset_UnCheckedHoverState;

		// Token: 0x04010CD7 RID: 68823
		[Nullable(2)]
		private FSpriteTransitionOfState _UnCheckedHoverState;

		// Token: 0x04010CD8 RID: 68824
		internal static int __PropertyOffset_UnCheckedPressedState;

		// Token: 0x04010CD9 RID: 68825
		[Nullable(2)]
		private FSpriteTransitionOfState _UnCheckedPressedState;

		// Token: 0x04010CDA RID: 68826
		internal static int __PropertyOffset_CheckedUnHoverState;

		// Token: 0x04010CDB RID: 68827
		[Nullable(2)]
		private FSpriteTransitionOfState _CheckedUnHoverState;

		// Token: 0x04010CDC RID: 68828
		internal static int __PropertyOffset_CheckedHoverState;

		// Token: 0x04010CDD RID: 68829
		[Nullable(2)]
		private FSpriteTransitionOfState _CheckedHoverState;

		// Token: 0x04010CDE RID: 68830
		internal static int __PropertyOffset_CheckedPressedState;

		// Token: 0x04010CDF RID: 68831
		[Nullable(2)]
		private FSpriteTransitionOfState _CheckedPressedState;

		// Token: 0x04010CE0 RID: 68832
		internal static int __PropertyOffset_UnDetermineUnHoverState;

		// Token: 0x04010CE1 RID: 68833
		[Nullable(2)]
		private FSpriteTransitionOfState _UnDetermineUnHoverState;

		// Token: 0x04010CE2 RID: 68834
		internal static int __PropertyOffset_UnDetermineHoverState;

		// Token: 0x04010CE3 RID: 68835
		[Nullable(2)]
		private FSpriteTransitionOfState _UnDetermineHoverState;

		// Token: 0x04010CE4 RID: 68836
		internal static int __PropertyOffset_UnDeterminePressedState;

		// Token: 0x04010CE5 RID: 68837
		[Nullable(2)]
		private FSpriteTransitionOfState _UnDeterminePressedState;

		// Token: 0x04010CE6 RID: 68838
		internal static int __PropertyOffset_bEnableUnDetermined;

		// Token: 0x04010CE7 RID: 68839
		internal static byte __PropertyMask_bEnableUnDetermined;

		// Token: 0x04010CE8 RID: 68840
		internal static int __PropertyOffset_bCustomUnCheckedHover;

		// Token: 0x04010CE9 RID: 68841
		internal static byte __PropertyMask_bCustomUnCheckedHover;

		// Token: 0x04010CEA RID: 68842
		internal static int __PropertyOffset_bCustomUnCheckedPressed;

		// Token: 0x04010CEB RID: 68843
		internal static byte __PropertyMask_bCustomUnCheckedPressed;

		// Token: 0x04010CEC RID: 68844
		internal static int __PropertyOffset_bCustomCheckedHover;

		// Token: 0x04010CED RID: 68845
		internal static byte __PropertyMask_bCustomCheckedHover;

		// Token: 0x04010CEE RID: 68846
		internal static int __PropertyOffset_bCustomCheckedPressed;

		// Token: 0x04010CEF RID: 68847
		internal static byte __PropertyMask_bCustomCheckedPressed;

		// Token: 0x04010CF0 RID: 68848
		internal static int __PropertyOffset_bCustomUnDeterminedHover;

		// Token: 0x04010CF1 RID: 68849
		internal static byte __PropertyMask_bCustomUnDeterminedHover;

		// Token: 0x04010CF2 RID: 68850
		internal static int __PropertyOffset_bCustomUnDeterminePressed;

		// Token: 0x04010CF3 RID: 68851
		internal static byte __PropertyMask_bCustomUnDeterminePressed;
	}
}
