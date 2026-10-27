using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D91 RID: 7569
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_Entity_Enemy")]
	[UnrealStructLayout(400, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 400)]
	public class UKSC_DA_Entity_Enemy : UKSC_DA_Entity, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601CF8F RID: 118671 RVA: 0x002AD2CE File Offset: 0x002AB4CE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Entity_Enemy._ClassPtr;
		}

		// Token: 0x0601CF90 RID: 118672 RVA: 0x002AD2DC File Offset: 0x002AB4DC
		public UKSC_DA_Entity_Enemy() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Entity_Enemy.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601CF91 RID: 118673 RVA: 0x002AD304 File Offset: 0x002AB504
		[NullableContext(1)]
		public UKSC_DA_Entity_Enemy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Entity_Enemy.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601CF92 RID: 118674 RVA: 0x002AD337 File Offset: 0x002AB537
		static UKSC_DA_Entity_Enemy()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_Entity_Enemy");
		}

		// Token: 0x0601CF93 RID: 118675 RVA: 0x002AD345 File Offset: 0x002AB545
		protected UKSC_DA_Entity_Enemy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FB98 RID: 64408
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_Entity_Enemy";

		// Token: 0x0400FB99 RID: 64409
		private static IntPtr _ClassPtr;

		// Token: 0x0400FB9A RID: 64410
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
