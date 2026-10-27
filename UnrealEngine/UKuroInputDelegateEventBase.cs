using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020018DB RID: 6363
	[UnrealObjectPath("/Script/KuroGameplay.KuroInputDelegateEventBase")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroInputDelegateEventBase : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06017927 RID: 96551 RVA: 0x002280ED File Offset: 0x002262ED
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroInputDelegateEventBase._ClassPtr;
		}

		// Token: 0x06017928 RID: 96552 RVA: 0x002280FC File Offset: 0x002262FC
		public UKuroInputDelegateEventBase() : this(BuiltinUtils.AllocNativeUObject(UKuroInputDelegateEventBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06017929 RID: 96553 RVA: 0x00228124 File Offset: 0x00226324
		[NullableContext(1)]
		public UKuroInputDelegateEventBase(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroInputDelegateEventBase.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601792A RID: 96554 RVA: 0x00228157 File Offset: 0x00226357
		static UKuroInputDelegateEventBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.KuroInputDelegateEventBase");
		}

		// Token: 0x0601792B RID: 96555 RVA: 0x00228165 File Offset: 0x00226365
		protected UKuroInputDelegateEventBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400CCB8 RID: 52408
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameplay.KuroInputDelegateEventBase";

		// Token: 0x0400CCB9 RID: 52409
		private static IntPtr _ClassPtr;

		// Token: 0x0400CCBA RID: 52410
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
