using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E0A RID: 3594
	[UnrealObjectPath("/Script/Engine.MaterialExpressionParticleDirection")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 192)]
	public class UMaterialExpressionParticleDirection : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C21B RID: 49691 RVA: 0x00117C22 File Offset: 0x00115E22
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionParticleDirection._ClassPtr;
		}

		// Token: 0x0600C21C RID: 49692 RVA: 0x00117C30 File Offset: 0x00115E30
		public UMaterialExpressionParticleDirection() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionParticleDirection.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C21D RID: 49693 RVA: 0x00117C58 File Offset: 0x00115E58
		[NullableContext(1)]
		public UMaterialExpressionParticleDirection(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionParticleDirection.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600C21E RID: 49694 RVA: 0x00117C8B File Offset: 0x00115E8B
		static UMaterialExpressionParticleDirection()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionParticleDirection");
		}

		// Token: 0x0600C21F RID: 49695 RVA: 0x00117C99 File Offset: 0x00115E99
		protected UMaterialExpressionParticleDirection(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006749 RID: 26441
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionParticleDirection";

		// Token: 0x0400674A RID: 26442
		private static IntPtr _ClassPtr;

		// Token: 0x0400674B RID: 26443
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
