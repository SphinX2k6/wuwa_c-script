using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000D36 RID: 3382
	[UnrealObjectPath("/Script/Engine.LevelScriptBlueprint")]
	[UnrealStructLayout(1256, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1256)]
	public class ULevelScriptBlueprint : UBlueprint, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600B509 RID: 46345 RVA: 0x00102385 File Offset: 0x00100585
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULevelScriptBlueprint._ClassPtr;
		}

		// Token: 0x0600B50A RID: 46346 RVA: 0x00102394 File Offset: 0x00100594
		public ULevelScriptBlueprint() : this(BuiltinUtils.AllocNativeUObject(ULevelScriptBlueprint.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600B50B RID: 46347 RVA: 0x001023BC File Offset: 0x001005BC
		[NullableContext(1)]
		public ULevelScriptBlueprint(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULevelScriptBlueprint.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600B50C RID: 46348 RVA: 0x001023EF File Offset: 0x001005EF
		static ULevelScriptBlueprint()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.LevelScriptBlueprint");
		}

		// Token: 0x0600B50D RID: 46349 RVA: 0x001023FD File Offset: 0x001005FD
		protected ULevelScriptBlueprint(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005F27 RID: 24359
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.LevelScriptBlueprint";

		// Token: 0x04005F28 RID: 24360
		private static IntPtr _ClassPtr;

		// Token: 0x04005F29 RID: 24361
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
