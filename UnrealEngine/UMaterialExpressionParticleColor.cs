using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E09 RID: 3593
	[UnrealObjectPath("/Script/Engine.MaterialExpressionParticleColor")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 192)]
	public class UMaterialExpressionParticleColor : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C216 RID: 49686 RVA: 0x00117BA4 File Offset: 0x00115DA4
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionParticleColor._ClassPtr;
		}

		// Token: 0x0600C217 RID: 49687 RVA: 0x00117BB0 File Offset: 0x00115DB0
		public UMaterialExpressionParticleColor() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionParticleColor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C218 RID: 49688 RVA: 0x00117BD8 File Offset: 0x00115DD8
		[NullableContext(1)]
		public UMaterialExpressionParticleColor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionParticleColor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600C219 RID: 49689 RVA: 0x00117C0B File Offset: 0x00115E0B
		static UMaterialExpressionParticleColor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionParticleColor");
		}

		// Token: 0x0600C21A RID: 49690 RVA: 0x00117C19 File Offset: 0x00115E19
		protected UMaterialExpressionParticleColor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006746 RID: 26438
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionParticleColor";

		// Token: 0x04006747 RID: 26439
		private static IntPtr _ClassPtr;

		// Token: 0x04006748 RID: 26440
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
