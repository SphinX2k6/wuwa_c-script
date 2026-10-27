using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000DDD RID: 3549
	[UnrealObjectPath("/Script/Engine.MaterialExpressionKuroLocalPosition")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 192)]
	public class UMaterialExpressionKuroLocalPosition : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C043 RID: 49219 RVA: 0x001142F2 File Offset: 0x001124F2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionKuroLocalPosition._ClassPtr;
		}

		// Token: 0x0600C044 RID: 49220 RVA: 0x00114300 File Offset: 0x00112500
		public UMaterialExpressionKuroLocalPosition() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionKuroLocalPosition.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C045 RID: 49221 RVA: 0x00114328 File Offset: 0x00112528
		[NullableContext(1)]
		public UMaterialExpressionKuroLocalPosition(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionKuroLocalPosition.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600C046 RID: 49222 RVA: 0x0011435B File Offset: 0x0011255B
		static UMaterialExpressionKuroLocalPosition()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionKuroLocalPosition");
		}

		// Token: 0x0600C047 RID: 49223 RVA: 0x00114369 File Offset: 0x00112569
		protected UMaterialExpressionKuroLocalPosition(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040065F4 RID: 26100
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionKuroLocalPosition";

		// Token: 0x040065F5 RID: 26101
		private static IntPtr _ClassPtr;

		// Token: 0x040065F6 RID: 26102
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
