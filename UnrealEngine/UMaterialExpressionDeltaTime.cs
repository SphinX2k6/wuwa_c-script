using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000DB2 RID: 3506
	[UnrealObjectPath("/Script/Engine.MaterialExpressionDeltaTime")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 192)]
	public class UMaterialExpressionDeltaTime : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600BE9A RID: 48794 RVA: 0x00111047 File Offset: 0x0010F247
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionDeltaTime._ClassPtr;
		}

		// Token: 0x0600BE9B RID: 48795 RVA: 0x00111054 File Offset: 0x0010F254
		public UMaterialExpressionDeltaTime() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionDeltaTime.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600BE9C RID: 48796 RVA: 0x0011107C File Offset: 0x0010F27C
		[NullableContext(1)]
		public UMaterialExpressionDeltaTime(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionDeltaTime.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600BE9D RID: 48797 RVA: 0x001110AF File Offset: 0x0010F2AF
		static UMaterialExpressionDeltaTime()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionDeltaTime");
		}

		// Token: 0x0600BE9E RID: 48798 RVA: 0x001110BD File Offset: 0x0010F2BD
		protected UMaterialExpressionDeltaTime(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040064C6 RID: 25798
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionDeltaTime";

		// Token: 0x040064C7 RID: 25799
		private static IntPtr _ClassPtr;

		// Token: 0x040064C8 RID: 25800
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
