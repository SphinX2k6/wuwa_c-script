using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000D31 RID: 3377
	[UnrealObjectPath("/Script/Engine.LevelInstanceSettings")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public class ULevelInstanceSettings : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600B4E1 RID: 46305 RVA: 0x00102092 File Offset: 0x00100292
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULevelInstanceSettings._ClassPtr;
		}

		// Token: 0x0600B4E2 RID: 46306 RVA: 0x001020A0 File Offset: 0x001002A0
		public ULevelInstanceSettings() : this(BuiltinUtils.AllocNativeUObject(ULevelInstanceSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600B4E3 RID: 46307 RVA: 0x001020C8 File Offset: 0x001002C8
		[NullableContext(1)]
		public ULevelInstanceSettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULevelInstanceSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600B4E4 RID: 46308 RVA: 0x001020FB File Offset: 0x001002FB
		static ULevelInstanceSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.LevelInstanceSettings");
		}

		// Token: 0x0600B4E5 RID: 46309 RVA: 0x00102109 File Offset: 0x00100309
		protected ULevelInstanceSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005F17 RID: 24343
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.LevelInstanceSettings";

		// Token: 0x04005F18 RID: 24344
		private static IntPtr _ClassPtr;

		// Token: 0x04005F19 RID: 24345
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
