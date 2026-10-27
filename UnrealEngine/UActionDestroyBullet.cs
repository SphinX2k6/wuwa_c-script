using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020016BC RID: 5820
	[UnrealObjectPath("/Script/KuroBulletCore.ActionDestroyBullet")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public class UActionDestroyBullet : UBulletActionBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06015184 RID: 86404 RVA: 0x001F03D2 File Offset: 0x001EE5D2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UActionDestroyBullet._ClassPtr;
		}

		// Token: 0x06015185 RID: 86405 RVA: 0x001F03E0 File Offset: 0x001EE5E0
		public UActionDestroyBullet() : this(BuiltinUtils.AllocNativeUObject(UActionDestroyBullet.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06015186 RID: 86406 RVA: 0x001F0408 File Offset: 0x001EE608
		[NullableContext(1)]
		public UActionDestroyBullet(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UActionDestroyBullet.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06015187 RID: 86407 RVA: 0x001F043B File Offset: 0x001EE63B
		static UActionDestroyBullet()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroBulletCore.ActionDestroyBullet");
		}

		// Token: 0x06015188 RID: 86408 RVA: 0x001F0449 File Offset: 0x001EE649
		protected UActionDestroyBullet(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400B7AE RID: 47022
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroBulletCore.ActionDestroyBullet";

		// Token: 0x0400B7AF RID: 47023
		private static IntPtr _ClassPtr;

		// Token: 0x0400B7B0 RID: 47024
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
