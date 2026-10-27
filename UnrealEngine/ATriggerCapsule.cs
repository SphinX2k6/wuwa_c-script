using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001205 RID: 4613
	[UnrealObjectPath("/Script/Engine.TriggerCapsule")]
	[UnrealStructLayout(1056, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1056)]
	public class ATriggerCapsule : ATriggerBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06011007 RID: 69639 RVA: 0x0018F33A File Offset: 0x0018D53A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ATriggerCapsule._ClassPtr;
		}

		// Token: 0x06011008 RID: 69640 RVA: 0x0018F348 File Offset: 0x0018D548
		public ATriggerCapsule() : this(BuiltinUtils.AllocNativeUObject(ATriggerCapsule.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06011009 RID: 69641 RVA: 0x0018F370 File Offset: 0x0018D570
		[NullableContext(1)]
		public ATriggerCapsule(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ATriggerCapsule.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601100A RID: 69642 RVA: 0x0018F3A3 File Offset: 0x0018D5A3
		static ATriggerCapsule()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.TriggerCapsule");
		}

		// Token: 0x0601100B RID: 69643 RVA: 0x0018F3B1 File Offset: 0x0018D5B1
		protected ATriggerCapsule(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040091AA RID: 37290
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.TriggerCapsule";

		// Token: 0x040091AB RID: 37291
		private static IntPtr _ClassPtr;

		// Token: 0x040091AC RID: 37292
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
