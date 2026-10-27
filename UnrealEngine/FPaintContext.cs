using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020029C0 RID: 10688
	[UnrealObjectPath("/Script/UMG.PaintContext")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FPaintContext : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602780D RID: 161805 RVA: 0x003C49F9 File Offset: 0x003C2BF9
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPaintContext._ScriptStructPtr != 0) ? FPaintContext._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/UMG.PaintContext", ref FPaintContext._ScriptStructPtr);
		}

		// Token: 0x0602780E RID: 161806 RVA: 0x003C4A1D File Offset: 0x003C2C1D
		public FPaintContext()
		{
		}

		// Token: 0x0602780F RID: 161807 RVA: 0x003C4A25 File Offset: 0x003C2C25
		protected override IntPtr GetUStructPtr()
		{
			return FPaintContext.StaticStruct();
		}

		// Token: 0x06027810 RID: 161808 RVA: 0x003C4A31 File Offset: 0x003C2C31
		[NullableContext(2)]
		public FPaintContext(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06027811 RID: 161809 RVA: 0x003C4A3B File Offset: 0x003C2C3B
		public FPaintContext(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06027812 RID: 161810 RVA: 0x003C4A46 File Offset: 0x003C2C46
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPaintContext(Pointer, false, true);
		}

		// Token: 0x06027813 RID: 161811 RVA: 0x003C4A50 File Offset: 0x003C2C50
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPaintContext(Pointer, MemoryOwner);
		}

		// Token: 0x04015A97 RID: 88727
		[Nullable(1)]
		public const string __ObjectPath = "/Script/UMG.PaintContext";

		// Token: 0x04015A98 RID: 88728
		private static IntPtr _ScriptStructPtr;
	}
}
