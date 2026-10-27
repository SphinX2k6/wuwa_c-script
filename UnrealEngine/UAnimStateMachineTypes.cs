using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000843 RID: 2115
	[UnrealObjectPath("/Script/Engine.AnimStateMachineTypes")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UAnimStateMachineTypes : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060071F5 RID: 29173 RVA: 0x000A3323 File Offset: 0x000A1523
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAnimStateMachineTypes._ClassPtr;
		}

		// Token: 0x060071F6 RID: 29174 RVA: 0x000A3330 File Offset: 0x000A1530
		public UAnimStateMachineTypes() : this(BuiltinUtils.AllocNativeUObject(UAnimStateMachineTypes.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060071F7 RID: 29175 RVA: 0x000A3358 File Offset: 0x000A1558
		[NullableContext(1)]
		public UAnimStateMachineTypes(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAnimStateMachineTypes.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060071F8 RID: 29176 RVA: 0x000A338B File Offset: 0x000A158B
		static UAnimStateMachineTypes()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.AnimStateMachineTypes");
		}

		// Token: 0x060071F9 RID: 29177 RVA: 0x000A3399 File Offset: 0x000A1599
		protected UAnimStateMachineTypes(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040036B9 RID: 14009
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.AnimStateMachineTypes";

		// Token: 0x040036BA RID: 14010
		private static IntPtr _ClassPtr;

		// Token: 0x040036BB RID: 14011
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
