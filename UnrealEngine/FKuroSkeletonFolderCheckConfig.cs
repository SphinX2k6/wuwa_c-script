using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000D0E RID: 3342
	[UnrealObjectPath("/Script/Engine.KuroSkeletonFolderCheckConfig")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FKuroSkeletonFolderCheckConfig : FKuroBaseFolderCheckConfig, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600B2B3 RID: 45747 RVA: 0x000FE77C File Offset: 0x000FC97C
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroSkeletonFolderCheckConfig._ScriptStructPtr != 0) ? FKuroSkeletonFolderCheckConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.KuroSkeletonFolderCheckConfig", ref FKuroSkeletonFolderCheckConfig._ScriptStructPtr);
		}

		// Token: 0x170028B8 RID: 10424
		// (get) Token: 0x0600B2B4 RID: 45748 RVA: 0x000FE7A0 File Offset: 0x000FC9A0
		// (set) Token: 0x0600B2B5 RID: 45749 RVA: 0x000FE7B0 File Offset: 0x000FC9B0
		public unsafe bool UpdateAnimationSeq
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroSkeletonFolderCheckConfig.__PropertyOffset_UpdateAnimationSeq) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroSkeletonFolderCheckConfig.__PropertyOffset_UpdateAnimationSeq) = (value ? 1 : 0);
			}
		}

		// Token: 0x0600B2B6 RID: 45750 RVA: 0x000FE7C1 File Offset: 0x000FC9C1
		public FKuroSkeletonFolderCheckConfig()
		{
		}

		// Token: 0x0600B2B7 RID: 45751 RVA: 0x000FE7C9 File Offset: 0x000FC9C9
		[NullableContext(1)]
		public FKuroSkeletonFolderCheckConfig(bool UpdateAnimationSeq, string Regex, int MatchingPriority)
		{
			this.UpdateAnimationSeq = UpdateAnimationSeq;
			base.Regex = Regex;
			base.MatchingPriority = MatchingPriority;
		}

		// Token: 0x0600B2B8 RID: 45752 RVA: 0x000FE7E6 File Offset: 0x000FC9E6
		protected override IntPtr GetUStructPtr()
		{
			return FKuroSkeletonFolderCheckConfig.StaticStruct();
		}

		// Token: 0x0600B2B9 RID: 45753 RVA: 0x000FE7F2 File Offset: 0x000FC9F2
		[NullableContext(2)]
		public FKuroSkeletonFolderCheckConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600B2BA RID: 45754 RVA: 0x000FE7FC File Offset: 0x000FC9FC
		public FKuroSkeletonFolderCheckConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600B2BB RID: 45755 RVA: 0x000FE807 File Offset: 0x000FCA07
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroSkeletonFolderCheckConfig(Pointer, false, true);
		}

		// Token: 0x0600B2BC RID: 45756 RVA: 0x000FE811 File Offset: 0x000FCA11
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroSkeletonFolderCheckConfig(Pointer, MemoryOwner);
		}

		// Token: 0x04005DCD RID: 24013
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.KuroSkeletonFolderCheckConfig";

		// Token: 0x04005DCE RID: 24014
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04005DCF RID: 24015
		internal static int __PropertyOffset_UpdateAnimationSeq;
	}
}
