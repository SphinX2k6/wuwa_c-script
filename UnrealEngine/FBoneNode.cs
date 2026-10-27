using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020008DA RID: 2266
	[UnrealObjectPath("/Script/Engine.BoneNode")]
	[UnrealStructLayout(20, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 20)]
	public class FBoneNode : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06007C94 RID: 31892 RVA: 0x000B2AD2 File Offset: 0x000B0CD2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBoneNode._ScriptStructPtr != 0) ? FBoneNode._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.BoneNode", ref FBoneNode._ScriptStructPtr);
		}

		// Token: 0x17001D49 RID: 7497
		// (get) Token: 0x06007C95 RID: 31893 RVA: 0x000B2AF6 File Offset: 0x000B0CF6
		// (set) Token: 0x06007C96 RID: 31894 RVA: 0x000B2B0A File Offset: 0x000B0D0A
		public unsafe FName Name_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBoneNode.__PropertyOffset_Name_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBoneNode.__PropertyOffset_Name_DEPRECATED) = value;
			}
		}

		// Token: 0x17001D4A RID: 7498
		// (get) Token: 0x06007C97 RID: 31895 RVA: 0x000B2B1F File Offset: 0x000B0D1F
		// (set) Token: 0x06007C98 RID: 31896 RVA: 0x000B2B2F File Offset: 0x000B0D2F
		public unsafe int ParentIndex_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBoneNode.__PropertyOffset_ParentIndex_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBoneNode.__PropertyOffset_ParentIndex_DEPRECATED) = value;
			}
		}

		// Token: 0x17001D4B RID: 7499
		// (get) Token: 0x06007C99 RID: 31897 RVA: 0x000B2B40 File Offset: 0x000B0D40
		// (set) Token: 0x06007C9A RID: 31898 RVA: 0x000B2B54 File Offset: 0x000B0D54
		public unsafe TEnumAsByte<EBoneTranslationRetargetingMode> TranslationRetargetingMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBoneNode.__PropertyOffset_TranslationRetargetingMode);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBoneNode.__PropertyOffset_TranslationRetargetingMode) = value;
			}
		}

		// Token: 0x17001D4C RID: 7500
		// (get) Token: 0x06007C9B RID: 31899 RVA: 0x000B2B69 File Offset: 0x000B0D69
		// (set) Token: 0x06007C9C RID: 31900 RVA: 0x000B2B7D File Offset: 0x000B0D7D
		public unsafe TEnumAsByte<EScaleInheritMode> ScaleInheritMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBoneNode.__PropertyOffset_ScaleInheritMode);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBoneNode.__PropertyOffset_ScaleInheritMode) = value;
			}
		}

		// Token: 0x06007C9D RID: 31901 RVA: 0x000B2B92 File Offset: 0x000B0D92
		public FBoneNode()
		{
		}

		// Token: 0x06007C9E RID: 31902 RVA: 0x000B2B9A File Offset: 0x000B0D9A
		public FBoneNode(FName Name_DEPRECATED, int ParentIndex_DEPRECATED, TEnumAsByte<EBoneTranslationRetargetingMode> TranslationRetargetingMode, TEnumAsByte<EScaleInheritMode> ScaleInheritMode)
		{
			this.Name_DEPRECATED = Name_DEPRECATED;
			this.ParentIndex_DEPRECATED = ParentIndex_DEPRECATED;
			this.TranslationRetargetingMode = TranslationRetargetingMode;
			this.ScaleInheritMode = ScaleInheritMode;
		}

		// Token: 0x06007C9F RID: 31903 RVA: 0x000B2BBF File Offset: 0x000B0DBF
		protected override IntPtr GetUStructPtr()
		{
			return FBoneNode.StaticStruct();
		}

		// Token: 0x06007CA0 RID: 31904 RVA: 0x000B2BCB File Offset: 0x000B0DCB
		[NullableContext(2)]
		public FBoneNode(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007CA1 RID: 31905 RVA: 0x000B2BD5 File Offset: 0x000B0DD5
		public FBoneNode(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007CA2 RID: 31906 RVA: 0x000B2BE0 File Offset: 0x000B0DE0
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBoneNode(Pointer, false, true);
		}

		// Token: 0x06007CA3 RID: 31907 RVA: 0x000B2BEA File Offset: 0x000B0DEA
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBoneNode(Pointer, MemoryOwner);
		}

		// Token: 0x04003BB7 RID: 15287
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.BoneNode";

		// Token: 0x04003BB8 RID: 15288
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003BB9 RID: 15289
		internal static int __PropertyOffset_Name_DEPRECATED;

		// Token: 0x04003BBA RID: 15290
		internal static int __PropertyOffset_ParentIndex_DEPRECATED;

		// Token: 0x04003BBB RID: 15291
		internal static int __PropertyOffset_TranslationRetargetingMode;

		// Token: 0x04003BBC RID: 15292
		internal static int __PropertyOffset_ScaleInheritMode;
	}
}
