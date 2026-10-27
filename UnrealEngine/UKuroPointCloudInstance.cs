using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001A2C RID: 6700
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroPointCloud.KuroPointCloudInstance")]
	[UnrealStructLayout(152, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 152)]
	public class UKuroPointCloudInstance : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06018CB1 RID: 101553 RVA: 0x0024A343 File Offset: 0x00248543
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroPointCloudInstance._ClassPtr;
		}

		// Token: 0x06018CB2 RID: 101554 RVA: 0x0024A350 File Offset: 0x00248550
		public UKuroPointCloudInstance() : this(BuiltinUtils.AllocNativeUObject(UKuroPointCloudInstance.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06018CB3 RID: 101555 RVA: 0x0024A378 File Offset: 0x00248578
		[NullableContext(1)]
		public UKuroPointCloudInstance(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroPointCloudInstance.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006247 RID: 25159
		// (get) Token: 0x06018CB4 RID: 101556 RVA: 0x0024A3AB File Offset: 0x002485AB
		// (set) Token: 0x06018CB5 RID: 101557 RVA: 0x0024A3BF File Offset: 0x002485BF
		public unsafe UKuroPointCloudCache PointCloudCache
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroPointCloudCache>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroPointCloudInstance.__PropertyOffset_PointCloudCache);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroPointCloudInstance.__PropertyOffset_PointCloudCache, value);
			}
		}

		// Token: 0x17006248 RID: 25160
		// (get) Token: 0x06018CB6 RID: 101558 RVA: 0x0024A3D4 File Offset: 0x002485D4
		// (set) Token: 0x06018CB7 RID: 101559 RVA: 0x0024A40D File Offset: 0x0024860D
		[Nullable(1)]
		public FKuroPointKdTree KdTree
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FKuroPointKdTree result;
				if ((result = this._KdTree) == null)
				{
					result = (this._KdTree = new FKuroPointKdTree(base.NativePtr + (IntPtr)UKuroPointCloudInstance.__PropertyOffset_KdTree, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroPointKdTree.StaticStruct(), base.NativePtr + (IntPtr)UKuroPointCloudInstance.__PropertyOffset_KdTree, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006249 RID: 25161
		// (get) Token: 0x06018CB8 RID: 101560 RVA: 0x0024A42E File Offset: 0x0024862E
		// (set) Token: 0x06018CB9 RID: 101561 RVA: 0x0024A442 File Offset: 0x00248642
		public unsafe UKuroVirtualPointCloud2DQTree QTree2D
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroVirtualPointCloud2DQTree>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroPointCloudInstance.__PropertyOffset_QTree2D);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroPointCloudInstance.__PropertyOffset_QTree2D, value);
			}
		}

		// Token: 0x06018CBA RID: 101562 RVA: 0x0024A457 File Offset: 0x00248657
		[NullableContext(1)]
		public FKuroPointCloudInstanceQueryResult SphereQuery(in FVector SphereCenter, float SphereRadius)
		{
			return new FKuroPointCloudInstanceQueryResult(UKuroPointCloudInstance.__SphereQuery_Internal(base.NativePtr, SphereCenter, SphereRadius), null);
		}

		// Token: 0x06018CBB RID: 101563 RVA: 0x0024A46C File Offset: 0x0024866C
		public void ResetData()
		{
			UKuroPointCloudInstance.__ResetData_Internal(base.NativePtr);
		}

		// Token: 0x06018CBC RID: 101564 RVA: 0x0024A47C File Offset: 0x0024867C
		public unsafe bool GetQueryPointTransform(in FKuroPointCloudInstanceQueryResult QueryResult, int Index, ref FVector OutPosition, ref FQuat OutRotation, ref FVector OutScale)
		{
			ref FQuat ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = OutRotation;
			fixed (FVector* ptr2 = &OutPosition)
			{
				void* ptr3 = (void*)ptr2;
				fixed (FVector* ptr4 = &OutScale)
				{
					void* ptr5 = (void*)ptr4;
					bool result = UKuroPointCloudInstance.__GetQueryPointTransform_Internal(base.NativePtr, (QueryResult ?? new FKuroPointCloudInstanceQueryResult()).NativePtr, Index, ref OutPosition, ref ptr, ref OutScale);
					OutRotation = ptr;
					return result;
				}
			}
		}

		// Token: 0x06018CBD RID: 101565 RVA: 0x0024A4E0 File Offset: 0x002486E0
		public int GetQueryPointsNum(in FKuroPointCloudInstanceQueryResult QueryResult)
		{
			return UKuroPointCloudInstance.__GetQueryPointsNum_Internal(base.NativePtr, (QueryResult ?? new FKuroPointCloudInstanceQueryResult()).NativePtr);
		}

		// Token: 0x06018CBE RID: 101566 RVA: 0x0024A4FD File Offset: 0x002486FD
		public UKuroPointCloudCache GetPointCloudCache()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroPointCloudCache>(UKuroPointCloudInstance.__GetPointCloudCache_Internal(base.NativePtr));
		}

		// Token: 0x06018CBF RID: 101567 RVA: 0x0024A50F File Offset: 0x0024870F
		public FBox GetBound()
		{
			return UKuroPointCloudInstance.__GetBound_Internal(base.NativePtr);
		}

		// Token: 0x06018CC0 RID: 101568 RVA: 0x0024A51C File Offset: 0x0024871C
		public void BuildFromPointCloudData(in TArray<FVector> Positions, in TArray<FQuat> Rotations, in TArray<FVector> Scales)
		{
			UKuroPointCloudInstance.__BuildFromPointCloudData_Internal(base.NativePtr, (Positions ?? new TArray<FVector>()).NativePtr, (Rotations ?? new TArray<FQuat>()).NativePtr, (Scales ?? new TArray<FVector>()).NativePtr);
		}

		// Token: 0x06018CC1 RID: 101569 RVA: 0x0024A55C File Offset: 0x0024875C
		public unsafe void BuildFrom2DPoints(in TArray<FIntPoint> InPoints, in FTransform InPlaneToWorld, int MaxHeight)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = InPlaneToWorld;
			UKuroPointCloudInstance.__BuildFrom2DPoints_Internal(base.NativePtr, (InPoints ?? new TArray<FIntPoint>()).NativePtr, ptr, MaxHeight);
		}

		// Token: 0x06018CC2 RID: 101570
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SphereQuery_Internal(IntPtr @this, in FVector SphereCenter, float SphereRadius);

		// Token: 0x06018CC3 RID: 101571
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetData_Internal(IntPtr @this);

		// Token: 0x06018CC4 RID: 101572
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetQueryPointTransform_Internal(IntPtr @this, IntPtr QueryResult, int Index, ref FVector OutPosition, ref FQuat OutRotation, ref FVector OutScale);

		// Token: 0x06018CC5 RID: 101573
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetQueryPointsNum_Internal(IntPtr @this, IntPtr QueryResult);

		// Token: 0x06018CC6 RID: 101574
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetPointCloudCache_Internal(IntPtr @this);

		// Token: 0x06018CC7 RID: 101575
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FBox __GetBound_Internal(IntPtr @this);

		// Token: 0x06018CC8 RID: 101576
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BuildFromPointCloudData_Internal(IntPtr @this, IntPtr Positions, IntPtr Rotations, IntPtr Scales);

		// Token: 0x06018CC9 RID: 101577
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BuildFrom2DPoints_Internal(IntPtr @this, IntPtr InPoints, in FTransform InPlaneToWorld, int MaxHeight);

		// Token: 0x06018CCA RID: 101578 RVA: 0x0024A5A2 File Offset: 0x002487A2
		static UKuroPointCloudInstance()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroPointCloud.KuroPointCloudInstance");
		}

		// Token: 0x06018CCB RID: 101579 RVA: 0x0024A5B0 File Offset: 0x002487B0
		protected UKuroPointCloudInstance(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400D67C RID: 54908
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroPointCloud.KuroPointCloudInstance";

		// Token: 0x0400D67D RID: 54909
		private static IntPtr _ClassPtr;

		// Token: 0x0400D67E RID: 54910
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400D67F RID: 54911
		internal static int __PropertyOffset_PointCloudCache;

		// Token: 0x0400D680 RID: 54912
		internal static int __PropertyOffset_KdTree;

		// Token: 0x0400D681 RID: 54913
		private FKuroPointKdTree _KdTree;

		// Token: 0x0400D682 RID: 54914
		internal static int __PropertyOffset_QTree2D;
	}
}
