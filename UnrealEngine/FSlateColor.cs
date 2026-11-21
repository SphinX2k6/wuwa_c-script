using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200081B RID: 2075
	[UnrealObjectPath("/Script/SlateCore.SlateColor")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FSlateColor : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600B5BC RID: 46524 RVA: 0x00121270 File Offset: 0x0011F470
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSlateColor._ScriptStructPtr != 0) ? FSlateColor._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SlateCore.SlateColor", ref FSlateColor._ScriptStructPtr);
		}

		// Token: 0x17002206 RID: 8710
		// (get) Token: 0x0600B5BD RID: 46525 RVA: 0x00121294 File Offset: 0x0011F494
		// (set) Token: 0x0600B5BE RID: 46526 RVA: 0x001212A8 File Offset: 0x0011F4A8
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

		// Token: 0x17002207 RID: 8711
		// (get) Token: 0x0600B5BF RID: 46527 RVA: 0x001212BD File Offset: 0x0011F4BD
		// (set) Token: 0x0600B5C0 RID: 46528 RVA: 0x001212D1 File Offset: 0x0011F4D1
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

		// Token: 0x0600B5C1 RID: 46529 RVA: 0x001212E6 File Offset: 0x0011F4E6
		public FSlateColor()
		{
		}

		// Token: 0x0600B5C2 RID: 46530 RVA: 0x001212EE File Offset: 0x0011F4EE
		protected override IntPtr GetUStructPtr()
		{
			return FSlateColor.StaticStruct();
		}

		// Token: 0x0600B5C3 RID: 46531 RVA: 0x001212FA File Offset: 0x0011F4FA
		[NullableContext(2)]
		public FSlateColor(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600B5C4 RID: 46532 RVA: 0x00121304 File Offset: 0x0011F504
		public FSlateColor(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600B5C5 RID: 46533 RVA: 0x0012130F File Offset: 0x0011F50F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSlateColor(Pointer, false, true);
		}

		// Token: 0x0600B5C6 RID: 46534 RVA: 0x00121319 File Offset: 0x0011F519
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSlateColor(Pointer, MemoryOwner);
		}

		// Token: 0x04005219 RID: 21017
		[Nullable(1)]
		public const string __ObjectPath = "/Script/SlateCore.SlateColor";

		// Token: 0x0400521A RID: 21018
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400521B RID: 21019
		internal static int __PropertyOffset_SpecifiedColor;

		// Token: 0x0400521C RID: 21020
		internal static int __PropertyOffset_ColorUseRule;
	}
}
