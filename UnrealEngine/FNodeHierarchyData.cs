using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020002C3 RID: 707
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AnimationCore.NodeHierarchyData")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 112)]
	public class FNodeHierarchyData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06002737 RID: 10039 RVA: 0x0003AD40 File Offset: 0x00038F40
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNodeHierarchyData._ScriptStructPtr != 0) ? FNodeHierarchyData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AnimationCore.NodeHierarchyData", ref FNodeHierarchyData._ScriptStructPtr);
		}

		// Token: 0x17000961 RID: 2401
		// (get) Token: 0x06002738 RID: 10040 RVA: 0x0003AD64 File Offset: 0x00038F64
		// (set) Token: 0x06002739 RID: 10041 RVA: 0x0003ADA7 File Offset: 0x00038FA7
		public TArray<FNodeObject> Nodes
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FNodeObject> result;
				if ((result = this._Nodes) == null)
				{
					result = (this._Nodes = new TArray<FNodeObject>(base.NativePtr + (IntPtr)FNodeHierarchyData.__PropertyOffset_Nodes, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Nodes.CopyAssign(value);
			}
		}

		// Token: 0x17000962 RID: 2402
		// (get) Token: 0x0600273A RID: 10042 RVA: 0x0003ADB8 File Offset: 0x00038FB8
		// (set) Token: 0x0600273B RID: 10043 RVA: 0x0003ADFB File Offset: 0x00038FFB
		public TArray<FTransform> Transforms
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FTransform> result;
				if ((result = this._Transforms) == null)
				{
					result = (this._Transforms = new TArray<FTransform>(base.NativePtr + (IntPtr)FNodeHierarchyData.__PropertyOffset_Transforms, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Transforms.CopyAssign(value);
			}
		}

		// Token: 0x17000963 RID: 2403
		// (get) Token: 0x0600273C RID: 10044 RVA: 0x0003AE0C File Offset: 0x0003900C
		// (set) Token: 0x0600273D RID: 10045 RVA: 0x0003AE4F File Offset: 0x0003904F
		public TMap<FName, int> NodeNameToIndexMapping
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, int> result;
				if ((result = this._NodeNameToIndexMapping) == null)
				{
					result = (this._NodeNameToIndexMapping = new TMap<FName, int>(base.NativePtr + (IntPtr)FNodeHierarchyData.__PropertyOffset_NodeNameToIndexMapping, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.NodeNameToIndexMapping.CopyAssign(value);
			}
		}

		// Token: 0x0600273E RID: 10046 RVA: 0x0003AE5D File Offset: 0x0003905D
		public FNodeHierarchyData()
		{
		}

		// Token: 0x0600273F RID: 10047 RVA: 0x0003AE65 File Offset: 0x00039065
		public FNodeHierarchyData(TArray<FNodeObject> Nodes, TArray<FTransform> Transforms, TMap<FName, int> NodeNameToIndexMapping)
		{
			this.Nodes = Nodes;
			this.Transforms = Transforms;
			this.NodeNameToIndexMapping = NodeNameToIndexMapping;
		}

		// Token: 0x06002740 RID: 10048 RVA: 0x0003AE82 File Offset: 0x00039082
		protected override IntPtr GetUStructPtr()
		{
			return FNodeHierarchyData.StaticStruct();
		}

		// Token: 0x06002741 RID: 10049 RVA: 0x0003AE8E File Offset: 0x0003908E
		[NullableContext(2)]
		public FNodeHierarchyData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002742 RID: 10050 RVA: 0x0003AE98 File Offset: 0x00039098
		public FNodeHierarchyData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002743 RID: 10051 RVA: 0x0003AEA3 File Offset: 0x000390A3
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNodeHierarchyData(Pointer, false, true);
		}

		// Token: 0x06002744 RID: 10052 RVA: 0x0003AEAD File Offset: 0x000390AD
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNodeHierarchyData(Pointer, MemoryOwner);
		}

		// Token: 0x04000F73 RID: 3955
		public const string __ObjectPath = "/Script/AnimationCore.NodeHierarchyData";

		// Token: 0x04000F74 RID: 3956
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04000F75 RID: 3957
		internal static int __PropertyOffset_Nodes;

		// Token: 0x04000F76 RID: 3958
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FNodeObject> _Nodes;

		// Token: 0x04000F77 RID: 3959
		internal static int __PropertyOffset_Transforms;

		// Token: 0x04000F78 RID: 3960
		[Nullable(2)]
		private TArray<FTransform> _Transforms;

		// Token: 0x04000F79 RID: 3961
		internal static int __PropertyOffset_NodeNameToIndexMapping;

		// Token: 0x04000F7A RID: 3962
		[Nullable(2)]
		private TMap<FName, int> _NodeNameToIndexMapping;
	}
}
