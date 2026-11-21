using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000470 RID: 1136
	[UnrealObjectPath("/Script/KuroMovement.KuroFlowerFlyingFocusParams")]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FKuroFlowerFlyingFocusParams : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06006C15 RID: 27669 RVA: 0x0009D49D File Offset: 0x0009B69D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroFlowerFlyingFocusParams._ScriptStructPtr != 0) ? FKuroFlowerFlyingFocusParams._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroMovement.KuroFlowerFlyingFocusParams", ref FKuroFlowerFlyingFocusParams._ScriptStructPtr);
		}

		// Token: 0x17001569 RID: 5481
		// (get) Token: 0x06006C16 RID: 27670 RVA: 0x0009D4C1 File Offset: 0x0009B6C1
		// (set) Token: 0x06006C17 RID: 27671 RVA: 0x0009D4D5 File Offset: 0x0009B6D5
		public unsafe FVector2D CameraPitchDeadZone
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroFlowerFlyingFocusParams.__PropertyOffset_CameraPitchDeadZone);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroFlowerFlyingFocusParams.__PropertyOffset_CameraPitchDeadZone) = value;
			}
		}

		// Token: 0x06006C18 RID: 27672 RVA: 0x0009D4EA File Offset: 0x0009B6EA
		public FKuroFlowerFlyingFocusParams()
		{
		}

		// Token: 0x06006C19 RID: 27673 RVA: 0x0009D4F2 File Offset: 0x0009B6F2
		protected override IntPtr GetUStructPtr()
		{
			return FKuroFlowerFlyingFocusParams.StaticStruct();
		}

		// Token: 0x06006C1A RID: 27674 RVA: 0x0009D4FE File Offset: 0x0009B6FE
		[NullableContext(2)]
		public FKuroFlowerFlyingFocusParams(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006C1B RID: 27675 RVA: 0x0009D508 File Offset: 0x0009B708
		public FKuroFlowerFlyingFocusParams(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006C1C RID: 27676 RVA: 0x0009D513 File Offset: 0x0009B713
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroFlowerFlyingFocusParams(Pointer, false, true);
		}

		// Token: 0x06006C1D RID: 27677 RVA: 0x0009D51D File Offset: 0x0009B71D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroFlowerFlyingFocusParams(Pointer, MemoryOwner);
		}

		// Token: 0x04002E22 RID: 11810
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroMovement.KuroFlowerFlyingFocusParams";

		// Token: 0x04002E23 RID: 11811
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002E24 RID: 11812
		internal static int __PropertyOffset_CameraPitchDeadZone;
	}
}
