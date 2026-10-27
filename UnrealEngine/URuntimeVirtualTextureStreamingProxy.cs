using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020010C8 RID: 4296
	[UnrealObjectPath("/Script/Engine.RuntimeVirtualTextureStreamingProxy")]
	[UnrealStructLayout(4032, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 4032)]
	public class URuntimeVirtualTextureStreamingProxy : UTexture2D, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600F54E RID: 62798 RVA: 0x0016B937 File Offset: 0x00169B37
		public new static UClassStackOnlyPtr StaticClass()
		{
			return URuntimeVirtualTextureStreamingProxy._ClassPtr;
		}

		// Token: 0x0600F54F RID: 62799 RVA: 0x0016B944 File Offset: 0x00169B44
		public URuntimeVirtualTextureStreamingProxy() : this(BuiltinUtils.AllocNativeUObject(URuntimeVirtualTextureStreamingProxy.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600F550 RID: 62800 RVA: 0x0016B96C File Offset: 0x00169B6C
		[NullableContext(1)]
		public URuntimeVirtualTextureStreamingProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(URuntimeVirtualTextureStreamingProxy.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600F551 RID: 62801 RVA: 0x0016B99F File Offset: 0x00169B9F
		static URuntimeVirtualTextureStreamingProxy()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.RuntimeVirtualTextureStreamingProxy");
		}

		// Token: 0x0600F552 RID: 62802 RVA: 0x0016B9AD File Offset: 0x00169BAD
		protected URuntimeVirtualTextureStreamingProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040084E8 RID: 34024
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.RuntimeVirtualTextureStreamingProxy";

		// Token: 0x040084E9 RID: 34025
		private static IntPtr _ClassPtr;

		// Token: 0x040084EA RID: 34026
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
