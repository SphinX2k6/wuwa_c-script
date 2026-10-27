using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001B68 RID: 7016
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialNamedColor_SI")]
	[UnrealStructLayout(28, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 28)]
	public class FKuroMaterialNamedColor_SI : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601A8EA RID: 108778 RVA: 0x002728BA File Offset: 0x00270ABA
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroMaterialNamedColor_SI._ScriptStructPtr != 0) ? FKuroMaterialNamedColor_SI._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialNamedColor_SI", ref FKuroMaterialNamedColor_SI._ScriptStructPtr);
		}

		// Token: 0x17006AB9 RID: 27321
		// (get) Token: 0x0601A8EB RID: 108779 RVA: 0x002728DE File Offset: 0x00270ADE
		// (set) Token: 0x0601A8EC RID: 108780 RVA: 0x002728F2 File Offset: 0x00270AF2
		public unsafe FName Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroMaterialNamedColor_SI.__PropertyOffset_Name);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMaterialNamedColor_SI.__PropertyOffset_Name) = value;
			}
		}

		// Token: 0x17006ABA RID: 27322
		// (get) Token: 0x0601A8ED RID: 108781 RVA: 0x00272907 File Offset: 0x00270B07
		// (set) Token: 0x0601A8EE RID: 108782 RVA: 0x0027291B File Offset: 0x00270B1B
		public unsafe FLinearColor Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroMaterialNamedColor_SI.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroMaterialNamedColor_SI.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x0601A8EF RID: 108783 RVA: 0x00272930 File Offset: 0x00270B30
		public FKuroMaterialNamedColor_SI()
		{
		}

		// Token: 0x0601A8F0 RID: 108784 RVA: 0x00272938 File Offset: 0x00270B38
		public FKuroMaterialNamedColor_SI(FName Name, FLinearColor Value)
		{
			this.Name = Name;
			this.Value = Value;
		}

		// Token: 0x0601A8F1 RID: 108785 RVA: 0x0027294E File Offset: 0x00270B4E
		protected override IntPtr GetUStructPtr()
		{
			return FKuroMaterialNamedColor_SI.StaticStruct();
		}

		// Token: 0x0601A8F2 RID: 108786 RVA: 0x0027295A File Offset: 0x00270B5A
		[NullableContext(2)]
		public FKuroMaterialNamedColor_SI(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601A8F3 RID: 108787 RVA: 0x00272964 File Offset: 0x00270B64
		public FKuroMaterialNamedColor_SI(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601A8F4 RID: 108788 RVA: 0x0027296F File Offset: 0x00270B6F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroMaterialNamedColor_SI(Pointer, false, true);
		}

		// Token: 0x0601A8F5 RID: 108789 RVA: 0x00272979 File Offset: 0x00270B79
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroMaterialNamedColor_SI(Pointer, MemoryOwner);
		}

		// Token: 0x0400E619 RID: 58905
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroMaterialNamedColor_SI";

		// Token: 0x0400E61A RID: 58906
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400E61B RID: 58907
		internal static int __PropertyOffset_Name;

		// Token: 0x0400E61C RID: 58908
		internal static int __PropertyOffset_Value;
	}
}
