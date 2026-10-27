using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000D39 RID: 3385
	[UnrealObjectPath("/Script/Engine.LevelStreamingAlwaysLoaded")]
	[UnrealStructLayout(480, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 480)]
	public class ULevelStreamingAlwaysLoaded : ULevelStreaming, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600B586 RID: 46470 RVA: 0x00102E95 File Offset: 0x00101095
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULevelStreamingAlwaysLoaded._ClassPtr;
		}

		// Token: 0x0600B587 RID: 46471 RVA: 0x00102EA4 File Offset: 0x001010A4
		public ULevelStreamingAlwaysLoaded() : this(BuiltinUtils.AllocNativeUObject(ULevelStreamingAlwaysLoaded.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600B588 RID: 46472 RVA: 0x00102ECC File Offset: 0x001010CC
		[NullableContext(1)]
		public ULevelStreamingAlwaysLoaded(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULevelStreamingAlwaysLoaded.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600B589 RID: 46473 RVA: 0x00102EFF File Offset: 0x001010FF
		static ULevelStreamingAlwaysLoaded()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.LevelStreamingAlwaysLoaded");
		}

		// Token: 0x0600B58A RID: 46474 RVA: 0x00102F0D File Offset: 0x0010110D
		protected ULevelStreamingAlwaysLoaded(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005F67 RID: 24423
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.LevelStreamingAlwaysLoaded";

		// Token: 0x04005F68 RID: 24424
		private static IntPtr _ClassPtr;

		// Token: 0x04005F69 RID: 24425
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
