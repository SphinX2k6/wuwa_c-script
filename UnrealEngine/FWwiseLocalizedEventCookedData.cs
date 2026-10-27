using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002A8B RID: 10891
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/WwiseResourceLoader.WwiseLocalizedEventCookedData")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 96)]
	public class FWwiseLocalizedEventCookedData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06028266 RID: 164454 RVA: 0x003D17E0 File Offset: 0x003CF9E0
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FWwiseLocalizedEventCookedData._ScriptStructPtr != 0) ? FWwiseLocalizedEventCookedData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/WwiseResourceLoader.WwiseLocalizedEventCookedData", ref FWwiseLocalizedEventCookedData._ScriptStructPtr);
		}

		// Token: 0x1700993A RID: 39226
		// (get) Token: 0x06028267 RID: 164455 RVA: 0x003D1804 File Offset: 0x003CFA04
		// (set) Token: 0x06028268 RID: 164456 RVA: 0x003D1847 File Offset: 0x003CFA47
		public TMap<FWwiseLanguageCookedData, FWwiseEventCookedData> EventLanguageMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FWwiseLanguageCookedData, FWwiseEventCookedData> result;
				if ((result = this._EventLanguageMap) == null)
				{
					result = (this._EventLanguageMap = new TMap<FWwiseLanguageCookedData, FWwiseEventCookedData>(base.NativePtr + (IntPtr)FWwiseLocalizedEventCookedData.__PropertyOffset_EventLanguageMap, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.EventLanguageMap.CopyAssign(value);
			}
		}

		// Token: 0x1700993B RID: 39227
		// (get) Token: 0x06028269 RID: 164457 RVA: 0x003D1855 File Offset: 0x003CFA55
		// (set) Token: 0x0602826A RID: 164458 RVA: 0x003D1869 File Offset: 0x003CFA69
		public unsafe FName DebugName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWwiseLocalizedEventCookedData.__PropertyOffset_DebugName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWwiseLocalizedEventCookedData.__PropertyOffset_DebugName) = value;
			}
		}

		// Token: 0x1700993C RID: 39228
		// (get) Token: 0x0602826B RID: 164459 RVA: 0x003D187E File Offset: 0x003CFA7E
		// (set) Token: 0x0602826C RID: 164460 RVA: 0x003D188E File Offset: 0x003CFA8E
		public unsafe int EventId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWwiseLocalizedEventCookedData.__PropertyOffset_EventId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWwiseLocalizedEventCookedData.__PropertyOffset_EventId) = value;
			}
		}

		// Token: 0x0602826D RID: 164461 RVA: 0x003D189F File Offset: 0x003CFA9F
		public FWwiseLocalizedEventCookedData()
		{
		}

		// Token: 0x0602826E RID: 164462 RVA: 0x003D18A7 File Offset: 0x003CFAA7
		public FWwiseLocalizedEventCookedData(TMap<FWwiseLanguageCookedData, FWwiseEventCookedData> EventLanguageMap, FName DebugName, int EventId)
		{
			this.EventLanguageMap = EventLanguageMap;
			this.DebugName = DebugName;
			this.EventId = EventId;
		}

		// Token: 0x0602826F RID: 164463 RVA: 0x003D18C4 File Offset: 0x003CFAC4
		protected override IntPtr GetUStructPtr()
		{
			return FWwiseLocalizedEventCookedData.StaticStruct();
		}

		// Token: 0x06028270 RID: 164464 RVA: 0x003D18D0 File Offset: 0x003CFAD0
		[NullableContext(2)]
		public FWwiseLocalizedEventCookedData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06028271 RID: 164465 RVA: 0x003D18DA File Offset: 0x003CFADA
		public FWwiseLocalizedEventCookedData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06028272 RID: 164466 RVA: 0x003D18E5 File Offset: 0x003CFAE5
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FWwiseLocalizedEventCookedData(Pointer, false, true);
		}

		// Token: 0x06028273 RID: 164467 RVA: 0x003D18EF File Offset: 0x003CFAEF
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FWwiseLocalizedEventCookedData(Pointer, MemoryOwner);
		}

		// Token: 0x04016061 RID: 90209
		public const string __ObjectPath = "/Script/WwiseResourceLoader.WwiseLocalizedEventCookedData";

		// Token: 0x04016062 RID: 90210
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04016063 RID: 90211
		internal static int __PropertyOffset_EventLanguageMap;

		// Token: 0x04016064 RID: 90212
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<FWwiseLanguageCookedData, FWwiseEventCookedData> _EventLanguageMap;

		// Token: 0x04016065 RID: 90213
		internal static int __PropertyOffset_DebugName;

		// Token: 0x04016066 RID: 90214
		internal static int __PropertyOffset_EventId;
	}
}
