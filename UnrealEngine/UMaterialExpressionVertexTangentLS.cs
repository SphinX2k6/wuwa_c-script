using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E77 RID: 3703
	[UnrealObjectPath("/Script/Engine.MaterialExpressionVertexTangentLS")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 192)]
	public class UMaterialExpressionVertexTangentLS : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C5E0 RID: 50656 RVA: 0x0011E962 File Offset: 0x0011CB62
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionVertexTangentLS._ClassPtr;
		}

		// Token: 0x0600C5E1 RID: 50657 RVA: 0x0011E970 File Offset: 0x0011CB70
		public UMaterialExpressionVertexTangentLS() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionVertexTangentLS.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C5E2 RID: 50658 RVA: 0x0011E998 File Offset: 0x0011CB98
		[NullableContext(1)]
		public UMaterialExpressionVertexTangentLS(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionVertexTangentLS.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600C5E3 RID: 50659 RVA: 0x0011E9CB File Offset: 0x0011CBCB
		static UMaterialExpressionVertexTangentLS()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionVertexTangentLS");
		}

		// Token: 0x0600C5E4 RID: 50660 RVA: 0x0011E9D9 File Offset: 0x0011CBD9
		protected UMaterialExpressionVertexTangentLS(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040069E1 RID: 27105
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionVertexTangentLS";

		// Token: 0x040069E2 RID: 27106
		private static IntPtr _ClassPtr;

		// Token: 0x040069E3 RID: 27107
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
