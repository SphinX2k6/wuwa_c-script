using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000E88 RID: 3720
	[UnrealObjectPath("/Script/Engine.MaterialInput")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FMaterialInput : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600C684 RID: 50820 RVA: 0x0011FA6E File Offset: 0x0011DC6E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMaterialInput._ScriptStructPtr != 0) ? FMaterialInput._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.MaterialInput", ref FMaterialInput._ScriptStructPtr);
		}

		// Token: 0x17002E11 RID: 11793
		// (get) Token: 0x0600C685 RID: 50821 RVA: 0x0011FA92 File Offset: 0x0011DC92
		// (set) Token: 0x0600C686 RID: 50822 RVA: 0x0011FAA2 File Offset: 0x0011DCA2
		public unsafe int OutputIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMaterialInput.__PropertyOffset_OutputIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMaterialInput.__PropertyOffset_OutputIndex) = value;
			}
		}

		// Token: 0x17002E12 RID: 11794
		// (get) Token: 0x0600C687 RID: 50823 RVA: 0x0011FAB3 File Offset: 0x0011DCB3
		// (set) Token: 0x0600C688 RID: 50824 RVA: 0x0011FAC7 File Offset: 0x0011DCC7
		public unsafe FName ExpressionName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMaterialInput.__PropertyOffset_ExpressionName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMaterialInput.__PropertyOffset_ExpressionName) = value;
			}
		}

		// Token: 0x0600C689 RID: 50825 RVA: 0x0011FADC File Offset: 0x0011DCDC
		public FMaterialInput()
		{
		}

		// Token: 0x0600C68A RID: 50826 RVA: 0x0011FAE4 File Offset: 0x0011DCE4
		[NullableContext(1)]
		public FMaterialInput(UMaterialExpression Expression, int OutputIndex, FName InputName, int Mask, int MaskR, int MaskG, int MaskB, int MaskA, FName ExpressionName)
		{
			this.OutputIndex = OutputIndex;
			this.ExpressionName = ExpressionName;
		}

		// Token: 0x0600C68B RID: 50827 RVA: 0x0011FAFB File Offset: 0x0011DCFB
		protected override IntPtr GetUStructPtr()
		{
			return FMaterialInput.StaticStruct();
		}

		// Token: 0x0600C68C RID: 50828 RVA: 0x0011FB07 File Offset: 0x0011DD07
		[NullableContext(2)]
		public FMaterialInput(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600C68D RID: 50829 RVA: 0x0011FB11 File Offset: 0x0011DD11
		public FMaterialInput(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600C68E RID: 50830 RVA: 0x0011FB1C File Offset: 0x0011DD1C
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMaterialInput(Pointer, false, true);
		}

		// Token: 0x0600C68F RID: 50831 RVA: 0x0011FB26 File Offset: 0x0011DD26
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMaterialInput(Pointer, MemoryOwner);
		}

		// Token: 0x04006A4B RID: 27211
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.MaterialInput";

		// Token: 0x04006A4C RID: 27212
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04006A4D RID: 27213
		internal static int __PropertyOffset_OutputIndex;

		// Token: 0x04006A4E RID: 27214
		internal static int __PropertyOffset_ExpressionName;
	}
}
