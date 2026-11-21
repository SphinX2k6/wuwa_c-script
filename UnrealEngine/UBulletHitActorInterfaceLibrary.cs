using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003B7 RID: 951
	[UnrealObjectPath("/Script/KuroGameplay.BulletHitActorInterfaceLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UBulletHitActorInterfaceLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06005D6B RID: 23915 RVA: 0x00083DDA File Offset: 0x00081FDA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBulletHitActorInterfaceLibrary._ClassPtr;
		}

		// Token: 0x06005D6C RID: 23916 RVA: 0x00083DE8 File Offset: 0x00081FE8
		public UBulletHitActorInterfaceLibrary() : this(BuiltinUtils.AllocNativeUObject(UBulletHitActorInterfaceLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06005D6D RID: 23917 RVA: 0x00083E10 File Offset: 0x00082010
		[NullableContext(1)]
		public UBulletHitActorInterfaceLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBulletHitActorInterfaceLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06005D6E RID: 23918 RVA: 0x00083E43 File Offset: 0x00082043
		[NullableContext(2)]
		public static void Execute_OnBulletHit(UObject Object, int BulletEntityId, FVector HitPoint)
		{
			UBulletHitActorInterfaceLibrary.__Execute_OnBulletHit_Internal((Object != null) ? Object.NativePtr : IntPtr.Zero, BulletEntityId, HitPoint);
		}

		// Token: 0x06005D6F RID: 23919
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Execute_OnBulletHit_Internal(IntPtr Object, int BulletEntityId, FVector HitPoint);

		// Token: 0x06005D70 RID: 23920 RVA: 0x00083E5C File Offset: 0x0008205C
		static UBulletHitActorInterfaceLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.BulletHitActorInterfaceLibrary");
		}

		// Token: 0x06005D71 RID: 23921 RVA: 0x00083E6A File Offset: 0x0008206A
		protected UBulletHitActorInterfaceLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040026F1 RID: 9969
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameplay.BulletHitActorInterfaceLibrary";

		// Token: 0x040026F2 RID: 9970
		private static IntPtr _ClassPtr;

		// Token: 0x040026F3 RID: 9971
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
