using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200065F RID: 1631
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.ExtendToggleTextTransitionState")]
	[UnrealStructLayout(368, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 368)]
	public class FExtendToggleTextTransitionState : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06008D8C RID: 36236 RVA: 0x000D515C File Offset: 0x000D335C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FExtendToggleTextTransitionState._ScriptStructPtr != 0) ? FExtendToggleTextTransitionState._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LGUI.ExtendToggleTextTransitionState", ref FExtendToggleTextTransitionState._ScriptStructPtr);
		}

		// Token: 0x17001ACF RID: 6863
		// (get) Token: 0x06008D8D RID: 36237 RVA: 0x000D5180 File Offset: 0x000D3380
		// (set) Token: 0x06008D8E RID: 36238 RVA: 0x000D51C3 File Offset: 0x000D33C3
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

		// Token: 0x17001AD0 RID: 6864
		// (get) Token: 0x06008D8F RID: 36239 RVA: 0x000D51E4 File Offset: 0x000D33E4
		// (set) Token: 0x06008D90 RID: 36240 RVA: 0x000D5227 File Offset: 0x000D3427
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

		// Token: 0x17001AD1 RID: 6865
		// (get) Token: 0x06008D91 RID: 36241 RVA: 0x000D5248 File Offset: 0x000D3448
		// (set) Token: 0x06008D92 RID: 36242 RVA: 0x000D528B File Offset: 0x000D348B
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

		// Token: 0x17001AD2 RID: 6866
		// (get) Token: 0x06008D93 RID: 36243 RVA: 0x000D52AC File Offset: 0x000D34AC
		// (set) Token: 0x06008D94 RID: 36244 RVA: 0x000D52EF File Offset: 0x000D34EF
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

		// Token: 0x17001AD3 RID: 6867
		// (get) Token: 0x06008D95 RID: 36245 RVA: 0x000D5310 File Offset: 0x000D3510
		// (set) Token: 0x06008D96 RID: 36246 RVA: 0x000D5353 File Offset: 0x000D3553
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

		// Token: 0x17001AD4 RID: 6868
		// (get) Token: 0x06008D97 RID: 36247 RVA: 0x000D5374 File Offset: 0x000D3574
		// (set) Token: 0x06008D98 RID: 36248 RVA: 0x000D53B7 File Offset: 0x000D35B7
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

		// Token: 0x17001AD5 RID: 6869
		// (get) Token: 0x06008D99 RID: 36249 RVA: 0x000D53D8 File Offset: 0x000D35D8
		// (set) Token: 0x06008D9A RID: 36250 RVA: 0x000D541B File Offset: 0x000D361B
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

		// Token: 0x17001AD6 RID: 6870
		// (get) Token: 0x06008D9B RID: 36251 RVA: 0x000D543C File Offset: 0x000D363C
		// (set) Token: 0x06008D9C RID: 36252 RVA: 0x000D547F File Offset: 0x000D367F
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

		// Token: 0x17001AD7 RID: 6871
		// (get) Token: 0x06008D9D RID: 36253 RVA: 0x000D54A0 File Offset: 0x000D36A0
		// (set) Token: 0x06008D9E RID: 36254 RVA: 0x000D54E3 File Offset: 0x000D36E3
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

		// Token: 0x06008D9F RID: 36255 RVA: 0x000D5504 File Offset: 0x000D3704
		public FExtendToggleTextTransitionState()
		{
		}

		// Token: 0x06008DA0 RID: 36256 RVA: 0x000D550C File Offset: 0x000D370C
		protected override IntPtr GetUStructPtr()
		{
			return FExtendToggleTextTransitionState.StaticStruct();
		}

		// Token: 0x06008DA1 RID: 36257 RVA: 0x000D5518 File Offset: 0x000D3718
		[NullableContext(2)]
		public FExtendToggleTextTransitionState(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008DA2 RID: 36258 RVA: 0x000D5522 File Offset: 0x000D3722
		public FExtendToggleTextTransitionState(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008DA3 RID: 36259 RVA: 0x000D552D File Offset: 0x000D372D
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FExtendToggleTextTransitionState(Pointer, false, true);
		}

		// Token: 0x06008DA4 RID: 36260 RVA: 0x000D5537 File Offset: 0x000D3737
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FExtendToggleTextTransitionState(Pointer, MemoryOwner);
		}

		// Token: 0x04003E58 RID: 15960
		public const string __ObjectPath = "/Script/LGUI.ExtendToggleTextTransitionState";

		// Token: 0x04003E59 RID: 15961
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003E5A RID: 15962
		internal static int __PropertyOffset_UnCheckUnHoverState;

		// Token: 0x04003E5B RID: 15963
		[Nullable(2)]
		private FTextTransitionInfoOfState _UnCheckUnHoverState;

		// Token: 0x04003E5C RID: 15964
		internal static int __PropertyOffset_UnCheckHoverState;

		// Token: 0x04003E5D RID: 15965
		[Nullable(2)]
		private FTextTransitionInfoOfState _UnCheckHoverState;

		// Token: 0x04003E5E RID: 15966
		internal static int __PropertyOffset_UnCheckPressedState;

		// Token: 0x04003E5F RID: 15967
		[Nullable(2)]
		private FTextTransitionInfoOfState _UnCheckPressedState;

		// Token: 0x04003E60 RID: 15968
		internal static int __PropertyOffset_CheckUnHoverState;

		// Token: 0x04003E61 RID: 15969
		[Nullable(2)]
		private FTextTransitionInfoOfState _CheckUnHoverState;

		// Token: 0x04003E62 RID: 15970
		internal static int __PropertyOffset_CheckHoverState;

		// Token: 0x04003E63 RID: 15971
		[Nullable(2)]
		private FTextTransitionInfoOfState _CheckHoverState;

		// Token: 0x04003E64 RID: 15972
		internal static int __PropertyOffset_CheckPressedState;

		// Token: 0x04003E65 RID: 15973
		[Nullable(2)]
		private FTextTransitionInfoOfState _CheckPressedState;

		// Token: 0x04003E66 RID: 15974
		internal static int __PropertyOffset_UnDetermineUnHoverState;

		// Token: 0x04003E67 RID: 15975
		[Nullable(2)]
		private FTextTransitionInfoOfState _UnDetermineUnHoverState;

		// Token: 0x04003E68 RID: 15976
		internal static int __PropertyOffset_UnDetermineHoverState;

		// Token: 0x04003E69 RID: 15977
		[Nullable(2)]
		private FTextTransitionInfoOfState _UnDetermineHoverState;

		// Token: 0x04003E6A RID: 15978
		internal static int __PropertyOffset_UnDeterminePressedState;

		// Token: 0x04003E6B RID: 15979
		[Nullable(2)]
		private FTextTransitionInfoOfState _UnDeterminePressedState;
	}
}
