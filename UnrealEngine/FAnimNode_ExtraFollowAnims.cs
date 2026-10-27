using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001608 RID: 5640
	[UnrealObjectPath("/Script/KuroAnim.AnimNode_ExtraFollowAnims")]
	[UnrealStructLayout(3456, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 3456)]
	public class FAnimNode_ExtraFollowAnims : FAnimNode_Base, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06014574 RID: 83316 RVA: 0x001DE378 File Offset: 0x001DC578
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNode_ExtraFollowAnims._ScriptStructPtr != 0) ? FAnimNode_ExtraFollowAnims._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroAnim.AnimNode_ExtraFollowAnims", ref FAnimNode_ExtraFollowAnims._ScriptStructPtr);
		}

		// Token: 0x17004FDC RID: 20444
		// (get) Token: 0x06014575 RID: 83317 RVA: 0x001DE39C File Offset: 0x001DC59C
		// (set) Token: 0x06014576 RID: 83318 RVA: 0x001DE3B0 File Offset: 0x001DC5B0
		public unsafe FName DefaultSequenceName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_ExtraFollowAnims.__PropertyOffset_DefaultSequenceName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_ExtraFollowAnims.__PropertyOffset_DefaultSequenceName) = value;
			}
		}

		// Token: 0x17004FDD RID: 20445
		// (get) Token: 0x06014577 RID: 83319 RVA: 0x001DE3C5 File Offset: 0x001DC5C5
		// (set) Token: 0x06014578 RID: 83320 RVA: 0x001DE3D9 File Offset: 0x001DC5D9
		public unsafe FName SecondaryExtraFollowTableName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_ExtraFollowAnims.__PropertyOffset_SecondaryExtraFollowTableName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_ExtraFollowAnims.__PropertyOffset_SecondaryExtraFollowTableName) = value;
			}
		}

		// Token: 0x17004FDE RID: 20446
		// (get) Token: 0x06014579 RID: 83321 RVA: 0x001DE3EE File Offset: 0x001DC5EE
		// (set) Token: 0x0601457A RID: 83322 RVA: 0x001DE3FE File Offset: 0x001DC5FE
		public unsafe float InternalTimeAccumulator
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_ExtraFollowAnims.__PropertyOffset_InternalTimeAccumulator);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_ExtraFollowAnims.__PropertyOffset_InternalTimeAccumulator) = value;
			}
		}

		// Token: 0x17004FDF RID: 20447
		// (get) Token: 0x0601457B RID: 83323 RVA: 0x001DE40F File Offset: 0x001DC60F
		// (set) Token: 0x0601457C RID: 83324 RVA: 0x001DE41F File Offset: 0x001DC61F
		public unsafe bool bUseAllAnims
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_ExtraFollowAnims.__PropertyOffset_bUseAllAnims) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_ExtraFollowAnims.__PropertyOffset_bUseAllAnims) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601457D RID: 83325 RVA: 0x001DE430 File Offset: 0x001DC630
		public FAnimNode_ExtraFollowAnims()
		{
		}

		// Token: 0x0601457E RID: 83326 RVA: 0x001DE438 File Offset: 0x001DC638
		public FAnimNode_ExtraFollowAnims(FName DefaultSequenceName, FName SecondaryExtraFollowTableName, float InternalTimeAccumulator, bool bUseAllAnims)
		{
			this.DefaultSequenceName = DefaultSequenceName;
			this.SecondaryExtraFollowTableName = SecondaryExtraFollowTableName;
			this.InternalTimeAccumulator = InternalTimeAccumulator;
			this.bUseAllAnims = bUseAllAnims;
		}

		// Token: 0x0601457F RID: 83327 RVA: 0x001DE45D File Offset: 0x001DC65D
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNode_ExtraFollowAnims.StaticStruct();
		}

		// Token: 0x06014580 RID: 83328 RVA: 0x001DE469 File Offset: 0x001DC669
		[NullableContext(2)]
		public FAnimNode_ExtraFollowAnims(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06014581 RID: 83329 RVA: 0x001DE473 File Offset: 0x001DC673
		public FAnimNode_ExtraFollowAnims(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06014582 RID: 83330 RVA: 0x001DE47E File Offset: 0x001DC67E
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNode_ExtraFollowAnims(Pointer, false, true);
		}

		// Token: 0x06014583 RID: 83331 RVA: 0x001DE488 File Offset: 0x001DC688
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNode_ExtraFollowAnims(Pointer, MemoryOwner);
		}

		// Token: 0x0400B11D RID: 45341
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroAnim.AnimNode_ExtraFollowAnims";

		// Token: 0x0400B11E RID: 45342
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400B11F RID: 45343
		internal static int __PropertyOffset_DefaultSequenceName;

		// Token: 0x0400B120 RID: 45344
		internal static int __PropertyOffset_SecondaryExtraFollowTableName;

		// Token: 0x0400B121 RID: 45345
		internal static int __PropertyOffset_InternalTimeAccumulator;

		// Token: 0x0400B122 RID: 45346
		internal static int __PropertyOffset_bUseAllAnims;
	}
}
