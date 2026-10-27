using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000DAF RID: 3503
	[UnrealObjectPath("/Script/Engine.MaterialExpressionDecalDerivative")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 192)]
	public class UMaterialExpressionDecalDerivative : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600BE85 RID: 48773 RVA: 0x00110E29 File Offset: 0x0010F029
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionDecalDerivative._ClassPtr;
		}

		// Token: 0x0600BE86 RID: 48774 RVA: 0x00110E38 File Offset: 0x0010F038
		public UMaterialExpressionDecalDerivative() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionDecalDerivative.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600BE87 RID: 48775 RVA: 0x00110E60 File Offset: 0x0010F060
		[NullableContext(1)]
		public UMaterialExpressionDecalDerivative(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionDecalDerivative.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600BE88 RID: 48776 RVA: 0x00110E93 File Offset: 0x0010F093
		static UMaterialExpressionDecalDerivative()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionDecalDerivative");
		}

		// Token: 0x0600BE89 RID: 48777 RVA: 0x00110EA1 File Offset: 0x0010F0A1
		protected UMaterialExpressionDecalDerivative(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040064B9 RID: 25785
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionDecalDerivative";

		// Token: 0x040064BA RID: 25786
		private static IntPtr _ClassPtr;

		// Token: 0x040064BB RID: 25787
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
