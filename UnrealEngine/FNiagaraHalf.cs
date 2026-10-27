using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020025AE RID: 9646
	[UnrealObjectPath("/Script/Niagara.NiagaraHalf")]
	[UnrealStructLayout(2, 2, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 2)]
	public class FNiagaraHalf : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06023D5F RID: 146783 RVA: 0x0034FF4C File Offset: 0x0034E14C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNiagaraHalf._ScriptStructPtr != 0) ? FNiagaraHalf._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.NiagaraHalf", ref FNiagaraHalf._ScriptStructPtr);
		}

		// Token: 0x170089BB RID: 35259
		// (get) Token: 0x06023D60 RID: 146784 RVA: 0x0034FF70 File Offset: 0x0034E170
		// (set) Token: 0x06023D61 RID: 146785 RVA: 0x0034FF80 File Offset: 0x0034E180
		public unsafe ushort Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraHalf.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraHalf.__PropertyOffset_Value) = (short)value;
			}
		}

		// Token: 0x06023D62 RID: 146786 RVA: 0x0034FF91 File Offset: 0x0034E191
		public FNiagaraHalf()
		{
		}

		// Token: 0x06023D63 RID: 146787 RVA: 0x0034FF99 File Offset: 0x0034E199
		public FNiagaraHalf(ushort Value)
		{
			this.Value = Value;
		}

		// Token: 0x06023D64 RID: 146788 RVA: 0x0034FFA8 File Offset: 0x0034E1A8
		protected override IntPtr GetUStructPtr()
		{
			return FNiagaraHalf.StaticStruct();
		}

		// Token: 0x06023D65 RID: 146789 RVA: 0x0034FFB4 File Offset: 0x0034E1B4
		[NullableContext(2)]
		public FNiagaraHalf(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06023D66 RID: 146790 RVA: 0x0034FFBE File Offset: 0x0034E1BE
		public FNiagaraHalf(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06023D67 RID: 146791 RVA: 0x0034FFC9 File Offset: 0x0034E1C9
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNiagaraHalf(Pointer, false, true);
		}

		// Token: 0x06023D68 RID: 146792 RVA: 0x0034FFD3 File Offset: 0x0034E1D3
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNiagaraHalf(Pointer, MemoryOwner);
		}

		// Token: 0x04013372 RID: 78706
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Niagara.NiagaraHalf";

		// Token: 0x04013373 RID: 78707
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013374 RID: 78708
		internal static int __PropertyOffset_Value;
	}
}
