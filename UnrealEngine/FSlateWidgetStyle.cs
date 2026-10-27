using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200282F RID: 10287
	[UnrealObjectPath("/Script/SlateCore.SlateWidgetStyle")]
	[UnrealStructLayout(8, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FSlateWidgetStyle : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060263A4 RID: 156580 RVA: 0x003A0556 File Offset: 0x0039E756
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSlateWidgetStyle._ScriptStructPtr != 0) ? FSlateWidgetStyle._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SlateCore.SlateWidgetStyle", ref FSlateWidgetStyle._ScriptStructPtr);
		}

		// Token: 0x060263A5 RID: 156581 RVA: 0x003A057A File Offset: 0x0039E77A
		public FSlateWidgetStyle()
		{
		}

		// Token: 0x060263A6 RID: 156582 RVA: 0x003A0582 File Offset: 0x0039E782
		protected override IntPtr GetUStructPtr()
		{
			return FSlateWidgetStyle.StaticStruct();
		}

		// Token: 0x060263A7 RID: 156583 RVA: 0x003A058E File Offset: 0x0039E78E
		[NullableContext(2)]
		public FSlateWidgetStyle(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060263A8 RID: 156584 RVA: 0x003A0598 File Offset: 0x0039E798
		public FSlateWidgetStyle(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060263A9 RID: 156585 RVA: 0x003A05A3 File Offset: 0x0039E7A3
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSlateWidgetStyle(Pointer, false, true);
		}

		// Token: 0x060263AA RID: 156586 RVA: 0x003A05AD File Offset: 0x0039E7AD
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSlateWidgetStyle(Pointer, MemoryOwner);
		}

		// Token: 0x04014EC4 RID: 85700
		[Nullable(1)]
		public const string __ObjectPath = "/Script/SlateCore.SlateWidgetStyle";

		// Token: 0x04014EC5 RID: 85701
		private static IntPtr _ScriptStructPtr;
	}
}
