using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007C3 RID: 1987
	[UnrealObjectPath("/Script/RoadNetNavigationRuntime.RoadNetNavigationSystem")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 144)]
	public class URoadNetNavigationSystem : URoadNetNavigationSystemBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600ABE5 RID: 44005 RVA: 0x000FD878 File Offset: 0x000FBA78
		public new static UClassStackOnlyPtr StaticClass()
		{
			return URoadNetNavigationSystem._ClassPtr;
		}

		// Token: 0x0600ABE6 RID: 44006 RVA: 0x000FD884 File Offset: 0x000FBA84
		public URoadNetNavigationSystem() : this(BuiltinUtils.AllocNativeUObject(URoadNetNavigationSystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600ABE7 RID: 44007 RVA: 0x000FD8AC File Offset: 0x000FBAAC
		[NullableContext(1)]
		public URoadNetNavigationSystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(URoadNetNavigationSystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600ABE8 RID: 44008 RVA: 0x000FD8DF File Offset: 0x000FBADF
		[NullableContext(2)]
		public static URoadNetNavigationPath RoadNet_FindPathToLocationSynchronously(UObject WorldContextObject, in FVector PathStart, in FVector PathEnd)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<URoadNetNavigationPath>(URoadNetNavigationSystem.__RoadNet_FindPathToLocationSynchronously_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, PathStart, PathEnd));
		}

		// Token: 0x0600ABE9 RID: 44009
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __RoadNet_FindPathToLocationSynchronously_Internal(IntPtr WorldContextObject, in FVector PathStart, in FVector PathEnd);

		// Token: 0x0600ABEA RID: 44010 RVA: 0x000FD8FD File Offset: 0x000FBAFD
		static URoadNetNavigationSystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/RoadNetNavigationRuntime.RoadNetNavigationSystem");
		}

		// Token: 0x0600ABEB RID: 44011 RVA: 0x000FD90B File Offset: 0x000FBB0B
		protected URoadNetNavigationSystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040049EC RID: 18924
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/RoadNetNavigationRuntime.RoadNetNavigationSystem";

		// Token: 0x040049ED RID: 18925
		private static IntPtr _ClassPtr;

		// Token: 0x040049EE RID: 18926
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
