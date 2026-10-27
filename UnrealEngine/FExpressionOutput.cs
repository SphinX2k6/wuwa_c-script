using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000BCE RID: 3022
	[UnrealObjectPath("/Script/Engine.ExpressionOutput")]
	[UnrealStructLayout(32, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FExpressionOutput : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06009490 RID: 38032 RVA: 0x000D40DD File Offset: 0x000D22DD
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FExpressionOutput._ScriptStructPtr != 0) ? FExpressionOutput._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.ExpressionOutput", ref FExpressionOutput._ScriptStructPtr);
		}

		// Token: 0x17002392 RID: 9106
		// (get) Token: 0x06009491 RID: 38033 RVA: 0x000D4101 File Offset: 0x000D2301
		// (set) Token: 0x06009492 RID: 38034 RVA: 0x000D4115 File Offset: 0x000D2315
		public unsafe FName OutputName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FExpressionOutput.__PropertyOffset_OutputName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FExpressionOutput.__PropertyOffset_OutputName) = value;
			}
		}

		// Token: 0x06009493 RID: 38035 RVA: 0x000D412A File Offset: 0x000D232A
		public FExpressionOutput()
		{
		}

		// Token: 0x06009494 RID: 38036 RVA: 0x000D4132 File Offset: 0x000D2332
		public FExpressionOutput(FName OutputName, int Mask, int MaskR, int MaskG, int MaskB, int MaskA)
		{
			this.OutputName = OutputName;
		}

		// Token: 0x06009495 RID: 38037 RVA: 0x000D4141 File Offset: 0x000D2341
		protected override IntPtr GetUStructPtr()
		{
			return FExpressionOutput.StaticStruct();
		}

		// Token: 0x06009496 RID: 38038 RVA: 0x000D414D File Offset: 0x000D234D
		[NullableContext(2)]
		public FExpressionOutput(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06009497 RID: 38039 RVA: 0x000D4157 File Offset: 0x000D2357
		public FExpressionOutput(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06009498 RID: 38040 RVA: 0x000D4162 File Offset: 0x000D2362
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FExpressionOutput(Pointer, false, true);
		}

		// Token: 0x06009499 RID: 38041 RVA: 0x000D416C File Offset: 0x000D236C
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FExpressionOutput(Pointer, MemoryOwner);
		}

		// Token: 0x04005376 RID: 21366
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ExpressionOutput";

		// Token: 0x04005377 RID: 21367
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04005378 RID: 21368
		internal static int __PropertyOffset_OutputName;
	}
}
