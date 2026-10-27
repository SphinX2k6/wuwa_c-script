using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001204 RID: 4612
	[UnrealObjectPath("/Script/Engine.TriggerBox")]
	[UnrealStructLayout(1056, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1056)]
	public class ATriggerBox : ATriggerBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06011002 RID: 69634 RVA: 0x0018F2B9 File Offset: 0x0018D4B9
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ATriggerBox._ClassPtr;
		}

		// Token: 0x06011003 RID: 69635 RVA: 0x0018F2C8 File Offset: 0x0018D4C8
		public ATriggerBox() : this(BuiltinUtils.AllocNativeUObject(ATriggerBox.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06011004 RID: 69636 RVA: 0x0018F2F0 File Offset: 0x0018D4F0
		[NullableContext(1)]
		public ATriggerBox(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ATriggerBox.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06011005 RID: 69637 RVA: 0x0018F323 File Offset: 0x0018D523
		static ATriggerBox()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.TriggerBox");
		}

		// Token: 0x06011006 RID: 69638 RVA: 0x0018F331 File Offset: 0x0018D531
		protected ATriggerBox(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040091A7 RID: 37287
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.TriggerBox";

		// Token: 0x040091A8 RID: 37288
		private static IntPtr _ClassPtr;

		// Token: 0x040091A9 RID: 37289
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
