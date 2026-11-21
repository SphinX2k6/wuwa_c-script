using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007A7 RID: 1959
	[UnrealObjectPath("/Script/Niagara.NiagaraEffectType")]
	[UnrealStructLayout(296, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 296)]
	public class UNiagaraEffectType : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600AA47 RID: 43591 RVA: 0x000FB296 File Offset: 0x000F9496
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraEffectType._ClassPtr;
		}

		// Token: 0x0600AA48 RID: 43592 RVA: 0x000FB2A4 File Offset: 0x000F94A4
		public UNiagaraEffectType() : this(BuiltinUtils.AllocNativeUObject(UNiagaraEffectType.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600AA49 RID: 43593 RVA: 0x000FB2CC File Offset: 0x000F94CC
		[NullableContext(1)]
		public UNiagaraEffectType(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNiagaraEffectType.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600AA4A RID: 43594 RVA: 0x000FB2FF File Offset: 0x000F94FF
		static UNiagaraEffectType()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.NiagaraEffectType");
		}

		// Token: 0x0600AA4B RID: 43595 RVA: 0x000FB30D File Offset: 0x000F950D
		protected UNiagaraEffectType(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040048EB RID: 18667
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Niagara.NiagaraEffectType";

		// Token: 0x040048EC RID: 18668
		private static IntPtr _ClassPtr;

		// Token: 0x040048ED RID: 18669
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
