using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002A81 RID: 10881
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/WwiseResourceLoader.WwiseEventCookedData")]
	[UnrealStructLayout(168, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 168)]
	public class FWwiseEventCookedData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060281BC RID: 164284 RVA: 0x003D09D3 File Offset: 0x003CEBD3
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FWwiseEventCookedData._ScriptStructPtr != 0) ? FWwiseEventCookedData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/WwiseResourceLoader.WwiseEventCookedData", ref FWwiseEventCookedData._ScriptStructPtr);
		}

		// Token: 0x17009922 RID: 39202
		// (get) Token: 0x060281BD RID: 164285 RVA: 0x003D09F7 File Offset: 0x003CEBF7
		// (set) Token: 0x060281BE RID: 164286 RVA: 0x003D0A07 File Offset: 0x003CEC07
		public unsafe int EventId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWwiseEventCookedData.__PropertyOffset_EventId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWwiseEventCookedData.__PropertyOffset_EventId) = value;
			}
		}

		// Token: 0x17009923 RID: 39203
		// (get) Token: 0x060281BF RID: 164287 RVA: 0x003D0A18 File Offset: 0x003CEC18
		// (set) Token: 0x060281C0 RID: 164288 RVA: 0x003D0A5B File Offset: 0x003CEC5B
		public TArray<FWwiseSoundBankCookedData> SoundBanks
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FWwiseSoundBankCookedData> result;
				if ((result = this._SoundBanks) == null)
				{
					result = (this._SoundBanks = new TArray<FWwiseSoundBankCookedData>(base.NativePtr + (IntPtr)FWwiseEventCookedData.__PropertyOffset_SoundBanks, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SoundBanks.CopyAssign(value);
			}
		}

		// Token: 0x17009924 RID: 39204
		// (get) Token: 0x060281C1 RID: 164289 RVA: 0x003D0A6C File Offset: 0x003CEC6C
		// (set) Token: 0x060281C2 RID: 164290 RVA: 0x003D0AAF File Offset: 0x003CECAF
		public TArray<FWwiseMediaCookedData> Media
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FWwiseMediaCookedData> result;
				if ((result = this._Media) == null)
				{
					result = (this._Media = new TArray<FWwiseMediaCookedData>(base.NativePtr + (IntPtr)FWwiseEventCookedData.__PropertyOffset_Media, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Media.CopyAssign(value);
			}
		}

		// Token: 0x17009925 RID: 39205
		// (get) Token: 0x060281C3 RID: 164291 RVA: 0x003D0AC0 File Offset: 0x003CECC0
		// (set) Token: 0x060281C4 RID: 164292 RVA: 0x003D0B03 File Offset: 0x003CED03
		public TArray<FWwiseExternalSourceCookedData> ExternalSources
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FWwiseExternalSourceCookedData> result;
				if ((result = this._ExternalSources) == null)
				{
					result = (this._ExternalSources = new TArray<FWwiseExternalSourceCookedData>(base.NativePtr + (IntPtr)FWwiseEventCookedData.__PropertyOffset_ExternalSources, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ExternalSources.CopyAssign(value);
			}
		}

		// Token: 0x17009926 RID: 39206
		// (get) Token: 0x060281C5 RID: 164293 RVA: 0x003D0B14 File Offset: 0x003CED14
		// (set) Token: 0x060281C6 RID: 164294 RVA: 0x003D0B57 File Offset: 0x003CED57
		public TArray<FWwiseSwitchContainerLeafCookedData> SwitchContainerLeaves
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FWwiseSwitchContainerLeafCookedData> result;
				if ((result = this._SwitchContainerLeaves) == null)
				{
					result = (this._SwitchContainerLeaves = new TArray<FWwiseSwitchContainerLeafCookedData>(base.NativePtr + (IntPtr)FWwiseEventCookedData.__PropertyOffset_SwitchContainerLeaves, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SwitchContainerLeaves.CopyAssign(value);
			}
		}

		// Token: 0x17009927 RID: 39207
		// (get) Token: 0x060281C7 RID: 164295 RVA: 0x003D0B68 File Offset: 0x003CED68
		// (set) Token: 0x060281C8 RID: 164296 RVA: 0x003D0BAB File Offset: 0x003CEDAB
		public TSet<FWwiseGroupValueCookedData> RequiredGroupValueSet
		{
			get
			{
				base.FastCheckIsValid();
				TSet<FWwiseGroupValueCookedData> result;
				if ((result = this._RequiredGroupValueSet) == null)
				{
					result = (this._RequiredGroupValueSet = new TSet<FWwiseGroupValueCookedData>(base.NativePtr + (IntPtr)FWwiseEventCookedData.__PropertyOffset_RequiredGroupValueSet, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.RequiredGroupValueSet.CopyAssign(value);
			}
		}

		// Token: 0x17009928 RID: 39208
		// (get) Token: 0x060281C9 RID: 164297 RVA: 0x003D0BB9 File Offset: 0x003CEDB9
		// (set) Token: 0x060281CA RID: 164298 RVA: 0x003D0BC9 File Offset: 0x003CEDC9
		public unsafe EWwiseEventDestroyOptions DestroyOptions
		{
			get
			{
				return (EWwiseEventDestroyOptions)(*(base.NativePtr + (IntPtr)FWwiseEventCookedData.__PropertyOffset_DestroyOptions));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWwiseEventCookedData.__PropertyOffset_DestroyOptions) = (byte)value;
			}
		}

		// Token: 0x17009929 RID: 39209
		// (get) Token: 0x060281CB RID: 164299 RVA: 0x003D0BDA File Offset: 0x003CEDDA
		// (set) Token: 0x060281CC RID: 164300 RVA: 0x003D0BEE File Offset: 0x003CEDEE
		public unsafe FName DebugName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWwiseEventCookedData.__PropertyOffset_DebugName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWwiseEventCookedData.__PropertyOffset_DebugName) = value;
			}
		}

		// Token: 0x060281CD RID: 164301 RVA: 0x003D0C03 File Offset: 0x003CEE03
		public FWwiseEventCookedData()
		{
		}

		// Token: 0x060281CE RID: 164302 RVA: 0x003D0C0C File Offset: 0x003CEE0C
		public FWwiseEventCookedData(int EventId, TArray<FWwiseSoundBankCookedData> SoundBanks, TArray<FWwiseMediaCookedData> Media, TArray<FWwiseExternalSourceCookedData> ExternalSources, TArray<FWwiseSwitchContainerLeafCookedData> SwitchContainerLeaves, TSet<FWwiseGroupValueCookedData> RequiredGroupValueSet, EWwiseEventDestroyOptions DestroyOptions, FName DebugName)
		{
			this.EventId = EventId;
			this.SoundBanks = SoundBanks;
			this.Media = Media;
			this.ExternalSources = ExternalSources;
			this.SwitchContainerLeaves = SwitchContainerLeaves;
			this.RequiredGroupValueSet = RequiredGroupValueSet;
			this.DestroyOptions = DestroyOptions;
			this.DebugName = DebugName;
		}

		// Token: 0x060281CF RID: 164303 RVA: 0x003D0C5C File Offset: 0x003CEE5C
		protected override IntPtr GetUStructPtr()
		{
			return FWwiseEventCookedData.StaticStruct();
		}

		// Token: 0x060281D0 RID: 164304 RVA: 0x003D0C68 File Offset: 0x003CEE68
		[NullableContext(2)]
		public FWwiseEventCookedData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060281D1 RID: 164305 RVA: 0x003D0C72 File Offset: 0x003CEE72
		public FWwiseEventCookedData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060281D2 RID: 164306 RVA: 0x003D0C7D File Offset: 0x003CEE7D
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FWwiseEventCookedData(Pointer, false, true);
		}

		// Token: 0x060281D3 RID: 164307 RVA: 0x003D0C87 File Offset: 0x003CEE87
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FWwiseEventCookedData(Pointer, MemoryOwner);
		}

		// Token: 0x0401602B RID: 90155
		public const string __ObjectPath = "/Script/WwiseResourceLoader.WwiseEventCookedData";

		// Token: 0x0401602C RID: 90156
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401602D RID: 90157
		internal static int __PropertyOffset_EventId;

		// Token: 0x0401602E RID: 90158
		internal static int __PropertyOffset_SoundBanks;

		// Token: 0x0401602F RID: 90159
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FWwiseSoundBankCookedData> _SoundBanks;

		// Token: 0x04016030 RID: 90160
		internal static int __PropertyOffset_Media;

		// Token: 0x04016031 RID: 90161
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FWwiseMediaCookedData> _Media;

		// Token: 0x04016032 RID: 90162
		internal static int __PropertyOffset_ExternalSources;

		// Token: 0x04016033 RID: 90163
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FWwiseExternalSourceCookedData> _ExternalSources;

		// Token: 0x04016034 RID: 90164
		internal static int __PropertyOffset_SwitchContainerLeaves;

		// Token: 0x04016035 RID: 90165
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FWwiseSwitchContainerLeafCookedData> _SwitchContainerLeaves;

		// Token: 0x04016036 RID: 90166
		internal static int __PropertyOffset_RequiredGroupValueSet;

		// Token: 0x04016037 RID: 90167
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<FWwiseGroupValueCookedData> _RequiredGroupValueSet;

		// Token: 0x04016038 RID: 90168
		internal static int __PropertyOffset_DestroyOptions;

		// Token: 0x04016039 RID: 90169
		internal static int __PropertyOffset_DebugName;
	}
}
