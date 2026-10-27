using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200282B RID: 10283
	[UnrealObjectPath("/Script/SlateCore.SlateColor")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FSlateColor : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06026375 RID: 156533 RVA: 0x003A01C1 File Offset: 0x0039E3C1
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSlateColor._ScriptStructPtr != 0) ? FSlateColor._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SlateCore.SlateColor", ref FSlateColor._ScriptStructPtr);
		}

		// Token: 0x17009387 RID: 37767
		// (get) Token: 0x06026376 RID: 156534 RVA: 0x003A01E5 File Offset: 0x0039E3E5
		// (set) Token: 0x06026377 RID: 156535 RVA: 0x003A01F9 File Offset: 0x0039E3F9
		public unsafe FLinearColor SpecifiedColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSlateColor.__PropertyOffset_SpecifiedColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSlateColor.__PropertyOffset_SpecifiedColor) = value;
			}
		}

		// Token: 0x17009388 RID: 37768
		// (get) Token: 0x06026378 RID: 156536 RVA: 0x003A020E File Offset: 0x0039E40E
		// (set) Token: 0x06026379 RID: 156537 RVA: 0x003A0222 File Offset: 0x0039E422
		public unsafe TEnumAsByte<ESlateColorStylingMode> ColorUseRule
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSlateColor.__PropertyOffset_ColorUseRule);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSlateColor.__PropertyOffset_ColorUseRule) = value;
			}
		}

		// Token: 0x0602637A RID: 156538 RVA: 0x003A0237 File Offset: 0x0039E437
		public FSlateColor()
		{
		}

		// Token: 0x0602637B RID: 156539 RVA: 0x003A023F File Offset: 0x0039E43F
		public FSlateColor(FLinearColor SpecifiedColor, TEnumAsByte<ESlateColorStylingMode> ColorUseRule)
		{
			this.SpecifiedColor = SpecifiedColor;
			this.ColorUseRule = ColorUseRule;
		}

		// Token: 0x0602637C RID: 156540 RVA: 0x003A0255 File Offset: 0x0039E455
		protected override IntPtr GetUStructPtr()
		{
			return FSlateColor.StaticStruct();
		}

		// Token: 0x0602637D RID: 156541 RVA: 0x003A0261 File Offset: 0x0039E461
		[NullableContext(2)]
		public FSlateColor(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602637E RID: 156542 RVA: 0x003A026B File Offset: 0x0039E46B
		public FSlateColor(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602637F RID: 156543 RVA: 0x003A0276 File Offset: 0x0039E476
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSlateColor(Pointer, false, true);
		}

		// Token: 0x06026380 RID: 156544 RVA: 0x003A0280 File Offset: 0x0039E480
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSlateColor(Pointer, MemoryOwner);
		}

		// Token: 0x04014EB1 RID: 85681
		[Nullable(1)]
		public const string __ObjectPath = "/Script/SlateCore.SlateColor";

		// Token: 0x04014EB2 RID: 85682
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04014EB3 RID: 85683
		internal static int __PropertyOffset_SpecifiedColor;

		// Token: 0x04014EB4 RID: 85684
		internal static int __PropertyOffset_ColorUseRule;
	}
}
