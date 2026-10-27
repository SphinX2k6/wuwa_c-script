using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000AF2 RID: 2802
	[UnrealObjectPath("/Script/Engine.EngineCustomTimeStep")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public abstract class UEngineCustomTimeStep : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06009251 RID: 37457 RVA: 0x000D1F45 File Offset: 0x000D0145
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UEngineCustomTimeStep._ClassPtr;
		}

		// Token: 0x06009252 RID: 37458 RVA: 0x000D1F51 File Offset: 0x000D0151
		static UEngineCustomTimeStep()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.EngineCustomTimeStep");
		}

		// Token: 0x06009253 RID: 37459 RVA: 0x000D1F60 File Offset: 0x000D0160
		protected UEngineCustomTimeStep() : this(BuiltinUtils.AllocNativeUObject(UEngineCustomTimeStep.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06009254 RID: 37460 RVA: 0x000D1F88 File Offset: 0x000D0188
		protected UEngineCustomTimeStep(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04004CD1 RID: 19665
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.EngineCustomTimeStep";

		// Token: 0x04004CD2 RID: 19666
		private static IntPtr _ClassPtr;

		// Token: 0x04004CD3 RID: 19667
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
