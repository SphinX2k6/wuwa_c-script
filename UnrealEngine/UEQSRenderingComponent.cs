using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020001C3 RID: 451
	[UnrealObjectPath("/Script/AIModule.EQSRenderingComponent")]
	[UnrealStructLayout(1728, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1728)]
	public class UEQSRenderingComponent : UPrimitiveComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001AE8 RID: 6888 RVA: 0x000281FB File Offset: 0x000263FB
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UEQSRenderingComponent._ClassPtr;
		}

		// Token: 0x06001AE9 RID: 6889 RVA: 0x00028208 File Offset: 0x00026408
		public UEQSRenderingComponent() : this(BuiltinUtils.AllocNativeUObject(UEQSRenderingComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001AEA RID: 6890 RVA: 0x00028230 File Offset: 0x00026430
		[NullableContext(1)]
		public UEQSRenderingComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UEQSRenderingComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06001AEB RID: 6891 RVA: 0x00028263 File Offset: 0x00026463
		static UEQSRenderingComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.EQSRenderingComponent");
		}

		// Token: 0x06001AEC RID: 6892 RVA: 0x00028271 File Offset: 0x00026471
		protected UEQSRenderingComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400087E RID: 2174
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.EQSRenderingComponent";

		// Token: 0x0400087F RID: 2175
		private static IntPtr _ClassPtr;

		// Token: 0x04000880 RID: 2176
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
