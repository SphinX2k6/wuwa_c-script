using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E6A RID: 3690
	[UnrealObjectPath("/Script/Engine.MaterialExpressionTextureSampleParameterVolume")]
	[UnrealStructLayout(696, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 696)]
	public class UMaterialExpressionTextureSampleParameterVolume : UMaterialExpressionTextureSampleParameter, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C575 RID: 50549 RVA: 0x0011DE27 File Offset: 0x0011C027
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionTextureSampleParameterVolume._ClassPtr;
		}

		// Token: 0x0600C576 RID: 50550 RVA: 0x0011DE34 File Offset: 0x0011C034
		public UMaterialExpressionTextureSampleParameterVolume() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionTextureSampleParameterVolume.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C577 RID: 50551 RVA: 0x0011DE5C File Offset: 0x0011C05C
		[NullableContext(1)]
		public UMaterialExpressionTextureSampleParameterVolume(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionTextureSampleParameterVolume.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600C578 RID: 50552 RVA: 0x0011DE8F File Offset: 0x0011C08F
		static UMaterialExpressionTextureSampleParameterVolume()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionTextureSampleParameterVolume");
		}

		// Token: 0x0600C579 RID: 50553 RVA: 0x0011DE9D File Offset: 0x0011C09D
		protected UMaterialExpressionTextureSampleParameterVolume(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400699C RID: 27036
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionTextureSampleParameterVolume";

		// Token: 0x0400699D RID: 27037
		private static IntPtr _ClassPtr;

		// Token: 0x0400699E RID: 27038
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
