using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002893 RID: 10387
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SMSystem.SMStateInfo")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 128)]
	public class FSMStateInfo : FSMInfo_Base, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060267A4 RID: 157604 RVA: 0x003A95BF File Offset: 0x003A77BF
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSMStateInfo._ScriptStructPtr != 0) ? FSMStateInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SMSystem.SMStateInfo", ref FSMStateInfo._ScriptStructPtr);
		}

		// Token: 0x17009455 RID: 37973
		// (get) Token: 0x060267A5 RID: 157605 RVA: 0x003A95E4 File Offset: 0x003A77E4
		// (set) Token: 0x060267A6 RID: 157606 RVA: 0x003A9627 File Offset: 0x003A7827
		public TArray<FSMTransitionInfo> OutgoingTransitions
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSMTransitionInfo> result;
				if ((result = this._OutgoingTransitions) == null)
				{
					result = (this._OutgoingTransitions = new TArray<FSMTransitionInfo>(base.NativePtr + (IntPtr)FSMStateInfo.__PropertyOffset_OutgoingTransitions, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.OutgoingTransitions.CopyAssign(value);
			}
		}

		// Token: 0x17009456 RID: 37974
		// (get) Token: 0x060267A7 RID: 157607 RVA: 0x003A9635 File Offset: 0x003A7835
		// (set) Token: 0x060267A8 RID: 157608 RVA: 0x003A9645 File Offset: 0x003A7845
		public unsafe bool bIsEndState
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSMStateInfo.__PropertyOffset_bIsEndState) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSMStateInfo.__PropertyOffset_bIsEndState) = (value ? 1 : 0);
			}
		}

		// Token: 0x060267A9 RID: 157609 RVA: 0x003A9656 File Offset: 0x003A7856
		public FSMStateInfo()
		{
		}

		// Token: 0x060267AA RID: 157610 RVA: 0x003A9660 File Offset: 0x003A7860
		public FSMStateInfo(TArray<FSMTransitionInfo> OutgoingTransitions, bool bIsEndState, string NodeName, FGuid Guid, FGuid OwnerGuid, FGuid NodeGuid, FGuid OwnerNodeGuid, USMNodeInstance NodeInstance)
		{
			this.OutgoingTransitions = OutgoingTransitions;
			this.bIsEndState = bIsEndState;
			base.NodeName = NodeName;
			base.Guid = Guid;
			base.OwnerGuid = OwnerGuid;
			base.NodeGuid = NodeGuid;
			base.OwnerNodeGuid = OwnerNodeGuid;
			base.NodeInstance = NodeInstance;
		}

		// Token: 0x060267AB RID: 157611 RVA: 0x003A96B0 File Offset: 0x003A78B0
		protected override IntPtr GetUStructPtr()
		{
			return FSMStateInfo.StaticStruct();
		}

		// Token: 0x060267AC RID: 157612 RVA: 0x003A96BC File Offset: 0x003A78BC
		[NullableContext(2)]
		public FSMStateInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060267AD RID: 157613 RVA: 0x003A96C6 File Offset: 0x003A78C6
		public FSMStateInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060267AE RID: 157614 RVA: 0x003A96D1 File Offset: 0x003A78D1
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSMStateInfo(Pointer, false, true);
		}

		// Token: 0x060267AF RID: 157615 RVA: 0x003A96DB File Offset: 0x003A78DB
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSMStateInfo(Pointer, MemoryOwner);
		}

		// Token: 0x040151DB RID: 86491
		public new const string __ObjectPath = "/Script/SMSystem.SMStateInfo";

		// Token: 0x040151DC RID: 86492
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040151DD RID: 86493
		internal static int __PropertyOffset_OutgoingTransitions;

		// Token: 0x040151DE RID: 86494
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSMTransitionInfo> _OutgoingTransitions;

		// Token: 0x040151DF RID: 86495
		internal static int __PropertyOffset_bIsEndState;
	}
}
