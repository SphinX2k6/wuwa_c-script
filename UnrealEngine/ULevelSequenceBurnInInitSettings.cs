using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001FB7 RID: 8119
	[UnrealObjectPath("/Script/LevelSequence.LevelSequenceBurnInInitSettings")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class ULevelSequenceBurnInInitSettings : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601ED1B RID: 126235 RVA: 0x002DCE23 File Offset: 0x002DB023
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULevelSequenceBurnInInitSettings._ClassPtr;
		}

		// Token: 0x0601ED1C RID: 126236 RVA: 0x002DCE30 File Offset: 0x002DB030
		public ULevelSequenceBurnInInitSettings() : this(BuiltinUtils.AllocNativeUObject(ULevelSequenceBurnInInitSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601ED1D RID: 126237 RVA: 0x002DCE58 File Offset: 0x002DB058
		[NullableContext(1)]
		public ULevelSequenceBurnInInitSettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULevelSequenceBurnInInitSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601ED1E RID: 126238 RVA: 0x002DCE8B File Offset: 0x002DB08B
		static ULevelSequenceBurnInInitSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LevelSequence.LevelSequenceBurnInInitSettings");
		}

		// Token: 0x0601ED1F RID: 126239 RVA: 0x002DCE99 File Offset: 0x002DB099
		protected ULevelSequenceBurnInInitSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010A81 RID: 68225
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LevelSequence.LevelSequenceBurnInInitSettings";

		// Token: 0x04010A82 RID: 68226
		private static IntPtr _ClassPtr;

		// Token: 0x04010A83 RID: 68227
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
