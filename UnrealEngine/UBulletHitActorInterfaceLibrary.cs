using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001893 RID: 6291
	[UnrealObjectPath("/Script/KuroGameplay.BulletHitActorInterfaceLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UBulletHitActorInterfaceLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060172C0 RID: 94912 RVA: 0x0021C93E File Offset: 0x0021AB3E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBulletHitActorInterfaceLibrary._ClassPtr;
		}

		// Token: 0x060172C1 RID: 94913 RVA: 0x0021C94C File Offset: 0x0021AB4C
		public UBulletHitActorInterfaceLibrary() : this(BuiltinUtils.AllocNativeUObject(UBulletHitActorInterfaceLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060172C2 RID: 94914 RVA: 0x0021C974 File Offset: 0x0021AB74
		[NullableContext(1)]
		public UBulletHitActorInterfaceLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBulletHitActorInterfaceLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060172C3 RID: 94915 RVA: 0x0021C9A7 File Offset: 0x0021ABA7
		[NullableContext(2)]
		public static void Execute_OnBulletHit(UObject Object, int BulletEntityId, FVector HitPoint)
		{
			UBulletHitActorInterfaceLibrary.__Execute_OnBulletHit_Internal((Object != null) ? Object.NativePtr : IntPtr.Zero, BulletEntityId, HitPoint);
		}

		// Token: 0x060172C4 RID: 94916
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Execute_OnBulletHit_Internal(IntPtr Object, int BulletEntityId, FVector HitPoint);

		// Token: 0x060172C5 RID: 94917 RVA: 0x0021C9C0 File Offset: 0x0021ABC0
		static UBulletHitActorInterfaceLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.BulletHitActorInterfaceLibrary");
		}

		// Token: 0x060172C6 RID: 94918 RVA: 0x0021C9CE File Offset: 0x0021ABCE
		protected UBulletHitActorInterfaceLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400C908 RID: 51464
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameplay.BulletHitActorInterfaceLibrary";

		// Token: 0x0400C909 RID: 51465
		private static IntPtr _ClassPtr;

		// Token: 0x0400C90A RID: 51466
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
