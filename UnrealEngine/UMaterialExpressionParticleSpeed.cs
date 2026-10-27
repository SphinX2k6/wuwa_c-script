using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E12 RID: 3602
	[UnrealObjectPath("/Script/Engine.MaterialExpressionParticleSpeed")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 192)]
	public class UMaterialExpressionParticleSpeed : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C243 RID: 49731 RVA: 0x00118022 File Offset: 0x00116222
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionParticleSpeed._ClassPtr;
		}

		// Token: 0x0600C244 RID: 49732 RVA: 0x00118030 File Offset: 0x00116230
		public UMaterialExpressionParticleSpeed() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionParticleSpeed.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C245 RID: 49733 RVA: 0x00118058 File Offset: 0x00116258
		[NullableContext(1)]
		public UMaterialExpressionParticleSpeed(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionParticleSpeed.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600C246 RID: 49734 RVA: 0x0011808B File Offset: 0x0011628B
		static UMaterialExpressionParticleSpeed()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionParticleSpeed");
		}

		// Token: 0x0600C247 RID: 49735 RVA: 0x00118099 File Offset: 0x00116299
		protected UMaterialExpressionParticleSpeed(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006761 RID: 26465
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionParticleSpeed";

		// Token: 0x04006762 RID: 26466
		private static IntPtr _ClassPtr;

		// Token: 0x04006763 RID: 26467
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
