using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E17 RID: 3607
	[UnrealObjectPath("/Script/Engine.MaterialExpressionPerInstanceFadeAmount")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 192)]
	public class UMaterialExpressionPerInstanceFadeAmount : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C26A RID: 49770 RVA: 0x00118423 File Offset: 0x00116623
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionPerInstanceFadeAmount._ClassPtr;
		}

		// Token: 0x0600C26B RID: 49771 RVA: 0x00118430 File Offset: 0x00116630
		public UMaterialExpressionPerInstanceFadeAmount() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionPerInstanceFadeAmount.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C26C RID: 49772 RVA: 0x00118458 File Offset: 0x00116658
		[NullableContext(1)]
		public UMaterialExpressionPerInstanceFadeAmount(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionPerInstanceFadeAmount.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600C26D RID: 49773 RVA: 0x0011848B File Offset: 0x0011668B
		static UMaterialExpressionPerInstanceFadeAmount()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionPerInstanceFadeAmount");
		}

		// Token: 0x0600C26E RID: 49774 RVA: 0x00118499 File Offset: 0x00116699
		protected UMaterialExpressionPerInstanceFadeAmount(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400677A RID: 26490
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionPerInstanceFadeAmount";

		// Token: 0x0400677B RID: 26491
		private static IntPtr _ClassPtr;

		// Token: 0x0400677C RID: 26492
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
