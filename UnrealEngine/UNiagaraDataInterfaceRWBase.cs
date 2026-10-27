using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002584 RID: 9604
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NiagaraDataInterfaceRWBase")]
	[UnrealStructLayout(288, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 288)]
	public abstract class UNiagaraDataInterfaceRWBase : UNiagaraDataInterface, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023A50 RID: 146000 RVA: 0x0034B282 File Offset: 0x00349482
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraDataInterfaceRWBase._ClassPtr;
		}

		// Token: 0x170088CF RID: 35023
		// (get) Token: 0x06023A51 RID: 146001 RVA: 0x0034B290 File Offset: 0x00349490
		// (set) Token: 0x06023A52 RID: 146002 RVA: 0x0034B2C9 File Offset: 0x003494C9
		public TSet<int> OutputShaderStages
		{
			get
			{
				base.FastCheckIsValid();
				TSet<int> result;
				if ((result = this._OutputShaderStages) == null)
				{
					result = (this._OutputShaderStages = new TSet<int>(base.NativePtr + (IntPtr)UNiagaraDataInterfaceRWBase.__PropertyOffset_OutputShaderStages, this));
				}
				return result;
			}
			set
			{
				this.OutputShaderStages.CopyAssign(value);
			}
		}

		// Token: 0x170088D0 RID: 35024
		// (get) Token: 0x06023A53 RID: 146003 RVA: 0x0034B2D8 File Offset: 0x003494D8
		// (set) Token: 0x06023A54 RID: 146004 RVA: 0x0034B311 File Offset: 0x00349511
		public TSet<int> IterationShaderStages
		{
			get
			{
				base.FastCheckIsValid();
				TSet<int> result;
				if ((result = this._IterationShaderStages) == null)
				{
					result = (this._IterationShaderStages = new TSet<int>(base.NativePtr + (IntPtr)UNiagaraDataInterfaceRWBase.__PropertyOffset_IterationShaderStages, this));
				}
				return result;
			}
			set
			{
				this.IterationShaderStages.CopyAssign(value);
			}
		}

		// Token: 0x06023A55 RID: 146005 RVA: 0x0034B31F File Offset: 0x0034951F
		static UNiagaraDataInterfaceRWBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.NiagaraDataInterfaceRWBase");
		}

		// Token: 0x06023A56 RID: 146006 RVA: 0x0034B330 File Offset: 0x00349530
		protected UNiagaraDataInterfaceRWBase() : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataInterfaceRWBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023A57 RID: 146007 RVA: 0x0034B358 File Offset: 0x00349558
		protected UNiagaraDataInterfaceRWBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040131C5 RID: 78277
		public new const string __ObjectPath = "/Script/Niagara.NiagaraDataInterfaceRWBase";

		// Token: 0x040131C6 RID: 78278
		private static IntPtr _ClassPtr;

		// Token: 0x040131C7 RID: 78279
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040131C8 RID: 78280
		internal static int __PropertyOffset_OutputShaderStages;

		// Token: 0x040131C9 RID: 78281
		[Nullable(2)]
		private TSet<int> _OutputShaderStages;

		// Token: 0x040131CA RID: 78282
		internal static int __PropertyOffset_IterationShaderStages;

		// Token: 0x040131CB RID: 78283
		[Nullable(2)]
		private TSet<int> _IterationShaderStages;
	}
}
