using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E14 RID: 3604
	[UnrealObjectPath("/Script/Engine.MaterialExpressionParticleSubUVProperties")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 192)]
	public class UMaterialExpressionParticleSubUVProperties : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C24F RID: 49743 RVA: 0x0011816B File Offset: 0x0011636B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionParticleSubUVProperties._ClassPtr;
		}

		// Token: 0x0600C250 RID: 49744 RVA: 0x00118178 File Offset: 0x00116378
		public UMaterialExpressionParticleSubUVProperties() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionParticleSubUVProperties.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C251 RID: 49745 RVA: 0x001181A0 File Offset: 0x001163A0
		[NullableContext(1)]
		public UMaterialExpressionParticleSubUVProperties(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionParticleSubUVProperties.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600C252 RID: 49746 RVA: 0x001181D3 File Offset: 0x001163D3
		static UMaterialExpressionParticleSubUVProperties()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionParticleSubUVProperties");
		}

		// Token: 0x0600C253 RID: 49747 RVA: 0x001181E1 File Offset: 0x001163E1
		protected UMaterialExpressionParticleSubUVProperties(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006769 RID: 26473
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionParticleSubUVProperties";

		// Token: 0x0400676A RID: 26474
		private static IntPtr _ClassPtr;

		// Token: 0x0400676B RID: 26475
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
