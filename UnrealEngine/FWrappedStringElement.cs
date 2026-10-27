using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001297 RID: 4759
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.WrappedStringElement")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FWrappedStringElement : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06011771 RID: 71537 RVA: 0x0019A38E File Offset: 0x0019858E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FWrappedStringElement._ScriptStructPtr != 0) ? FWrappedStringElement._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.WrappedStringElement", ref FWrappedStringElement._ScriptStructPtr);
		}

		// Token: 0x1700441F RID: 17439
		// (get) Token: 0x06011772 RID: 71538 RVA: 0x0019A3B2 File Offset: 0x001985B2
		// (set) Token: 0x06011773 RID: 71539 RVA: 0x0019A3C6 File Offset: 0x001985C6
		public unsafe string Value
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FWrappedStringElement.__PropertyOffset_Value)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FWrappedStringElement.__PropertyOffset_Value)), value);
			}
		}

		// Token: 0x17004420 RID: 17440
		// (get) Token: 0x06011774 RID: 71540 RVA: 0x0019A3DB File Offset: 0x001985DB
		// (set) Token: 0x06011775 RID: 71541 RVA: 0x0019A3EF File Offset: 0x001985EF
		public unsafe FVector2D LineExtent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWrappedStringElement.__PropertyOffset_LineExtent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWrappedStringElement.__PropertyOffset_LineExtent) = value;
			}
		}

		// Token: 0x06011776 RID: 71542 RVA: 0x0019A404 File Offset: 0x00198604
		public FWrappedStringElement()
		{
		}

		// Token: 0x06011777 RID: 71543 RVA: 0x0019A40C File Offset: 0x0019860C
		public FWrappedStringElement(string Value, FVector2D LineExtent)
		{
			this.Value = Value;
			this.LineExtent = LineExtent;
		}

		// Token: 0x06011778 RID: 71544 RVA: 0x0019A422 File Offset: 0x00198622
		protected override IntPtr GetUStructPtr()
		{
			return FWrappedStringElement.StaticStruct();
		}

		// Token: 0x06011779 RID: 71545 RVA: 0x0019A42E File Offset: 0x0019862E
		[NullableContext(2)]
		public FWrappedStringElement(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601177A RID: 71546 RVA: 0x0019A438 File Offset: 0x00198638
		public FWrappedStringElement(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601177B RID: 71547 RVA: 0x0019A443 File Offset: 0x00198643
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FWrappedStringElement(Pointer, false, true);
		}

		// Token: 0x0601177C RID: 71548 RVA: 0x0019A44D File Offset: 0x0019864D
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FWrappedStringElement(Pointer, MemoryOwner);
		}

		// Token: 0x04009592 RID: 38290
		public const string __ObjectPath = "/Script/Engine.WrappedStringElement";

		// Token: 0x04009593 RID: 38291
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04009594 RID: 38292
		internal static int __PropertyOffset_Value;

		// Token: 0x04009595 RID: 38293
		internal static int __PropertyOffset_LineExtent;
	}
}
