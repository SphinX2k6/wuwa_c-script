using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200013F RID: 319
	[UnrealObjectPath("/Script/AIModule.BTDecorator_ConditionalLoop")]
	[UnrealStructLayout(224, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 224)]
	public class UBTDecorator_ConditionalLoop : UBTDecorator_Blackboard, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600165F RID: 5727 RVA: 0x00020DE9 File Offset: 0x0001EFE9
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBTDecorator_ConditionalLoop._ClassPtr;
		}

		// Token: 0x06001660 RID: 5728 RVA: 0x00020DF8 File Offset: 0x0001EFF8
		public UBTDecorator_ConditionalLoop() : this(BuiltinUtils.AllocNativeUObject(UBTDecorator_ConditionalLoop.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001661 RID: 5729 RVA: 0x00020E20 File Offset: 0x0001F020
		[NullableContext(1)]
		public UBTDecorator_ConditionalLoop(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBTDecorator_ConditionalLoop.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06001662 RID: 5730 RVA: 0x00020E53 File Offset: 0x0001F053
		static UBTDecorator_ConditionalLoop()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.BTDecorator_ConditionalLoop");
		}

		// Token: 0x06001663 RID: 5731 RVA: 0x00020E61 File Offset: 0x0001F061
		protected UBTDecorator_ConditionalLoop(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000509 RID: 1289
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.BTDecorator_ConditionalLoop";

		// Token: 0x0400050A RID: 1290
		private static IntPtr _ClassPtr;

		// Token: 0x0400050B RID: 1291
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
