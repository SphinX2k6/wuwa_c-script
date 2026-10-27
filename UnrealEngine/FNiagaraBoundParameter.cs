using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002540 RID: 9536
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NiagaraBoundParameter")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 72)]
	public class FNiagaraBoundParameter : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06023646 RID: 144966 RVA: 0x0034567D File Offset: 0x0034387D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNiagaraBoundParameter._ScriptStructPtr != 0) ? FNiagaraBoundParameter._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.NiagaraBoundParameter", ref FNiagaraBoundParameter._ScriptStructPtr);
		}

		// Token: 0x17008805 RID: 34821
		// (get) Token: 0x06023647 RID: 144967 RVA: 0x003456A4 File Offset: 0x003438A4
		// (set) Token: 0x06023648 RID: 144968 RVA: 0x003456E7 File Offset: 0x003438E7
		public FNiagaraVariable Parameter
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraVariable result;
				if ((result = this._Parameter) == null)
				{
					result = (this._Parameter = new FNiagaraVariable(base.NativePtr + (IntPtr)FNiagaraBoundParameter.__PropertyOffset_Parameter, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraVariable.StaticStruct(), base.NativePtr + (IntPtr)FNiagaraBoundParameter.__PropertyOffset_Parameter, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008806 RID: 34822
		// (get) Token: 0x06023649 RID: 144969 RVA: 0x00345708 File Offset: 0x00343908
		// (set) Token: 0x0602364A RID: 144970 RVA: 0x00345718 File Offset: 0x00343918
		public unsafe int SrcOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraBoundParameter.__PropertyOffset_SrcOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraBoundParameter.__PropertyOffset_SrcOffset) = value;
			}
		}

		// Token: 0x17008807 RID: 34823
		// (get) Token: 0x0602364B RID: 144971 RVA: 0x00345729 File Offset: 0x00343929
		// (set) Token: 0x0602364C RID: 144972 RVA: 0x00345739 File Offset: 0x00343939
		public unsafe int DestOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraBoundParameter.__PropertyOffset_DestOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraBoundParameter.__PropertyOffset_DestOffset) = value;
			}
		}

		// Token: 0x0602364D RID: 144973 RVA: 0x0034574A File Offset: 0x0034394A
		public FNiagaraBoundParameter()
		{
		}

		// Token: 0x0602364E RID: 144974 RVA: 0x00345752 File Offset: 0x00343952
		public FNiagaraBoundParameter(FNiagaraVariable Parameter, int SrcOffset, int DestOffset)
		{
			this.Parameter = Parameter;
			this.SrcOffset = SrcOffset;
			this.DestOffset = DestOffset;
		}

		// Token: 0x0602364F RID: 144975 RVA: 0x0034576F File Offset: 0x0034396F
		protected override IntPtr GetUStructPtr()
		{
			return FNiagaraBoundParameter.StaticStruct();
		}

		// Token: 0x06023650 RID: 144976 RVA: 0x0034577B File Offset: 0x0034397B
		[NullableContext(2)]
		public FNiagaraBoundParameter(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06023651 RID: 144977 RVA: 0x00345785 File Offset: 0x00343985
		public FNiagaraBoundParameter(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06023652 RID: 144978 RVA: 0x00345790 File Offset: 0x00343990
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNiagaraBoundParameter(Pointer, false, true);
		}

		// Token: 0x06023653 RID: 144979 RVA: 0x0034579A File Offset: 0x0034399A
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNiagaraBoundParameter(Pointer, MemoryOwner);
		}

		// Token: 0x04012FEA RID: 77802
		public const string __ObjectPath = "/Script/Niagara.NiagaraBoundParameter";

		// Token: 0x04012FEB RID: 77803
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012FEC RID: 77804
		internal static int __PropertyOffset_Parameter;

		// Token: 0x04012FED RID: 77805
		[Nullable(2)]
		private FNiagaraVariable _Parameter;

		// Token: 0x04012FEE RID: 77806
		internal static int __PropertyOffset_SrcOffset;

		// Token: 0x04012FEF RID: 77807
		internal static int __PropertyOffset_DestOffset;
	}
}
