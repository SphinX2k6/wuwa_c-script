using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001A39 RID: 6713
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroPointCloud.KuroVirtualPointCloud2DQTree")]
	[UnrealStructLayout(192, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 192)]
	public class UKuroVirtualPointCloud2DQTree : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06018D9D RID: 101789 RVA: 0x0024B5DC File Offset: 0x002497DC
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroVirtualPointCloud2DQTree._ClassPtr;
		}

		// Token: 0x06018D9E RID: 101790 RVA: 0x0024B5E8 File Offset: 0x002497E8
		public UKuroVirtualPointCloud2DQTree() : this(BuiltinUtils.AllocNativeUObject(UKuroVirtualPointCloud2DQTree.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06018D9F RID: 101791 RVA: 0x0024B610 File Offset: 0x00249810
		public UKuroVirtualPointCloud2DQTree(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroVirtualPointCloud2DQTree.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700626F RID: 25199
		// (get) Token: 0x06018DA0 RID: 101792 RVA: 0x0024B644 File Offset: 0x00249844
		// (set) Token: 0x06018DA1 RID: 101793 RVA: 0x0024B67D File Offset: 0x0024987D
		public TArray<int> QTree
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._QTree) == null)
				{
					result = (this._QTree = new TArray<int>(base.NativePtr + (IntPtr)UKuroVirtualPointCloud2DQTree.__PropertyOffset_QTree, this));
				}
				return result;
			}
			set
			{
				this.QTree.CopyAssign(value);
			}
		}

		// Token: 0x17006270 RID: 25200
		// (get) Token: 0x06018DA2 RID: 101794 RVA: 0x0024B68B File Offset: 0x0024988B
		// (set) Token: 0x06018DA3 RID: 101795 RVA: 0x0024B69F File Offset: 0x0024989F
		public unsafe FIntPoint QTreeBoundMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroVirtualPointCloud2DQTree.__PropertyOffset_QTreeBoundMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroVirtualPointCloud2DQTree.__PropertyOffset_QTreeBoundMin) = value;
			}
		}

		// Token: 0x17006271 RID: 25201
		// (get) Token: 0x06018DA4 RID: 101796 RVA: 0x0024B6B4 File Offset: 0x002498B4
		// (set) Token: 0x06018DA5 RID: 101797 RVA: 0x0024B6C8 File Offset: 0x002498C8
		public unsafe FIntPoint QTreeBoundMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroVirtualPointCloud2DQTree.__PropertyOffset_QTreeBoundMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroVirtualPointCloud2DQTree.__PropertyOffset_QTreeBoundMax) = value;
			}
		}

		// Token: 0x17006272 RID: 25202
		// (get) Token: 0x06018DA6 RID: 101798 RVA: 0x0024B6DD File Offset: 0x002498DD
		// (set) Token: 0x06018DA7 RID: 101799 RVA: 0x0024B6F1 File Offset: 0x002498F1
		public unsafe FTransform WorldToPointCloudLocal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroVirtualPointCloud2DQTree.__PropertyOffset_WorldToPointCloudLocal);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroVirtualPointCloud2DQTree.__PropertyOffset_WorldToPointCloudLocal) = value;
			}
		}

		// Token: 0x17006273 RID: 25203
		// (get) Token: 0x06018DA8 RID: 101800 RVA: 0x0024B706 File Offset: 0x00249906
		// (set) Token: 0x06018DA9 RID: 101801 RVA: 0x0024B71A File Offset: 0x0024991A
		public unsafe FTransform PointCloudLocalToWorld
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroVirtualPointCloud2DQTree.__PropertyOffset_PointCloudLocalToWorld);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroVirtualPointCloud2DQTree.__PropertyOffset_PointCloudLocalToWorld) = value;
			}
		}

		// Token: 0x06018DAA RID: 101802 RVA: 0x0024B72F File Offset: 0x0024992F
		public FVector TransformPointToWorld(in FIntPoint Point)
		{
			return UKuroVirtualPointCloud2DQTree.__TransformPointToWorld_Internal(base.NativePtr, Point);
		}

		// Token: 0x06018DAB RID: 101803 RVA: 0x0024B73D File Offset: 0x0024993D
		[NullableContext(2)]
		public void SphereQuery(in FVector SphereCenter, float SphereRadius, ref TArray<FIntPoint> OutResult)
		{
			UKuroVirtualPointCloud2DQTree.__SphereQuery_Internal(base.NativePtr, SphereCenter, SphereRadius, (OutResult ?? new TArray<FIntPoint>()).NativePtr);
		}

		// Token: 0x06018DAC RID: 101804 RVA: 0x0024B75C File Offset: 0x0024995C
		public void Reset()
		{
			UKuroVirtualPointCloud2DQTree.__Reset_Internal(base.NativePtr);
		}

		// Token: 0x06018DAD RID: 101805 RVA: 0x0024B769 File Offset: 0x00249969
		public FBox GetWorldBound()
		{
			return UKuroVirtualPointCloud2DQTree.__GetWorldBound_Internal(base.NativePtr);
		}

		// Token: 0x06018DAE RID: 101806 RVA: 0x0024B776 File Offset: 0x00249976
		public FQuat GetRotation()
		{
			return UKuroVirtualPointCloud2DQTree.__GetRotation_Internal(base.NativePtr);
		}

		// Token: 0x06018DAF RID: 101807 RVA: 0x0024B784 File Offset: 0x00249984
		[NullableContext(2)]
		public unsafe void BuildFromPointData(in TArray<FIntPoint> InPoints, in FTransform InPlaneToWorld, int MaxHeight)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = InPlaneToWorld;
			UKuroVirtualPointCloud2DQTree.__BuildFromPointData_Internal(base.NativePtr, (InPoints ?? new TArray<FIntPoint>()).NativePtr, ptr, MaxHeight);
		}

		// Token: 0x06018DB0 RID: 101808
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __TransformPointToWorld_Internal(IntPtr @this, in FIntPoint Point);

		// Token: 0x06018DB1 RID: 101809
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SphereQuery_Internal(IntPtr @this, in FVector SphereCenter, float SphereRadius, IntPtr OutResult);

		// Token: 0x06018DB2 RID: 101810
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Reset_Internal(IntPtr @this);

		// Token: 0x06018DB3 RID: 101811
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FBox __GetWorldBound_Internal(IntPtr @this);

		// Token: 0x06018DB4 RID: 101812
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FQuat __GetRotation_Internal(IntPtr @this);

		// Token: 0x06018DB5 RID: 101813
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BuildFromPointData_Internal(IntPtr @this, IntPtr InPoints, in FTransform InPlaneToWorld, int MaxHeight);

		// Token: 0x06018DB6 RID: 101814 RVA: 0x0024B7CA File Offset: 0x002499CA
		static UKuroVirtualPointCloud2DQTree()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroPointCloud.KuroVirtualPointCloud2DQTree");
		}

		// Token: 0x06018DB7 RID: 101815 RVA: 0x0024B7D8 File Offset: 0x002499D8
		protected UKuroVirtualPointCloud2DQTree(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400D6D1 RID: 54993
		public new const string __ObjectPath = "/Script/KuroPointCloud.KuroVirtualPointCloud2DQTree";

		// Token: 0x0400D6D2 RID: 54994
		private static IntPtr _ClassPtr;

		// Token: 0x0400D6D3 RID: 54995
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400D6D4 RID: 54996
		internal static int __PropertyOffset_QTree;

		// Token: 0x0400D6D5 RID: 54997
		[Nullable(2)]
		private TArray<int> _QTree;

		// Token: 0x0400D6D6 RID: 54998
		internal static int __PropertyOffset_QTreeBoundMin;

		// Token: 0x0400D6D7 RID: 54999
		internal static int __PropertyOffset_QTreeBoundMax;

		// Token: 0x0400D6D8 RID: 55000
		internal static int __PropertyOffset_WorldToPointCloudLocal;

		// Token: 0x0400D6D9 RID: 55001
		internal static int __PropertyOffset_PointCloudLocalToWorld;
	}
}
