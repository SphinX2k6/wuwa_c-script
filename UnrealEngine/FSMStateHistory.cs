using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002892 RID: 10386
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SMSystem.SMStateHistory")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FSMStateHistory : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06026794 RID: 157588 RVA: 0x003A9468 File Offset: 0x003A7668
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSMStateHistory._ScriptStructPtr != 0) ? FSMStateHistory._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SMSystem.SMStateHistory", ref FSMStateHistory._ScriptStructPtr);
		}

		// Token: 0x17009451 RID: 37969
		// (get) Token: 0x06026795 RID: 157589 RVA: 0x003A948C File Offset: 0x003A768C
		// (set) Token: 0x06026796 RID: 157590 RVA: 0x003A94A0 File Offset: 0x003A76A0
		public unsafe FGuid StateGuid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSMStateHistory.__PropertyOffset_StateGuid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSMStateHistory.__PropertyOffset_StateGuid) = value;
			}
		}

		// Token: 0x17009452 RID: 37970
		// (get) Token: 0x06026797 RID: 157591 RVA: 0x003A94B8 File Offset: 0x003A76B8
		// (set) Token: 0x06026798 RID: 157592 RVA: 0x003A94FB File Offset: 0x003A76FB
		public FDateTime StartTime
		{
			get
			{
				base.FastCheckIsValid();
				FDateTime result;
				if ((result = this._StartTime) == null)
				{
					result = (this._StartTime = new FDateTime(base.NativePtr + (IntPtr)FSMStateHistory.__PropertyOffset_StartTime, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FDateTime.StaticStruct(), base.NativePtr + (IntPtr)FSMStateHistory.__PropertyOffset_StartTime, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17009453 RID: 37971
		// (get) Token: 0x06026799 RID: 157593 RVA: 0x003A951C File Offset: 0x003A771C
		// (set) Token: 0x0602679A RID: 157594 RVA: 0x003A952C File Offset: 0x003A772C
		public unsafe float TimeInState
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSMStateHistory.__PropertyOffset_TimeInState);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSMStateHistory.__PropertyOffset_TimeInState) = value;
			}
		}

		// Token: 0x17009454 RID: 37972
		// (get) Token: 0x0602679B RID: 157595 RVA: 0x003A953D File Offset: 0x003A773D
		// (set) Token: 0x0602679C RID: 157596 RVA: 0x003A954D File Offset: 0x003A774D
		public unsafe float ServerTimeInState
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSMStateHistory.__PropertyOffset_ServerTimeInState);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSMStateHistory.__PropertyOffset_ServerTimeInState) = value;
			}
		}

		// Token: 0x0602679D RID: 157597 RVA: 0x003A955E File Offset: 0x003A775E
		public FSMStateHistory()
		{
		}

		// Token: 0x0602679E RID: 157598 RVA: 0x003A9566 File Offset: 0x003A7766
		public FSMStateHistory(FGuid StateGuid, FDateTime StartTime, float TimeInState, float ServerTimeInState)
		{
			this.StateGuid = StateGuid;
			this.StartTime = StartTime;
			this.TimeInState = TimeInState;
			this.ServerTimeInState = ServerTimeInState;
		}

		// Token: 0x0602679F RID: 157599 RVA: 0x003A958B File Offset: 0x003A778B
		protected override IntPtr GetUStructPtr()
		{
			return FSMStateHistory.StaticStruct();
		}

		// Token: 0x060267A0 RID: 157600 RVA: 0x003A9597 File Offset: 0x003A7797
		[NullableContext(2)]
		public FSMStateHistory(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060267A1 RID: 157601 RVA: 0x003A95A1 File Offset: 0x003A77A1
		public FSMStateHistory(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060267A2 RID: 157602 RVA: 0x003A95AC File Offset: 0x003A77AC
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSMStateHistory(Pointer, false, true);
		}

		// Token: 0x060267A3 RID: 157603 RVA: 0x003A95B6 File Offset: 0x003A77B6
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSMStateHistory(Pointer, MemoryOwner);
		}

		// Token: 0x040151D4 RID: 86484
		public const string __ObjectPath = "/Script/SMSystem.SMStateHistory";

		// Token: 0x040151D5 RID: 86485
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040151D6 RID: 86486
		internal static int __PropertyOffset_StateGuid;

		// Token: 0x040151D7 RID: 86487
		internal static int __PropertyOffset_StartTime;

		// Token: 0x040151D8 RID: 86488
		[Nullable(2)]
		private FDateTime _StartTime;

		// Token: 0x040151D9 RID: 86489
		internal static int __PropertyOffset_TimeInState;

		// Token: 0x040151DA RID: 86490
		internal static int __PropertyOffset_ServerTimeInState;
	}
}
