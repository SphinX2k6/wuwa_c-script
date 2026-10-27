using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001EC2 RID: 7874
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroUtility.KuroMeshTextureFunctionLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroMeshTextureFunctionLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601DDFF RID: 122367 RVA: 0x002C315F File Offset: 0x002C135F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroMeshTextureFunctionLibrary._ClassPtr;
		}

		// Token: 0x0601DE00 RID: 122368 RVA: 0x002C316C File Offset: 0x002C136C
		public UKuroMeshTextureFunctionLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroMeshTextureFunctionLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601DE01 RID: 122369 RVA: 0x002C3194 File Offset: 0x002C1394
		[NullableContext(1)]
		public UKuroMeshTextureFunctionLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroMeshTextureFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601DE02 RID: 122370
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool UnbindStaticMeshStreamedAllMipsDelegate();

		// Token: 0x0601DE03 RID: 122371
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool UnbindSkeletalStreamedAllMipsDelegate();

		// Token: 0x0601DE04 RID: 122372
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool UnbindMeshesBundleStreamedAllMipsDelegate();

		// Token: 0x0601DE05 RID: 122373
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool StopMeshesBundleStreamingInAllMips(int UniqueInstanceID);

		// Token: 0x0601DE06 RID: 122374 RVA: 0x002C31C7 File Offset: 0x002C13C7
		public static bool IsStaticMeshComponentStreamingComplete(UStaticMesh staticMesh)
		{
			return UKuroMeshTextureFunctionLibrary.__IsStaticMeshComponentStreamingComplete_Internal((staticMesh != null) ? staticMesh.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601DE07 RID: 122375 RVA: 0x002C31DE File Offset: 0x002C13DE
		public static bool IsSkeletalMeshComponentStreamingComplete(USkeletalMesh skeletalMesh)
		{
			return UKuroMeshTextureFunctionLibrary.__IsSkeletalMeshComponentStreamingComplete_Internal((skeletalMesh != null) ? skeletalMesh.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601DE08 RID: 122376 RVA: 0x002C31F5 File Offset: 0x002C13F5
		public static void HandleStaticMeshComponentStreaming(UStaticMesh staticMesh, bool bStartForceStreamIn)
		{
			UKuroMeshTextureFunctionLibrary.__HandleStaticMeshComponentStreaming_Internal((staticMesh != null) ? staticMesh.NativePtr : IntPtr.Zero, bStartForceStreamIn);
		}

		// Token: 0x0601DE09 RID: 122377 RVA: 0x002C320D File Offset: 0x002C140D
		public static void HandleSkeletalMeshComponentStreaming(USkeletalMesh skeletalMesh, bool bStartForceStreamIn)
		{
			UKuroMeshTextureFunctionLibrary.__HandleSkeletalMeshComponentStreaming_Internal((skeletalMesh != null) ? skeletalMesh.NativePtr : IntPtr.Zero, bStartForceStreamIn);
		}

		// Token: 0x0601DE0A RID: 122378 RVA: 0x002C3225 File Offset: 0x002C1425
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

		// Token: 0x0601DE0B RID: 122379 RVA: 0x002C324D File Offset: 0x002C144D
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

		// Token: 0x0601DE0C RID: 122380 RVA: 0x002C3283 File Offset: 0x002C1483
		public static bool AddStaticMeshStreamedAllMipsDelegate(in FOnStreamedAllStaticMeshCompMips InDelegate)
		{
			FOnStreamedAllStaticMeshCompMips fonStreamedAllStaticMeshCompMips = InDelegate;
			return UKuroMeshTextureFunctionLibrary.__AddStaticMeshStreamedAllMipsDelegate_Internal((fonStreamedAllStaticMeshCompMips != null) ? fonStreamedAllStaticMeshCompMips.NativePtr : ((IntPtr)0));
		}

		// Token: 0x0601DE0D RID: 122381 RVA: 0x002C3299 File Offset: 0x002C1499
		public static bool AddSkeletalStreamedAllMipsDelegate(in FOnStreamedAllSkeletalCompMips InDelegate)
		{
			FOnStreamedAllSkeletalCompMips fonStreamedAllSkeletalCompMips = InDelegate;
			return UKuroMeshTextureFunctionLibrary.__AddSkeletalStreamedAllMipsDelegate_Internal((fonStreamedAllSkeletalCompMips != null) ? fonStreamedAllSkeletalCompMips.NativePtr : ((IntPtr)0));
		}

		// Token: 0x0601DE0E RID: 122382 RVA: 0x002C32AF File Offset: 0x002C14AF
		public static bool AddMeshesBundleStreamedAllMipsDelegate(in FOnStreamedMeshesCompBundleAllMips InDelegate)
		{
			FOnStreamedMeshesCompBundleAllMips fonStreamedMeshesCompBundleAllMips = InDelegate;
			return UKuroMeshTextureFunctionLibrary.__AddMeshesBundleStreamedAllMipsDelegate_Internal((fonStreamedMeshesCompBundleAllMips != null) ? fonStreamedMeshesCompBundleAllMips.NativePtr : ((IntPtr)0));
		}

		// Token: 0x0601DE0F RID: 122383
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsStaticMeshComponentStreamingComplete_Internal(IntPtr staticMesh);

		// Token: 0x0601DE10 RID: 122384
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsSkeletalMeshComponentStreamingComplete_Internal(IntPtr skeletalMesh);

		// Token: 0x0601DE11 RID: 122385
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __HandleStaticMeshComponentStreaming_Internal(IntPtr staticMesh, bool bStartForceStreamIn);

		// Token: 0x0601DE12 RID: 122386
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __HandleSkeletalMeshComponentStreaming_Internal(IntPtr skeletalMesh, bool bStartForceStreamIn);

		// Token: 0x0601DE13 RID: 122387
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __HandleMeshesComponentsBundleStreaming_Internal(IntPtr MeshBundleSkeletalMeshes, IntPtr MeshBundleStaticMeshes, bool bStartForceStreamIn);

		// Token: 0x0601DE14 RID: 122388
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __ForceMeshesBundleStreamingInAllMips_Internal(IntPtr MeshBundleSkeletalMeshes, IntPtr MeshBundleStaticMeshes, IntPtr InDelegate);

		// Token: 0x0601DE15 RID: 122389
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __AddStaticMeshStreamedAllMipsDelegate_Internal(IntPtr InDelegate);

		// Token: 0x0601DE16 RID: 122390
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __AddSkeletalStreamedAllMipsDelegate_Internal(IntPtr InDelegate);

		// Token: 0x0601DE17 RID: 122391
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __AddMeshesBundleStreamedAllMipsDelegate_Internal(IntPtr InDelegate);

		// Token: 0x0601DE18 RID: 122392 RVA: 0x002C32C5 File Offset: 0x002C14C5
		static UKuroMeshTextureFunctionLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroUtility.KuroMeshTextureFunctionLibrary");
		}

		// Token: 0x0601DE19 RID: 122393 RVA: 0x002C32D3 File Offset: 0x002C14D3
		protected UKuroMeshTextureFunctionLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040102F5 RID: 66293
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroUtility.KuroMeshTextureFunctionLibrary";

		// Token: 0x040102F6 RID: 66294
		private static IntPtr _ClassPtr;

		// Token: 0x040102F7 RID: 66295
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
