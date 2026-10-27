using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001717 RID: 5911
	[UnrealObjectPath("/Script/KuroBullet.ActionOnHitBulletPTT")]
	[UnrealStructLayout(176, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 176)]
	public class UActionOnHitBulletPTT : UBulletOnHitAction, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601551D RID: 87325 RVA: 0x001F55DE File Offset: 0x001F37DE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UActionOnHitBulletPTT._ClassPtr;
		}

		// Token: 0x0601551E RID: 87326 RVA: 0x001F55EC File Offset: 0x001F37EC
		public UActionOnHitBulletPTT() : this(BuiltinUtils.AllocNativeUObject(UActionOnHitBulletPTT.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601551F RID: 87327 RVA: 0x001F5614 File Offset: 0x001F3814
		[NullableContext(1)]
		public UActionOnHitBulletPTT(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UActionOnHitBulletPTT.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06015520 RID: 87328 RVA: 0x001F5647 File Offset: 0x001F3847
		static UActionOnHitBulletPTT()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroBullet.ActionOnHitBulletPTT");
		}

		// Token: 0x06015521 RID: 87329 RVA: 0x001F5655 File Offset: 0x001F3855
		protected UActionOnHitBulletPTT(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400B9ED RID: 47597
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroBullet.ActionOnHitBulletPTT";

		// Token: 0x0400B9EE RID: 47598
		private static IntPtr _ClassPtr;

		// Token: 0x0400B9EF RID: 47599
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
