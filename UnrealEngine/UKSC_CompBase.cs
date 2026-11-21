using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000564 RID: 1380
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_CompBase")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public abstract class UKSC_CompBase : UKSC_BaseObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06007DCA RID: 32202 RVA: 0x000BA82F File Offset: 0x000B8A2F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_CompBase._ClassPtr;
		}

		// Token: 0x06007DCB RID: 32203 RVA: 0x000BA83B File Offset: 0x000B8A3B
		static UKSC_CompBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_CompBase");
		}

		// Token: 0x06007DCC RID: 32204 RVA: 0x000BA84C File Offset: 0x000B8A4C
		protected UKSC_CompBase() : this(BuiltinUtils.AllocNativeUObject(UKSC_CompBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06007DCD RID: 32205 RVA: 0x000BA874 File Offset: 0x000B8A74
		protected UKSC_CompBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040036D3 RID: 14035
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_CompBase";

		// Token: 0x040036D4 RID: 14036
		private static IntPtr _ClassPtr;

		// Token: 0x040036D5 RID: 14037
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
