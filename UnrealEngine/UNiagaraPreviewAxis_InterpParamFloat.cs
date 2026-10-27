using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020025CF RID: 9679
	[UnrealObjectPath("/Script/Niagara.NiagaraPreviewAxis_InterpParamFloat")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class UNiagaraPreviewAxis_InterpParamFloat : UNiagaraPreviewAxis_InterpParamBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023F94 RID: 147348 RVA: 0x003535E9 File Offset: 0x003517E9
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraPreviewAxis_InterpParamFloat._ClassPtr;
		}

		// Token: 0x06023F95 RID: 147349 RVA: 0x003535F8 File Offset: 0x003517F8
		public UNiagaraPreviewAxis_InterpParamFloat() : this(BuiltinUtils.AllocNativeUObject(UNiagaraPreviewAxis_InterpParamFloat.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023F96 RID: 147350 RVA: 0x00353620 File Offset: 0x00351820
		[NullableContext(1)]
		public UNiagaraPreviewAxis_InterpParamFloat(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNiagaraPreviewAxis_InterpParamFloat.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008A54 RID: 35412
		// (get) Token: 0x06023F97 RID: 147351 RVA: 0x00353653 File Offset: 0x00351853
		// (set) Token: 0x06023F98 RID: 147352 RVA: 0x00353663 File Offset: 0x00351863
		public unsafe float Min
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraPreviewAxis_InterpParamFloat.__PropertyOffset_Min);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraPreviewAxis_InterpParamFloat.__PropertyOffset_Min) = value;
			}
		}

		// Token: 0x17008A55 RID: 35413
		// (get) Token: 0x06023F99 RID: 147353 RVA: 0x00353674 File Offset: 0x00351874
		// (set) Token: 0x06023F9A RID: 147354 RVA: 0x00353684 File Offset: 0x00351884
		public unsafe float Max
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraPreviewAxis_InterpParamFloat.__PropertyOffset_Max);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraPreviewAxis_InterpParamFloat.__PropertyOffset_Max) = value;
			}
		}

		// Token: 0x06023F9B RID: 147355 RVA: 0x00353695 File Offset: 0x00351895
		static UNiagaraPreviewAxis_InterpParamFloat()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.NiagaraPreviewAxis_InterpParamFloat");
		}

		// Token: 0x06023F9C RID: 147356 RVA: 0x003536A3 File Offset: 0x003518A3
		protected UNiagaraPreviewAxis_InterpParamFloat(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013497 RID: 78999
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Niagara.NiagaraPreviewAxis_InterpParamFloat";

		// Token: 0x04013498 RID: 79000
		private static IntPtr _ClassPtr;

		// Token: 0x04013499 RID: 79001
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401349A RID: 79002
		internal static int __PropertyOffset_Min;

		// Token: 0x0401349B RID: 79003
		internal static int __PropertyOffset_Max;
	}
}
