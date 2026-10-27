using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020013E4 RID: 5092
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayTags.GameplayTagsDeveloperSettings")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 128)]
	public class UGameplayTagsDeveloperSettings : UDeveloperSettings, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060129D5 RID: 76245 RVA: 0x001B6418 File Offset: 0x001B4618
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGameplayTagsDeveloperSettings._ClassPtr;
		}

		// Token: 0x060129D6 RID: 76246 RVA: 0x001B6424 File Offset: 0x001B4624
		public UGameplayTagsDeveloperSettings() : this(BuiltinUtils.AllocNativeUObject(UGameplayTagsDeveloperSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060129D7 RID: 76247 RVA: 0x001B644C File Offset: 0x001B464C
		public UGameplayTagsDeveloperSettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGameplayTagsDeveloperSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004825 RID: 18469
		// (get) Token: 0x060129D8 RID: 76248 RVA: 0x001B647F File Offset: 0x001B467F
		// (set) Token: 0x060129D9 RID: 76249 RVA: 0x001B6493 File Offset: 0x001B4693
		public unsafe string DeveloperConfigName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UGameplayTagsDeveloperSettings.__PropertyOffset_DeveloperConfigName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UGameplayTagsDeveloperSettings.__PropertyOffset_DeveloperConfigName)), value);
			}
		}

		// Token: 0x17004826 RID: 18470
		// (get) Token: 0x060129DA RID: 76250 RVA: 0x001B64A8 File Offset: 0x001B46A8
		// (set) Token: 0x060129DB RID: 76251 RVA: 0x001B64BC File Offset: 0x001B46BC
		public unsafe FName FavoriteTagSource
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGameplayTagsDeveloperSettings.__PropertyOffset_FavoriteTagSource);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGameplayTagsDeveloperSettings.__PropertyOffset_FavoriteTagSource) = value;
			}
		}

		// Token: 0x060129DC RID: 76252 RVA: 0x001B64D1 File Offset: 0x001B46D1
		static UGameplayTagsDeveloperSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GameplayTags.GameplayTagsDeveloperSettings");
		}

		// Token: 0x060129DD RID: 76253 RVA: 0x001B64DF File Offset: 0x001B46DF
		protected UGameplayTagsDeveloperSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04009F1D RID: 40733
		public new const string __ObjectPath = "/Script/GameplayTags.GameplayTagsDeveloperSettings";

		// Token: 0x04009F1E RID: 40734
		private static IntPtr _ClassPtr;

		// Token: 0x04009F1F RID: 40735
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04009F20 RID: 40736
		internal static int __PropertyOffset_DeveloperConfigName;

		// Token: 0x04009F21 RID: 40737
		internal static int __PropertyOffset_FavoriteTagSource;
	}
}
