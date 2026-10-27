using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E85 RID: 3717
	[UnrealObjectPath("/Script/Engine.MaterialFunctionMaterialLayerBlend")]
	[UnrealStructLayout(216, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 216)]
	public class UMaterialFunctionMaterialLayerBlend : UMaterialFunction, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C675 RID: 50805 RVA: 0x0011F8EE File Offset: 0x0011DAEE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialFunctionMaterialLayerBlend._ClassPtr;
		}

		// Token: 0x0600C676 RID: 50806 RVA: 0x0011F8FC File Offset: 0x0011DAFC
		public UMaterialFunctionMaterialLayerBlend() : this(BuiltinUtils.AllocNativeUObject(UMaterialFunctionMaterialLayerBlend.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C677 RID: 50807 RVA: 0x0011F924 File Offset: 0x0011DB24
		[NullableContext(1)]
		public UMaterialFunctionMaterialLayerBlend(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialFunctionMaterialLayerBlend.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600C678 RID: 50808 RVA: 0x0011F957 File Offset: 0x0011DB57
		static UMaterialFunctionMaterialLayerBlend()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialFunctionMaterialLayerBlend");
		}

		// Token: 0x0600C679 RID: 50809 RVA: 0x0011F965 File Offset: 0x0011DB65
		protected UMaterialFunctionMaterialLayerBlend(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006A42 RID: 27202
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialFunctionMaterialLayerBlend";

		// Token: 0x04006A43 RID: 27203
		private static IntPtr _ClassPtr;

		// Token: 0x04006A44 RID: 27204
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
