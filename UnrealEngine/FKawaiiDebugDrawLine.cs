using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020015D2 RID: 5586
	[UnrealObjectPath("/Script/KawaiiPhysics.KawaiiDebugDrawLine")]
	[UnrealStructLayout(40, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FKawaiiDebugDrawLine : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06014236 RID: 82486 RVA: 0x001D948E File Offset: 0x001D768E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKawaiiDebugDrawLine._ScriptStructPtr != 0) ? FKawaiiDebugDrawLine._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KawaiiPhysics.KawaiiDebugDrawLine", ref FKawaiiDebugDrawLine._ScriptStructPtr);
		}

		// Token: 0x17004EF4 RID: 20212
		// (get) Token: 0x06014237 RID: 82487 RVA: 0x001D94B2 File Offset: 0x001D76B2
		// (set) Token: 0x06014238 RID: 82488 RVA: 0x001D94C6 File Offset: 0x001D76C6
		public unsafe FVector Start
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKawaiiDebugDrawLine.__PropertyOffset_Start);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKawaiiDebugDrawLine.__PropertyOffset_Start) = value;
			}
		}

		// Token: 0x17004EF5 RID: 20213
		// (get) Token: 0x06014239 RID: 82489 RVA: 0x001D94DB File Offset: 0x001D76DB
		// (set) Token: 0x0601423A RID: 82490 RVA: 0x001D94EF File Offset: 0x001D76EF
		public unsafe FVector End
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKawaiiDebugDrawLine.__PropertyOffset_End);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKawaiiDebugDrawLine.__PropertyOffset_End) = value;
			}
		}

		// Token: 0x17004EF6 RID: 20214
		// (get) Token: 0x0601423B RID: 82491 RVA: 0x001D9504 File Offset: 0x001D7704
		// (set) Token: 0x0601423C RID: 82492 RVA: 0x001D9518 File Offset: 0x001D7718
		public unsafe FLinearColor Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKawaiiDebugDrawLine.__PropertyOffset_Color);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKawaiiDebugDrawLine.__PropertyOffset_Color) = value;
			}
		}

		// Token: 0x0601423D RID: 82493 RVA: 0x001D952D File Offset: 0x001D772D
		public FKawaiiDebugDrawLine()
		{
		}

		// Token: 0x0601423E RID: 82494 RVA: 0x001D9535 File Offset: 0x001D7735
		public FKawaiiDebugDrawLine(FVector Start, FVector End, FLinearColor Color)
		{
			this.Start = Start;
			this.End = End;
			this.Color = Color;
		}

		// Token: 0x0601423F RID: 82495 RVA: 0x001D9552 File Offset: 0x001D7752
		protected override IntPtr GetUStructPtr()
		{
			return FKawaiiDebugDrawLine.StaticStruct();
		}

		// Token: 0x06014240 RID: 82496 RVA: 0x001D955E File Offset: 0x001D775E
		[NullableContext(2)]
		public FKawaiiDebugDrawLine(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06014241 RID: 82497 RVA: 0x001D9568 File Offset: 0x001D7768
		public FKawaiiDebugDrawLine(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06014242 RID: 82498 RVA: 0x001D9573 File Offset: 0x001D7773
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKawaiiDebugDrawLine(Pointer, false, true);
		}

		// Token: 0x06014243 RID: 82499 RVA: 0x001D957D File Offset: 0x001D777D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKawaiiDebugDrawLine(Pointer, MemoryOwner);
		}

		// Token: 0x0400AF44 RID: 44868
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KawaiiPhysics.KawaiiDebugDrawLine";

		// Token: 0x0400AF45 RID: 44869
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400AF46 RID: 44870
		internal static int __PropertyOffset_Start;

		// Token: 0x0400AF47 RID: 44871
		internal static int __PropertyOffset_End;

		// Token: 0x0400AF48 RID: 44872
		internal static int __PropertyOffset_Color;
	}
}
