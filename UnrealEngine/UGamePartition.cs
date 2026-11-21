using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200039E RID: 926
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGamePartition.GamePartition")]
	[UnrealStructLayout(712, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 712)]
	public class UGamePartition : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06005BCF RID: 23503 RVA: 0x000815ED File Offset: 0x0007F7ED
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGamePartition._ClassPtr;
		}

		// Token: 0x06005BD0 RID: 23504 RVA: 0x000815FC File Offset: 0x0007F7FC
		public UGamePartition() : this(BuiltinUtils.AllocNativeUObject(UGamePartition.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06005BD1 RID: 23505 RVA: 0x00081624 File Offset: 0x0007F824
		public UGamePartition(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGamePartition.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06005BD2 RID: 23506 RVA: 0x00081657 File Offset: 0x0007F857
		[NullableContext(2)]
		public void Remove(AActor Actor)
		{
			UGamePartition.__Remove_Internal(base.NativePtr, (Actor != null) ? Actor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06005BD3 RID: 23507 RVA: 0x00081674 File Offset: 0x0007F874
		public TArray<FGamePartitionObject> RangeQuery(in FVectorDouble QueryOrigin, double QuerySphereRadius, int QueryType, int QuerySubType = 0, bool bConsiderObjectPosition = true)
		{
			return new TArray<FGamePartitionObject>(UGamePartition.__RangeQuery_Internal(base.NativePtr, QueryOrigin, QuerySphereRadius, QueryType, QuerySubType, bConsiderObjectPosition), null);
		}

		// Token: 0x06005BD4 RID: 23508 RVA: 0x0008168E File Offset: 0x0007F88E
		public void K2_Remove(int ID)
		{
			UGamePartition.__K2_Remove_Internal(base.NativePtr, ID);
		}

		// Token: 0x06005BD5 RID: 23509 RVA: 0x0008169C File Offset: 0x0007F89C
		public TArray<FGamePartitionObject> K2_RangeQueryWithBounds(in FBox QueryBounds, int QueryType, int QuerySubType = 0, bool bConsiderObjectPosition = true)
		{
			return new TArray<FGamePartitionObject>(UGamePartition.__K2_RangeQueryWithBounds_Internal(base.NativePtr, QueryBounds, QueryType, QuerySubType, bConsiderObjectPosition), null);
		}

		// Token: 0x06005BD6 RID: 23510 RVA: 0x000816B4 File Offset: 0x0007F8B4
		[NullableContext(2)]
		public void K2_Insert(int ID, AActor Actor, int Type, int SubType = 0, bool bUseActorBounds = false)
		{
			UGamePartition.__K2_Insert_Internal(base.NativePtr, ID, (Actor != null) ? Actor.NativePtr : IntPtr.Zero, Type, SubType, bUseActorBounds);
		}

		// Token: 0x06005BD7 RID: 23511 RVA: 0x000816D7 File Offset: 0x0007F8D7
		[NullableContext(2)]
		public int Insert(AActor Actor, int Type)
		{
			return UGamePartition.__Insert_Internal(base.NativePtr, (Actor != null) ? Actor.NativePtr : IntPtr.Zero, Type);
		}

		// Token: 0x06005BD8 RID: 23512 RVA: 0x000816F5 File Offset: 0x0007F8F5
		public int AllocateNewID()
		{
			return UGamePartition.__AllocateNewID_Internal(base.NativePtr);
		}

		// Token: 0x06005BD9 RID: 23513
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Remove_Internal(IntPtr @this, IntPtr Actor);

		// Token: 0x06005BDA RID: 23514
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __RangeQuery_Internal(IntPtr @this, in FVectorDouble QueryOrigin, double QuerySphereRadius, int QueryType, int QuerySubType, bool bConsiderObjectPosition);

		// Token: 0x06005BDB RID: 23515
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_Remove_Internal(IntPtr @this, int ID);

		// Token: 0x06005BDC RID: 23516
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __K2_RangeQueryWithBounds_Internal(IntPtr @this, in FBox QueryBounds, int QueryType, int QuerySubType, bool bConsiderObjectPosition);

		// Token: 0x06005BDD RID: 23517
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_Insert_Internal(IntPtr @this, int ID, IntPtr Actor, int Type, int SubType, bool bUseActorBounds);

		// Token: 0x06005BDE RID: 23518
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __Insert_Internal(IntPtr @this, IntPtr Actor, int Type);

		// Token: 0x06005BDF RID: 23519
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __AllocateNewID_Internal(IntPtr @this);

		// Token: 0x06005BE0 RID: 23520 RVA: 0x00081702 File Offset: 0x0007F902
		static UGamePartition()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGamePartition.GamePartition");
		}

		// Token: 0x06005BE1 RID: 23521 RVA: 0x00081710 File Offset: 0x0007F910
		protected UGamePartition(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002639 RID: 9785
		public new const string __ObjectPath = "/Script/KuroGamePartition.GamePartition";

		// Token: 0x0400263A RID: 9786
		private static IntPtr _ClassPtr;

		// Token: 0x0400263B RID: 9787
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
