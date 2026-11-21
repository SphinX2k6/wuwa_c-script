using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000329 RID: 809
	[UnrealObjectPath("/Script/KuroBulletCore.KuroBulletCoreSubsystem")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public class UKuroBulletCoreSubsystem : UGameInstanceSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060054DC RID: 21724 RVA: 0x00076C25 File Offset: 0x00074E25
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroBulletCoreSubsystem._ClassPtr;
		}

		// Token: 0x060054DD RID: 21725 RVA: 0x00076C34 File Offset: 0x00074E34
		public UKuroBulletCoreSubsystem() : this(BuiltinUtils.AllocNativeUObject(UKuroBulletCoreSubsystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060054DE RID: 21726 RVA: 0x00076C5C File Offset: 0x00074E5C
		[NullableContext(1)]
		public UKuroBulletCoreSubsystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroBulletCoreSubsystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060054DF RID: 21727 RVA: 0x00076C8F File Offset: 0x00074E8F
		[NullableContext(2)]
		public UBulletWorld GetBulletWorld()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UBulletWorld>(UKuroBulletCoreSubsystem.__GetBulletWorld_Internal(base.NativePtr));
		}

		// Token: 0x060054E0 RID: 21728 RVA: 0x00076CA1 File Offset: 0x00074EA1
		public void DestroyWorld()
		{
			UKuroBulletCoreSubsystem.__DestroyWorld_Internal(base.NativePtr);
		}

		// Token: 0x060054E1 RID: 21729 RVA: 0x00076CAE File Offset: 0x00074EAE
		[NullableContext(2)]
		public UBulletWorld CreateWorld()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UBulletWorld>(UKuroBulletCoreSubsystem.__CreateWorld_Internal(base.NativePtr));
		}

		// Token: 0x060054E2 RID: 21730
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetBulletWorld_Internal(IntPtr @this);

		// Token: 0x060054E3 RID: 21731
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DestroyWorld_Internal(IntPtr @this);

		// Token: 0x060054E4 RID: 21732
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __CreateWorld_Internal(IntPtr @this);

		// Token: 0x060054E5 RID: 21733 RVA: 0x00076CC0 File Offset: 0x00074EC0
		static UKuroBulletCoreSubsystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroBulletCore.KuroBulletCoreSubsystem");
		}

		// Token: 0x060054E6 RID: 21734 RVA: 0x00076CCE File Offset: 0x00074ECE
		protected UKuroBulletCoreSubsystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040022AF RID: 8879
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroBulletCore.KuroBulletCoreSubsystem";

		// Token: 0x040022B0 RID: 8880
		private static IntPtr _ClassPtr;

		// Token: 0x040022B1 RID: 8881
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
