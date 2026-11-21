using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200032E RID: 814
	[UnrealObjectPath("/Script/KuroBullet.ActionInitExplosionBulletPTT")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public class UActionInitExplosionBulletPTT : UBulletActionBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600550F RID: 21775 RVA: 0x00077112 File Offset: 0x00075312
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UActionInitExplosionBulletPTT._ClassPtr;
		}

		// Token: 0x06005510 RID: 21776 RVA: 0x00077120 File Offset: 0x00075320
		public UActionInitExplosionBulletPTT() : this(BuiltinUtils.AllocNativeUObject(UActionInitExplosionBulletPTT.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06005511 RID: 21777 RVA: 0x00077148 File Offset: 0x00075348
		[NullableContext(1)]
		public UActionInitExplosionBulletPTT(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UActionInitExplosionBulletPTT.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06005512 RID: 21778 RVA: 0x0007717B File Offset: 0x0007537B
		static UActionInitExplosionBulletPTT()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroBullet.ActionInitExplosionBulletPTT");
		}

		// Token: 0x06005513 RID: 21779 RVA: 0x00077189 File Offset: 0x00075389
		protected UActionInitExplosionBulletPTT(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040022BD RID: 8893
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroBullet.ActionInitExplosionBulletPTT";

		// Token: 0x040022BE RID: 8894
		private static IntPtr _ClassPtr;

		// Token: 0x040022BF RID: 8895
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
