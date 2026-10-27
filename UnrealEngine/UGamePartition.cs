using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001871 RID: 6257
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGamePartition.GamePartition")]
	[UnrealStructLayout(712, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 712)]
	public class UGamePartition : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060170B4 RID: 94388 RVA: 0x0021950F File Offset: 0x0021770F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGamePartition._ClassPtr;
		}

		// Token: 0x060170B5 RID: 94389 RVA: 0x0021951C File Offset: 0x0021771C
		public UGamePartition() : this(BuiltinUtils.AllocNativeUObject(UGamePartition.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060170B6 RID: 94390 RVA: 0x00219544 File Offset: 0x00217744
		public UGamePartition(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGamePartition.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060170B7 RID: 94391 RVA: 0x00219577 File Offset: 0x00217777
		[NullableContext(2)]
		public void Remove(AActor Actor)
		{
			UGamePartition.__Remove_Internal(base.NativePtr, (Actor != null) ? Actor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060170B8 RID: 94392 RVA: 0x00219594 File Offset: 0x00217794
		public TArray<FGamePartitionObject> RangeQuery(in FVectorDouble QueryOrigin, double QuerySphereRadius, int QueryType, int QuerySubType = 0, bool bConsiderObjectPosition = true)
		{
			return new TArray<FGamePartitionObject>(UGamePartition.__RangeQuery_Internal(base.NativePtr, QueryOrigin, QuerySphereRadius, QueryType, QuerySubType, bConsiderObjectPosition), null);
		}

		// Token: 0x060170B9 RID: 94393 RVA: 0x002195AE File Offset: 0x002177AE
		public void K2_Remove(int ID)
		{
			UGamePartition.__K2_Remove_Internal(base.NativePtr, ID);
		}

		// Token: 0x060170BA RID: 94394 RVA: 0x002195BC File Offset: 0x002177BC
		public TArray<FGamePartitionObject> K2_RangeQueryWithBounds(in FBox QueryBounds, int QueryType, int QuerySubType = 0, bool bConsiderObjectPosition = true)
		{
			return new TArray<FGamePartitionObject>(UGamePartition.__K2_RangeQueryWithBounds_Internal(base.NativePtr, QueryBounds, QueryType, QuerySubType, bConsiderObjectPosition), null);
		}

		// Token: 0x060170BB RID: 94395 RVA: 0x002195D4 File Offset: 0x002177D4
		[NullableContext(2)]
		public void K2_Insert(int ID, AActor Actor, int Type, int SubType = 0, bool bUseActorBounds = false)
		{
			UGamePartition.__K2_Insert_Internal(base.NativePtr, ID, (Actor != null) ? Actor.NativePtr : IntPtr.Zero, Type, SubType, bUseActorBounds);
		}

		// Token: 0x060170BC RID: 94396 RVA: 0x002195F7 File Offset: 0x002177F7
		[NullableContext(2)]
		public int Insert(AActor Actor, int Type)
		{
			return UGamePartition.__Insert_Internal(base.NativePtr, (Actor != null) ? Actor.NativePtr : IntPtr.Zero, Type);
		}

		// Token: 0x060170BD RID: 94397 RVA: 0x00219615 File Offset: 0x00217815
		public int AllocateNewID()
		{
			return UGamePartition.__AllocateNewID_Internal(base.NativePtr);
		}

		// Token: 0x060170BE RID: 94398
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Remove_Internal(IntPtr @this, IntPtr Actor);

		// Token: 0x060170BF RID: 94399
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __RangeQuery_Internal(IntPtr @this, in FVectorDouble QueryOrigin, double QuerySphereRadius, int QueryType, int QuerySubType, bool bConsiderObjectPosition);

		// Token: 0x060170C0 RID: 94400
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_Remove_Internal(IntPtr @this, int ID);

		// Token: 0x060170C1 RID: 94401
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __K2_RangeQueryWithBounds_Internal(IntPtr @this, in FBox QueryBounds, int QueryType, int QuerySubType, bool bConsiderObjectPosition);

		// Token: 0x060170C2 RID: 94402
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_Insert_Internal(IntPtr @this, int ID, IntPtr Actor, int Type, int SubType, bool bUseActorBounds);

		// Token: 0x060170C3 RID: 94403
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __Insert_Internal(IntPtr @this, IntPtr Actor, int Type);

		// Token: 0x060170C4 RID: 94404
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __AllocateNewID_Internal(IntPtr @this);

		// Token: 0x060170C5 RID: 94405 RVA: 0x00219622 File Offset: 0x00217822
		static UGamePartition()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGamePartition.GamePartition");
		}

		// Token: 0x060170C6 RID: 94406 RVA: 0x00219630 File Offset: 0x00217830
		protected UGamePartition(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400C819 RID: 51225
		public new const string __ObjectPath = "/Script/KuroGamePartition.GamePartition";

		// Token: 0x0400C81A RID: 51226
		private static IntPtr _ClassPtr;

		// Token: 0x0400C81B RID: 51227
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
