using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200015B RID: 347
	[UnrealObjectPath("/Script/AIModule.BTTask_PawnActionBase")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public abstract class UBTTask_PawnActionBase : UBTTaskNode, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060017D6 RID: 6102 RVA: 0x000231AA File Offset: 0x000213AA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBTTask_PawnActionBase._ClassPtr;
		}

		// Token: 0x060017D7 RID: 6103 RVA: 0x000231B6 File Offset: 0x000213B6
		static UBTTask_PawnActionBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.BTTask_PawnActionBase");
		}

		// Token: 0x060017D8 RID: 6104 RVA: 0x000231C4 File Offset: 0x000213C4
		protected UBTTask_PawnActionBase() : this(BuiltinUtils.AllocNativeUObject(UBTTask_PawnActionBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060017D9 RID: 6105 RVA: 0x000231EC File Offset: 0x000213EC
		protected UBTTask_PawnActionBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040005CD RID: 1485
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.BTTask_PawnActionBase";

		// Token: 0x040005CE RID: 1486
		private static IntPtr _ClassPtr;

		// Token: 0x040005CF RID: 1487
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
