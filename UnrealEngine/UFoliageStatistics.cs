using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020012C7 RID: 4807
	[UnrealObjectPath("/Script/Foliage.FoliageStatistics")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UFoliageStatistics : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06011967 RID: 72039 RVA: 0x0019CC7C File Offset: 0x0019AE7C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UFoliageStatistics._ClassPtr;
		}

		// Token: 0x06011968 RID: 72040 RVA: 0x0019CC88 File Offset: 0x0019AE88
		public UFoliageStatistics() : this(BuiltinUtils.AllocNativeUObject(UFoliageStatistics.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06011969 RID: 72041 RVA: 0x0019CCB0 File Offset: 0x0019AEB0
		[NullableContext(1)]
		public UFoliageStatistics(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UFoliageStatistics.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601196A RID: 72042 RVA: 0x0019CCE3 File Offset: 0x0019AEE3
		[NullableContext(2)]
		public static int FoliageOverlappingSphereCount(UObject WorldContextObject, UStaticMesh StaticMesh, FVector CenterPosition, float Radius)
		{
			return UFoliageStatistics.__FoliageOverlappingSphereCount_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (StaticMesh != null) ? StaticMesh.NativePtr : IntPtr.Zero, CenterPosition, Radius);
		}

		// Token: 0x0601196B RID: 72043 RVA: 0x0019CD0C File Offset: 0x0019AF0C
		[NullableContext(2)]
		public static int FoliageOverlappingBoxCount(UObject WorldContextObject, UStaticMesh StaticMesh, FBox Box)
		{
			return UFoliageStatistics.__FoliageOverlappingBoxCount_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (StaticMesh != null) ? StaticMesh.NativePtr : IntPtr.Zero, Box);
		}

		// Token: 0x0601196C RID: 72044
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __FoliageOverlappingSphereCount_Internal(IntPtr WorldContextObject, IntPtr StaticMesh, FVector CenterPosition, float Radius);

		// Token: 0x0601196D RID: 72045
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __FoliageOverlappingBoxCount_Internal(IntPtr WorldContextObject, IntPtr StaticMesh, FBox Box);

		// Token: 0x0601196E RID: 72046 RVA: 0x0019CD34 File Offset: 0x0019AF34
		static UFoliageStatistics()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Foliage.FoliageStatistics");
		}

		// Token: 0x0601196F RID: 72047 RVA: 0x0019CD42 File Offset: 0x0019AF42
		protected UFoliageStatistics(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040096C0 RID: 38592
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Foliage.FoliageStatistics";

		// Token: 0x040096C1 RID: 38593
		private static IntPtr _ClassPtr;

		// Token: 0x040096C2 RID: 38594
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
