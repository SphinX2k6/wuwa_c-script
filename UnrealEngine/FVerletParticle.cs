using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001C7D RID: 7293
	[UnrealObjectPath("/Script/KuroRopeEffect.VerletParticle")]
	[UnrealStructLayout(40, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FVerletParticle : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601C514 RID: 115988 RVA: 0x0029BC94 File Offset: 0x00299E94
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FVerletParticle._ScriptStructPtr != 0) ? FVerletParticle._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRopeEffect.VerletParticle", ref FVerletParticle._ScriptStructPtr);
		}

		// Token: 0x17007282 RID: 29314
		// (get) Token: 0x0601C515 RID: 115989 RVA: 0x0029BCB8 File Offset: 0x00299EB8
		// (set) Token: 0x0601C516 RID: 115990 RVA: 0x0029BCCC File Offset: 0x00299ECC
		public unsafe FVector Position
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FVerletParticle.__PropertyOffset_Position);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FVerletParticle.__PropertyOffset_Position) = value;
			}
		}

		// Token: 0x17007283 RID: 29315
		// (get) Token: 0x0601C517 RID: 115991 RVA: 0x0029BCE1 File Offset: 0x00299EE1
		// (set) Token: 0x0601C518 RID: 115992 RVA: 0x0029BCF5 File Offset: 0x00299EF5
		public unsafe FVector PreviousPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FVerletParticle.__PropertyOffset_PreviousPosition);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FVerletParticle.__PropertyOffset_PreviousPosition) = value;
			}
		}

		// Token: 0x17007284 RID: 29316
		// (get) Token: 0x0601C519 RID: 115993 RVA: 0x0029BD0A File Offset: 0x00299F0A
		// (set) Token: 0x0601C51A RID: 115994 RVA: 0x0029BD1E File Offset: 0x00299F1E
		public unsafe FVector AccumulatedTension
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FVerletParticle.__PropertyOffset_AccumulatedTension);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FVerletParticle.__PropertyOffset_AccumulatedTension) = value;
			}
		}

		// Token: 0x17007285 RID: 29317
		// (get) Token: 0x0601C51B RID: 115995 RVA: 0x0029BD33 File Offset: 0x00299F33
		// (set) Token: 0x0601C51C RID: 115996 RVA: 0x0029BD43 File Offset: 0x00299F43
		public unsafe bool bPinned
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FVerletParticle.__PropertyOffset_bPinned) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FVerletParticle.__PropertyOffset_bPinned) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601C51D RID: 115997 RVA: 0x0029BD54 File Offset: 0x00299F54
		public FVerletParticle()
		{
		}

		// Token: 0x0601C51E RID: 115998 RVA: 0x0029BD5C File Offset: 0x00299F5C
		public FVerletParticle(FVector Position, FVector PreviousPosition, FVector AccumulatedTension, bool bPinned)
		{
			this.Position = Position;
			this.PreviousPosition = PreviousPosition;
			this.AccumulatedTension = AccumulatedTension;
			this.bPinned = bPinned;
		}

		// Token: 0x0601C51F RID: 115999 RVA: 0x0029BD81 File Offset: 0x00299F81
		protected override IntPtr GetUStructPtr()
		{
			return FVerletParticle.StaticStruct();
		}

		// Token: 0x0601C520 RID: 116000 RVA: 0x0029BD8D File Offset: 0x00299F8D
		[NullableContext(2)]
		public FVerletParticle(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601C521 RID: 116001 RVA: 0x0029BD97 File Offset: 0x00299F97
		public FVerletParticle(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601C522 RID: 116002 RVA: 0x0029BDA2 File Offset: 0x00299FA2
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FVerletParticle(Pointer, false, true);
		}

		// Token: 0x0601C523 RID: 116003 RVA: 0x0029BDAC File Offset: 0x00299FAC
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FVerletParticle(Pointer, MemoryOwner);
		}

		// Token: 0x0400F395 RID: 62357
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRopeEffect.VerletParticle";

		// Token: 0x0400F396 RID: 62358
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400F397 RID: 62359
		internal static int __PropertyOffset_Position;

		// Token: 0x0400F398 RID: 62360
		internal static int __PropertyOffset_PreviousPosition;

		// Token: 0x0400F399 RID: 62361
		internal static int __PropertyOffset_AccumulatedTension;

		// Token: 0x0400F39A RID: 62362
		internal static int __PropertyOffset_bPinned;
	}
}
