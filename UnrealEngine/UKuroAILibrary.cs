using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020002DC RID: 732
	[UnrealObjectPath("/Script/KuroAI.KuroAILibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroAILibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06004EDB RID: 20187 RVA: 0x0006E305 File Offset: 0x0006C505
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroAILibrary._ClassPtr;
		}

		// Token: 0x06004EDC RID: 20188 RVA: 0x0006E314 File Offset: 0x0006C514
		public UKuroAILibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroAILibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06004EDD RID: 20189 RVA: 0x0006E33C File Offset: 0x0006C53C
		[NullableContext(1)]
		public UKuroAILibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroAILibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06004EDE RID: 20190 RVA: 0x0006E370 File Offset: 0x0006C570
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static void SetBtNodePropertyFromString([Nullable(2)] UBTNode TaskNode, FName PropertyName, string NewValue)
		{
			UKuroAILibrary.__SetBtNodePropertyFromString_FunctionParams* ptr = stackalloc UKuroAILibrary.__SetBtNodePropertyFromString_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(UKuroAILibrary.__SetBtNodePropertyFromString_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroAILibrary.__SetBtNodePropertyFromString_NativeFunctionPtr, (void*)ptr, 1);
			ptr->TaskNode = ((TaskNode != null) ? TaskNode.NativePtr : IntPtr.Zero);
			ptr->PropertyName = PropertyName;
			FString.CopyFrom((void*)(&ptr->NewValue), NewValue);
			UnrealReflectionUtils.CallUFunction(UKuroAILibrary._ClassDefaultObjectPtr, UKuroAILibrary.__SetBtNodePropertyFromString_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UKuroAILibrary.__SetBtNodePropertyFromString_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06004EDF RID: 20191 RVA: 0x0006E3EC File Offset: 0x0006C5EC
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static bool SaveBehaviorTreeNodeInfoWithSubtree(UBehaviorTreeComponent BTComp, ref FBtSaveLoadRecord OutRecord)
		{
			UKuroAILibrary.__SaveBehaviorTreeNodeInfoWithSubtree_FunctionParams* ptr = stackalloc UKuroAILibrary.__SaveBehaviorTreeNodeInfoWithSubtree_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UKuroAILibrary.__SaveBehaviorTreeNodeInfoWithSubtree_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroAILibrary.__SaveBehaviorTreeNodeInfoWithSubtree_NativeFunctionPtr, (void*)ptr, 1);
			ptr->BTComp = ((BTComp != null) ? BTComp.NativePtr : IntPtr.Zero);
			if (OutRecord != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FBtSaveLoadRecord.StaticStruct(), &ptr->OutRecord, OutRecord.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(UKuroAILibrary._ClassDefaultObjectPtr, UKuroAILibrary.__SaveBehaviorTreeNodeInfoWithSubtree_NativeFunctionPtr, (void*)ptr);
			if (OutRecord != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FBtSaveLoadRecord.StaticStruct(), OutRecord.NativePtr, &ptr->OutRecord, 1, false);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UKuroAILibrary.__SaveBehaviorTreeNodeInfoWithSubtree_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x06004EE0 RID: 20192 RVA: 0x0006E4A0 File Offset: 0x0006C6A0
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static bool SaveBehaviorTreeNodeInfo(UBehaviorTreeComponent BTComp, ref TMap<int, int> OutSavedInfoMap, int MaxNodeNum = 10000)
		{
			UKuroAILibrary.__SaveBehaviorTreeNodeInfo_FunctionParams* ptr = stackalloc UKuroAILibrary.__SaveBehaviorTreeNodeInfo_FunctionParams[(UIntPtr)111] + 15L / (long)sizeof(UKuroAILibrary.__SaveBehaviorTreeNodeInfo_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroAILibrary.__SaveBehaviorTreeNodeInfo_NativeFunctionPtr, (void*)ptr, 1);
			ptr->BTComp = ((BTComp != null) ? BTComp.NativePtr : IntPtr.Zero);
			TMap<int, int> tmap = OutSavedInfoMap;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->OutSavedInfoMap);
			}
			ptr->MaxNodeNum = MaxNodeNum;
			UnrealReflectionUtils.CallUFunction(UKuroAILibrary._ClassDefaultObjectPtr, UKuroAILibrary.__SaveBehaviorTreeNodeInfo_NativeFunctionPtr, (void*)ptr);
			TMap<int, int> tmap2 = OutSavedInfoMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->OutSavedInfoMap);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UKuroAILibrary.__SaveBehaviorTreeNodeInfo_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x06004EE1 RID: 20193 RVA: 0x0006E53C File Offset: 0x0006C73C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static void ResetRandomNode(UBehaviorTreeComponent BTComp, UBTNode Node, TArray<int> WeightsOverride)
		{
			UKuroAILibrary.__ResetRandomNode_FunctionParams* ptr = stackalloc UKuroAILibrary.__ResetRandomNode_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UKuroAILibrary.__ResetRandomNode_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroAILibrary.__ResetRandomNode_NativeFunctionPtr, (void*)ptr, 1);
			ptr->BTComp = ((BTComp != null) ? BTComp.NativePtr : IntPtr.Zero);
			ptr->Node = ((Node != null) ? Node.NativePtr : IntPtr.Zero);
			if (WeightsOverride != null)
			{
				WeightsOverride.CopyTo(&ptr->WeightsOverride, default(UScriptStructStackOnlyPtr));
			}
			UnrealReflectionUtils.CallUFunction(UKuroAILibrary._ClassDefaultObjectPtr, UKuroAILibrary.__ResetRandomNode_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UKuroAILibrary.__ResetRandomNode_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06004EE2 RID: 20194 RVA: 0x0006E5D0 File Offset: 0x0006C7D0
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static bool LoadBehaviorTreeNodeInfoFromRecordItem(UBehaviorTreeComponent BTComp, in FBtSaveLoadRecordItem InItem)
		{
			UKuroAILibrary.__LoadBehaviorTreeNodeInfoFromRecordItem_FunctionParams* ptr = stackalloc UKuroAILibrary.__LoadBehaviorTreeNodeInfoFromRecordItem_FunctionParams[(UIntPtr)119] + 15L / (long)sizeof(UKuroAILibrary.__LoadBehaviorTreeNodeInfoFromRecordItem_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroAILibrary.__LoadBehaviorTreeNodeInfoFromRecordItem_NativeFunctionPtr, (void*)ptr, 1);
			ptr->BTComp = ((BTComp != null) ? BTComp.NativePtr : IntPtr.Zero);
			if (InItem != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FBtSaveLoadRecordItem.StaticStruct(), &ptr->InItem, InItem.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(UKuroAILibrary._ClassDefaultObjectPtr, UKuroAILibrary.__LoadBehaviorTreeNodeInfoFromRecordItem_NativeFunctionPtr, (void*)ptr);
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UKuroAILibrary.__LoadBehaviorTreeNodeInfoFromRecordItem_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x06004EE3 RID: 20195 RVA: 0x0006E660 File Offset: 0x0006C860
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static bool LoadBehaviorTreeNodeInfo(UBehaviorTreeComponent BTComp, in TMap<int, int> InSavedInfoMap, int MaxNodeNum = 10000)
		{
			UKuroAILibrary.__LoadBehaviorTreeNodeInfo_FunctionParams* ptr = stackalloc UKuroAILibrary.__LoadBehaviorTreeNodeInfo_FunctionParams[(UIntPtr)111] + 15L / (long)sizeof(UKuroAILibrary.__LoadBehaviorTreeNodeInfo_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroAILibrary.__LoadBehaviorTreeNodeInfo_NativeFunctionPtr, (void*)ptr, 1);
			ptr->BTComp = ((BTComp != null) ? BTComp.NativePtr : IntPtr.Zero);
			TMap<int, int> tmap = InSavedInfoMap;
			if (tmap != null)
			{
				tmap.MoveTo(&ptr->InSavedInfoMap);
			}
			ptr->MaxNodeNum = MaxNodeNum;
			UnrealReflectionUtils.CallUFunction(UKuroAILibrary._ClassDefaultObjectPtr, UKuroAILibrary.__LoadBehaviorTreeNodeInfo_NativeFunctionPtr, (void*)ptr);
			TMap<int, int> tmap2 = InSavedInfoMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->InSavedInfoMap);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UKuroAILibrary.__LoadBehaviorTreeNodeInfo_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x06004EE4 RID: 20196 RVA: 0x0006E6FC File Offset: 0x0006C8FC
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static UBTNode GetNodeFromSubtree(UBehaviorTreeComponent BTComp, int SubTreeNodeId, int NodeId)
		{
			UKuroAILibrary.__GetNodeFromSubtree_FunctionParams* ptr = stackalloc UKuroAILibrary.__GetNodeFromSubtree_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UKuroAILibrary.__GetNodeFromSubtree_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroAILibrary.__GetNodeFromSubtree_NativeFunctionPtr, (void*)ptr, 1);
			ptr->BTComp = ((BTComp != null) ? BTComp.NativePtr : IntPtr.Zero);
			ptr->SubTreeNodeId = SubTreeNodeId;
			ptr->NodeId = NodeId;
			UnrealReflectionUtils.CallUFunction(UKuroAILibrary._ClassDefaultObjectPtr, UKuroAILibrary.__GetNodeFromSubtree_NativeFunctionPtr, (void*)ptr);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UBTNode>(ptr->__Result);
		}

		// Token: 0x06004EE5 RID: 20197 RVA: 0x0006E76C File Offset: 0x0006C96C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static UBTNode GetNodeFromBehaviorTree(UBehaviorTreeComponent BTComp, int NodeId)
		{
			UKuroAILibrary.__GetNodeFromBehaviorTree_FunctionParams* ptr = stackalloc UKuroAILibrary.__GetNodeFromBehaviorTree_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UKuroAILibrary.__GetNodeFromBehaviorTree_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroAILibrary.__GetNodeFromBehaviorTree_NativeFunctionPtr, (void*)ptr, 1);
			ptr->BTComp = ((BTComp != null) ? BTComp.NativePtr : IntPtr.Zero);
			ptr->NodeId = NodeId;
			UnrealReflectionUtils.CallUFunction(UKuroAILibrary._ClassDefaultObjectPtr, UKuroAILibrary.__GetNodeFromBehaviorTree_NativeFunctionPtr, (void*)ptr);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UBTNode>(ptr->__Result);
		}

		// Token: 0x06004EE6 RID: 20198 RVA: 0x0006E7D4 File Offset: 0x0006C9D4
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static UBTNode GetCurrentRootNode(UBehaviorTreeComponent BTComp)
		{
			UKuroAILibrary.__GetCurrentRootNode_FunctionParams* ptr = stackalloc UKuroAILibrary.__GetCurrentRootNode_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroAILibrary.__GetCurrentRootNode_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroAILibrary.__GetCurrentRootNode_NativeFunctionPtr, (void*)ptr, 1);
			ptr->BTComp = ((BTComp != null) ? BTComp.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(UKuroAILibrary._ClassDefaultObjectPtr, UKuroAILibrary.__GetCurrentRootNode_NativeFunctionPtr, (void*)ptr);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UBTNode>(ptr->__Result);
		}

		// Token: 0x06004EE7 RID: 20199 RVA: 0x0006E834 File Offset: 0x0006CA34
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static void DumpBtNodeAllProperties(UBTNode TaskNode)
		{
			UKuroAILibrary.__DumpBtNodeAllProperties_FunctionParams* ptr = stackalloc UKuroAILibrary.__DumpBtNodeAllProperties_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UKuroAILibrary.__DumpBtNodeAllProperties_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroAILibrary.__DumpBtNodeAllProperties_NativeFunctionPtr, (void*)ptr, 1);
			ptr->TaskNode = ((TaskNode != null) ? TaskNode.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(UKuroAILibrary._ClassDefaultObjectPtr, UKuroAILibrary.__DumpBtNodeAllProperties_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06004EE8 RID: 20200 RVA: 0x0006E888 File Offset: 0x0006CA88
		static UKuroAILibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroAI.KuroAILibrary");
		}

		// Token: 0x06004EE9 RID: 20201 RVA: 0x0006E896 File Offset: 0x0006CA96
		protected UKuroAILibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001F8E RID: 8078
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroAI.KuroAILibrary";

		// Token: 0x04001F8F RID: 8079
		private static IntPtr _ClassPtr;

		// Token: 0x04001F90 RID: 8080
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04001F91 RID: 8081
		private static IntPtr __SetBtNodePropertyFromString_NativeFunctionPtr;

		// Token: 0x04001F92 RID: 8082
		private static IntPtr __SaveBehaviorTreeNodeInfoWithSubtree_NativeFunctionPtr;

		// Token: 0x04001F93 RID: 8083
		private static IntPtr __SaveBehaviorTreeNodeInfo_NativeFunctionPtr;

		// Token: 0x04001F94 RID: 8084
		private static IntPtr __ResetRandomNode_NativeFunctionPtr;

		// Token: 0x04001F95 RID: 8085
		private static IntPtr __LoadBehaviorTreeNodeInfoFromRecordItem_NativeFunctionPtr;

		// Token: 0x04001F96 RID: 8086
		private static IntPtr __LoadBehaviorTreeNodeInfo_NativeFunctionPtr;

		// Token: 0x04001F97 RID: 8087
		private static IntPtr __GetNodeFromSubtree_NativeFunctionPtr;

		// Token: 0x04001F98 RID: 8088
		private static IntPtr __GetNodeFromBehaviorTree_NativeFunctionPtr;

		// Token: 0x04001F99 RID: 8089
		private static IntPtr __GetCurrentRootNode_NativeFunctionPtr;

		// Token: 0x04001F9A RID: 8090
		private static IntPtr __DumpBtNodeAllProperties_NativeFunctionPtr;

		// Token: 0x02000A06 RID: 2566
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __SetBtNodePropertyFromString_FunctionParams
		{
			// Token: 0x040059B0 RID: 22960
			[FieldOffset(0)]
			public IntPtr TaskNode;

			// Token: 0x040059B1 RID: 22961
			[FieldOffset(8)]
			public FName PropertyName;

			// Token: 0x040059B2 RID: 22962
			[FieldOffset(24)]
			public FString NewValue;
		}

		// Token: 0x02000A07 RID: 2567
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __SaveBehaviorTreeNodeInfoWithSubtree_FunctionParams
		{
			// Token: 0x040059B3 RID: 22963
			[FieldOffset(0)]
			public IntPtr BTComp;

			// Token: 0x040059B4 RID: 22964
			[FieldOffset(8)]
			public byte OutRecord;

			// Token: 0x040059B5 RID: 22965
			[FieldOffset(24)]
			public bool __Result;
		}

		// Token: 0x02000A08 RID: 2568
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 96)]
		protected ref struct __SaveBehaviorTreeNodeInfo_FunctionParams
		{
			// Token: 0x040059B6 RID: 22966
			[FieldOffset(0)]
			public IntPtr BTComp;

			// Token: 0x040059B7 RID: 22967
			[FieldOffset(8)]
			public byte OutSavedInfoMap;

			// Token: 0x040059B8 RID: 22968
			[FieldOffset(88)]
			public int MaxNodeNum;

			// Token: 0x040059B9 RID: 22969
			[FieldOffset(92)]
			public bool __Result;
		}

		// Token: 0x02000A09 RID: 2569
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __ResetRandomNode_FunctionParams
		{
			// Token: 0x040059BA RID: 22970
			[FieldOffset(0)]
			public IntPtr BTComp;

			// Token: 0x040059BB RID: 22971
			[FieldOffset(8)]
			public IntPtr Node;

			// Token: 0x040059BC RID: 22972
			[FieldOffset(16)]
			public byte WeightsOverride;
		}

		// Token: 0x02000A0A RID: 2570
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 104)]
		protected ref struct __LoadBehaviorTreeNodeInfoFromRecordItem_FunctionParams
		{
			// Token: 0x040059BD RID: 22973
			[FieldOffset(0)]
			public IntPtr BTComp;

			// Token: 0x040059BE RID: 22974
			[FieldOffset(8)]
			public byte InItem;

			// Token: 0x040059BF RID: 22975
			[FieldOffset(96)]
			public bool __Result;
		}

		// Token: 0x02000A0B RID: 2571
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 96)]
		protected ref struct __LoadBehaviorTreeNodeInfo_FunctionParams
		{
			// Token: 0x040059C0 RID: 22976
			[FieldOffset(0)]
			public IntPtr BTComp;

			// Token: 0x040059C1 RID: 22977
			[FieldOffset(8)]
			public byte InSavedInfoMap;

			// Token: 0x040059C2 RID: 22978
			[FieldOffset(88)]
			public int MaxNodeNum;

			// Token: 0x040059C3 RID: 22979
			[FieldOffset(92)]
			public bool __Result;
		}

		// Token: 0x02000A0C RID: 2572
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __GetNodeFromSubtree_FunctionParams
		{
			// Token: 0x040059C4 RID: 22980
			[FieldOffset(0)]
			public IntPtr BTComp;

			// Token: 0x040059C5 RID: 22981
			[FieldOffset(8)]
			public int SubTreeNodeId;

			// Token: 0x040059C6 RID: 22982
			[FieldOffset(12)]
			public int NodeId;

			// Token: 0x040059C7 RID: 22983
			[FieldOffset(16)]
			public IntPtr __Result;
		}

		// Token: 0x02000A0D RID: 2573
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __GetNodeFromBehaviorTree_FunctionParams
		{
			// Token: 0x040059C8 RID: 22984
			[FieldOffset(0)]
			public IntPtr BTComp;

			// Token: 0x040059C9 RID: 22985
			[FieldOffset(8)]
			public int NodeId;

			// Token: 0x040059CA RID: 22986
			[FieldOffset(16)]
			public IntPtr __Result;
		}

		// Token: 0x02000A0E RID: 2574
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetCurrentRootNode_FunctionParams
		{
			// Token: 0x040059CB RID: 22987
			[FieldOffset(0)]
			public IntPtr BTComp;

			// Token: 0x040059CC RID: 22988
			[FieldOffset(8)]
			public IntPtr __Result;
		}

		// Token: 0x02000A0F RID: 2575
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __DumpBtNodeAllProperties_FunctionParams
		{
			// Token: 0x040059CD RID: 22989
			[FieldOffset(0)]
			public IntPtr TaskNode;
		}
	}
}
