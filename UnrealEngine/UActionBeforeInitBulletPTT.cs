using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001715 RID: 5909
	[UnrealObjectPath("/Script/KuroBullet.ActionBeforeInitBulletPTT")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class UActionBeforeInitBulletPTT : UBulletActionBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06015513 RID: 87315 RVA: 0x001F54DD File Offset: 0x001F36DD
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UActionBeforeInitBulletPTT._ClassPtr;
		}

		// Token: 0x06015514 RID: 87316 RVA: 0x001F54EC File Offset: 0x001F36EC
		public UActionBeforeInitBulletPTT() : this(BuiltinUtils.AllocNativeUObject(UActionBeforeInitBulletPTT.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06015515 RID: 87317 RVA: 0x001F5514 File Offset: 0x001F3714
		[NullableContext(1)]
		public UActionBeforeInitBulletPTT(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UActionBeforeInitBulletPTT.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06015516 RID: 87318 RVA: 0x001F5547 File Offset: 0x001F3747
		static UActionBeforeInitBulletPTT()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroBullet.ActionBeforeInitBulletPTT");
		}

		// Token: 0x06015517 RID: 87319 RVA: 0x001F5555 File Offset: 0x001F3755
		protected UActionBeforeInitBulletPTT(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400B9E7 RID: 47591
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroBullet.ActionBeforeInitBulletPTT";

		// Token: 0x0400B9E8 RID: 47592
		private static IntPtr _ClassPtr;

		// Token: 0x0400B9E9 RID: 47593
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
