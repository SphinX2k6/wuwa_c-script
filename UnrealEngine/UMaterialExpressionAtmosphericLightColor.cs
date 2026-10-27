using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000D8D RID: 3469
	[UnrealObjectPath("/Script/Engine.MaterialExpressionAtmosphericLightColor")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 192)]
	public class UMaterialExpressionAtmosphericLightColor : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600BD4F RID: 48463 RVA: 0x0010EC1D File Offset: 0x0010CE1D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionAtmosphericLightColor._ClassPtr;
		}

		// Token: 0x0600BD50 RID: 48464 RVA: 0x0010EC2C File Offset: 0x0010CE2C
		public UMaterialExpressionAtmosphericLightColor() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionAtmosphericLightColor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600BD51 RID: 48465 RVA: 0x0010EC54 File Offset: 0x0010CE54
		[NullableContext(1)]
		public UMaterialExpressionAtmosphericLightColor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionAtmosphericLightColor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600BD52 RID: 48466 RVA: 0x0010EC87 File Offset: 0x0010CE87
		static UMaterialExpressionAtmosphericLightColor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionAtmosphericLightColor");
		}

		// Token: 0x0600BD53 RID: 48467 RVA: 0x0010EC95 File Offset: 0x0010CE95
		protected UMaterialExpressionAtmosphericLightColor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040063E6 RID: 25574
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionAtmosphericLightColor";

		// Token: 0x040063E7 RID: 25575
		private static IntPtr _ClassPtr;

		// Token: 0x040063E8 RID: 25576
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
