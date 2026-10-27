using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020009C1 RID: 2497
	[UnrealObjectPath("/Script/Engine.DirectionalLight")]
	[UnrealStructLayout(1072, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1072)]
	public class ADirectionalLight : ALight, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06008CF7 RID: 36087 RVA: 0x000C9C12 File Offset: 0x000C7E12
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ADirectionalLight._ClassPtr;
		}

		// Token: 0x06008CF8 RID: 36088 RVA: 0x000C9C20 File Offset: 0x000C7E20
		public ADirectionalLight() : this(BuiltinUtils.AllocNativeUObject(ADirectionalLight.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06008CF9 RID: 36089 RVA: 0x000C9C48 File Offset: 0x000C7E48
		[NullableContext(1)]
		public ADirectionalLight(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ADirectionalLight.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06008CFA RID: 36090 RVA: 0x000C9C7B File Offset: 0x000C7E7B
		static ADirectionalLight()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.DirectionalLight");
		}

		// Token: 0x06008CFB RID: 36091 RVA: 0x000C9C89 File Offset: 0x000C7E89
		protected ADirectionalLight(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040042F3 RID: 17139
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.DirectionalLight";

		// Token: 0x040042F4 RID: 17140
		private static IntPtr _ClassPtr;

		// Token: 0x040042F5 RID: 17141
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
