using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000422 RID: 1058
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AutomationMessages.AutomationWorkerRunTestsReply")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FAutomationWorkerRunTestsReply : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060038D4 RID: 14548 RVA: 0x000565A7 File Offset: 0x000547A7
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAutomationWorkerRunTestsReply._ScriptStructPtr != 0) ? FAutomationWorkerRunTestsReply._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AutomationMessages.AutomationWorkerRunTestsReply", ref FAutomationWorkerRunTestsReply._ScriptStructPtr);
		}

		// Token: 0x17000D6F RID: 3439
		// (get) Token: 0x060038D5 RID: 14549 RVA: 0x000565CB File Offset: 0x000547CB
		// (set) Token: 0x060038D6 RID: 14550 RVA: 0x000565DF File Offset: 0x000547DF
		public unsafe string TestName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FAutomationWorkerRunTestsReply.__PropertyOffset_TestName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FAutomationWorkerRunTestsReply.__PropertyOffset_TestName)), value);
			}
		}

		// Token: 0x17000D70 RID: 3440
		// (get) Token: 0x060038D7 RID: 14551 RVA: 0x000565F4 File Offset: 0x000547F4
		// (set) Token: 0x060038D8 RID: 14552 RVA: 0x00056637 File Offset: 0x00054837
		public TArray<FAutomationExecutionEntry> Entries
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FAutomationExecutionEntry> result;
				if ((result = this._Entries) == null)
				{
					result = (this._Entries = new TArray<FAutomationExecutionEntry>(base.NativePtr + (IntPtr)FAutomationWorkerRunTestsReply.__PropertyOffset_Entries, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Entries.CopyAssign(value);
			}
		}

		// Token: 0x17000D71 RID: 3441
		// (get) Token: 0x060038D9 RID: 14553 RVA: 0x00056645 File Offset: 0x00054845
		// (set) Token: 0x060038DA RID: 14554 RVA: 0x00056655 File Offset: 0x00054855
		public unsafe int WarningTotal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAutomationWorkerRunTestsReply.__PropertyOffset_WarningTotal);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAutomationWorkerRunTestsReply.__PropertyOffset_WarningTotal) = value;
			}
		}

		// Token: 0x17000D72 RID: 3442
		// (get) Token: 0x060038DB RID: 14555 RVA: 0x00056666 File Offset: 0x00054866
		// (set) Token: 0x060038DC RID: 14556 RVA: 0x00056676 File Offset: 0x00054876
		public unsafe int ErrorTotal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAutomationWorkerRunTestsReply.__PropertyOffset_ErrorTotal);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAutomationWorkerRunTestsReply.__PropertyOffset_ErrorTotal) = value;
			}
		}

		// Token: 0x17000D73 RID: 3443
		// (get) Token: 0x060038DD RID: 14557 RVA: 0x00056687 File Offset: 0x00054887
		// (set) Token: 0x060038DE RID: 14558 RVA: 0x00056697 File Offset: 0x00054897
		public unsafe float Duration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAutomationWorkerRunTestsReply.__PropertyOffset_Duration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAutomationWorkerRunTestsReply.__PropertyOffset_Duration) = value;
			}
		}

		// Token: 0x17000D74 RID: 3444
		// (get) Token: 0x060038DF RID: 14559 RVA: 0x000566A8 File Offset: 0x000548A8
		// (set) Token: 0x060038E0 RID: 14560 RVA: 0x000566B8 File Offset: 0x000548B8
		public unsafe uint ExecutionCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAutomationWorkerRunTestsReply.__PropertyOffset_ExecutionCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAutomationWorkerRunTestsReply.__PropertyOffset_ExecutionCount) = (int)value;
			}
		}

		// Token: 0x17000D75 RID: 3445
		// (get) Token: 0x060038E1 RID: 14561 RVA: 0x000566C9 File Offset: 0x000548C9
		// (set) Token: 0x060038E2 RID: 14562 RVA: 0x000566D9 File Offset: 0x000548D9
		public unsafe bool Success
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAutomationWorkerRunTestsReply.__PropertyOffset_Success) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAutomationWorkerRunTestsReply.__PropertyOffset_Success) = (value ? 1 : 0);
			}
		}

		// Token: 0x060038E3 RID: 14563 RVA: 0x000566EA File Offset: 0x000548EA
		public FAutomationWorkerRunTestsReply()
		{
		}

		// Token: 0x060038E4 RID: 14564 RVA: 0x000566F2 File Offset: 0x000548F2
		public FAutomationWorkerRunTestsReply(string TestName, TArray<FAutomationExecutionEntry> Entries, int WarningTotal, int ErrorTotal, float Duration, uint ExecutionCount, bool Success)
		{
			this.TestName = TestName;
			this.Entries = Entries;
			this.WarningTotal = WarningTotal;
			this.ErrorTotal = ErrorTotal;
			this.Duration = Duration;
			this.ExecutionCount = ExecutionCount;
			this.Success = Success;
		}

		// Token: 0x060038E5 RID: 14565 RVA: 0x0005672F File Offset: 0x0005492F
		protected override IntPtr GetUStructPtr()
		{
			return FAutomationWorkerRunTestsReply.StaticStruct();
		}

		// Token: 0x060038E6 RID: 14566 RVA: 0x0005673B File Offset: 0x0005493B
		[NullableContext(2)]
		public FAutomationWorkerRunTestsReply(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060038E7 RID: 14567 RVA: 0x00056745 File Offset: 0x00054945
		public FAutomationWorkerRunTestsReply(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060038E8 RID: 14568 RVA: 0x00056750 File Offset: 0x00054950
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAutomationWorkerRunTestsReply(Pointer, false, true);
		}

		// Token: 0x060038E9 RID: 14569 RVA: 0x0005675A File Offset: 0x0005495A
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAutomationWorkerRunTestsReply(Pointer, MemoryOwner);
		}

		// Token: 0x040019C8 RID: 6600
		public const string __ObjectPath = "/Script/AutomationMessages.AutomationWorkerRunTestsReply";

		// Token: 0x040019C9 RID: 6601
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040019CA RID: 6602
		internal static int __PropertyOffset_TestName;

		// Token: 0x040019CB RID: 6603
		internal static int __PropertyOffset_Entries;

		// Token: 0x040019CC RID: 6604
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FAutomationExecutionEntry> _Entries;

		// Token: 0x040019CD RID: 6605
		internal static int __PropertyOffset_WarningTotal;

		// Token: 0x040019CE RID: 6606
		internal static int __PropertyOffset_ErrorTotal;

		// Token: 0x040019CF RID: 6607
		internal static int __PropertyOffset_Duration;

		// Token: 0x040019D0 RID: 6608
		internal static int __PropertyOffset_ExecutionCount;

		// Token: 0x040019D1 RID: 6609
		internal static int __PropertyOffset_Success;
	}
}
