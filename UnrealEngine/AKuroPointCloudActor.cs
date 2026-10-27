using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001A26 RID: 6694
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroPointCloud.KuroPointCloudActor")]
	[UnrealStructLayout(1176, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1176)]
	public class AKuroPointCloudActor : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06018C2A RID: 101418 RVA: 0x0024965D File Offset: 0x0024785D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroPointCloudActor._ClassPtr;
		}

		// Token: 0x06018C2B RID: 101419 RVA: 0x0024966C File Offset: 0x0024786C
		public AKuroPointCloudActor() : this(BuiltinUtils.AllocNativeUObject(AKuroPointCloudActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06018C2C RID: 101420 RVA: 0x00249694 File Offset: 0x00247894
		public AKuroPointCloudActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroPointCloudActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006225 RID: 25125
		// (get) Token: 0x06018C2D RID: 101421 RVA: 0x002496C7 File Offset: 0x002478C7
		// (set) Token: 0x06018C2E RID: 101422 RVA: 0x002496DB File Offset: 0x002478DB
		[Nullable(2)]
		public unsafe UInstancedStaticMeshComponent InstancedStaticMeshComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UInstancedStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroPointCloudActor.__PropertyOffset_InstancedStaticMeshComponent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroPointCloudActor.__PropertyOffset_InstancedStaticMeshComponent, value);
			}
		}

		// Token: 0x17006226 RID: 25126
		// (get) Token: 0x06018C2F RID: 101423 RVA: 0x002496F0 File Offset: 0x002478F0
		// (set) Token: 0x06018C30 RID: 101424 RVA: 0x00249704 File Offset: 0x00247904
		[Nullable(2)]
		public unsafe UKuroPointCloudCache PointCloudAsset
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroPointCloudCache>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroPointCloudActor.__PropertyOffset_PointCloudAsset);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroPointCloudActor.__PropertyOffset_PointCloudAsset, value);
			}
		}

		// Token: 0x17006227 RID: 25127
		// (get) Token: 0x06018C31 RID: 101425 RVA: 0x00249719 File Offset: 0x00247919
		// (set) Token: 0x06018C32 RID: 101426 RVA: 0x00249729 File Offset: 0x00247929
		public unsafe int PointNumToStopDivide
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroPointCloudActor.__PropertyOffset_PointNumToStopDivide);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroPointCloudActor.__PropertyOffset_PointNumToStopDivide) = value;
			}
		}

		// Token: 0x17006228 RID: 25128
		// (get) Token: 0x06018C33 RID: 101427 RVA: 0x0024973A File Offset: 0x0024793A
		// (set) Token: 0x06018C34 RID: 101428 RVA: 0x0024974A File Offset: 0x0024794A
		public unsafe float BoxLengthToStopDivide
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroPointCloudActor.__PropertyOffset_BoxLengthToStopDivide);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroPointCloudActor.__PropertyOffset_BoxLengthToStopDivide) = value;
			}
		}

		// Token: 0x17006229 RID: 25129
		// (get) Token: 0x06018C35 RID: 101429 RVA: 0x0024975B File Offset: 0x0024795B
		// (set) Token: 0x06018C36 RID: 101430 RVA: 0x0024976B File Offset: 0x0024796B
		public unsafe float InstanceScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroPointCloudActor.__PropertyOffset_InstanceScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroPointCloudActor.__PropertyOffset_InstanceScale) = value;
			}
		}

		// Token: 0x1700622A RID: 25130
		// (get) Token: 0x06018C37 RID: 101431 RVA: 0x0024977C File Offset: 0x0024797C
		// (set) Token: 0x06018C38 RID: 101432 RVA: 0x002497B5 File Offset: 0x002479B5
		public FKuroPointKdTree KdTree
		{
			get
			{
				base.FastCheckIsValid();
				FKuroPointKdTree result;
				if ((result = this._KdTree) == null)
				{
					result = (this._KdTree = new FKuroPointKdTree(base.NativePtr + (IntPtr)AKuroPointCloudActor.__PropertyOffset_KdTree, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroPointKdTree.StaticStruct(), base.NativePtr + (IntPtr)AKuroPointCloudActor.__PropertyOffset_KdTree, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700622B RID: 25131
		// (get) Token: 0x06018C39 RID: 101433 RVA: 0x002497D8 File Offset: 0x002479D8
		// (set) Token: 0x06018C3A RID: 101434 RVA: 0x00249811 File Offset: 0x00247A11
		public TArray<float> CustomData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._CustomData) == null)
				{
					result = (this._CustomData = new TArray<float>(base.NativePtr + (IntPtr)AKuroPointCloudActor.__PropertyOffset_CustomData, this));
				}
				return result;
			}
			set
			{
				this.CustomData.CopyAssign(value);
			}
		}

		// Token: 0x06018C3B RID: 101435 RVA: 0x0024981F File Offset: 0x00247A1F
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void UpdateIsm()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, AKuroPointCloudActor.__UpdateIsm_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06018C3C RID: 101436 RVA: 0x00249834 File Offset: 0x00247A34
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void MarkPointsInBox(in FBox BoxWS)
		{
			AKuroPointCloudActor.__MarkPointsInBox_FunctionParams* ptr = stackalloc AKuroPointCloudActor.__MarkPointsInBox_FunctionParams[(UIntPtr)43] + 15L / (long)sizeof(AKuroPointCloudActor.__MarkPointsInBox_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(AKuroPointCloudActor.__MarkPointsInBox_NativeFunctionPtr, (void*)ptr, 1);
			ptr->BoxWS = BoxWS;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, AKuroPointCloudActor.__MarkPointsInBox_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06018C3D RID: 101437 RVA: 0x00249880 File Offset: 0x00247A80
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void ClearMark()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, AKuroPointCloudActor.__ClearMark_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06018C3E RID: 101438 RVA: 0x00249895 File Offset: 0x00247A95
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void BuildKdTreeData()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, AKuroPointCloudActor.__BuildKdTreeData_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06018C3F RID: 101439 RVA: 0x002498AA File Offset: 0x00247AAA
		static AKuroPointCloudActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroPointCloud.KuroPointCloudActor");
		}

		// Token: 0x06018C40 RID: 101440 RVA: 0x002498B8 File Offset: 0x00247AB8
		protected AKuroPointCloudActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400D633 RID: 54835
		public new const string __ObjectPath = "/Script/KuroPointCloud.KuroPointCloudActor";

		// Token: 0x0400D634 RID: 54836
		private static IntPtr _ClassPtr;

		// Token: 0x0400D635 RID: 54837
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400D636 RID: 54838
		internal static int __PropertyOffset_InstancedStaticMeshComponent;

		// Token: 0x0400D637 RID: 54839
		internal static int __PropertyOffset_PointCloudAsset;

		// Token: 0x0400D638 RID: 54840
		internal static int __PropertyOffset_PointNumToStopDivide;

		// Token: 0x0400D639 RID: 54841
		internal static int __PropertyOffset_BoxLengthToStopDivide;

		// Token: 0x0400D63A RID: 54842
		internal static int __PropertyOffset_InstanceScale;

		// Token: 0x0400D63B RID: 54843
		internal static int __PropertyOffset_KdTree;

		// Token: 0x0400D63C RID: 54844
		[Nullable(2)]
		private FKuroPointKdTree _KdTree;

		// Token: 0x0400D63D RID: 54845
		internal static int __PropertyOffset_CustomData;

		// Token: 0x0400D63E RID: 54846
		[Nullable(2)]
		private TArray<float> _CustomData;

		// Token: 0x0400D63F RID: 54847
		private static IntPtr __UpdateIsm_NativeFunctionPtr;

		// Token: 0x0400D640 RID: 54848
		private static IntPtr __MarkPointsInBox_NativeFunctionPtr;

		// Token: 0x0400D641 RID: 54849
		private static IntPtr __ClearMark_NativeFunctionPtr;

		// Token: 0x0400D642 RID: 54850
		private static IntPtr __BuildKdTreeData_NativeFunctionPtr;

		// Token: 0x020030FA RID: 12538
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 28)]
		protected ref struct __MarkPointsInBox_FunctionParams
		{
			// Token: 0x04016E79 RID: 93817
			[FieldOffset(0)]
			public FBox BoxWS;
		}
	}
}
