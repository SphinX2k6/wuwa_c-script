using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000D80 RID: 3456
	[UnrealObjectPath("/Script/Engine.MaterialExpressionActorPositionWS")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 192)]
	public class UMaterialExpressionActorPositionWS : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600BCE8 RID: 48360 RVA: 0x0010DFB1 File Offset: 0x0010C1B1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionActorPositionWS._ClassPtr;
		}

		// Token: 0x0600BCE9 RID: 48361 RVA: 0x0010DFC0 File Offset: 0x0010C1C0
		public UMaterialExpressionActorPositionWS() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionActorPositionWS.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600BCEA RID: 48362 RVA: 0x0010DFE8 File Offset: 0x0010C1E8
		[NullableContext(1)]
		public UMaterialExpressionActorPositionWS(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionActorPositionWS.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600BCEB RID: 48363 RVA: 0x0010E01B File Offset: 0x0010C21B
		static UMaterialExpressionActorPositionWS()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionActorPositionWS");
		}

		// Token: 0x0600BCEC RID: 48364 RVA: 0x0010E029 File Offset: 0x0010C229
		protected UMaterialExpressionActorPositionWS(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400639D RID: 25501
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionActorPositionWS";

		// Token: 0x0400639E RID: 25502
		private static IntPtr _ClassPtr;

		// Token: 0x0400639F RID: 25503
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
