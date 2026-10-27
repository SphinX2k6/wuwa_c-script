using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001676 RID: 5750
	[UnrealObjectPath("/Script/KuroAnim.LeanAmount")]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FLeanAmount : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06014DC7 RID: 85447 RVA: 0x001EAC4D File Offset: 0x001E8E4D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLeanAmount._ScriptStructPtr != 0) ? FLeanAmount._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroAnim.LeanAmount", ref FLeanAmount._ScriptStructPtr);
		}

		// Token: 0x170052A2 RID: 21154
		// (get) Token: 0x06014DC8 RID: 85448 RVA: 0x001EAC71 File Offset: 0x001E8E71
		// (set) Token: 0x06014DC9 RID: 85449 RVA: 0x001EAC81 File Offset: 0x001E8E81
		public unsafe float ForwardAndBackward
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLeanAmount.__PropertyOffset_ForwardAndBackward);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLeanAmount.__PropertyOffset_ForwardAndBackward) = value;
			}
		}

		// Token: 0x170052A3 RID: 21155
		// (get) Token: 0x06014DCA RID: 85450 RVA: 0x001EAC92 File Offset: 0x001E8E92
		// (set) Token: 0x06014DCB RID: 85451 RVA: 0x001EACA2 File Offset: 0x001E8EA2
		public unsafe float LeftAndRight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLeanAmount.__PropertyOffset_LeftAndRight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLeanAmount.__PropertyOffset_LeftAndRight) = value;
			}
		}

		// Token: 0x06014DCC RID: 85452 RVA: 0x001EACB3 File Offset: 0x001E8EB3
		public FLeanAmount()
		{
		}

		// Token: 0x06014DCD RID: 85453 RVA: 0x001EACBB File Offset: 0x001E8EBB
		public FLeanAmount(float ForwardAndBackward, float LeftAndRight)
		{
			this.ForwardAndBackward = ForwardAndBackward;
			this.LeftAndRight = LeftAndRight;
		}

		// Token: 0x06014DCE RID: 85454 RVA: 0x001EACD1 File Offset: 0x001E8ED1
		protected override IntPtr GetUStructPtr()
		{
			return FLeanAmount.StaticStruct();
		}

		// Token: 0x06014DCF RID: 85455 RVA: 0x001EACDD File Offset: 0x001E8EDD
		[NullableContext(2)]
		public FLeanAmount(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06014DD0 RID: 85456 RVA: 0x001EACE7 File Offset: 0x001E8EE7
		public FLeanAmount(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06014DD1 RID: 85457 RVA: 0x001EACF2 File Offset: 0x001E8EF2
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLeanAmount(Pointer, false, true);
		}

		// Token: 0x06014DD2 RID: 85458 RVA: 0x001EACFC File Offset: 0x001E8EFC
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLeanAmount(Pointer, MemoryOwner);
		}

		// Token: 0x0400B5E7 RID: 46567
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroAnim.LeanAmount";

		// Token: 0x0400B5E8 RID: 46568
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400B5E9 RID: 46569
		internal static int __PropertyOffset_ForwardAndBackward;

		// Token: 0x0400B5EA RID: 46570
		internal static int __PropertyOffset_LeftAndRight;
	}
}
