using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001F7F RID: 8063
	[UnrealObjectPath("/Script/Landscape.LandscapeLODStreamingProxy")]
	[UnrealStructLayout(2552, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2552)]
	public class ULandscapeLODStreamingProxy : UStreamableRenderAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601E96E RID: 125294 RVA: 0x002D758E File Offset: 0x002D578E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULandscapeLODStreamingProxy._ClassPtr;
		}

		// Token: 0x0601E96F RID: 125295 RVA: 0x002D759C File Offset: 0x002D579C
		public ULandscapeLODStreamingProxy() : this(BuiltinUtils.AllocNativeUObject(ULandscapeLODStreamingProxy.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601E970 RID: 125296 RVA: 0x002D75C4 File Offset: 0x002D57C4
		[NullableContext(1)]
		public ULandscapeLODStreamingProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULandscapeLODStreamingProxy.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601E971 RID: 125297 RVA: 0x002D75F7 File Offset: 0x002D57F7
		static ULandscapeLODStreamingProxy()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Landscape.LandscapeLODStreamingProxy");
		}

		// Token: 0x0601E972 RID: 125298 RVA: 0x002D7605 File Offset: 0x002D5805
		protected ULandscapeLODStreamingProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010879 RID: 67705
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Landscape.LandscapeLODStreamingProxy";

		// Token: 0x0401087A RID: 67706
		private static IntPtr _ClassPtr;

		// Token: 0x0401087B RID: 67707
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
