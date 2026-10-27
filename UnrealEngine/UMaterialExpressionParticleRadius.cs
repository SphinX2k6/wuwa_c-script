using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E0E RID: 3598
	[UnrealObjectPath("/Script/Engine.MaterialExpressionParticleRadius")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 192)]
	public class UMaterialExpressionParticleRadius : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C22F RID: 49711 RVA: 0x00117E22 File Offset: 0x00116022
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionParticleRadius._ClassPtr;
		}

		// Token: 0x0600C230 RID: 49712 RVA: 0x00117E30 File Offset: 0x00116030
		public UMaterialExpressionParticleRadius() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionParticleRadius.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C231 RID: 49713 RVA: 0x00117E58 File Offset: 0x00116058
		[NullableContext(1)]
		public UMaterialExpressionParticleRadius(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionParticleRadius.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600C232 RID: 49714 RVA: 0x00117E8B File Offset: 0x0011608B
		static UMaterialExpressionParticleRadius()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionParticleRadius");
		}

		// Token: 0x0600C233 RID: 49715 RVA: 0x00117E99 File Offset: 0x00116099
		protected UMaterialExpressionParticleRadius(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006755 RID: 26453
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionParticleRadius";

		// Token: 0x04006756 RID: 26454
		private static IntPtr _ClassPtr;

		// Token: 0x04006757 RID: 26455
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
