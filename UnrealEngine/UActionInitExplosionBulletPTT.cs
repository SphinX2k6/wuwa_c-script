using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001716 RID: 5910
	[UnrealObjectPath("/Script/KuroBullet.ActionInitExplosionBulletPTT")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public class UActionInitExplosionBulletPTT : UBulletActionBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06015518 RID: 87320 RVA: 0x001F555E File Offset: 0x001F375E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UActionInitExplosionBulletPTT._ClassPtr;
		}

		// Token: 0x06015519 RID: 87321 RVA: 0x001F556C File Offset: 0x001F376C
		public UActionInitExplosionBulletPTT() : this(BuiltinUtils.AllocNativeUObject(UActionInitExplosionBulletPTT.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601551A RID: 87322 RVA: 0x001F5594 File Offset: 0x001F3794
		[NullableContext(1)]
		public UActionInitExplosionBulletPTT(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UActionInitExplosionBulletPTT.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601551B RID: 87323 RVA: 0x001F55C7 File Offset: 0x001F37C7
		static UActionInitExplosionBulletPTT()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroBullet.ActionInitExplosionBulletPTT");
		}

		// Token: 0x0601551C RID: 87324 RVA: 0x001F55D5 File Offset: 0x001F37D5
		protected UActionInitExplosionBulletPTT(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400B9EA RID: 47594
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroBullet.ActionInitExplosionBulletPTT";

		// Token: 0x0400B9EB RID: 47595
		private static IntPtr _ClassPtr;

		// Token: 0x0400B9EC RID: 47596
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
