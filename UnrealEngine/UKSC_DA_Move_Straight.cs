using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001DA7 RID: 7591
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_Move_Straight")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class UKSC_DA_Move_Straight : UKSC_DA_Move, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D064 RID: 118884 RVA: 0x002AE584 File Offset: 0x002AC784
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Move_Straight._ClassPtr;
		}

		// Token: 0x0601D065 RID: 118885 RVA: 0x002AE590 File Offset: 0x002AC790
		public UKSC_DA_Move_Straight() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Move_Straight.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D066 RID: 118886 RVA: 0x002AE5B8 File Offset: 0x002AC7B8
		[NullableContext(1)]
		public UKSC_DA_Move_Straight(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Move_Straight.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601D067 RID: 118887 RVA: 0x002AE5EB File Offset: 0x002AC7EB
		static UKSC_DA_Move_Straight()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_Move_Straight");
		}

		// Token: 0x0601D068 RID: 118888 RVA: 0x002AE5F9 File Offset: 0x002AC7F9
		protected UKSC_DA_Move_Straight(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FC15 RID: 64533
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_Move_Straight";

		// Token: 0x0400FC16 RID: 64534
		private static IntPtr _ClassPtr;

		// Token: 0x0400FC17 RID: 64535
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
