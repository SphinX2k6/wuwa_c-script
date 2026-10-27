using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020016BB RID: 5819
	[UnrealObjectPath("/Script/KuroBulletCore.ActionChildBullet")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public class UActionChildBullet : UBulletActionBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601517F RID: 86399 RVA: 0x001F0354 File Offset: 0x001EE554
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UActionChildBullet._ClassPtr;
		}

		// Token: 0x06015180 RID: 86400 RVA: 0x001F0360 File Offset: 0x001EE560
		public UActionChildBullet() : this(BuiltinUtils.AllocNativeUObject(UActionChildBullet.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06015181 RID: 86401 RVA: 0x001F0388 File Offset: 0x001EE588
		[NullableContext(1)]
		public UActionChildBullet(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UActionChildBullet.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06015182 RID: 86402 RVA: 0x001F03BB File Offset: 0x001EE5BB
		static UActionChildBullet()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroBulletCore.ActionChildBullet");
		}

		// Token: 0x06015183 RID: 86403 RVA: 0x001F03C9 File Offset: 0x001EE5C9
		protected UActionChildBullet(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400B7AB RID: 47019
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroBulletCore.ActionChildBullet";

		// Token: 0x0400B7AC RID: 47020
		private static IntPtr _ClassPtr;

		// Token: 0x0400B7AD RID: 47021
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
