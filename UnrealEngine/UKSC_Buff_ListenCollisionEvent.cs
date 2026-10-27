using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D1C RID: 7452
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Buff_ListenCollisionEvent")]
	[UnrealStructLayout(176, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 176)]
	public class UKSC_Buff_ListenCollisionEvent : UKSC_Buff, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601C9CF RID: 117199 RVA: 0x002A4C73 File Offset: 0x002A2E73
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Buff_ListenCollisionEvent._ClassPtr;
		}

		// Token: 0x0601C9D0 RID: 117200 RVA: 0x002A4C80 File Offset: 0x002A2E80
		public UKSC_Buff_ListenCollisionEvent() : this(BuiltinUtils.AllocNativeUObject(UKSC_Buff_ListenCollisionEvent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601C9D1 RID: 117201 RVA: 0x002A4CA8 File Offset: 0x002A2EA8
		[NullableContext(1)]
		public UKSC_Buff_ListenCollisionEvent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Buff_ListenCollisionEvent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700732D RID: 29485
		// (get) Token: 0x0601C9D2 RID: 117202 RVA: 0x002A4CDB File Offset: 0x002A2EDB
		// (set) Token: 0x0601C9D3 RID: 117203 RVA: 0x002A4CEF File Offset: 0x002A2EEF
		public unsafe UKSC_DA_Buff_ListenCollisionEvent DaBuffListenCollisionEvent_
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Buff_ListenCollisionEvent>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff_ListenCollisionEvent.__PropertyOffset_DaBuffListenCollisionEvent_);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff_ListenCollisionEvent.__PropertyOffset_DaBuffListenCollisionEvent_, value);
			}
		}

		// Token: 0x1700732E RID: 29486
		// (get) Token: 0x0601C9D4 RID: 117204 RVA: 0x002A4D04 File Offset: 0x002A2F04
		// (set) Token: 0x0601C9D5 RID: 117205 RVA: 0x002A4D18 File Offset: 0x002A2F18
		public unsafe UKSC_Shape2D_World KscShapeWorld
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_Shape2D_World>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff_ListenCollisionEvent.__PropertyOffset_KscShapeWorld);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff_ListenCollisionEvent.__PropertyOffset_KscShapeWorld, value);
			}
		}

		// Token: 0x0601C9D6 RID: 117206 RVA: 0x002A4D2D File Offset: 0x002A2F2D
		static UKSC_Buff_ListenCollisionEvent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Buff_ListenCollisionEvent");
		}

		// Token: 0x0601C9D7 RID: 117207 RVA: 0x002A4D3B File Offset: 0x002A2F3B
		protected UKSC_Buff_ListenCollisionEvent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F82C RID: 63532
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Buff_ListenCollisionEvent";

		// Token: 0x0400F82D RID: 63533
		private static IntPtr _ClassPtr;

		// Token: 0x0400F82E RID: 63534
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F82F RID: 63535
		internal static int __PropertyOffset_DaBuffListenCollisionEvent_;

		// Token: 0x0400F830 RID: 63536
		internal static int __PropertyOffset_KscShapeWorld;
	}
}
