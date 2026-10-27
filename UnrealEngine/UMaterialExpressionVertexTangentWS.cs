using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E78 RID: 3704
	[UnrealObjectPath("/Script/Engine.MaterialExpressionVertexTangentWS")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 192)]
	public class UMaterialExpressionVertexTangentWS : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C5E5 RID: 50661 RVA: 0x0011E9E2 File Offset: 0x0011CBE2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionVertexTangentWS._ClassPtr;
		}

		// Token: 0x0600C5E6 RID: 50662 RVA: 0x0011E9F0 File Offset: 0x0011CBF0
		public UMaterialExpressionVertexTangentWS() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionVertexTangentWS.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C5E7 RID: 50663 RVA: 0x0011EA18 File Offset: 0x0011CC18
		[NullableContext(1)]
		public UMaterialExpressionVertexTangentWS(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionVertexTangentWS.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600C5E8 RID: 50664 RVA: 0x0011EA4B File Offset: 0x0011CC4B
		static UMaterialExpressionVertexTangentWS()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionVertexTangentWS");
		}

		// Token: 0x0600C5E9 RID: 50665 RVA: 0x0011EA59 File Offset: 0x0011CC59
		protected UMaterialExpressionVertexTangentWS(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040069E4 RID: 27108
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionVertexTangentWS";

		// Token: 0x040069E5 RID: 27109
		private static IntPtr _ClassPtr;

		// Token: 0x040069E6 RID: 27110
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
