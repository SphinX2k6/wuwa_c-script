using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000415 RID: 1045
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AutomationMessages.AutomationWorkerFindWorkers")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FAutomationWorkerFindWorkers : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06003832 RID: 14386 RVA: 0x00055920 File Offset: 0x00053B20
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAutomationWorkerFindWorkers._ScriptStructPtr != 0) ? FAutomationWorkerFindWorkers._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AutomationMessages.AutomationWorkerFindWorkers", ref FAutomationWorkerFindWorkers._ScriptStructPtr);
		}

		// Token: 0x17000D4C RID: 3404
		// (get) Token: 0x06003833 RID: 14387 RVA: 0x00055944 File Offset: 0x00053B44
		// (set) Token: 0x06003834 RID: 14388 RVA: 0x00055954 File Offset: 0x00053B54
		public unsafe int Changelist
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAutomationWorkerFindWorkers.__PropertyOffset_Changelist);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAutomationWorkerFindWorkers.__PropertyOffset_Changelist) = value;
			}
		}

		// Token: 0x17000D4D RID: 3405
		// (get) Token: 0x06003835 RID: 14389 RVA: 0x00055965 File Offset: 0x00053B65
		// (set) Token: 0x06003836 RID: 14390 RVA: 0x00055979 File Offset: 0x00053B79
		public unsafe string GameName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FAutomationWorkerFindWorkers.__PropertyOffset_GameName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FAutomationWorkerFindWorkers.__PropertyOffset_GameName)), value);
			}
		}

		// Token: 0x17000D4E RID: 3406
		// (get) Token: 0x06003837 RID: 14391 RVA: 0x0005598E File Offset: 0x00053B8E
		// (set) Token: 0x06003838 RID: 14392 RVA: 0x000559A2 File Offset: 0x00053BA2
		public unsafe string ProcessName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FAutomationWorkerFindWorkers.__PropertyOffset_ProcessName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FAutomationWorkerFindWorkers.__PropertyOffset_ProcessName)), value);
			}
		}

		// Token: 0x17000D4F RID: 3407
		// (get) Token: 0x06003839 RID: 14393 RVA: 0x000559B7 File Offset: 0x00053BB7
		// (set) Token: 0x0600383A RID: 14394 RVA: 0x000559CB File Offset: 0x00053BCB
		public unsafe FGuid SessionId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAutomationWorkerFindWorkers.__PropertyOffset_SessionId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAutomationWorkerFindWorkers.__PropertyOffset_SessionId) = value;
			}
		}

		// Token: 0x0600383B RID: 14395 RVA: 0x000559E0 File Offset: 0x00053BE0
		public FAutomationWorkerFindWorkers()
		{
		}

		// Token: 0x0600383C RID: 14396 RVA: 0x000559E8 File Offset: 0x00053BE8
		public FAutomationWorkerFindWorkers(int Changelist, string GameName, string ProcessName, FGuid SessionId)
		{
			this.Changelist = Changelist;
			this.GameName = GameName;
			this.ProcessName = ProcessName;
			this.SessionId = SessionId;
		}

		// Token: 0x0600383D RID: 14397 RVA: 0x00055A0D File Offset: 0x00053C0D
		protected override IntPtr GetUStructPtr()
		{
			return FAutomationWorkerFindWorkers.StaticStruct();
		}

		// Token: 0x0600383E RID: 14398 RVA: 0x00055A19 File Offset: 0x00053C19
		[NullableContext(2)]
		public FAutomationWorkerFindWorkers(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600383F RID: 14399 RVA: 0x00055A23 File Offset: 0x00053C23
		public FAutomationWorkerFindWorkers(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06003840 RID: 14400 RVA: 0x00055A2E File Offset: 0x00053C2E
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAutomationWorkerFindWorkers(Pointer, false, true);
		}

		// Token: 0x06003841 RID: 14401 RVA: 0x00055A38 File Offset: 0x00053C38
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAutomationWorkerFindWorkers(Pointer, MemoryOwner);
		}

		// Token: 0x04001989 RID: 6537
		public const string __ObjectPath = "/Script/AutomationMessages.AutomationWorkerFindWorkers";

		// Token: 0x0400198A RID: 6538
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400198B RID: 6539
		internal static int __PropertyOffset_Changelist;

		// Token: 0x0400198C RID: 6540
		internal static int __PropertyOffset_GameName;

		// Token: 0x0400198D RID: 6541
		internal static int __PropertyOffset_ProcessName;

		// Token: 0x0400198E RID: 6542
		internal static int __PropertyOffset_SessionId;
	}
}
