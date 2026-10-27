using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200139D RID: 5021
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayAbilities.GameplayTagReponseTable")]
	[UnrealStructLayout(544, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 544)]
	public class UGameplayTagReponseTable : UDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06012704 RID: 75524 RVA: 0x001B1B17 File Offset: 0x001AFD17
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGameplayTagReponseTable._ClassPtr;
		}

		// Token: 0x06012705 RID: 75525 RVA: 0x001B1B24 File Offset: 0x001AFD24
		public UGameplayTagReponseTable() : this(BuiltinUtils.AllocNativeUObject(UGameplayTagReponseTable.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06012706 RID: 75526 RVA: 0x001B1B4C File Offset: 0x001AFD4C
		public UGameplayTagReponseTable(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGameplayTagReponseTable.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170047E4 RID: 18404
		// (get) Token: 0x06012707 RID: 75527 RVA: 0x001B1B80 File Offset: 0x001AFD80
		// (set) Token: 0x06012708 RID: 75528 RVA: 0x001B1BB9 File Offset: 0x001AFDB9
		public TArray<FGameplayTagResponseTableEntry> Entries
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FGameplayTagResponseTableEntry> result;
				if ((result = this._Entries) == null)
				{
					result = (this._Entries = new TArray<FGameplayTagResponseTableEntry>(base.NativePtr + (IntPtr)UGameplayTagReponseTable.__PropertyOffset_Entries, this));
				}
				return result;
			}
			set
			{
				this.Entries.CopyAssign(value);
			}
		}

		// Token: 0x06012709 RID: 75529 RVA: 0x001B1BC7 File Offset: 0x001AFDC7
		[NullableContext(2)]
		public void TagResponseEvent(FGameplayTag Tag, int NewCount, UAbilitySystemComponent ASC, int idx)
		{
			UGameplayTagReponseTable.__TagResponseEvent_Internal(base.NativePtr, Tag, NewCount, (ASC != null) ? ASC.NativePtr : IntPtr.Zero, idx);
		}

		// Token: 0x0601270A RID: 75530
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __TagResponseEvent_Internal(IntPtr @this, FGameplayTag Tag, int NewCount, IntPtr ASC, int idx);

		// Token: 0x0601270B RID: 75531 RVA: 0x001B1BE8 File Offset: 0x001AFDE8
		static UGameplayTagReponseTable()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GameplayAbilities.GameplayTagReponseTable");
		}

		// Token: 0x0601270C RID: 75532 RVA: 0x001B1BF6 File Offset: 0x001AFDF6
		protected UGameplayTagReponseTable(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04009DFA RID: 40442
		public new const string __ObjectPath = "/Script/GameplayAbilities.GameplayTagReponseTable";

		// Token: 0x04009DFB RID: 40443
		private static IntPtr _ClassPtr;

		// Token: 0x04009DFC RID: 40444
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04009DFD RID: 40445
		internal static int __PropertyOffset_Entries;

		// Token: 0x04009DFE RID: 40446
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FGameplayTagResponseTableEntry> _Entries;
	}
}
