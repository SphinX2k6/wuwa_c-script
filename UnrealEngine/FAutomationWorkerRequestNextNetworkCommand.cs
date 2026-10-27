using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200041D RID: 1053
	[UnrealObjectPath("/Script/AutomationMessages.AutomationWorkerRequestNextNetworkCommand")]
	[UnrealStructLayout(4, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 4)]
	public class FAutomationWorkerRequestNextNetworkCommand : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600389D RID: 14493 RVA: 0x000561C9 File Offset: 0x000543C9
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAutomationWorkerRequestNextNetworkCommand._ScriptStructPtr != 0) ? FAutomationWorkerRequestNextNetworkCommand._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AutomationMessages.AutomationWorkerRequestNextNetworkCommand", ref FAutomationWorkerRequestNextNetworkCommand._ScriptStructPtr);
		}

		// Token: 0x17000D66 RID: 3430
		// (get) Token: 0x0600389E RID: 14494 RVA: 0x000561ED File Offset: 0x000543ED
		// (set) Token: 0x0600389F RID: 14495 RVA: 0x000561FD File Offset: 0x000543FD
		public unsafe uint ExecutionCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAutomationWorkerRequestNextNetworkCommand.__PropertyOffset_ExecutionCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAutomationWorkerRequestNextNetworkCommand.__PropertyOffset_ExecutionCount) = (int)value;
			}
		}

		// Token: 0x060038A0 RID: 14496 RVA: 0x0005620E File Offset: 0x0005440E
		public FAutomationWorkerRequestNextNetworkCommand()
		{
		}

		// Token: 0x060038A1 RID: 14497 RVA: 0x00056216 File Offset: 0x00054416
		public FAutomationWorkerRequestNextNetworkCommand(uint ExecutionCount)
		{
			this.ExecutionCount = ExecutionCount;
		}

		// Token: 0x060038A2 RID: 14498 RVA: 0x00056225 File Offset: 0x00054425
		protected override IntPtr GetUStructPtr()
		{
			return FAutomationWorkerRequestNextNetworkCommand.StaticStruct();
		}

		// Token: 0x060038A3 RID: 14499 RVA: 0x00056231 File Offset: 0x00054431
		[NullableContext(2)]
		public FAutomationWorkerRequestNextNetworkCommand(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060038A4 RID: 14500 RVA: 0x0005623B File Offset: 0x0005443B
		public FAutomationWorkerRequestNextNetworkCommand(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060038A5 RID: 14501 RVA: 0x00056246 File Offset: 0x00054446
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAutomationWorkerRequestNextNetworkCommand(Pointer, false, true);
		}

		// Token: 0x060038A6 RID: 14502 RVA: 0x00056250 File Offset: 0x00054450
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAutomationWorkerRequestNextNetworkCommand(Pointer, MemoryOwner);
		}

		// Token: 0x040019B4 RID: 6580
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AutomationMessages.AutomationWorkerRequestNextNetworkCommand";

		// Token: 0x040019B5 RID: 6581
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040019B6 RID: 6582
		internal static int __PropertyOffset_ExecutionCount;
	}
}
