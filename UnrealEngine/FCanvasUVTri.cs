using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200091C RID: 2332
	[UnrealObjectPath("/Script/Engine.CanvasUVTri")]
	[UnrealStructLayout(96, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 96)]
	public class FCanvasUVTri : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600807C RID: 32892 RVA: 0x000B8515 File Offset: 0x000B6715
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCanvasUVTri._ScriptStructPtr != 0) ? FCanvasUVTri._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.CanvasUVTri", ref FCanvasUVTri._ScriptStructPtr);
		}

		// Token: 0x17001E30 RID: 7728
		// (get) Token: 0x0600807D RID: 32893 RVA: 0x000B8539 File Offset: 0x000B6739
		// (set) Token: 0x0600807E RID: 32894 RVA: 0x000B854D File Offset: 0x000B674D
		public unsafe FVector2D V0_Pos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCanvasUVTri.__PropertyOffset_V0_Pos);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCanvasUVTri.__PropertyOffset_V0_Pos) = value;
			}
		}

		// Token: 0x17001E31 RID: 7729
		// (get) Token: 0x0600807F RID: 32895 RVA: 0x000B8562 File Offset: 0x000B6762
		// (set) Token: 0x06008080 RID: 32896 RVA: 0x000B8576 File Offset: 0x000B6776
		public unsafe FVector2D V0_UV
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCanvasUVTri.__PropertyOffset_V0_UV);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCanvasUVTri.__PropertyOffset_V0_UV) = value;
			}
		}

		// Token: 0x17001E32 RID: 7730
		// (get) Token: 0x06008081 RID: 32897 RVA: 0x000B858B File Offset: 0x000B678B
		// (set) Token: 0x06008082 RID: 32898 RVA: 0x000B859F File Offset: 0x000B679F
		public unsafe FLinearColor V0_Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCanvasUVTri.__PropertyOffset_V0_Color);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCanvasUVTri.__PropertyOffset_V0_Color) = value;
			}
		}

		// Token: 0x17001E33 RID: 7731
		// (get) Token: 0x06008083 RID: 32899 RVA: 0x000B85B4 File Offset: 0x000B67B4
		// (set) Token: 0x06008084 RID: 32900 RVA: 0x000B85C8 File Offset: 0x000B67C8
		public unsafe FVector2D V1_Pos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCanvasUVTri.__PropertyOffset_V1_Pos);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCanvasUVTri.__PropertyOffset_V1_Pos) = value;
			}
		}

		// Token: 0x17001E34 RID: 7732
		// (get) Token: 0x06008085 RID: 32901 RVA: 0x000B85DD File Offset: 0x000B67DD
		// (set) Token: 0x06008086 RID: 32902 RVA: 0x000B85F1 File Offset: 0x000B67F1
		public unsafe FVector2D V1_UV
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCanvasUVTri.__PropertyOffset_V1_UV);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCanvasUVTri.__PropertyOffset_V1_UV) = value;
			}
		}

		// Token: 0x17001E35 RID: 7733
		// (get) Token: 0x06008087 RID: 32903 RVA: 0x000B8606 File Offset: 0x000B6806
		// (set) Token: 0x06008088 RID: 32904 RVA: 0x000B861A File Offset: 0x000B681A
		public unsafe FLinearColor V1_Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCanvasUVTri.__PropertyOffset_V1_Color);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCanvasUVTri.__PropertyOffset_V1_Color) = value;
			}
		}

		// Token: 0x17001E36 RID: 7734
		// (get) Token: 0x06008089 RID: 32905 RVA: 0x000B862F File Offset: 0x000B682F
		// (set) Token: 0x0600808A RID: 32906 RVA: 0x000B8643 File Offset: 0x000B6843
		public unsafe FVector2D V2_Pos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCanvasUVTri.__PropertyOffset_V2_Pos);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCanvasUVTri.__PropertyOffset_V2_Pos) = value;
			}
		}

		// Token: 0x17001E37 RID: 7735
		// (get) Token: 0x0600808B RID: 32907 RVA: 0x000B8658 File Offset: 0x000B6858
		// (set) Token: 0x0600808C RID: 32908 RVA: 0x000B866C File Offset: 0x000B686C
		public unsafe FVector2D V2_UV
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCanvasUVTri.__PropertyOffset_V2_UV);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCanvasUVTri.__PropertyOffset_V2_UV) = value;
			}
		}

		// Token: 0x17001E38 RID: 7736
		// (get) Token: 0x0600808D RID: 32909 RVA: 0x000B8681 File Offset: 0x000B6881
		// (set) Token: 0x0600808E RID: 32910 RVA: 0x000B8695 File Offset: 0x000B6895
		public unsafe FLinearColor V2_Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCanvasUVTri.__PropertyOffset_V2_Color);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCanvasUVTri.__PropertyOffset_V2_Color) = value;
			}
		}

		// Token: 0x0600808F RID: 32911 RVA: 0x000B86AA File Offset: 0x000B68AA
		public FCanvasUVTri()
		{
		}

		// Token: 0x06008090 RID: 32912 RVA: 0x000B86B4 File Offset: 0x000B68B4
		public FCanvasUVTri(FVector2D V0_Pos, FVector2D V0_UV, FLinearColor V0_Color, FVector2D V1_Pos, FVector2D V1_UV, FLinearColor V1_Color, FVector2D V2_Pos, FVector2D V2_UV, FLinearColor V2_Color)
		{
			this.V0_Pos = V0_Pos;
			this.V0_UV = V0_UV;
			this.V0_Color = V0_Color;
			this.V1_Pos = V1_Pos;
			this.V1_UV = V1_UV;
			this.V1_Color = V1_Color;
			this.V2_Pos = V2_Pos;
			this.V2_UV = V2_UV;
			this.V2_Color = V2_Color;
		}

		// Token: 0x06008091 RID: 32913 RVA: 0x000B870C File Offset: 0x000B690C
		protected override IntPtr GetUStructPtr()
		{
			return FCanvasUVTri.StaticStruct();
		}

		// Token: 0x06008092 RID: 32914 RVA: 0x000B8718 File Offset: 0x000B6918
		[NullableContext(2)]
		public FCanvasUVTri(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008093 RID: 32915 RVA: 0x000B8722 File Offset: 0x000B6922
		public FCanvasUVTri(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008094 RID: 32916 RVA: 0x000B872D File Offset: 0x000B692D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCanvasUVTri(Pointer, false, true);
		}

		// Token: 0x06008095 RID: 32917 RVA: 0x000B8737 File Offset: 0x000B6937
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCanvasUVTri(Pointer, MemoryOwner);
		}

		// Token: 0x04003D84 RID: 15748
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.CanvasUVTri";

		// Token: 0x04003D85 RID: 15749
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003D86 RID: 15750
		internal static int __PropertyOffset_V0_Pos;

		// Token: 0x04003D87 RID: 15751
		internal static int __PropertyOffset_V0_UV;

		// Token: 0x04003D88 RID: 15752
		internal static int __PropertyOffset_V0_Color;

		// Token: 0x04003D89 RID: 15753
		internal static int __PropertyOffset_V1_Pos;

		// Token: 0x04003D8A RID: 15754
		internal static int __PropertyOffset_V1_UV;

		// Token: 0x04003D8B RID: 15755
		internal static int __PropertyOffset_V1_Color;

		// Token: 0x04003D8C RID: 15756
		internal static int __PropertyOffset_V2_Pos;

		// Token: 0x04003D8D RID: 15757
		internal static int __PropertyOffset_V2_UV;

		// Token: 0x04003D8E RID: 15758
		internal static int __PropertyOffset_V2_Color;
	}
}
