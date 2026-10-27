using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000DF6 RID: 3574
	[UnrealObjectPath("/Script/Engine.MaterialExpressionMaterialLayerOutput")]
	[UnrealStructLayout(312, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 312)]
	public class UMaterialExpressionMaterialLayerOutput : UMaterialExpressionFunctionOutput, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C162 RID: 49506 RVA: 0x00116861 File Offset: 0x00114A61
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionMaterialLayerOutput._ClassPtr;
		}

		// Token: 0x0600C163 RID: 49507 RVA: 0x00116870 File Offset: 0x00114A70
		public UMaterialExpressionMaterialLayerOutput() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionMaterialLayerOutput.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C164 RID: 49508 RVA: 0x00116898 File Offset: 0x00114A98
		[NullableContext(1)]
		public UMaterialExpressionMaterialLayerOutput(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionMaterialLayerOutput.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600C165 RID: 49509 RVA: 0x001168CB File Offset: 0x00114ACB
		static UMaterialExpressionMaterialLayerOutput()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionMaterialLayerOutput");
		}

		// Token: 0x0600C166 RID: 49510 RVA: 0x001168D9 File Offset: 0x00114AD9
		protected UMaterialExpressionMaterialLayerOutput(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040066CF RID: 26319
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionMaterialLayerOutput";

		// Token: 0x040066D0 RID: 26320
		private static IntPtr _ClassPtr;

		// Token: 0x040066D1 RID: 26321
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
