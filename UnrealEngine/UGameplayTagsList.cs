using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020013E5 RID: 5093
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayTags.GameplayTagsList")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UGameplayTagsList : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060129DE RID: 76254 RVA: 0x001B64E8 File Offset: 0x001B46E8
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGameplayTagsList._ClassPtr;
		}

		// Token: 0x060129DF RID: 76255 RVA: 0x001B64F4 File Offset: 0x001B46F4
		public UGameplayTagsList() : this(BuiltinUtils.AllocNativeUObject(UGameplayTagsList.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060129E0 RID: 76256 RVA: 0x001B651C File Offset: 0x001B471C
		public UGameplayTagsList(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGameplayTagsList.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004827 RID: 18471
		// (get) Token: 0x060129E1 RID: 76257 RVA: 0x001B654F File Offset: 0x001B474F
		// (set) Token: 0x060129E2 RID: 76258 RVA: 0x001B6563 File Offset: 0x001B4763
		public unsafe string ConfigFileName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UGameplayTagsList.__PropertyOffset_ConfigFileName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UGameplayTagsList.__PropertyOffset_ConfigFileName)), value);
			}
		}

		// Token: 0x17004828 RID: 18472
		// (get) Token: 0x060129E3 RID: 76259 RVA: 0x001B6578 File Offset: 0x001B4778
		// (set) Token: 0x060129E4 RID: 76260 RVA: 0x001B65B1 File Offset: 0x001B47B1
		public TArray<FGameplayTagTableRow> GameplayTagList
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FGameplayTagTableRow> result;
				if ((result = this._GameplayTagList) == null)
				{
					result = (this._GameplayTagList = new TArray<FGameplayTagTableRow>(base.NativePtr + (IntPtr)UGameplayTagsList.__PropertyOffset_GameplayTagList, this));
				}
				return result;
			}
			set
			{
				this.GameplayTagList.CopyAssign(value);
			}
		}

		// Token: 0x060129E5 RID: 76261 RVA: 0x001B65BF File Offset: 0x001B47BF
		static UGameplayTagsList()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GameplayTags.GameplayTagsList");
		}

		// Token: 0x060129E6 RID: 76262 RVA: 0x001B65CD File Offset: 0x001B47CD
		protected UGameplayTagsList(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04009F22 RID: 40738
		public new const string __ObjectPath = "/Script/GameplayTags.GameplayTagsList";

		// Token: 0x04009F23 RID: 40739
		private static IntPtr _ClassPtr;

		// Token: 0x04009F24 RID: 40740
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04009F25 RID: 40741
		internal static int __PropertyOffset_ConfigFileName;

		// Token: 0x04009F26 RID: 40742
		internal static int __PropertyOffset_GameplayTagList;

		// Token: 0x04009F27 RID: 40743
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FGameplayTagTableRow> _GameplayTagList;
	}
}
