using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000453 RID: 1107
	[UnrealObjectPath("/Script/ChaosSolverEngine.ChaosSolverEngineBlueprintLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UChaosSolverEngineBlueprintLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06003BCE RID: 15310 RVA: 0x0005A1EE File Offset: 0x000583EE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UChaosSolverEngineBlueprintLibrary._ClassPtr;
		}

		// Token: 0x06003BCF RID: 15311 RVA: 0x0005A1FC File Offset: 0x000583FC
		public UChaosSolverEngineBlueprintLibrary() : this(BuiltinUtils.AllocNativeUObject(UChaosSolverEngineBlueprintLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06003BD0 RID: 15312 RVA: 0x0005A224 File Offset: 0x00058424
		[NullableContext(1)]
		public UChaosSolverEngineBlueprintLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UChaosSolverEngineBlueprintLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06003BD1 RID: 15313 RVA: 0x0005A257 File Offset: 0x00058457
		[NullableContext(1)]
		public static FHitResult ConvertPhysicsCollisionToHitResult([Nullable(2)] in FChaosPhysicsCollisionInfo PhysicsCollision)
		{
			return new FHitResult(UChaosSolverEngineBlueprintLibrary.__ConvertPhysicsCollisionToHitResult_Internal((PhysicsCollision ?? new FChaosPhysicsCollisionInfo()).NativePtr), null);
		}

		// Token: 0x06003BD2 RID: 15314
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __ConvertPhysicsCollisionToHitResult_Internal(IntPtr PhysicsCollision);

		// Token: 0x06003BD3 RID: 15315 RVA: 0x0005A274 File Offset: 0x00058474
		static UChaosSolverEngineBlueprintLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/ChaosSolverEngine.ChaosSolverEngineBlueprintLibrary");
		}

		// Token: 0x06003BD4 RID: 15316 RVA: 0x0005A282 File Offset: 0x00058482
		protected UChaosSolverEngineBlueprintLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001B8D RID: 7053
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ChaosSolverEngine.ChaosSolverEngineBlueprintLibrary";

		// Token: 0x04001B8E RID: 7054
		private static IntPtr _ClassPtr;

		// Token: 0x04001B8F RID: 7055
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
