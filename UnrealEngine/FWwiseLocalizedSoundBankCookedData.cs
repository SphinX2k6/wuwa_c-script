using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002A8D RID: 10893
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/WwiseResourceLoader.WwiseLocalizedSoundBankCookedData")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 96)]
	public class FWwiseLocalizedSoundBankCookedData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06028282 RID: 164482 RVA: 0x003D1A10 File Offset: 0x003CFC10
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FWwiseLocalizedSoundBankCookedData._ScriptStructPtr != 0) ? FWwiseLocalizedSoundBankCookedData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/WwiseResourceLoader.WwiseLocalizedSoundBankCookedData", ref FWwiseLocalizedSoundBankCookedData._ScriptStructPtr);
		}

		// Token: 0x17009940 RID: 39232
		// (get) Token: 0x06028283 RID: 164483 RVA: 0x003D1A34 File Offset: 0x003CFC34
		// (set) Token: 0x06028284 RID: 164484 RVA: 0x003D1A77 File Offset: 0x003CFC77
		public TMap<FWwiseLanguageCookedData, FWwiseSoundBankCookedData> SoundBankLanguageMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FWwiseLanguageCookedData, FWwiseSoundBankCookedData> result;
				if ((result = this._SoundBankLanguageMap) == null)
				{
					result = (this._SoundBankLanguageMap = new TMap<FWwiseLanguageCookedData, FWwiseSoundBankCookedData>(base.NativePtr + (IntPtr)FWwiseLocalizedSoundBankCookedData.__PropertyOffset_SoundBankLanguageMap, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SoundBankLanguageMap.CopyAssign(value);
			}
		}

		// Token: 0x17009941 RID: 39233
		// (get) Token: 0x06028285 RID: 164485 RVA: 0x003D1A85 File Offset: 0x003CFC85
		// (set) Token: 0x06028286 RID: 164486 RVA: 0x003D1A99 File Offset: 0x003CFC99
		public unsafe FName DebugName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWwiseLocalizedSoundBankCookedData.__PropertyOffset_DebugName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWwiseLocalizedSoundBankCookedData.__PropertyOffset_DebugName) = value;
			}
		}

		// Token: 0x17009942 RID: 39234
		// (get) Token: 0x06028287 RID: 164487 RVA: 0x003D1AAE File Offset: 0x003CFCAE
		// (set) Token: 0x06028288 RID: 164488 RVA: 0x003D1ABE File Offset: 0x003CFCBE
		public unsafe int SoundBankId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWwiseLocalizedSoundBankCookedData.__PropertyOffset_SoundBankId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWwiseLocalizedSoundBankCookedData.__PropertyOffset_SoundBankId) = value;
			}
		}

		// Token: 0x06028289 RID: 164489 RVA: 0x003D1ACF File Offset: 0x003CFCCF
		public FWwiseLocalizedSoundBankCookedData()
		{
		}

		// Token: 0x0602828A RID: 164490 RVA: 0x003D1AD7 File Offset: 0x003CFCD7
		public FWwiseLocalizedSoundBankCookedData(TMap<FWwiseLanguageCookedData, FWwiseSoundBankCookedData> SoundBankLanguageMap, FName DebugName, int SoundBankId)
		{
			this.SoundBankLanguageMap = SoundBankLanguageMap;
			this.DebugName = DebugName;
			this.SoundBankId = SoundBankId;
		}

		// Token: 0x0602828B RID: 164491 RVA: 0x003D1AF4 File Offset: 0x003CFCF4
		protected override IntPtr GetUStructPtr()
		{
			return FWwiseLocalizedSoundBankCookedData.StaticStruct();
		}

		// Token: 0x0602828C RID: 164492 RVA: 0x003D1B00 File Offset: 0x003CFD00
		[NullableContext(2)]
		public FWwiseLocalizedSoundBankCookedData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602828D RID: 164493 RVA: 0x003D1B0A File Offset: 0x003CFD0A
		public FWwiseLocalizedSoundBankCookedData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602828E RID: 164494 RVA: 0x003D1B15 File Offset: 0x003CFD15
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FWwiseLocalizedSoundBankCookedData(Pointer, false, true);
		}

		// Token: 0x0602828F RID: 164495 RVA: 0x003D1B1F File Offset: 0x003CFD1F
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FWwiseLocalizedSoundBankCookedData(Pointer, MemoryOwner);
		}

		// Token: 0x0401606D RID: 90221
		public const string __ObjectPath = "/Script/WwiseResourceLoader.WwiseLocalizedSoundBankCookedData";

		// Token: 0x0401606E RID: 90222
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401606F RID: 90223
		internal static int __PropertyOffset_SoundBankLanguageMap;

		// Token: 0x04016070 RID: 90224
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<FWwiseLanguageCookedData, FWwiseSoundBankCookedData> _SoundBankLanguageMap;

		// Token: 0x04016071 RID: 90225
		internal static int __PropertyOffset_DebugName;

		// Token: 0x04016072 RID: 90226
		internal static int __PropertyOffset_SoundBankId;
	}
}
