using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001C72 RID: 7282
	[UnrealObjectPath("/Script/KuroRopeEffect.ArcRopeParticle")]
	[UnrealStructLayout(28, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 28)]
	public class FArcRopeParticle : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601C419 RID: 115737 RVA: 0x0029A6E8 File Offset: 0x002988E8
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FArcRopeParticle._ScriptStructPtr != 0) ? FArcRopeParticle._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRopeEffect.ArcRopeParticle", ref FArcRopeParticle._ScriptStructPtr);
		}

		// Token: 0x17007238 RID: 29240
		// (get) Token: 0x0601C41A RID: 115738 RVA: 0x0029A70C File Offset: 0x0029890C
		// (set) Token: 0x0601C41B RID: 115739 RVA: 0x0029A720 File Offset: 0x00298920
		public unsafe FVector Position
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FArcRopeParticle.__PropertyOffset_Position);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FArcRopeParticle.__PropertyOffset_Position) = value;
			}
		}

		// Token: 0x17007239 RID: 29241
		// (get) Token: 0x0601C41C RID: 115740 RVA: 0x0029A735 File Offset: 0x00298935
		// (set) Token: 0x0601C41D RID: 115741 RVA: 0x0029A749 File Offset: 0x00298949
		public unsafe FVector PreviousPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FArcRopeParticle.__PropertyOffset_PreviousPosition);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FArcRopeParticle.__PropertyOffset_PreviousPosition) = value;
			}
		}

		// Token: 0x1700723A RID: 29242
		// (get) Token: 0x0601C41E RID: 115742 RVA: 0x0029A75E File Offset: 0x0029895E
		// (set) Token: 0x0601C41F RID: 115743 RVA: 0x0029A76E File Offset: 0x0029896E
		public unsafe bool bPinned
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FArcRopeParticle.__PropertyOffset_bPinned) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FArcRopeParticle.__PropertyOffset_bPinned) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601C420 RID: 115744 RVA: 0x0029A77F File Offset: 0x0029897F
		public FArcRopeParticle()
		{
		}

		// Token: 0x0601C421 RID: 115745 RVA: 0x0029A787 File Offset: 0x00298987
		public FArcRopeParticle(FVector Position, FVector PreviousPosition, bool bPinned)
		{
			this.Position = Position;
			this.PreviousPosition = PreviousPosition;
			this.bPinned = bPinned;
		}

		// Token: 0x0601C422 RID: 115746 RVA: 0x0029A7A4 File Offset: 0x002989A4
		protected override IntPtr GetUStructPtr()
		{
			return FArcRopeParticle.StaticStruct();
		}

		// Token: 0x0601C423 RID: 115747 RVA: 0x0029A7B0 File Offset: 0x002989B0
		[NullableContext(2)]
		public FArcRopeParticle(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601C424 RID: 115748 RVA: 0x0029A7BA File Offset: 0x002989BA
		public FArcRopeParticle(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601C425 RID: 115749 RVA: 0x0029A7C5 File Offset: 0x002989C5
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FArcRopeParticle(Pointer, false, true);
		}

		// Token: 0x0601C426 RID: 115750 RVA: 0x0029A7CF File Offset: 0x002989CF
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FArcRopeParticle(Pointer, MemoryOwner);
		}

		// Token: 0x0400F317 RID: 62231
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRopeEffect.ArcRopeParticle";

		// Token: 0x0400F318 RID: 62232
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400F319 RID: 62233
		internal static int __PropertyOffset_Position;

		// Token: 0x0400F31A RID: 62234
		internal static int __PropertyOffset_PreviousPosition;

		// Token: 0x0400F31B RID: 62235
		internal static int __PropertyOffset_bPinned;
	}
}
