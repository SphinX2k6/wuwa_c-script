using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020016C8 RID: 5832
	[UnrealObjectPath("/Script/KuroBulletCore.BulletHitActorData")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public class UBulletHitActorData : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060151DE RID: 86494 RVA: 0x001F0CBF File Offset: 0x001EEEBF
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBulletHitActorData._ClassPtr;
		}

		// Token: 0x060151DF RID: 86495 RVA: 0x001F0CCC File Offset: 0x001EEECC
		public UBulletHitActorData() : this(BuiltinUtils.AllocNativeUObject(UBulletHitActorData.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060151E0 RID: 86496 RVA: 0x001F0CF4 File Offset: 0x001EEEF4
		[NullableContext(1)]
		public UBulletHitActorData(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBulletHitActorData.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060151E1 RID: 86497 RVA: 0x001F0D27 File Offset: 0x001EEF27
		static UBulletHitActorData()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroBulletCore.BulletHitActorData");
		}

		// Token: 0x060151E2 RID: 86498 RVA: 0x001F0D35 File Offset: 0x001EEF35
		protected UBulletHitActorData(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400B7E6 RID: 47078
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroBulletCore.BulletHitActorData";

		// Token: 0x0400B7E7 RID: 47079
		private static IntPtr _ClassPtr;

		// Token: 0x0400B7E8 RID: 47080
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
