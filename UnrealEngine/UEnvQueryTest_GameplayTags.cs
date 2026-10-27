using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020001AD RID: 429
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AIModule.EnvQueryTest_GameplayTags")]
	[UnrealStructLayout(720, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 720)]
	public class UEnvQueryTest_GameplayTags : UEnvQueryTest, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001A4B RID: 6731 RVA: 0x0002707F File Offset: 0x0002527F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UEnvQueryTest_GameplayTags._ClassPtr;
		}

		// Token: 0x06001A4C RID: 6732 RVA: 0x0002708C File Offset: 0x0002528C
		public UEnvQueryTest_GameplayTags() : this(BuiltinUtils.AllocNativeUObject(UEnvQueryTest_GameplayTags.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001A4D RID: 6733 RVA: 0x000270B4 File Offset: 0x000252B4
		public UEnvQueryTest_GameplayTags(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UEnvQueryTest_GameplayTags.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170006C0 RID: 1728
		// (get) Token: 0x06001A4E RID: 6734 RVA: 0x000270E8 File Offset: 0x000252E8
		// (set) Token: 0x06001A4F RID: 6735 RVA: 0x00027121 File Offset: 0x00025321
		public FGameplayTagQuery TagQueryToMatch
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagQuery result;
				if ((result = this._TagQueryToMatch) == null)
				{
					result = (this._TagQueryToMatch = new FGameplayTagQuery(base.NativePtr + (IntPtr)UEnvQueryTest_GameplayTags.__PropertyOffset_TagQueryToMatch, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagQuery.StaticStruct(), base.NativePtr + (IntPtr)UEnvQueryTest_GameplayTags.__PropertyOffset_TagQueryToMatch, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170006C1 RID: 1729
		// (get) Token: 0x06001A50 RID: 6736 RVA: 0x00027142 File Offset: 0x00025342
		// (set) Token: 0x06001A51 RID: 6737 RVA: 0x00027152 File Offset: 0x00025352
		public unsafe bool bUpdatedToUseQuery
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEnvQueryTest_GameplayTags.__PropertyOffset_bUpdatedToUseQuery) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEnvQueryTest_GameplayTags.__PropertyOffset_bUpdatedToUseQuery) = (value ? 1 : 0);
			}
		}

		// Token: 0x170006C2 RID: 1730
		// (get) Token: 0x06001A52 RID: 6738 RVA: 0x00027163 File Offset: 0x00025363
		// (set) Token: 0x06001A53 RID: 6739 RVA: 0x00027173 File Offset: 0x00025373
		public unsafe EGameplayContainerMatchType TagsToMatch
		{
			get
			{
				return (EGameplayContainerMatchType)(*(base.NativePtr + (IntPtr)UEnvQueryTest_GameplayTags.__PropertyOffset_TagsToMatch));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEnvQueryTest_GameplayTags.__PropertyOffset_TagsToMatch) = (byte)value;
			}
		}

		// Token: 0x170006C3 RID: 1731
		// (get) Token: 0x06001A54 RID: 6740 RVA: 0x00027184 File Offset: 0x00025384
		// (set) Token: 0x06001A55 RID: 6741 RVA: 0x000271BD File Offset: 0x000253BD
		public FGameplayTagContainer GameplayTags
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._GameplayTags) == null)
				{
					result = (this._GameplayTags = new FGameplayTagContainer(base.NativePtr + (IntPtr)UEnvQueryTest_GameplayTags.__PropertyOffset_GameplayTags, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)UEnvQueryTest_GameplayTags.__PropertyOffset_GameplayTags, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06001A56 RID: 6742 RVA: 0x000271DE File Offset: 0x000253DE
		static UEnvQueryTest_GameplayTags()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.EnvQueryTest_GameplayTags");
		}

		// Token: 0x06001A57 RID: 6743 RVA: 0x000271EC File Offset: 0x000253EC
		protected UEnvQueryTest_GameplayTags(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040007E7 RID: 2023
		public new const string __ObjectPath = "/Script/AIModule.EnvQueryTest_GameplayTags";

		// Token: 0x040007E8 RID: 2024
		private static IntPtr _ClassPtr;

		// Token: 0x040007E9 RID: 2025
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040007EA RID: 2026
		internal static int __PropertyOffset_TagQueryToMatch;

		// Token: 0x040007EB RID: 2027
		[Nullable(2)]
		private FGameplayTagQuery _TagQueryToMatch;

		// Token: 0x040007EC RID: 2028
		internal static int __PropertyOffset_bUpdatedToUseQuery;

		// Token: 0x040007ED RID: 2029
		internal static int __PropertyOffset_TagsToMatch;

		// Token: 0x040007EE RID: 2030
		internal static int __PropertyOffset_GameplayTags;

		// Token: 0x040007EF RID: 2031
		[Nullable(2)]
		private FGameplayTagContainer _GameplayTags;
	}
}
