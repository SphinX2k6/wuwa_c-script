using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000D98 RID: 3480
	[UnrealObjectPath("/Script/Engine.MaterialExpressionCameraVectorWS")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 192)]
	public class UMaterialExpressionCameraVectorWS : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600BDB3 RID: 48563 RVA: 0x0010F796 File Offset: 0x0010D996
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionCameraVectorWS._ClassPtr;
		}

		// Token: 0x0600BDB4 RID: 48564 RVA: 0x0010F7A4 File Offset: 0x0010D9A4
		public UMaterialExpressionCameraVectorWS() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionCameraVectorWS.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600BDB5 RID: 48565 RVA: 0x0010F7CC File Offset: 0x0010D9CC
		[NullableContext(1)]
		public UMaterialExpressionCameraVectorWS(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionCameraVectorWS.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600BDB6 RID: 48566 RVA: 0x0010F7FF File Offset: 0x0010D9FF
		static UMaterialExpressionCameraVectorWS()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionCameraVectorWS");
		}

		// Token: 0x0600BDB7 RID: 48567 RVA: 0x0010F80D File Offset: 0x0010DA0D
		protected UMaterialExpressionCameraVectorWS(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400642D RID: 25645
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionCameraVectorWS";

		// Token: 0x0400642E RID: 25646
		private static IntPtr _ClassPtr;

		// Token: 0x0400642F RID: 25647
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
