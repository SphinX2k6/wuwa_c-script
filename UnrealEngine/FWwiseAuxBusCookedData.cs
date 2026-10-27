using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002A80 RID: 10880
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/WwiseResourceLoader.WwiseAuxBusCookedData")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FWwiseAuxBusCookedData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060281AC RID: 164268 RVA: 0x003D085D File Offset: 0x003CEA5D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FWwiseAuxBusCookedData._ScriptStructPtr != 0) ? FWwiseAuxBusCookedData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/WwiseResourceLoader.WwiseAuxBusCookedData", ref FWwiseAuxBusCookedData._ScriptStructPtr);
		}

		// Token: 0x1700991E RID: 39198
		// (get) Token: 0x060281AD RID: 164269 RVA: 0x003D0881 File Offset: 0x003CEA81
		// (set) Token: 0x060281AE RID: 164270 RVA: 0x003D0891 File Offset: 0x003CEA91
		public unsafe int AuxBusId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWwiseAuxBusCookedData.__PropertyOffset_AuxBusId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWwiseAuxBusCookedData.__PropertyOffset_AuxBusId) = value;
			}
		}

		// Token: 0x1700991F RID: 39199
		// (get) Token: 0x060281AF RID: 164271 RVA: 0x003D08A4 File Offset: 0x003CEAA4
		// (set) Token: 0x060281B0 RID: 164272 RVA: 0x003D08E7 File Offset: 0x003CEAE7
		public TArray<FWwiseSoundBankCookedData> SoundBanks
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FWwiseSoundBankCookedData> result;
				if ((result = this._SoundBanks) == null)
				{
					result = (this._SoundBanks = new TArray<FWwiseSoundBankCookedData>(base.NativePtr + (IntPtr)FWwiseAuxBusCookedData.__PropertyOffset_SoundBanks, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SoundBanks.CopyAssign(value);
			}
		}

		// Token: 0x17009920 RID: 39200
		// (get) Token: 0x060281B1 RID: 164273 RVA: 0x003D08F8 File Offset: 0x003CEAF8
		// (set) Token: 0x060281B2 RID: 164274 RVA: 0x003D093B File Offset: 0x003CEB3B
		public TArray<FWwiseMediaCookedData> Media
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FWwiseMediaCookedData> result;
				if ((result = this._Media) == null)
				{
					result = (this._Media = new TArray<FWwiseMediaCookedData>(base.NativePtr + (IntPtr)FWwiseAuxBusCookedData.__PropertyOffset_Media, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Media.CopyAssign(value);
			}
		}

		// Token: 0x17009921 RID: 39201
		// (get) Token: 0x060281B3 RID: 164275 RVA: 0x003D0949 File Offset: 0x003CEB49
		// (set) Token: 0x060281B4 RID: 164276 RVA: 0x003D095D File Offset: 0x003CEB5D
		public unsafe FName DebugName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWwiseAuxBusCookedData.__PropertyOffset_DebugName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWwiseAuxBusCookedData.__PropertyOffset_DebugName) = value;
			}
		}

		// Token: 0x060281B5 RID: 164277 RVA: 0x003D0972 File Offset: 0x003CEB72
		public FWwiseAuxBusCookedData()
		{
		}

		// Token: 0x060281B6 RID: 164278 RVA: 0x003D097A File Offset: 0x003CEB7A
		public FWwiseAuxBusCookedData(int AuxBusId, TArray<FWwiseSoundBankCookedData> SoundBanks, TArray<FWwiseMediaCookedData> Media, FName DebugName)
		{
			this.AuxBusId = AuxBusId;
			this.SoundBanks = SoundBanks;
			this.Media = Media;
			this.DebugName = DebugName;
		}

		// Token: 0x060281B7 RID: 164279 RVA: 0x003D099F File Offset: 0x003CEB9F
		protected override IntPtr GetUStructPtr()
		{
			return FWwiseAuxBusCookedData.StaticStruct();
		}

		// Token: 0x060281B8 RID: 164280 RVA: 0x003D09AB File Offset: 0x003CEBAB
		[NullableContext(2)]
		public FWwiseAuxBusCookedData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060281B9 RID: 164281 RVA: 0x003D09B5 File Offset: 0x003CEBB5
		public FWwiseAuxBusCookedData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060281BA RID: 164282 RVA: 0x003D09C0 File Offset: 0x003CEBC0
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FWwiseAuxBusCookedData(Pointer, false, true);
		}

		// Token: 0x060281BB RID: 164283 RVA: 0x003D09CA File Offset: 0x003CEBCA
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FWwiseAuxBusCookedData(Pointer, MemoryOwner);
		}

		// Token: 0x04016023 RID: 90147
		public const string __ObjectPath = "/Script/WwiseResourceLoader.WwiseAuxBusCookedData";

		// Token: 0x04016024 RID: 90148
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04016025 RID: 90149
		internal static int __PropertyOffset_AuxBusId;

		// Token: 0x04016026 RID: 90150
		internal static int __PropertyOffset_SoundBanks;

		// Token: 0x04016027 RID: 90151
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FWwiseSoundBankCookedData> _SoundBanks;

		// Token: 0x04016028 RID: 90152
		internal static int __PropertyOffset_Media;

		// Token: 0x04016029 RID: 90153
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FWwiseMediaCookedData> _Media;

		// Token: 0x0401602A RID: 90154
		internal static int __PropertyOffset_DebugName;
	}
}
