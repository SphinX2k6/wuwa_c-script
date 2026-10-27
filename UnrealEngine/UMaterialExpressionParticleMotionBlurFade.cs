using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E0C RID: 3596
	[UnrealObjectPath("/Script/Engine.MaterialExpressionParticleMotionBlurFade")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 192)]
	public class UMaterialExpressionParticleMotionBlurFade : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C225 RID: 49701 RVA: 0x00117D22 File Offset: 0x00115F22
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionParticleMotionBlurFade._ClassPtr;
		}

		// Token: 0x0600C226 RID: 49702 RVA: 0x00117D30 File Offset: 0x00115F30
		public UMaterialExpressionParticleMotionBlurFade() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionParticleMotionBlurFade.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C227 RID: 49703 RVA: 0x00117D58 File Offset: 0x00115F58
		[NullableContext(1)]
		public UMaterialExpressionParticleMotionBlurFade(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionParticleMotionBlurFade.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600C228 RID: 49704 RVA: 0x00117D8B File Offset: 0x00115F8B
		static UMaterialExpressionParticleMotionBlurFade()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionParticleMotionBlurFade");
		}

		// Token: 0x0600C229 RID: 49705 RVA: 0x00117D99 File Offset: 0x00115F99
		protected UMaterialExpressionParticleMotionBlurFade(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400674F RID: 26447
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionParticleMotionBlurFade";

		// Token: 0x04006750 RID: 26448
		private static IntPtr _ClassPtr;

		// Token: 0x04006751 RID: 26449
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
