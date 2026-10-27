using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000D4B RID: 3403
	[UnrealObjectPath("/Script/Engine.LightMapTexture2D")]
	[UnrealStructLayout(4048, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 4048)]
	public class ULightMapTexture2D : UTexture2D, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600B7BF RID: 47039 RVA: 0x0010563A File Offset: 0x0010383A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULightMapTexture2D._ClassPtr;
		}

		// Token: 0x0600B7C0 RID: 47040 RVA: 0x00105648 File Offset: 0x00103848
		public ULightMapTexture2D() : this(BuiltinUtils.AllocNativeUObject(ULightMapTexture2D.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600B7C1 RID: 47041 RVA: 0x00105670 File Offset: 0x00103870
		[NullableContext(1)]
		public ULightMapTexture2D(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULightMapTexture2D.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600B7C2 RID: 47042 RVA: 0x001056A3 File Offset: 0x001038A3
		static ULightMapTexture2D()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.LightMapTexture2D");
		}

		// Token: 0x0600B7C3 RID: 47043 RVA: 0x001056B1 File Offset: 0x001038B1
		protected ULightMapTexture2D(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400603E RID: 24638
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.LightMapTexture2D";

		// Token: 0x0400603F RID: 24639
		private static IntPtr _ClassPtr;

		// Token: 0x04006040 RID: 24640
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
