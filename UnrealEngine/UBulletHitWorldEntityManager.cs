using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000330 RID: 816
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroBullet.BulletHitWorldEntityManager")]
	[UnrealStructLayout(272, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 272)]
	public class UBulletHitWorldEntityManager : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06005523 RID: 21795 RVA: 0x00077268 File Offset: 0x00075468
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBulletHitWorldEntityManager._ClassPtr;
		}

		// Token: 0x06005524 RID: 21796 RVA: 0x00077274 File Offset: 0x00075474
		public UBulletHitWorldEntityManager() : this(BuiltinUtils.AllocNativeUObject(UBulletHitWorldEntityManager.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06005525 RID: 21797 RVA: 0x0007729C File Offset: 0x0007549C
		[NullableContext(1)]
		public UBulletHitWorldEntityManager(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBulletHitWorldEntityManager.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170010C4 RID: 4292
		// (get) Token: 0x06005526 RID: 21798 RVA: 0x000772CF File Offset: 0x000754CF
		// (set) Token: 0x06005527 RID: 21799 RVA: 0x000772E3 File Offset: 0x000754E3
		public unsafe UHitEffectManager HitEffectManager
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UHitEffectManager>(base.NativePtr / (IntPtr)sizeof(void*) + UBulletHitWorldEntityManager.__PropertyOffset_HitEffectManager);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UBulletHitWorldEntityManager.__PropertyOffset_HitEffectManager, value);
			}
		}

		// Token: 0x170010C5 RID: 4293
		// (get) Token: 0x06005528 RID: 21800 RVA: 0x000772F8 File Offset: 0x000754F8
		// (set) Token: 0x06005529 RID: 21801 RVA: 0x0007730C File Offset: 0x0007550C
		public unsafe UBulletWorld BulletWorld
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBulletWorld>(base.NativePtr / (IntPtr)sizeof(void*) + UBulletHitWorldEntityManager.__PropertyOffset_BulletWorld);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UBulletHitWorldEntityManager.__PropertyOffset_BulletWorld, value);
			}
		}

		// Token: 0x170010C6 RID: 4294
		// (get) Token: 0x0600552A RID: 21802 RVA: 0x00077321 File Offset: 0x00075521
		// (set) Token: 0x0600552B RID: 21803 RVA: 0x00077335 File Offset: 0x00075535
		public unsafe UBulletHitWorldEntityBridge BulletHitWorldEntityBridge
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBulletHitWorldEntityBridge>(base.NativePtr / (IntPtr)sizeof(void*) + UBulletHitWorldEntityManager.__PropertyOffset_BulletHitWorldEntityBridge);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UBulletHitWorldEntityManager.__PropertyOffset_BulletHitWorldEntityBridge, value);
			}
		}

		// Token: 0x0600552C RID: 21804 RVA: 0x0007734A File Offset: 0x0007554A
		public void SetEntityCanDodge(int EntityId, bool bCanDodge)
		{
			UBulletHitWorldEntityManager.__SetEntityCanDodge_Internal(base.NativePtr, EntityId, bCanDodge);
		}

		// Token: 0x0600552D RID: 21805 RVA: 0x00077359 File Offset: 0x00075559
		public void SetEntityCamp(int EntityId, int Camp)
		{
			UBulletHitWorldEntityManager.__SetEntityCamp_Internal(base.NativePtr, EntityId, Camp);
		}

		// Token: 0x0600552E RID: 21806 RVA: 0x00077368 File Offset: 0x00075568
		public void SetBulletHitWorldEntityBridge(UBulletHitWorldEntityBridge Bridge)
		{
			UBulletHitWorldEntityManager.__SetBulletHitWorldEntityBridge_Internal(base.NativePtr, (Bridge != null) ? Bridge.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600552F RID: 21807 RVA: 0x00077385 File Offset: 0x00075585
		public void GetOperationList([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FBulletHitWorldEntityOperation> OutOperationList)
		{
			UBulletHitWorldEntityManager.__GetOperationList_Internal(base.NativePtr, (OutOperationList ?? new TArray<FBulletHitWorldEntityOperation>()).NativePtr);
		}

		// Token: 0x06005530 RID: 21808 RVA: 0x000773A2 File Offset: 0x000755A2
		public static UBulletHitWorldEntityManager GetInstance()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UBulletHitWorldEntityManager>(UBulletHitWorldEntityManager.__GetInstance_Internal());
		}

		// Token: 0x06005531 RID: 21809 RVA: 0x000773AE File Offset: 0x000755AE
		public bool GetEntityCanDodge(int EntityId)
		{
			return UBulletHitWorldEntityManager.__GetEntityCanDodge_Internal(base.NativePtr, EntityId);
		}

		// Token: 0x06005532 RID: 21810 RVA: 0x000773BC File Offset: 0x000755BC
		public UBulletHitWorldEntityBridge GetBulletHitWorldEntityBridge()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UBulletHitWorldEntityBridge>(UBulletHitWorldEntityManager.__GetBulletHitWorldEntityBridge_Internal(base.NativePtr));
		}

		// Token: 0x06005533 RID: 21811
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void DestroyInstance();

		// Token: 0x06005534 RID: 21812 RVA: 0x000773CE File Offset: 0x000755CE
		public static UBulletHitWorldEntityManager CreateInstance(UObject Outer)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UBulletHitWorldEntityManager>(UBulletHitWorldEntityManager.__CreateInstance_Internal((Outer != null) ? Outer.NativePtr : IntPtr.Zero));
		}

		// Token: 0x06005535 RID: 21813
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetEntityCanDodge_Internal(IntPtr @this, int EntityId, bool bCanDodge);

		// Token: 0x06005536 RID: 21814
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetEntityCamp_Internal(IntPtr @this, int EntityId, int Camp);

		// Token: 0x06005537 RID: 21815
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBulletHitWorldEntityBridge_Internal(IntPtr @this, IntPtr Bridge);

		// Token: 0x06005538 RID: 21816
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetOperationList_Internal(IntPtr @this, IntPtr OutOperationList);

		// Token: 0x06005539 RID: 21817
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetInstance_Internal();

		// Token: 0x0600553A RID: 21818
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetEntityCanDodge_Internal(IntPtr @this, int EntityId);

		// Token: 0x0600553B RID: 21819
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetBulletHitWorldEntityBridge_Internal(IntPtr @this);

		// Token: 0x0600553C RID: 21820
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __CreateInstance_Internal(IntPtr Outer);

		// Token: 0x0600553D RID: 21821 RVA: 0x000773EA File Offset: 0x000755EA
		static UBulletHitWorldEntityManager()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroBullet.BulletHitWorldEntityManager");
		}

		// Token: 0x0600553E RID: 21822 RVA: 0x000773F8 File Offset: 0x000755F8
		protected UBulletHitWorldEntityManager(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040022C3 RID: 8899
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroBullet.BulletHitWorldEntityManager";

		// Token: 0x040022C4 RID: 8900
		private static IntPtr _ClassPtr;

		// Token: 0x040022C5 RID: 8901
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040022C6 RID: 8902
		internal static int __PropertyOffset_HitEffectManager;

		// Token: 0x040022C7 RID: 8903
		internal static int __PropertyOffset_BulletWorld;

		// Token: 0x040022C8 RID: 8904
		internal static int __PropertyOffset_BulletHitWorldEntityBridge;
	}
}
