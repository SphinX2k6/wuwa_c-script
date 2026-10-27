using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002A8A RID: 10890
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/WwiseResourceLoader.WwiseLocalizedAuxBusCookedData")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 96)]
	public class FWwiseLocalizedAuxBusCookedData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06028258 RID: 164440 RVA: 0x003D16C8 File Offset: 0x003CF8C8
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FWwiseLocalizedAuxBusCookedData._ScriptStructPtr != 0) ? FWwiseLocalizedAuxBusCookedData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/WwiseResourceLoader.WwiseLocalizedAuxBusCookedData", ref FWwiseLocalizedAuxBusCookedData._ScriptStructPtr);
		}

		// Token: 0x17009937 RID: 39223
		// (get) Token: 0x06028259 RID: 164441 RVA: 0x003D16EC File Offset: 0x003CF8EC
		// (set) Token: 0x0602825A RID: 164442 RVA: 0x003D172F File Offset: 0x003CF92F
		public TMap<FWwiseLanguageCookedData, FWwiseAuxBusCookedData> AuxBusLanguageMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FWwiseLanguageCookedData, FWwiseAuxBusCookedData> result;
				if ((result = this._AuxBusLanguageMap) == null)
				{
					result = (this._AuxBusLanguageMap = new TMap<FWwiseLanguageCookedData, FWwiseAuxBusCookedData>(base.NativePtr + (IntPtr)FWwiseLocalizedAuxBusCookedData.__PropertyOffset_AuxBusLanguageMap, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.AuxBusLanguageMap.CopyAssign(value);
			}
		}

		// Token: 0x17009938 RID: 39224
		// (get) Token: 0x0602825B RID: 164443 RVA: 0x003D173D File Offset: 0x003CF93D
		// (set) Token: 0x0602825C RID: 164444 RVA: 0x003D1751 File Offset: 0x003CF951
		public unsafe FName DebugName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWwiseLocalizedAuxBusCookedData.__PropertyOffset_DebugName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWwiseLocalizedAuxBusCookedData.__PropertyOffset_DebugName) = value;
			}
		}

		// Token: 0x17009939 RID: 39225
		// (get) Token: 0x0602825D RID: 164445 RVA: 0x003D1766 File Offset: 0x003CF966
		// (set) Token: 0x0602825E RID: 164446 RVA: 0x003D1776 File Offset: 0x003CF976
		public unsafe int AuxBusId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWwiseLocalizedAuxBusCookedData.__PropertyOffset_AuxBusId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWwiseLocalizedAuxBusCookedData.__PropertyOffset_AuxBusId) = value;
			}
		}

		// Token: 0x0602825F RID: 164447 RVA: 0x003D1787 File Offset: 0x003CF987
		public FWwiseLocalizedAuxBusCookedData()
		{
		}

		// Token: 0x06028260 RID: 164448 RVA: 0x003D178F File Offset: 0x003CF98F
		public FWwiseLocalizedAuxBusCookedData(TMap<FWwiseLanguageCookedData, FWwiseAuxBusCookedData> AuxBusLanguageMap, FName DebugName, int AuxBusId)
		{
			this.AuxBusLanguageMap = AuxBusLanguageMap;
			this.DebugName = DebugName;
			this.AuxBusId = AuxBusId;
		}

		// Token: 0x06028261 RID: 164449 RVA: 0x003D17AC File Offset: 0x003CF9AC
		protected override IntPtr GetUStructPtr()
		{
			return FWwiseLocalizedAuxBusCookedData.StaticStruct();
		}

		// Token: 0x06028262 RID: 164450 RVA: 0x003D17B8 File Offset: 0x003CF9B8
		[NullableContext(2)]
		public FWwiseLocalizedAuxBusCookedData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06028263 RID: 164451 RVA: 0x003D17C2 File Offset: 0x003CF9C2
		public FWwiseLocalizedAuxBusCookedData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06028264 RID: 164452 RVA: 0x003D17CD File Offset: 0x003CF9CD
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FWwiseLocalizedAuxBusCookedData(Pointer, false, true);
		}

		// Token: 0x06028265 RID: 164453 RVA: 0x003D17D7 File Offset: 0x003CF9D7
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FWwiseLocalizedAuxBusCookedData(Pointer, MemoryOwner);
		}

		// Token: 0x0401605B RID: 90203
		public const string __ObjectPath = "/Script/WwiseResourceLoader.WwiseLocalizedAuxBusCookedData";

		// Token: 0x0401605C RID: 90204
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401605D RID: 90205
		internal static int __PropertyOffset_AuxBusLanguageMap;

		// Token: 0x0401605E RID: 90206
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<FWwiseLanguageCookedData, FWwiseAuxBusCookedData> _AuxBusLanguageMap;

		// Token: 0x0401605F RID: 90207
		internal static int __PropertyOffset_DebugName;

		// Token: 0x04016060 RID: 90208
		internal static int __PropertyOffset_AuxBusId;
	}
}
