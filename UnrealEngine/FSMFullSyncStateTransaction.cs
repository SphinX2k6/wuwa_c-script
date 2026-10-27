using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002884 RID: 10372
	[UnrealObjectPath("/Script/SMSystem.SMFullSyncStateTransaction")]
	[UnrealStructLayout(24, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FSMFullSyncStateTransaction : FSMTransaction_Base, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06026635 RID: 157237 RVA: 0x003A583E File Offset: 0x003A3A3E
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSMFullSyncStateTransaction._ScriptStructPtr != 0) ? FSMFullSyncStateTransaction._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SMSystem.SMFullSyncStateTransaction", ref FSMFullSyncStateTransaction._ScriptStructPtr);
		}

		// Token: 0x1700940A RID: 37898
		// (get) Token: 0x06026636 RID: 157238 RVA: 0x003A5862 File Offset: 0x003A3A62
		// (set) Token: 0x06026637 RID: 157239 RVA: 0x003A5876 File Offset: 0x003A3A76
		public unsafe FGuid BaseGuid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSMFullSyncStateTransaction.__PropertyOffset_BaseGuid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSMFullSyncStateTransaction.__PropertyOffset_BaseGuid) = value;
			}
		}

		// Token: 0x1700940B RID: 37899
		// (get) Token: 0x06026638 RID: 157240 RVA: 0x003A588B File Offset: 0x003A3A8B
		// (set) Token: 0x06026639 RID: 157241 RVA: 0x003A589B File Offset: 0x003A3A9B
		public unsafe float TimeInState
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSMFullSyncStateTransaction.__PropertyOffset_TimeInState);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSMFullSyncStateTransaction.__PropertyOffset_TimeInState) = value;
			}
		}

		// Token: 0x0602663A RID: 157242 RVA: 0x003A58AC File Offset: 0x003A3AAC
		public FSMFullSyncStateTransaction()
		{
		}

		// Token: 0x0602663B RID: 157243 RVA: 0x003A58B4 File Offset: 0x003A3AB4
		public FSMFullSyncStateTransaction(FGuid BaseGuid, float TimeInState, ESMTransactionType TransactionType, bool bOriginatedFromServer)
		{
			this.BaseGuid = BaseGuid;
			this.TimeInState = TimeInState;
			base.TransactionType = TransactionType;
			base.bOriginatedFromServer = bOriginatedFromServer;
		}

		// Token: 0x0602663C RID: 157244 RVA: 0x003A58D9 File Offset: 0x003A3AD9
		protected override IntPtr GetUStructPtr()
		{
			return FSMFullSyncStateTransaction.StaticStruct();
		}

		// Token: 0x0602663D RID: 157245 RVA: 0x003A58E5 File Offset: 0x003A3AE5
		[NullableContext(2)]
		public FSMFullSyncStateTransaction(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602663E RID: 157246 RVA: 0x003A58EF File Offset: 0x003A3AEF
		public FSMFullSyncStateTransaction(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602663F RID: 157247 RVA: 0x003A58FA File Offset: 0x003A3AFA
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSMFullSyncStateTransaction(Pointer, false, true);
		}

		// Token: 0x06026640 RID: 157248 RVA: 0x003A5904 File Offset: 0x003A3B04
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSMFullSyncStateTransaction(Pointer, MemoryOwner);
		}

		// Token: 0x040150DB RID: 86235
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/SMSystem.SMFullSyncStateTransaction";

		// Token: 0x040150DC RID: 86236
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040150DD RID: 86237
		internal static int __PropertyOffset_BaseGuid;

		// Token: 0x040150DE RID: 86238
		internal static int __PropertyOffset_TimeInState;
	}
}
