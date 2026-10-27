using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D16 RID: 7446
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Buff_IdleTimer")]
	[UnrealStructLayout(152, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 152)]
	public class UKSC_Buff_IdleTimer : UKSC_Buff, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601C9A3 RID: 117155 RVA: 0x002A483B File Offset: 0x002A2A3B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Buff_IdleTimer._ClassPtr;
		}

		// Token: 0x0601C9A4 RID: 117156 RVA: 0x002A4848 File Offset: 0x002A2A48
		public UKSC_Buff_IdleTimer() : this(BuiltinUtils.AllocNativeUObject(UKSC_Buff_IdleTimer.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601C9A5 RID: 117157 RVA: 0x002A4870 File Offset: 0x002A2A70
		[NullableContext(1)]
		public UKSC_Buff_IdleTimer(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Buff_IdleTimer.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007326 RID: 29478
		// (get) Token: 0x0601C9A6 RID: 117158 RVA: 0x002A48A3 File Offset: 0x002A2AA3
		// (set) Token: 0x0601C9A7 RID: 117159 RVA: 0x002A48B7 File Offset: 0x002A2AB7
		[Nullable(2)]
		public unsafe UKSC_DA_Buff_IdleTimer DaBuffIdleTimer_
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Buff_IdleTimer>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff_IdleTimer.__PropertyOffset_DaBuffIdleTimer_);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff_IdleTimer.__PropertyOffset_DaBuffIdleTimer_, value);
			}
		}

		// Token: 0x0601C9A8 RID: 117160 RVA: 0x002A48CC File Offset: 0x002A2ACC
		static UKSC_Buff_IdleTimer()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Buff_IdleTimer");
		}

		// Token: 0x0601C9A9 RID: 117161 RVA: 0x002A48DA File Offset: 0x002A2ADA
		protected UKSC_Buff_IdleTimer(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F812 RID: 63506
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Buff_IdleTimer";

		// Token: 0x0400F813 RID: 63507
		private static IntPtr _ClassPtr;

		// Token: 0x0400F814 RID: 63508
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F815 RID: 63509
		internal static int __PropertyOffset_DaBuffIdleTimer_;
	}
}
