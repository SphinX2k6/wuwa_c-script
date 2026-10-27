using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200098C RID: 2444
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.CustomInput")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 72)]
	public class FCustomInput : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06008A19 RID: 35353 RVA: 0x000C5CA6 File Offset: 0x000C3EA6
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCustomInput._ScriptStructPtr != 0) ? FCustomInput._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.CustomInput", ref FCustomInput._ScriptStructPtr);
		}

		// Token: 0x1700208C RID: 8332
		// (get) Token: 0x06008A1A RID: 35354 RVA: 0x000C5CCA File Offset: 0x000C3ECA
		// (set) Token: 0x06008A1B RID: 35355 RVA: 0x000C5CDE File Offset: 0x000C3EDE
		public unsafe FName InputName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCustomInput.__PropertyOffset_InputName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCustomInput.__PropertyOffset_InputName) = value;
			}
		}

		// Token: 0x1700208D RID: 8333
		// (get) Token: 0x06008A1C RID: 35356 RVA: 0x000C5CF4 File Offset: 0x000C3EF4
		// (set) Token: 0x06008A1D RID: 35357 RVA: 0x000C5D37 File Offset: 0x000C3F37
		public FExpressionInput Input
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Input) == null)
				{
					result = (this._Input = new FExpressionInput(base.NativePtr + (IntPtr)FCustomInput.__PropertyOffset_Input, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)FCustomInput.__PropertyOffset_Input, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06008A1E RID: 35358 RVA: 0x000C5D58 File Offset: 0x000C3F58
		public FCustomInput()
		{
		}

		// Token: 0x06008A1F RID: 35359 RVA: 0x000C5D60 File Offset: 0x000C3F60
		public FCustomInput(FName InputName, FExpressionInput Input)
		{
			this.InputName = InputName;
			this.Input = Input;
		}

		// Token: 0x06008A20 RID: 35360 RVA: 0x000C5D76 File Offset: 0x000C3F76
		protected override IntPtr GetUStructPtr()
		{
			return FCustomInput.StaticStruct();
		}

		// Token: 0x06008A21 RID: 35361 RVA: 0x000C5D82 File Offset: 0x000C3F82
		[NullableContext(2)]
		public FCustomInput(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008A22 RID: 35362 RVA: 0x000C5D8C File Offset: 0x000C3F8C
		public FCustomInput(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008A23 RID: 35363 RVA: 0x000C5D97 File Offset: 0x000C3F97
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCustomInput(Pointer, false, true);
		}

		// Token: 0x06008A24 RID: 35364 RVA: 0x000C5DA1 File Offset: 0x000C3FA1
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCustomInput(Pointer, MemoryOwner);
		}

		// Token: 0x0400418F RID: 16783
		public const string __ObjectPath = "/Script/Engine.CustomInput";

		// Token: 0x04004190 RID: 16784
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04004191 RID: 16785
		internal static int __PropertyOffset_InputName;

		// Token: 0x04004192 RID: 16786
		internal static int __PropertyOffset_Input;

		// Token: 0x04004193 RID: 16787
		[Nullable(2)]
		private FExpressionInput _Input;
	}
}
