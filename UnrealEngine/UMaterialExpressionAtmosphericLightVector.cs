using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000D8E RID: 3470
	[UnrealObjectPath("/Script/Engine.MaterialExpressionAtmosphericLightVector")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 192)]
	public class UMaterialExpressionAtmosphericLightVector : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600BD54 RID: 48468 RVA: 0x0010EC9E File Offset: 0x0010CE9E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionAtmosphericLightVector._ClassPtr;
		}

		// Token: 0x0600BD55 RID: 48469 RVA: 0x0010ECAC File Offset: 0x0010CEAC
		public UMaterialExpressionAtmosphericLightVector() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionAtmosphericLightVector.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600BD56 RID: 48470 RVA: 0x0010ECD4 File Offset: 0x0010CED4
		[NullableContext(1)]
		public UMaterialExpressionAtmosphericLightVector(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionAtmosphericLightVector.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600BD57 RID: 48471 RVA: 0x0010ED07 File Offset: 0x0010CF07
		static UMaterialExpressionAtmosphericLightVector()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionAtmosphericLightVector");
		}

		// Token: 0x0600BD58 RID: 48472 RVA: 0x0010ED15 File Offset: 0x0010CF15
		protected UMaterialExpressionAtmosphericLightVector(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040063E9 RID: 25577
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionAtmosphericLightVector";

		// Token: 0x040063EA RID: 25578
		private static IntPtr _ClassPtr;

		// Token: 0x040063EB RID: 25579
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
