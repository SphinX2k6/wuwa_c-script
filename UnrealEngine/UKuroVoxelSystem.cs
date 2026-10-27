using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001F46 RID: 8006
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroVoxelRuntime.KuroVoxelSystem")]
	[UnrealStructLayout(304, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 304)]
	public class UKuroVoxelSystem : UWorldSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601E738 RID: 124728 RVA: 0x002D4534 File Offset: 0x002D2734
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroVoxelSystem._ClassPtr;
		}

		// Token: 0x0601E739 RID: 124729 RVA: 0x002D4540 File Offset: 0x002D2740
		public UKuroVoxelSystem() : this(BuiltinUtils.AllocNativeUObject(UKuroVoxelSystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601E73A RID: 124730 RVA: 0x002D4568 File Offset: 0x002D2768
		public UKuroVoxelSystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroVoxelSystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007921 RID: 31009
		// (get) Token: 0x0601E73B RID: 124731 RVA: 0x002D459C File Offset: 0x002D279C
		// (set) Token: 0x0601E73C RID: 124732 RVA: 0x002D45D5 File Offset: 0x002D27D5
		public TMap<FIntPoint, AKuroVoxelPartitionActor> LoadedPartitionActorsMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FIntPoint, AKuroVoxelPartitionActor> result;
				if ((result = this._LoadedPartitionActorsMap) == null)
				{
					result = (this._LoadedPartitionActorsMap = new TMap<FIntPoint, AKuroVoxelPartitionActor>(base.NativePtr + (IntPtr)UKuroVoxelSystem.__PropertyOffset_LoadedPartitionActorsMap, this));
				}
				return result;
			}
			set
			{
				this.LoadedPartitionActorsMap.CopyAssign(value);
			}
		}

		// Token: 0x17007922 RID: 31010
		// (get) Token: 0x0601E73D RID: 124733 RVA: 0x002D45E4 File Offset: 0x002D27E4
		// (set) Token: 0x0601E73E RID: 124734 RVA: 0x002D461D File Offset: 0x002D281D
		public TSet<AKuroVoxelPartitionActor> ToAddActorSet
		{
			get
			{
				base.FastCheckIsValid();
				TSet<AKuroVoxelPartitionActor> result;
				if ((result = this._ToAddActorSet) == null)
				{
					result = (this._ToAddActorSet = new TSet<AKuroVoxelPartitionActor>(base.NativePtr + (IntPtr)UKuroVoxelSystem.__PropertyOffset_ToAddActorSet, this));
				}
				return result;
			}
			set
			{
				this.ToAddActorSet.CopyAssign(value);
			}
		}

		// Token: 0x0601E73F RID: 124735 RVA: 0x002D462C File Offset: 0x002D282C
		[NullableContext(2)]
		public unsafe static bool TryGetVoxelInfoAtPos(UWorld World, FVector UEPos, ref FKuroVoxelInfo OutVoxelInfo, ref int ErrorCode, float SearchStep = -1f)
		{
			fixed (int* ptr = &ErrorCode)
			{
				void* ptr2 = (void*)ptr;
				return UKuroVoxelSystem.__TryGetVoxelInfoAtPos_Internal((World != null) ? World.NativePtr : IntPtr.Zero, UEPos, (OutVoxelInfo ?? new FKuroVoxelInfo()).NativePtr, ref ErrorCode, SearchStep);
			}
		}

		// Token: 0x0601E740 RID: 124736 RVA: 0x002D4667 File Offset: 0x002D2867
		[NullableContext(2)]
		public static bool IsVoxelSystemInitialized(UWorld World)
		{
			return UKuroVoxelSystem.__IsVoxelSystemInitialized_Internal((World != null) ? World.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601E741 RID: 124737 RVA: 0x002D467E File Offset: 0x002D287E
		[NullableContext(2)]
		public static bool IsCavernAtPos(UWorld World, FVector UEPos)
		{
			return UKuroVoxelSystem.__IsCavernAtPos_Internal((World != null) ? World.NativePtr : IntPtr.Zero, UEPos);
		}

		// Token: 0x0601E742 RID: 124738 RVA: 0x002D4698 File Offset: 0x002D2898
		public unsafe static FKuroVoxelInfo GetVoxelInfoAtPos([Nullable(2)] UWorld World, FVector UEPos, ref int ErrorCode, float SearchStep = -1f)
		{
			fixed (int* ptr = &ErrorCode)
			{
				void* ptr2 = (void*)ptr;
				return new FKuroVoxelInfo(UKuroVoxelSystem.__GetVoxelInfoAtPos_Internal((World != null) ? World.NativePtr : IntPtr.Zero, UEPos, ref ErrorCode, SearchStep), null);
			}
		}

		// Token: 0x0601E743 RID: 124739 RVA: 0x002D46C8 File Offset: 0x002D28C8
		public static string GetMtlNameByID(byte MtlID)
		{
			return FString.ToStringAndDeleteNativePtr(UKuroVoxelSystem.__GetMtlNameByID_Internal(MtlID));
		}

		// Token: 0x0601E744 RID: 124740 RVA: 0x002D46D5 File Offset: 0x002D28D5
		[NullableContext(2)]
		public static byte GetMaterialIDAtPos(UWorld World, FVector UEPos)
		{
			return UKuroVoxelSystem.__GetMaterialIDAtPos_Internal((World != null) ? World.NativePtr : IntPtr.Zero, UEPos);
		}

		// Token: 0x0601E745 RID: 124741 RVA: 0x002D46F0 File Offset: 0x002D28F0
		[NullableContext(2)]
		public unsafe static bool D_TryGetVoxelInfoAtPos(UWorld World, FVectorDouble UEPos, ref FKuroVoxelInfo OutVoxelInfo, ref int ErrorCode, double SearchStep = -1.0)
		{
			fixed (int* ptr = &ErrorCode)
			{
				void* ptr2 = (void*)ptr;
				return UKuroVoxelSystem.__D_TryGetVoxelInfoAtPos_Internal((World != null) ? World.NativePtr : IntPtr.Zero, UEPos, (OutVoxelInfo ?? new FKuroVoxelInfo()).NativePtr, ref ErrorCode, SearchStep);
			}
		}

		// Token: 0x0601E746 RID: 124742 RVA: 0x002D472B File Offset: 0x002D292B
		[NullableContext(2)]
		public static bool D_IsCavernAtPos(UWorld World, FVectorDouble UEPos)
		{
			return UKuroVoxelSystem.__D_IsCavernAtPos_Internal((World != null) ? World.NativePtr : IntPtr.Zero, UEPos);
		}

		// Token: 0x0601E747 RID: 124743 RVA: 0x002D4744 File Offset: 0x002D2944
		public unsafe static FKuroVoxelInfo D_GetVoxelInfoAtPos([Nullable(2)] UWorld World, FVectorDouble UEPos, ref int ErrorCode, double SearchStep = -1.0)
		{
			fixed (int* ptr = &ErrorCode)
			{
				void* ptr2 = (void*)ptr;
				return new FKuroVoxelInfo(UKuroVoxelSystem.__D_GetVoxelInfoAtPos_Internal((World != null) ? World.NativePtr : IntPtr.Zero, UEPos, ref ErrorCode, SearchStep), null);
			}
		}

		// Token: 0x0601E748 RID: 124744 RVA: 0x002D4774 File Offset: 0x002D2974
		[NullableContext(2)]
		public static byte D_GetMaterialIDAtPos(UWorld World, FVectorDouble UEPos)
		{
			return UKuroVoxelSystem.__D_GetMaterialIDAtPos_Internal((World != null) ? World.NativePtr : IntPtr.Zero, UEPos);
		}

		// Token: 0x0601E749 RID: 124745
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __TryGetVoxelInfoAtPos_Internal(IntPtr World, FVector UEPos, IntPtr OutVoxelInfo, ref int ErrorCode, float SearchStep);

		// Token: 0x0601E74A RID: 124746
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsVoxelSystemInitialized_Internal(IntPtr World);

		// Token: 0x0601E74B RID: 124747
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsCavernAtPos_Internal(IntPtr World, FVector UEPos);

		// Token: 0x0601E74C RID: 124748
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetVoxelInfoAtPos_Internal(IntPtr World, FVector UEPos, ref int ErrorCode, float SearchStep);

		// Token: 0x0601E74D RID: 124749
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetMtlNameByID_Internal(byte MtlID);

		// Token: 0x0601E74E RID: 124750
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern byte __GetMaterialIDAtPos_Internal(IntPtr World, FVector UEPos);

		// Token: 0x0601E74F RID: 124751
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __D_TryGetVoxelInfoAtPos_Internal(IntPtr World, FVectorDouble UEPos, IntPtr OutVoxelInfo, ref int ErrorCode, double SearchStep);

		// Token: 0x0601E750 RID: 124752
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __D_IsCavernAtPos_Internal(IntPtr World, FVectorDouble UEPos);

		// Token: 0x0601E751 RID: 124753
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __D_GetVoxelInfoAtPos_Internal(IntPtr World, FVectorDouble UEPos, ref int ErrorCode, double SearchStep);

		// Token: 0x0601E752 RID: 124754
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern byte __D_GetMaterialIDAtPos_Internal(IntPtr World, FVectorDouble UEPos);

		// Token: 0x0601E753 RID: 124755 RVA: 0x002D478C File Offset: 0x002D298C
		static UKuroVoxelSystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroVoxelRuntime.KuroVoxelSystem");
		}

		// Token: 0x0601E754 RID: 124756 RVA: 0x002D479A File Offset: 0x002D299A
		protected UKuroVoxelSystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040106E0 RID: 67296
		public new const string __ObjectPath = "/Script/KuroVoxelRuntime.KuroVoxelSystem";

		// Token: 0x040106E1 RID: 67297
		private static IntPtr _ClassPtr;

		// Token: 0x040106E2 RID: 67298
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040106E3 RID: 67299
		internal static int __PropertyOffset_LoadedPartitionActorsMap;

		// Token: 0x040106E4 RID: 67300
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FIntPoint, AKuroVoxelPartitionActor> _LoadedPartitionActorsMap;

		// Token: 0x040106E5 RID: 67301
		internal static int __PropertyOffset_ToAddActorSet;

		// Token: 0x040106E6 RID: 67302
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<AKuroVoxelPartitionActor> _ToAddActorSet;
	}
}
