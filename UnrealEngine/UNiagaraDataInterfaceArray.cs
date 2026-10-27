using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200255D RID: 9565
	[UnrealObjectPath("/Script/Niagara.NiagaraDataInterfaceArray")]
	[UnrealStructLayout(152, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 152)]
	public abstract class UNiagaraDataInterfaceArray : UNiagaraDataInterface, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023888 RID: 145544 RVA: 0x0034864B File Offset: 0x0034684B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraDataInterfaceArray._ClassPtr;
		}

		// Token: 0x17008863 RID: 34915
		// (get) Token: 0x06023889 RID: 145545 RVA: 0x00348657 File Offset: 0x00346857
		// (set) Token: 0x0602388A RID: 145546 RVA: 0x00348667 File Offset: 0x00346867
		public unsafe int MaxElements
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraDataInterfaceArray.__PropertyOffset_MaxElements);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceArray.__PropertyOffset_MaxElements) = value;
			}
		}

		// Token: 0x0602388B RID: 145547 RVA: 0x00348678 File Offset: 0x00346878
		static UNiagaraDataInterfaceArray()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.NiagaraDataInterfaceArray");
		}

		// Token: 0x0602388C RID: 145548 RVA: 0x00348688 File Offset: 0x00346888
		protected UNiagaraDataInterfaceArray() : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataInterfaceArray.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602388D RID: 145549 RVA: 0x003486B0 File Offset: 0x003468B0
		protected UNiagaraDataInterfaceArray(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040130C1 RID: 78017
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Niagara.NiagaraDataInterfaceArray";

		// Token: 0x040130C2 RID: 78018
		private static IntPtr _ClassPtr;

		// Token: 0x040130C3 RID: 78019
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040130C4 RID: 78020
		internal static int __PropertyOffset_MaxElements;
	}
}
