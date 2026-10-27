using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E7D RID: 3709
	[UnrealObjectPath("/Script/Engine.MaterialExpressionVolumetricAdvancedMaterialInput")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 192)]
	public class UMaterialExpressionVolumetricAdvancedMaterialInput : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C604 RID: 50692 RVA: 0x0011ED41 File Offset: 0x0011CF41
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionVolumetricAdvancedMaterialInput._ClassPtr;
		}

		// Token: 0x0600C605 RID: 50693 RVA: 0x0011ED50 File Offset: 0x0011CF50
		public UMaterialExpressionVolumetricAdvancedMaterialInput() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionVolumetricAdvancedMaterialInput.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C606 RID: 50694 RVA: 0x0011ED78 File Offset: 0x0011CF78
		[NullableContext(1)]
		public UMaterialExpressionVolumetricAdvancedMaterialInput(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionVolumetricAdvancedMaterialInput.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600C607 RID: 50695 RVA: 0x0011EDAB File Offset: 0x0011CFAB
		static UMaterialExpressionVolumetricAdvancedMaterialInput()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionVolumetricAdvancedMaterialInput");
		}

		// Token: 0x0600C608 RID: 50696 RVA: 0x0011EDB9 File Offset: 0x0011CFB9
		protected UMaterialExpressionVolumetricAdvancedMaterialInput(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040069F8 RID: 27128
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionVolumetricAdvancedMaterialInput";

		// Token: 0x040069F9 RID: 27129
		private static IntPtr _ClassPtr;

		// Token: 0x040069FA RID: 27130
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
