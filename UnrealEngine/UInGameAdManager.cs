using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000C4B RID: 3147
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.InGameAdManager")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class UInGameAdManager : UPlatformInterfaceBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06009F93 RID: 40851 RVA: 0x000E2B99 File Offset: 0x000E0D99
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UInGameAdManager._ClassPtr;
		}

		// Token: 0x06009F94 RID: 40852 RVA: 0x000E2BA8 File Offset: 0x000E0DA8
		public UInGameAdManager() : this(BuiltinUtils.AllocNativeUObject(UInGameAdManager.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06009F95 RID: 40853 RVA: 0x000E2BD0 File Offset: 0x000E0DD0
		public UInGameAdManager(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UInGameAdManager.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002607 RID: 9735
		// (get) Token: 0x06009F96 RID: 40854 RVA: 0x000E2C03 File Offset: 0x000E0E03
		// (set) Token: 0x06009F97 RID: 40855 RVA: 0x000E2C1C File Offset: 0x000E0E1C
		public unsafe bool bShouldPauseWhileAdOpen
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UInGameAdManager.__PropertyOffset_bShouldPauseWhileAdOpen) & UInGameAdManager.__PropertyMask_bShouldPauseWhileAdOpen) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UInGameAdManager.__PropertyOffset_bShouldPauseWhileAdOpen) = ((*(base.NativePtr + (IntPtr)UInGameAdManager.__PropertyOffset_bShouldPauseWhileAdOpen) & ~UInGameAdManager.__PropertyMask_bShouldPauseWhileAdOpen) | (value ? UInGameAdManager.__PropertyMask_bShouldPauseWhileAdOpen : 0));
			}
		}

		// Token: 0x17002608 RID: 9736
		// (get) Token: 0x06009F98 RID: 40856 RVA: 0x000E2C4C File Offset: 0x000E0E4C
		// (set) Token: 0x06009F99 RID: 40857 RVA: 0x000E2C85 File Offset: 0x000E0E85
		public TArray<FOnUserClickedBanner> ClickedBannerDelegates
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FOnUserClickedBanner> result;
				if ((result = this._ClickedBannerDelegates) == null)
				{
					result = (this._ClickedBannerDelegates = new TArray<FOnUserClickedBanner>(base.NativePtr + (IntPtr)UInGameAdManager.__PropertyOffset_ClickedBannerDelegates, this));
				}
				return result;
			}
			set
			{
				this.ClickedBannerDelegates.CopyAssign(value);
			}
		}

		// Token: 0x17002609 RID: 9737
		// (get) Token: 0x06009F9A RID: 40858 RVA: 0x000E2C94 File Offset: 0x000E0E94
		// (set) Token: 0x06009F9B RID: 40859 RVA: 0x000E2CCD File Offset: 0x000E0ECD
		public TArray<FOnUserClosedAdvertisement> ClosedAdDelegates
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FOnUserClosedAdvertisement> result;
				if ((result = this._ClosedAdDelegates) == null)
				{
					result = (this._ClosedAdDelegates = new TArray<FOnUserClosedAdvertisement>(base.NativePtr + (IntPtr)UInGameAdManager.__PropertyOffset_ClosedAdDelegates, this));
				}
				return result;
			}
			set
			{
				this.ClosedAdDelegates.CopyAssign(value);
			}
		}

		// Token: 0x06009F9C RID: 40860 RVA: 0x000E2CDB File Offset: 0x000E0EDB
		static UInGameAdManager()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.InGameAdManager");
		}

		// Token: 0x06009F9D RID: 40861 RVA: 0x000E2CE9 File Offset: 0x000E0EE9
		protected UInGameAdManager(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040057CC RID: 22476
		public new const string __ObjectPath = "/Script/Engine.InGameAdManager";

		// Token: 0x040057CD RID: 22477
		private static IntPtr _ClassPtr;

		// Token: 0x040057CE RID: 22478
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040057CF RID: 22479
		internal static int __PropertyOffset_bShouldPauseWhileAdOpen;

		// Token: 0x040057D0 RID: 22480
		internal static byte __PropertyMask_bShouldPauseWhileAdOpen;

		// Token: 0x040057D1 RID: 22481
		internal static int __PropertyOffset_ClickedBannerDelegates;

		// Token: 0x040057D2 RID: 22482
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FOnUserClickedBanner> _ClickedBannerDelegates;

		// Token: 0x040057D3 RID: 22483
		internal static int __PropertyOffset_ClosedAdDelegates;

		// Token: 0x040057D4 RID: 22484
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FOnUserClosedAdvertisement> _ClosedAdDelegates;
	}
}
