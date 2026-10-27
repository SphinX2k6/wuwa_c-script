using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000417 RID: 1047
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AutomationMessages.AutomationWorkerImageComparisonResults")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FAutomationWorkerImageComparisonResults : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600385E RID: 14430 RVA: 0x00055C94 File Offset: 0x00053E94
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAutomationWorkerImageComparisonResults._ScriptStructPtr != 0) ? FAutomationWorkerImageComparisonResults._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AutomationMessages.AutomationWorkerImageComparisonResults", ref FAutomationWorkerImageComparisonResults._ScriptStructPtr);
		}

		// Token: 0x17000D5A RID: 3418
		// (get) Token: 0x0600385F RID: 14431 RVA: 0x00055CB8 File Offset: 0x00053EB8
		// (set) Token: 0x06003860 RID: 14432 RVA: 0x00055CCC File Offset: 0x00053ECC
		public unsafe FGuid UniqueId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAutomationWorkerImageComparisonResults.__PropertyOffset_UniqueId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAutomationWorkerImageComparisonResults.__PropertyOffset_UniqueId) = value;
			}
		}

		// Token: 0x17000D5B RID: 3419
		// (get) Token: 0x06003861 RID: 14433 RVA: 0x00055CE1 File Offset: 0x00053EE1
		// (set) Token: 0x06003862 RID: 14434 RVA: 0x00055CF1 File Offset: 0x00053EF1
		public unsafe bool bNew
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAutomationWorkerImageComparisonResults.__PropertyOffset_bNew) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAutomationWorkerImageComparisonResults.__PropertyOffset_bNew) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000D5C RID: 3420
		// (get) Token: 0x06003863 RID: 14435 RVA: 0x00055D02 File Offset: 0x00053F02
		// (set) Token: 0x06003864 RID: 14436 RVA: 0x00055D12 File Offset: 0x00053F12
		public unsafe bool bSimilar
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAutomationWorkerImageComparisonResults.__PropertyOffset_bSimilar) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAutomationWorkerImageComparisonResults.__PropertyOffset_bSimilar) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000D5D RID: 3421
		// (get) Token: 0x06003865 RID: 14437 RVA: 0x00055D23 File Offset: 0x00053F23
		// (set) Token: 0x06003866 RID: 14438 RVA: 0x00055D33 File Offset: 0x00053F33
		public unsafe double MaxLocalDifference
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAutomationWorkerImageComparisonResults.__PropertyOffset_MaxLocalDifference);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAutomationWorkerImageComparisonResults.__PropertyOffset_MaxLocalDifference) = value;
			}
		}

		// Token: 0x17000D5E RID: 3422
		// (get) Token: 0x06003867 RID: 14439 RVA: 0x00055D44 File Offset: 0x00053F44
		// (set) Token: 0x06003868 RID: 14440 RVA: 0x00055D54 File Offset: 0x00053F54
		public unsafe double GlobalDifference
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAutomationWorkerImageComparisonResults.__PropertyOffset_GlobalDifference);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAutomationWorkerImageComparisonResults.__PropertyOffset_GlobalDifference) = value;
			}
		}

		// Token: 0x17000D5F RID: 3423
		// (get) Token: 0x06003869 RID: 14441 RVA: 0x00055D65 File Offset: 0x00053F65
		// (set) Token: 0x0600386A RID: 14442 RVA: 0x00055D79 File Offset: 0x00053F79
		public unsafe string ErrorMessage
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FAutomationWorkerImageComparisonResults.__PropertyOffset_ErrorMessage)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FAutomationWorkerImageComparisonResults.__PropertyOffset_ErrorMessage)), value);
			}
		}

		// Token: 0x0600386B RID: 14443 RVA: 0x00055D8E File Offset: 0x00053F8E
		public FAutomationWorkerImageComparisonResults()
		{
		}

		// Token: 0x0600386C RID: 14444 RVA: 0x00055D96 File Offset: 0x00053F96
		public FAutomationWorkerImageComparisonResults(FGuid UniqueId, bool bNew, bool bSimilar, double MaxLocalDifference, double GlobalDifference, string ErrorMessage)
		{
			this.UniqueId = UniqueId;
			this.bNew = bNew;
			this.bSimilar = bSimilar;
			this.MaxLocalDifference = MaxLocalDifference;
			this.GlobalDifference = GlobalDifference;
			this.ErrorMessage = ErrorMessage;
		}

		// Token: 0x0600386D RID: 14445 RVA: 0x00055DCB File Offset: 0x00053FCB
		protected override IntPtr GetUStructPtr()
		{
			return FAutomationWorkerImageComparisonResults.StaticStruct();
		}

		// Token: 0x0600386E RID: 14446 RVA: 0x00055DD7 File Offset: 0x00053FD7
		[NullableContext(2)]
		public FAutomationWorkerImageComparisonResults(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600386F RID: 14447 RVA: 0x00055DE1 File Offset: 0x00053FE1
		public FAutomationWorkerImageComparisonResults(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06003870 RID: 14448 RVA: 0x00055DEC File Offset: 0x00053FEC
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAutomationWorkerImageComparisonResults(Pointer, false, true);
		}

		// Token: 0x06003871 RID: 14449 RVA: 0x00055DF6 File Offset: 0x00053FF6
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAutomationWorkerImageComparisonResults(Pointer, MemoryOwner);
		}

		// Token: 0x0400199B RID: 6555
		public const string __ObjectPath = "/Script/AutomationMessages.AutomationWorkerImageComparisonResults";

		// Token: 0x0400199C RID: 6556
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400199D RID: 6557
		internal static int __PropertyOffset_UniqueId;

		// Token: 0x0400199E RID: 6558
		internal static int __PropertyOffset_bNew;

		// Token: 0x0400199F RID: 6559
		internal static int __PropertyOffset_bSimilar;

		// Token: 0x040019A0 RID: 6560
		internal static int __PropertyOffset_MaxLocalDifference;

		// Token: 0x040019A1 RID: 6561
		internal static int __PropertyOffset_GlobalDifference;

		// Token: 0x040019A2 RID: 6562
		internal static int __PropertyOffset_ErrorMessage;
	}
}
