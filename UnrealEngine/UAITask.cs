using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000115 RID: 277
	[UnrealObjectPath("/Script/AIModule.AITask")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public abstract class UAITask : UGameplayTask, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001485 RID: 5253 RVA: 0x0001E37A File Offset: 0x0001C57A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAITask._ClassPtr;
		}

		// Token: 0x17000586 RID: 1414
		// (get) Token: 0x06001486 RID: 5254 RVA: 0x0001E386 File Offset: 0x0001C586
		// (set) Token: 0x06001487 RID: 5255 RVA: 0x0001E39A File Offset: 0x0001C59A
		[Nullable(2)]
		public unsafe AAIController OwnerController
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AAIController>(base.NativePtr / (IntPtr)sizeof(void*) + UAITask.__PropertyOffset_OwnerController);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UAITask.__PropertyOffset_OwnerController, value);
			}
		}

		// Token: 0x06001488 RID: 5256 RVA: 0x0001E3AF File Offset: 0x0001C5AF
		static UAITask()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.AITask");
		}

		// Token: 0x06001489 RID: 5257 RVA: 0x0001E3C0 File Offset: 0x0001C5C0
		protected UAITask() : this(BuiltinUtils.AllocNativeUObject(UAITask.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600148A RID: 5258 RVA: 0x0001E3E8 File Offset: 0x0001C5E8
		protected UAITask(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000424 RID: 1060
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.AITask";

		// Token: 0x04000425 RID: 1061
		private static IntPtr _ClassPtr;

		// Token: 0x04000426 RID: 1062
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000427 RID: 1063
		internal static int __PropertyOffset_OwnerController;
	}
}
