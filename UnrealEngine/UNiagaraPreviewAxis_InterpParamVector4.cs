using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020025D4 RID: 9684
	[UnrealObjectPath("/Script/Niagara.NiagaraPreviewAxis_InterpParamVector4")]
	[UnrealStructLayout(96, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 96)]
	public class UNiagaraPreviewAxis_InterpParamVector4 : UNiagaraPreviewAxis_InterpParamBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023FC1 RID: 147393 RVA: 0x003539DC File Offset: 0x00351BDC
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraPreviewAxis_InterpParamVector4._ClassPtr;
		}

		// Token: 0x06023FC2 RID: 147394 RVA: 0x003539E8 File Offset: 0x00351BE8
		public UNiagaraPreviewAxis_InterpParamVector4() : this(BuiltinUtils.AllocNativeUObject(UNiagaraPreviewAxis_InterpParamVector4.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023FC3 RID: 147395 RVA: 0x00353A10 File Offset: 0x00351C10
		[NullableContext(1)]
		public UNiagaraPreviewAxis_InterpParamVector4(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNiagaraPreviewAxis_InterpParamVector4.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008A5E RID: 35422
		// (get) Token: 0x06023FC4 RID: 147396 RVA: 0x00353A43 File Offset: 0x00351C43
		// (set) Token: 0x06023FC5 RID: 147397 RVA: 0x00353A57 File Offset: 0x00351C57
		public unsafe FVector4 Min
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraPreviewAxis_InterpParamVector4.__PropertyOffset_Min);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraPreviewAxis_InterpParamVector4.__PropertyOffset_Min) = value;
			}
		}

		// Token: 0x17008A5F RID: 35423
		// (get) Token: 0x06023FC6 RID: 147398 RVA: 0x00353A6C File Offset: 0x00351C6C
		// (set) Token: 0x06023FC7 RID: 147399 RVA: 0x00353A80 File Offset: 0x00351C80
		public unsafe FVector4 Max
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraPreviewAxis_InterpParamVector4.__PropertyOffset_Max);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraPreviewAxis_InterpParamVector4.__PropertyOffset_Max) = value;
			}
		}

		// Token: 0x06023FC8 RID: 147400 RVA: 0x00353A95 File Offset: 0x00351C95
		static UNiagaraPreviewAxis_InterpParamVector4()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.NiagaraPreviewAxis_InterpParamVector4");
		}

		// Token: 0x06023FC9 RID: 147401 RVA: 0x00353AA3 File Offset: 0x00351CA3
		protected UNiagaraPreviewAxis_InterpParamVector4(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040134B0 RID: 79024
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Niagara.NiagaraPreviewAxis_InterpParamVector4";

		// Token: 0x040134B1 RID: 79025
		private static IntPtr _ClassPtr;

		// Token: 0x040134B2 RID: 79026
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040134B3 RID: 79027
		internal static int __PropertyOffset_Min;

		// Token: 0x040134B4 RID: 79028
		internal static int __PropertyOffset_Max;
	}
}
