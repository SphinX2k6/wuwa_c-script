using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002544 RID: 9540
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NiagaraComponentPool")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public class UNiagaraComponentPool : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023749 RID: 145225 RVA: 0x00346871 File Offset: 0x00344A71
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraComponentPool._ClassPtr;
		}

		// Token: 0x0602374A RID: 145226 RVA: 0x00346880 File Offset: 0x00344A80
		public UNiagaraComponentPool() : this(BuiltinUtils.AllocNativeUObject(UNiagaraComponentPool.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602374B RID: 145227 RVA: 0x003468A8 File Offset: 0x00344AA8
		public UNiagaraComponentPool(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNiagaraComponentPool.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008829 RID: 34857
		// (get) Token: 0x0602374C RID: 145228 RVA: 0x003468DC File Offset: 0x00344ADC
		// (set) Token: 0x0602374D RID: 145229 RVA: 0x00346915 File Offset: 0x00344B15
		public TMap<UNiagaraSystem, FNCPool> WorldParticleSystemPools
		{
			get
			{
				base.FastCheckIsValid();
				TMap<UNiagaraSystem, FNCPool> result;
				if ((result = this._WorldParticleSystemPools) == null)
				{
					result = (this._WorldParticleSystemPools = new TMap<UNiagaraSystem, FNCPool>(base.NativePtr + (IntPtr)UNiagaraComponentPool.__PropertyOffset_WorldParticleSystemPools, this));
				}
				return result;
			}
			set
			{
				this.WorldParticleSystemPools.CopyAssign(value);
			}
		}

		// Token: 0x0602374E RID: 145230 RVA: 0x00346923 File Offset: 0x00344B23
		static UNiagaraComponentPool()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.NiagaraComponentPool");
		}

		// Token: 0x0602374F RID: 145231 RVA: 0x00346931 File Offset: 0x00344B31
		protected UNiagaraComponentPool(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013025 RID: 77861
		public new const string __ObjectPath = "/Script/Niagara.NiagaraComponentPool";

		// Token: 0x04013026 RID: 77862
		private static IntPtr _ClassPtr;

		// Token: 0x04013027 RID: 77863
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013028 RID: 77864
		internal static int __PropertyOffset_WorldParticleSystemPools;

		// Token: 0x04013029 RID: 77865
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<UNiagaraSystem, FNCPool> _WorldParticleSystemPools;
	}
}
