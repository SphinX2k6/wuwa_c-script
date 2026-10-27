using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020000FF RID: 255
	[UnrealObjectPath("/Script/AIModule.AISenseConfig_Blueprint")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 88)]
	public abstract class UAISenseConfig_Blueprint : UAISenseConfig, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001382 RID: 4994 RVA: 0x0001CCB1 File Offset: 0x0001AEB1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAISenseConfig_Blueprint._ClassPtr;
		}

		// Token: 0x17000548 RID: 1352
		// (get) Token: 0x06001383 RID: 4995 RVA: 0x0001CCBD File Offset: 0x0001AEBD
		// (set) Token: 0x06001384 RID: 4996 RVA: 0x0001CCD1 File Offset: 0x0001AED1
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UAISense_Blueprint> Implementation
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UAISenseConfig_Blueprint.__PropertyOffset_Implementation);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UAISenseConfig_Blueprint.__PropertyOffset_Implementation) = value;
			}
		}

		// Token: 0x06001385 RID: 4997 RVA: 0x0001CCE6 File Offset: 0x0001AEE6
		static UAISenseConfig_Blueprint()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.AISenseConfig_Blueprint");
		}

		// Token: 0x06001386 RID: 4998 RVA: 0x0001CCF4 File Offset: 0x0001AEF4
		protected UAISenseConfig_Blueprint() : this(BuiltinUtils.AllocNativeUObject(UAISenseConfig_Blueprint.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001387 RID: 4999 RVA: 0x0001CD1C File Offset: 0x0001AF1C
		protected UAISenseConfig_Blueprint(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400039A RID: 922
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.AISenseConfig_Blueprint";

		// Token: 0x0400039B RID: 923
		private static IntPtr _ClassPtr;

		// Token: 0x0400039C RID: 924
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400039D RID: 925
		internal static int __PropertyOffset_Implementation;
	}
}
