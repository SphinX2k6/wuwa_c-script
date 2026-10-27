using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E10 RID: 3600
	[UnrealObjectPath("/Script/Engine.MaterialExpressionParticleRelativeTime")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 192)]
	public class UMaterialExpressionParticleRelativeTime : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C239 RID: 49721 RVA: 0x00117F22 File Offset: 0x00116122
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionParticleRelativeTime._ClassPtr;
		}

		// Token: 0x0600C23A RID: 49722 RVA: 0x00117F30 File Offset: 0x00116130
		public UMaterialExpressionParticleRelativeTime() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionParticleRelativeTime.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C23B RID: 49723 RVA: 0x00117F58 File Offset: 0x00116158
		[NullableContext(1)]
		public UMaterialExpressionParticleRelativeTime(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionParticleRelativeTime.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600C23C RID: 49724 RVA: 0x00117F8B File Offset: 0x0011618B
		static UMaterialExpressionParticleRelativeTime()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionParticleRelativeTime");
		}

		// Token: 0x0600C23D RID: 49725 RVA: 0x00117F99 File Offset: 0x00116199
		protected UMaterialExpressionParticleRelativeTime(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400675B RID: 26459
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionParticleRelativeTime";

		// Token: 0x0400675C RID: 26460
		private static IntPtr _ClassPtr;

		// Token: 0x0400675D RID: 26461
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
