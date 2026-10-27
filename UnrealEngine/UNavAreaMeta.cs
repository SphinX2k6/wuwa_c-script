using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002477 RID: 9335
	[UnrealObjectPath("/Script/NavigationSystem.NavAreaMeta")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public abstract class UNavAreaMeta : UNavArea, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06022F08 RID: 143112 RVA: 0x0033A8D1 File Offset: 0x00338AD1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNavAreaMeta._ClassPtr;
		}

		// Token: 0x06022F09 RID: 143113 RVA: 0x0033A8DD File Offset: 0x00338ADD
		static UNavAreaMeta()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/NavigationSystem.NavAreaMeta");
		}

		// Token: 0x06022F0A RID: 143114 RVA: 0x0033A8EC File Offset: 0x00338AEC
		protected UNavAreaMeta() : this(BuiltinUtils.AllocNativeUObject(UNavAreaMeta.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022F0B RID: 143115 RVA: 0x0033A914 File Offset: 0x00338B14
		protected UNavAreaMeta(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012A84 RID: 76420
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/NavigationSystem.NavAreaMeta";

		// Token: 0x04012A85 RID: 76421
		private static IntPtr _ClassPtr;

		// Token: 0x04012A86 RID: 76422
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
