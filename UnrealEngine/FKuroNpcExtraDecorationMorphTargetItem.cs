using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001B81 RID: 7041
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroNpcExtraDecorationMorphTargetItem")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FKuroNpcExtraDecorationMorphTargetItem : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601AB79 RID: 109433 RVA: 0x00275DEA File Offset: 0x00273FEA
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroNpcExtraDecorationMorphTargetItem._ScriptStructPtr != 0) ? FKuroNpcExtraDecorationMorphTargetItem._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroNpcExtraDecorationMorphTargetItem", ref FKuroNpcExtraDecorationMorphTargetItem._ScriptStructPtr);
		}

		// Token: 0x17006B74 RID: 27508
		// (get) Token: 0x0601AB7A RID: 109434 RVA: 0x00275E0E File Offset: 0x0027400E
		// (set) Token: 0x0601AB7B RID: 109435 RVA: 0x00275E22 File Offset: 0x00274022
		public unsafe FName MorphTargetName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroNpcExtraDecorationMorphTargetItem.__PropertyOffset_MorphTargetName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroNpcExtraDecorationMorphTargetItem.__PropertyOffset_MorphTargetName) = value;
			}
		}

		// Token: 0x17006B75 RID: 27509
		// (get) Token: 0x0601AB7C RID: 109436 RVA: 0x00275E37 File Offset: 0x00274037
		// (set) Token: 0x0601AB7D RID: 109437 RVA: 0x00275E47 File Offset: 0x00274047
		public unsafe float MorphTargetValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroNpcExtraDecorationMorphTargetItem.__PropertyOffset_MorphTargetValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroNpcExtraDecorationMorphTargetItem.__PropertyOffset_MorphTargetValue) = value;
			}
		}

		// Token: 0x0601AB7E RID: 109438 RVA: 0x00275E58 File Offset: 0x00274058
		public FKuroNpcExtraDecorationMorphTargetItem()
		{
		}

		// Token: 0x0601AB7F RID: 109439 RVA: 0x00275E60 File Offset: 0x00274060
		public FKuroNpcExtraDecorationMorphTargetItem(FName MorphTargetName, float MorphTargetValue)
		{
			this.MorphTargetName = MorphTargetName;
			this.MorphTargetValue = MorphTargetValue;
		}

		// Token: 0x0601AB80 RID: 109440 RVA: 0x00275E76 File Offset: 0x00274076
		protected override IntPtr GetUStructPtr()
		{
			return FKuroNpcExtraDecorationMorphTargetItem.StaticStruct();
		}

		// Token: 0x0601AB81 RID: 109441 RVA: 0x00275E82 File Offset: 0x00274082
		[NullableContext(2)]
		public FKuroNpcExtraDecorationMorphTargetItem(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601AB82 RID: 109442 RVA: 0x00275E8C File Offset: 0x0027408C
		public FKuroNpcExtraDecorationMorphTargetItem(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601AB83 RID: 109443 RVA: 0x00275E97 File Offset: 0x00274097
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroNpcExtraDecorationMorphTargetItem(Pointer, false, true);
		}

		// Token: 0x0601AB84 RID: 109444 RVA: 0x00275EA1 File Offset: 0x002740A1
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroNpcExtraDecorationMorphTargetItem(Pointer, MemoryOwner);
		}

		// Token: 0x0400E741 RID: 59201
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroNpcExtraDecorationMorphTargetItem";

		// Token: 0x0400E742 RID: 59202
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400E743 RID: 59203
		internal static int __PropertyOffset_MorphTargetName;

		// Token: 0x0400E744 RID: 59204
		internal static int __PropertyOffset_MorphTargetValue;
	}
}
