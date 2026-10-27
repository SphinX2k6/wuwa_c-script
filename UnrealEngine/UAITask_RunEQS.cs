using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000118 RID: 280
	[UnrealObjectPath("/Script/AIModule.AITask_RunEQS")]
	[UnrealStructLayout(264, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 264)]
	public class UAITask_RunEQS : UAITask, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600149D RID: 5277 RVA: 0x0001E65B File Offset: 0x0001C85B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAITask_RunEQS._ClassPtr;
		}

		// Token: 0x0600149E RID: 5278 RVA: 0x0001E668 File Offset: 0x0001C868
		public UAITask_RunEQS() : this(BuiltinUtils.AllocNativeUObject(UAITask_RunEQS.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600149F RID: 5279 RVA: 0x0001E690 File Offset: 0x0001C890
		[NullableContext(1)]
		public UAITask_RunEQS(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAITask_RunEQS.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060014A0 RID: 5280 RVA: 0x0001E6C3 File Offset: 0x0001C8C3
		[NullableContext(2)]
		public static UAITask_RunEQS RunEQS(AAIController Controller, UEnvQuery QueryTemplate)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAITask_RunEQS>(UAITask_RunEQS.__RunEQS_Internal((Controller != null) ? Controller.NativePtr : IntPtr.Zero, (QueryTemplate != null) ? QueryTemplate.NativePtr : IntPtr.Zero));
		}

		// Token: 0x060014A1 RID: 5281
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __RunEQS_Internal(IntPtr Controller, IntPtr QueryTemplate);

		// Token: 0x060014A2 RID: 5282 RVA: 0x0001E6EF File Offset: 0x0001C8EF
		static UAITask_RunEQS()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.AITask_RunEQS");
		}

		// Token: 0x060014A3 RID: 5283 RVA: 0x0001E6FD File Offset: 0x0001C8FD
		protected UAITask_RunEQS(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000434 RID: 1076
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.AITask_RunEQS";

		// Token: 0x04000435 RID: 1077
		private static IntPtr _ClassPtr;

		// Token: 0x04000436 RID: 1078
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
