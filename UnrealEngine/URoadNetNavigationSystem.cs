using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020026D3 RID: 9939
	[UnrealObjectPath("/Script/RoadNetNavigationRuntime.RoadNetNavigationSystem")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 144)]
	public class URoadNetNavigationSystem : URoadNetNavigationSystemBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06024E52 RID: 151122 RVA: 0x003692B7 File Offset: 0x003674B7
		public new static UClassStackOnlyPtr StaticClass()
		{
			return URoadNetNavigationSystem._ClassPtr;
		}

		// Token: 0x06024E53 RID: 151123 RVA: 0x003692C4 File Offset: 0x003674C4
		public URoadNetNavigationSystem() : this(BuiltinUtils.AllocNativeUObject(URoadNetNavigationSystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06024E54 RID: 151124 RVA: 0x003692EC File Offset: 0x003674EC
		[NullableContext(1)]
		public URoadNetNavigationSystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(URoadNetNavigationSystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06024E55 RID: 151125 RVA: 0x0036931F File Offset: 0x0036751F
		[NullableContext(2)]
		public static URoadNetNavigationPath RoadNet_FindPathToLocationSynchronously(UObject WorldContextObject, in FVector PathStart, in FVector PathEnd)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<URoadNetNavigationPath>(URoadNetNavigationSystem.__RoadNet_FindPathToLocationSynchronously_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, PathStart, PathEnd));
		}

		// Token: 0x06024E56 RID: 151126
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __RoadNet_FindPathToLocationSynchronously_Internal(IntPtr WorldContextObject, in FVector PathStart, in FVector PathEnd);

		// Token: 0x06024E57 RID: 151127 RVA: 0x0036933D File Offset: 0x0036753D
		static URoadNetNavigationSystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/RoadNetNavigationRuntime.RoadNetNavigationSystem");
		}

		// Token: 0x06024E58 RID: 151128 RVA: 0x0036934B File Offset: 0x0036754B
		protected URoadNetNavigationSystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013E01 RID: 81409
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/RoadNetNavigationRuntime.RoadNetNavigationSystem";

		// Token: 0x04013E02 RID: 81410
		private static IntPtr _ClassPtr;

		// Token: 0x04013E03 RID: 81411
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
