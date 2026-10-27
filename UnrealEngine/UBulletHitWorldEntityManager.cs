using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200171F RID: 5919
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroBullet.BulletHitWorldEntityManager")]
	[UnrealStructLayout(272, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 272)]
	public class UBulletHitWorldEntityManager : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06015553 RID: 87379 RVA: 0x001F5A84 File Offset: 0x001F3C84
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBulletHitWorldEntityManager._ClassPtr;
		}

		// Token: 0x06015554 RID: 87380 RVA: 0x001F5A90 File Offset: 0x001F3C90
		public UBulletHitWorldEntityManager() : this(BuiltinUtils.AllocNativeUObject(UBulletHitWorldEntityManager.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06015555 RID: 87381 RVA: 0x001F5AB8 File Offset: 0x001F3CB8
		[NullableContext(1)]
		public UBulletHitWorldEntityManager(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBulletHitWorldEntityManager.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005443 RID: 21571
		// (get) Token: 0x06015556 RID: 87382 RVA: 0x001F5AEB File Offset: 0x001F3CEB
		// (set) Token: 0x06015557 RID: 87383 RVA: 0x001F5AFF File Offset: 0x001F3CFF
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

		// Token: 0x17005444 RID: 21572
		// (get) Token: 0x06015558 RID: 87384 RVA: 0x001F5B14 File Offset: 0x001F3D14
		// (set) Token: 0x06015559 RID: 87385 RVA: 0x001F5B28 File Offset: 0x001F3D28
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

		// Token: 0x17005445 RID: 21573
		// (get) Token: 0x0601555A RID: 87386 RVA: 0x001F5B3D File Offset: 0x001F3D3D
		// (set) Token: 0x0601555B RID: 87387 RVA: 0x001F5B51 File Offset: 0x001F3D51
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

		// Token: 0x0601555C RID: 87388 RVA: 0x001F5B66 File Offset: 0x001F3D66
		public void SetEntityCanDodge(int EntityId, bool bCanDodge)
		{
			UBulletHitWorldEntityManager.__SetEntityCanDodge_Internal(base.NativePtr, EntityId, bCanDodge);
		}

		// Token: 0x0601555D RID: 87389 RVA: 0x001F5B75 File Offset: 0x001F3D75
		public void SetEntityCamp(int EntityId, int Camp)
		{
			UBulletHitWorldEntityManager.__SetEntityCamp_Internal(base.NativePtr, EntityId, Camp);
		}

		// Token: 0x0601555E RID: 87390 RVA: 0x001F5B84 File Offset: 0x001F3D84
		public void SetBulletHitWorldEntityBridge(UBulletHitWorldEntityBridge Bridge)
		{
			UBulletHitWorldEntityManager.__SetBulletHitWorldEntityBridge_Internal(base.NativePtr, (Bridge != null) ? Bridge.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601555F RID: 87391 RVA: 0x001F5BA1 File Offset: 0x001F3DA1
		public void GetOperationList([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FBulletHitWorldEntityOperation> OutOperationList)
		{
			UBulletHitWorldEntityManager.__GetOperationList_Internal(base.NativePtr, (OutOperationList ?? new TArray<FBulletHitWorldEntityOperation>()).NativePtr);
		}

		// Token: 0x06015560 RID: 87392 RVA: 0x001F5BBE File Offset: 0x001F3DBE
		public static UBulletHitWorldEntityManager GetInstance()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UBulletHitWorldEntityManager>(UBulletHitWorldEntityManager.__GetInstance_Internal());
		}

		// Token: 0x06015561 RID: 87393 RVA: 0x001F5BCA File Offset: 0x001F3DCA
		public bool GetEntityCanDodge(int EntityId)
		{
			return UBulletHitWorldEntityManager.__GetEntityCanDodge_Internal(base.NativePtr, EntityId);
		}

		// Token: 0x06015562 RID: 87394 RVA: 0x001F5BD8 File Offset: 0x001F3DD8
		public UBulletHitWorldEntityBridge GetBulletHitWorldEntityBridge()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UBulletHitWorldEntityBridge>(UBulletHitWorldEntityManager.__GetBulletHitWorldEntityBridge_Internal(base.NativePtr));
		}

		// Token: 0x06015563 RID: 87395
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void DestroyInstance();

		// Token: 0x06015564 RID: 87396 RVA: 0x001F5BEA File Offset: 0x001F3DEA
		public static UBulletHitWorldEntityManager CreateInstance(UObject Outer)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UBulletHitWorldEntityManager>(UBulletHitWorldEntityManager.__CreateInstance_Internal((Outer != null) ? Outer.NativePtr : IntPtr.Zero));
		}

		// Token: 0x06015565 RID: 87397
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetEntityCanDodge_Internal(IntPtr @this, int EntityId, bool bCanDodge);

		// Token: 0x06015566 RID: 87398
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetEntityCamp_Internal(IntPtr @this, int EntityId, int Camp);

		// Token: 0x06015567 RID: 87399
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBulletHitWorldEntityBridge_Internal(IntPtr @this, IntPtr Bridge);

		// Token: 0x06015568 RID: 87400
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetOperationList_Internal(IntPtr @this, IntPtr OutOperationList);

		// Token: 0x06015569 RID: 87401
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetInstance_Internal();

		// Token: 0x0601556A RID: 87402
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetEntityCanDodge_Internal(IntPtr @this, int EntityId);

		// Token: 0x0601556B RID: 87403
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetBulletHitWorldEntityBridge_Internal(IntPtr @this);

		// Token: 0x0601556C RID: 87404
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __CreateInstance_Internal(IntPtr Outer);

		// Token: 0x0601556D RID: 87405 RVA: 0x001F5C06 File Offset: 0x001F3E06
		static UBulletHitWorldEntityManager()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroBullet.BulletHitWorldEntityManager");
		}

		// Token: 0x0601556E RID: 87406 RVA: 0x001F5C14 File Offset: 0x001F3E14
		protected UBulletHitWorldEntityManager(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400BA07 RID: 47623
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroBullet.BulletHitWorldEntityManager";

		// Token: 0x0400BA08 RID: 47624
		private static IntPtr _ClassPtr;

		// Token: 0x0400BA09 RID: 47625
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400BA0A RID: 47626
		internal static int __PropertyOffset_HitEffectManager;

		// Token: 0x0400BA0B RID: 47627
		internal static int __PropertyOffset_BulletWorld;

		// Token: 0x0400BA0C RID: 47628
		internal static int __PropertyOffset_BulletHitWorldEntityBridge;
	}
}
