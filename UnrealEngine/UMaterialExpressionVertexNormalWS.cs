using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E75 RID: 3701
	[UnrealObjectPath("/Script/Engine.MaterialExpressionVertexNormalWS")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 192)]
	public class UMaterialExpressionVertexNormalWS : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C5D6 RID: 50646 RVA: 0x0011E861 File Offset: 0x0011CA61
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionVertexNormalWS._ClassPtr;
		}

		// Token: 0x0600C5D7 RID: 50647 RVA: 0x0011E870 File Offset: 0x0011CA70
		public UMaterialExpressionVertexNormalWS() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionVertexNormalWS.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C5D8 RID: 50648 RVA: 0x0011E898 File Offset: 0x0011CA98
		[NullableContext(1)]
		public UMaterialExpressionVertexNormalWS(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionVertexNormalWS.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600C5D9 RID: 50649 RVA: 0x0011E8CB File Offset: 0x0011CACB
		static UMaterialExpressionVertexNormalWS()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionVertexNormalWS");
		}

		// Token: 0x0600C5DA RID: 50650 RVA: 0x0011E8D9 File Offset: 0x0011CAD9
		protected UMaterialExpressionVertexNormalWS(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040069DB RID: 27099
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionVertexNormalWS";

		// Token: 0x040069DC RID: 27100
		private static IntPtr _ClassPtr;

		// Token: 0x040069DD RID: 27101
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
