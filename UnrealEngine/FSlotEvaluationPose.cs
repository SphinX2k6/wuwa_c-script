using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200111A RID: 4378
	[UnrealObjectPath("/Script/Engine.SlotEvaluationPose")]
	[UnrealStructLayout(336, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 336)]
	public class FSlotEvaluationPose : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600FFEC RID: 65516 RVA: 0x00178ED2 File Offset: 0x001770D2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSlotEvaluationPose._ScriptStructPtr != 0) ? FSlotEvaluationPose._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.SlotEvaluationPose", ref FSlotEvaluationPose._ScriptStructPtr);
		}

		// Token: 0x17003E76 RID: 15990
		// (get) Token: 0x0600FFED RID: 65517 RVA: 0x00178EF6 File Offset: 0x001770F6
		// (set) Token: 0x0600FFEE RID: 65518 RVA: 0x00178F0A File Offset: 0x0017710A
		public unsafe TEnumAsByte<EAdditiveAnimationType> AdditiveType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSlotEvaluationPose.__PropertyOffset_AdditiveType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSlotEvaluationPose.__PropertyOffset_AdditiveType) = value;
			}
		}

		// Token: 0x17003E77 RID: 15991
		// (get) Token: 0x0600FFEF RID: 65519 RVA: 0x00178F1F File Offset: 0x0017711F
		// (set) Token: 0x0600FFF0 RID: 65520 RVA: 0x00178F2F File Offset: 0x0017712F
		public unsafe float Weight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSlotEvaluationPose.__PropertyOffset_Weight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSlotEvaluationPose.__PropertyOffset_Weight) = value;
			}
		}

		// Token: 0x0600FFF1 RID: 65521 RVA: 0x00178F40 File Offset: 0x00177140
		public FSlotEvaluationPose()
		{
		}

		// Token: 0x0600FFF2 RID: 65522 RVA: 0x00178F48 File Offset: 0x00177148
		public FSlotEvaluationPose(TEnumAsByte<EAdditiveAnimationType> AdditiveType, float Weight)
		{
			this.AdditiveType = AdditiveType;
			this.Weight = Weight;
		}

		// Token: 0x0600FFF3 RID: 65523 RVA: 0x00178F5E File Offset: 0x0017715E
		protected override IntPtr GetUStructPtr()
		{
			return FSlotEvaluationPose.StaticStruct();
		}

		// Token: 0x0600FFF4 RID: 65524 RVA: 0x00178F6A File Offset: 0x0017716A
		[NullableContext(2)]
		public FSlotEvaluationPose(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600FFF5 RID: 65525 RVA: 0x00178F74 File Offset: 0x00177174
		public FSlotEvaluationPose(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600FFF6 RID: 65526 RVA: 0x00178F7F File Offset: 0x0017717F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSlotEvaluationPose(Pointer, false, true);
		}

		// Token: 0x0600FFF7 RID: 65527 RVA: 0x00178F89 File Offset: 0x00177189
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSlotEvaluationPose(Pointer, MemoryOwner);
		}

		// Token: 0x04008987 RID: 35207
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.SlotEvaluationPose";

		// Token: 0x04008988 RID: 35208
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04008989 RID: 35209
		internal static int __PropertyOffset_AdditiveType;

		// Token: 0x0400898A RID: 35210
		internal static int __PropertyOffset_Weight;
	}
}
