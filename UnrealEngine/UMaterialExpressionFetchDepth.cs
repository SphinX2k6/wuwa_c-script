using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000DC4 RID: 3524
	[UnrealObjectPath("/Script/Engine.MaterialExpressionFetchDepth")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 192)]
	public class UMaterialExpressionFetchDepth : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600BF2E RID: 48942 RVA: 0x0011215D File Offset: 0x0011035D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionFetchDepth._ClassPtr;
		}

		// Token: 0x0600BF2F RID: 48943 RVA: 0x0011216C File Offset: 0x0011036C
		public UMaterialExpressionFetchDepth() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionFetchDepth.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600BF30 RID: 48944 RVA: 0x00112194 File Offset: 0x00110394
		[NullableContext(1)]
		public UMaterialExpressionFetchDepth(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionFetchDepth.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600BF31 RID: 48945 RVA: 0x001121C7 File Offset: 0x001103C7
		static UMaterialExpressionFetchDepth()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionFetchDepth");
		}

		// Token: 0x0600BF32 RID: 48946 RVA: 0x001121D5 File Offset: 0x001103D5
		protected UMaterialExpressionFetchDepth(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400652C RID: 25900
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionFetchDepth";

		// Token: 0x0400652D RID: 25901
		private static IntPtr _ClassPtr;

		// Token: 0x0400652E RID: 25902
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
