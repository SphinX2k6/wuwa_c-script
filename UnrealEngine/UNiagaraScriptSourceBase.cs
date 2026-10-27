using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020025E4 RID: 9700
	[UnrealObjectPath("/Script/Niagara.NiagaraScriptSourceBase")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class UNiagaraScriptSourceBase : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060240E7 RID: 147687 RVA: 0x00355886 File Offset: 0x00353A86
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraScriptSourceBase._ClassPtr;
		}

		// Token: 0x060240E8 RID: 147688 RVA: 0x00355894 File Offset: 0x00353A94
		public UNiagaraScriptSourceBase() : this(BuiltinUtils.AllocNativeUObject(UNiagaraScriptSourceBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060240E9 RID: 147689 RVA: 0x003558BC File Offset: 0x00353ABC
		[NullableContext(1)]
		public UNiagaraScriptSourceBase(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNiagaraScriptSourceBase.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060240EA RID: 147690 RVA: 0x003558EF File Offset: 0x00353AEF
		static UNiagaraScriptSourceBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.NiagaraScriptSourceBase");
		}

		// Token: 0x060240EB RID: 147691 RVA: 0x003558FD File Offset: 0x00353AFD
		protected UNiagaraScriptSourceBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401355F RID: 79199
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Niagara.NiagaraScriptSourceBase";

		// Token: 0x04013560 RID: 79200
		private static IntPtr _ClassPtr;

		// Token: 0x04013561 RID: 79201
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
