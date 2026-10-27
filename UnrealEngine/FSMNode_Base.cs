using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200288E RID: 10382
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SMSystem.SMNode_Base")]
	[UnrealStructLayout(208, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 208)]
	public class FSMNode_Base : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602674B RID: 157515 RVA: 0x003A8CBD File Offset: 0x003A6EBD
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSMNode_Base._ScriptStructPtr != 0) ? FSMNode_Base._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SMSystem.SMNode_Base", ref FSMNode_Base._ScriptStructPtr);
		}

		// Token: 0x1700943B RID: 37947
		// (get) Token: 0x0602674C RID: 157516 RVA: 0x003A8CE4 File Offset: 0x003A6EE4
		// (set) Token: 0x0602674D RID: 157517 RVA: 0x003A8D27 File Offset: 0x003A6F27
		public TArray<FSMExposedFunctionHandler> TransitionInitializedGraphEvaluators
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSMExposedFunctionHandler> result;
				if ((result = this._TransitionInitializedGraphEvaluators) == null)
				{
					result = (this._TransitionInitializedGraphEvaluators = new TArray<FSMExposedFunctionHandler>(base.NativePtr + (IntPtr)FSMNode_Base.__PropertyOffset_TransitionInitializedGraphEvaluators, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.TransitionInitializedGraphEvaluators.CopyAssign(value);
			}
		}

		// Token: 0x1700943C RID: 37948
		// (get) Token: 0x0602674E RID: 157518 RVA: 0x003A8D38 File Offset: 0x003A6F38
		// (set) Token: 0x0602674F RID: 157519 RVA: 0x003A8D7B File Offset: 0x003A6F7B
		public TArray<FSMExposedFunctionHandler> TransitionShutdownGraphEvaluators
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSMExposedFunctionHandler> result;
				if ((result = this._TransitionShutdownGraphEvaluators) == null)
				{
					result = (this._TransitionShutdownGraphEvaluators = new TArray<FSMExposedFunctionHandler>(base.NativePtr + (IntPtr)FSMNode_Base.__PropertyOffset_TransitionShutdownGraphEvaluators, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.TransitionShutdownGraphEvaluators.CopyAssign(value);
			}
		}

		// Token: 0x1700943D RID: 37949
		// (get) Token: 0x06026750 RID: 157520 RVA: 0x003A8D8C File Offset: 0x003A6F8C
		// (set) Token: 0x06026751 RID: 157521 RVA: 0x003A8DCF File Offset: 0x003A6FCF
		public TArray<FSMExposedFunctionHandler> OnRootStateMachineStartedGraphEvaluator
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSMExposedFunctionHandler> result;
				if ((result = this._OnRootStateMachineStartedGraphEvaluator) == null)
				{
					result = (this._OnRootStateMachineStartedGraphEvaluator = new TArray<FSMExposedFunctionHandler>(base.NativePtr + (IntPtr)FSMNode_Base.__PropertyOffset_OnRootStateMachineStartedGraphEvaluator, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.OnRootStateMachineStartedGraphEvaluator.CopyAssign(value);
			}
		}

		// Token: 0x1700943E RID: 37950
		// (get) Token: 0x06026752 RID: 157522 RVA: 0x003A8DE0 File Offset: 0x003A6FE0
		// (set) Token: 0x06026753 RID: 157523 RVA: 0x003A8E23 File Offset: 0x003A7023
		public TArray<FSMExposedFunctionHandler> OnRootStateMachineStoppedGraphEvaluator
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSMExposedFunctionHandler> result;
				if ((result = this._OnRootStateMachineStoppedGraphEvaluator) == null)
				{
					result = (this._OnRootStateMachineStoppedGraphEvaluator = new TArray<FSMExposedFunctionHandler>(base.NativePtr + (IntPtr)FSMNode_Base.__PropertyOffset_OnRootStateMachineStoppedGraphEvaluator, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.OnRootStateMachineStoppedGraphEvaluator.CopyAssign(value);
			}
		}

		// Token: 0x1700943F RID: 37951
		// (get) Token: 0x06026754 RID: 157524 RVA: 0x003A8E31 File Offset: 0x003A7031
		// (set) Token: 0x06026755 RID: 157525 RVA: 0x003A8E41 File Offset: 0x003A7041
		public unsafe float TimeInState
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSMNode_Base.__PropertyOffset_TimeInState);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSMNode_Base.__PropertyOffset_TimeInState) = value;
			}
		}

		// Token: 0x17009440 RID: 37952
		// (get) Token: 0x06026756 RID: 157526 RVA: 0x003A8E52 File Offset: 0x003A7052
		// (set) Token: 0x06026757 RID: 157527 RVA: 0x003A8E62 File Offset: 0x003A7062
		public unsafe bool bIsInEndState
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSMNode_Base.__PropertyOffset_bIsInEndState) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSMNode_Base.__PropertyOffset_bIsInEndState) = (value ? 1 : 0);
			}
		}

		// Token: 0x17009441 RID: 37953
		// (get) Token: 0x06026758 RID: 157528 RVA: 0x003A8E73 File Offset: 0x003A7073
		// (set) Token: 0x06026759 RID: 157529 RVA: 0x003A8E83 File Offset: 0x003A7083
		public unsafe bool bHasUpdated
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSMNode_Base.__PropertyOffset_bHasUpdated) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSMNode_Base.__PropertyOffset_bHasUpdated) = (value ? 1 : 0);
			}
		}

		// Token: 0x17009442 RID: 37954
		// (get) Token: 0x0602675A RID: 157530 RVA: 0x003A8E94 File Offset: 0x003A7094
		// (set) Token: 0x0602675B RID: 157531 RVA: 0x003A8EA4 File Offset: 0x003A70A4
		public unsafe int DuplicateId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSMNode_Base.__PropertyOffset_DuplicateId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSMNode_Base.__PropertyOffset_DuplicateId) = value;
			}
		}

		// Token: 0x17009443 RID: 37955
		// (get) Token: 0x0602675C RID: 157532 RVA: 0x003A8EB5 File Offset: 0x003A70B5
		// (set) Token: 0x0602675D RID: 157533 RVA: 0x003A8EC9 File Offset: 0x003A70C9
		public unsafe FGuid Guid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSMNode_Base.__PropertyOffset_Guid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSMNode_Base.__PropertyOffset_Guid) = value;
			}
		}

		// Token: 0x17009444 RID: 37956
		// (get) Token: 0x0602675E RID: 157534 RVA: 0x003A8EDE File Offset: 0x003A70DE
		// (set) Token: 0x0602675F RID: 157535 RVA: 0x003A8EF2 File Offset: 0x003A70F2
		public unsafe FGuid OwnerGuid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSMNode_Base.__PropertyOffset_OwnerGuid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSMNode_Base.__PropertyOffset_OwnerGuid) = value;
			}
		}

		// Token: 0x17009445 RID: 37957
		// (get) Token: 0x06026760 RID: 157536 RVA: 0x003A8F07 File Offset: 0x003A7107
		// (set) Token: 0x06026761 RID: 157537 RVA: 0x003A8F1B File Offset: 0x003A711B
		public unsafe FGuid PathGuid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSMNode_Base.__PropertyOffset_PathGuid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSMNode_Base.__PropertyOffset_PathGuid) = value;
			}
		}

		// Token: 0x17009446 RID: 37958
		// (get) Token: 0x06026762 RID: 157538 RVA: 0x003A8F30 File Offset: 0x003A7130
		// (set) Token: 0x06026763 RID: 157539 RVA: 0x003A8F44 File Offset: 0x003A7144
		public unsafe string NodeName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FSMNode_Base.__PropertyOffset_NodeName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FSMNode_Base.__PropertyOffset_NodeName)), value);
			}
		}

		// Token: 0x17009447 RID: 37959
		// (get) Token: 0x06026764 RID: 157540 RVA: 0x003A8F59 File Offset: 0x003A7159
		// (set) Token: 0x06026765 RID: 157541 RVA: 0x003A8F6D File Offset: 0x003A716D
		public unsafe FName TemplateName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSMNode_Base.__PropertyOffset_TemplateName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSMNode_Base.__PropertyOffset_TemplateName) = value;
			}
		}

		// Token: 0x17009448 RID: 37960
		// (get) Token: 0x06026766 RID: 157542 RVA: 0x003A8F82 File Offset: 0x003A7182
		// (set) Token: 0x06026767 RID: 157543 RVA: 0x003A8F96 File Offset: 0x003A7196
		[Nullable(2)]
		public unsafe USMInstance OwningInstance
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USMInstance>(base.NativePtr / (IntPtr)sizeof(void*) + FSMNode_Base.__PropertyOffset_OwningInstance);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FSMNode_Base.__PropertyOffset_OwningInstance, value);
			}
		}

		// Token: 0x17009449 RID: 37961
		// (get) Token: 0x06026768 RID: 157544 RVA: 0x003A8FAB File Offset: 0x003A71AB
		// (set) Token: 0x06026769 RID: 157545 RVA: 0x003A8FBF File Offset: 0x003A71BF
		[Nullable(2)]
		public unsafe USMNodeInstance NodeInstance
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USMNodeInstance>(base.NativePtr / (IntPtr)sizeof(void*) + FSMNode_Base.__PropertyOffset_NodeInstance);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FSMNode_Base.__PropertyOffset_NodeInstance, value);
			}
		}

		// Token: 0x1700944A RID: 37962
		// (get) Token: 0x0602676A RID: 157546 RVA: 0x003A8FD4 File Offset: 0x003A71D4
		// (set) Token: 0x0602676B RID: 157547 RVA: 0x003A8FE8 File Offset: 0x003A71E8
		public unsafe UClassStackOnlyPtr NodeInstanceClass
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSMNode_Base.__PropertyOffset_NodeInstanceClass);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSMNode_Base.__PropertyOffset_NodeInstanceClass) = value;
			}
		}

		// Token: 0x0602676C RID: 157548 RVA: 0x003A8FFD File Offset: 0x003A71FD
		public FSMNode_Base()
		{
		}

		// Token: 0x0602676D RID: 157549 RVA: 0x003A9008 File Offset: 0x003A7208
		public FSMNode_Base(TArray<FSMExposedFunctionHandler> TransitionInitializedGraphEvaluators, TArray<FSMExposedFunctionHandler> TransitionShutdownGraphEvaluators, TArray<FSMExposedFunctionHandler> OnRootStateMachineStartedGraphEvaluator, TArray<FSMExposedFunctionHandler> OnRootStateMachineStoppedGraphEvaluator, float TimeInState, bool bIsInEndState, bool bHasUpdated, int DuplicateId, FGuid Guid, FGuid OwnerGuid, FGuid PathGuid, string NodeName, FName TemplateName, USMInstance OwningInstance, USMNodeInstance NodeInstance, UClassStackOnlyPtr NodeInstanceClass)
		{
			this.TransitionInitializedGraphEvaluators = TransitionInitializedGraphEvaluators;
			this.TransitionShutdownGraphEvaluators = TransitionShutdownGraphEvaluators;
			this.OnRootStateMachineStartedGraphEvaluator = OnRootStateMachineStartedGraphEvaluator;
			this.OnRootStateMachineStoppedGraphEvaluator = OnRootStateMachineStoppedGraphEvaluator;
			this.TimeInState = TimeInState;
			this.bIsInEndState = bIsInEndState;
			this.bHasUpdated = bHasUpdated;
			this.DuplicateId = DuplicateId;
			this.Guid = Guid;
			this.OwnerGuid = OwnerGuid;
			this.PathGuid = PathGuid;
			this.NodeName = NodeName;
			this.TemplateName = TemplateName;
			this.OwningInstance = OwningInstance;
			this.NodeInstance = NodeInstance;
			this.NodeInstanceClass = NodeInstanceClass;
		}

		// Token: 0x0602676E RID: 157550 RVA: 0x003A9098 File Offset: 0x003A7298
		protected override IntPtr GetUStructPtr()
		{
			return FSMNode_Base.StaticStruct();
		}

		// Token: 0x0602676F RID: 157551 RVA: 0x003A90A4 File Offset: 0x003A72A4
		[NullableContext(2)]
		public FSMNode_Base(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06026770 RID: 157552 RVA: 0x003A90AE File Offset: 0x003A72AE
		public FSMNode_Base(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06026771 RID: 157553 RVA: 0x003A90B9 File Offset: 0x003A72B9
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSMNode_Base(Pointer, false, true);
		}

		// Token: 0x06026772 RID: 157554 RVA: 0x003A90C3 File Offset: 0x003A72C3
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSMNode_Base(Pointer, MemoryOwner);
		}

		// Token: 0x040151AE RID: 86446
		public const string __ObjectPath = "/Script/SMSystem.SMNode_Base";

		// Token: 0x040151AF RID: 86447
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040151B0 RID: 86448
		internal static int __PropertyOffset_TransitionInitializedGraphEvaluators;

		// Token: 0x040151B1 RID: 86449
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSMExposedFunctionHandler> _TransitionInitializedGraphEvaluators;

		// Token: 0x040151B2 RID: 86450
		internal static int __PropertyOffset_TransitionShutdownGraphEvaluators;

		// Token: 0x040151B3 RID: 86451
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSMExposedFunctionHandler> _TransitionShutdownGraphEvaluators;

		// Token: 0x040151B4 RID: 86452
		internal static int __PropertyOffset_OnRootStateMachineStartedGraphEvaluator;

		// Token: 0x040151B5 RID: 86453
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSMExposedFunctionHandler> _OnRootStateMachineStartedGraphEvaluator;

		// Token: 0x040151B6 RID: 86454
		internal static int __PropertyOffset_OnRootStateMachineStoppedGraphEvaluator;

		// Token: 0x040151B7 RID: 86455
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSMExposedFunctionHandler> _OnRootStateMachineStoppedGraphEvaluator;

		// Token: 0x040151B8 RID: 86456
		internal static int __PropertyOffset_TimeInState;

		// Token: 0x040151B9 RID: 86457
		internal static int __PropertyOffset_bIsInEndState;

		// Token: 0x040151BA RID: 86458
		internal static int __PropertyOffset_bHasUpdated;

		// Token: 0x040151BB RID: 86459
		internal static int __PropertyOffset_DuplicateId;

		// Token: 0x040151BC RID: 86460
		internal static int __PropertyOffset_Guid;

		// Token: 0x040151BD RID: 86461
		internal static int __PropertyOffset_OwnerGuid;

		// Token: 0x040151BE RID: 86462
		internal static int __PropertyOffset_PathGuid;

		// Token: 0x040151BF RID: 86463
		internal static int __PropertyOffset_NodeName;

		// Token: 0x040151C0 RID: 86464
		internal static int __PropertyOffset_TemplateName;

		// Token: 0x040151C1 RID: 86465
		internal static int __PropertyOffset_OwningInstance;

		// Token: 0x040151C2 RID: 86466
		internal static int __PropertyOffset_NodeInstance;

		// Token: 0x040151C3 RID: 86467
		internal static int __PropertyOffset_NodeInstanceClass;
	}
}
