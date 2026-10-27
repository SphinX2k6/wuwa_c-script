using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D15 RID: 7445
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Buff_EventHandler")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 112)]
	public class UKSC_Buff_EventHandler : UKSC_Buff, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601C99C RID: 117148 RVA: 0x002A4793 File Offset: 0x002A2993
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Buff_EventHandler._ClassPtr;
		}

		// Token: 0x0601C99D RID: 117149 RVA: 0x002A47A0 File Offset: 0x002A29A0
		public UKSC_Buff_EventHandler() : this(BuiltinUtils.AllocNativeUObject(UKSC_Buff_EventHandler.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601C99E RID: 117150 RVA: 0x002A47C8 File Offset: 0x002A29C8
		[NullableContext(1)]
		public UKSC_Buff_EventHandler(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Buff_EventHandler.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007325 RID: 29477
		// (get) Token: 0x0601C99F RID: 117151 RVA: 0x002A47FB File Offset: 0x002A29FB
		// (set) Token: 0x0601C9A0 RID: 117152 RVA: 0x002A480F File Offset: 0x002A2A0F
		[Nullable(2)]
		public unsafe UKSC_DA_Buff_EventHandler DaConfig
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Buff_EventHandler>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff_EventHandler.__PropertyOffset_DaConfig);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff_EventHandler.__PropertyOffset_DaConfig, value);
			}
		}

		// Token: 0x0601C9A1 RID: 117153 RVA: 0x002A4824 File Offset: 0x002A2A24
		static UKSC_Buff_EventHandler()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Buff_EventHandler");
		}

		// Token: 0x0601C9A2 RID: 117154 RVA: 0x002A4832 File Offset: 0x002A2A32
		protected UKSC_Buff_EventHandler(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F80E RID: 63502
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Buff_EventHandler";

		// Token: 0x0400F80F RID: 63503
		private static IntPtr _ClassPtr;

		// Token: 0x0400F810 RID: 63504
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F811 RID: 63505
		internal static int __PropertyOffset_DaConfig;
	}
}
