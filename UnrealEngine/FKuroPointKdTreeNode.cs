using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001A37 RID: 6711
	[UnrealObjectPath("/Script/KuroPointCloud.KuroPointKdTreeNode")]
	[UnrealStructLayout(44, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 44)]
	public class FKuroPointKdTreeNode : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06018D7F RID: 101759 RVA: 0x0024B3AF File Offset: 0x002495AF
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroPointKdTreeNode._ScriptStructPtr != 0) ? FKuroPointKdTreeNode._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroPointCloud.KuroPointKdTreeNode", ref FKuroPointKdTreeNode._ScriptStructPtr);
		}

		// Token: 0x17006268 RID: 25192
		// (get) Token: 0x06018D80 RID: 101760 RVA: 0x0024B3D3 File Offset: 0x002495D3
		// (set) Token: 0x06018D81 RID: 101761 RVA: 0x0024B3E3 File Offset: 0x002495E3
		public unsafe int LeftNodeIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroPointKdTreeNode.__PropertyOffset_LeftNodeIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroPointKdTreeNode.__PropertyOffset_LeftNodeIndex) = value;
			}
		}

		// Token: 0x17006269 RID: 25193
		// (get) Token: 0x06018D82 RID: 101762 RVA: 0x0024B3F4 File Offset: 0x002495F4
		// (set) Token: 0x06018D83 RID: 101763 RVA: 0x0024B404 File Offset: 0x00249604
		public unsafe int RightNodeIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroPointKdTreeNode.__PropertyOffset_RightNodeIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroPointKdTreeNode.__PropertyOffset_RightNodeIndex) = value;
			}
		}

		// Token: 0x1700626A RID: 25194
		// (get) Token: 0x06018D84 RID: 101764 RVA: 0x0024B415 File Offset: 0x00249615
		// (set) Token: 0x06018D85 RID: 101765 RVA: 0x0024B425 File Offset: 0x00249625
		public unsafe int PointArrayBegin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroPointKdTreeNode.__PropertyOffset_PointArrayBegin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroPointKdTreeNode.__PropertyOffset_PointArrayBegin) = value;
			}
		}

		// Token: 0x1700626B RID: 25195
		// (get) Token: 0x06018D86 RID: 101766 RVA: 0x0024B436 File Offset: 0x00249636
		// (set) Token: 0x06018D87 RID: 101767 RVA: 0x0024B446 File Offset: 0x00249646
		public unsafe int PointArrayEnd
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroPointKdTreeNode.__PropertyOffset_PointArrayEnd);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroPointKdTreeNode.__PropertyOffset_PointArrayEnd) = value;
			}
		}

		// Token: 0x1700626C RID: 25196
		// (get) Token: 0x06018D88 RID: 101768 RVA: 0x0024B457 File Offset: 0x00249657
		// (set) Token: 0x06018D89 RID: 101769 RVA: 0x0024B46B File Offset: 0x0024966B
		public unsafe FBox BoundingBox
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroPointKdTreeNode.__PropertyOffset_BoundingBox);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroPointKdTreeNode.__PropertyOffset_BoundingBox) = value;
			}
		}

		// Token: 0x06018D8A RID: 101770 RVA: 0x0024B480 File Offset: 0x00249680
		public FKuroPointKdTreeNode()
		{
		}

		// Token: 0x06018D8B RID: 101771 RVA: 0x0024B488 File Offset: 0x00249688
		public FKuroPointKdTreeNode(int LeftNodeIndex, int RightNodeIndex, int PointArrayBegin, int PointArrayEnd, FBox BoundingBox)
		{
			this.LeftNodeIndex = LeftNodeIndex;
			this.RightNodeIndex = RightNodeIndex;
			this.PointArrayBegin = PointArrayBegin;
			this.PointArrayEnd = PointArrayEnd;
			this.BoundingBox = BoundingBox;
		}

		// Token: 0x06018D8C RID: 101772 RVA: 0x0024B4B5 File Offset: 0x002496B5
		protected override IntPtr GetUStructPtr()
		{
			return FKuroPointKdTreeNode.StaticStruct();
		}

		// Token: 0x06018D8D RID: 101773 RVA: 0x0024B4C1 File Offset: 0x002496C1
		[NullableContext(2)]
		public FKuroPointKdTreeNode(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06018D8E RID: 101774 RVA: 0x0024B4CB File Offset: 0x002496CB
		public FKuroPointKdTreeNode(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06018D8F RID: 101775 RVA: 0x0024B4D6 File Offset: 0x002496D6
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroPointKdTreeNode(Pointer, false, true);
		}

		// Token: 0x06018D90 RID: 101776 RVA: 0x0024B4E0 File Offset: 0x002496E0
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroPointKdTreeNode(Pointer, MemoryOwner);
		}

		// Token: 0x0400D6C5 RID: 54981
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroPointCloud.KuroPointKdTreeNode";

		// Token: 0x0400D6C6 RID: 54982
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400D6C7 RID: 54983
		internal static int __PropertyOffset_LeftNodeIndex;

		// Token: 0x0400D6C8 RID: 54984
		internal static int __PropertyOffset_RightNodeIndex;

		// Token: 0x0400D6C9 RID: 54985
		internal static int __PropertyOffset_PointArrayBegin;

		// Token: 0x0400D6CA RID: 54986
		internal static int __PropertyOffset_PointArrayEnd;

		// Token: 0x0400D6CB RID: 54987
		internal static int __PropertyOffset_BoundingBox;
	}
}
