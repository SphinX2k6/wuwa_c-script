using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B98 RID: 7064
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroRainManager")]
	[UnrealStructLayout(240, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 240)]
	public class UKuroRainManager : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601AE58 RID: 110168 RVA: 0x0027A5E3 File Offset: 0x002787E3
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroRainManager._ClassPtr;
		}

		// Token: 0x0601AE59 RID: 110169 RVA: 0x0027A5F0 File Offset: 0x002787F0
		public UKuroRainManager() : this(BuiltinUtils.AllocNativeUObject(UKuroRainManager.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601AE5A RID: 110170 RVA: 0x0027A618 File Offset: 0x00278818
		[NullableContext(1)]
		public UKuroRainManager(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroRainManager.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601AE5B RID: 110171 RVA: 0x0027A64B File Offset: 0x0027884B
		static UKuroRainManager()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroRainManager");
		}

		// Token: 0x0601AE5C RID: 110172 RVA: 0x0027A659 File Offset: 0x00278859
		protected UKuroRainManager(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400E8CA RID: 59594
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroRainManager";

		// Token: 0x0400E8CB RID: 59595
		private static IntPtr _ClassPtr;

		// Token: 0x0400E8CC RID: 59596
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
