using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020025D2 RID: 9682
	[UnrealObjectPath("/Script/Niagara.NiagaraPreviewAxis_InterpParamVector")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 88)]
	public class UNiagaraPreviewAxis_InterpParamVector : UNiagaraPreviewAxis_InterpParamBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023FAF RID: 147375 RVA: 0x0035383C File Offset: 0x00351A3C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraPreviewAxis_InterpParamVector._ClassPtr;
		}

		// Token: 0x06023FB0 RID: 147376 RVA: 0x00353848 File Offset: 0x00351A48
		public UNiagaraPreviewAxis_InterpParamVector() : this(BuiltinUtils.AllocNativeUObject(UNiagaraPreviewAxis_InterpParamVector.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023FB1 RID: 147377 RVA: 0x00353870 File Offset: 0x00351A70
		[NullableContext(1)]
		public UNiagaraPreviewAxis_InterpParamVector(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNiagaraPreviewAxis_InterpParamVector.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008A5A RID: 35418
		// (get) Token: 0x06023FB2 RID: 147378 RVA: 0x003538A3 File Offset: 0x00351AA3
		// (set) Token: 0x06023FB3 RID: 147379 RVA: 0x003538B7 File Offset: 0x00351AB7
		public unsafe FVector Min
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraPreviewAxis_InterpParamVector.__PropertyOffset_Min);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraPreviewAxis_InterpParamVector.__PropertyOffset_Min) = value;
			}
		}

		// Token: 0x17008A5B RID: 35419
		// (get) Token: 0x06023FB4 RID: 147380 RVA: 0x003538CC File Offset: 0x00351ACC
		// (set) Token: 0x06023FB5 RID: 147381 RVA: 0x003538E0 File Offset: 0x00351AE0
		public unsafe FVector Max
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraPreviewAxis_InterpParamVector.__PropertyOffset_Max);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraPreviewAxis_InterpParamVector.__PropertyOffset_Max) = value;
			}
		}

		// Token: 0x06023FB6 RID: 147382 RVA: 0x003538F5 File Offset: 0x00351AF5
		static UNiagaraPreviewAxis_InterpParamVector()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.NiagaraPreviewAxis_InterpParamVector");
		}

		// Token: 0x06023FB7 RID: 147383 RVA: 0x00353903 File Offset: 0x00351B03
		protected UNiagaraPreviewAxis_InterpParamVector(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040134A6 RID: 79014
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Niagara.NiagaraPreviewAxis_InterpParamVector";

		// Token: 0x040134A7 RID: 79015
		private static IntPtr _ClassPtr;

		// Token: 0x040134A8 RID: 79016
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040134A9 RID: 79017
		internal static int __PropertyOffset_Min;

		// Token: 0x040134AA RID: 79018
		internal static int __PropertyOffset_Max;
	}
}
