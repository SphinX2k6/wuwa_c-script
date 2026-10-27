using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D89 RID: 7561
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_BulletPierce")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 88)]
	public class UKSC_DA_BulletPierce : UKSC_DA_Bullet, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601CF2E RID: 118574 RVA: 0x002ACA0A File Offset: 0x002AAC0A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_BulletPierce._ClassPtr;
		}

		// Token: 0x0601CF2F RID: 118575 RVA: 0x002ACA18 File Offset: 0x002AAC18
		public UKSC_DA_BulletPierce() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_BulletPierce.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601CF30 RID: 118576 RVA: 0x002ACA40 File Offset: 0x002AAC40
		[NullableContext(1)]
		public UKSC_DA_BulletPierce(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_BulletPierce.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601CF31 RID: 118577 RVA: 0x002ACA73 File Offset: 0x002AAC73
		static UKSC_DA_BulletPierce()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_BulletPierce");
		}

		// Token: 0x0601CF32 RID: 118578 RVA: 0x002ACA81 File Offset: 0x002AAC81
		protected UKSC_DA_BulletPierce(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FB5F RID: 64351
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_BulletPierce";

		// Token: 0x0400FB60 RID: 64352
		private static IntPtr _ClassPtr;

		// Token: 0x0400FB61 RID: 64353
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
