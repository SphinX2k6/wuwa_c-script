using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000D9D RID: 3485
	[UnrealObjectPath("/Script/Engine.MaterialExpressionCloudSampleAttribute")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 192)]
	public class UMaterialExpressionCloudSampleAttribute : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600BDDE RID: 48606 RVA: 0x0010FC71 File Offset: 0x0010DE71
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionCloudSampleAttribute._ClassPtr;
		}

		// Token: 0x0600BDDF RID: 48607 RVA: 0x0010FC80 File Offset: 0x0010DE80
		public UMaterialExpressionCloudSampleAttribute() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionCloudSampleAttribute.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600BDE0 RID: 48608 RVA: 0x0010FCA8 File Offset: 0x0010DEA8
		[NullableContext(1)]
		public UMaterialExpressionCloudSampleAttribute(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionCloudSampleAttribute.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600BDE1 RID: 48609 RVA: 0x0010FCDB File Offset: 0x0010DEDB
		static UMaterialExpressionCloudSampleAttribute()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionCloudSampleAttribute");
		}

		// Token: 0x0600BDE2 RID: 48610 RVA: 0x0010FCE9 File Offset: 0x0010DEE9
		protected UMaterialExpressionCloudSampleAttribute(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400644A RID: 25674
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionCloudSampleAttribute";

		// Token: 0x0400644B RID: 25675
		private static IntPtr _ClassPtr;

		// Token: 0x0400644C RID: 25676
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
