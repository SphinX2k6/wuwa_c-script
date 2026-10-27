using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000D97 RID: 3479
	[UnrealObjectPath("/Script/Engine.MaterialExpressionCameraPositionWS")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 192)]
	public class UMaterialExpressionCameraPositionWS : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600BDAE RID: 48558 RVA: 0x0010F718 File Offset: 0x0010D918
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionCameraPositionWS._ClassPtr;
		}

		// Token: 0x0600BDAF RID: 48559 RVA: 0x0010F724 File Offset: 0x0010D924
		public UMaterialExpressionCameraPositionWS() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionCameraPositionWS.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600BDB0 RID: 48560 RVA: 0x0010F74C File Offset: 0x0010D94C
		[NullableContext(1)]
		public UMaterialExpressionCameraPositionWS(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionCameraPositionWS.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600BDB1 RID: 48561 RVA: 0x0010F77F File Offset: 0x0010D97F
		static UMaterialExpressionCameraPositionWS()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionCameraPositionWS");
		}

		// Token: 0x0600BDB2 RID: 48562 RVA: 0x0010F78D File Offset: 0x0010D98D
		protected UMaterialExpressionCameraPositionWS(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400642A RID: 25642
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionCameraPositionWS";

		// Token: 0x0400642B RID: 25643
		private static IntPtr _ClassPtr;

		// Token: 0x0400642C RID: 25644
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
