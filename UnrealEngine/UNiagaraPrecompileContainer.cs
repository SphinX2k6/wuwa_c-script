using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020025CC RID: 9676
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NiagaraPrecompileContainer")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class UNiagaraPrecompileContainer : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023F7B RID: 147323 RVA: 0x0035325C File Offset: 0x0035145C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraPrecompileContainer._ClassPtr;
		}

		// Token: 0x06023F7C RID: 147324 RVA: 0x00353268 File Offset: 0x00351468
		public UNiagaraPrecompileContainer() : this(BuiltinUtils.AllocNativeUObject(UNiagaraPrecompileContainer.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023F7D RID: 147325 RVA: 0x00353290 File Offset: 0x00351490
		public UNiagaraPrecompileContainer(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNiagaraPrecompileContainer.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008A50 RID: 35408
		// (get) Token: 0x06023F7E RID: 147326 RVA: 0x003532C4 File Offset: 0x003514C4
		// (set) Token: 0x06023F7F RID: 147327 RVA: 0x003532FD File Offset: 0x003514FD
		public TArray<UNiagaraScript> Scripts
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UNiagaraScript> result;
				if ((result = this._Scripts) == null)
				{
					result = (this._Scripts = new TArray<UNiagaraScript>(base.NativePtr + (IntPtr)UNiagaraPrecompileContainer.__PropertyOffset_Scripts, this));
				}
				return result;
			}
			set
			{
				this.Scripts.CopyAssign(value);
			}
		}

		// Token: 0x17008A51 RID: 35409
		// (get) Token: 0x06023F80 RID: 147328 RVA: 0x0035330B File Offset: 0x0035150B
		// (set) Token: 0x06023F81 RID: 147329 RVA: 0x0035331F File Offset: 0x0035151F
		[Nullable(2)]
		public unsafe UNiagaraSystem System
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraSystem>(base.NativePtr / (IntPtr)sizeof(void*) + UNiagaraPrecompileContainer.__PropertyOffset_System);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UNiagaraPrecompileContainer.__PropertyOffset_System, value);
			}
		}

		// Token: 0x06023F82 RID: 147330 RVA: 0x00353334 File Offset: 0x00351534
		static UNiagaraPrecompileContainer()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.NiagaraPrecompileContainer");
		}

		// Token: 0x06023F83 RID: 147331 RVA: 0x00353342 File Offset: 0x00351542
		protected UNiagaraPrecompileContainer(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013487 RID: 78983
		public new const string __ObjectPath = "/Script/Niagara.NiagaraPrecompileContainer";

		// Token: 0x04013488 RID: 78984
		private static IntPtr _ClassPtr;

		// Token: 0x04013489 RID: 78985
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401348A RID: 78986
		internal static int __PropertyOffset_Scripts;

		// Token: 0x0401348B RID: 78987
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UNiagaraScript> _Scripts;

		// Token: 0x0401348C RID: 78988
		internal static int __PropertyOffset_System;
	}
}
