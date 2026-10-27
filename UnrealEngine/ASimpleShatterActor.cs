using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001C28 RID: 7208
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.SimpleShatterActor")]
	[UnrealStructLayout(1664, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1664)]
	public class ASimpleShatterActor : AKuroBPActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601BD8D RID: 114061 RVA: 0x0028FC10 File Offset: 0x0028DE10
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ASimpleShatterActor._ClassPtr;
		}

		// Token: 0x0601BD8E RID: 114062 RVA: 0x0028FC1C File Offset: 0x0028DE1C
		public ASimpleShatterActor() : this(BuiltinUtils.AllocNativeUObject(ASimpleShatterActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601BD8F RID: 114063 RVA: 0x0028FC44 File Offset: 0x0028DE44
		public ASimpleShatterActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ASimpleShatterActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007060 RID: 28768
		// (get) Token: 0x0601BD90 RID: 114064 RVA: 0x0028FC78 File Offset: 0x0028DE78
		// (set) Token: 0x0601BD91 RID: 114065 RVA: 0x0028FCB1 File Offset: 0x0028DEB1
		public TMap<int, FSimpleShatterNode> Nodes
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, FSimpleShatterNode> result;
				if ((result = this._Nodes) == null)
				{
					result = (this._Nodes = new TMap<int, FSimpleShatterNode>(base.NativePtr + (IntPtr)ASimpleShatterActor.__PropertyOffset_Nodes, this));
				}
				return result;
			}
			set
			{
				this.Nodes.CopyAssign(value);
			}
		}

		// Token: 0x17007061 RID: 28769
		// (get) Token: 0x0601BD92 RID: 114066 RVA: 0x0028FCC0 File Offset: 0x0028DEC0
		// (set) Token: 0x0601BD93 RID: 114067 RVA: 0x0028FCF9 File Offset: 0x0028DEF9
		public TMap<string, int> NodeNameToID
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, int> result;
				if ((result = this._NodeNameToID) == null)
				{
					result = (this._NodeNameToID = new TMap<string, int>(base.NativePtr + (IntPtr)ASimpleShatterActor.__PropertyOffset_NodeNameToID, this));
				}
				return result;
			}
			set
			{
				this.NodeNameToID.CopyAssign(value);
			}
		}

		// Token: 0x17007062 RID: 28770
		// (get) Token: 0x0601BD94 RID: 114068 RVA: 0x0028FD08 File Offset: 0x0028DF08
		// (set) Token: 0x0601BD95 RID: 114069 RVA: 0x0028FD41 File Offset: 0x0028DF41
		public TArray<int> WaitingDestroyedQueue
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._WaitingDestroyedQueue) == null)
				{
					result = (this._WaitingDestroyedQueue = new TArray<int>(base.NativePtr + (IntPtr)ASimpleShatterActor.__PropertyOffset_WaitingDestroyedQueue, this));
				}
				return result;
			}
			set
			{
				this.WaitingDestroyedQueue.CopyAssign(value);
			}
		}

		// Token: 0x17007063 RID: 28771
		// (get) Token: 0x0601BD96 RID: 114070 RVA: 0x0028FD50 File Offset: 0x0028DF50
		// (set) Token: 0x0601BD97 RID: 114071 RVA: 0x0028FD89 File Offset: 0x0028DF89
		public TArray<int> WaitingShatterQueue
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._WaitingShatterQueue) == null)
				{
					result = (this._WaitingShatterQueue = new TArray<int>(base.NativePtr + (IntPtr)ASimpleShatterActor.__PropertyOffset_WaitingShatterQueue, this));
				}
				return result;
			}
			set
			{
				this.WaitingShatterQueue.CopyAssign(value);
			}
		}

		// Token: 0x17007064 RID: 28772
		// (get) Token: 0x0601BD98 RID: 114072 RVA: 0x0028FD98 File Offset: 0x0028DF98
		// (set) Token: 0x0601BD99 RID: 114073 RVA: 0x0028FDD1 File Offset: 0x0028DFD1
		public TArray<int> CheckShatterStateQueue
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._CheckShatterStateQueue) == null)
				{
					result = (this._CheckShatterStateQueue = new TArray<int>(base.NativePtr + (IntPtr)ASimpleShatterActor.__PropertyOffset_CheckShatterStateQueue, this));
				}
				return result;
			}
			set
			{
				this.CheckShatterStateQueue.CopyAssign(value);
			}
		}

		// Token: 0x17007065 RID: 28773
		// (get) Token: 0x0601BD9A RID: 114074 RVA: 0x0028FDE0 File Offset: 0x0028DFE0
		// (set) Token: 0x0601BD9B RID: 114075 RVA: 0x0028FE19 File Offset: 0x0028E019
		public TArray<int> WaitingDitherQueue
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._WaitingDitherQueue) == null)
				{
					result = (this._WaitingDitherQueue = new TArray<int>(base.NativePtr + (IntPtr)ASimpleShatterActor.__PropertyOffset_WaitingDitherQueue, this));
				}
				return result;
			}
			set
			{
				this.WaitingDitherQueue.CopyAssign(value);
			}
		}

		// Token: 0x17007066 RID: 28774
		// (get) Token: 0x0601BD9C RID: 114076 RVA: 0x0028FE27 File Offset: 0x0028E027
		// (set) Token: 0x0601BD9D RID: 114077 RVA: 0x0028FE37 File Offset: 0x0028E037
		public unsafe float WaitingDitherTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ASimpleShatterActor.__PropertyOffset_WaitingDitherTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ASimpleShatterActor.__PropertyOffset_WaitingDitherTime) = value;
			}
		}

		// Token: 0x17007067 RID: 28775
		// (get) Token: 0x0601BD9E RID: 114078 RVA: 0x0028FE48 File Offset: 0x0028E048
		// (set) Token: 0x0601BD9F RID: 114079 RVA: 0x0028FE58 File Offset: 0x0028E058
		public unsafe float Dither
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ASimpleShatterActor.__PropertyOffset_Dither);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ASimpleShatterActor.__PropertyOffset_Dither) = value;
			}
		}

		// Token: 0x0601BDA0 RID: 114080 RVA: 0x0028FE69 File Offset: 0x0028E069
		public void UpdateWaitingDitherQueue(float DeltaTime, float DitherStep = 0.02f)
		{
			ASimpleShatterActor.__UpdateWaitingDitherQueue_Internal(base.NativePtr, DeltaTime, DitherStep);
		}

		// Token: 0x0601BDA1 RID: 114081 RVA: 0x0028FE78 File Offset: 0x0028E078
		public unsafe bool SetParentWeightAndRebalanceByName(int ChildNodeID, string ParentNodeName, float NewWeight)
		{
			FString fstring = FString.AllocTemp(ParentNodeName);
			bool result = ASimpleShatterActor.__SetParentWeightAndRebalanceByName_Internal(base.NativePtr, ChildNodeID, fstring, NewWeight);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0601BDA2 RID: 114082 RVA: 0x0028FEA4 File Offset: 0x0028E0A4
		public bool SetParentWeightAndRebalanceByID(int ChildNodeID, int ParentNodeID, float NewWeight)
		{
			return ASimpleShatterActor.__SetParentWeightAndRebalanceByID_Internal(base.NativePtr, ChildNodeID, ParentNodeID, NewWeight);
		}

		// Token: 0x0601BDA3 RID: 114083 RVA: 0x0028FEB4 File Offset: 0x0028E0B4
		public void SetParentWeight(int ChildNodeID, int ParentNodeID, float Weight)
		{
			ASimpleShatterActor.__SetParentWeight_Internal(base.NativePtr, ChildNodeID, ParentNodeID, Weight);
		}

		// Token: 0x0601BDA4 RID: 114084 RVA: 0x0028FEC4 File Offset: 0x0028E0C4
		public void SetNodeShattered(int NodeID, bool bShattered)
		{
			ASimpleShatterActor.__SetNodeShattered_Internal(base.NativePtr, NodeID, bShattered);
		}

		// Token: 0x0601BDA5 RID: 114085 RVA: 0x0028FED3 File Offset: 0x0028E0D3
		[NullableContext(2)]
		public void SetNodeNiagaraSystem(int NodeID, UNiagaraSystem InNiagaraSystem)
		{
			ASimpleShatterActor.__SetNodeNiagaraSystem_Internal(base.NativePtr, NodeID, (InNiagaraSystem != null) ? InNiagaraSystem.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601BDA6 RID: 114086 RVA: 0x0028FEF4 File Offset: 0x0028E0F4
		public unsafe void SetNodeName(int NodeID, string NodeName)
		{
			FString fstring = FString.AllocTemp(NodeName);
			ASimpleShatterActor.__SetNodeName_Internal(base.NativePtr, NodeID, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0601BDA7 RID: 114087 RVA: 0x0028FF20 File Offset: 0x0028E120
		public unsafe void SetNodeLastFrameWorldTransform(int NodeID, FTransform LastTransform)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = LastTransform;
			ASimpleShatterActor.__SetNodeLastFrameWorldTransform_Internal(base.NativePtr, NodeID, ptr);
		}

		// Token: 0x0601BDA8 RID: 114088 RVA: 0x0028FF54 File Offset: 0x0028E154
		public unsafe void SetNodeInitialTransform(int NodeID, FTransform InitialTransform)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = InitialTransform;
			ASimpleShatterActor.__SetNodeInitialTransform_Internal(base.NativePtr, NodeID, ptr);
		}

		// Token: 0x0601BDA9 RID: 114089 RVA: 0x0028FF85 File Offset: 0x0028E185
		public void SetNodeEnableDissolve(int NodeID, bool bInEnableDissolve)
		{
			ASimpleShatterActor.__SetNodeEnableDissolve_Internal(base.NativePtr, NodeID, bInEnableDissolve);
		}

		// Token: 0x0601BDAA RID: 114090 RVA: 0x0028FF94 File Offset: 0x0028E194
		public void SetNodeDestroyedAndShattered(int NodeID, bool bDestroyedAndShattered)
		{
			ASimpleShatterActor.__SetNodeDestroyedAndShattered_Internal(base.NativePtr, NodeID, bDestroyedAndShattered);
		}

		// Token: 0x0601BDAB RID: 114091 RVA: 0x0028FFA3 File Offset: 0x0028E1A3
		public void SetNodeDestroyed(int NodeID, bool bDestroyed)
		{
			ASimpleShatterActor.__SetNodeDestroyed_Internal(base.NativePtr, NodeID, bDestroyed);
		}

		// Token: 0x0601BDAC RID: 114092 RVA: 0x0028FFB2 File Offset: 0x0028E1B2
		public void SetNodeCurSpeed(int NodeID, FVector Speed)
		{
			ASimpleShatterActor.__SetNodeCurSpeed_Internal(base.NativePtr, NodeID, Speed);
		}

		// Token: 0x0601BDAD RID: 114093 RVA: 0x0028FFC1 File Offset: 0x0028E1C1
		[NullableContext(2)]
		public void SetNodeComponent(int NodeID, UStaticMeshComponent OwnerComponent)
		{
			ASimpleShatterActor.__SetNodeComponent_Internal(base.NativePtr, NodeID, (OwnerComponent != null) ? OwnerComponent.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601BDAE RID: 114094 RVA: 0x0028FFDF File Offset: 0x0028E1DF
		public void SetNodeAutoShatterOnDestroy(int NodeID, bool bAutoShatter)
		{
			ASimpleShatterActor.__SetNodeAutoShatterOnDestroy_Internal(base.NativePtr, NodeID, bAutoShatter);
		}

		// Token: 0x0601BDAF RID: 114095 RVA: 0x0028FFEE File Offset: 0x0028E1EE
		public void RestoreNodesFromArray([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FSimpleShatterNode> SavedNodes)
		{
			ASimpleShatterActor.__RestoreNodesFromArray_Internal(base.NativePtr, (SavedNodes ?? new TArray<FSimpleShatterNode>()).NativePtr);
		}

		// Token: 0x0601BDB0 RID: 114096 RVA: 0x0029000B File Offset: 0x0028E20B
		public void RemoveParentFromNode(int ChildNodeID, int ParentNodeID)
		{
			ASimpleShatterActor.__RemoveParentFromNode_Internal(base.NativePtr, ChildNodeID, ParentNodeID);
		}

		// Token: 0x0601BDB1 RID: 114097 RVA: 0x0029001A File Offset: 0x0028E21A
		public void RemoveNodeFromWaitingDitherQueue(int NodeID)
		{
			ASimpleShatterActor.__RemoveNodeFromWaitingDitherQueue_Internal(base.NativePtr, NodeID);
		}

		// Token: 0x0601BDB2 RID: 114098 RVA: 0x00290028 File Offset: 0x0028E228
		public void RemoveNode(int NodeID)
		{
			ASimpleShatterActor.__RemoveNode_Internal(base.NativePtr, NodeID);
		}

		// Token: 0x0601BDB3 RID: 114099 RVA: 0x00290036 File Offset: 0x0028E236
		[NullableContext(2)]
		public void RemoveAfterDestroyedMesh(int NodeID, UStaticMesh Mesh)
		{
			ASimpleShatterActor.__RemoveAfterDestroyedMesh_Internal(base.NativePtr, NodeID, (Mesh != null) ? Mesh.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601BDB4 RID: 114100 RVA: 0x00290054 File Offset: 0x0028E254
		[NullableContext(2)]
		public void RemoveAfterDestroyedActor(int NodeID, AStaticMeshActor Actor)
		{
			ASimpleShatterActor.__RemoveAfterDestroyedActor_Internal(base.NativePtr, NodeID, (Actor != null) ? Actor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601BDB5 RID: 114101 RVA: 0x00290072 File Offset: 0x0028E272
		public void RebuildChildrenFromParents()
		{
			ASimpleShatterActor.__RebuildChildrenFromParents_Internal(base.NativePtr);
		}

		// Token: 0x0601BDB6 RID: 114102 RVA: 0x0029007F File Offset: 0x0028E27F
		public void PushNodeToWaitingDitherQueue(int NodeID)
		{
			ASimpleShatterActor.__PushNodeToWaitingDitherQueue_Internal(base.NativePtr, NodeID);
		}

		// Token: 0x0601BDB7 RID: 114103 RVA: 0x0029008D File Offset: 0x0028E28D
		public void PropagateDestroyToChildren(int NodeID, float DestroyThreshold = 0.5f)
		{
			ASimpleShatterActor.__PropagateDestroyToChildren_Internal(base.NativePtr, NodeID, DestroyThreshold);
		}

		// Token: 0x0601BDB8 RID: 114104 RVA: 0x0029009C File Offset: 0x0028E29C
		public float GetParentWeight(int ChildNodeID, int ParentNodeID)
		{
			return ASimpleShatterActor.__GetParentWeight_Internal(base.NativePtr, ChildNodeID, ParentNodeID);
		}

		// Token: 0x0601BDB9 RID: 114105 RVA: 0x002900AB File Offset: 0x0028E2AB
		[NullableContext(2)]
		public UNiagaraSystem GetNodeNiagaraSystem(int NodeID)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UNiagaraSystem>(ASimpleShatterActor.__GetNodeNiagaraSystem_Internal(base.NativePtr, NodeID));
		}

		// Token: 0x0601BDBA RID: 114106 RVA: 0x002900BE File Offset: 0x0028E2BE
		public string GetNodeName(int NodeID)
		{
			return FString.ToStringAndDeleteNativePtr(ASimpleShatterActor.__GetNodeName_Internal(base.NativePtr, NodeID));
		}

		// Token: 0x0601BDBB RID: 114107 RVA: 0x002900D1 File Offset: 0x0028E2D1
		public FTransform GetNodeLastFrameWorldTransform(int NodeID)
		{
			return ASimpleShatterActor.__GetNodeLastFrameWorldTransform_Internal(base.NativePtr, NodeID);
		}

		// Token: 0x0601BDBC RID: 114108 RVA: 0x002900DF File Offset: 0x0028E2DF
		public FTransform GetNodeInitialTransform(int NodeID)
		{
			return ASimpleShatterActor.__GetNodeInitialTransform_Internal(base.NativePtr, NodeID);
		}

		// Token: 0x0601BDBD RID: 114109 RVA: 0x002900ED File Offset: 0x0028E2ED
		public bool GetNodeEnableDissolve(int NodeID)
		{
			return ASimpleShatterActor.__GetNodeEnableDissolve_Internal(base.NativePtr, NodeID);
		}

		// Token: 0x0601BDBE RID: 114110 RVA: 0x002900FB File Offset: 0x0028E2FB
		public FVector GetNodeCurSpeed(int NodeID)
		{
			return ASimpleShatterActor.__GetNodeCurSpeed_Internal(base.NativePtr, NodeID);
		}

		// Token: 0x0601BDBF RID: 114111 RVA: 0x00290109 File Offset: 0x0028E309
		public int GetNodeCount()
		{
			return ASimpleShatterActor.__GetNodeCount_Internal(base.NativePtr);
		}

		// Token: 0x0601BDC0 RID: 114112 RVA: 0x00290116 File Offset: 0x0028E316
		[NullableContext(2)]
		public UStaticMeshComponent GetNodeComponent(int NodeID)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UStaticMeshComponent>(ASimpleShatterActor.__GetNodeComponent_Internal(base.NativePtr, NodeID));
		}

		// Token: 0x0601BDC1 RID: 114113 RVA: 0x0029012C File Offset: 0x0028E32C
		public unsafe bool GetNodeByName(string NodeName, [Nullable(2)] ref FSimpleShatterNode OutNode)
		{
			FString fstring = FString.AllocTemp(NodeName);
			bool result = ASimpleShatterActor.__GetNodeByName_Internal(base.NativePtr, fstring, (OutNode ?? new FSimpleShatterNode()).NativePtr);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0601BDC2 RID: 114114 RVA: 0x00290166 File Offset: 0x0028E366
		[NullableContext(2)]
		public bool GetNode(int NodeID, ref FSimpleShatterNode OutNode)
		{
			return ASimpleShatterActor.__GetNode_Internal(base.NativePtr, NodeID, (OutNode ?? new FSimpleShatterNode()).NativePtr);
		}

		// Token: 0x0601BDC3 RID: 114115 RVA: 0x00290184 File Offset: 0x0028E384
		public TMap<int, float> GetAllParentWeights(int NodeID)
		{
			return new TMap<int, float>(ASimpleShatterActor.__GetAllParentWeights_Internal(base.NativePtr, NodeID), null);
		}

		// Token: 0x0601BDC4 RID: 114116 RVA: 0x00290198 File Offset: 0x0028E398
		public TArray<FSimpleShatterNode> GetAllNodes()
		{
			return new TArray<FSimpleShatterNode>(ASimpleShatterActor.__GetAllNodes_Internal(base.NativePtr), null);
		}

		// Token: 0x0601BDC5 RID: 114117 RVA: 0x002901AB File Offset: 0x0028E3AB
		public TArray<int> GetAllNodeIDs()
		{
			return new TArray<int>(ASimpleShatterActor.__GetAllNodeIDs_Internal(base.NativePtr), null);
		}

		// Token: 0x0601BDC6 RID: 114118 RVA: 0x002901BE File Offset: 0x0028E3BE
		public TArray<UStaticMesh> GetAfterDestroyedMeshes(int NodeID)
		{
			return new TArray<UStaticMesh>(ASimpleShatterActor.__GetAfterDestroyedMeshes_Internal(base.NativePtr, NodeID), null);
		}

		// Token: 0x0601BDC7 RID: 114119 RVA: 0x002901D2 File Offset: 0x0028E3D2
		public TArray<AStaticMeshActor> GetAfterDestroyedActors(int NodeID)
		{
			return new TArray<AStaticMeshActor>(ASimpleShatterActor.__GetAfterDestroyedActors_Internal(base.NativePtr, NodeID), null);
		}

		// Token: 0x0601BDC8 RID: 114120 RVA: 0x002901E6 File Offset: 0x0028E3E6
		[NullableContext(2)]
		public int FindNodeIDByOwnerComponent(UStaticMeshComponent OwnerComponent)
		{
			return ASimpleShatterActor.__FindNodeIDByOwnerComponent_Internal(base.NativePtr, (OwnerComponent != null) ? OwnerComponent.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601BDC9 RID: 114121 RVA: 0x00290204 File Offset: 0x0028E404
		public unsafe int FindNodeIDByName(string NodeName)
		{
			FString fstring = FString.AllocTemp(NodeName);
			int result = ASimpleShatterActor.__FindNodeIDByName_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0601BDCA RID: 114122 RVA: 0x0029022E File Offset: 0x0028E42E
		public void ClearWaitingShatterQueue()
		{
			ASimpleShatterActor.__ClearWaitingShatterQueue_Internal(base.NativePtr);
		}

		// Token: 0x0601BDCB RID: 114123 RVA: 0x0029023B File Offset: 0x0028E43B
		public void ClearWaitingDitherQueue()
		{
			ASimpleShatterActor.__ClearWaitingDitherQueue_Internal(base.NativePtr);
		}

		// Token: 0x0601BDCC RID: 114124 RVA: 0x00290248 File Offset: 0x0028E448
		public void ClearWaitingDestroyedQueue()
		{
			ASimpleShatterActor.__ClearWaitingDestroyedQueue_Internal(base.NativePtr);
		}

		// Token: 0x0601BDCD RID: 114125 RVA: 0x00290255 File Offset: 0x0028E455
		public void ClearCheckShatterStateQueue()
		{
			ASimpleShatterActor.__ClearCheckShatterStateQueue_Internal(base.NativePtr);
		}

		// Token: 0x0601BDCE RID: 114126 RVA: 0x00290262 File Offset: 0x0028E462
		public void ClearAllNodes()
		{
			ASimpleShatterActor.__ClearAllNodes_Internal(base.NativePtr);
		}

		// Token: 0x0601BDCF RID: 114127 RVA: 0x0029026F File Offset: 0x0028E46F
		public void ClearAfterDestroyedMeshes(int NodeID)
		{
			ASimpleShatterActor.__ClearAfterDestroyedMeshes_Internal(base.NativePtr, NodeID);
		}

		// Token: 0x0601BDD0 RID: 114128 RVA: 0x0029027D File Offset: 0x0028E47D
		public void ClearAfterDestroyedActors(int NodeID)
		{
			ASimpleShatterActor.__ClearAfterDestroyedActors_Internal(base.NativePtr, NodeID);
		}

		// Token: 0x0601BDD1 RID: 114129 RVA: 0x0029028B File Offset: 0x0028E48B
		public bool CheckShouldDestroy(int NodeID, float DestroyThreshold = 0.5f)
		{
			return ASimpleShatterActor.__CheckShouldDestroy_Internal(base.NativePtr, NodeID, DestroyThreshold);
		}

		// Token: 0x0601BDD2 RID: 114130 RVA: 0x0029029A File Offset: 0x0028E49A
		public void AddParentToNode(int ChildNodeID, int ParentNodeID)
		{
			ASimpleShatterActor.__AddParentToNode_Internal(base.NativePtr, ChildNodeID, ParentNodeID);
		}

		// Token: 0x0601BDD3 RID: 114131 RVA: 0x002902AC File Offset: 0x0028E4AC
		public unsafe void AddNode(int NodeID, [Nullable(2)] UStaticMeshComponent OwnerComponent, FTransform InitialTransform, string NodeName = "")
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = InitialTransform;
			FString fstring = FString.AllocTemp(NodeName);
			ASimpleShatterActor.__AddNode_Internal(base.NativePtr, NodeID, (OwnerComponent != null) ? OwnerComponent.NativePtr : IntPtr.Zero, ptr, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0601BDD4 RID: 114132 RVA: 0x00290300 File Offset: 0x0028E500
		[NullableContext(2)]
		public void AddAfterDestroyedMesh(int NodeID, UStaticMesh Mesh)
		{
			ASimpleShatterActor.__AddAfterDestroyedMesh_Internal(base.NativePtr, NodeID, (Mesh != null) ? Mesh.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601BDD5 RID: 114133 RVA: 0x0029031E File Offset: 0x0028E51E
		[NullableContext(2)]
		public void AddAfterDestroyedActor(int NodeID, AStaticMeshActor Actor)
		{
			ASimpleShatterActor.__AddAfterDestroyedActor_Internal(base.NativePtr, NodeID, (Actor != null) ? Actor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601BDD6 RID: 114134
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateWaitingDitherQueue_Internal(IntPtr @this, float DeltaTime, float DitherStep);

		// Token: 0x0601BDD7 RID: 114135
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SetParentWeightAndRebalanceByName_Internal(IntPtr @this, int ChildNodeID, in FString ParentNodeName, float NewWeight);

		// Token: 0x0601BDD8 RID: 114136
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SetParentWeightAndRebalanceByID_Internal(IntPtr @this, int ChildNodeID, int ParentNodeID, float NewWeight);

		// Token: 0x0601BDD9 RID: 114137
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetParentWeight_Internal(IntPtr @this, int ChildNodeID, int ParentNodeID, float Weight);

		// Token: 0x0601BDDA RID: 114138
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNodeShattered_Internal(IntPtr @this, int NodeID, bool bShattered);

		// Token: 0x0601BDDB RID: 114139
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNodeNiagaraSystem_Internal(IntPtr @this, int NodeID, IntPtr InNiagaraSystem);

		// Token: 0x0601BDDC RID: 114140
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNodeName_Internal(IntPtr @this, int NodeID, in FString NodeName);

		// Token: 0x0601BDDD RID: 114141
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNodeLastFrameWorldTransform_Internal(IntPtr @this, int NodeID, in FTransform LastTransform);

		// Token: 0x0601BDDE RID: 114142
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNodeInitialTransform_Internal(IntPtr @this, int NodeID, in FTransform InitialTransform);

		// Token: 0x0601BDDF RID: 114143
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNodeEnableDissolve_Internal(IntPtr @this, int NodeID, bool bInEnableDissolve);

		// Token: 0x0601BDE0 RID: 114144
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNodeDestroyedAndShattered_Internal(IntPtr @this, int NodeID, bool bDestroyedAndShattered);

		// Token: 0x0601BDE1 RID: 114145
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNodeDestroyed_Internal(IntPtr @this, int NodeID, bool bDestroyed);

		// Token: 0x0601BDE2 RID: 114146
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNodeCurSpeed_Internal(IntPtr @this, int NodeID, FVector Speed);

		// Token: 0x0601BDE3 RID: 114147
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNodeComponent_Internal(IntPtr @this, int NodeID, IntPtr OwnerComponent);

		// Token: 0x0601BDE4 RID: 114148
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNodeAutoShatterOnDestroy_Internal(IntPtr @this, int NodeID, bool bAutoShatter);

		// Token: 0x0601BDE5 RID: 114149
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RestoreNodesFromArray_Internal(IntPtr @this, IntPtr SavedNodes);

		// Token: 0x0601BDE6 RID: 114150
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveParentFromNode_Internal(IntPtr @this, int ChildNodeID, int ParentNodeID);

		// Token: 0x0601BDE7 RID: 114151
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveNodeFromWaitingDitherQueue_Internal(IntPtr @this, int NodeID);

		// Token: 0x0601BDE8 RID: 114152
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveNode_Internal(IntPtr @this, int NodeID);

		// Token: 0x0601BDE9 RID: 114153
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveAfterDestroyedMesh_Internal(IntPtr @this, int NodeID, IntPtr Mesh);

		// Token: 0x0601BDEA RID: 114154
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveAfterDestroyedActor_Internal(IntPtr @this, int NodeID, IntPtr Actor);

		// Token: 0x0601BDEB RID: 114155
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RebuildChildrenFromParents_Internal(IntPtr @this);

		// Token: 0x0601BDEC RID: 114156
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PushNodeToWaitingDitherQueue_Internal(IntPtr @this, int NodeID);

		// Token: 0x0601BDED RID: 114157
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PropagateDestroyToChildren_Internal(IntPtr @this, int NodeID, float DestroyThreshold);

		// Token: 0x0601BDEE RID: 114158
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetParentWeight_Internal(IntPtr @this, int ChildNodeID, int ParentNodeID);

		// Token: 0x0601BDEF RID: 114159
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetNodeNiagaraSystem_Internal(IntPtr @this, int NodeID);

		// Token: 0x0601BDF0 RID: 114160
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetNodeName_Internal(IntPtr @this, int NodeID);

		// Token: 0x0601BDF1 RID: 114161
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform __GetNodeLastFrameWorldTransform_Internal(IntPtr @this, int NodeID);

		// Token: 0x0601BDF2 RID: 114162
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform __GetNodeInitialTransform_Internal(IntPtr @this, int NodeID);

		// Token: 0x0601BDF3 RID: 114163
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetNodeEnableDissolve_Internal(IntPtr @this, int NodeID);

		// Token: 0x0601BDF4 RID: 114164
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetNodeCurSpeed_Internal(IntPtr @this, int NodeID);

		// Token: 0x0601BDF5 RID: 114165
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetNodeCount_Internal(IntPtr @this);

		// Token: 0x0601BDF6 RID: 114166
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetNodeComponent_Internal(IntPtr @this, int NodeID);

		// Token: 0x0601BDF7 RID: 114167
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetNodeByName_Internal(IntPtr @this, in FString NodeName, IntPtr OutNode);

		// Token: 0x0601BDF8 RID: 114168
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetNode_Internal(IntPtr @this, int NodeID, IntPtr OutNode);

		// Token: 0x0601BDF9 RID: 114169
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetAllParentWeights_Internal(IntPtr @this, int NodeID);

		// Token: 0x0601BDFA RID: 114170
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetAllNodes_Internal(IntPtr @this);

		// Token: 0x0601BDFB RID: 114171
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetAllNodeIDs_Internal(IntPtr @this);

		// Token: 0x0601BDFC RID: 114172
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetAfterDestroyedMeshes_Internal(IntPtr @this, int NodeID);

		// Token: 0x0601BDFD RID: 114173
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetAfterDestroyedActors_Internal(IntPtr @this, int NodeID);

		// Token: 0x0601BDFE RID: 114174
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __FindNodeIDByOwnerComponent_Internal(IntPtr @this, IntPtr OwnerComponent);

		// Token: 0x0601BDFF RID: 114175
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __FindNodeIDByName_Internal(IntPtr @this, in FString NodeName);

		// Token: 0x0601BE00 RID: 114176
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearWaitingShatterQueue_Internal(IntPtr @this);

		// Token: 0x0601BE01 RID: 114177
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearWaitingDitherQueue_Internal(IntPtr @this);

		// Token: 0x0601BE02 RID: 114178
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearWaitingDestroyedQueue_Internal(IntPtr @this);

		// Token: 0x0601BE03 RID: 114179
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearCheckShatterStateQueue_Internal(IntPtr @this);

		// Token: 0x0601BE04 RID: 114180
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearAllNodes_Internal(IntPtr @this);

		// Token: 0x0601BE05 RID: 114181
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearAfterDestroyedMeshes_Internal(IntPtr @this, int NodeID);

		// Token: 0x0601BE06 RID: 114182
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearAfterDestroyedActors_Internal(IntPtr @this, int NodeID);

		// Token: 0x0601BE07 RID: 114183
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __CheckShouldDestroy_Internal(IntPtr @this, int NodeID, float DestroyThreshold);

		// Token: 0x0601BE08 RID: 114184
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddParentToNode_Internal(IntPtr @this, int ChildNodeID, int ParentNodeID);

		// Token: 0x0601BE09 RID: 114185
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddNode_Internal(IntPtr @this, int NodeID, IntPtr OwnerComponent, in FTransform InitialTransform, in FString NodeName);

		// Token: 0x0601BE0A RID: 114186
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddAfterDestroyedMesh_Internal(IntPtr @this, int NodeID, IntPtr Mesh);

		// Token: 0x0601BE0B RID: 114187
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddAfterDestroyedActor_Internal(IntPtr @this, int NodeID, IntPtr Actor);

		// Token: 0x0601BE0C RID: 114188 RVA: 0x0029033C File Offset: 0x0028E53C
		static ASimpleShatterActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.SimpleShatterActor");
		}

		// Token: 0x0601BE0D RID: 114189 RVA: 0x0029034A File Offset: 0x0028E54A
		protected ASimpleShatterActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400EF6A RID: 61290
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.SimpleShatterActor";

		// Token: 0x0400EF6B RID: 61291
		private static IntPtr _ClassPtr;

		// Token: 0x0400EF6C RID: 61292
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400EF6D RID: 61293
		internal static int __PropertyOffset_Nodes;

		// Token: 0x0400EF6E RID: 61294
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<int, FSimpleShatterNode> _Nodes;

		// Token: 0x0400EF6F RID: 61295
		internal static int __PropertyOffset_NodeNameToID;

		// Token: 0x0400EF70 RID: 61296
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<string, int> _NodeNameToID;

		// Token: 0x0400EF71 RID: 61297
		internal static int __PropertyOffset_WaitingDestroyedQueue;

		// Token: 0x0400EF72 RID: 61298
		[Nullable(2)]
		private TArray<int> _WaitingDestroyedQueue;

		// Token: 0x0400EF73 RID: 61299
		internal static int __PropertyOffset_WaitingShatterQueue;

		// Token: 0x0400EF74 RID: 61300
		[Nullable(2)]
		private TArray<int> _WaitingShatterQueue;

		// Token: 0x0400EF75 RID: 61301
		internal static int __PropertyOffset_CheckShatterStateQueue;

		// Token: 0x0400EF76 RID: 61302
		[Nullable(2)]
		private TArray<int> _CheckShatterStateQueue;

		// Token: 0x0400EF77 RID: 61303
		internal static int __PropertyOffset_WaitingDitherQueue;

		// Token: 0x0400EF78 RID: 61304
		[Nullable(2)]
		private TArray<int> _WaitingDitherQueue;

		// Token: 0x0400EF79 RID: 61305
		internal static int __PropertyOffset_WaitingDitherTime;

		// Token: 0x0400EF7A RID: 61306
		internal static int __PropertyOffset_Dither;
	}
}
