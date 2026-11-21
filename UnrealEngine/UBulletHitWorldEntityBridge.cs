using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200032F RID: 815
	[UnrealObjectPath("/Script/KuroBullet.BulletHitWorldEntityBridge")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UBulletHitWorldEntityBridge : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06005514 RID: 21780 RVA: 0x00077192 File Offset: 0x00075392
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBulletHitWorldEntityBridge._ClassPtr;
		}

		// Token: 0x06005515 RID: 21781 RVA: 0x000771A0 File Offset: 0x000753A0
		public UBulletHitWorldEntityBridge() : this(BuiltinUtils.AllocNativeUObject(UBulletHitWorldEntityBridge.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06005516 RID: 21782 RVA: 0x000771C8 File Offset: 0x000753C8
		[NullableContext(1)]
		public UBulletHitWorldEntityBridge(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBulletHitWorldEntityBridge.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06005517 RID: 21783 RVA: 0x000771FB File Offset: 0x000753FB
		public virtual void NotifyExistedOperationList()
		{
			UBulletHitWorldEntityBridge.__NotifyExistedOperationList_Internal(base.NativePtr);
		}

		// Token: 0x06005518 RID: 21784 RVA: 0x00077208 File Offset: 0x00075408
		[NullableContext(2)]
		public virtual void NotifyExistedImmediatelyOperation(in FBulletHitWorldEntityOperation Operation)
		{
			UBulletHitWorldEntityBridge.__NotifyExistedImmediatelyOperation_Internal(base.NativePtr, (Operation ?? new FBulletHitWorldEntityOperation()).NativePtr);
		}

		// Token: 0x06005519 RID: 21785 RVA: 0x00077225 File Offset: 0x00075425
		public virtual bool HasTag(int EntityId, in FGameplayTag Tag)
		{
			return UBulletHitWorldEntityBridge.__HasTag_Internal(base.NativePtr, EntityId, Tag);
		}

		// Token: 0x0600551A RID: 21786 RVA: 0x00077234 File Offset: 0x00075434
		public virtual int GetCampRelationship(int Camp1, int Camp2)
		{
			return UBulletHitWorldEntityBridge.__GetCampRelationship_Internal(base.NativePtr, Camp1, Camp2);
		}

		// Token: 0x0600551B RID: 21787 RVA: 0x00077243 File Offset: 0x00075443
		public virtual int GetCamp(int EntityId)
		{
			return UBulletHitWorldEntityBridge.__GetCamp_Internal(base.NativePtr, EntityId);
		}

		// Token: 0x0600551C RID: 21788
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __NotifyExistedOperationList_Internal(IntPtr @this);

		// Token: 0x0600551D RID: 21789
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __NotifyExistedImmediatelyOperation_Internal(IntPtr @this, IntPtr Operation);

		// Token: 0x0600551E RID: 21790
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasTag_Internal(IntPtr @this, int EntityId, in FGameplayTag Tag);

		// Token: 0x0600551F RID: 21791
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetCampRelationship_Internal(IntPtr @this, int Camp1, int Camp2);

		// Token: 0x06005520 RID: 21792
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetCamp_Internal(IntPtr @this, int EntityId);

		// Token: 0x06005521 RID: 21793 RVA: 0x00077251 File Offset: 0x00075451
		static UBulletHitWorldEntityBridge()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroBullet.BulletHitWorldEntityBridge");
		}

		// Token: 0x06005522 RID: 21794 RVA: 0x0007725F File Offset: 0x0007545F
		protected UBulletHitWorldEntityBridge(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040022C0 RID: 8896
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroBullet.BulletHitWorldEntityBridge";

		// Token: 0x040022C1 RID: 8897
		private static IntPtr _ClassPtr;

		// Token: 0x040022C2 RID: 8898
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x02000A2B RID: 2603
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 88)]
		protected ref struct __NotifyExistedImmediatelyOperation_FunctionParams
		{
			// Token: 0x04005A01 RID: 23041
			[FieldOffset(0)]
			public byte Operation;
		}

		// Token: 0x02000A2C RID: 2604
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 20)]
		protected ref struct __HasTag_FunctionParams
		{
			// Token: 0x04005A02 RID: 23042
			[FieldOffset(0)]
			public int EntityId;

			// Token: 0x04005A03 RID: 23043
			[FieldOffset(4)]
			public FGameplayTag Tag;

			// Token: 0x04005A04 RID: 23044
			[FieldOffset(16)]
			public bool __Result;
		}

		// Token: 0x02000A2D RID: 2605
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __GetCampRelationship_FunctionParams
		{
			// Token: 0x04005A05 RID: 23045
			[FieldOffset(0)]
			public int Camp1;

			// Token: 0x04005A06 RID: 23046
			[FieldOffset(4)]
			public int Camp2;

			// Token: 0x04005A07 RID: 23047
			[FieldOffset(8)]
			public int __Result;
		}

		// Token: 0x02000A2E RID: 2606
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetCamp_FunctionParams
		{
			// Token: 0x04005A08 RID: 23048
			[FieldOffset(0)]
			public int EntityId;

			// Token: 0x04005A09 RID: 23049
			[FieldOffset(4)]
			public int __Result;
		}
	}
}
