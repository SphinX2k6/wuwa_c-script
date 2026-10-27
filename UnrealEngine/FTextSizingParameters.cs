using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020011CB RID: 4555
	[UnrealObjectPath("/Script/Engine.TextSizingParameters")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FTextSizingParameters : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06010C97 RID: 68759 RVA: 0x0018A6A8 File Offset: 0x001888A8
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FTextSizingParameters._ScriptStructPtr != 0) ? FTextSizingParameters._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.TextSizingParameters", ref FTextSizingParameters._ScriptStructPtr);
		}

		// Token: 0x17004184 RID: 16772
		// (get) Token: 0x06010C98 RID: 68760 RVA: 0x0018A6CC File Offset: 0x001888CC
		// (set) Token: 0x06010C99 RID: 68761 RVA: 0x0018A6DC File Offset: 0x001888DC
		public unsafe float DrawX
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTextSizingParameters.__PropertyOffset_DrawX);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTextSizingParameters.__PropertyOffset_DrawX) = value;
			}
		}

		// Token: 0x17004185 RID: 16773
		// (get) Token: 0x06010C9A RID: 68762 RVA: 0x0018A6ED File Offset: 0x001888ED
		// (set) Token: 0x06010C9B RID: 68763 RVA: 0x0018A6FD File Offset: 0x001888FD
		public unsafe float DrawY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTextSizingParameters.__PropertyOffset_DrawY);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTextSizingParameters.__PropertyOffset_DrawY) = value;
			}
		}

		// Token: 0x17004186 RID: 16774
		// (get) Token: 0x06010C9C RID: 68764 RVA: 0x0018A70E File Offset: 0x0018890E
		// (set) Token: 0x06010C9D RID: 68765 RVA: 0x0018A71E File Offset: 0x0018891E
		public unsafe float DrawXL
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTextSizingParameters.__PropertyOffset_DrawXL);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTextSizingParameters.__PropertyOffset_DrawXL) = value;
			}
		}

		// Token: 0x17004187 RID: 16775
		// (get) Token: 0x06010C9E RID: 68766 RVA: 0x0018A72F File Offset: 0x0018892F
		// (set) Token: 0x06010C9F RID: 68767 RVA: 0x0018A73F File Offset: 0x0018893F
		public unsafe float DrawYL
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTextSizingParameters.__PropertyOffset_DrawYL);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTextSizingParameters.__PropertyOffset_DrawYL) = value;
			}
		}

		// Token: 0x17004188 RID: 16776
		// (get) Token: 0x06010CA0 RID: 68768 RVA: 0x0018A750 File Offset: 0x00188950
		// (set) Token: 0x06010CA1 RID: 68769 RVA: 0x0018A764 File Offset: 0x00188964
		public unsafe FVector2D Scaling
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTextSizingParameters.__PropertyOffset_Scaling);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTextSizingParameters.__PropertyOffset_Scaling) = value;
			}
		}

		// Token: 0x17004189 RID: 16777
		// (get) Token: 0x06010CA2 RID: 68770 RVA: 0x0018A779 File Offset: 0x00188979
		// (set) Token: 0x06010CA3 RID: 68771 RVA: 0x0018A78D File Offset: 0x0018898D
		[Nullable(2)]
		public unsafe UFont DrawFont
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UFont>(base.NativePtr / (IntPtr)sizeof(void*) + FTextSizingParameters.__PropertyOffset_DrawFont);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FTextSizingParameters.__PropertyOffset_DrawFont, value);
			}
		}

		// Token: 0x1700418A RID: 16778
		// (get) Token: 0x06010CA4 RID: 68772 RVA: 0x0018A7A2 File Offset: 0x001889A2
		// (set) Token: 0x06010CA5 RID: 68773 RVA: 0x0018A7B6 File Offset: 0x001889B6
		public unsafe FVector2D SpacingAdjust
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTextSizingParameters.__PropertyOffset_SpacingAdjust);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTextSizingParameters.__PropertyOffset_SpacingAdjust) = value;
			}
		}

		// Token: 0x06010CA6 RID: 68774 RVA: 0x0018A7CB File Offset: 0x001889CB
		public FTextSizingParameters()
		{
		}

		// Token: 0x06010CA7 RID: 68775 RVA: 0x0018A7D3 File Offset: 0x001889D3
		[NullableContext(1)]
		public FTextSizingParameters(float DrawX, float DrawY, float DrawXL, float DrawYL, FVector2D Scaling, UFont DrawFont, FVector2D SpacingAdjust)
		{
			this.DrawX = DrawX;
			this.DrawY = DrawY;
			this.DrawXL = DrawXL;
			this.DrawYL = DrawYL;
			this.Scaling = Scaling;
			this.DrawFont = DrawFont;
			this.SpacingAdjust = SpacingAdjust;
		}

		// Token: 0x06010CA8 RID: 68776 RVA: 0x0018A810 File Offset: 0x00188A10
		protected override IntPtr GetUStructPtr()
		{
			return FTextSizingParameters.StaticStruct();
		}

		// Token: 0x06010CA9 RID: 68777 RVA: 0x0018A81C File Offset: 0x00188A1C
		[NullableContext(2)]
		public FTextSizingParameters(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06010CAA RID: 68778 RVA: 0x0018A826 File Offset: 0x00188A26
		public FTextSizingParameters(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06010CAB RID: 68779 RVA: 0x0018A831 File Offset: 0x00188A31
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FTextSizingParameters(Pointer, false, true);
		}

		// Token: 0x06010CAC RID: 68780 RVA: 0x0018A83B File Offset: 0x00188A3B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FTextSizingParameters(Pointer, MemoryOwner);
		}

		// Token: 0x04008F7F RID: 36735
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.TextSizingParameters";

		// Token: 0x04008F80 RID: 36736
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04008F81 RID: 36737
		internal static int __PropertyOffset_DrawX;

		// Token: 0x04008F82 RID: 36738
		internal static int __PropertyOffset_DrawY;

		// Token: 0x04008F83 RID: 36739
		internal static int __PropertyOffset_DrawXL;

		// Token: 0x04008F84 RID: 36740
		internal static int __PropertyOffset_DrawYL;

		// Token: 0x04008F85 RID: 36741
		internal static int __PropertyOffset_Scaling;

		// Token: 0x04008F86 RID: 36742
		internal static int __PropertyOffset_DrawFont;

		// Token: 0x04008F87 RID: 36743
		internal static int __PropertyOffset_SpacingAdjust;
	}
}
