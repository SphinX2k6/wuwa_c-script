using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020019EB RID: 6635
	[UnrealObjectPath("/Script/KuroNavMeshCookData.NavMeshCookDataSubsystem")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public class UNavMeshCookDataSubsystem : UWorldSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060189CC RID: 100812 RVA: 0x00244432 File Offset: 0x00242632
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNavMeshCookDataSubsystem._ClassPtr;
		}

		// Token: 0x060189CD RID: 100813 RVA: 0x00244440 File Offset: 0x00242640
		public UNavMeshCookDataSubsystem() : this(BuiltinUtils.AllocNativeUObject(UNavMeshCookDataSubsystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060189CE RID: 100814 RVA: 0x00244468 File Offset: 0x00242668
		[NullableContext(1)]
		public UNavMeshCookDataSubsystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNavMeshCookDataSubsystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060189CF RID: 100815 RVA: 0x0024449B File Offset: 0x0024269B
		[NullableContext(2)]
		public bool D_QueryNavBoundaryEdges(in FBox QueryBounds, ref TArray<FVectorDouble> OutBoundaryEdgesDouble)
		{
			return UNavMeshCookDataSubsystem.__D_QueryNavBoundaryEdges_Internal(base.NativePtr, QueryBounds, (OutBoundaryEdgesDouble ?? new TArray<FVectorDouble>()).NativePtr);
		}

		// Token: 0x060189D0 RID: 100816 RVA: 0x002444B9 File Offset: 0x002426B9
		[NullableContext(2)]
		public bool D_MultiQueryNavBoundaryEdges(in TArray<FBox> QueryBoundsArr)
		{
			return UNavMeshCookDataSubsystem.__D_MultiQueryNavBoundaryEdges_Internal(base.NativePtr, (QueryBoundsArr ?? new TArray<FBox>()).NativePtr);
		}

		// Token: 0x060189D1 RID: 100817
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __D_QueryNavBoundaryEdges_Internal(IntPtr @this, in FBox QueryBounds, IntPtr OutBoundaryEdgesDouble);

		// Token: 0x060189D2 RID: 100818
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __D_MultiQueryNavBoundaryEdges_Internal(IntPtr @this, IntPtr QueryBoundsArr);

		// Token: 0x060189D3 RID: 100819 RVA: 0x002444D6 File Offset: 0x002426D6
		static UNavMeshCookDataSubsystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroNavMeshCookData.NavMeshCookDataSubsystem");
		}

		// Token: 0x060189D4 RID: 100820 RVA: 0x002444E4 File Offset: 0x002426E4
		protected UNavMeshCookDataSubsystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400D4DA RID: 54490
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroNavMeshCookData.NavMeshCookDataSubsystem";

		// Token: 0x0400D4DB RID: 54491
		private static IntPtr _ClassPtr;

		// Token: 0x0400D4DC RID: 54492
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
