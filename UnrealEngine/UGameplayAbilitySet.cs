using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001352 RID: 4946
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayAbilities.GameplayAbilitySet")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UGameplayAbilitySet : UDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06012258 RID: 74328 RVA: 0x001AA3B8 File Offset: 0x001A85B8
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGameplayAbilitySet._ClassPtr;
		}

		// Token: 0x06012259 RID: 74329 RVA: 0x001AA3C4 File Offset: 0x001A85C4
		public UGameplayAbilitySet() : this(BuiltinUtils.AllocNativeUObject(UGameplayAbilitySet.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601225A RID: 74330 RVA: 0x001AA3EC File Offset: 0x001A85EC
		public UGameplayAbilitySet(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGameplayAbilitySet.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170046AD RID: 18093
		// (get) Token: 0x0601225B RID: 74331 RVA: 0x001AA420 File Offset: 0x001A8620
		// (set) Token: 0x0601225C RID: 74332 RVA: 0x001AA459 File Offset: 0x001A8659
		public TArray<FGameplayAbilityBindInfo> Abilities
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FGameplayAbilityBindInfo> result;
				if ((result = this._Abilities) == null)
				{
					result = (this._Abilities = new TArray<FGameplayAbilityBindInfo>(base.NativePtr + (IntPtr)UGameplayAbilitySet.__PropertyOffset_Abilities, this));
				}
				return result;
			}
			set
			{
				this.Abilities.CopyAssign(value);
			}
		}

		// Token: 0x0601225D RID: 74333 RVA: 0x001AA467 File Offset: 0x001A8667
		static UGameplayAbilitySet()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GameplayAbilities.GameplayAbilitySet");
		}

		// Token: 0x0601225E RID: 74334 RVA: 0x001AA475 File Offset: 0x001A8675
		protected UGameplayAbilitySet(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04009B86 RID: 39814
		public new const string __ObjectPath = "/Script/GameplayAbilities.GameplayAbilitySet";

		// Token: 0x04009B87 RID: 39815
		private static IntPtr _ClassPtr;

		// Token: 0x04009B88 RID: 39816
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04009B89 RID: 39817
		internal static int __PropertyOffset_Abilities;

		// Token: 0x04009B8A RID: 39818
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FGameplayAbilityBindInfo> _Abilities;
	}
}
