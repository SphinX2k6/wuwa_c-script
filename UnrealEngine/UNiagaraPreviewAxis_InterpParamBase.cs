using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020025CE RID: 9678
	[UnrealObjectPath("/Script/Niagara.NiagaraPreviewAxis_InterpParamBase")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public abstract class UNiagaraPreviewAxis_InterpParamBase : UNiagaraPreviewAxis, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023F8C RID: 147340 RVA: 0x00353551 File Offset: 0x00351751
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraPreviewAxis_InterpParamBase._ClassPtr;
		}

		// Token: 0x17008A52 RID: 35410
		// (get) Token: 0x06023F8D RID: 147341 RVA: 0x0035355D File Offset: 0x0035175D
		// (set) Token: 0x06023F8E RID: 147342 RVA: 0x00353571 File Offset: 0x00351771
		public unsafe FName Param
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraPreviewAxis_InterpParamBase.__PropertyOffset_Param);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraPreviewAxis_InterpParamBase.__PropertyOffset_Param) = value;
			}
		}

		// Token: 0x17008A53 RID: 35411
		// (get) Token: 0x06023F8F RID: 147343 RVA: 0x00353586 File Offset: 0x00351786
		// (set) Token: 0x06023F90 RID: 147344 RVA: 0x00353596 File Offset: 0x00351796
		public unsafe int Count
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraPreviewAxis_InterpParamBase.__PropertyOffset_Count);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraPreviewAxis_InterpParamBase.__PropertyOffset_Count) = value;
			}
		}

		// Token: 0x06023F91 RID: 147345 RVA: 0x003535A7 File Offset: 0x003517A7
		static UNiagaraPreviewAxis_InterpParamBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.NiagaraPreviewAxis_InterpParamBase");
		}

		// Token: 0x06023F92 RID: 147346 RVA: 0x003535B8 File Offset: 0x003517B8
		protected UNiagaraPreviewAxis_InterpParamBase() : this(BuiltinUtils.AllocNativeUObject(UNiagaraPreviewAxis_InterpParamBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023F93 RID: 147347 RVA: 0x003535E0 File Offset: 0x003517E0
		protected UNiagaraPreviewAxis_InterpParamBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013492 RID: 78994
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Niagara.NiagaraPreviewAxis_InterpParamBase";

		// Token: 0x04013493 RID: 78995
		private static IntPtr _ClassPtr;

		// Token: 0x04013494 RID: 78996
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013495 RID: 78997
		internal static int __PropertyOffset_Param;

		// Token: 0x04013496 RID: 78998
		internal static int __PropertyOffset_Count;
	}
}
