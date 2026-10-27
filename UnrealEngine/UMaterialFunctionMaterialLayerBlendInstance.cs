using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E86 RID: 3718
	[UnrealObjectPath("/Script/Engine.MaterialFunctionMaterialLayerBlendInstance")]
	[UnrealStructLayout(224, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 224)]
	public class UMaterialFunctionMaterialLayerBlendInstance : UMaterialFunctionInstance, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C67A RID: 50810 RVA: 0x0011F96E File Offset: 0x0011DB6E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialFunctionMaterialLayerBlendInstance._ClassPtr;
		}

		// Token: 0x0600C67B RID: 50811 RVA: 0x0011F97C File Offset: 0x0011DB7C
		public UMaterialFunctionMaterialLayerBlendInstance() : this(BuiltinUtils.AllocNativeUObject(UMaterialFunctionMaterialLayerBlendInstance.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C67C RID: 50812 RVA: 0x0011F9A4 File Offset: 0x0011DBA4
		[NullableContext(1)]
		public UMaterialFunctionMaterialLayerBlendInstance(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialFunctionMaterialLayerBlendInstance.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600C67D RID: 50813 RVA: 0x0011F9D7 File Offset: 0x0011DBD7
		static UMaterialFunctionMaterialLayerBlendInstance()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialFunctionMaterialLayerBlendInstance");
		}

		// Token: 0x0600C67E RID: 50814 RVA: 0x0011F9E5 File Offset: 0x0011DBE5
		protected UMaterialFunctionMaterialLayerBlendInstance(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006A45 RID: 27205
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialFunctionMaterialLayerBlendInstance";

		// Token: 0x04006A46 RID: 27206
		private static IntPtr _ClassPtr;

		// Token: 0x04006A47 RID: 27207
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
