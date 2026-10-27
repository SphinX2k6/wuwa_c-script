using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002A95 RID: 10901
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/WwiseResourceLoader.WwiseShareSetCookedData")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FWwiseShareSetCookedData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060282E4 RID: 164580 RVA: 0x003D2107 File Offset: 0x003D0307
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FWwiseShareSetCookedData._ScriptStructPtr != 0) ? FWwiseShareSetCookedData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/WwiseResourceLoader.WwiseShareSetCookedData", ref FWwiseShareSetCookedData._ScriptStructPtr);
		}

		// Token: 0x1700994B RID: 39243
		// (get) Token: 0x060282E5 RID: 164581 RVA: 0x003D212B File Offset: 0x003D032B
		// (set) Token: 0x060282E6 RID: 164582 RVA: 0x003D213B File Offset: 0x003D033B
		public unsafe int ShareSetId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWwiseShareSetCookedData.__PropertyOffset_ShareSetId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWwiseShareSetCookedData.__PropertyOffset_ShareSetId) = value;
			}
		}

		// Token: 0x1700994C RID: 39244
		// (get) Token: 0x060282E7 RID: 164583 RVA: 0x003D214C File Offset: 0x003D034C
		// (set) Token: 0x060282E8 RID: 164584 RVA: 0x003D218F File Offset: 0x003D038F
		public TArray<FWwiseSoundBankCookedData> SoundBanks
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FWwiseSoundBankCookedData> result;
				if ((result = this._SoundBanks) == null)
				{
					result = (this._SoundBanks = new TArray<FWwiseSoundBankCookedData>(base.NativePtr + (IntPtr)FWwiseShareSetCookedData.__PropertyOffset_SoundBanks, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SoundBanks.CopyAssign(value);
			}
		}

		// Token: 0x1700994D RID: 39245
		// (get) Token: 0x060282E9 RID: 164585 RVA: 0x003D21A0 File Offset: 0x003D03A0
		// (set) Token: 0x060282EA RID: 164586 RVA: 0x003D21E3 File Offset: 0x003D03E3
		public TArray<FWwiseMediaCookedData> Media
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FWwiseMediaCookedData> result;
				if ((result = this._Media) == null)
				{
					result = (this._Media = new TArray<FWwiseMediaCookedData>(base.NativePtr + (IntPtr)FWwiseShareSetCookedData.__PropertyOffset_Media, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Media.CopyAssign(value);
			}
		}

		// Token: 0x1700994E RID: 39246
		// (get) Token: 0x060282EB RID: 164587 RVA: 0x003D21F1 File Offset: 0x003D03F1
		// (set) Token: 0x060282EC RID: 164588 RVA: 0x003D2205 File Offset: 0x003D0405
		public unsafe FName DebugName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWwiseShareSetCookedData.__PropertyOffset_DebugName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWwiseShareSetCookedData.__PropertyOffset_DebugName) = value;
			}
		}

		// Token: 0x060282ED RID: 164589 RVA: 0x003D221A File Offset: 0x003D041A
		public FWwiseShareSetCookedData()
		{
		}

		// Token: 0x060282EE RID: 164590 RVA: 0x003D2222 File Offset: 0x003D0422
		public FWwiseShareSetCookedData(int ShareSetId, TArray<FWwiseSoundBankCookedData> SoundBanks, TArray<FWwiseMediaCookedData> Media, FName DebugName)
		{
			this.ShareSetId = ShareSetId;
			this.SoundBanks = SoundBanks;
			this.Media = Media;
			this.DebugName = DebugName;
		}

		// Token: 0x060282EF RID: 164591 RVA: 0x003D2247 File Offset: 0x003D0447
		protected override IntPtr GetUStructPtr()
		{
			return FWwiseShareSetCookedData.StaticStruct();
		}

		// Token: 0x060282F0 RID: 164592 RVA: 0x003D2253 File Offset: 0x003D0453
		[NullableContext(2)]
		public FWwiseShareSetCookedData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060282F1 RID: 164593 RVA: 0x003D225D File Offset: 0x003D045D
		public FWwiseShareSetCookedData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060282F2 RID: 164594 RVA: 0x003D2268 File Offset: 0x003D0468
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FWwiseShareSetCookedData(Pointer, false, true);
		}

		// Token: 0x060282F3 RID: 164595 RVA: 0x003D2272 File Offset: 0x003D0472
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FWwiseShareSetCookedData(Pointer, MemoryOwner);
		}

		// Token: 0x0401608B RID: 90251
		public const string __ObjectPath = "/Script/WwiseResourceLoader.WwiseShareSetCookedData";

		// Token: 0x0401608C RID: 90252
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401608D RID: 90253
		internal static int __PropertyOffset_ShareSetId;

		// Token: 0x0401608E RID: 90254
		internal static int __PropertyOffset_SoundBanks;

		// Token: 0x0401608F RID: 90255
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FWwiseSoundBankCookedData> _SoundBanks;

		// Token: 0x04016090 RID: 90256
		internal static int __PropertyOffset_Media;

		// Token: 0x04016091 RID: 90257
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FWwiseMediaCookedData> _Media;

		// Token: 0x04016092 RID: 90258
		internal static int __PropertyOffset_DebugName;
	}
}
