using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000DE1 RID: 3553
	[UnrealObjectPath("/Script/Engine.MaterialExpressionKuroShadowDistance")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 192)]
	public class UMaterialExpressionKuroShadowDistance : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C05B RID: 49243 RVA: 0x00114595 File Offset: 0x00112795
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionKuroShadowDistance._ClassPtr;
		}

		// Token: 0x0600C05C RID: 49244 RVA: 0x001145A4 File Offset: 0x001127A4
		public UMaterialExpressionKuroShadowDistance() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionKuroShadowDistance.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C05D RID: 49245 RVA: 0x001145CC File Offset: 0x001127CC
		[NullableContext(1)]
		public UMaterialExpressionKuroShadowDistance(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionKuroShadowDistance.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600C05E RID: 49246 RVA: 0x001145FF File Offset: 0x001127FF
		static UMaterialExpressionKuroShadowDistance()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionKuroShadowDistance");
		}

		// Token: 0x0600C05F RID: 49247 RVA: 0x0011460D File Offset: 0x0011280D
		protected UMaterialExpressionKuroShadowDistance(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006604 RID: 26116
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionKuroShadowDistance";

		// Token: 0x04006605 RID: 26117
		private static IntPtr _ClassPtr;

		// Token: 0x04006606 RID: 26118
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
