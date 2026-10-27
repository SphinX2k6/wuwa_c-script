using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020008D8 RID: 2264
	[UnrealObjectPath("/Script/Engine.BoneMirrorExport")]
	[UnrealStructLayout(28, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 28)]
	public class FBoneMirrorExport : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06007C7A RID: 31866 RVA: 0x000B291A File Offset: 0x000B0B1A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBoneMirrorExport._ScriptStructPtr != 0) ? FBoneMirrorExport._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.BoneMirrorExport", ref FBoneMirrorExport._ScriptStructPtr);
		}

		// Token: 0x17001D44 RID: 7492
		// (get) Token: 0x06007C7B RID: 31867 RVA: 0x000B293E File Offset: 0x000B0B3E
		// (set) Token: 0x06007C7C RID: 31868 RVA: 0x000B2952 File Offset: 0x000B0B52
		public unsafe FName BoneName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBoneMirrorExport.__PropertyOffset_BoneName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBoneMirrorExport.__PropertyOffset_BoneName) = value;
			}
		}

		// Token: 0x17001D45 RID: 7493
		// (get) Token: 0x06007C7D RID: 31869 RVA: 0x000B2967 File Offset: 0x000B0B67
		// (set) Token: 0x06007C7E RID: 31870 RVA: 0x000B297B File Offset: 0x000B0B7B
		public unsafe FName SourceBoneName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBoneMirrorExport.__PropertyOffset_SourceBoneName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBoneMirrorExport.__PropertyOffset_SourceBoneName) = value;
			}
		}

		// Token: 0x17001D46 RID: 7494
		// (get) Token: 0x06007C7F RID: 31871 RVA: 0x000B2990 File Offset: 0x000B0B90
		// (set) Token: 0x06007C80 RID: 31872 RVA: 0x000B29A4 File Offset: 0x000B0BA4
		public unsafe TEnumAsByte<EAxis> BoneFlipAxis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBoneMirrorExport.__PropertyOffset_BoneFlipAxis);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBoneMirrorExport.__PropertyOffset_BoneFlipAxis) = value;
			}
		}

		// Token: 0x06007C81 RID: 31873 RVA: 0x000B29B9 File Offset: 0x000B0BB9
		public FBoneMirrorExport()
		{
		}

		// Token: 0x06007C82 RID: 31874 RVA: 0x000B29C1 File Offset: 0x000B0BC1
		public FBoneMirrorExport(FName BoneName, FName SourceBoneName, TEnumAsByte<EAxis> BoneFlipAxis)
		{
			this.BoneName = BoneName;
			this.SourceBoneName = SourceBoneName;
			this.BoneFlipAxis = BoneFlipAxis;
		}

		// Token: 0x06007C83 RID: 31875 RVA: 0x000B29DE File Offset: 0x000B0BDE
		protected override IntPtr GetUStructPtr()
		{
			return FBoneMirrorExport.StaticStruct();
		}

		// Token: 0x06007C84 RID: 31876 RVA: 0x000B29EA File Offset: 0x000B0BEA
		[NullableContext(2)]
		public FBoneMirrorExport(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007C85 RID: 31877 RVA: 0x000B29F4 File Offset: 0x000B0BF4
		public FBoneMirrorExport(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007C86 RID: 31878 RVA: 0x000B29FF File Offset: 0x000B0BFF
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBoneMirrorExport(Pointer, false, true);
		}

		// Token: 0x06007C87 RID: 31879 RVA: 0x000B2A09 File Offset: 0x000B0C09
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBoneMirrorExport(Pointer, MemoryOwner);
		}

		// Token: 0x04003BAE RID: 15278
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.BoneMirrorExport";

		// Token: 0x04003BAF RID: 15279
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003BB0 RID: 15280
		internal static int __PropertyOffset_BoneName;

		// Token: 0x04003BB1 RID: 15281
		internal static int __PropertyOffset_SourceBoneName;

		// Token: 0x04003BB2 RID: 15282
		internal static int __PropertyOffset_BoneFlipAxis;
	}
}
