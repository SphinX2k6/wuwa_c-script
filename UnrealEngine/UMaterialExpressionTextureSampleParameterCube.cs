using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E68 RID: 3688
	[UnrealObjectPath("/Script/Engine.MaterialExpressionTextureSampleParameterCube")]
	[UnrealStructLayout(696, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 696)]
	public class UMaterialExpressionTextureSampleParameterCube : UMaterialExpressionTextureSampleParameter, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C569 RID: 50537 RVA: 0x0011DCDE File Offset: 0x0011BEDE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionTextureSampleParameterCube._ClassPtr;
		}

		// Token: 0x0600C56A RID: 50538 RVA: 0x0011DCEC File Offset: 0x0011BEEC
		public UMaterialExpressionTextureSampleParameterCube() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionTextureSampleParameterCube.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C56B RID: 50539 RVA: 0x0011DD14 File Offset: 0x0011BF14
		[NullableContext(1)]
		public UMaterialExpressionTextureSampleParameterCube(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionTextureSampleParameterCube.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600C56C RID: 50540 RVA: 0x0011DD47 File Offset: 0x0011BF47
		static UMaterialExpressionTextureSampleParameterCube()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionTextureSampleParameterCube");
		}

		// Token: 0x0600C56D RID: 50541 RVA: 0x0011DD55 File Offset: 0x0011BF55
		protected UMaterialExpressionTextureSampleParameterCube(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006994 RID: 27028
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionTextureSampleParameterCube";

		// Token: 0x04006995 RID: 27029
		private static IntPtr _ClassPtr;

		// Token: 0x04006996 RID: 27030
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
