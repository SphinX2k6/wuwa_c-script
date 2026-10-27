using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000DBE RID: 3518
	[UnrealObjectPath("/Script/Engine.MaterialExpressionDynamicSwitchParameter")]
	[UnrealStructLayout(368, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 368)]
	public class UMaterialExpressionDynamicSwitchParameter : UMaterialExpressionScalarParameter, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600BF04 RID: 48900 RVA: 0x00111CB0 File Offset: 0x0010FEB0
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionDynamicSwitchParameter._ClassPtr;
		}

		// Token: 0x0600BF05 RID: 48901 RVA: 0x00111CBC File Offset: 0x0010FEBC
		public UMaterialExpressionDynamicSwitchParameter() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionDynamicSwitchParameter.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600BF06 RID: 48902 RVA: 0x00111CE4 File Offset: 0x0010FEE4
		[NullableContext(1)]
		public UMaterialExpressionDynamicSwitchParameter(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionDynamicSwitchParameter.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600BF07 RID: 48903 RVA: 0x00111D17 File Offset: 0x0010FF17
		static UMaterialExpressionDynamicSwitchParameter()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionDynamicSwitchParameter");
		}

		// Token: 0x0600BF08 RID: 48904 RVA: 0x00111D25 File Offset: 0x0010FF25
		protected UMaterialExpressionDynamicSwitchParameter(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006510 RID: 25872
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionDynamicSwitchParameter";

		// Token: 0x04006511 RID: 25873
		private static IntPtr _ClassPtr;

		// Token: 0x04006512 RID: 25874
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
