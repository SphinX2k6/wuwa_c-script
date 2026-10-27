using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E11 RID: 3601
	[UnrealObjectPath("/Script/Engine.MaterialExpressionParticleSize")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 192)]
	public class UMaterialExpressionParticleSize : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C23E RID: 49726 RVA: 0x00117FA2 File Offset: 0x001161A2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionParticleSize._ClassPtr;
		}

		// Token: 0x0600C23F RID: 49727 RVA: 0x00117FB0 File Offset: 0x001161B0
		public UMaterialExpressionParticleSize() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionParticleSize.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C240 RID: 49728 RVA: 0x00117FD8 File Offset: 0x001161D8
		[NullableContext(1)]
		public UMaterialExpressionParticleSize(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionParticleSize.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600C241 RID: 49729 RVA: 0x0011800B File Offset: 0x0011620B
		static UMaterialExpressionParticleSize()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionParticleSize");
		}

		// Token: 0x0600C242 RID: 49730 RVA: 0x00118019 File Offset: 0x00116219
		protected UMaterialExpressionParticleSize(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400675E RID: 26462
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionParticleSize";

		// Token: 0x0400675F RID: 26463
		private static IntPtr _ClassPtr;

		// Token: 0x04006760 RID: 26464
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
