using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200056B RID: 1387
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_Entity_Enemy")]
	[UnrealStructLayout(400, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 400)]
	public class UKSC_DA_Entity_Enemy : UKSC_DA_Entity, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06007E4F RID: 32335 RVA: 0x000BB312 File Offset: 0x000B9512
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Entity_Enemy._ClassPtr;
		}

		// Token: 0x06007E50 RID: 32336 RVA: 0x000BB320 File Offset: 0x000B9520
		public UKSC_DA_Entity_Enemy() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Entity_Enemy.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06007E51 RID: 32337 RVA: 0x000BB348 File Offset: 0x000B9548
		[NullableContext(1)]
		public UKSC_DA_Entity_Enemy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Entity_Enemy.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06007E52 RID: 32338 RVA: 0x000BB37B File Offset: 0x000B957B
		static UKSC_DA_Entity_Enemy()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_Entity_Enemy");
		}

		// Token: 0x06007E53 RID: 32339 RVA: 0x000BB389 File Offset: 0x000B9589
		protected UKSC_DA_Entity_Enemy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400371C RID: 14108
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_Entity_Enemy";

		// Token: 0x0400371D RID: 14109
		private static IntPtr _ClassPtr;

		// Token: 0x0400371E RID: 14110
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
