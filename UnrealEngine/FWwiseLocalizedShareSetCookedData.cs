using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002A8C RID: 10892
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/WwiseResourceLoader.WwiseLocalizedShareSetCookedData")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 96)]
	public class FWwiseLocalizedShareSetCookedData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06028274 RID: 164468 RVA: 0x003D18F8 File Offset: 0x003CFAF8
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FWwiseLocalizedShareSetCookedData._ScriptStructPtr != 0) ? FWwiseLocalizedShareSetCookedData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/WwiseResourceLoader.WwiseLocalizedShareSetCookedData", ref FWwiseLocalizedShareSetCookedData._ScriptStructPtr);
		}

		// Token: 0x1700993D RID: 39229
		// (get) Token: 0x06028275 RID: 164469 RVA: 0x003D191C File Offset: 0x003CFB1C
		// (set) Token: 0x06028276 RID: 164470 RVA: 0x003D195F File Offset: 0x003CFB5F
		public TMap<FWwiseLanguageCookedData, FWwiseShareSetCookedData> ShareSetLanguageMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FWwiseLanguageCookedData, FWwiseShareSetCookedData> result;
				if ((result = this._ShareSetLanguageMap) == null)
				{
					result = (this._ShareSetLanguageMap = new TMap<FWwiseLanguageCookedData, FWwiseShareSetCookedData>(base.NativePtr + (IntPtr)FWwiseLocalizedShareSetCookedData.__PropertyOffset_ShareSetLanguageMap, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ShareSetLanguageMap.CopyAssign(value);
			}
		}

		// Token: 0x1700993E RID: 39230
		// (get) Token: 0x06028277 RID: 164471 RVA: 0x003D196D File Offset: 0x003CFB6D
		// (set) Token: 0x06028278 RID: 164472 RVA: 0x003D1981 File Offset: 0x003CFB81
		public unsafe FName DebugName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWwiseLocalizedShareSetCookedData.__PropertyOffset_DebugName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWwiseLocalizedShareSetCookedData.__PropertyOffset_DebugName) = value;
			}
		}

		// Token: 0x1700993F RID: 39231
		// (get) Token: 0x06028279 RID: 164473 RVA: 0x003D1996 File Offset: 0x003CFB96
		// (set) Token: 0x0602827A RID: 164474 RVA: 0x003D19A6 File Offset: 0x003CFBA6
		public unsafe int ShareSetId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWwiseLocalizedShareSetCookedData.__PropertyOffset_ShareSetId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWwiseLocalizedShareSetCookedData.__PropertyOffset_ShareSetId) = value;
			}
		}

		// Token: 0x0602827B RID: 164475 RVA: 0x003D19B7 File Offset: 0x003CFBB7
		public FWwiseLocalizedShareSetCookedData()
		{
		}

		// Token: 0x0602827C RID: 164476 RVA: 0x003D19BF File Offset: 0x003CFBBF
		public FWwiseLocalizedShareSetCookedData(TMap<FWwiseLanguageCookedData, FWwiseShareSetCookedData> ShareSetLanguageMap, FName DebugName, int ShareSetId)
		{
			this.ShareSetLanguageMap = ShareSetLanguageMap;
			this.DebugName = DebugName;
			this.ShareSetId = ShareSetId;
		}

		// Token: 0x0602827D RID: 164477 RVA: 0x003D19DC File Offset: 0x003CFBDC
		protected override IntPtr GetUStructPtr()
		{
			return FWwiseLocalizedShareSetCookedData.StaticStruct();
		}

		// Token: 0x0602827E RID: 164478 RVA: 0x003D19E8 File Offset: 0x003CFBE8
		[NullableContext(2)]
		public FWwiseLocalizedShareSetCookedData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602827F RID: 164479 RVA: 0x003D19F2 File Offset: 0x003CFBF2
		public FWwiseLocalizedShareSetCookedData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06028280 RID: 164480 RVA: 0x003D19FD File Offset: 0x003CFBFD
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FWwiseLocalizedShareSetCookedData(Pointer, false, true);
		}

		// Token: 0x06028281 RID: 164481 RVA: 0x003D1A07 File Offset: 0x003CFC07
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FWwiseLocalizedShareSetCookedData(Pointer, MemoryOwner);
		}

		// Token: 0x04016067 RID: 90215
		public const string __ObjectPath = "/Script/WwiseResourceLoader.WwiseLocalizedShareSetCookedData";

		// Token: 0x04016068 RID: 90216
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04016069 RID: 90217
		internal static int __PropertyOffset_ShareSetLanguageMap;

		// Token: 0x0401606A RID: 90218
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<FWwiseLanguageCookedData, FWwiseShareSetCookedData> _ShareSetLanguageMap;

		// Token: 0x0401606B RID: 90219
		internal static int __PropertyOffset_DebugName;

		// Token: 0x0401606C RID: 90220
		internal static int __PropertyOffset_ShareSetId;
	}
}
