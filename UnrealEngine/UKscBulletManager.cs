using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200172B RID: 5931
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroBullet.KscBulletManager")]
	[UnrealStructLayout(224, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 224)]
	public class UKscBulletManager : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060155A4 RID: 87460 RVA: 0x001F6071 File Offset: 0x001F4271
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKscBulletManager._ClassPtr;
		}

		// Token: 0x060155A5 RID: 87461 RVA: 0x001F6080 File Offset: 0x001F4280
		public UKscBulletManager() : this(BuiltinUtils.AllocNativeUObject(UKscBulletManager.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060155A6 RID: 87462 RVA: 0x001F60A8 File Offset: 0x001F42A8
		[NullableContext(1)]
		public UKscBulletManager(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKscBulletManager.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005457 RID: 21591
		// (get) Token: 0x060155A7 RID: 87463 RVA: 0x001F60DB File Offset: 0x001F42DB
		// (set) Token: 0x060155A8 RID: 87464 RVA: 0x001F60EF File Offset: 0x001F42EF
		public unsafe UKSC_World KscWorld
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_World>(base.NativePtr / (IntPtr)sizeof(void*) + UKscBulletManager.__PropertyOffset_KscWorld);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKscBulletManager.__PropertyOffset_KscWorld, value);
			}
		}

		// Token: 0x17005458 RID: 21592
		// (get) Token: 0x060155A9 RID: 87465 RVA: 0x001F6104 File Offset: 0x001F4304
		// (set) Token: 0x060155AA RID: 87466 RVA: 0x001F6118 File Offset: 0x001F4318
		public unsafe UBulletWorld BulletWorld
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBulletWorld>(base.NativePtr / (IntPtr)sizeof(void*) + UKscBulletManager.__PropertyOffset_BulletWorld);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKscBulletManager.__PropertyOffset_BulletWorld, value);
			}
		}

		// Token: 0x17005459 RID: 21593
		// (get) Token: 0x060155AB RID: 87467 RVA: 0x001F612D File Offset: 0x001F432D
		// (set) Token: 0x060155AC RID: 87468 RVA: 0x001F6141 File Offset: 0x001F4341
		public unsafe UHitEffectManager HitEffectManager
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UHitEffectManager>(base.NativePtr / (IntPtr)sizeof(void*) + UKscBulletManager.__PropertyOffset_HitEffectManager);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKscBulletManager.__PropertyOffset_HitEffectManager, value);
			}
		}

		// Token: 0x060155AD RID: 87469 RVA: 0x001F6156 File Offset: 0x001F4356
		public static UKscBulletManager GetInstance()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UKscBulletManager>(UKscBulletManager.__GetInstance_Internal());
		}

		// Token: 0x060155AE RID: 87470
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void DestroyInstance();

		// Token: 0x060155AF RID: 87471 RVA: 0x001F6162 File Offset: 0x001F4362
		public static UKscBulletManager CreateInstance(UObject Outer)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UKscBulletManager>(UKscBulletManager.__CreateInstance_Internal((Outer != null) ? Outer.NativePtr : IntPtr.Zero));
		}

		// Token: 0x060155B0 RID: 87472
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetInstance_Internal();

		// Token: 0x060155B1 RID: 87473
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __CreateInstance_Internal(IntPtr Outer);

		// Token: 0x060155B2 RID: 87474 RVA: 0x001F617E File Offset: 0x001F437E
		static UKscBulletManager()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroBullet.KscBulletManager");
		}

		// Token: 0x060155B3 RID: 87475 RVA: 0x001F618C File Offset: 0x001F438C
		protected UKscBulletManager(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400BA4F RID: 47695
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroBullet.KscBulletManager";

		// Token: 0x0400BA50 RID: 47696
		private static IntPtr _ClassPtr;

		// Token: 0x0400BA51 RID: 47697
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400BA52 RID: 47698
		internal static int __PropertyOffset_KscWorld;

		// Token: 0x0400BA53 RID: 47699
		internal static int __PropertyOffset_BulletWorld;

		// Token: 0x0400BA54 RID: 47700
		internal static int __PropertyOffset_HitEffectManager;
	}
}
