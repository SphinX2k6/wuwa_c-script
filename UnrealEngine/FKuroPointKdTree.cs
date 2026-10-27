using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001A36 RID: 6710
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroPointCloud.KuroPointKdTree")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 88)]
	public class FKuroPointKdTree : FKuroPointSpatialTree, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06018D6F RID: 101743 RVA: 0x0024B266 File Offset: 0x00249466
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroPointKdTree._ScriptStructPtr != 0) ? FKuroPointKdTree._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroPointCloud.KuroPointKdTree", ref FKuroPointKdTree._ScriptStructPtr);
		}

		// Token: 0x17006264 RID: 25188
		// (get) Token: 0x06018D70 RID: 101744 RVA: 0x0024B28A File Offset: 0x0024948A
		// (set) Token: 0x06018D71 RID: 101745 RVA: 0x0024B29A File Offset: 0x0024949A
		public unsafe int PointNumToStopDivide
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroPointKdTree.__PropertyOffset_PointNumToStopDivide);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroPointKdTree.__PropertyOffset_PointNumToStopDivide) = value;
			}
		}

		// Token: 0x17006265 RID: 25189
		// (get) Token: 0x06018D72 RID: 101746 RVA: 0x0024B2AB File Offset: 0x002494AB
		// (set) Token: 0x06018D73 RID: 101747 RVA: 0x0024B2BB File Offset: 0x002494BB
		public unsafe float BoxLengthToStopDivide
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroPointKdTree.__PropertyOffset_BoxLengthToStopDivide);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroPointKdTree.__PropertyOffset_BoxLengthToStopDivide) = value;
			}
		}

		// Token: 0x17006266 RID: 25190
		// (get) Token: 0x06018D74 RID: 101748 RVA: 0x0024B2CC File Offset: 0x002494CC
		// (set) Token: 0x06018D75 RID: 101749 RVA: 0x0024B30F File Offset: 0x0024950F
		public TArray<FKuroPointKdTreeNode> TreeNodes
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroPointKdTreeNode> result;
				if ((result = this._TreeNodes) == null)
				{
					result = (this._TreeNodes = new TArray<FKuroPointKdTreeNode>(base.NativePtr + (IntPtr)FKuroPointKdTree.__PropertyOffset_TreeNodes, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.TreeNodes.CopyAssign(value);
			}
		}

		// Token: 0x17006267 RID: 25191
		// (get) Token: 0x06018D76 RID: 101750 RVA: 0x0024B31D File Offset: 0x0024951D
		// (set) Token: 0x06018D77 RID: 101751 RVA: 0x0024B32D File Offset: 0x0024952D
		public unsafe int RootNodeId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroPointKdTree.__PropertyOffset_RootNodeId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroPointKdTree.__PropertyOffset_RootNodeId) = value;
			}
		}

		// Token: 0x06018D78 RID: 101752 RVA: 0x0024B33E File Offset: 0x0024953E
		public FKuroPointKdTree()
		{
		}

		// Token: 0x06018D79 RID: 101753 RVA: 0x0024B346 File Offset: 0x00249546
		public FKuroPointKdTree(int PointNumToStopDivide, float BoxLengthToStopDivide, TArray<FKuroPointKdTreeNode> TreeNodes, int RootNodeId, TArray<FPointData> PointCloudData, FBox MaxBound)
		{
			this.PointNumToStopDivide = PointNumToStopDivide;
			this.BoxLengthToStopDivide = BoxLengthToStopDivide;
			this.TreeNodes = TreeNodes;
			this.RootNodeId = RootNodeId;
			base.PointCloudData = PointCloudData;
			base.MaxBound = MaxBound;
		}

		// Token: 0x06018D7A RID: 101754 RVA: 0x0024B37B File Offset: 0x0024957B
		protected override IntPtr GetUStructPtr()
		{
			return FKuroPointKdTree.StaticStruct();
		}

		// Token: 0x06018D7B RID: 101755 RVA: 0x0024B387 File Offset: 0x00249587
		[NullableContext(2)]
		public FKuroPointKdTree(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06018D7C RID: 101756 RVA: 0x0024B391 File Offset: 0x00249591
		public FKuroPointKdTree(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06018D7D RID: 101757 RVA: 0x0024B39C File Offset: 0x0024959C
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroPointKdTree(Pointer, false, true);
		}

		// Token: 0x06018D7E RID: 101758 RVA: 0x0024B3A6 File Offset: 0x002495A6
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroPointKdTree(Pointer, MemoryOwner);
		}

		// Token: 0x0400D6BE RID: 54974
		public new const string __ObjectPath = "/Script/KuroPointCloud.KuroPointKdTree";

		// Token: 0x0400D6BF RID: 54975
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400D6C0 RID: 54976
		internal static int __PropertyOffset_PointNumToStopDivide;

		// Token: 0x0400D6C1 RID: 54977
		internal static int __PropertyOffset_BoxLengthToStopDivide;

		// Token: 0x0400D6C2 RID: 54978
		internal static int __PropertyOffset_TreeNodes;

		// Token: 0x0400D6C3 RID: 54979
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroPointKdTreeNode> _TreeNodes;

		// Token: 0x0400D6C4 RID: 54980
		internal static int __PropertyOffset_RootNodeId;
	}
}
