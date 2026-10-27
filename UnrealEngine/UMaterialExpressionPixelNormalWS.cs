using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E1A RID: 3610
	[UnrealObjectPath("/Script/Engine.MaterialExpressionPixelNormalWS")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 192)]
	public class UMaterialExpressionPixelNormalWS : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C279 RID: 49785 RVA: 0x001185A2 File Offset: 0x001167A2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionPixelNormalWS._ClassPtr;
		}

		// Token: 0x0600C27A RID: 49786 RVA: 0x001185B0 File Offset: 0x001167B0
		public UMaterialExpressionPixelNormalWS() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionPixelNormalWS.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C27B RID: 49787 RVA: 0x001185D8 File Offset: 0x001167D8
		[NullableContext(1)]
		public UMaterialExpressionPixelNormalWS(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionPixelNormalWS.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600C27C RID: 49788 RVA: 0x0011860B File Offset: 0x0011680B
		static UMaterialExpressionPixelNormalWS()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionPixelNormalWS");
		}

		// Token: 0x0600C27D RID: 49789 RVA: 0x00118619 File Offset: 0x00116819
		protected UMaterialExpressionPixelNormalWS(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006783 RID: 26499
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionPixelNormalWS";

		// Token: 0x04006784 RID: 26500
		private static IntPtr _ClassPtr;

		// Token: 0x04006785 RID: 26501
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
