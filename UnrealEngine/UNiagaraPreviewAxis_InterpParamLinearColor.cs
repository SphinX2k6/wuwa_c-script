using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020025D1 RID: 9681
	[UnrealObjectPath("/Script/Niagara.NiagaraPreviewAxis_InterpParamLinearColor")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 96)]
	public class UNiagaraPreviewAxis_InterpParamLinearColor : UNiagaraPreviewAxis_InterpParamBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023FA6 RID: 147366 RVA: 0x0035376C File Offset: 0x0035196C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraPreviewAxis_InterpParamLinearColor._ClassPtr;
		}

		// Token: 0x06023FA7 RID: 147367 RVA: 0x00353778 File Offset: 0x00351978
		public UNiagaraPreviewAxis_InterpParamLinearColor() : this(BuiltinUtils.AllocNativeUObject(UNiagaraPreviewAxis_InterpParamLinearColor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023FA8 RID: 147368 RVA: 0x003537A0 File Offset: 0x003519A0
		[NullableContext(1)]
		public UNiagaraPreviewAxis_InterpParamLinearColor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNiagaraPreviewAxis_InterpParamLinearColor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008A58 RID: 35416
		// (get) Token: 0x06023FA9 RID: 147369 RVA: 0x003537D3 File Offset: 0x003519D3
		// (set) Token: 0x06023FAA RID: 147370 RVA: 0x003537E7 File Offset: 0x003519E7
		public unsafe FLinearColor Min
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraPreviewAxis_InterpParamLinearColor.__PropertyOffset_Min);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraPreviewAxis_InterpParamLinearColor.__PropertyOffset_Min) = value;
			}
		}

		// Token: 0x17008A59 RID: 35417
		// (get) Token: 0x06023FAB RID: 147371 RVA: 0x003537FC File Offset: 0x003519FC
		// (set) Token: 0x06023FAC RID: 147372 RVA: 0x00353810 File Offset: 0x00351A10
		public unsafe FLinearColor Max
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraPreviewAxis_InterpParamLinearColor.__PropertyOffset_Max);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraPreviewAxis_InterpParamLinearColor.__PropertyOffset_Max) = value;
			}
		}

		// Token: 0x06023FAD RID: 147373 RVA: 0x00353825 File Offset: 0x00351A25
		static UNiagaraPreviewAxis_InterpParamLinearColor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.NiagaraPreviewAxis_InterpParamLinearColor");
		}

		// Token: 0x06023FAE RID: 147374 RVA: 0x00353833 File Offset: 0x00351A33
		protected UNiagaraPreviewAxis_InterpParamLinearColor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040134A1 RID: 79009
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Niagara.NiagaraPreviewAxis_InterpParamLinearColor";

		// Token: 0x040134A2 RID: 79010
		private static IntPtr _ClassPtr;

		// Token: 0x040134A3 RID: 79011
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040134A4 RID: 79012
		internal static int __PropertyOffset_Min;

		// Token: 0x040134A5 RID: 79013
		internal static int __PropertyOffset_Max;
	}
}
