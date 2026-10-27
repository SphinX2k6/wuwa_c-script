using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F67 RID: 3943
	[UnrealObjectPath("/Script/Engine.ParticleModuleEventReceiverBase")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public abstract class UParticleModuleEventReceiverBase : UParticleModuleEventBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D4D5 RID: 54485 RVA: 0x00138D12 File Offset: 0x00136F12
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleModuleEventReceiverBase._ClassPtr;
		}

		// Token: 0x170031EA RID: 12778
		// (get) Token: 0x0600D4D6 RID: 54486 RVA: 0x00138D1E File Offset: 0x00136F1E
		// (set) Token: 0x0600D4D7 RID: 54487 RVA: 0x00138D32 File Offset: 0x00136F32
		public unsafe TEnumAsByte<EParticleEventType> EventGeneratorType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleEventReceiverBase.__PropertyOffset_EventGeneratorType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleEventReceiverBase.__PropertyOffset_EventGeneratorType) = value;
			}
		}

		// Token: 0x170031EB RID: 12779
		// (get) Token: 0x0600D4D8 RID: 54488 RVA: 0x00138D47 File Offset: 0x00136F47
		// (set) Token: 0x0600D4D9 RID: 54489 RVA: 0x00138D5B File Offset: 0x00136F5B
		public unsafe FName EventName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleEventReceiverBase.__PropertyOffset_EventName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleEventReceiverBase.__PropertyOffset_EventName) = value;
			}
		}

		// Token: 0x0600D4DA RID: 54490 RVA: 0x00138D70 File Offset: 0x00136F70
		static UParticleModuleEventReceiverBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleModuleEventReceiverBase");
		}

		// Token: 0x0600D4DB RID: 54491 RVA: 0x00138D80 File Offset: 0x00136F80
		protected UParticleModuleEventReceiverBase() : this(BuiltinUtils.AllocNativeUObject(UParticleModuleEventReceiverBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D4DC RID: 54492 RVA: 0x00138DA8 File Offset: 0x00136FA8
		protected UParticleModuleEventReceiverBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400729F RID: 29343
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.ParticleModuleEventReceiverBase";

		// Token: 0x040072A0 RID: 29344
		private static IntPtr _ClassPtr;

		// Token: 0x040072A1 RID: 29345
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040072A2 RID: 29346
		internal static int __PropertyOffset_EventGeneratorType;

		// Token: 0x040072A3 RID: 29347
		internal static int __PropertyOffset_EventName;
	}
}
