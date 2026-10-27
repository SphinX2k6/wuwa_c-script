using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000BF6 RID: 3062
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.FunctionExpressionOutput")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FFunctionExpressionOutput : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06009717 RID: 38679 RVA: 0x000D77A5 File Offset: 0x000D59A5
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FFunctionExpressionOutput._ScriptStructPtr != 0) ? FFunctionExpressionOutput._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.FunctionExpressionOutput", ref FFunctionExpressionOutput._ScriptStructPtr);
		}

		// Token: 0x1700243D RID: 9277
		// (get) Token: 0x06009718 RID: 38680 RVA: 0x000D77C9 File Offset: 0x000D59C9
		// (set) Token: 0x06009719 RID: 38681 RVA: 0x000D77DD File Offset: 0x000D59DD
		[Nullable(2)]
		public unsafe UMaterialExpressionFunctionOutput ExpressionOutput
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialExpressionFunctionOutput>(base.NativePtr / (IntPtr)sizeof(void*) + FFunctionExpressionOutput.__PropertyOffset_ExpressionOutput);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FFunctionExpressionOutput.__PropertyOffset_ExpressionOutput, value);
			}
		}

		// Token: 0x1700243E RID: 9278
		// (get) Token: 0x0600971A RID: 38682 RVA: 0x000D77F2 File Offset: 0x000D59F2
		// (set) Token: 0x0600971B RID: 38683 RVA: 0x000D7806 File Offset: 0x000D5A06
		public unsafe FGuid ExpressionOutputId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FFunctionExpressionOutput.__PropertyOffset_ExpressionOutputId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FFunctionExpressionOutput.__PropertyOffset_ExpressionOutputId) = value;
			}
		}

		// Token: 0x1700243F RID: 9279
		// (get) Token: 0x0600971C RID: 38684 RVA: 0x000D781C File Offset: 0x000D5A1C
		// (set) Token: 0x0600971D RID: 38685 RVA: 0x000D785F File Offset: 0x000D5A5F
		public FExpressionOutput Output
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionOutput result;
				if ((result = this._Output) == null)
				{
					result = (this._Output = new FExpressionOutput(base.NativePtr + (IntPtr)FFunctionExpressionOutput.__PropertyOffset_Output, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionOutput.StaticStruct(), base.NativePtr + (IntPtr)FFunctionExpressionOutput.__PropertyOffset_Output, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600971E RID: 38686 RVA: 0x000D7880 File Offset: 0x000D5A80
		public FFunctionExpressionOutput()
		{
		}

		// Token: 0x0600971F RID: 38687 RVA: 0x000D7888 File Offset: 0x000D5A88
		public FFunctionExpressionOutput(UMaterialExpressionFunctionOutput ExpressionOutput, FGuid ExpressionOutputId, FExpressionOutput Output)
		{
			this.ExpressionOutput = ExpressionOutput;
			this.ExpressionOutputId = ExpressionOutputId;
			this.Output = Output;
		}

		// Token: 0x06009720 RID: 38688 RVA: 0x000D78A5 File Offset: 0x000D5AA5
		protected override IntPtr GetUStructPtr()
		{
			return FFunctionExpressionOutput.StaticStruct();
		}

		// Token: 0x06009721 RID: 38689 RVA: 0x000D78B1 File Offset: 0x000D5AB1
		[NullableContext(2)]
		public FFunctionExpressionOutput(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06009722 RID: 38690 RVA: 0x000D78BB File Offset: 0x000D5ABB
		public FFunctionExpressionOutput(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06009723 RID: 38691 RVA: 0x000D78C6 File Offset: 0x000D5AC6
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FFunctionExpressionOutput(Pointer, false, true);
		}

		// Token: 0x06009724 RID: 38692 RVA: 0x000D78D0 File Offset: 0x000D5AD0
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FFunctionExpressionOutput(Pointer, MemoryOwner);
		}

		// Token: 0x040054B6 RID: 21686
		public const string __ObjectPath = "/Script/Engine.FunctionExpressionOutput";

		// Token: 0x040054B7 RID: 21687
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040054B8 RID: 21688
		internal static int __PropertyOffset_ExpressionOutput;

		// Token: 0x040054B9 RID: 21689
		internal static int __PropertyOffset_ExpressionOutputId;

		// Token: 0x040054BA RID: 21690
		internal static int __PropertyOffset_Output;

		// Token: 0x040054BB RID: 21691
		[Nullable(2)]
		private FExpressionOutput _Output;
	}
}
