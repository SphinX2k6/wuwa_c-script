using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002A96 RID: 10902
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/WwiseResourceLoader.WwiseSwitchContainerLeafCookedData")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 128)]
	public class FWwiseSwitchContainerLeafCookedData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060282F4 RID: 164596 RVA: 0x003D227B File Offset: 0x003D047B
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FWwiseSwitchContainerLeafCookedData._ScriptStructPtr != 0) ? FWwiseSwitchContainerLeafCookedData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/WwiseResourceLoader.WwiseSwitchContainerLeafCookedData", ref FWwiseSwitchContainerLeafCookedData._ScriptStructPtr);
		}

		// Token: 0x1700994F RID: 39247
		// (get) Token: 0x060282F5 RID: 164597 RVA: 0x003D22A0 File Offset: 0x003D04A0
		// (set) Token: 0x060282F6 RID: 164598 RVA: 0x003D22E3 File Offset: 0x003D04E3
		public TSet<FWwiseGroupValueCookedData> GroupValueSet
		{
			get
			{
				base.FastCheckIsValid();
				TSet<FWwiseGroupValueCookedData> result;
				if ((result = this._GroupValueSet) == null)
				{
					result = (this._GroupValueSet = new TSet<FWwiseGroupValueCookedData>(base.NativePtr + (IntPtr)FWwiseSwitchContainerLeafCookedData.__PropertyOffset_GroupValueSet, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.GroupValueSet.CopyAssign(value);
			}
		}

		// Token: 0x17009950 RID: 39248
		// (get) Token: 0x060282F7 RID: 164599 RVA: 0x003D22F4 File Offset: 0x003D04F4
		// (set) Token: 0x060282F8 RID: 164600 RVA: 0x003D2337 File Offset: 0x003D0537
		public TArray<FWwiseSoundBankCookedData> SoundBanks
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FWwiseSoundBankCookedData> result;
				if ((result = this._SoundBanks) == null)
				{
					result = (this._SoundBanks = new TArray<FWwiseSoundBankCookedData>(base.NativePtr + (IntPtr)FWwiseSwitchContainerLeafCookedData.__PropertyOffset_SoundBanks, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SoundBanks.CopyAssign(value);
			}
		}

		// Token: 0x17009951 RID: 39249
		// (get) Token: 0x060282F9 RID: 164601 RVA: 0x003D2348 File Offset: 0x003D0548
		// (set) Token: 0x060282FA RID: 164602 RVA: 0x003D238B File Offset: 0x003D058B
		public TArray<FWwiseMediaCookedData> Media
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FWwiseMediaCookedData> result;
				if ((result = this._Media) == null)
				{
					result = (this._Media = new TArray<FWwiseMediaCookedData>(base.NativePtr + (IntPtr)FWwiseSwitchContainerLeafCookedData.__PropertyOffset_Media, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Media.CopyAssign(value);
			}
		}

		// Token: 0x17009952 RID: 39250
		// (get) Token: 0x060282FB RID: 164603 RVA: 0x003D239C File Offset: 0x003D059C
		// (set) Token: 0x060282FC RID: 164604 RVA: 0x003D23DF File Offset: 0x003D05DF
		public TArray<FWwiseExternalSourceCookedData> ExternalSources
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FWwiseExternalSourceCookedData> result;
				if ((result = this._ExternalSources) == null)
				{
					result = (this._ExternalSources = new TArray<FWwiseExternalSourceCookedData>(base.NativePtr + (IntPtr)FWwiseSwitchContainerLeafCookedData.__PropertyOffset_ExternalSources, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ExternalSources.CopyAssign(value);
			}
		}

		// Token: 0x060282FD RID: 164605 RVA: 0x003D23ED File Offset: 0x003D05ED
		public FWwiseSwitchContainerLeafCookedData()
		{
		}

		// Token: 0x060282FE RID: 164606 RVA: 0x003D23F5 File Offset: 0x003D05F5
		public FWwiseSwitchContainerLeafCookedData(TSet<FWwiseGroupValueCookedData> GroupValueSet, TArray<FWwiseSoundBankCookedData> SoundBanks, TArray<FWwiseMediaCookedData> Media, TArray<FWwiseExternalSourceCookedData> ExternalSources)
		{
			this.GroupValueSet = GroupValueSet;
			this.SoundBanks = SoundBanks;
			this.Media = Media;
			this.ExternalSources = ExternalSources;
		}

		// Token: 0x060282FF RID: 164607 RVA: 0x003D241A File Offset: 0x003D061A
		protected override IntPtr GetUStructPtr()
		{
			return FWwiseSwitchContainerLeafCookedData.StaticStruct();
		}

		// Token: 0x06028300 RID: 164608 RVA: 0x003D2426 File Offset: 0x003D0626
		[NullableContext(2)]
		public FWwiseSwitchContainerLeafCookedData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06028301 RID: 164609 RVA: 0x003D2430 File Offset: 0x003D0630
		public FWwiseSwitchContainerLeafCookedData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06028302 RID: 164610 RVA: 0x003D243B File Offset: 0x003D063B
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FWwiseSwitchContainerLeafCookedData(Pointer, false, true);
		}

		// Token: 0x06028303 RID: 164611 RVA: 0x003D2445 File Offset: 0x003D0645
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FWwiseSwitchContainerLeafCookedData(Pointer, MemoryOwner);
		}

		// Token: 0x04016093 RID: 90259
		public const string __ObjectPath = "/Script/WwiseResourceLoader.WwiseSwitchContainerLeafCookedData";

		// Token: 0x04016094 RID: 90260
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04016095 RID: 90261
		internal static int __PropertyOffset_GroupValueSet;

		// Token: 0x04016096 RID: 90262
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<FWwiseGroupValueCookedData> _GroupValueSet;

		// Token: 0x04016097 RID: 90263
		internal static int __PropertyOffset_SoundBanks;

		// Token: 0x04016098 RID: 90264
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FWwiseSoundBankCookedData> _SoundBanks;

		// Token: 0x04016099 RID: 90265
		internal static int __PropertyOffset_Media;

		// Token: 0x0401609A RID: 90266
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FWwiseMediaCookedData> _Media;

		// Token: 0x0401609B RID: 90267
		internal static int __PropertyOffset_ExternalSources;

		// Token: 0x0401609C RID: 90268
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FWwiseExternalSourceCookedData> _ExternalSources;
	}
}
