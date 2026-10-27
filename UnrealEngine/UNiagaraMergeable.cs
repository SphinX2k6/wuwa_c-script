using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020024C8 RID: 9416
	[UnrealObjectPath("/Script/NiagaraCore.NiagaraMergeable")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 88)]
	public class UNiagaraMergeable : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060233B1 RID: 144305 RVA: 0x00341C61 File Offset: 0x0033FE61
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraMergeable._ClassPtr;
		}

		// Token: 0x060233B2 RID: 144306 RVA: 0x00341C70 File Offset: 0x0033FE70
		public UNiagaraMergeable() : this(BuiltinUtils.AllocNativeUObject(UNiagaraMergeable.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060233B3 RID: 144307 RVA: 0x00341C98 File Offset: 0x0033FE98
		[NullableContext(1)]
		public UNiagaraMergeable(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNiagaraMergeable.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060233B4 RID: 144308 RVA: 0x00341CCB File Offset: 0x0033FECB
		static UNiagaraMergeable()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/NiagaraCore.NiagaraMergeable");
		}

		// Token: 0x060233B5 RID: 144309 RVA: 0x00341CD9 File Offset: 0x0033FED9
		protected UNiagaraMergeable(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012D12 RID: 77074
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/NiagaraCore.NiagaraMergeable";

		// Token: 0x04012D13 RID: 77075
		private static IntPtr _ClassPtr;

		// Token: 0x04012D14 RID: 77076
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
