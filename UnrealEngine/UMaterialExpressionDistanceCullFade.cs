using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000DB8 RID: 3512
	[UnrealObjectPath("/Script/Engine.MaterialExpressionDistanceCullFade")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 192)]
	public class UMaterialExpressionDistanceCullFade : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600BED0 RID: 48848 RVA: 0x001116B5 File Offset: 0x0010F8B5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionDistanceCullFade._ClassPtr;
		}

		// Token: 0x0600BED1 RID: 48849 RVA: 0x001116C4 File Offset: 0x0010F8C4
		public UMaterialExpressionDistanceCullFade() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionDistanceCullFade.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600BED2 RID: 48850 RVA: 0x001116EC File Offset: 0x0010F8EC
		[NullableContext(1)]
		public UMaterialExpressionDistanceCullFade(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionDistanceCullFade.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600BED3 RID: 48851 RVA: 0x0011171F File Offset: 0x0010F91F
		static UMaterialExpressionDistanceCullFade()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionDistanceCullFade");
		}

		// Token: 0x0600BED4 RID: 48852 RVA: 0x0011172D File Offset: 0x0010F92D
		protected UMaterialExpressionDistanceCullFade(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040064EC RID: 25836
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionDistanceCullFade";

		// Token: 0x040064ED RID: 25837
		private static IntPtr _ClassPtr;

		// Token: 0x040064EE RID: 25838
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
