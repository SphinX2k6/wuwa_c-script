using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200183B RID: 6203
	[UnrealObjectPath("/Script/KuroFauxPhysics.KuroDashedLine")]
	[UnrealStructLayout(56, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FKuroDashedLine : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06016DD3 RID: 93651 RVA: 0x00216100 File Offset: 0x00214300
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroDashedLine._ScriptStructPtr != 0) ? FKuroDashedLine._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroFauxPhysics.KuroDashedLine", ref FKuroDashedLine._ScriptStructPtr);
		}

		// Token: 0x17005C44 RID: 23620
		// (get) Token: 0x06016DD4 RID: 93652 RVA: 0x00216124 File Offset: 0x00214324
		// (set) Token: 0x06016DD5 RID: 93653 RVA: 0x00216138 File Offset: 0x00214338
		public unsafe FVector Start
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroDashedLine.__PropertyOffset_Start);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroDashedLine.__PropertyOffset_Start) = value;
			}
		}

		// Token: 0x17005C45 RID: 23621
		// (get) Token: 0x06016DD6 RID: 93654 RVA: 0x0021614D File Offset: 0x0021434D
		// (set) Token: 0x06016DD7 RID: 93655 RVA: 0x00216161 File Offset: 0x00214361
		public unsafe FVector End
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroDashedLine.__PropertyOffset_End);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroDashedLine.__PropertyOffset_End) = value;
			}
		}

		// Token: 0x17005C46 RID: 23622
		// (get) Token: 0x06016DD8 RID: 93656 RVA: 0x00216176 File Offset: 0x00214376
		// (set) Token: 0x06016DD9 RID: 93657 RVA: 0x0021618A File Offset: 0x0021438A
		public unsafe FLinearColor Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroDashedLine.__PropertyOffset_Color);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroDashedLine.__PropertyOffset_Color) = value;
			}
		}

		// Token: 0x17005C47 RID: 23623
		// (get) Token: 0x06016DDA RID: 93658 RVA: 0x0021619F File Offset: 0x0021439F
		// (set) Token: 0x06016DDB RID: 93659 RVA: 0x002161AF File Offset: 0x002143AF
		public unsafe float DashSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroDashedLine.__PropertyOffset_DashSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroDashedLine.__PropertyOffset_DashSize) = value;
			}
		}

		// Token: 0x17005C48 RID: 23624
		// (get) Token: 0x06016DDC RID: 93660 RVA: 0x002161C0 File Offset: 0x002143C0
		// (set) Token: 0x06016DDD RID: 93661 RVA: 0x002161D0 File Offset: 0x002143D0
		public unsafe float RemainingLifeTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroDashedLine.__PropertyOffset_RemainingLifeTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroDashedLine.__PropertyOffset_RemainingLifeTime) = value;
			}
		}

		// Token: 0x17005C49 RID: 23625
		// (get) Token: 0x06016DDE RID: 93662 RVA: 0x002161E1 File Offset: 0x002143E1
		// (set) Token: 0x06016DDF RID: 93663 RVA: 0x002161F1 File Offset: 0x002143F1
		public unsafe byte DepthPriority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroDashedLine.__PropertyOffset_DepthPriority);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroDashedLine.__PropertyOffset_DepthPriority) = value;
			}
		}

		// Token: 0x17005C4A RID: 23626
		// (get) Token: 0x06016DE0 RID: 93664 RVA: 0x00216202 File Offset: 0x00214402
		// (set) Token: 0x06016DE1 RID: 93665 RVA: 0x00216212 File Offset: 0x00214412
		public unsafe float DepthBias
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroDashedLine.__PropertyOffset_DepthBias);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroDashedLine.__PropertyOffset_DepthBias) = value;
			}
		}

		// Token: 0x06016DE2 RID: 93666 RVA: 0x00216223 File Offset: 0x00214423
		public FKuroDashedLine()
		{
		}

		// Token: 0x06016DE3 RID: 93667 RVA: 0x0021622B File Offset: 0x0021442B
		public FKuroDashedLine(FVector Start, FVector End, FLinearColor Color, float DashSize, float RemainingLifeTime, byte DepthPriority, float DepthBias)
		{
			this.Start = Start;
			this.End = End;
			this.Color = Color;
			this.DashSize = DashSize;
			this.RemainingLifeTime = RemainingLifeTime;
			this.DepthPriority = DepthPriority;
			this.DepthBias = DepthBias;
		}

		// Token: 0x06016DE4 RID: 93668 RVA: 0x00216268 File Offset: 0x00214468
		protected override IntPtr GetUStructPtr()
		{
			return FKuroDashedLine.StaticStruct();
		}

		// Token: 0x06016DE5 RID: 93669 RVA: 0x00216274 File Offset: 0x00214474
		[NullableContext(2)]
		public FKuroDashedLine(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06016DE6 RID: 93670 RVA: 0x0021627E File Offset: 0x0021447E
		public FKuroDashedLine(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06016DE7 RID: 93671 RVA: 0x00216289 File Offset: 0x00214489
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroDashedLine(Pointer, false, true);
		}

		// Token: 0x06016DE8 RID: 93672 RVA: 0x00216293 File Offset: 0x00214493
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroDashedLine(Pointer, MemoryOwner);
		}

		// Token: 0x0400C6E0 RID: 50912
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroFauxPhysics.KuroDashedLine";

		// Token: 0x0400C6E1 RID: 50913
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400C6E2 RID: 50914
		internal static int __PropertyOffset_Start;

		// Token: 0x0400C6E3 RID: 50915
		internal static int __PropertyOffset_End;

		// Token: 0x0400C6E4 RID: 50916
		internal static int __PropertyOffset_Color;

		// Token: 0x0400C6E5 RID: 50917
		internal static int __PropertyOffset_DashSize;

		// Token: 0x0400C6E6 RID: 50918
		internal static int __PropertyOffset_RemainingLifeTime;

		// Token: 0x0400C6E7 RID: 50919
		internal static int __PropertyOffset_DepthPriority;

		// Token: 0x0400C6E8 RID: 50920
		internal static int __PropertyOffset_DepthBias;
	}
}
