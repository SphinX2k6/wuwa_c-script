using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D09 RID: 7433
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Buff_AddTargetFaction")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class UKSC_Buff_AddTargetFaction : UKSC_Buff, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601C942 RID: 117058 RVA: 0x002A3F83 File Offset: 0x002A2183
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Buff_AddTargetFaction._ClassPtr;
		}

		// Token: 0x0601C943 RID: 117059 RVA: 0x002A3F90 File Offset: 0x002A2190
		public UKSC_Buff_AddTargetFaction() : this(BuiltinUtils.AllocNativeUObject(UKSC_Buff_AddTargetFaction.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601C944 RID: 117060 RVA: 0x002A3FB8 File Offset: 0x002A21B8
		[NullableContext(1)]
		public UKSC_Buff_AddTargetFaction(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Buff_AddTargetFaction.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007319 RID: 29465
		// (get) Token: 0x0601C945 RID: 117061 RVA: 0x002A3FEB File Offset: 0x002A21EB
		// (set) Token: 0x0601C946 RID: 117062 RVA: 0x002A3FFF File Offset: 0x002A21FF
		[Nullable(2)]
		public unsafe UKSC_DA_Buff_AddTargetFaction DaBuffAddTarget_
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Buff_AddTargetFaction>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff_AddTargetFaction.__PropertyOffset_DaBuffAddTarget_);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_Buff_AddTargetFaction.__PropertyOffset_DaBuffAddTarget_, value);
			}
		}

		// Token: 0x0601C947 RID: 117063 RVA: 0x002A4014 File Offset: 0x002A2214
		static UKSC_Buff_AddTargetFaction()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Buff_AddTargetFaction");
		}

		// Token: 0x0601C948 RID: 117064 RVA: 0x002A4022 File Offset: 0x002A2222
		protected UKSC_Buff_AddTargetFaction(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F7DE RID: 63454
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Buff_AddTargetFaction";

		// Token: 0x0400F7DF RID: 63455
		private static IntPtr _ClassPtr;

		// Token: 0x0400F7E0 RID: 63456
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F7E1 RID: 63457
		internal static int __PropertyOffset_DaBuffAddTarget_;
	}
}
