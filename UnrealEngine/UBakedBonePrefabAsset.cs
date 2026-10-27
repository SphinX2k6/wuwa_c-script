using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000886 RID: 2182
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.BakedBonePrefabAsset")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 96)]
	public class UBakedBonePrefabAsset : UDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06007764 RID: 30564 RVA: 0x000AAF26 File Offset: 0x000A9126
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBakedBonePrefabAsset._ClassPtr;
		}

		// Token: 0x06007765 RID: 30565 RVA: 0x000AAF34 File Offset: 0x000A9134
		public UBakedBonePrefabAsset() : this(BuiltinUtils.AllocNativeUObject(UBakedBonePrefabAsset.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06007766 RID: 30566 RVA: 0x000AAF5C File Offset: 0x000A915C
		public UBakedBonePrefabAsset(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBakedBonePrefabAsset.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001C30 RID: 7216
		// (get) Token: 0x06007767 RID: 30567 RVA: 0x000AAF90 File Offset: 0x000A9190
		// (set) Token: 0x06007768 RID: 30568 RVA: 0x000AAFC9 File Offset: 0x000A91C9
		public TArray<FBakedBoneActorPrefab> PrefabActors
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FBakedBoneActorPrefab> result;
				if ((result = this._PrefabActors) == null)
				{
					result = (this._PrefabActors = new TArray<FBakedBoneActorPrefab>(base.NativePtr + (IntPtr)UBakedBonePrefabAsset.__PropertyOffset_PrefabActors, this));
				}
				return result;
			}
			set
			{
				this.PrefabActors.CopyAssign(value);
			}
		}

		// Token: 0x17001C31 RID: 7217
		// (get) Token: 0x06007769 RID: 30569 RVA: 0x000AAFD8 File Offset: 0x000A91D8
		// (set) Token: 0x0600776A RID: 30570 RVA: 0x000AB011 File Offset: 0x000A9211
		public TArray<FBakedBoneGroupPrefab> PrefabGroups
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FBakedBoneGroupPrefab> result;
				if ((result = this._PrefabGroups) == null)
				{
					result = (this._PrefabGroups = new TArray<FBakedBoneGroupPrefab>(base.NativePtr + (IntPtr)UBakedBonePrefabAsset.__PropertyOffset_PrefabGroups, this));
				}
				return result;
			}
			set
			{
				this.PrefabGroups.CopyAssign(value);
			}
		}

		// Token: 0x0600776B RID: 30571 RVA: 0x000AB01F File Offset: 0x000A921F
		static UBakedBonePrefabAsset()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.BakedBonePrefabAsset");
		}

		// Token: 0x0600776C RID: 30572 RVA: 0x000AB02D File Offset: 0x000A922D
		protected UBakedBonePrefabAsset(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003951 RID: 14673
		public new const string __ObjectPath = "/Script/Engine.BakedBonePrefabAsset";

		// Token: 0x04003952 RID: 14674
		private static IntPtr _ClassPtr;

		// Token: 0x04003953 RID: 14675
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003954 RID: 14676
		internal static int __PropertyOffset_PrefabActors;

		// Token: 0x04003955 RID: 14677
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FBakedBoneActorPrefab> _PrefabActors;

		// Token: 0x04003956 RID: 14678
		internal static int __PropertyOffset_PrefabGroups;

		// Token: 0x04003957 RID: 14679
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FBakedBoneGroupPrefab> _PrefabGroups;
	}
}
