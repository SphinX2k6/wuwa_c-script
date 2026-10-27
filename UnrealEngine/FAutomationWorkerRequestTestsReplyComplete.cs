using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200041F RID: 1055
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AutomationMessages.AutomationWorkerRequestTestsReplyComplete")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FAutomationWorkerRequestTestsReplyComplete : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060038B3 RID: 14515 RVA: 0x00056311 File Offset: 0x00054511
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAutomationWorkerRequestTestsReplyComplete._ScriptStructPtr != 0) ? FAutomationWorkerRequestTestsReplyComplete._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AutomationMessages.AutomationWorkerRequestTestsReplyComplete", ref FAutomationWorkerRequestTestsReplyComplete._ScriptStructPtr);
		}

		// Token: 0x17000D69 RID: 3433
		// (get) Token: 0x060038B4 RID: 14516 RVA: 0x00056338 File Offset: 0x00054538
		// (set) Token: 0x060038B5 RID: 14517 RVA: 0x0005637B File Offset: 0x0005457B
		public TArray<FAutomationWorkerSingleTestReply> Tests
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FAutomationWorkerSingleTestReply> result;
				if ((result = this._Tests) == null)
				{
					result = (this._Tests = new TArray<FAutomationWorkerSingleTestReply>(base.NativePtr + (IntPtr)FAutomationWorkerRequestTestsReplyComplete.__PropertyOffset_Tests, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Tests.CopyAssign(value);
			}
		}

		// Token: 0x060038B6 RID: 14518 RVA: 0x00056389 File Offset: 0x00054589
		public FAutomationWorkerRequestTestsReplyComplete()
		{
		}

		// Token: 0x060038B7 RID: 14519 RVA: 0x00056391 File Offset: 0x00054591
		public FAutomationWorkerRequestTestsReplyComplete(TArray<FAutomationWorkerSingleTestReply> Tests)
		{
			this.Tests = Tests;
		}

		// Token: 0x060038B8 RID: 14520 RVA: 0x000563A0 File Offset: 0x000545A0
		protected override IntPtr GetUStructPtr()
		{
			return FAutomationWorkerRequestTestsReplyComplete.StaticStruct();
		}

		// Token: 0x060038B9 RID: 14521 RVA: 0x000563AC File Offset: 0x000545AC
		[NullableContext(2)]
		public FAutomationWorkerRequestTestsReplyComplete(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060038BA RID: 14522 RVA: 0x000563B6 File Offset: 0x000545B6
		public FAutomationWorkerRequestTestsReplyComplete(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060038BB RID: 14523 RVA: 0x000563C1 File Offset: 0x000545C1
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAutomationWorkerRequestTestsReplyComplete(Pointer, false, true);
		}

		// Token: 0x060038BC RID: 14524 RVA: 0x000563CB File Offset: 0x000545CB
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAutomationWorkerRequestTestsReplyComplete(Pointer, MemoryOwner);
		}

		// Token: 0x040019BB RID: 6587
		public const string __ObjectPath = "/Script/AutomationMessages.AutomationWorkerRequestTestsReplyComplete";

		// Token: 0x040019BC RID: 6588
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040019BD RID: 6589
		internal static int __PropertyOffset_Tests;

		// Token: 0x040019BE RID: 6590
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FAutomationWorkerSingleTestReply> _Tests;
	}
}
