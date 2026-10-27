using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002A99 RID: 10905
	[UnrealObjectPath("/Script/WwiseSimpleExternalSource.WwiseExternalSourceMediaInfo")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FWwiseExternalSourceMediaInfo : FTableRowBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06028320 RID: 164640 RVA: 0x003D2627 File Offset: 0x003D0827
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FWwiseExternalSourceMediaInfo._ScriptStructPtr != 0) ? FWwiseExternalSourceMediaInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/WwiseSimpleExternalSource.WwiseExternalSourceMediaInfo", ref FWwiseExternalSourceMediaInfo._ScriptStructPtr);
		}

		// Token: 0x17009959 RID: 39257
		// (get) Token: 0x06028321 RID: 164641 RVA: 0x003D264B File Offset: 0x003D084B
		// (set) Token: 0x06028322 RID: 164642 RVA: 0x003D265B File Offset: 0x003D085B
		public unsafe int ExternalSourceMediaInfoId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWwiseExternalSourceMediaInfo.__PropertyOffset_ExternalSourceMediaInfoId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWwiseExternalSourceMediaInfo.__PropertyOffset_ExternalSourceMediaInfoId) = value;
			}
		}

		// Token: 0x1700995A RID: 39258
		// (get) Token: 0x06028323 RID: 164643 RVA: 0x003D266C File Offset: 0x003D086C
		// (set) Token: 0x06028324 RID: 164644 RVA: 0x003D2680 File Offset: 0x003D0880
		public unsafe FName MediaName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWwiseExternalSourceMediaInfo.__PropertyOffset_MediaName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWwiseExternalSourceMediaInfo.__PropertyOffset_MediaName) = value;
			}
		}

		// Token: 0x1700995B RID: 39259
		// (get) Token: 0x06028325 RID: 164645 RVA: 0x003D2695 File Offset: 0x003D0895
		// (set) Token: 0x06028326 RID: 164646 RVA: 0x003D26A5 File Offset: 0x003D08A5
		public unsafe int CodecID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWwiseExternalSourceMediaInfo.__PropertyOffset_CodecID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWwiseExternalSourceMediaInfo.__PropertyOffset_CodecID) = value;
			}
		}

		// Token: 0x1700995C RID: 39260
		// (get) Token: 0x06028327 RID: 164647 RVA: 0x003D26B6 File Offset: 0x003D08B6
		// (set) Token: 0x06028328 RID: 164648 RVA: 0x003D26C6 File Offset: 0x003D08C6
		public unsafe bool bIsStreamed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWwiseExternalSourceMediaInfo.__PropertyOffset_bIsStreamed) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWwiseExternalSourceMediaInfo.__PropertyOffset_bIsStreamed) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700995D RID: 39261
		// (get) Token: 0x06028329 RID: 164649 RVA: 0x003D26D7 File Offset: 0x003D08D7
		// (set) Token: 0x0602832A RID: 164650 RVA: 0x003D26E7 File Offset: 0x003D08E7
		public unsafe bool bUseDeviceMemory
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWwiseExternalSourceMediaInfo.__PropertyOffset_bUseDeviceMemory) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWwiseExternalSourceMediaInfo.__PropertyOffset_bUseDeviceMemory) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700995E RID: 39262
		// (get) Token: 0x0602832B RID: 164651 RVA: 0x003D26F8 File Offset: 0x003D08F8
		// (set) Token: 0x0602832C RID: 164652 RVA: 0x003D2708 File Offset: 0x003D0908
		public unsafe int MemoryAlignment
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWwiseExternalSourceMediaInfo.__PropertyOffset_MemoryAlignment);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWwiseExternalSourceMediaInfo.__PropertyOffset_MemoryAlignment) = value;
			}
		}

		// Token: 0x1700995F RID: 39263
		// (get) Token: 0x0602832D RID: 164653 RVA: 0x003D2719 File Offset: 0x003D0919
		// (set) Token: 0x0602832E RID: 164654 RVA: 0x003D2729 File Offset: 0x003D0929
		public unsafe int PrefetchSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWwiseExternalSourceMediaInfo.__PropertyOffset_PrefetchSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWwiseExternalSourceMediaInfo.__PropertyOffset_PrefetchSize) = value;
			}
		}

		// Token: 0x0602832F RID: 164655 RVA: 0x003D273A File Offset: 0x003D093A
		public FWwiseExternalSourceMediaInfo()
		{
		}

		// Token: 0x06028330 RID: 164656 RVA: 0x003D2742 File Offset: 0x003D0942
		public FWwiseExternalSourceMediaInfo(int ExternalSourceMediaInfoId, FName MediaName, int CodecID, bool bIsStreamed, bool bUseDeviceMemory, int MemoryAlignment, int PrefetchSize)
		{
			this.ExternalSourceMediaInfoId = ExternalSourceMediaInfoId;
			this.MediaName = MediaName;
			this.CodecID = CodecID;
			this.bIsStreamed = bIsStreamed;
			this.bUseDeviceMemory = bUseDeviceMemory;
			this.MemoryAlignment = MemoryAlignment;
			this.PrefetchSize = PrefetchSize;
		}

		// Token: 0x06028331 RID: 164657 RVA: 0x003D277F File Offset: 0x003D097F
		protected override IntPtr GetUStructPtr()
		{
			return FWwiseExternalSourceMediaInfo.StaticStruct();
		}

		// Token: 0x06028332 RID: 164658 RVA: 0x003D278B File Offset: 0x003D098B
		[NullableContext(2)]
		public FWwiseExternalSourceMediaInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06028333 RID: 164659 RVA: 0x003D2795 File Offset: 0x003D0995
		public FWwiseExternalSourceMediaInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06028334 RID: 164660 RVA: 0x003D27A0 File Offset: 0x003D09A0
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FWwiseExternalSourceMediaInfo(Pointer, false, true);
		}

		// Token: 0x06028335 RID: 164661 RVA: 0x003D27AA File Offset: 0x003D09AA
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FWwiseExternalSourceMediaInfo(Pointer, MemoryOwner);
		}

		// Token: 0x040160A7 RID: 90279
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/WwiseSimpleExternalSource.WwiseExternalSourceMediaInfo";

		// Token: 0x040160A8 RID: 90280
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040160A9 RID: 90281
		internal static int __PropertyOffset_ExternalSourceMediaInfoId;

		// Token: 0x040160AA RID: 90282
		internal static int __PropertyOffset_MediaName;

		// Token: 0x040160AB RID: 90283
		internal static int __PropertyOffset_CodecID;

		// Token: 0x040160AC RID: 90284
		internal static int __PropertyOffset_bIsStreamed;

		// Token: 0x040160AD RID: 90285
		internal static int __PropertyOffset_bUseDeviceMemory;

		// Token: 0x040160AE RID: 90286
		internal static int __PropertyOffset_MemoryAlignment;

		// Token: 0x040160AF RID: 90287
		internal static int __PropertyOffset_PrefetchSize;
	}
}
