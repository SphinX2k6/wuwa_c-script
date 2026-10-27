using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001DB3 RID: 7603
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_Shape2D_Entity_Machine")]
	[UnrealStructLayout(416, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 416)]
	public class UKSC_DA_Shape2D_Entity_Machine : UKSC_DA_Shape2D_Entity, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D0D6 RID: 118998 RVA: 0x002AF013 File Offset: 0x002AD213
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_Shape2D_Entity_Machine._ClassPtr;
		}

		// Token: 0x0601D0D7 RID: 118999 RVA: 0x002AF020 File Offset: 0x002AD220
		public UKSC_DA_Shape2D_Entity_Machine() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Shape2D_Entity_Machine.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D0D8 RID: 119000 RVA: 0x002AF048 File Offset: 0x002AD248
		public UKSC_DA_Shape2D_Entity_Machine(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_Shape2D_Entity_Machine.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007531 RID: 30001
		// (get) Token: 0x0601D0D9 RID: 119001 RVA: 0x002AF07B File Offset: 0x002AD27B
		// (set) Token: 0x0601D0DA RID: 119002 RVA: 0x002AF08F File Offset: 0x002AD28F
		public unsafe string TriggerAnimName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UKSC_DA_Shape2D_Entity_Machine.__PropertyOffset_TriggerAnimName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UKSC_DA_Shape2D_Entity_Machine.__PropertyOffset_TriggerAnimName)), value);
			}
		}

		// Token: 0x0601D0DB RID: 119003 RVA: 0x002AF0A4 File Offset: 0x002AD2A4
		static UKSC_DA_Shape2D_Entity_Machine()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_Shape2D_Entity_Machine");
		}

		// Token: 0x0601D0DC RID: 119004 RVA: 0x002AF0B2 File Offset: 0x002AD2B2
		protected UKSC_DA_Shape2D_Entity_Machine(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FC5A RID: 64602
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_Shape2D_Entity_Machine";

		// Token: 0x0400FC5B RID: 64603
		private static IntPtr _ClassPtr;

		// Token: 0x0400FC5C RID: 64604
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FC5D RID: 64605
		internal static int __PropertyOffset_TriggerAnimName;
	}
}
