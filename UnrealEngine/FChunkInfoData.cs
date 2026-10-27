using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000431 RID: 1073
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/BuildPatchServices.ChunkInfoData")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FChunkInfoData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060039AB RID: 14763 RVA: 0x0005776E File Offset: 0x0005596E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FChunkInfoData._ScriptStructPtr != 0) ? FChunkInfoData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/BuildPatchServices.ChunkInfoData", ref FChunkInfoData._ScriptStructPtr);
		}

		// Token: 0x17000DB8 RID: 3512
		// (get) Token: 0x060039AC RID: 14764 RVA: 0x00057792 File Offset: 0x00055992
		// (set) Token: 0x060039AD RID: 14765 RVA: 0x000577A6 File Offset: 0x000559A6
		public unsafe FGuid Guid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FChunkInfoData.__PropertyOffset_Guid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FChunkInfoData.__PropertyOffset_Guid) = value;
			}
		}

		// Token: 0x17000DB9 RID: 3513
		// (get) Token: 0x060039AE RID: 14766 RVA: 0x000577BB File Offset: 0x000559BB
		// (set) Token: 0x060039AF RID: 14767 RVA: 0x000577CB File Offset: 0x000559CB
		public unsafe ulong Hash
		{
			get
			{
				return (ulong)(*(base.NativePtr + (IntPtr)FChunkInfoData.__PropertyOffset_Hash));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FChunkInfoData.__PropertyOffset_Hash) = (long)value;
			}
		}

		// Token: 0x17000DBA RID: 3514
		// (get) Token: 0x060039B0 RID: 14768 RVA: 0x000577DC File Offset: 0x000559DC
		// (set) Token: 0x060039B1 RID: 14769 RVA: 0x0005781F File Offset: 0x00055A1F
		public FSHAHashData ShaHash
		{
			get
			{
				base.FastCheckIsValid();
				FSHAHashData result;
				if ((result = this._ShaHash) == null)
				{
					result = (this._ShaHash = new FSHAHashData(base.NativePtr + (IntPtr)FChunkInfoData.__PropertyOffset_ShaHash, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSHAHashData.StaticStruct(), base.NativePtr + (IntPtr)FChunkInfoData.__PropertyOffset_ShaHash, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000DBB RID: 3515
		// (get) Token: 0x060039B2 RID: 14770 RVA: 0x00057840 File Offset: 0x00055A40
		// (set) Token: 0x060039B3 RID: 14771 RVA: 0x00057850 File Offset: 0x00055A50
		public unsafe long FileSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FChunkInfoData.__PropertyOffset_FileSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FChunkInfoData.__PropertyOffset_FileSize) = value;
			}
		}

		// Token: 0x17000DBC RID: 3516
		// (get) Token: 0x060039B4 RID: 14772 RVA: 0x00057861 File Offset: 0x00055A61
		// (set) Token: 0x060039B5 RID: 14773 RVA: 0x00057871 File Offset: 0x00055A71
		public unsafe byte GroupNumber
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FChunkInfoData.__PropertyOffset_GroupNumber);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FChunkInfoData.__PropertyOffset_GroupNumber) = value;
			}
		}

		// Token: 0x060039B6 RID: 14774 RVA: 0x00057882 File Offset: 0x00055A82
		public FChunkInfoData()
		{
		}

		// Token: 0x060039B7 RID: 14775 RVA: 0x0005788A File Offset: 0x00055A8A
		public FChunkInfoData(FGuid Guid, ulong Hash, FSHAHashData ShaHash, long FileSize, byte GroupNumber)
		{
			this.Guid = Guid;
			this.Hash = Hash;
			this.ShaHash = ShaHash;
			this.FileSize = FileSize;
			this.GroupNumber = GroupNumber;
		}

		// Token: 0x060039B8 RID: 14776 RVA: 0x000578B7 File Offset: 0x00055AB7
		protected override IntPtr GetUStructPtr()
		{
			return FChunkInfoData.StaticStruct();
		}

		// Token: 0x060039B9 RID: 14777 RVA: 0x000578C3 File Offset: 0x00055AC3
		[NullableContext(2)]
		public FChunkInfoData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060039BA RID: 14778 RVA: 0x000578CD File Offset: 0x00055ACD
		public FChunkInfoData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060039BB RID: 14779 RVA: 0x000578D8 File Offset: 0x00055AD8
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FChunkInfoData(Pointer, false, true);
		}

		// Token: 0x060039BC RID: 14780 RVA: 0x000578E2 File Offset: 0x00055AE2
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FChunkInfoData(Pointer, MemoryOwner);
		}

		// Token: 0x04001A4A RID: 6730
		public const string __ObjectPath = "/Script/BuildPatchServices.ChunkInfoData";

		// Token: 0x04001A4B RID: 6731
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001A4C RID: 6732
		internal static int __PropertyOffset_Guid;

		// Token: 0x04001A4D RID: 6733
		internal static int __PropertyOffset_Hash;

		// Token: 0x04001A4E RID: 6734
		internal static int __PropertyOffset_ShaHash;

		// Token: 0x04001A4F RID: 6735
		[Nullable(2)]
		private FSHAHashData _ShaHash;

		// Token: 0x04001A50 RID: 6736
		internal static int __PropertyOffset_FileSize;

		// Token: 0x04001A51 RID: 6737
		internal static int __PropertyOffset_GroupNumber;
	}
}
