using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020016BF RID: 5823
	[UnrealObjectPath("/Script/KuroBulletCore.ActionInitBulletKFC")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class UActionInitBulletKFC : UActionInitBullet, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06015193 RID: 86419 RVA: 0x001F0552 File Offset: 0x001EE752
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UActionInitBulletKFC._ClassPtr;
		}

		// Token: 0x06015194 RID: 86420 RVA: 0x001F0560 File Offset: 0x001EE760
		public UActionInitBulletKFC() : this(BuiltinUtils.AllocNativeUObject(UActionInitBulletKFC.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06015195 RID: 86421 RVA: 0x001F0588 File Offset: 0x001EE788
		[NullableContext(1)]
		public UActionInitBulletKFC(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UActionInitBulletKFC.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06015196 RID: 86422 RVA: 0x001F05BB File Offset: 0x001EE7BB
		static UActionInitBulletKFC()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroBulletCore.ActionInitBulletKFC");
		}

		// Token: 0x06015197 RID: 86423 RVA: 0x001F05C9 File Offset: 0x001EE7C9
		protected UActionInitBulletKFC(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400B7B7 RID: 47031
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroBulletCore.ActionInitBulletKFC";

		// Token: 0x0400B7B8 RID: 47032
		private static IntPtr _ClassPtr;

		// Token: 0x0400B7B9 RID: 47033
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
