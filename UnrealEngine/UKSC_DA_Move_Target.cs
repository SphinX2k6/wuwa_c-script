using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001DA8 RID: 7592
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_Move_Target")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class UKSC_DA_Move_Target : UKSC_DA_Move, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D069 RID: 118889 RVA: 0x002AE602 File Offset: 0x002AC802
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Move_Target._ClassPtr;
		}

		// Token: 0x0601D06A RID: 118890 RVA: 0x002AE610 File Offset: 0x002AC810
		public UKSC_DA_Move_Target() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Move_Target.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D06B RID: 118891 RVA: 0x002AE638 File Offset: 0x002AC838
		[NullableContext(1)]
		public UKSC_DA_Move_Target(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Move_Target.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601D06C RID: 118892 RVA: 0x002AE66B File Offset: 0x002AC86B
		static UKSC_DA_Move_Target()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_Move_Target");
		}

		// Token: 0x0601D06D RID: 118893 RVA: 0x002AE679 File Offset: 0x002AC879
		protected UKSC_DA_Move_Target(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FC18 RID: 64536
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_Move_Target";

		// Token: 0x0400FC19 RID: 64537
		private static IntPtr _ClassPtr;

		// Token: 0x0400FC1A RID: 64538
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
