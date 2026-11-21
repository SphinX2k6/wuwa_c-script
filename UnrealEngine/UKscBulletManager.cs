using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000335 RID: 821
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroBullet.KscBulletManager")]
	[UnrealStructLayout(224, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 224)]
	public class UKscBulletManager : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06005573 RID: 21875 RVA: 0x00077815 File Offset: 0x00075A15
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKscBulletManager._ClassPtr;
		}

		// Token: 0x06005574 RID: 21876 RVA: 0x00077824 File Offset: 0x00075A24
		public UKscBulletManager() : this(BuiltinUtils.AllocNativeUObject(UKscBulletManager.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06005575 RID: 21877 RVA: 0x0007784C File Offset: 0x00075A4C
		[NullableContext(1)]
		public UKscBulletManager(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKscBulletManager.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170010D8 RID: 4312
		// (get) Token: 0x06005576 RID: 21878 RVA: 0x0007787F File Offset: 0x00075A7F
		// (set) Token: 0x06005577 RID: 21879 RVA: 0x00077893 File Offset: 0x00075A93
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

		// Token: 0x170010D9 RID: 4313
		// (get) Token: 0x06005578 RID: 21880 RVA: 0x000778A8 File Offset: 0x00075AA8
		// (set) Token: 0x06005579 RID: 21881 RVA: 0x000778BC File Offset: 0x00075ABC
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

		// Token: 0x170010DA RID: 4314
		// (get) Token: 0x0600557A RID: 21882 RVA: 0x000778D1 File Offset: 0x00075AD1
		// (set) Token: 0x0600557B RID: 21883 RVA: 0x000778E5 File Offset: 0x00075AE5
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

		// Token: 0x0600557C RID: 21884 RVA: 0x000778FA File Offset: 0x00075AFA
		public static UKscBulletManager GetInstance()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UKscBulletManager>(UKscBulletManager.__GetInstance_Internal());
		}

		// Token: 0x0600557D RID: 21885
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void DestroyInstance();

		// Token: 0x0600557E RID: 21886 RVA: 0x00077906 File Offset: 0x00075B06
		public static UKscBulletManager CreateInstance(UObject Outer)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UKscBulletManager>(UKscBulletManager.__CreateInstance_Internal((Outer != null) ? Outer.NativePtr : IntPtr.Zero));
		}

		// Token: 0x0600557F RID: 21887
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetInstance_Internal();

		// Token: 0x06005580 RID: 21888
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __CreateInstance_Internal(IntPtr Outer);

		// Token: 0x06005581 RID: 21889 RVA: 0x00077922 File Offset: 0x00075B22
		static UKscBulletManager()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroBullet.KscBulletManager");
		}

		// Token: 0x06005582 RID: 21890 RVA: 0x00077930 File Offset: 0x00075B30
		protected UKscBulletManager(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040022EB RID: 8939
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroBullet.KscBulletManager";

		// Token: 0x040022EC RID: 8940
		private static IntPtr _ClassPtr;

		// Token: 0x040022ED RID: 8941
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040022EE RID: 8942
		internal static int __PropertyOffset_KscWorld;

		// Token: 0x040022EF RID: 8943
		internal static int __PropertyOffset_BulletWorld;

		// Token: 0x040022F0 RID: 8944
		internal static int __PropertyOffset_HitEffectManager;
	}
}
