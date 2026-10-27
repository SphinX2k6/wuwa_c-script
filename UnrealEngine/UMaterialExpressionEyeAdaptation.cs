using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000DC2 RID: 3522
	[UnrealObjectPath("/Script/Engine.MaterialExpressionEyeAdaptation")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 192)]
	public class UMaterialExpressionEyeAdaptation : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600BF22 RID: 48930 RVA: 0x00112001 File Offset: 0x00110201
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionEyeAdaptation._ClassPtr;
		}

		// Token: 0x0600BF23 RID: 48931 RVA: 0x00112010 File Offset: 0x00110210
		public UMaterialExpressionEyeAdaptation() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionEyeAdaptation.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600BF24 RID: 48932 RVA: 0x00112038 File Offset: 0x00110238
		[NullableContext(1)]
		public UMaterialExpressionEyeAdaptation(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionEyeAdaptation.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600BF25 RID: 48933 RVA: 0x0011206B File Offset: 0x0011026B
		static UMaterialExpressionEyeAdaptation()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionEyeAdaptation");
		}

		// Token: 0x0600BF26 RID: 48934 RVA: 0x00112079 File Offset: 0x00110279
		protected UMaterialExpressionEyeAdaptation(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006524 RID: 25892
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionEyeAdaptation";

		// Token: 0x04006525 RID: 25893
		private static IntPtr _ClassPtr;

		// Token: 0x04006526 RID: 25894
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
