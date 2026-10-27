using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E49 RID: 3657
	[UnrealObjectPath("/Script/Engine.MaterialExpressionSkyAtmosphereViewLuminance")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 192)]
	public class UMaterialExpressionSkyAtmosphereViewLuminance : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C439 RID: 50233 RVA: 0x0011BAD5 File Offset: 0x00119CD5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionSkyAtmosphereViewLuminance._ClassPtr;
		}

		// Token: 0x0600C43A RID: 50234 RVA: 0x0011BAE4 File Offset: 0x00119CE4
		public UMaterialExpressionSkyAtmosphereViewLuminance() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionSkyAtmosphereViewLuminance.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C43B RID: 50235 RVA: 0x0011BB0C File Offset: 0x00119D0C
		[NullableContext(1)]
		public UMaterialExpressionSkyAtmosphereViewLuminance(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionSkyAtmosphereViewLuminance.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600C43C RID: 50236 RVA: 0x0011BB3F File Offset: 0x00119D3F
		static UMaterialExpressionSkyAtmosphereViewLuminance()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionSkyAtmosphereViewLuminance");
		}

		// Token: 0x0600C43D RID: 50237 RVA: 0x0011BB4D File Offset: 0x00119D4D
		protected UMaterialExpressionSkyAtmosphereViewLuminance(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040068C1 RID: 26817
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionSkyAtmosphereViewLuminance";

		// Token: 0x040068C2 RID: 26818
		private static IntPtr _ClassPtr;

		// Token: 0x040068C3 RID: 26819
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
