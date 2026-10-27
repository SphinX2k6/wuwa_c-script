using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001DF3 RID: 7667
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Listener_OnBulletCreate")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class UKSC_Listener_OnBulletCreate : UKSC_EventListener, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D4D3 RID: 120019 RVA: 0x002B4308 File Offset: 0x002B2508
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_Listener_OnBulletCreate._ClassPtr;
		}

		// Token: 0x0601D4D4 RID: 120020 RVA: 0x002B4314 File Offset: 0x002B2514
		public UKSC_Listener_OnBulletCreate() : this(BuiltinUtils.AllocNativeUObject(UKSC_Listener_OnBulletCreate.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D4D5 RID: 120021 RVA: 0x002B433C File Offset: 0x002B253C
		[NullableContext(1)]
		public UKSC_Listener_OnBulletCreate(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_Listener_OnBulletCreate.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007655 RID: 30293
		// (get) Token: 0x0601D4D6 RID: 120022 RVA: 0x002B436F File Offset: 0x002B256F
		// (set) Token: 0x0601D4D7 RID: 120023 RVA: 0x002B437F File Offset: 0x002B257F
		public unsafe long BulletConfigId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_Listener_OnBulletCreate.__PropertyOffset_BulletConfigId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_Listener_OnBulletCreate.__PropertyOffset_BulletConfigId) = value;
			}
		}

		// Token: 0x0601D4D8 RID: 120024 RVA: 0x002B4390 File Offset: 0x002B2590
		public void OnBulletCreateCallback(long ConfigId)
		{
			UKSC_Listener_OnBulletCreate.__OnBulletCreateCallback_Internal(base.NativePtr, ConfigId);
		}

		// Token: 0x0601D4D9 RID: 120025
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnBulletCreateCallback_Internal(IntPtr @this, long ConfigId);

		// Token: 0x0601D4DA RID: 120026 RVA: 0x002B439E File Offset: 0x002B259E
		static UKSC_Listener_OnBulletCreate()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Listener_OnBulletCreate");
		}

		// Token: 0x0601D4DB RID: 120027 RVA: 0x002B43AC File Offset: 0x002B25AC
		protected UKSC_Listener_OnBulletCreate(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FE5F RID: 65119
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Listener_OnBulletCreate";

		// Token: 0x0400FE60 RID: 65120
		private static IntPtr _ClassPtr;

		// Token: 0x0400FE61 RID: 65121
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FE62 RID: 65122
		internal static int __PropertyOffset_BulletConfigId;
	}
}
