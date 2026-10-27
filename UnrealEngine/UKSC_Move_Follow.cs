using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001E04 RID: 7684
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Move_Follow")]
	[UnrealStructLayout(520, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 520)]
	public class UKSC_Move_Follow : UKSC_Move, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D58C RID: 120204 RVA: 0x002B5302 File Offset: 0x002B3502
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Move_Follow._ClassPtr;
		}

		// Token: 0x0601D58D RID: 120205 RVA: 0x002B5310 File Offset: 0x002B3510
		public UKSC_Move_Follow() : this(BuiltinUtils.AllocNativeUObject(UKSC_Move_Follow.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D58E RID: 120206 RVA: 0x002B5338 File Offset: 0x002B3538
		[NullableContext(1)]
		public UKSC_Move_Follow(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Move_Follow.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601D58F RID: 120207 RVA: 0x002B536B File Offset: 0x002B356B
		static UKSC_Move_Follow()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Move_Follow");
		}

		// Token: 0x0601D590 RID: 120208 RVA: 0x002B5379 File Offset: 0x002B3579
		protected UKSC_Move_Follow(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FEB3 RID: 65203
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Move_Follow";

		// Token: 0x0400FEB4 RID: 65204
		private static IntPtr _ClassPtr;

		// Token: 0x0400FEB5 RID: 65205
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
