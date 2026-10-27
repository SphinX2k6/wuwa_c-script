using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E87 RID: 3719
	[UnrealObjectPath("/Script/Engine.MaterialFunctionMaterialLayerInstance")]
	[UnrealStructLayout(224, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 224)]
	public class UMaterialFunctionMaterialLayerInstance : UMaterialFunctionInstance, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C67F RID: 50815 RVA: 0x0011F9EE File Offset: 0x0011DBEE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialFunctionMaterialLayerInstance._ClassPtr;
		}

		// Token: 0x0600C680 RID: 50816 RVA: 0x0011F9FC File Offset: 0x0011DBFC
		public UMaterialFunctionMaterialLayerInstance() : this(BuiltinUtils.AllocNativeUObject(UMaterialFunctionMaterialLayerInstance.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C681 RID: 50817 RVA: 0x0011FA24 File Offset: 0x0011DC24
		[NullableContext(1)]
		public UMaterialFunctionMaterialLayerInstance(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialFunctionMaterialLayerInstance.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600C682 RID: 50818 RVA: 0x0011FA57 File Offset: 0x0011DC57
		static UMaterialFunctionMaterialLayerInstance()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialFunctionMaterialLayerInstance");
		}

		// Token: 0x0600C683 RID: 50819 RVA: 0x0011FA65 File Offset: 0x0011DC65
		protected UMaterialFunctionMaterialLayerInstance(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006A48 RID: 27208
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialFunctionMaterialLayerInstance";

		// Token: 0x04006A49 RID: 27209
		private static IntPtr _ClassPtr;

		// Token: 0x04006A4A RID: 27210
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
