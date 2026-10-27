using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001FAE RID: 8110
	[UnrealObjectPath("/Script/LevelSequence.LegacyLevelSequenceDirectorBlueprint")]
	[UnrealStructLayout(1240, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1240)]
	public class ULegacyLevelSequenceDirectorBlueprint : UBlueprint, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601EC4D RID: 126029 RVA: 0x002DBD90 File Offset: 0x002D9F90
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULegacyLevelSequenceDirectorBlueprint._ClassPtr;
		}

		// Token: 0x0601EC4E RID: 126030 RVA: 0x002DBD9C File Offset: 0x002D9F9C
		public ULegacyLevelSequenceDirectorBlueprint() : this(BuiltinUtils.AllocNativeUObject(ULegacyLevelSequenceDirectorBlueprint.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601EC4F RID: 126031 RVA: 0x002DBDC4 File Offset: 0x002D9FC4
		[NullableContext(1)]
		public ULegacyLevelSequenceDirectorBlueprint(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULegacyLevelSequenceDirectorBlueprint.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601EC50 RID: 126032 RVA: 0x002DBDF7 File Offset: 0x002D9FF7
		static ULegacyLevelSequenceDirectorBlueprint()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LevelSequence.LegacyLevelSequenceDirectorBlueprint");
		}

		// Token: 0x0601EC51 RID: 126033 RVA: 0x002DBE05 File Offset: 0x002DA005
		protected ULegacyLevelSequenceDirectorBlueprint(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010A2E RID: 68142
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LevelSequence.LegacyLevelSequenceDirectorBlueprint";

		// Token: 0x04010A2F RID: 68143
		private static IntPtr _ClassPtr;

		// Token: 0x04010A30 RID: 68144
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
