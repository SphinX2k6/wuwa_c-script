using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020005DD RID: 1501
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroUtility.KuroMeshTextureFunctionLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroMeshTextureFunctionLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060084B3 RID: 33971 RVA: 0x000C4E4F File Offset: 0x000C304F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroMeshTextureFunctionLibrary._ClassPtr;
		}

		// Token: 0x060084B4 RID: 33972 RVA: 0x000C4E5C File Offset: 0x000C305C
		public UKuroMeshTextureFunctionLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroMeshTextureFunctionLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060084B5 RID: 33973 RVA: 0x000C4E84 File Offset: 0x000C3084
		[NullableContext(1)]
		public UKuroMeshTextureFunctionLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroMeshTextureFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060084B6 RID: 33974
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool UnbindStaticMeshStreamedAllMipsDelegate();

		// Token: 0x060084B7 RID: 33975
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool UnbindSkeletalStreamedAllMipsDelegate();

		// Token: 0x060084B8 RID: 33976
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool UnbindMeshesBundleStreamedAllMipsDelegate();

		// Token: 0x060084B9 RID: 33977
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool StopMeshesBundleStreamingInAllMips(int UniqueInstanceID);

		// Token: 0x060084BA RID: 33978 RVA: 0x000C4EB7 File Offset: 0x000C30B7
		public static bool IsStaticMeshComponentStreamingComplete(UStaticMesh staticMesh)
		{
			return UKuroMeshTextureFunctionLibrary.__IsStaticMeshComponentStreamingComplete_Internal((staticMesh != null) ? staticMesh.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060084BB RID: 33979 RVA: 0x000C4ECE File Offset: 0x000C30CE
		public static bool IsSkeletalMeshComponentStreamingComplete(USkeletalMesh skeletalMesh)
		{
			return UKuroMeshTextureFunctionLibrary.__IsSkeletalMeshComponentStreamingComplete_Internal((skeletalMesh != null) ? skeletalMesh.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060084BC RID: 33980 RVA: 0x000C4EE5 File Offset: 0x000C30E5
		public static void HandleStaticMeshComponentStreaming(UStaticMesh staticMesh, bool bStartForceStreamIn)
		{
			UKuroMeshTextureFunctionLibrary.__HandleStaticMeshComponentStreaming_Internal((staticMesh != null) ? staticMesh.NativePtr : IntPtr.Zero, bStartForceStreamIn);
		}

		// Token: 0x060084BD RID: 33981 RVA: 0x000C4EFD File Offset: 0x000C30FD
		public static void HandleSkeletalMeshComponentStreaming(USkeletalMesh skeletalMesh, bool bStartForceStreamIn)
		{
			UKuroMeshTextureFunctionLibrary.__HandleSkeletalMeshComponentStreaming_Internal((skeletalMesh != null) ? skeletalMesh.NativePtr : IntPtr.Zero, bStartForceStreamIn);
		}

		// Token: 0x060084BE RID: 33982 RVA: 0x000C4F15 File Offset: 0x000C3115
		public static void HandleMeshesComponentsBundleStreaming([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<USkeletalMesh> MeshBundleSkeletalMeshes, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<UStaticMesh> MeshBundleStaticMeshes, bool bStartForceStreamIn)
		{
			UKuroMeshTextureFunctionLibrary.__HandleMeshesComponentsBundleStreaming_Internal((MeshBundleSkeletalMeshes ?? new TArray<USkeletalMesh>()).NativePtr, (MeshBundleStaticMeshes ?? new TArray<UStaticMesh>()).NativePtr, bStartForceStreamIn);
		}

		// Token: 0x060084BF RID: 33983 RVA: 0x000C4F3D File Offset: 0x000C313D
		public static int ForceMeshesBundleStreamingInAllMips([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<USkeletalMesh> MeshBundleSkeletalMeshes, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<UStaticMesh> MeshBundleStaticMeshes, in FOnStreamedMeshesCompBundleAllMips InDelegate)
		{
			IntPtr nativePtr = (MeshBundleSkeletalMeshes ?? new TArray<USkeletalMesh>()).NativePtr;
			IntPtr nativePtr2 = (MeshBundleStaticMeshes ?? new TArray<UStaticMesh>()).NativePtr;
			FOnStreamedMeshesCompBundleAllMips fonStreamedMeshesCompBundleAllMips = InDelegate;
			return UKuroMeshTextureFunctionLibrary.__ForceMeshesBundleStreamingInAllMips_Internal(nativePtr, nativePtr2, (fonStreamedMeshesCompBundleAllMips != null) ? fonStreamedMeshesCompBundleAllMips.NativePtr : ((IntPtr)0));
		}

		// Token: 0x060084C0 RID: 33984 RVA: 0x000C4F73 File Offset: 0x000C3173
		public static bool AddStaticMeshStreamedAllMipsDelegate(in FOnStreamedAllStaticMeshCompMips InDelegate)
		{
			FOnStreamedAllStaticMeshCompMips fonStreamedAllStaticMeshCompMips = InDelegate;
			return UKuroMeshTextureFunctionLibrary.__AddStaticMeshStreamedAllMipsDelegate_Internal((fonStreamedAllStaticMeshCompMips != null) ? fonStreamedAllStaticMeshCompMips.NativePtr : ((IntPtr)0));
		}

		// Token: 0x060084C1 RID: 33985 RVA: 0x000C4F89 File Offset: 0x000C3189
		public static bool AddSkeletalStreamedAllMipsDelegate(in FOnStreamedAllSkeletalCompMips InDelegate)
		{
			FOnStreamedAllSkeletalCompMips fonStreamedAllSkeletalCompMips = InDelegate;
			return UKuroMeshTextureFunctionLibrary.__AddSkeletalStreamedAllMipsDelegate_Internal((fonStreamedAllSkeletalCompMips != null) ? fonStreamedAllSkeletalCompMips.NativePtr : ((IntPtr)0));
		}

		// Token: 0x060084C2 RID: 33986 RVA: 0x000C4F9F File Offset: 0x000C319F
		public static bool AddMeshesBundleStreamedAllMipsDelegate(in FOnStreamedMeshesCompBundleAllMips InDelegate)
		{
			FOnStreamedMeshesCompBundleAllMips fonStreamedMeshesCompBundleAllMips = InDelegate;
			return UKuroMeshTextureFunctionLibrary.__AddMeshesBundleStreamedAllMipsDelegate_Internal((fonStreamedMeshesCompBundleAllMips != null) ? fonStreamedMeshesCompBundleAllMips.NativePtr : ((IntPtr)0));
		}

		// Token: 0x060084C3 RID: 33987
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsStaticMeshComponentStreamingComplete_Internal(IntPtr staticMesh);

		// Token: 0x060084C4 RID: 33988
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsSkeletalMeshComponentStreamingComplete_Internal(IntPtr skeletalMesh);

		// Token: 0x060084C5 RID: 33989
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __HandleStaticMeshComponentStreaming_Internal(IntPtr staticMesh, bool bStartForceStreamIn);

		// Token: 0x060084C6 RID: 33990
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __HandleSkeletalMeshComponentStreaming_Internal(IntPtr skeletalMesh, bool bStartForceStreamIn);

		// Token: 0x060084C7 RID: 33991
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __HandleMeshesComponentsBundleStreaming_Internal(IntPtr MeshBundleSkeletalMeshes, IntPtr MeshBundleStaticMeshes, bool bStartForceStreamIn);

		// Token: 0x060084C8 RID: 33992
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __ForceMeshesBundleStreamingInAllMips_Internal(IntPtr MeshBundleSkeletalMeshes, IntPtr MeshBundleStaticMeshes, IntPtr InDelegate);

		// Token: 0x060084C9 RID: 33993
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __AddStaticMeshStreamedAllMipsDelegate_Internal(IntPtr InDelegate);

		// Token: 0x060084CA RID: 33994
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __AddSkeletalStreamedAllMipsDelegate_Internal(IntPtr InDelegate);

		// Token: 0x060084CB RID: 33995
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __AddMeshesBundleStreamedAllMipsDelegate_Internal(IntPtr InDelegate);

		// Token: 0x060084CC RID: 33996 RVA: 0x000C4FB5 File Offset: 0x000C31B5
		static UKuroMeshTextureFunctionLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroUtility.KuroMeshTextureFunctionLibrary");
		}

		// Token: 0x060084CD RID: 33997 RVA: 0x000C4FC3 File Offset: 0x000C31C3
		protected UKuroMeshTextureFunctionLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040039FE RID: 14846
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroUtility.KuroMeshTextureFunctionLibrary";

		// Token: 0x040039FF RID: 14847
		private static IntPtr _ClassPtr;

		// Token: 0x04003A00 RID: 14848
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
