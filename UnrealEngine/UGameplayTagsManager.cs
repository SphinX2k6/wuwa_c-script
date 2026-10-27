using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020013E6 RID: 5094
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayTags.GameplayTagsManager")]
	[UnrealStructLayout(1208, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1208)]
	public class UGameplayTagsManager : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060129E7 RID: 76263 RVA: 0x001B65D6 File Offset: 0x001B47D6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGameplayTagsManager._ClassPtr;
		}

		// Token: 0x060129E8 RID: 76264 RVA: 0x001B65E4 File Offset: 0x001B47E4
		public UGameplayTagsManager() : this(BuiltinUtils.AllocNativeUObject(UGameplayTagsManager.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060129E9 RID: 76265 RVA: 0x001B660C File Offset: 0x001B480C
		public UGameplayTagsManager(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGameplayTagsManager.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004829 RID: 18473
		// (get) Token: 0x060129EA RID: 76266 RVA: 0x001B6640 File Offset: 0x001B4840
		// (set) Token: 0x060129EB RID: 76267 RVA: 0x001B6679 File Offset: 0x001B4879
		public TArray<FGameplayTagSource> TagSources
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FGameplayTagSource> result;
				if ((result = this._TagSources) == null)
				{
					result = (this._TagSources = new TArray<FGameplayTagSource>(base.NativePtr + (IntPtr)UGameplayTagsManager.__PropertyOffset_TagSources, this));
				}
				return result;
			}
			set
			{
				this.TagSources.CopyAssign(value);
			}
		}

		// Token: 0x1700482A RID: 18474
		// (get) Token: 0x060129EC RID: 76268 RVA: 0x001B6688 File Offset: 0x001B4888
		// (set) Token: 0x060129ED RID: 76269 RVA: 0x001B66C1 File Offset: 0x001B48C1
		public TArray<UDataTable> GameplayTagTables
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UDataTable> result;
				if ((result = this._GameplayTagTables) == null)
				{
					result = (this._GameplayTagTables = new TArray<UDataTable>(base.NativePtr + (IntPtr)UGameplayTagsManager.__PropertyOffset_GameplayTagTables, this));
				}
				return result;
			}
			set
			{
				this.GameplayTagTables.CopyAssign(value);
			}
		}

		// Token: 0x060129EE RID: 76270 RVA: 0x001B66CF File Offset: 0x001B48CF
		static UGameplayTagsManager()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GameplayTags.GameplayTagsManager");
		}

		// Token: 0x060129EF RID: 76271 RVA: 0x001B66DD File Offset: 0x001B48DD
		protected UGameplayTagsManager(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04009F28 RID: 40744
		public new const string __ObjectPath = "/Script/GameplayTags.GameplayTagsManager";

		// Token: 0x04009F29 RID: 40745
		private static IntPtr _ClassPtr;

		// Token: 0x04009F2A RID: 40746
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04009F2B RID: 40747
		internal static int __PropertyOffset_TagSources;

		// Token: 0x04009F2C RID: 40748
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FGameplayTagSource> _TagSources;

		// Token: 0x04009F2D RID: 40749
		internal static int __PropertyOffset_GameplayTagTables;

		// Token: 0x04009F2E RID: 40750
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UDataTable> _GameplayTagTables;
	}
}
