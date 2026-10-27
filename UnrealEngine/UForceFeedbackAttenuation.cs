using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000BEA RID: 3050
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ForceFeedbackAttenuation")]
	[UnrealStructLayout(224, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 224)]
	public class UForceFeedbackAttenuation : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06009661 RID: 38497 RVA: 0x000D6791 File Offset: 0x000D4991
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UForceFeedbackAttenuation._ClassPtr;
		}

		// Token: 0x06009662 RID: 38498 RVA: 0x000D67A0 File Offset: 0x000D49A0
		public UForceFeedbackAttenuation() : this(BuiltinUtils.AllocNativeUObject(UForceFeedbackAttenuation.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06009663 RID: 38499 RVA: 0x000D67C8 File Offset: 0x000D49C8
		public UForceFeedbackAttenuation(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UForceFeedbackAttenuation.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002413 RID: 9235
		// (get) Token: 0x06009664 RID: 38500 RVA: 0x000D67FC File Offset: 0x000D49FC
		// (set) Token: 0x06009665 RID: 38501 RVA: 0x000D6835 File Offset: 0x000D4A35
		public FForceFeedbackAttenuationSettings Attenuation
		{
			get
			{
				base.FastCheckIsValid();
				FForceFeedbackAttenuationSettings result;
				if ((result = this._Attenuation) == null)
				{
					result = (this._Attenuation = new FForceFeedbackAttenuationSettings(base.NativePtr + (IntPtr)UForceFeedbackAttenuation.__PropertyOffset_Attenuation, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FForceFeedbackAttenuationSettings.StaticStruct(), base.NativePtr + (IntPtr)UForceFeedbackAttenuation.__PropertyOffset_Attenuation, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06009666 RID: 38502 RVA: 0x000D6856 File Offset: 0x000D4A56
		static UForceFeedbackAttenuation()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ForceFeedbackAttenuation");
		}

		// Token: 0x06009667 RID: 38503 RVA: 0x000D6864 File Offset: 0x000D4A64
		protected UForceFeedbackAttenuation(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400545E RID: 21598
		public new const string __ObjectPath = "/Script/Engine.ForceFeedbackAttenuation";

		// Token: 0x0400545F RID: 21599
		private static IntPtr _ClassPtr;

		// Token: 0x04005460 RID: 21600
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04005461 RID: 21601
		internal static int __PropertyOffset_Attenuation;

		// Token: 0x04005462 RID: 21602
		[Nullable(2)]
		private FForceFeedbackAttenuationSettings _Attenuation;
	}
}
