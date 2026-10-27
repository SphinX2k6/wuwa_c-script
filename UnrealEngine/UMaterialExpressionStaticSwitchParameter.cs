using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E59 RID: 3673
	[UnrealObjectPath("/Script/Engine.MaterialExpressionStaticSwitchParameter")]
	[UnrealStructLayout(376, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 376)]
	public class UMaterialExpressionStaticSwitchParameter : UMaterialExpressionStaticBoolParameter, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C4EA RID: 50410 RVA: 0x0011CF81 File Offset: 0x0011B181
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionStaticSwitchParameter._ClassPtr;
		}

		// Token: 0x0600C4EB RID: 50411 RVA: 0x0011CF90 File Offset: 0x0011B190
		public UMaterialExpressionStaticSwitchParameter() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionStaticSwitchParameter.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C4EC RID: 50412 RVA: 0x0011CFB8 File Offset: 0x0011B1B8
		[NullableContext(1)]
		public UMaterialExpressionStaticSwitchParameter(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionStaticSwitchParameter.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600C4ED RID: 50413 RVA: 0x0011CFEB File Offset: 0x0011B1EB
		static UMaterialExpressionStaticSwitchParameter()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionStaticSwitchParameter");
		}

		// Token: 0x0600C4EE RID: 50414 RVA: 0x0011CFF9 File Offset: 0x0011B1F9
		protected UMaterialExpressionStaticSwitchParameter(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006940 RID: 26944
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionStaticSwitchParameter";

		// Token: 0x04006941 RID: 26945
		private static IntPtr _ClassPtr;

		// Token: 0x04006942 RID: 26946
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
