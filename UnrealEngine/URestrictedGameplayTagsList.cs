using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020013EB RID: 5099
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayTags.RestrictedGameplayTagsList")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class URestrictedGameplayTagsList : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06012A33 RID: 76339 RVA: 0x001B6C77 File Offset: 0x001B4E77
		public new static UClassStackOnlyPtr StaticClass()
		{
			return URestrictedGameplayTagsList._ClassPtr;
		}

		// Token: 0x06012A34 RID: 76340 RVA: 0x001B6C84 File Offset: 0x001B4E84
		public URestrictedGameplayTagsList() : this(BuiltinUtils.AllocNativeUObject(URestrictedGameplayTagsList.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06012A35 RID: 76341 RVA: 0x001B6CAC File Offset: 0x001B4EAC
		public URestrictedGameplayTagsList(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(URestrictedGameplayTagsList.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700483E RID: 18494
		// (get) Token: 0x06012A36 RID: 76342 RVA: 0x001B6CDF File Offset: 0x001B4EDF
		// (set) Token: 0x06012A37 RID: 76343 RVA: 0x001B6CF3 File Offset: 0x001B4EF3
		public unsafe string ConfigFileName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)URestrictedGameplayTagsList.__PropertyOffset_ConfigFileName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)URestrictedGameplayTagsList.__PropertyOffset_ConfigFileName)), value);
			}
		}

		// Token: 0x1700483F RID: 18495
		// (get) Token: 0x06012A38 RID: 76344 RVA: 0x001B6D08 File Offset: 0x001B4F08
		// (set) Token: 0x06012A39 RID: 76345 RVA: 0x001B6D41 File Offset: 0x001B4F41
		public TArray<FRestrictedGameplayTagTableRow> RestrictedGameplayTagList
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FRestrictedGameplayTagTableRow> result;
				if ((result = this._RestrictedGameplayTagList) == null)
				{
					result = (this._RestrictedGameplayTagList = new TArray<FRestrictedGameplayTagTableRow>(base.NativePtr + (IntPtr)URestrictedGameplayTagsList.__PropertyOffset_RestrictedGameplayTagList, this));
				}
				return result;
			}
			set
			{
				this.RestrictedGameplayTagList.CopyAssign(value);
			}
		}

		// Token: 0x06012A3A RID: 76346 RVA: 0x001B6D4F File Offset: 0x001B4F4F
		static URestrictedGameplayTagsList()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GameplayTags.RestrictedGameplayTagsList");
		}

		// Token: 0x06012A3B RID: 76347 RVA: 0x001B6D5D File Offset: 0x001B4F5D
		protected URestrictedGameplayTagsList(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04009F51 RID: 40785
		public new const string __ObjectPath = "/Script/GameplayTags.RestrictedGameplayTagsList";

		// Token: 0x04009F52 RID: 40786
		private static IntPtr _ClassPtr;

		// Token: 0x04009F53 RID: 40787
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04009F54 RID: 40788
		internal static int __PropertyOffset_ConfigFileName;

		// Token: 0x04009F55 RID: 40789
		internal static int __PropertyOffset_RestrictedGameplayTagList;

		// Token: 0x04009F56 RID: 40790
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FRestrictedGameplayTagTableRow> _RestrictedGameplayTagList;
	}
}
