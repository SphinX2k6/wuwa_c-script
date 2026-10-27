using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000DEE RID: 3566
	[UnrealObjectPath("/Script/Engine.MaterialExpressionLightVector")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 192)]
	public class UMaterialExpressionLightVector : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C0E2 RID: 49378 RVA: 0x001156CD File Offset: 0x001138CD
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionLightVector._ClassPtr;
		}

		// Token: 0x0600C0E3 RID: 49379 RVA: 0x001156DC File Offset: 0x001138DC
		public UMaterialExpressionLightVector() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionLightVector.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C0E4 RID: 49380 RVA: 0x00115704 File Offset: 0x00113904
		[NullableContext(1)]
		public UMaterialExpressionLightVector(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionLightVector.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600C0E5 RID: 49381 RVA: 0x00115737 File Offset: 0x00113937
		static UMaterialExpressionLightVector()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionLightVector");
		}

		// Token: 0x0600C0E6 RID: 49382 RVA: 0x00115745 File Offset: 0x00113945
		protected UMaterialExpressionLightVector(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006668 RID: 26216
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionLightVector";

		// Token: 0x04006669 RID: 26217
		private static IntPtr _ClassPtr;

		// Token: 0x0400666A RID: 26218
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
