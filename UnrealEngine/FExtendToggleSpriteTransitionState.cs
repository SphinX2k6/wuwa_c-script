using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200065E RID: 1630
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.ExtendToggleSpriteTransitionState")]
	[UnrealStructLayout(440, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 440)]
	public class FExtendToggleSpriteTransitionState : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06008D73 RID: 36211 RVA: 0x000D4D78 File Offset: 0x000D2F78
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FExtendToggleSpriteTransitionState._ScriptStructPtr != 0) ? FExtendToggleSpriteTransitionState._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LGUI.ExtendToggleSpriteTransitionState", ref FExtendToggleSpriteTransitionState._ScriptStructPtr);
		}

		// Token: 0x17001AC6 RID: 6854
		// (get) Token: 0x06008D74 RID: 36212 RVA: 0x000D4D9C File Offset: 0x000D2F9C
		// (set) Token: 0x06008D75 RID: 36213 RVA: 0x000D4DDF File Offset: 0x000D2FDF
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

		// Token: 0x17001AC7 RID: 6855
		// (get) Token: 0x06008D76 RID: 36214 RVA: 0x000D4E00 File Offset: 0x000D3000
		// (set) Token: 0x06008D77 RID: 36215 RVA: 0x000D4E43 File Offset: 0x000D3043
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

		// Token: 0x17001AC8 RID: 6856
		// (get) Token: 0x06008D78 RID: 36216 RVA: 0x000D4E64 File Offset: 0x000D3064
		// (set) Token: 0x06008D79 RID: 36217 RVA: 0x000D4EA7 File Offset: 0x000D30A7
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

		// Token: 0x17001AC9 RID: 6857
		// (get) Token: 0x06008D7A RID: 36218 RVA: 0x000D4EC8 File Offset: 0x000D30C8
		// (set) Token: 0x06008D7B RID: 36219 RVA: 0x000D4F0B File Offset: 0x000D310B
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

		// Token: 0x17001ACA RID: 6858
		// (get) Token: 0x06008D7C RID: 36220 RVA: 0x000D4F2C File Offset: 0x000D312C
		// (set) Token: 0x06008D7D RID: 36221 RVA: 0x000D4F6F File Offset: 0x000D316F
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

		// Token: 0x17001ACB RID: 6859
		// (get) Token: 0x06008D7E RID: 36222 RVA: 0x000D4F90 File Offset: 0x000D3190
		// (set) Token: 0x06008D7F RID: 36223 RVA: 0x000D4FD3 File Offset: 0x000D31D3
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

		// Token: 0x17001ACC RID: 6860
		// (get) Token: 0x06008D80 RID: 36224 RVA: 0x000D4FF4 File Offset: 0x000D31F4
		// (set) Token: 0x06008D81 RID: 36225 RVA: 0x000D5037 File Offset: 0x000D3237
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

		// Token: 0x17001ACD RID: 6861
		// (get) Token: 0x06008D82 RID: 36226 RVA: 0x000D5058 File Offset: 0x000D3258
		// (set) Token: 0x06008D83 RID: 36227 RVA: 0x000D509B File Offset: 0x000D329B
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

		// Token: 0x17001ACE RID: 6862
		// (get) Token: 0x06008D84 RID: 36228 RVA: 0x000D50BC File Offset: 0x000D32BC
		// (set) Token: 0x06008D85 RID: 36229 RVA: 0x000D50FF File Offset: 0x000D32FF
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

		// Token: 0x06008D86 RID: 36230 RVA: 0x000D5120 File Offset: 0x000D3320
		public FExtendToggleSpriteTransitionState()
		{
		}

		// Token: 0x06008D87 RID: 36231 RVA: 0x000D5128 File Offset: 0x000D3328
		protected override IntPtr GetUStructPtr()
		{
			return FExtendToggleSpriteTransitionState.StaticStruct();
		}

		// Token: 0x06008D88 RID: 36232 RVA: 0x000D5134 File Offset: 0x000D3334
		[NullableContext(2)]
		public FExtendToggleSpriteTransitionState(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008D89 RID: 36233 RVA: 0x000D513E File Offset: 0x000D333E
		public FExtendToggleSpriteTransitionState(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008D8A RID: 36234 RVA: 0x000D5149 File Offset: 0x000D3349
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FExtendToggleSpriteTransitionState(Pointer, false, true);
		}

		// Token: 0x06008D8B RID: 36235 RVA: 0x000D5153 File Offset: 0x000D3353
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FExtendToggleSpriteTransitionState(Pointer, MemoryOwner);
		}

		// Token: 0x04003E44 RID: 15940
		public const string __ObjectPath = "/Script/LGUI.ExtendToggleSpriteTransitionState";

		// Token: 0x04003E45 RID: 15941
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003E46 RID: 15942
		internal static int __PropertyOffset_UnCheckedUnHoverState;

		// Token: 0x04003E47 RID: 15943
		[Nullable(2)]
		private FSpriteTransitionOfState _UnCheckedUnHoverState;

		// Token: 0x04003E48 RID: 15944
		internal static int __PropertyOffset_UnCheckedHoverState;

		// Token: 0x04003E49 RID: 15945
		[Nullable(2)]
		private FSpriteTransitionOfState _UnCheckedHoverState;

		// Token: 0x04003E4A RID: 15946
		internal static int __PropertyOffset_UnCheckedPressedState;

		// Token: 0x04003E4B RID: 15947
		[Nullable(2)]
		private FSpriteTransitionOfState _UnCheckedPressedState;

		// Token: 0x04003E4C RID: 15948
		internal static int __PropertyOffset_CheckedUnHoverState;

		// Token: 0x04003E4D RID: 15949
		[Nullable(2)]
		private FSpriteTransitionOfState _CheckedUnHoverState;

		// Token: 0x04003E4E RID: 15950
		internal static int __PropertyOffset_CheckedHoverState;

		// Token: 0x04003E4F RID: 15951
		[Nullable(2)]
		private FSpriteTransitionOfState _CheckedHoverState;

		// Token: 0x04003E50 RID: 15952
		internal static int __PropertyOffset_CheckedPressedState;

		// Token: 0x04003E51 RID: 15953
		[Nullable(2)]
		private FSpriteTransitionOfState _CheckedPressedState;

		// Token: 0x04003E52 RID: 15954
		internal static int __PropertyOffset_UnDetermineUnHoverState;

		// Token: 0x04003E53 RID: 15955
		[Nullable(2)]
		private FSpriteTransitionOfState _UnDetermineUnHoverState;

		// Token: 0x04003E54 RID: 15956
		internal static int __PropertyOffset_UnDetermineHoverState;

		// Token: 0x04003E55 RID: 15957
		[Nullable(2)]
		private FSpriteTransitionOfState _UnDetermineHoverState;

		// Token: 0x04003E56 RID: 15958
		internal static int __PropertyOffset_UnDeterminePressedState;

		// Token: 0x04003E57 RID: 15959
		[Nullable(2)]
		private FSpriteTransitionOfState _UnDeterminePressedState;
	}
}
