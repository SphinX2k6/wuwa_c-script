using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020001D0 RID: 464
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AIModule.NavLocalGridManager")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 96)]
	public class UNavLocalGridManager : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001B61 RID: 7009 RVA: 0x00028DB8 File Offset: 0x00026FB8
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNavLocalGridManager._ClassPtr;
		}

		// Token: 0x06001B62 RID: 7010 RVA: 0x00028DC4 File Offset: 0x00026FC4
		public UNavLocalGridManager() : this(BuiltinUtils.AllocNativeUObject(UNavLocalGridManager.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001B63 RID: 7011 RVA: 0x00028DEC File Offset: 0x00026FEC
		[NullableContext(1)]
		public UNavLocalGridManager(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNavLocalGridManager.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06001B64 RID: 7012 RVA: 0x00028E1F File Offset: 0x0002701F
		public static bool SetLocalNavigationGridDensity(UObject WorldContextObject, float CellSize)
		{
			return UNavLocalGridManager.__SetLocalNavigationGridDensity_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, CellSize);
		}

		// Token: 0x06001B65 RID: 7013 RVA: 0x00028E37 File Offset: 0x00027037
		public static void RemoveLocalNavigationGrid(UObject WorldContextObject, int GridId, bool bRebuildGrids = true)
		{
			UNavLocalGridManager.__RemoveLocalNavigationGrid_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, GridId, bRebuildGrids);
		}

		// Token: 0x06001B66 RID: 7014 RVA: 0x00028E50 File Offset: 0x00027050
		public static bool FindLocalNavigationGridPath(UObject WorldContextObject, in FVector Start, in FVector End, ref TArray<FVector> PathPoints)
		{
			return UNavLocalGridManager.__FindLocalNavigationGridPath_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, Start, End, (PathPoints ?? new TArray<FVector>()).NativePtr);
		}

		// Token: 0x06001B67 RID: 7015 RVA: 0x00028E79 File Offset: 0x00027079
		public static int AddLocalNavigationGridForPoints(UObject WorldContextObject, in TArray<FVector> Locations, int Radius2D = 5, float Height = 100f, bool bRebuildGrids = true)
		{
			return UNavLocalGridManager.__AddLocalNavigationGridForPoints_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (Locations ?? new TArray<FVector>()).NativePtr, Radius2D, Height, bRebuildGrids);
		}

		// Token: 0x06001B68 RID: 7016 RVA: 0x00028EA4 File Offset: 0x000270A4
		public static int AddLocalNavigationGridForPoint(UObject WorldContextObject, in FVector Location, int Radius2D = 5, float Height = 100f, bool bRebuildGrids = true)
		{
			return UNavLocalGridManager.__AddLocalNavigationGridForPoint_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, Location, Radius2D, Height, bRebuildGrids);
		}

		// Token: 0x06001B69 RID: 7017 RVA: 0x00028EC0 File Offset: 0x000270C0
		public static int AddLocalNavigationGridForCapsule(UObject WorldContextObject, in FVector Location, float CapsuleRadius, float CapsuleHalfHeight, int Radius2D = 5, float Height = 100f, bool bRebuildGrids = true)
		{
			return UNavLocalGridManager.__AddLocalNavigationGridForCapsule_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, Location, CapsuleRadius, CapsuleHalfHeight, Radius2D, Height, bRebuildGrids);
		}

		// Token: 0x06001B6A RID: 7018 RVA: 0x00028EE0 File Offset: 0x000270E0
		public static int AddLocalNavigationGridForBox(UObject WorldContextObject, in FVector Location, FVector? Extent = null, FRotator Rotation = default(FRotator), int Radius2D = 5, float Height = 100f, bool bRebuildGrids = true)
		{
			return UNavLocalGridManager.__AddLocalNavigationGridForBox_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, Location, Extent ?? new FVector(1f, 1f, 1f), Rotation, Radius2D, Height, bRebuildGrids);
		}

		// Token: 0x06001B6B RID: 7019
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SetLocalNavigationGridDensity_Internal(IntPtr WorldContextObject, float CellSize);

		// Token: 0x06001B6C RID: 7020
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveLocalNavigationGrid_Internal(IntPtr WorldContextObject, int GridId, bool bRebuildGrids);

		// Token: 0x06001B6D RID: 7021
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __FindLocalNavigationGridPath_Internal(IntPtr WorldContextObject, in FVector Start, in FVector End, IntPtr PathPoints);

		// Token: 0x06001B6E RID: 7022
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __AddLocalNavigationGridForPoints_Internal(IntPtr WorldContextObject, IntPtr Locations, int Radius2D, float Height, bool bRebuildGrids);

		// Token: 0x06001B6F RID: 7023
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __AddLocalNavigationGridForPoint_Internal(IntPtr WorldContextObject, in FVector Location, int Radius2D, float Height, bool bRebuildGrids);

		// Token: 0x06001B70 RID: 7024
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __AddLocalNavigationGridForCapsule_Internal(IntPtr WorldContextObject, in FVector Location, float CapsuleRadius, float CapsuleHalfHeight, int Radius2D, float Height, bool bRebuildGrids);

		// Token: 0x06001B71 RID: 7025
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __AddLocalNavigationGridForBox_Internal(IntPtr WorldContextObject, in FVector Location, FVector Extent, FRotator Rotation, int Radius2D, float Height, bool bRebuildGrids);

		// Token: 0x06001B72 RID: 7026 RVA: 0x00028F32 File Offset: 0x00027132
		static UNavLocalGridManager()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.NavLocalGridManager");
		}

		// Token: 0x06001B73 RID: 7027 RVA: 0x00028F40 File Offset: 0x00027140
		protected UNavLocalGridManager(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040008C8 RID: 2248
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.NavLocalGridManager";

		// Token: 0x040008C9 RID: 2249
		private static IntPtr _ClassPtr;

		// Token: 0x040008CA RID: 2250
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
