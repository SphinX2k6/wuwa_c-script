using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E76 RID: 3702
	[UnrealObjectPath("/Script/Engine.MaterialExpressionVertexPositionLS")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 192)]
	public class UMaterialExpressionVertexPositionLS : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C5DB RID: 50651 RVA: 0x0011E8E2 File Offset: 0x0011CAE2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionVertexPositionLS._ClassPtr;
		}

		// Token: 0x0600C5DC RID: 50652 RVA: 0x0011E8F0 File Offset: 0x0011CAF0
		public UMaterialExpressionVertexPositionLS() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionVertexPositionLS.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C5DD RID: 50653 RVA: 0x0011E918 File Offset: 0x0011CB18
		[NullableContext(1)]
		public UMaterialExpressionVertexPositionLS(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionVertexPositionLS.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600C5DE RID: 50654 RVA: 0x0011E94B File Offset: 0x0011CB4B
		static UMaterialExpressionVertexPositionLS()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionVertexPositionLS");
		}

		// Token: 0x0600C5DF RID: 50655 RVA: 0x0011E959 File Offset: 0x0011CB59
		protected UMaterialExpressionVertexPositionLS(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040069DE RID: 27102
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionVertexPositionLS";

		// Token: 0x040069DF RID: 27103
		private static IntPtr _ClassPtr;

		// Token: 0x040069E0 RID: 27104
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
