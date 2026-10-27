using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002A88 RID: 10888
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/WwiseResourceLoader.WwiseInitBankCookedData")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 72)]
	public class FWwiseInitBankCookedData : FWwiseSoundBankCookedData, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06028240 RID: 164416 RVA: 0x003D14A6 File Offset: 0x003CF6A6
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FWwiseInitBankCookedData._ScriptStructPtr != 0) ? FWwiseInitBankCookedData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/WwiseResourceLoader.WwiseInitBankCookedData", ref FWwiseInitBankCookedData._ScriptStructPtr);
		}

		// Token: 0x17009933 RID: 39219
		// (get) Token: 0x06028241 RID: 164417 RVA: 0x003D14CC File Offset: 0x003CF6CC
		// (set) Token: 0x06028242 RID: 164418 RVA: 0x003D150F File Offset: 0x003CF70F
		public TArray<FWwiseMediaCookedData> Media
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FWwiseMediaCookedData> result;
				if ((result = this._Media) == null)
				{
					result = (this._Media = new TArray<FWwiseMediaCookedData>(base.NativePtr + (IntPtr)FWwiseInitBankCookedData.__PropertyOffset_Media, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Media.CopyAssign(value);
			}
		}

		// Token: 0x17009934 RID: 39220
		// (get) Token: 0x06028243 RID: 164419 RVA: 0x003D1520 File Offset: 0x003CF720
		// (set) Token: 0x06028244 RID: 164420 RVA: 0x003D1563 File Offset: 0x003CF763
		public TArray<FWwiseLanguageCookedData> Language
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FWwiseLanguageCookedData> result;
				if ((result = this._Language) == null)
				{
					result = (this._Language = new TArray<FWwiseLanguageCookedData>(base.NativePtr + (IntPtr)FWwiseInitBankCookedData.__PropertyOffset_Language, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Language.CopyAssign(value);
			}
		}

		// Token: 0x06028245 RID: 164421 RVA: 0x003D1571 File Offset: 0x003CF771
		public FWwiseInitBankCookedData()
		{
		}

		// Token: 0x06028246 RID: 164422 RVA: 0x003D157C File Offset: 0x003CF77C
		public FWwiseInitBankCookedData(TArray<FWwiseMediaCookedData> Media, TArray<FWwiseLanguageCookedData> Language, int SoundBankId, FName SoundBankPathName, int MemoryAlignment, bool bDeviceMemory, bool bContainsMedia, EWwiseSoundBankType SoundBankType, FName DebugName)
		{
			this.Media = Media;
			this.Language = Language;
			base.SoundBankId = SoundBankId;
			base.SoundBankPathName = SoundBankPathName;
			base.MemoryAlignment = MemoryAlignment;
			base.bDeviceMemory = bDeviceMemory;
			base.bContainsMedia = bContainsMedia;
			base.SoundBankType = SoundBankType;
			base.DebugName = DebugName;
		}

		// Token: 0x06028247 RID: 164423 RVA: 0x003D15D4 File Offset: 0x003CF7D4
		protected override IntPtr GetUStructPtr()
		{
			return FWwiseInitBankCookedData.StaticStruct();
		}

		// Token: 0x06028248 RID: 164424 RVA: 0x003D15E0 File Offset: 0x003CF7E0
		[NullableContext(2)]
		public FWwiseInitBankCookedData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06028249 RID: 164425 RVA: 0x003D15EA File Offset: 0x003CF7EA
		public FWwiseInitBankCookedData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602824A RID: 164426 RVA: 0x003D15F5 File Offset: 0x003CF7F5
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FWwiseInitBankCookedData(Pointer, false, true);
		}

		// Token: 0x0602824B RID: 164427 RVA: 0x003D15FF File Offset: 0x003CF7FF
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FWwiseInitBankCookedData(Pointer, MemoryOwner);
		}

		// Token: 0x04016051 RID: 90193
		public new const string __ObjectPath = "/Script/WwiseResourceLoader.WwiseInitBankCookedData";

		// Token: 0x04016052 RID: 90194
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04016053 RID: 90195
		internal static int __PropertyOffset_Media;

		// Token: 0x04016054 RID: 90196
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FWwiseMediaCookedData> _Media;

		// Token: 0x04016055 RID: 90197
		internal static int __PropertyOffset_Language;

		// Token: 0x04016056 RID: 90198
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FWwiseLanguageCookedData> _Language;
	}
}
