using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020008D9 RID: 2265
	[UnrealObjectPath("/Script/Engine.BoneMirrorInfo")]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FBoneMirrorInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06007C88 RID: 31880 RVA: 0x000B2A12 File Offset: 0x000B0C12
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBoneMirrorInfo._ScriptStructPtr != 0) ? FBoneMirrorInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.BoneMirrorInfo", ref FBoneMirrorInfo._ScriptStructPtr);
		}

		// Token: 0x17001D47 RID: 7495
		// (get) Token: 0x06007C89 RID: 31881 RVA: 0x000B2A36 File Offset: 0x000B0C36
		// (set) Token: 0x06007C8A RID: 31882 RVA: 0x000B2A46 File Offset: 0x000B0C46
		public unsafe int SourceIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBoneMirrorInfo.__PropertyOffset_SourceIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBoneMirrorInfo.__PropertyOffset_SourceIndex) = value;
			}
		}

		// Token: 0x17001D48 RID: 7496
		// (get) Token: 0x06007C8B RID: 31883 RVA: 0x000B2A57 File Offset: 0x000B0C57
		// (set) Token: 0x06007C8C RID: 31884 RVA: 0x000B2A6B File Offset: 0x000B0C6B
		public unsafe TEnumAsByte<EAxis> BoneFlipAxis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBoneMirrorInfo.__PropertyOffset_BoneFlipAxis);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBoneMirrorInfo.__PropertyOffset_BoneFlipAxis) = value;
			}
		}

		// Token: 0x06007C8D RID: 31885 RVA: 0x000B2A80 File Offset: 0x000B0C80
		public FBoneMirrorInfo()
		{
		}

		// Token: 0x06007C8E RID: 31886 RVA: 0x000B2A88 File Offset: 0x000B0C88
		public FBoneMirrorInfo(int SourceIndex, TEnumAsByte<EAxis> BoneFlipAxis)
		{
			this.SourceIndex = SourceIndex;
			this.BoneFlipAxis = BoneFlipAxis;
		}

		// Token: 0x06007C8F RID: 31887 RVA: 0x000B2A9E File Offset: 0x000B0C9E
		protected override IntPtr GetUStructPtr()
		{
			return FBoneMirrorInfo.StaticStruct();
		}

		// Token: 0x06007C90 RID: 31888 RVA: 0x000B2AAA File Offset: 0x000B0CAA
		[NullableContext(2)]
		public FBoneMirrorInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007C91 RID: 31889 RVA: 0x000B2AB4 File Offset: 0x000B0CB4
		public FBoneMirrorInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007C92 RID: 31890 RVA: 0x000B2ABF File Offset: 0x000B0CBF
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBoneMirrorInfo(Pointer, false, true);
		}

		// Token: 0x06007C93 RID: 31891 RVA: 0x000B2AC9 File Offset: 0x000B0CC9
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBoneMirrorInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04003BB3 RID: 15283
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.BoneMirrorInfo";

		// Token: 0x04003BB4 RID: 15284
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003BB5 RID: 15285
		internal static int __PropertyOffset_SourceIndex;

		// Token: 0x04003BB6 RID: 15286
		internal static int __PropertyOffset_BoneFlipAxis;
	}
}
