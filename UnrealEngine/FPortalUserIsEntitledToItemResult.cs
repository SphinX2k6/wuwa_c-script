using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200264E RID: 9806
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/PortalServices.PortalUserIsEntitledToItemResult")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FPortalUserIsEntitledToItemResult : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060246FB RID: 149243 RVA: 0x0035EFD8 File Offset: 0x0035D1D8
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPortalUserIsEntitledToItemResult._ScriptStructPtr != 0) ? FPortalUserIsEntitledToItemResult._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/PortalServices.PortalUserIsEntitledToItemResult", ref FPortalUserIsEntitledToItemResult._ScriptStructPtr);
		}

		// Token: 0x17008C6B RID: 35947
		// (get) Token: 0x060246FC RID: 149244 RVA: 0x0035EFFC File Offset: 0x0035D1FC
		// (set) Token: 0x060246FD RID: 149245 RVA: 0x0035F010 File Offset: 0x0035D210
		public unsafe string ItemId
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FPortalUserIsEntitledToItemResult.__PropertyOffset_ItemId)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FPortalUserIsEntitledToItemResult.__PropertyOffset_ItemId)), value);
			}
		}

		// Token: 0x17008C6C RID: 35948
		// (get) Token: 0x060246FE RID: 149246 RVA: 0x0035F025 File Offset: 0x0035D225
		// (set) Token: 0x060246FF RID: 149247 RVA: 0x0035F035 File Offset: 0x0035D235
		public unsafe bool IsEntitled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPortalUserIsEntitledToItemResult.__PropertyOffset_IsEntitled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPortalUserIsEntitledToItemResult.__PropertyOffset_IsEntitled) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008C6D RID: 35949
		// (get) Token: 0x06024700 RID: 149248 RVA: 0x0035F046 File Offset: 0x0035D246
		// (set) Token: 0x06024701 RID: 149249 RVA: 0x0035F056 File Offset: 0x0035D256
		public unsafe EEntitlementCacheLevelRetrieved RetrievedFromCacheLevel
		{
			get
			{
				return (EEntitlementCacheLevelRetrieved)(*(base.NativePtr + (IntPtr)FPortalUserIsEntitledToItemResult.__PropertyOffset_RetrievedFromCacheLevel));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPortalUserIsEntitledToItemResult.__PropertyOffset_RetrievedFromCacheLevel) = (byte)value;
			}
		}

		// Token: 0x06024702 RID: 149250 RVA: 0x0035F067 File Offset: 0x0035D267
		public FPortalUserIsEntitledToItemResult()
		{
		}

		// Token: 0x06024703 RID: 149251 RVA: 0x0035F06F File Offset: 0x0035D26F
		public FPortalUserIsEntitledToItemResult(string ItemId, bool IsEntitled, EEntitlementCacheLevelRetrieved RetrievedFromCacheLevel)
		{
			this.ItemId = ItemId;
			this.IsEntitled = IsEntitled;
			this.RetrievedFromCacheLevel = RetrievedFromCacheLevel;
		}

		// Token: 0x06024704 RID: 149252 RVA: 0x0035F08C File Offset: 0x0035D28C
		protected override IntPtr GetUStructPtr()
		{
			return FPortalUserIsEntitledToItemResult.StaticStruct();
		}

		// Token: 0x06024705 RID: 149253 RVA: 0x0035F098 File Offset: 0x0035D298
		[NullableContext(2)]
		public FPortalUserIsEntitledToItemResult(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06024706 RID: 149254 RVA: 0x0035F0A2 File Offset: 0x0035D2A2
		public FPortalUserIsEntitledToItemResult(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06024707 RID: 149255 RVA: 0x0035F0AD File Offset: 0x0035D2AD
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPortalUserIsEntitledToItemResult(Pointer, false, true);
		}

		// Token: 0x06024708 RID: 149256 RVA: 0x0035F0B7 File Offset: 0x0035D2B7
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPortalUserIsEntitledToItemResult(Pointer, MemoryOwner);
		}

		// Token: 0x04013931 RID: 80177
		public const string __ObjectPath = "/Script/PortalServices.PortalUserIsEntitledToItemResult";

		// Token: 0x04013932 RID: 80178
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013933 RID: 80179
		internal static int __PropertyOffset_ItemId;

		// Token: 0x04013934 RID: 80180
		internal static int __PropertyOffset_IsEntitled;

		// Token: 0x04013935 RID: 80181
		internal static int __PropertyOffset_RetrievedFromCacheLevel;
	}
}
