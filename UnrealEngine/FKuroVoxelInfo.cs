using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200063A RID: 1594
	[UnrealObjectPath("/Script/KuroVoxelRuntime.KuroVoxelInfo")]
	[UnrealStructLayout(2, 1, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 2)]
	public class FKuroVoxelInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06008BC6 RID: 35782 RVA: 0x000D2559 File Offset: 0x000D0759
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroVoxelInfo._ScriptStructPtr != 0) ? FKuroVoxelInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroVoxelRuntime.KuroVoxelInfo", ref FKuroVoxelInfo._ScriptStructPtr);
		}

		// Token: 0x17001A59 RID: 6745
		// (get) Token: 0x06008BC7 RID: 35783 RVA: 0x000D257D File Offset: 0x000D077D
		// (set) Token: 0x06008BC8 RID: 35784 RVA: 0x000D258D File Offset: 0x000D078D
		public unsafe byte MtlID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroVoxelInfo.__PropertyOffset_MtlID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroVoxelInfo.__PropertyOffset_MtlID) = value;
			}
		}

		// Token: 0x17001A5A RID: 6746
		// (get) Token: 0x06008BC9 RID: 35785 RVA: 0x000D259E File Offset: 0x000D079E
		// (set) Token: 0x06008BCA RID: 35786 RVA: 0x000D25AE File Offset: 0x000D07AE
		public unsafe byte EnvType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroVoxelInfo.__PropertyOffset_EnvType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroVoxelInfo.__PropertyOffset_EnvType) = value;
			}
		}

		// Token: 0x06008BCB RID: 35787 RVA: 0x000D25BF File Offset: 0x000D07BF
		public FKuroVoxelInfo()
		{
		}

		// Token: 0x06008BCC RID: 35788 RVA: 0x000D25C7 File Offset: 0x000D07C7
		protected override IntPtr GetUStructPtr()
		{
			return FKuroVoxelInfo.StaticStruct();
		}

		// Token: 0x06008BCD RID: 35789 RVA: 0x000D25D3 File Offset: 0x000D07D3
		[NullableContext(2)]
		public FKuroVoxelInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008BCE RID: 35790 RVA: 0x000D25DD File Offset: 0x000D07DD
		public FKuroVoxelInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008BCF RID: 35791 RVA: 0x000D25E8 File Offset: 0x000D07E8
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroVoxelInfo(Pointer, false, true);
		}

		// Token: 0x06008BD0 RID: 35792 RVA: 0x000D25F2 File Offset: 0x000D07F2
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroVoxelInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04003CC6 RID: 15558
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroVoxelRuntime.KuroVoxelInfo";

		// Token: 0x04003CC7 RID: 15559
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003CC8 RID: 15560
		internal static int __PropertyOffset_MtlID;

		// Token: 0x04003CC9 RID: 15561
		internal static int __PropertyOffset_EnvType;
	}
}
