using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001A38 RID: 6712
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroPointCloud.KuroPointSpatialTree")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FKuroPointSpatialTree : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06018D91 RID: 101777 RVA: 0x0024B4E9 File Offset: 0x002496E9
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroPointSpatialTree._ScriptStructPtr != 0) ? FKuroPointSpatialTree._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroPointCloud.KuroPointSpatialTree", ref FKuroPointSpatialTree._ScriptStructPtr);
		}

		// Token: 0x1700626D RID: 25197
		// (get) Token: 0x06018D92 RID: 101778 RVA: 0x0024B510 File Offset: 0x00249710
		// (set) Token: 0x06018D93 RID: 101779 RVA: 0x0024B553 File Offset: 0x00249753
		public TArray<FPointData> PointCloudData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FPointData> result;
				if ((result = this._PointCloudData) == null)
				{
					result = (this._PointCloudData = new TArray<FPointData>(base.NativePtr + (IntPtr)FKuroPointSpatialTree.__PropertyOffset_PointCloudData, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.PointCloudData.CopyAssign(value);
			}
		}

		// Token: 0x1700626E RID: 25198
		// (get) Token: 0x06018D94 RID: 101780 RVA: 0x0024B561 File Offset: 0x00249761
		// (set) Token: 0x06018D95 RID: 101781 RVA: 0x0024B575 File Offset: 0x00249775
		public unsafe FBox MaxBound
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroPointSpatialTree.__PropertyOffset_MaxBound);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroPointSpatialTree.__PropertyOffset_MaxBound) = value;
			}
		}

		// Token: 0x06018D96 RID: 101782 RVA: 0x0024B58A File Offset: 0x0024978A
		public FKuroPointSpatialTree()
		{
		}

		// Token: 0x06018D97 RID: 101783 RVA: 0x0024B592 File Offset: 0x00249792
		public FKuroPointSpatialTree(TArray<FPointData> PointCloudData, FBox MaxBound)
		{
			this.PointCloudData = PointCloudData;
			this.MaxBound = MaxBound;
		}

		// Token: 0x06018D98 RID: 101784 RVA: 0x0024B5A8 File Offset: 0x002497A8
		protected override IntPtr GetUStructPtr()
		{
			return FKuroPointSpatialTree.StaticStruct();
		}

		// Token: 0x06018D99 RID: 101785 RVA: 0x0024B5B4 File Offset: 0x002497B4
		[NullableContext(2)]
		public FKuroPointSpatialTree(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06018D9A RID: 101786 RVA: 0x0024B5BE File Offset: 0x002497BE
		public FKuroPointSpatialTree(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06018D9B RID: 101787 RVA: 0x0024B5C9 File Offset: 0x002497C9
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroPointSpatialTree(Pointer, false, true);
		}

		// Token: 0x06018D9C RID: 101788 RVA: 0x0024B5D3 File Offset: 0x002497D3
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroPointSpatialTree(Pointer, MemoryOwner);
		}

		// Token: 0x0400D6CC RID: 54988
		public const string __ObjectPath = "/Script/KuroPointCloud.KuroPointSpatialTree";

		// Token: 0x0400D6CD RID: 54989
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400D6CE RID: 54990
		internal static int __PropertyOffset_PointCloudData;

		// Token: 0x0400D6CF RID: 54991
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FPointData> _PointCloudData;

		// Token: 0x0400D6D0 RID: 54992
		internal static int __PropertyOffset_MaxBound;
	}
}
