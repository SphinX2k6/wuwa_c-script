using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020011AF RID: 4527
	[UnrealObjectPath("/Script/Engine.StreamingTextureBuildInfo")]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 12)]
	public class FStreamingTextureBuildInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06010B25 RID: 68389 RVA: 0x00188502 File Offset: 0x00186702
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FStreamingTextureBuildInfo._ScriptStructPtr != 0) ? FStreamingTextureBuildInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.StreamingTextureBuildInfo", ref FStreamingTextureBuildInfo._ScriptStructPtr);
		}

		// Token: 0x1700413A RID: 16698
		// (get) Token: 0x06010B26 RID: 68390 RVA: 0x00188526 File Offset: 0x00186726
		// (set) Token: 0x06010B27 RID: 68391 RVA: 0x00188536 File Offset: 0x00186736
		public unsafe uint PackedRelativeBox
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FStreamingTextureBuildInfo.__PropertyOffset_PackedRelativeBox);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FStreamingTextureBuildInfo.__PropertyOffset_PackedRelativeBox) = (int)value;
			}
		}

		// Token: 0x1700413B RID: 16699
		// (get) Token: 0x06010B28 RID: 68392 RVA: 0x00188547 File Offset: 0x00186747
		// (set) Token: 0x06010B29 RID: 68393 RVA: 0x00188557 File Offset: 0x00186757
		public unsafe int TextureLevelIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FStreamingTextureBuildInfo.__PropertyOffset_TextureLevelIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FStreamingTextureBuildInfo.__PropertyOffset_TextureLevelIndex) = value;
			}
		}

		// Token: 0x1700413C RID: 16700
		// (get) Token: 0x06010B2A RID: 68394 RVA: 0x00188568 File Offset: 0x00186768
		// (set) Token: 0x06010B2B RID: 68395 RVA: 0x00188578 File Offset: 0x00186778
		public unsafe float TexelFactor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FStreamingTextureBuildInfo.__PropertyOffset_TexelFactor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FStreamingTextureBuildInfo.__PropertyOffset_TexelFactor) = value;
			}
		}

		// Token: 0x06010B2C RID: 68396 RVA: 0x00188589 File Offset: 0x00186789
		public FStreamingTextureBuildInfo()
		{
		}

		// Token: 0x06010B2D RID: 68397 RVA: 0x00188591 File Offset: 0x00186791
		public FStreamingTextureBuildInfo(uint PackedRelativeBox, int TextureLevelIndex, float TexelFactor)
		{
			this.PackedRelativeBox = PackedRelativeBox;
			this.TextureLevelIndex = TextureLevelIndex;
			this.TexelFactor = TexelFactor;
		}

		// Token: 0x06010B2E RID: 68398 RVA: 0x001885AE File Offset: 0x001867AE
		protected override IntPtr GetUStructPtr()
		{
			return FStreamingTextureBuildInfo.StaticStruct();
		}

		// Token: 0x06010B2F RID: 68399 RVA: 0x001885BA File Offset: 0x001867BA
		[NullableContext(2)]
		public FStreamingTextureBuildInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06010B30 RID: 68400 RVA: 0x001885C4 File Offset: 0x001867C4
		public FStreamingTextureBuildInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06010B31 RID: 68401 RVA: 0x001885CF File Offset: 0x001867CF
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FStreamingTextureBuildInfo(Pointer, false, true);
		}

		// Token: 0x06010B32 RID: 68402 RVA: 0x001885D9 File Offset: 0x001867D9
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FStreamingTextureBuildInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04008EE0 RID: 36576
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.StreamingTextureBuildInfo";

		// Token: 0x04008EE1 RID: 36577
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04008EE2 RID: 36578
		internal static int __PropertyOffset_PackedRelativeBox;

		// Token: 0x04008EE3 RID: 36579
		internal static int __PropertyOffset_TextureLevelIndex;

		// Token: 0x04008EE4 RID: 36580
		internal static int __PropertyOffset_TexelFactor;
	}
}
