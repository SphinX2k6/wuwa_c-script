using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200011F RID: 287
	[UnrealObjectPath("/Script/AIModule.BehaviorTreeTypes")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public abstract class UBehaviorTreeTypes : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060014F2 RID: 5362 RVA: 0x0001ED6E File Offset: 0x0001CF6E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBehaviorTreeTypes._ClassPtr;
		}

		// Token: 0x060014F3 RID: 5363 RVA: 0x0001ED7A File Offset: 0x0001CF7A
		static UBehaviorTreeTypes()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.BehaviorTreeTypes");
		}

		// Token: 0x060014F4 RID: 5364 RVA: 0x0001ED88 File Offset: 0x0001CF88
		protected UBehaviorTreeTypes() : this(BuiltinUtils.AllocNativeUObject(UBehaviorTreeTypes.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060014F5 RID: 5365 RVA: 0x0001EDB0 File Offset: 0x0001CFB0
		protected UBehaviorTreeTypes(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400045D RID: 1117
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.BehaviorTreeTypes";

		// Token: 0x0400045E RID: 1118
		private static IntPtr _ClassPtr;

		// Token: 0x0400045F RID: 1119
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
