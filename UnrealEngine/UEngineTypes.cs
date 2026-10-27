using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000AF7 RID: 2807
	[UnrealObjectPath("/Script/Engine.EngineTypes")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public abstract class UEngineTypes : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600927E RID: 37502 RVA: 0x000D22B1 File Offset: 0x000D04B1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UEngineTypes._ClassPtr;
		}

		// Token: 0x0600927F RID: 37503 RVA: 0x000D22BD File Offset: 0x000D04BD
		static UEngineTypes()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.EngineTypes");
		}

		// Token: 0x06009280 RID: 37504 RVA: 0x000D22CC File Offset: 0x000D04CC
		protected UEngineTypes() : this(BuiltinUtils.AllocNativeUObject(UEngineTypes.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06009281 RID: 37505 RVA: 0x000D22F4 File Offset: 0x000D04F4
		protected UEngineTypes(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04004CE9 RID: 19689
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.EngineTypes";

		// Token: 0x04004CEA RID: 19690
		private static IntPtr _ClassPtr;

		// Token: 0x04004CEB RID: 19691
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
