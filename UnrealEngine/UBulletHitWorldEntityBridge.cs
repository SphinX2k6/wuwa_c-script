using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200171E RID: 5918
	[UnrealObjectPath("/Script/KuroBullet.BulletHitWorldEntityBridge")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UBulletHitWorldEntityBridge : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06015544 RID: 87364 RVA: 0x001F59AF File Offset: 0x001F3BAF
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBulletHitWorldEntityBridge._ClassPtr;
		}

		// Token: 0x06015545 RID: 87365 RVA: 0x001F59BC File Offset: 0x001F3BBC
		public UBulletHitWorldEntityBridge() : this(BuiltinUtils.AllocNativeUObject(UBulletHitWorldEntityBridge.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06015546 RID: 87366 RVA: 0x001F59E4 File Offset: 0x001F3BE4
		[NullableContext(1)]
		public UBulletHitWorldEntityBridge(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBulletHitWorldEntityBridge.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06015547 RID: 87367 RVA: 0x001F5A17 File Offset: 0x001F3C17
		public virtual void NotifyExistedOperationList()
		{
			UBulletHitWorldEntityBridge.__NotifyExistedOperationList_Internal(base.NativePtr);
		}

		// Token: 0x06015548 RID: 87368 RVA: 0x001F5A24 File Offset: 0x001F3C24
		[NullableContext(2)]
		public virtual void NotifyExistedImmediatelyOperation(in FBulletHitWorldEntityOperation Operation)
		{
			UBulletHitWorldEntityBridge.__NotifyExistedImmediatelyOperation_Internal(base.NativePtr, (Operation ?? new FBulletHitWorldEntityOperation()).NativePtr);
		}

		// Token: 0x06015549 RID: 87369 RVA: 0x001F5A41 File Offset: 0x001F3C41
		public virtual bool HasTag(int EntityId, in FGameplayTag Tag)
		{
			return UBulletHitWorldEntityBridge.__HasTag_Internal(base.NativePtr, EntityId, Tag);
		}

		// Token: 0x0601554A RID: 87370 RVA: 0x001F5A50 File Offset: 0x001F3C50
		public virtual int GetCampRelationship(int Camp1, int Camp2)
		{
			return UBulletHitWorldEntityBridge.__GetCampRelationship_Internal(base.NativePtr, Camp1, Camp2);
		}

		// Token: 0x0601554B RID: 87371 RVA: 0x001F5A5F File Offset: 0x001F3C5F
		public virtual int GetCamp(int EntityId)
		{
			return UBulletHitWorldEntityBridge.__GetCamp_Internal(base.NativePtr, EntityId);
		}

		// Token: 0x0601554C RID: 87372
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __NotifyExistedOperationList_Internal(IntPtr @this);

		// Token: 0x0601554D RID: 87373
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __NotifyExistedImmediatelyOperation_Internal(IntPtr @this, IntPtr Operation);

		// Token: 0x0601554E RID: 87374
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasTag_Internal(IntPtr @this, int EntityId, in FGameplayTag Tag);

		// Token: 0x0601554F RID: 87375
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetCampRelationship_Internal(IntPtr @this, int Camp1, int Camp2);

		// Token: 0x06015550 RID: 87376
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetCamp_Internal(IntPtr @this, int EntityId);

		// Token: 0x06015551 RID: 87377 RVA: 0x001F5A6D File Offset: 0x001F3C6D
		static UBulletHitWorldEntityBridge()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroBullet.BulletHitWorldEntityBridge");
		}

		// Token: 0x06015552 RID: 87378 RVA: 0x001F5A7B File Offset: 0x001F3C7B
		protected UBulletHitWorldEntityBridge(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400BA04 RID: 47620
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroBullet.BulletHitWorldEntityBridge";

		// Token: 0x0400BA05 RID: 47621
		private static IntPtr _ClassPtr;

		// Token: 0x0400BA06 RID: 47622
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x02002EF6 RID: 12022
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 88)]
		protected ref struct __NotifyExistedImmediatelyOperation_FunctionParams
		{
			// Token: 0x04016A2D RID: 92717
			[FieldOffset(0)]
			public byte Operation;
		}

		// Token: 0x02002EF7 RID: 12023
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 20)]
		protected ref struct __HasTag_FunctionParams
		{
			// Token: 0x04016A2E RID: 92718
			[FieldOffset(0)]
			public int EntityId;

			// Token: 0x04016A2F RID: 92719
			[FieldOffset(4)]
			public FGameplayTag Tag;

			// Token: 0x04016A30 RID: 92720
			[FieldOffset(16)]
			public bool __Result;
		}

		// Token: 0x02002EF8 RID: 12024
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __GetCampRelationship_FunctionParams
		{
			// Token: 0x04016A31 RID: 92721
			[FieldOffset(0)]
			public int Camp1;

			// Token: 0x04016A32 RID: 92722
			[FieldOffset(4)]
			public int Camp2;

			// Token: 0x04016A33 RID: 92723
			[FieldOffset(8)]
			public int __Result;
		}

		// Token: 0x02002EF9 RID: 12025
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetCamp_FunctionParams
		{
			// Token: 0x04016A34 RID: 92724
			[FieldOffset(0)]
			public int EntityId;

			// Token: 0x04016A35 RID: 92725
			[FieldOffset(4)]
			public int __Result;
		}
	}
}
