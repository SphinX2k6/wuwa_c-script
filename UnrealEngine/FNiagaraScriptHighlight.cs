using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020025E2 RID: 9698
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NiagaraScriptHighlight")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FNiagaraScriptHighlight : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060240D3 RID: 147667 RVA: 0x003556F8 File Offset: 0x003538F8
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNiagaraScriptHighlight._ScriptStructPtr != 0) ? FNiagaraScriptHighlight._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.NiagaraScriptHighlight", ref FNiagaraScriptHighlight._ScriptStructPtr);
		}

		// Token: 0x17008AB6 RID: 35510
		// (get) Token: 0x060240D4 RID: 147668 RVA: 0x0035571C File Offset: 0x0035391C
		// (set) Token: 0x060240D5 RID: 147669 RVA: 0x00355730 File Offset: 0x00353930
		public unsafe FLinearColor Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraScriptHighlight.__PropertyOffset_Color);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraScriptHighlight.__PropertyOffset_Color) = value;
			}
		}

		// Token: 0x17008AB7 RID: 35511
		// (get) Token: 0x060240D6 RID: 147670 RVA: 0x00355748 File Offset: 0x00353948
		// (set) Token: 0x060240D7 RID: 147671 RVA: 0x0035578B File Offset: 0x0035398B
		public unsafe FText DisplayName
		{
			get
			{
				base.FastCheckIsValid();
				FText result;
				if ((result = this._DisplayName) == null)
				{
					result = (this._DisplayName = new FText(base.NativePtr + (IntPtr)FNiagaraScriptHighlight.__PropertyOffset_DisplayName, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				FText.NativeCopy((void*)(base.NativePtr + (byte*)((IntPtr)FNiagaraScriptHighlight.__PropertyOffset_DisplayName)), value.NativePtr, 1);
			}
		}

		// Token: 0x060240D8 RID: 147672 RVA: 0x003557A6 File Offset: 0x003539A6
		public FNiagaraScriptHighlight()
		{
		}

		// Token: 0x060240D9 RID: 147673 RVA: 0x003557AE File Offset: 0x003539AE
		public FNiagaraScriptHighlight(FLinearColor Color, FText DisplayName)
		{
			this.Color = Color;
			this.DisplayName = DisplayName;
		}

		// Token: 0x060240DA RID: 147674 RVA: 0x003557C4 File Offset: 0x003539C4
		protected override IntPtr GetUStructPtr()
		{
			return FNiagaraScriptHighlight.StaticStruct();
		}

		// Token: 0x060240DB RID: 147675 RVA: 0x003557D0 File Offset: 0x003539D0
		[NullableContext(2)]
		public FNiagaraScriptHighlight(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060240DC RID: 147676 RVA: 0x003557DA File Offset: 0x003539DA
		public FNiagaraScriptHighlight(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060240DD RID: 147677 RVA: 0x003557E5 File Offset: 0x003539E5
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNiagaraScriptHighlight(Pointer, false, true);
		}

		// Token: 0x060240DE RID: 147678 RVA: 0x003557EF File Offset: 0x003539EF
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNiagaraScriptHighlight(Pointer, MemoryOwner);
		}

		// Token: 0x04013558 RID: 79192
		public const string __ObjectPath = "/Script/Niagara.NiagaraScriptHighlight";

		// Token: 0x04013559 RID: 79193
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401355A RID: 79194
		internal static int __PropertyOffset_Color;

		// Token: 0x0401355B RID: 79195
		internal static int __PropertyOffset_DisplayName;

		// Token: 0x0401355C RID: 79196
		[Nullable(2)]
		private FText _DisplayName;
	}
}
