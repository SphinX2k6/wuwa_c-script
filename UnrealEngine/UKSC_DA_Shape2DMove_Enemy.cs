using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001DAF RID: 7599
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_Shape2DMove_Enemy")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 112)]
	public class UKSC_DA_Shape2DMove_Enemy : UKSC_DA_Move, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D0BC RID: 118972 RVA: 0x002AEDB4 File Offset: 0x002ACFB4
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Shape2DMove_Enemy._ClassPtr;
		}

		// Token: 0x0601D0BD RID: 118973 RVA: 0x002AEDC0 File Offset: 0x002ACFC0
		public UKSC_DA_Shape2DMove_Enemy() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Shape2DMove_Enemy.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D0BE RID: 118974 RVA: 0x002AEDE8 File Offset: 0x002ACFE8
		[NullableContext(1)]
		public UKSC_DA_Shape2DMove_Enemy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Shape2DMove_Enemy.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700752E RID: 29998
		// (get) Token: 0x0601D0BF RID: 118975 RVA: 0x002AEE1B File Offset: 0x002AD01B
		// (set) Token: 0x0601D0C0 RID: 118976 RVA: 0x002AEE2B File Offset: 0x002AD02B
		public unsafe float LimitY
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_Shape2DMove_Enemy.__PropertyOffset_LimitY);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_Shape2DMove_Enemy.__PropertyOffset_LimitY) = value;
			}
		}

		// Token: 0x0601D0C1 RID: 118977 RVA: 0x002AEE3C File Offset: 0x002AD03C
		static UKSC_DA_Shape2DMove_Enemy()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_Shape2DMove_Enemy");
		}

		// Token: 0x0601D0C2 RID: 118978 RVA: 0x002AEE4A File Offset: 0x002AD04A
		protected UKSC_DA_Shape2DMove_Enemy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FC4B RID: 64587
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_Shape2DMove_Enemy";

		// Token: 0x0400FC4C RID: 64588
		private static IntPtr _ClassPtr;

		// Token: 0x0400FC4D RID: 64589
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FC4E RID: 64590
		internal static int __PropertyOffset_LimitY;
	}
}
