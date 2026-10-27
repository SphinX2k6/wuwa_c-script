using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000D4C RID: 3404
	[UnrealObjectPath("/Script/Engine.LightMapVirtualTexture")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class ULightMapVirtualTexture : UVirtualTexture, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600B7C4 RID: 47044 RVA: 0x001056BA File Offset: 0x001038BA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULightMapVirtualTexture._ClassPtr;
		}

		// Token: 0x0600B7C5 RID: 47045 RVA: 0x001056C8 File Offset: 0x001038C8
		public ULightMapVirtualTexture() : this(BuiltinUtils.AllocNativeUObject(ULightMapVirtualTexture.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600B7C6 RID: 47046 RVA: 0x001056F0 File Offset: 0x001038F0
		[NullableContext(1)]
		public ULightMapVirtualTexture(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULightMapVirtualTexture.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600B7C7 RID: 47047 RVA: 0x00105723 File Offset: 0x00103923
		static ULightMapVirtualTexture()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.LightMapVirtualTexture");
		}

		// Token: 0x0600B7C8 RID: 47048 RVA: 0x00105731 File Offset: 0x00103931
		protected ULightMapVirtualTexture(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006041 RID: 24641
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.LightMapVirtualTexture";

		// Token: 0x04006042 RID: 24642
		private static IntPtr _ClassPtr;

		// Token: 0x04006043 RID: 24643
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
