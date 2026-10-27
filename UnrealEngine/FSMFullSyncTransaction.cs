using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002885 RID: 10373
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SMSystem.SMFullSyncTransaction")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FSMFullSyncTransaction : FSMTransaction_Base, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06026641 RID: 157249 RVA: 0x003A590D File Offset: 0x003A3B0D
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSMFullSyncTransaction._ScriptStructPtr != 0) ? FSMFullSyncTransaction._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SMSystem.SMFullSyncTransaction", ref FSMFullSyncTransaction._ScriptStructPtr);
		}

		// Token: 0x1700940C RID: 37900
		// (get) Token: 0x06026642 RID: 157250 RVA: 0x003A5934 File Offset: 0x003A3B34
		// (set) Token: 0x06026643 RID: 157251 RVA: 0x003A5977 File Offset: 0x003A3B77
		public TArray<FSMFullSyncStateTransaction> ActiveStates
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSMFullSyncStateTransaction> result;
				if ((result = this._ActiveStates) == null)
				{
					result = (this._ActiveStates = new TArray<FSMFullSyncStateTransaction>(base.NativePtr + (IntPtr)FSMFullSyncTransaction.__PropertyOffset_ActiveStates, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ActiveStates.CopyAssign(value);
			}
		}

		// Token: 0x1700940D RID: 37901
		// (get) Token: 0x06026644 RID: 157252 RVA: 0x003A5985 File Offset: 0x003A3B85
		// (set) Token: 0x06026645 RID: 157253 RVA: 0x003A599E File Offset: 0x003A3B9E
		public unsafe bool bHasStarted
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSMFullSyncTransaction.__PropertyOffset_bHasStarted) & FSMFullSyncTransaction.__PropertyMask_bHasStarted) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSMFullSyncTransaction.__PropertyOffset_bHasStarted) = ((*(base.NativePtr + (IntPtr)FSMFullSyncTransaction.__PropertyOffset_bHasStarted) & ~FSMFullSyncTransaction.__PropertyMask_bHasStarted) | (value ? FSMFullSyncTransaction.__PropertyMask_bHasStarted : 0));
			}
		}

		// Token: 0x1700940E RID: 37902
		// (get) Token: 0x06026646 RID: 157254 RVA: 0x003A59CE File Offset: 0x003A3BCE
		// (set) Token: 0x06026647 RID: 157255 RVA: 0x003A59E7 File Offset: 0x003A3BE7
		public unsafe bool bFromUserLoad
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSMFullSyncTransaction.__PropertyOffset_bFromUserLoad) & FSMFullSyncTransaction.__PropertyMask_bFromUserLoad) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSMFullSyncTransaction.__PropertyOffset_bFromUserLoad) = ((*(base.NativePtr + (IntPtr)FSMFullSyncTransaction.__PropertyOffset_bFromUserLoad) & ~FSMFullSyncTransaction.__PropertyMask_bFromUserLoad) | (value ? FSMFullSyncTransaction.__PropertyMask_bFromUserLoad : 0));
			}
		}

		// Token: 0x06026648 RID: 157256 RVA: 0x003A5A17 File Offset: 0x003A3C17
		public FSMFullSyncTransaction()
		{
		}

		// Token: 0x06026649 RID: 157257 RVA: 0x003A5A1F File Offset: 0x003A3C1F
		public FSMFullSyncTransaction(TArray<FSMFullSyncStateTransaction> ActiveStates, bool bHasStarted, bool bFromUserLoad, ESMTransactionType TransactionType, bool bOriginatedFromServer)
		{
			this.ActiveStates = ActiveStates;
			this.bHasStarted = bHasStarted;
			this.bFromUserLoad = bFromUserLoad;
			base.TransactionType = TransactionType;
			base.bOriginatedFromServer = bOriginatedFromServer;
		}

		// Token: 0x0602664A RID: 157258 RVA: 0x003A5A4C File Offset: 0x003A3C4C
		protected override IntPtr GetUStructPtr()
		{
			return FSMFullSyncTransaction.StaticStruct();
		}

		// Token: 0x0602664B RID: 157259 RVA: 0x003A5A58 File Offset: 0x003A3C58
		[NullableContext(2)]
		public FSMFullSyncTransaction(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602664C RID: 157260 RVA: 0x003A5A62 File Offset: 0x003A3C62
		public FSMFullSyncTransaction(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602664D RID: 157261 RVA: 0x003A5A6D File Offset: 0x003A3C6D
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSMFullSyncTransaction(Pointer, false, true);
		}

		// Token: 0x0602664E RID: 157262 RVA: 0x003A5A77 File Offset: 0x003A3C77
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSMFullSyncTransaction(Pointer, MemoryOwner);
		}

		// Token: 0x040150DF RID: 86239
		public new const string __ObjectPath = "/Script/SMSystem.SMFullSyncTransaction";

		// Token: 0x040150E0 RID: 86240
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040150E1 RID: 86241
		internal static int __PropertyOffset_ActiveStates;

		// Token: 0x040150E2 RID: 86242
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSMFullSyncStateTransaction> _ActiveStates;

		// Token: 0x040150E3 RID: 86243
		internal static int __PropertyOffset_bHasStarted;

		// Token: 0x040150E4 RID: 86244
		internal static byte __PropertyMask_bHasStarted;

		// Token: 0x040150E5 RID: 86245
		internal static int __PropertyOffset_bFromUserLoad;

		// Token: 0x040150E6 RID: 86246
		internal static byte __PropertyMask_bFromUserLoad;
	}
}
