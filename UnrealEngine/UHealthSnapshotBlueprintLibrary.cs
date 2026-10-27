using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000C1A RID: 3098
	[UnrealObjectPath("/Script/Engine.HealthSnapshotBlueprintLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UHealthSnapshotBlueprintLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06009C83 RID: 40067 RVA: 0x000DE903 File Offset: 0x000DCB03
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UHealthSnapshotBlueprintLibrary._ClassPtr;
		}

		// Token: 0x06009C84 RID: 40068 RVA: 0x000DE910 File Offset: 0x000DCB10
		public UHealthSnapshotBlueprintLibrary() : this(BuiltinUtils.AllocNativeUObject(UHealthSnapshotBlueprintLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06009C85 RID: 40069 RVA: 0x000DE938 File Offset: 0x000DCB38
		[NullableContext(1)]
		public UHealthSnapshotBlueprintLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UHealthSnapshotBlueprintLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06009C86 RID: 40070
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void StopPerformanceSnapshots();

		// Token: 0x06009C87 RID: 40071
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void StartPerformanceSnapshots();

		// Token: 0x06009C88 RID: 40072 RVA: 0x000DE96C File Offset: 0x000DCB6C
		[NullableContext(1)]
		public unsafe static void LogPerformanceSnapshot(string SnapshotTitle, bool bResetStats = true)
		{
			FString fstring = FString.AllocTemp(SnapshotTitle);
			UHealthSnapshotBlueprintLibrary.__LogPerformanceSnapshot_Internal(fstring, bResetStats);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06009C89 RID: 40073
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LogPerformanceSnapshot_Internal(in FString SnapshotTitle, bool bResetStats);

		// Token: 0x06009C8A RID: 40074 RVA: 0x000DE991 File Offset: 0x000DCB91
		static UHealthSnapshotBlueprintLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.HealthSnapshotBlueprintLibrary");
		}

		// Token: 0x06009C8B RID: 40075 RVA: 0x000DE99F File Offset: 0x000DCB9F
		protected UHealthSnapshotBlueprintLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005661 RID: 22113
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.HealthSnapshotBlueprintLibrary";

		// Token: 0x04005662 RID: 22114
		private static IntPtr _ClassPtr;

		// Token: 0x04005663 RID: 22115
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
