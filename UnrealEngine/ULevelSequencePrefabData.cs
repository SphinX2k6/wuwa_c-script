using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200201A RID: 8218
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.LevelSequencePrefabData")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class ULevelSequencePrefabData : UAssetUserData, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601EF7C RID: 126844 RVA: 0x002E0D77 File Offset: 0x002DEF77
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULevelSequencePrefabData._ClassPtr;
		}

		// Token: 0x0601EF7D RID: 126845 RVA: 0x002E0D84 File Offset: 0x002DEF84
		public ULevelSequencePrefabData() : this(BuiltinUtils.AllocNativeUObject(ULevelSequencePrefabData.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601EF7E RID: 126846 RVA: 0x002E0DAC File Offset: 0x002DEFAC
		public ULevelSequencePrefabData(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULevelSequencePrefabData.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007B46 RID: 31558
		// (get) Token: 0x0601EF7F RID: 126847 RVA: 0x002E0DE0 File Offset: 0x002DEFE0
		// (set) Token: 0x0601EF80 RID: 126848 RVA: 0x002E0E19 File Offset: 0x002DF019
		public TArray<FGuid> SourcePrefabGuids
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FGuid> result;
				if ((result = this._SourcePrefabGuids) == null)
				{
					result = (this._SourcePrefabGuids = new TArray<FGuid>(base.NativePtr + (IntPtr)ULevelSequencePrefabData.__PropertyOffset_SourcePrefabGuids, this));
				}
				return result;
			}
			set
			{
				this.SourcePrefabGuids.CopyAssign(value);
			}
		}

		// Token: 0x0601EF81 RID: 126849 RVA: 0x002E0E27 File Offset: 0x002DF027
		static ULevelSequencePrefabData()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.LevelSequencePrefabData");
		}

		// Token: 0x0601EF82 RID: 126850 RVA: 0x002E0E35 File Offset: 0x002DF035
		protected ULevelSequencePrefabData(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010D5D RID: 68957
		public new const string __ObjectPath = "/Script/LGUI.LevelSequencePrefabData";

		// Token: 0x04010D5E RID: 68958
		private static IntPtr _ClassPtr;

		// Token: 0x04010D5F RID: 68959
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010D60 RID: 68960
		internal static int __PropertyOffset_SourcePrefabGuids;

		// Token: 0x04010D61 RID: 68961
		[Nullable(2)]
		private TArray<FGuid> _SourcePrefabGuids;
	}
}
