using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E0F RID: 3599
	[UnrealObjectPath("/Script/Engine.MaterialExpressionParticleRandom")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 192)]
	public class UMaterialExpressionParticleRandom : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C234 RID: 49716 RVA: 0x00117EA2 File Offset: 0x001160A2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionParticleRandom._ClassPtr;
		}

		// Token: 0x0600C235 RID: 49717 RVA: 0x00117EB0 File Offset: 0x001160B0
		public UMaterialExpressionParticleRandom() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionParticleRandom.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C236 RID: 49718 RVA: 0x00117ED8 File Offset: 0x001160D8
		[NullableContext(1)]
		public UMaterialExpressionParticleRandom(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionParticleRandom.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600C237 RID: 49719 RVA: 0x00117F0B File Offset: 0x0011610B
		static UMaterialExpressionParticleRandom()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionParticleRandom");
		}

		// Token: 0x0600C238 RID: 49720 RVA: 0x00117F19 File Offset: 0x00116119
		protected UMaterialExpressionParticleRandom(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006758 RID: 26456
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionParticleRandom";

		// Token: 0x04006759 RID: 26457
		private static IntPtr _ClassPtr;

		// Token: 0x0400675A RID: 26458
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
