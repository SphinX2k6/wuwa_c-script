using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001855 RID: 6229
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameBudget.CustomPlayerRangeEventState")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 88)]
	public class FCustomPlayerRangeEventState : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06016F16 RID: 93974 RVA: 0x002179C6 File Offset: 0x00215BC6
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCustomPlayerRangeEventState._ScriptStructPtr != 0) ? FCustomPlayerRangeEventState._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroGameBudget.CustomPlayerRangeEventState", ref FCustomPlayerRangeEventState._ScriptStructPtr);
		}

		// Token: 0x17005C77 RID: 23671
		// (get) Token: 0x06016F17 RID: 93975 RVA: 0x002179EC File Offset: 0x00215BEC
		// (set) Token: 0x06016F18 RID: 93976 RVA: 0x00217A2F File Offset: 0x00215C2F
		public FCustomPlayerRangeEnterEvent OnEnterEvent
		{
			get
			{
				base.FastCheckIsValid();
				FCustomPlayerRangeEnterEvent result;
				if ((result = this._OnEnterEvent) == null)
				{
					result = (this._OnEnterEvent = new FCustomPlayerRangeEnterEvent(base.NativePtr + (IntPtr)FCustomPlayerRangeEventState.__PropertyOffset_OnEnterEvent, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)FCustomPlayerRangeEventState.__PropertyOffset_OnEnterEvent, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17005C78 RID: 23672
		// (get) Token: 0x06016F19 RID: 93977 RVA: 0x00217A50 File Offset: 0x00215C50
		// (set) Token: 0x06016F1A RID: 93978 RVA: 0x00217A93 File Offset: 0x00215C93
		public FCustomPlayerRangeLeaveEvent OnLeaveEvent
		{
			get
			{
				base.FastCheckIsValid();
				FCustomPlayerRangeLeaveEvent result;
				if ((result = this._OnLeaveEvent) == null)
				{
					result = (this._OnLeaveEvent = new FCustomPlayerRangeLeaveEvent(base.NativePtr + (IntPtr)FCustomPlayerRangeEventState.__PropertyOffset_OnLeaveEvent, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)FCustomPlayerRangeEventState.__PropertyOffset_OnLeaveEvent, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x06016F1B RID: 93979 RVA: 0x00217AB4 File Offset: 0x00215CB4
		public FCustomPlayerRangeEventState()
		{
		}

		// Token: 0x06016F1C RID: 93980 RVA: 0x00217ABC File Offset: 0x00215CBC
		public FCustomPlayerRangeEventState(FCustomPlayerRangeEnterEvent OnEnterEvent, FCustomPlayerRangeLeaveEvent OnLeaveEvent)
		{
			this.OnEnterEvent = OnEnterEvent;
			this.OnLeaveEvent = OnLeaveEvent;
		}

		// Token: 0x06016F1D RID: 93981 RVA: 0x00217AD2 File Offset: 0x00215CD2
		protected override IntPtr GetUStructPtr()
		{
			return FCustomPlayerRangeEventState.StaticStruct();
		}

		// Token: 0x06016F1E RID: 93982 RVA: 0x00217ADE File Offset: 0x00215CDE
		[NullableContext(2)]
		public FCustomPlayerRangeEventState(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06016F1F RID: 93983 RVA: 0x00217AE8 File Offset: 0x00215CE8
		public FCustomPlayerRangeEventState(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06016F20 RID: 93984 RVA: 0x00217AF3 File Offset: 0x00215CF3
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCustomPlayerRangeEventState(Pointer, false, true);
		}

		// Token: 0x06016F21 RID: 93985 RVA: 0x00217AFD File Offset: 0x00215CFD
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCustomPlayerRangeEventState(Pointer, MemoryOwner);
		}

		// Token: 0x0400C765 RID: 51045
		public const string __ObjectPath = "/Script/KuroGameBudget.CustomPlayerRangeEventState";

		// Token: 0x0400C766 RID: 51046
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400C767 RID: 51047
		internal static int __PropertyOffset_OnEnterEvent;

		// Token: 0x0400C768 RID: 51048
		[Nullable(2)]
		private FCustomPlayerRangeEnterEvent _OnEnterEvent;

		// Token: 0x0400C769 RID: 51049
		internal static int __PropertyOffset_OnLeaveEvent;

		// Token: 0x0400C76A RID: 51050
		[Nullable(2)]
		private FCustomPlayerRangeLeaveEvent _OnLeaveEvent;
	}
}
