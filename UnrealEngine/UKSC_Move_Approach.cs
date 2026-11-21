using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200057F RID: 1407
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Move_Approach")]
	[UnrealStructLayout(528, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 528)]
	public class UKSC_Move_Approach : UKSC_Move, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06007FD9 RID: 32729 RVA: 0x000BD0AD File Offset: 0x000BB2AD
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Move_Approach._ClassPtr;
		}

		// Token: 0x06007FDA RID: 32730 RVA: 0x000BD0BC File Offset: 0x000BB2BC
		public UKSC_Move_Approach() : this(BuiltinUtils.AllocNativeUObject(UKSC_Move_Approach.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06007FDB RID: 32731 RVA: 0x000BD0E4 File Offset: 0x000BB2E4
		[NullableContext(1)]
		public UKSC_Move_Approach(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Move_Approach.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06007FDC RID: 32732 RVA: 0x000BD117 File Offset: 0x000BB317
		[NullableContext(2)]
		public void SetTargetEntity(AKSC_Entity Entity)
		{
			UKSC_Move_Approach.__SetTargetEntity_Internal(base.NativePtr, (Entity != null) ? Entity.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06007FDD RID: 32733
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTargetEntity_Internal(IntPtr @this, IntPtr Entity);

		// Token: 0x06007FDE RID: 32734 RVA: 0x000BD134 File Offset: 0x000BB334
		static UKSC_Move_Approach()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Move_Approach");
		}

		// Token: 0x06007FDF RID: 32735 RVA: 0x000BD142 File Offset: 0x000BB342
		protected UKSC_Move_Approach(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040037D6 RID: 14294
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Move_Approach";

		// Token: 0x040037D7 RID: 14295
		private static IntPtr _ClassPtr;

		// Token: 0x040037D8 RID: 14296
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
