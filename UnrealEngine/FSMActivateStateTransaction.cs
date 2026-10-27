using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200287C RID: 10364
	[UnrealObjectPath("/Script/SMSystem.SMActivateStateTransaction")]
	[UnrealStructLayout(28, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 28)]
	public class FSMActivateStateTransaction : FSMTransaction_Base, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060265D9 RID: 157145 RVA: 0x003A4D45 File Offset: 0x003A2F45
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSMActivateStateTransaction._ScriptStructPtr != 0) ? FSMActivateStateTransaction._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SMSystem.SMActivateStateTransaction", ref FSMActivateStateTransaction._ScriptStructPtr);
		}

		// Token: 0x170093F9 RID: 37881
		// (get) Token: 0x060265DA RID: 157146 RVA: 0x003A4D69 File Offset: 0x003A2F69
		// (set) Token: 0x060265DB RID: 157147 RVA: 0x003A4D7D File Offset: 0x003A2F7D
		public unsafe FGuid BaseGuid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSMActivateStateTransaction.__PropertyOffset_BaseGuid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSMActivateStateTransaction.__PropertyOffset_BaseGuid) = value;
			}
		}

		// Token: 0x170093FA RID: 37882
		// (get) Token: 0x060265DC RID: 157148 RVA: 0x003A4D92 File Offset: 0x003A2F92
		// (set) Token: 0x060265DD RID: 157149 RVA: 0x003A4DA2 File Offset: 0x003A2FA2
		public unsafe float TimeInState
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSMActivateStateTransaction.__PropertyOffset_TimeInState);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSMActivateStateTransaction.__PropertyOffset_TimeInState) = value;
			}
		}

		// Token: 0x170093FB RID: 37883
		// (get) Token: 0x060265DE RID: 157150 RVA: 0x003A4DB3 File Offset: 0x003A2FB3
		// (set) Token: 0x060265DF RID: 157151 RVA: 0x003A4DCC File Offset: 0x003A2FCC
		public unsafe bool bIsActive
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSMActivateStateTransaction.__PropertyOffset_bIsActive) & FSMActivateStateTransaction.__PropertyMask_bIsActive) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSMActivateStateTransaction.__PropertyOffset_bIsActive) = ((*(base.NativePtr + (IntPtr)FSMActivateStateTransaction.__PropertyOffset_bIsActive) & ~FSMActivateStateTransaction.__PropertyMask_bIsActive) | (value ? FSMActivateStateTransaction.__PropertyMask_bIsActive : 0));
			}
		}

		// Token: 0x170093FC RID: 37884
		// (get) Token: 0x060265E0 RID: 157152 RVA: 0x003A4DFC File Offset: 0x003A2FFC
		// (set) Token: 0x060265E1 RID: 157153 RVA: 0x003A4E15 File Offset: 0x003A3015
		public unsafe bool bSetAllParents
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSMActivateStateTransaction.__PropertyOffset_bSetAllParents) & FSMActivateStateTransaction.__PropertyMask_bSetAllParents) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSMActivateStateTransaction.__PropertyOffset_bSetAllParents) = ((*(base.NativePtr + (IntPtr)FSMActivateStateTransaction.__PropertyOffset_bSetAllParents) & ~FSMActivateStateTransaction.__PropertyMask_bSetAllParents) | (value ? FSMActivateStateTransaction.__PropertyMask_bSetAllParents : 0));
			}
		}

		// Token: 0x060265E2 RID: 157154 RVA: 0x003A4E45 File Offset: 0x003A3045
		public FSMActivateStateTransaction()
		{
		}

		// Token: 0x060265E3 RID: 157155 RVA: 0x003A4E4D File Offset: 0x003A304D
		public FSMActivateStateTransaction(FGuid BaseGuid, float TimeInState, bool bIsActive, bool bSetAllParents, ESMTransactionType TransactionType, bool bOriginatedFromServer)
		{
			this.BaseGuid = BaseGuid;
			this.TimeInState = TimeInState;
			this.bIsActive = bIsActive;
			this.bSetAllParents = bSetAllParents;
			base.TransactionType = TransactionType;
			base.bOriginatedFromServer = bOriginatedFromServer;
		}

		// Token: 0x060265E4 RID: 157156 RVA: 0x003A4E82 File Offset: 0x003A3082
		protected override IntPtr GetUStructPtr()
		{
			return FSMActivateStateTransaction.StaticStruct();
		}

		// Token: 0x060265E5 RID: 157157 RVA: 0x003A4E8E File Offset: 0x003A308E
		[NullableContext(2)]
		public FSMActivateStateTransaction(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060265E6 RID: 157158 RVA: 0x003A4E98 File Offset: 0x003A3098
		public FSMActivateStateTransaction(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060265E7 RID: 157159 RVA: 0x003A4EA3 File Offset: 0x003A30A3
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSMActivateStateTransaction(Pointer, false, true);
		}

		// Token: 0x060265E8 RID: 157160 RVA: 0x003A4EAD File Offset: 0x003A30AD
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSMActivateStateTransaction(Pointer, MemoryOwner);
		}

		// Token: 0x040150A7 RID: 86183
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/SMSystem.SMActivateStateTransaction";

		// Token: 0x040150A8 RID: 86184
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040150A9 RID: 86185
		internal static int __PropertyOffset_BaseGuid;

		// Token: 0x040150AA RID: 86186
		internal static int __PropertyOffset_TimeInState;

		// Token: 0x040150AB RID: 86187
		internal static int __PropertyOffset_bIsActive;

		// Token: 0x040150AC RID: 86188
		internal static byte __PropertyMask_bIsActive;

		// Token: 0x040150AD RID: 86189
		internal static int __PropertyOffset_bSetAllParents;

		// Token: 0x040150AE RID: 86190
		internal static byte __PropertyMask_bSetAllParents;
	}
}
