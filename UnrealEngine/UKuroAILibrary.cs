using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020015FC RID: 5628
	[UnrealObjectPath("/Script/KuroAI.KuroAILibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroAILibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601441A RID: 82970 RVA: 0x001DBE89 File Offset: 0x001DA089
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroAILibrary._ClassPtr;
		}

		// Token: 0x0601441B RID: 82971 RVA: 0x001DBE98 File Offset: 0x001DA098
		public UKuroAILibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroAILibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601441C RID: 82972 RVA: 0x001DBEC0 File Offset: 0x001DA0C0
		[NullableContext(1)]
		public UKuroAILibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroAILibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601441D RID: 82973 RVA: 0x001DBEF4 File Offset: 0x001DA0F4
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void SetBtNodePropertyFromString([Nullable(2)] UBTNode TaskNode, FName PropertyName, string NewValue)
		{
			UKuroAILibrary.__SetBtNodePropertyFromString_FunctionParams* ptr = stackalloc UKuroAILibrary.__SetBtNodePropertyFromString_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(UKuroAILibrary.__SetBtNodePropertyFromString_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroAILibrary.__SetBtNodePropertyFromString_NativeFunctionPtr, (void*)ptr, 1);
			ptr->TaskNode = ((TaskNode != null) ? TaskNode.NativePtr : IntPtr.Zero);
			ptr->PropertyName = PropertyName;
			FString.CopyFrom((void*)(&ptr->NewValue), NewValue);
			UnrealReflectionUtils.CallUFunction(UKuroAILibrary._ClassDefaultObjectPtr, UKuroAILibrary.__SetBtNodePropertyFromString_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UKuroAILibrary.__SetBtNodePropertyFromString_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601441E RID: 82974 RVA: 0x001DBF70 File Offset: 0x001DA170
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool SaveBehaviorTreeNodeInfoWithSubtree(UBehaviorTreeComponent BTComp, ref FBtSaveLoadRecord OutRecord)
		{
			UKuroAILibrary.__SaveBehaviorTreeNodeInfoWithSubtree_FunctionParams* ptr = stackalloc UKuroAILibrary.__SaveBehaviorTreeNodeInfoWithSubtree_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UKuroAILibrary.__SaveBehaviorTreeNodeInfoWithSubtree_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroAILibrary.__SaveBehaviorTreeNodeInfoWithSubtree_NativeFunctionPtr, (void*)ptr, 1);
			ptr->BTComp = ((BTComp != null) ? BTComp.NativePtr : IntPtr.Zero);
			if (OutRecord != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FBtSaveLoadRecord.StaticStruct(), &ptr->OutRecord, OutRecord.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(UKuroAILibrary._ClassDefaultObjectPtr, UKuroAILibrary.__SaveBehaviorTreeNodeInfoWithSubtree_NativeFunctionPtr, (void*)ptr, 0);
			if (OutRecord != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FBtSaveLoadRecord.StaticStruct(), OutRecord.NativePtr, &ptr->OutRecord, 1, false);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UKuroAILibrary.__SaveBehaviorTreeNodeInfoWithSubtree_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601441F RID: 82975 RVA: 0x001DC024 File Offset: 0x001DA224
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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
			UnrealReflectionUtils.CallUFunction(UKuroAILibrary._ClassDefaultObjectPtr, UKuroAILibrary.__SaveBehaviorTreeNodeInfo_NativeFunctionPtr, (void*)ptr, 0);
			TMap<int, int> tmap2 = OutSavedInfoMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->OutSavedInfoMap);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UKuroAILibrary.__SaveBehaviorTreeNodeInfo_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x06014420 RID: 82976 RVA: 0x001DC0C0 File Offset: 0x001DA2C0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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
			UnrealReflectionUtils.CallUFunction(UKuroAILibrary._ClassDefaultObjectPtr, UKuroAILibrary.__ResetRandomNode_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UKuroAILibrary.__ResetRandomNode_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06014421 RID: 82977 RVA: 0x001DC158 File Offset: 0x001DA358
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool LoadBehaviorTreeNodeInfoFromRecordItem(UBehaviorTreeComponent BTComp, in FBtSaveLoadRecordItem InItem)
		{
			UKuroAILibrary.__LoadBehaviorTreeNodeInfoFromRecordItem_FunctionParams* ptr = stackalloc UKuroAILibrary.__LoadBehaviorTreeNodeInfoFromRecordItem_FunctionParams[(UIntPtr)119] + 15L / (long)sizeof(UKuroAILibrary.__LoadBehaviorTreeNodeInfoFromRecordItem_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroAILibrary.__LoadBehaviorTreeNodeInfoFromRecordItem_NativeFunctionPtr, (void*)ptr, 1);
			ptr->BTComp = ((BTComp != null) ? BTComp.NativePtr : IntPtr.Zero);
			if (InItem != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FBtSaveLoadRecordItem.StaticStruct(), &ptr->InItem, InItem.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(UKuroAILibrary._ClassDefaultObjectPtr, UKuroAILibrary.__LoadBehaviorTreeNodeInfoFromRecordItem_NativeFunctionPtr, (void*)ptr, 0);
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UKuroAILibrary.__LoadBehaviorTreeNodeInfoFromRecordItem_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x06014422 RID: 82978 RVA: 0x001DC1E8 File Offset: 0x001DA3E8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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
			UnrealReflectionUtils.CallUFunction(UKuroAILibrary._ClassDefaultObjectPtr, UKuroAILibrary.__LoadBehaviorTreeNodeInfo_NativeFunctionPtr, (void*)ptr, 0);
			TMap<int, int> tmap2 = InSavedInfoMap;
			if (tmap2 != null)
			{
				tmap2.MoveAssign(&ptr->InSavedInfoMap);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UKuroAILibrary.__LoadBehaviorTreeNodeInfo_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x06014423 RID: 82979 RVA: 0x001DC284 File Offset: 0x001DA484
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static UBTNode GetNodeFromSubtree(UBehaviorTreeComponent BTComp, int SubTreeNodeId, int NodeId)
		{
			UKuroAILibrary.__GetNodeFromSubtree_FunctionParams* ptr = stackalloc UKuroAILibrary.__GetNodeFromSubtree_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UKuroAILibrary.__GetNodeFromSubtree_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroAILibrary.__GetNodeFromSubtree_NativeFunctionPtr, (void*)ptr, 1);
			ptr->BTComp = ((BTComp != null) ? BTComp.NativePtr : IntPtr.Zero);
			ptr->SubTreeNodeId = SubTreeNodeId;
			ptr->NodeId = NodeId;
			UnrealReflectionUtils.CallUFunction(UKuroAILibrary._ClassDefaultObjectPtr, UKuroAILibrary.__GetNodeFromSubtree_NativeFunctionPtr, (void*)ptr, 0);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UBTNode>(ptr->__Result);
		}

		// Token: 0x06014424 RID: 82980 RVA: 0x001DC2F4 File Offset: 0x001DA4F4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static UBTNode GetNodeFromBehaviorTree(UBehaviorTreeComponent BTComp, int NodeId)
		{
			UKuroAILibrary.__GetNodeFromBehaviorTree_FunctionParams* ptr = stackalloc UKuroAILibrary.__GetNodeFromBehaviorTree_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UKuroAILibrary.__GetNodeFromBehaviorTree_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroAILibrary.__GetNodeFromBehaviorTree_NativeFunctionPtr, (void*)ptr, 1);
			ptr->BTComp = ((BTComp != null) ? BTComp.NativePtr : IntPtr.Zero);
			ptr->NodeId = NodeId;
			UnrealReflectionUtils.CallUFunction(UKuroAILibrary._ClassDefaultObjectPtr, UKuroAILibrary.__GetNodeFromBehaviorTree_NativeFunctionPtr, (void*)ptr, 0);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UBTNode>(ptr->__Result);
		}

		// Token: 0x06014425 RID: 82981 RVA: 0x001DC35C File Offset: 0x001DA55C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static UBTNode GetCurrentRootNode(UBehaviorTreeComponent BTComp)
		{
			UKuroAILibrary.__GetCurrentRootNode_FunctionParams* ptr = stackalloc UKuroAILibrary.__GetCurrentRootNode_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroAILibrary.__GetCurrentRootNode_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroAILibrary.__GetCurrentRootNode_NativeFunctionPtr, (void*)ptr, 1);
			ptr->BTComp = ((BTComp != null) ? BTComp.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(UKuroAILibrary._ClassDefaultObjectPtr, UKuroAILibrary.__GetCurrentRootNode_NativeFunctionPtr, (void*)ptr, 0);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UBTNode>(ptr->__Result);
		}

		// Token: 0x06014426 RID: 82982 RVA: 0x001DC3BC File Offset: 0x001DA5BC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void DumpBtNodeAllProperties(UBTNode TaskNode)
		{
			UKuroAILibrary.__DumpBtNodeAllProperties_FunctionParams* ptr = stackalloc UKuroAILibrary.__DumpBtNodeAllProperties_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UKuroAILibrary.__DumpBtNodeAllProperties_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroAILibrary.__DumpBtNodeAllProperties_NativeFunctionPtr, (void*)ptr, 1);
			ptr->TaskNode = ((TaskNode != null) ? TaskNode.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(UKuroAILibrary._ClassDefaultObjectPtr, UKuroAILibrary.__DumpBtNodeAllProperties_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06014427 RID: 82983 RVA: 0x001DC411 File Offset: 0x001DA611
		static UKuroAILibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroAI.KuroAILibrary");
		}

		// Token: 0x06014428 RID: 82984 RVA: 0x001DC41F File Offset: 0x001DA61F
		protected UKuroAILibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400B053 RID: 45139
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroAI.KuroAILibrary";

		// Token: 0x0400B054 RID: 45140
		private static IntPtr _ClassPtr;

		// Token: 0x0400B055 RID: 45141
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400B056 RID: 45142
		private static IntPtr __SetBtNodePropertyFromString_NativeFunctionPtr;

		// Token: 0x0400B057 RID: 45143
		private static IntPtr __SaveBehaviorTreeNodeInfoWithSubtree_NativeFunctionPtr;

		// Token: 0x0400B058 RID: 45144
		private static IntPtr __SaveBehaviorTreeNodeInfo_NativeFunctionPtr;

		// Token: 0x0400B059 RID: 45145
		private static IntPtr __ResetRandomNode_NativeFunctionPtr;

		// Token: 0x0400B05A RID: 45146
		private static IntPtr __LoadBehaviorTreeNodeInfoFromRecordItem_NativeFunctionPtr;

		// Token: 0x0400B05B RID: 45147
		private static IntPtr __LoadBehaviorTreeNodeInfo_NativeFunctionPtr;

		// Token: 0x0400B05C RID: 45148
		private static IntPtr __GetNodeFromSubtree_NativeFunctionPtr;

		// Token: 0x0400B05D RID: 45149
		private static IntPtr __GetNodeFromBehaviorTree_NativeFunctionPtr;

		// Token: 0x0400B05E RID: 45150
		private static IntPtr __GetCurrentRootNode_NativeFunctionPtr;

		// Token: 0x0400B05F RID: 45151
		private static IntPtr __DumpBtNodeAllProperties_NativeFunctionPtr;

		// Token: 0x02002ECD RID: 11981
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __SetBtNodePropertyFromString_FunctionParams
		{
			// Token: 0x040169D5 RID: 92629
			[FieldOffset(0)]
			public IntPtr TaskNode;

			// Token: 0x040169D6 RID: 92630
			[FieldOffset(8)]
			public FName PropertyName;

			// Token: 0x040169D7 RID: 92631
			[FieldOffset(24)]
			public FString NewValue;
		}

		// Token: 0x02002ECE RID: 11982
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __SaveBehaviorTreeNodeInfoWithSubtree_FunctionParams
		{
			// Token: 0x040169D8 RID: 92632
			[FieldOffset(0)]
			public IntPtr BTComp;

			// Token: 0x040169D9 RID: 92633
			[FieldOffset(8)]
			public byte OutRecord;

			// Token: 0x040169DA RID: 92634
			[FieldOffset(24)]
			public bool __Result;
		}

		// Token: 0x02002ECF RID: 11983
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 96)]
		protected ref struct __SaveBehaviorTreeNodeInfo_FunctionParams
		{
			// Token: 0x040169DB RID: 92635
			[FieldOffset(0)]
			public IntPtr BTComp;

			// Token: 0x040169DC RID: 92636
			[FieldOffset(8)]
			public byte OutSavedInfoMap;

			// Token: 0x040169DD RID: 92637
			[FieldOffset(88)]
			public int MaxNodeNum;

			// Token: 0x040169DE RID: 92638
			[FieldOffset(92)]
			public bool __Result;
		}

		// Token: 0x02002ED0 RID: 11984
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __ResetRandomNode_FunctionParams
		{
			// Token: 0x040169DF RID: 92639
			[FieldOffset(0)]
			public IntPtr BTComp;

			// Token: 0x040169E0 RID: 92640
			[FieldOffset(8)]
			public IntPtr Node;

			// Token: 0x040169E1 RID: 92641
			[FieldOffset(16)]
			public byte WeightsOverride;
		}

		// Token: 0x02002ED1 RID: 11985
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 104)]
		protected ref struct __LoadBehaviorTreeNodeInfoFromRecordItem_FunctionParams
		{
			// Token: 0x040169E2 RID: 92642
			[FieldOffset(0)]
			public IntPtr BTComp;

			// Token: 0x040169E3 RID: 92643
			[FieldOffset(8)]
			public byte InItem;

			// Token: 0x040169E4 RID: 92644
			[FieldOffset(96)]
			public bool __Result;
		}

		// Token: 0x02002ED2 RID: 11986
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 96)]
		protected ref struct __LoadBehaviorTreeNodeInfo_FunctionParams
		{
			// Token: 0x040169E5 RID: 92645
			[FieldOffset(0)]
			public IntPtr BTComp;

			// Token: 0x040169E6 RID: 92646
			[FieldOffset(8)]
			public byte InSavedInfoMap;

			// Token: 0x040169E7 RID: 92647
			[FieldOffset(88)]
			public int MaxNodeNum;

			// Token: 0x040169E8 RID: 92648
			[FieldOffset(92)]
			public bool __Result;
		}

		// Token: 0x02002ED3 RID: 11987
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __GetNodeFromSubtree_FunctionParams
		{
			// Token: 0x040169E9 RID: 92649
			[FieldOffset(0)]
			public IntPtr BTComp;

			// Token: 0x040169EA RID: 92650
			[FieldOffset(8)]
			public int SubTreeNodeId;

			// Token: 0x040169EB RID: 92651
			[FieldOffset(12)]
			public int NodeId;

			// Token: 0x040169EC RID: 92652
			[FieldOffset(16)]
			public IntPtr __Result;
		}

		// Token: 0x02002ED4 RID: 11988
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __GetNodeFromBehaviorTree_FunctionParams
		{
			// Token: 0x040169ED RID: 92653
			[FieldOffset(0)]
			public IntPtr BTComp;

			// Token: 0x040169EE RID: 92654
			[FieldOffset(8)]
			public int NodeId;

			// Token: 0x040169EF RID: 92655
			[FieldOffset(16)]
			public IntPtr __Result;
		}

		// Token: 0x02002ED5 RID: 11989
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetCurrentRootNode_FunctionParams
		{
			// Token: 0x040169F0 RID: 92656
			[FieldOffset(0)]
			public IntPtr BTComp;

			// Token: 0x040169F1 RID: 92657
			[FieldOffset(8)]
			public IntPtr __Result;
		}

		// Token: 0x02002ED6 RID: 11990
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __DumpBtNodeAllProperties_FunctionParams
		{
			// Token: 0x040169F2 RID: 92658
			[FieldOffset(0)]
			public IntPtr TaskNode;
		}
	}
}
