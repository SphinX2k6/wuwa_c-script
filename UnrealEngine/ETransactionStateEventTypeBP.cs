using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200181D RID: 6173
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroEditorCommon.ETransactionStateEventTypeBP")]
	public enum ETransactionStateEventTypeBP : byte
	{
		// Token: 0x0400C631 RID: 50737
		TransactionStarted,
		// Token: 0x0400C632 RID: 50738
		TransactionCanceled,
		// Token: 0x0400C633 RID: 50739
		TransactionFinalized,
		// Token: 0x0400C634 RID: 50740
		UndoRedoStarted,
		// Token: 0x0400C635 RID: 50741
		UndoRedoFinalized,
		// Token: 0x0400C636 RID: 50742
		Unknown = 100,
		// Token: 0x0400C637 RID: 50743
		ETransactionStateEventTypeBP_MAX
	}
}
