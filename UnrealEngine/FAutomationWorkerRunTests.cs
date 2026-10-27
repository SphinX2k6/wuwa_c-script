using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000421 RID: 1057
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AutomationMessages.AutomationWorkerRunTests")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FAutomationWorkerRunTests : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060038C2 RID: 14530 RVA: 0x00056465 File Offset: 0x00054665
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAutomationWorkerRunTests._ScriptStructPtr != 0) ? FAutomationWorkerRunTests._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AutomationMessages.AutomationWorkerRunTests", ref FAutomationWorkerRunTests._ScriptStructPtr);
		}

		// Token: 0x17000D6A RID: 3434
		// (get) Token: 0x060038C3 RID: 14531 RVA: 0x00056489 File Offset: 0x00054689
		// (set) Token: 0x060038C4 RID: 14532 RVA: 0x00056499 File Offset: 0x00054699
		public unsafe uint ExecutionCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAutomationWorkerRunTests.__PropertyOffset_ExecutionCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAutomationWorkerRunTests.__PropertyOffset_ExecutionCount) = (int)value;
			}
		}

		// Token: 0x17000D6B RID: 3435
		// (get) Token: 0x060038C5 RID: 14533 RVA: 0x000564AA File Offset: 0x000546AA
		// (set) Token: 0x060038C6 RID: 14534 RVA: 0x000564BA File Offset: 0x000546BA
		public unsafe int RoleIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAutomationWorkerRunTests.__PropertyOffset_RoleIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAutomationWorkerRunTests.__PropertyOffset_RoleIndex) = value;
			}
		}

		// Token: 0x17000D6C RID: 3436
		// (get) Token: 0x060038C7 RID: 14535 RVA: 0x000564CB File Offset: 0x000546CB
		// (set) Token: 0x060038C8 RID: 14536 RVA: 0x000564DF File Offset: 0x000546DF
		public unsafe string TestName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FAutomationWorkerRunTests.__PropertyOffset_TestName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FAutomationWorkerRunTests.__PropertyOffset_TestName)), value);
			}
		}

		// Token: 0x17000D6D RID: 3437
		// (get) Token: 0x060038C9 RID: 14537 RVA: 0x000564F4 File Offset: 0x000546F4
		// (set) Token: 0x060038CA RID: 14538 RVA: 0x00056508 File Offset: 0x00054708
		public unsafe string BeautifiedTestName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FAutomationWorkerRunTests.__PropertyOffset_BeautifiedTestName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FAutomationWorkerRunTests.__PropertyOffset_BeautifiedTestName)), value);
			}
		}

		// Token: 0x17000D6E RID: 3438
		// (get) Token: 0x060038CB RID: 14539 RVA: 0x0005651D File Offset: 0x0005471D
		// (set) Token: 0x060038CC RID: 14540 RVA: 0x0005652D File Offset: 0x0005472D
		public unsafe bool bSendAnalytics
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAutomationWorkerRunTests.__PropertyOffset_bSendAnalytics) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAutomationWorkerRunTests.__PropertyOffset_bSendAnalytics) = (value ? 1 : 0);
			}
		}

		// Token: 0x060038CD RID: 14541 RVA: 0x0005653E File Offset: 0x0005473E
		public FAutomationWorkerRunTests()
		{
		}

		// Token: 0x060038CE RID: 14542 RVA: 0x00056546 File Offset: 0x00054746
		public FAutomationWorkerRunTests(uint ExecutionCount, int RoleIndex, string TestName, string BeautifiedTestName, bool bSendAnalytics)
		{
			this.ExecutionCount = ExecutionCount;
			this.RoleIndex = RoleIndex;
			this.TestName = TestName;
			this.BeautifiedTestName = BeautifiedTestName;
			this.bSendAnalytics = bSendAnalytics;
		}

		// Token: 0x060038CF RID: 14543 RVA: 0x00056573 File Offset: 0x00054773
		protected override IntPtr GetUStructPtr()
		{
			return FAutomationWorkerRunTests.StaticStruct();
		}

		// Token: 0x060038D0 RID: 14544 RVA: 0x0005657F File Offset: 0x0005477F
		[NullableContext(2)]
		public FAutomationWorkerRunTests(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060038D1 RID: 14545 RVA: 0x00056589 File Offset: 0x00054789
		public FAutomationWorkerRunTests(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060038D2 RID: 14546 RVA: 0x00056594 File Offset: 0x00054794
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAutomationWorkerRunTests(Pointer, false, true);
		}

		// Token: 0x060038D3 RID: 14547 RVA: 0x0005659E File Offset: 0x0005479E
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAutomationWorkerRunTests(Pointer, MemoryOwner);
		}

		// Token: 0x040019C1 RID: 6593
		public const string __ObjectPath = "/Script/AutomationMessages.AutomationWorkerRunTests";

		// Token: 0x040019C2 RID: 6594
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040019C3 RID: 6595
		internal static int __PropertyOffset_ExecutionCount;

		// Token: 0x040019C4 RID: 6596
		internal static int __PropertyOffset_RoleIndex;

		// Token: 0x040019C5 RID: 6597
		internal static int __PropertyOffset_TestName;

		// Token: 0x040019C6 RID: 6598
		internal static int __PropertyOffset_BeautifiedTestName;

		// Token: 0x040019C7 RID: 6599
		internal static int __PropertyOffset_bSendAnalytics;
	}
}
