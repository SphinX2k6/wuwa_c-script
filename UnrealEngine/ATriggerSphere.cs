using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001206 RID: 4614
	[UnrealObjectPath("/Script/Engine.TriggerSphere")]
	[UnrealStructLayout(1056, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1056)]
	public class ATriggerSphere : ATriggerBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601100C RID: 69644 RVA: 0x0018F3BA File Offset: 0x0018D5BA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ATriggerSphere._ClassPtr;
		}

		// Token: 0x0601100D RID: 69645 RVA: 0x0018F3C8 File Offset: 0x0018D5C8
		public ATriggerSphere() : this(BuiltinUtils.AllocNativeUObject(ATriggerSphere.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601100E RID: 69646 RVA: 0x0018F3F0 File Offset: 0x0018D5F0
		[NullableContext(1)]
		public ATriggerSphere(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ATriggerSphere.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601100F RID: 69647 RVA: 0x0018F423 File Offset: 0x0018D623
		static ATriggerSphere()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.TriggerSphere");
		}

		// Token: 0x06011010 RID: 69648 RVA: 0x0018F431 File Offset: 0x0018D631
		protected ATriggerSphere(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040091AD RID: 37293
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.TriggerSphere";

		// Token: 0x040091AE RID: 37294
		private static IntPtr _ClassPtr;

		// Token: 0x040091AF RID: 37295
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
