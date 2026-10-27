using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200184A RID: 6218
	[UnrealObjectPath("/Script/KuroFauxPhysics.KuroLine")]
	[UnrealStructLayout(52, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 52)]
	public class FKuroLine : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06016EB2 RID: 93874 RVA: 0x002170CA File Offset: 0x002152CA
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroLine._ScriptStructPtr != 0) ? FKuroLine._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroFauxPhysics.KuroLine", ref FKuroLine._ScriptStructPtr);
		}

		// Token: 0x17005C6E RID: 23662
		// (get) Token: 0x06016EB3 RID: 93875 RVA: 0x002170EE File Offset: 0x002152EE
		// (set) Token: 0x06016EB4 RID: 93876 RVA: 0x00217102 File Offset: 0x00215302
		public unsafe FVector Start
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroLine.__PropertyOffset_Start);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroLine.__PropertyOffset_Start) = value;
			}
		}

		// Token: 0x17005C6F RID: 23663
		// (get) Token: 0x06016EB5 RID: 93877 RVA: 0x00217117 File Offset: 0x00215317
		// (set) Token: 0x06016EB6 RID: 93878 RVA: 0x0021712B File Offset: 0x0021532B
		public unsafe FVector End
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroLine.__PropertyOffset_End);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroLine.__PropertyOffset_End) = value;
			}
		}

		// Token: 0x17005C70 RID: 23664
		// (get) Token: 0x06016EB7 RID: 93879 RVA: 0x00217140 File Offset: 0x00215340
		// (set) Token: 0x06016EB8 RID: 93880 RVA: 0x00217154 File Offset: 0x00215354
		public unsafe FLinearColor Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroLine.__PropertyOffset_Color);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroLine.__PropertyOffset_Color) = value;
			}
		}

		// Token: 0x17005C71 RID: 23665
		// (get) Token: 0x06016EB9 RID: 93881 RVA: 0x00217169 File Offset: 0x00215369
		// (set) Token: 0x06016EBA RID: 93882 RVA: 0x00217179 File Offset: 0x00215379
		public unsafe float Thickness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroLine.__PropertyOffset_Thickness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroLine.__PropertyOffset_Thickness) = value;
			}
		}

		// Token: 0x17005C72 RID: 23666
		// (get) Token: 0x06016EBB RID: 93883 RVA: 0x0021718A File Offset: 0x0021538A
		// (set) Token: 0x06016EBC RID: 93884 RVA: 0x0021719A File Offset: 0x0021539A
		public unsafe float RemainingLifeTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroLine.__PropertyOffset_RemainingLifeTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroLine.__PropertyOffset_RemainingLifeTime) = value;
			}
		}

		// Token: 0x17005C73 RID: 23667
		// (get) Token: 0x06016EBD RID: 93885 RVA: 0x002171AB File Offset: 0x002153AB
		// (set) Token: 0x06016EBE RID: 93886 RVA: 0x002171BB File Offset: 0x002153BB
		public unsafe byte DepthPriority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroLine.__PropertyOffset_DepthPriority);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroLine.__PropertyOffset_DepthPriority) = value;
			}
		}

		// Token: 0x06016EBF RID: 93887 RVA: 0x002171CC File Offset: 0x002153CC
		public FKuroLine()
		{
		}

		// Token: 0x06016EC0 RID: 93888 RVA: 0x002171D4 File Offset: 0x002153D4
		public FKuroLine(FVector Start, FVector End, FLinearColor Color, float Thickness, float RemainingLifeTime, byte DepthPriority)
		{
			this.Start = Start;
			this.End = End;
			this.Color = Color;
			this.Thickness = Thickness;
			this.RemainingLifeTime = RemainingLifeTime;
			this.DepthPriority = DepthPriority;
		}

		// Token: 0x06016EC1 RID: 93889 RVA: 0x00217209 File Offset: 0x00215409
		protected override IntPtr GetUStructPtr()
		{
			return FKuroLine.StaticStruct();
		}

		// Token: 0x06016EC2 RID: 93890 RVA: 0x00217215 File Offset: 0x00215415
		[NullableContext(2)]
		public FKuroLine(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06016EC3 RID: 93891 RVA: 0x0021721F File Offset: 0x0021541F
		public FKuroLine(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06016EC4 RID: 93892 RVA: 0x0021722A File Offset: 0x0021542A
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroLine(Pointer, false, true);
		}

		// Token: 0x06016EC5 RID: 93893 RVA: 0x00217234 File Offset: 0x00215434
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroLine(Pointer, MemoryOwner);
		}

		// Token: 0x0400C743 RID: 51011
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroFauxPhysics.KuroLine";

		// Token: 0x0400C744 RID: 51012
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400C745 RID: 51013
		internal static int __PropertyOffset_Start;

		// Token: 0x0400C746 RID: 51014
		internal static int __PropertyOffset_End;

		// Token: 0x0400C747 RID: 51015
		internal static int __PropertyOffset_Color;

		// Token: 0x0400C748 RID: 51016
		internal static int __PropertyOffset_Thickness;

		// Token: 0x0400C749 RID: 51017
		internal static int __PropertyOffset_RemainingLifeTime;

		// Token: 0x0400C74A RID: 51018
		internal static int __PropertyOffset_DepthPriority;
	}
}
