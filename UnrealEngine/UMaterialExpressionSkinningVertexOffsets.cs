using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E43 RID: 3651
	[UnrealObjectPath("/Script/Engine.MaterialExpressionSkinningVertexOffsets")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 192)]
	public class UMaterialExpressionSkinningVertexOffsets : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C411 RID: 50193 RVA: 0x0011B6BD File Offset: 0x001198BD
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionSkinningVertexOffsets._ClassPtr;
		}

		// Token: 0x0600C412 RID: 50194 RVA: 0x0011B6CC File Offset: 0x001198CC
		public UMaterialExpressionSkinningVertexOffsets() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionSkinningVertexOffsets.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C413 RID: 50195 RVA: 0x0011B6F4 File Offset: 0x001198F4
		[NullableContext(1)]
		public UMaterialExpressionSkinningVertexOffsets(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionSkinningVertexOffsets.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600C414 RID: 50196 RVA: 0x0011B727 File Offset: 0x00119927
		static UMaterialExpressionSkinningVertexOffsets()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionSkinningVertexOffsets");
		}

		// Token: 0x0600C415 RID: 50197 RVA: 0x0011B735 File Offset: 0x00119935
		protected UMaterialExpressionSkinningVertexOffsets(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040068A8 RID: 26792
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionSkinningVertexOffsets";

		// Token: 0x040068A9 RID: 26793
		private static IntPtr _ClassPtr;

		// Token: 0x040068AA RID: 26794
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
