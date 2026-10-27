using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200024D RID: 589
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AkAudio.AkTrigger")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 160)]
	public class UAkTrigger : UAkAudioType, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060022D1 RID: 8913 RVA: 0x0003381F File Offset: 0x00031A1F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAkTrigger._ClassPtr;
		}

		// Token: 0x060022D2 RID: 8914 RVA: 0x0003382C File Offset: 0x00031A2C
		public UAkTrigger() : this(BuiltinUtils.AllocNativeUObject(UAkTrigger.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060022D3 RID: 8915 RVA: 0x00033854 File Offset: 0x00031A54
		public UAkTrigger(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAkTrigger.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000884 RID: 2180
		// (get) Token: 0x060022D4 RID: 8916 RVA: 0x00033888 File Offset: 0x00031A88
		// (set) Token: 0x060022D5 RID: 8917 RVA: 0x000338C1 File Offset: 0x00031AC1
		public FWwiseTriggerCookedData TriggerCookedData
		{
			get
			{
				base.FastCheckIsValid();
				FWwiseTriggerCookedData result;
				if ((result = this._TriggerCookedData) == null)
				{
					result = (this._TriggerCookedData = new FWwiseTriggerCookedData(base.NativePtr + (IntPtr)UAkTrigger.__PropertyOffset_TriggerCookedData, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FWwiseTriggerCookedData.StaticStruct(), base.NativePtr + (IntPtr)UAkTrigger.__PropertyOffset_TriggerCookedData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060022D6 RID: 8918 RVA: 0x000338E2 File Offset: 0x00031AE2
		static UAkTrigger()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AkAudio.AkTrigger");
		}

		// Token: 0x060022D7 RID: 8919 RVA: 0x000338F0 File Offset: 0x00031AF0
		protected UAkTrigger(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000C06 RID: 3078
		public new const string __ObjectPath = "/Script/AkAudio.AkTrigger";

		// Token: 0x04000C07 RID: 3079
		private static IntPtr _ClassPtr;

		// Token: 0x04000C08 RID: 3080
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000C09 RID: 3081
		internal static int __PropertyOffset_TriggerCookedData;

		// Token: 0x04000C0A RID: 3082
		[Nullable(2)]
		private FWwiseTriggerCookedData _TriggerCookedData;
	}
}
