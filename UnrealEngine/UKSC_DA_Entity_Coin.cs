using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D90 RID: 7568
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_Entity_Coin")]
	[UnrealStructLayout(400, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 400)]
	public class UKSC_DA_Entity_Coin : UKSC_DA_Entity, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601CF8A RID: 118666 RVA: 0x002AD24E File Offset: 0x002AB44E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Entity_Coin._ClassPtr;
		}

		// Token: 0x0601CF8B RID: 118667 RVA: 0x002AD25C File Offset: 0x002AB45C
		public UKSC_DA_Entity_Coin() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Entity_Coin.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601CF8C RID: 118668 RVA: 0x002AD284 File Offset: 0x002AB484
		[NullableContext(1)]
		public UKSC_DA_Entity_Coin(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Entity_Coin.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601CF8D RID: 118669 RVA: 0x002AD2B7 File Offset: 0x002AB4B7
		static UKSC_DA_Entity_Coin()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_Entity_Coin");
		}

		// Token: 0x0601CF8E RID: 118670 RVA: 0x002AD2C5 File Offset: 0x002AB4C5
		protected UKSC_DA_Entity_Coin(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FB95 RID: 64405
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_Entity_Coin";

		// Token: 0x0400FB96 RID: 64406
		private static IntPtr _ClassPtr;

		// Token: 0x0400FB97 RID: 64407
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
