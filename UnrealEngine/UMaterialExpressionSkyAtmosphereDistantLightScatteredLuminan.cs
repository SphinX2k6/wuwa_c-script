using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E45 RID: 3653
	[UnrealObjectPath("/Script/Engine.MaterialExpressionSkyAtmosphereDistantLightScatteredLuminance")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 192)]
	public class UMaterialExpressionSkyAtmosphereDistantLightScatteredLuminance : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C41D RID: 50205 RVA: 0x0011B819 File Offset: 0x00119A19
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionSkyAtmosphereDistantLightScatteredLuminance._ClassPtr;
		}

		// Token: 0x0600C41E RID: 50206 RVA: 0x0011B828 File Offset: 0x00119A28
		public UMaterialExpressionSkyAtmosphereDistantLightScatteredLuminance() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionSkyAtmosphereDistantLightScatteredLuminance.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C41F RID: 50207 RVA: 0x0011B850 File Offset: 0x00119A50
		[NullableContext(1)]
		public UMaterialExpressionSkyAtmosphereDistantLightScatteredLuminance(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionSkyAtmosphereDistantLightScatteredLuminance.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600C420 RID: 50208 RVA: 0x0011B883 File Offset: 0x00119A83
		static UMaterialExpressionSkyAtmosphereDistantLightScatteredLuminance()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionSkyAtmosphereDistantLightScatteredLuminance");
		}

		// Token: 0x0600C421 RID: 50209 RVA: 0x0011B891 File Offset: 0x00119A91
		protected UMaterialExpressionSkyAtmosphereDistantLightScatteredLuminance(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040068B0 RID: 26800
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionSkyAtmosphereDistantLightScatteredLuminance";

		// Token: 0x040068B1 RID: 26801
		private static IntPtr _ClassPtr;

		// Token: 0x040068B2 RID: 26802
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
