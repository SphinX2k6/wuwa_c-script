using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001373 RID: 4979
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayAbilities.GameplayCueSet")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 160)]
	public class UGameplayCueSet : UDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06012470 RID: 74864 RVA: 0x001AD491 File Offset: 0x001AB691
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGameplayCueSet._ClassPtr;
		}

		// Token: 0x06012471 RID: 74865 RVA: 0x001AD4A0 File Offset: 0x001AB6A0
		public UGameplayCueSet() : this(BuiltinUtils.AllocNativeUObject(UGameplayCueSet.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06012472 RID: 74866 RVA: 0x001AD4C8 File Offset: 0x001AB6C8
		public UGameplayCueSet(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGameplayCueSet.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004734 RID: 18228
		// (get) Token: 0x06012473 RID: 74867 RVA: 0x001AD4FC File Offset: 0x001AB6FC
		// (set) Token: 0x06012474 RID: 74868 RVA: 0x001AD535 File Offset: 0x001AB735
		public TArray<FGameplayCueNotifyData> GameplayCueData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FGameplayCueNotifyData> result;
				if ((result = this._GameplayCueData) == null)
				{
					result = (this._GameplayCueData = new TArray<FGameplayCueNotifyData>(base.NativePtr + (IntPtr)UGameplayCueSet.__PropertyOffset_GameplayCueData, this));
				}
				return result;
			}
			set
			{
				this.GameplayCueData.CopyAssign(value);
			}
		}

		// Token: 0x06012475 RID: 74869 RVA: 0x001AD543 File Offset: 0x001AB743
		static UGameplayCueSet()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GameplayAbilities.GameplayCueSet");
		}

		// Token: 0x06012476 RID: 74870 RVA: 0x001AD551 File Offset: 0x001AB751
		protected UGameplayCueSet(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04009C87 RID: 40071
		public new const string __ObjectPath = "/Script/GameplayAbilities.GameplayCueSet";

		// Token: 0x04009C88 RID: 40072
		private static IntPtr _ClassPtr;

		// Token: 0x04009C89 RID: 40073
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04009C8A RID: 40074
		internal static int __PropertyOffset_GameplayCueData;

		// Token: 0x04009C8B RID: 40075
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FGameplayCueNotifyData> _GameplayCueData;
	}
}
