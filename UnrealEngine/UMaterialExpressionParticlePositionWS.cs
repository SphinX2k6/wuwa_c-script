using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E0D RID: 3597
	[UnrealObjectPath("/Script/Engine.MaterialExpressionParticlePositionWS")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 192)]
	public class UMaterialExpressionParticlePositionWS : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C22A RID: 49706 RVA: 0x00117DA2 File Offset: 0x00115FA2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionParticlePositionWS._ClassPtr;
		}

		// Token: 0x0600C22B RID: 49707 RVA: 0x00117DB0 File Offset: 0x00115FB0
		public UMaterialExpressionParticlePositionWS() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionParticlePositionWS.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C22C RID: 49708 RVA: 0x00117DD8 File Offset: 0x00115FD8
		[NullableContext(1)]
		public UMaterialExpressionParticlePositionWS(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionParticlePositionWS.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600C22D RID: 49709 RVA: 0x00117E0B File Offset: 0x0011600B
		static UMaterialExpressionParticlePositionWS()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionParticlePositionWS");
		}

		// Token: 0x0600C22E RID: 49710 RVA: 0x00117E19 File Offset: 0x00116019
		protected UMaterialExpressionParticlePositionWS(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006752 RID: 26450
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionParticlePositionWS";

		// Token: 0x04006753 RID: 26451
		private static IntPtr _ClassPtr;

		// Token: 0x04006754 RID: 26452
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
