using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002199 RID: 8601
	[UnrealObjectPath("/Script/LGUI.UIPostProcessBaseActor")]
	[UnrealStructLayout(1664, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1664)]
	public abstract class AUIPostProcessBaseActor : AUIBaseActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060209EE RID: 133614 RVA: 0x0030481B File Offset: 0x00302A1B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AUIPostProcessBaseActor._ClassPtr;
		}

		// Token: 0x060209EF RID: 133615 RVA: 0x00304827 File Offset: 0x00302A27
		static AUIPostProcessBaseActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIPostProcessBaseActor");
		}

		// Token: 0x060209F0 RID: 133616 RVA: 0x00304838 File Offset: 0x00302A38
		protected AUIPostProcessBaseActor() : this(BuiltinUtils.AllocNativeUObject(AUIPostProcessBaseActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060209F1 RID: 133617 RVA: 0x00304860 File Offset: 0x00302A60
		protected AUIPostProcessBaseActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011750 RID: 71504
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UIPostProcessBaseActor";

		// Token: 0x04011751 RID: 71505
		private static IntPtr _ClassPtr;

		// Token: 0x04011752 RID: 71506
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
