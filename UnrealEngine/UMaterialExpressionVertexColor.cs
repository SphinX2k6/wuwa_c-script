using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E73 RID: 3699
	[UnrealObjectPath("/Script/Engine.MaterialExpressionVertexColor")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 192)]
	public class UMaterialExpressionVertexColor : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C5CA RID: 50634 RVA: 0x0011E706 File Offset: 0x0011C906
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionVertexColor._ClassPtr;
		}

		// Token: 0x0600C5CB RID: 50635 RVA: 0x0011E714 File Offset: 0x0011C914
		public UMaterialExpressionVertexColor() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionVertexColor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C5CC RID: 50636 RVA: 0x0011E73C File Offset: 0x0011C93C
		[NullableContext(1)]
		public UMaterialExpressionVertexColor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionVertexColor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600C5CD RID: 50637 RVA: 0x0011E76F File Offset: 0x0011C96F
		static UMaterialExpressionVertexColor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionVertexColor");
		}

		// Token: 0x0600C5CE RID: 50638 RVA: 0x0011E77D File Offset: 0x0011C97D
		protected UMaterialExpressionVertexColor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040069D3 RID: 27091
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionVertexColor";

		// Token: 0x040069D4 RID: 27092
		private static IntPtr _ClassPtr;

		// Token: 0x040069D5 RID: 27093
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
