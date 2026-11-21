using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200063B RID: 1595
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroVoxelRuntime.KuroVoxelSystem")]
	[UnrealStructLayout(304, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 304)]
	public class UKuroVoxelSystem : UWorldSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06008BD1 RID: 35793 RVA: 0x000D25FB File Offset: 0x000D07FB
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroVoxelSystem._ClassPtr;
		}

		// Token: 0x06008BD2 RID: 35794 RVA: 0x000D2608 File Offset: 0x000D0808
		public UKuroVoxelSystem() : this(BuiltinUtils.AllocNativeUObject(UKuroVoxelSystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06008BD3 RID: 35795 RVA: 0x000D2630 File Offset: 0x000D0830
		[NullableContext(1)]
		public UKuroVoxelSystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroVoxelSystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06008BD4 RID: 35796 RVA: 0x000D2664 File Offset: 0x000D0864
		public unsafe static bool TryGetVoxelInfoAtPos(UWorld World, FVector UEPos, ref FKuroVoxelInfo OutVoxelInfo, ref int ErrorCode, float SearchStep = -1f)
		{
			fixed (int* ptr = &ErrorCode)
			{
				void* ptr2 = (void*)ptr;
				return UKuroVoxelSystem.__TryGetVoxelInfoAtPos_Internal((World != null) ? World.NativePtr : IntPtr.Zero, UEPos, (OutVoxelInfo ?? new FKuroVoxelInfo()).NativePtr, ref ErrorCode, SearchStep);
			}
		}

		// Token: 0x06008BD5 RID: 35797 RVA: 0x000D269F File Offset: 0x000D089F
		public static bool IsVoxelSystemInitialized(UWorld World)
		{
			return UKuroVoxelSystem.__IsVoxelSystemInitialized_Internal((World != null) ? World.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06008BD6 RID: 35798 RVA: 0x000D26B6 File Offset: 0x000D08B6
		public static bool IsCavernAtPos(UWorld World, FVector UEPos)
		{
			return UKuroVoxelSystem.__IsCavernAtPos_Internal((World != null) ? World.NativePtr : IntPtr.Zero, UEPos);
		}

		// Token: 0x06008BD7 RID: 35799 RVA: 0x000D26D0 File Offset: 0x000D08D0
		[NullableContext(1)]
		public unsafe static FKuroVoxelInfo GetVoxelInfoAtPos([Nullable(2)] UWorld World, FVector UEPos, ref int ErrorCode, float SearchStep = -1f)
		{
			fixed (int* ptr = &ErrorCode)
			{
				void* ptr2 = (void*)ptr;
				return new FKuroVoxelInfo(UKuroVoxelSystem.__GetVoxelInfoAtPos_Internal((World != null) ? World.NativePtr : IntPtr.Zero, UEPos, ref ErrorCode, SearchStep), null);
			}
		}

		// Token: 0x06008BD8 RID: 35800 RVA: 0x000D2700 File Offset: 0x000D0900
		[NullableContext(1)]
		public static string GetMtlNameByID(byte MtlID)
		{
			return FString.ToStringAndDeleteNativePtr(UKuroVoxelSystem.__GetMtlNameByID_Internal(MtlID));
		}

		// Token: 0x06008BD9 RID: 35801 RVA: 0x000D270D File Offset: 0x000D090D
		public static byte GetMaterialIDAtPos(UWorld World, FVector UEPos)
		{
			return UKuroVoxelSystem.__GetMaterialIDAtPos_Internal((World != null) ? World.NativePtr : IntPtr.Zero, UEPos);
		}

		// Token: 0x06008BDA RID: 35802 RVA: 0x000D2728 File Offset: 0x000D0928
		public unsafe static bool D_TryGetVoxelInfoAtPos(UWorld World, FVectorDouble UEPos, ref FKuroVoxelInfo OutVoxelInfo, ref int ErrorCode, double SearchStep = -1.0)
		{
			fixed (int* ptr = &ErrorCode)
			{
				void* ptr2 = (void*)ptr;
				return UKuroVoxelSystem.__D_TryGetVoxelInfoAtPos_Internal((World != null) ? World.NativePtr : IntPtr.Zero, UEPos, (OutVoxelInfo ?? new FKuroVoxelInfo()).NativePtr, ref ErrorCode, SearchStep);
			}
		}

		// Token: 0x06008BDB RID: 35803 RVA: 0x000D2763 File Offset: 0x000D0963
		public static bool D_IsCavernAtPos(UWorld World, FVectorDouble UEPos)
		{
			return UKuroVoxelSystem.__D_IsCavernAtPos_Internal((World != null) ? World.NativePtr : IntPtr.Zero, UEPos);
		}

		// Token: 0x06008BDC RID: 35804 RVA: 0x000D277C File Offset: 0x000D097C
		[NullableContext(1)]
		public unsafe static FKuroVoxelInfo D_GetVoxelInfoAtPos([Nullable(2)] UWorld World, FVectorDouble UEPos, ref int ErrorCode, double SearchStep = -1.0)
		{
			fixed (int* ptr = &ErrorCode)
			{
				void* ptr2 = (void*)ptr;
				return new FKuroVoxelInfo(UKuroVoxelSystem.__D_GetVoxelInfoAtPos_Internal((World != null) ? World.NativePtr : IntPtr.Zero, UEPos, ref ErrorCode, SearchStep), null);
			}
		}

		// Token: 0x06008BDD RID: 35805 RVA: 0x000D27AC File Offset: 0x000D09AC
		public static byte D_GetMaterialIDAtPos(UWorld World, FVectorDouble UEPos)
		{
			return UKuroVoxelSystem.__D_GetMaterialIDAtPos_Internal((World != null) ? World.NativePtr : IntPtr.Zero, UEPos);
		}

		// Token: 0x06008BDE RID: 35806
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __TryGetVoxelInfoAtPos_Internal(IntPtr World, FVector UEPos, IntPtr OutVoxelInfo, ref int ErrorCode, float SearchStep);

		// Token: 0x06008BDF RID: 35807
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsVoxelSystemInitialized_Internal(IntPtr World);

		// Token: 0x06008BE0 RID: 35808
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsCavernAtPos_Internal(IntPtr World, FVector UEPos);

		// Token: 0x06008BE1 RID: 35809
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetVoxelInfoAtPos_Internal(IntPtr World, FVector UEPos, ref int ErrorCode, float SearchStep);

		// Token: 0x06008BE2 RID: 35810
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetMtlNameByID_Internal(byte MtlID);

		// Token: 0x06008BE3 RID: 35811
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern byte __GetMaterialIDAtPos_Internal(IntPtr World, FVector UEPos);

		// Token: 0x06008BE4 RID: 35812
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __D_TryGetVoxelInfoAtPos_Internal(IntPtr World, FVectorDouble UEPos, IntPtr OutVoxelInfo, ref int ErrorCode, double SearchStep);

		// Token: 0x06008BE5 RID: 35813
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __D_IsCavernAtPos_Internal(IntPtr World, FVectorDouble UEPos);

		// Token: 0x06008BE6 RID: 35814
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __D_GetVoxelInfoAtPos_Internal(IntPtr World, FVectorDouble UEPos, ref int ErrorCode, double SearchStep);

		// Token: 0x06008BE7 RID: 35815
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern byte __D_GetMaterialIDAtPos_Internal(IntPtr World, FVectorDouble UEPos);

		// Token: 0x06008BE8 RID: 35816 RVA: 0x000D27C4 File Offset: 0x000D09C4
		static UKuroVoxelSystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroVoxelRuntime.KuroVoxelSystem");
		}

		// Token: 0x06008BE9 RID: 35817 RVA: 0x000D27D2 File Offset: 0x000D09D2
		protected UKuroVoxelSystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003CCA RID: 15562
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroVoxelRuntime.KuroVoxelSystem";

		// Token: 0x04003CCB RID: 15563
		private static IntPtr _ClassPtr;

		// Token: 0x04003CCC RID: 15564
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
