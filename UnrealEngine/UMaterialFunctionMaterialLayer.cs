using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E84 RID: 3716
	[UnrealObjectPath("/Script/Engine.MaterialFunctionMaterialLayer")]
	[UnrealStructLayout(216, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 216)]
	public class UMaterialFunctionMaterialLayer : UMaterialFunction, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C670 RID: 50800 RVA: 0x0011F870 File Offset: 0x0011DA70
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialFunctionMaterialLayer._ClassPtr;
		}

		// Token: 0x0600C671 RID: 50801 RVA: 0x0011F87C File Offset: 0x0011DA7C
		public UMaterialFunctionMaterialLayer() : this(BuiltinUtils.AllocNativeUObject(UMaterialFunctionMaterialLayer.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C672 RID: 50802 RVA: 0x0011F8A4 File Offset: 0x0011DAA4
		[NullableContext(1)]
		public UMaterialFunctionMaterialLayer(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialFunctionMaterialLayer.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600C673 RID: 50803 RVA: 0x0011F8D7 File Offset: 0x0011DAD7
		static UMaterialFunctionMaterialLayer()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialFunctionMaterialLayer");
		}

		// Token: 0x0600C674 RID: 50804 RVA: 0x0011F8E5 File Offset: 0x0011DAE5
		protected UMaterialFunctionMaterialLayer(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006A3F RID: 27199
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialFunctionMaterialLayer";

		// Token: 0x04006A40 RID: 27200
		private static IntPtr _ClassPtr;

		// Token: 0x04006A41 RID: 27201
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
