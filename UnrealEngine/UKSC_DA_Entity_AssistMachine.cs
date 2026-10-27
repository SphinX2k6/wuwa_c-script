using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D8F RID: 7567
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_Entity_AssistMachine")]
	[UnrealStructLayout(400, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 400)]
	public class UKSC_DA_Entity_AssistMachine : UKSC_DA_Entity, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601CF85 RID: 118661 RVA: 0x002AD1CE File Offset: 0x002AB3CE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Entity_AssistMachine._ClassPtr;
		}

		// Token: 0x0601CF86 RID: 118662 RVA: 0x002AD1DC File Offset: 0x002AB3DC
		public UKSC_DA_Entity_AssistMachine() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Entity_AssistMachine.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601CF87 RID: 118663 RVA: 0x002AD204 File Offset: 0x002AB404
		[NullableContext(1)]
		public UKSC_DA_Entity_AssistMachine(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Entity_AssistMachine.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601CF88 RID: 118664 RVA: 0x002AD237 File Offset: 0x002AB437
		static UKSC_DA_Entity_AssistMachine()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_Entity_AssistMachine");
		}

		// Token: 0x0601CF89 RID: 118665 RVA: 0x002AD245 File Offset: 0x002AB445
		protected UKSC_DA_Entity_AssistMachine(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FB92 RID: 64402
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_Entity_AssistMachine";

		// Token: 0x0400FB93 RID: 64403
		private static IntPtr _ClassPtr;

		// Token: 0x0400FB94 RID: 64404
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
