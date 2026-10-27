using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000481 RID: 1153
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ClothingSystemRuntimeCommon.ClothLODDataCommon")]
	[UnrealStructLayout(400, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 400)]
	public class FClothLODDataCommon : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06003E05 RID: 15877 RVA: 0x0005D399 File Offset: 0x0005B599
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FClothLODDataCommon._ScriptStructPtr != 0) ? FClothLODDataCommon._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ClothingSystemRuntimeCommon.ClothLODDataCommon", ref FClothLODDataCommon._ScriptStructPtr);
		}

		// Token: 0x17000F1F RID: 3871
		// (get) Token: 0x06003E06 RID: 15878 RVA: 0x0005D3C0 File Offset: 0x0005B5C0
		// (set) Token: 0x06003E07 RID: 15879 RVA: 0x0005D403 File Offset: 0x0005B603
		public FClothPhysicalMeshData PhysicalMeshData
		{
			get
			{
				base.FastCheckIsValid();
				FClothPhysicalMeshData result;
				if ((result = this._PhysicalMeshData) == null)
				{
					result = (this._PhysicalMeshData = new FClothPhysicalMeshData(base.NativePtr + (IntPtr)FClothLODDataCommon.__PropertyOffset_PhysicalMeshData, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FClothPhysicalMeshData.StaticStruct(), base.NativePtr + (IntPtr)FClothLODDataCommon.__PropertyOffset_PhysicalMeshData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000F20 RID: 3872
		// (get) Token: 0x06003E08 RID: 15880 RVA: 0x0005D424 File Offset: 0x0005B624
		// (set) Token: 0x06003E09 RID: 15881 RVA: 0x0005D467 File Offset: 0x0005B667
		public FClothCollisionData CollisionData
		{
			get
			{
				base.FastCheckIsValid();
				FClothCollisionData result;
				if ((result = this._CollisionData) == null)
				{
					result = (this._CollisionData = new FClothCollisionData(base.NativePtr + (IntPtr)FClothLODDataCommon.__PropertyOffset_CollisionData, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FClothCollisionData.StaticStruct(), base.NativePtr + (IntPtr)FClothLODDataCommon.__PropertyOffset_CollisionData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000F21 RID: 3873
		// (get) Token: 0x06003E0A RID: 15882 RVA: 0x0005D488 File Offset: 0x0005B688
		// (set) Token: 0x06003E0B RID: 15883 RVA: 0x0005D498 File Offset: 0x0005B698
		public unsafe bool bUseMultipleInfluences
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FClothLODDataCommon.__PropertyOffset_bUseMultipleInfluences) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FClothLODDataCommon.__PropertyOffset_bUseMultipleInfluences) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000F22 RID: 3874
		// (get) Token: 0x06003E0C RID: 15884 RVA: 0x0005D4A9 File Offset: 0x0005B6A9
		// (set) Token: 0x06003E0D RID: 15885 RVA: 0x0005D4B9 File Offset: 0x0005B6B9
		public unsafe float SkinningKernelRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FClothLODDataCommon.__PropertyOffset_SkinningKernelRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FClothLODDataCommon.__PropertyOffset_SkinningKernelRadius) = value;
			}
		}

		// Token: 0x06003E0E RID: 15886 RVA: 0x0005D4CA File Offset: 0x0005B6CA
		public FClothLODDataCommon()
		{
		}

		// Token: 0x06003E0F RID: 15887 RVA: 0x0005D4D2 File Offset: 0x0005B6D2
		public FClothLODDataCommon(FClothPhysicalMeshData PhysicalMeshData, FClothCollisionData CollisionData, bool bUseMultipleInfluences, float SkinningKernelRadius, TArray<FClothParameterMask_Legacy> ParameterMasks_DEPRECATED, TArray<FPointWeightMap> PointWeightMaps)
		{
			this.PhysicalMeshData = PhysicalMeshData;
			this.CollisionData = CollisionData;
			this.bUseMultipleInfluences = bUseMultipleInfluences;
			this.SkinningKernelRadius = SkinningKernelRadius;
		}

		// Token: 0x06003E10 RID: 15888 RVA: 0x0005D4F7 File Offset: 0x0005B6F7
		protected override IntPtr GetUStructPtr()
		{
			return FClothLODDataCommon.StaticStruct();
		}

		// Token: 0x06003E11 RID: 15889 RVA: 0x0005D503 File Offset: 0x0005B703
		[NullableContext(2)]
		public FClothLODDataCommon(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06003E12 RID: 15890 RVA: 0x0005D50D File Offset: 0x0005B70D
		public FClothLODDataCommon(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06003E13 RID: 15891 RVA: 0x0005D518 File Offset: 0x0005B718
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FClothLODDataCommon(Pointer, false, true);
		}

		// Token: 0x06003E14 RID: 15892 RVA: 0x0005D522 File Offset: 0x0005B722
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FClothLODDataCommon(Pointer, MemoryOwner);
		}

		// Token: 0x04001D26 RID: 7462
		public const string __ObjectPath = "/Script/ClothingSystemRuntimeCommon.ClothLODDataCommon";

		// Token: 0x04001D27 RID: 7463
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001D28 RID: 7464
		internal static int __PropertyOffset_PhysicalMeshData;

		// Token: 0x04001D29 RID: 7465
		[Nullable(2)]
		private FClothPhysicalMeshData _PhysicalMeshData;

		// Token: 0x04001D2A RID: 7466
		internal static int __PropertyOffset_CollisionData;

		// Token: 0x04001D2B RID: 7467
		[Nullable(2)]
		private FClothCollisionData _CollisionData;

		// Token: 0x04001D2C RID: 7468
		internal static int __PropertyOffset_bUseMultipleInfluences;

		// Token: 0x04001D2D RID: 7469
		internal static int __PropertyOffset_SkinningKernelRadius;
	}
}
