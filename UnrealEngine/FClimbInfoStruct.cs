using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200162E RID: 5678
	[UnrealObjectPath("/Script/KuroAnim.ClimbInfoStruct")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FClimbInfoStruct : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060148BC RID: 84156 RVA: 0x001E39BB File Offset: 0x001E1BBB
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FClimbInfoStruct._ScriptStructPtr != 0) ? FClimbInfoStruct._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroAnim.ClimbInfoStruct", ref FClimbInfoStruct._ScriptStructPtr);
		}

		// Token: 0x170050E8 RID: 20712
		// (get) Token: 0x060148BD RID: 84157 RVA: 0x001E39DF File Offset: 0x001E1BDF
		// (set) Token: 0x060148BE RID: 84158 RVA: 0x001E39EF File Offset: 0x001E1BEF
		public unsafe bool IsClimbMoving
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FClimbInfoStruct.__PropertyOffset_IsClimbMoving) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FClimbInfoStruct.__PropertyOffset_IsClimbMoving) = (value ? 1 : 0);
			}
		}

		// Token: 0x170050E9 RID: 20713
		// (get) Token: 0x060148BF RID: 84159 RVA: 0x001E3A00 File Offset: 0x001E1C00
		// (set) Token: 0x060148C0 RID: 84160 RVA: 0x001E3A14 File Offset: 0x001E1C14
		public unsafe FVector2D ClimbInput
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FClimbInfoStruct.__PropertyOffset_ClimbInput);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FClimbInfoStruct.__PropertyOffset_ClimbInput) = value;
			}
		}

		// Token: 0x170050EA RID: 20714
		// (get) Token: 0x060148C1 RID: 84161 RVA: 0x001E3A29 File Offset: 0x001E1C29
		// (set) Token: 0x060148C2 RID: 84162 RVA: 0x001E3A39 File Offset: 0x001E1C39
		public unsafe float OnWallAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FClimbInfoStruct.__PropertyOffset_OnWallAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FClimbInfoStruct.__PropertyOffset_OnWallAngle) = value;
			}
		}

		// Token: 0x060148C3 RID: 84163 RVA: 0x001E3A4A File Offset: 0x001E1C4A
		public FClimbInfoStruct()
		{
		}

		// Token: 0x060148C4 RID: 84164 RVA: 0x001E3A52 File Offset: 0x001E1C52
		public FClimbInfoStruct(bool IsClimbMoving, FVector2D ClimbInput, float OnWallAngle)
		{
			this.IsClimbMoving = IsClimbMoving;
			this.ClimbInput = ClimbInput;
			this.OnWallAngle = OnWallAngle;
		}

		// Token: 0x060148C5 RID: 84165 RVA: 0x001E3A6F File Offset: 0x001E1C6F
		protected override IntPtr GetUStructPtr()
		{
			return FClimbInfoStruct.StaticStruct();
		}

		// Token: 0x060148C6 RID: 84166 RVA: 0x001E3A7B File Offset: 0x001E1C7B
		[NullableContext(2)]
		public FClimbInfoStruct(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060148C7 RID: 84167 RVA: 0x001E3A85 File Offset: 0x001E1C85
		public FClimbInfoStruct(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060148C8 RID: 84168 RVA: 0x001E3A90 File Offset: 0x001E1C90
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FClimbInfoStruct(Pointer, false, true);
		}

		// Token: 0x060148C9 RID: 84169 RVA: 0x001E3A9A File Offset: 0x001E1C9A
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FClimbInfoStruct(Pointer, MemoryOwner);
		}

		// Token: 0x0400B2C1 RID: 45761
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroAnim.ClimbInfoStruct";

		// Token: 0x0400B2C2 RID: 45762
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400B2C3 RID: 45763
		internal static int __PropertyOffset_IsClimbMoving;

		// Token: 0x0400B2C4 RID: 45764
		internal static int __PropertyOffset_ClimbInput;

		// Token: 0x0400B2C5 RID: 45765
		internal static int __PropertyOffset_OnWallAngle;
	}
}
