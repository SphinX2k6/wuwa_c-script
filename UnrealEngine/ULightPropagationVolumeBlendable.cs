using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020021EB RID: 8683
	[UnrealObjectPath("/Script/LightPropagationVolumeRuntime.LightPropagationVolumeBlendable")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 128)]
	public class ULightPropagationVolumeBlendable : UObject, IUnrealUObject, IUnrealObject, IBlendableInterface, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x060211FC RID: 135676 RVA: 0x0030D85E File Offset: 0x0030BA5E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULightPropagationVolumeBlendable._ClassPtr;
		}

		// Token: 0x060211FD RID: 135677 RVA: 0x0030D86A File Offset: 0x0030BA6A
		int IBlendableInterface.InterfaceOffset()
		{
			return ULightPropagationVolumeBlendable.__InterfaceOffset_IBlendableInterface;
		}

		// Token: 0x060211FE RID: 135678 RVA: 0x0030D874 File Offset: 0x0030BA74
		public ULightPropagationVolumeBlendable() : this(BuiltinUtils.AllocNativeUObject(ULightPropagationVolumeBlendable.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060211FF RID: 135679 RVA: 0x0030D89C File Offset: 0x0030BA9C
		[NullableContext(1)]
		public ULightPropagationVolumeBlendable(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULightPropagationVolumeBlendable.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700815F RID: 33119
		// (get) Token: 0x06021200 RID: 135680 RVA: 0x0030D8D0 File Offset: 0x0030BAD0
		// (set) Token: 0x06021201 RID: 135681 RVA: 0x0030D909 File Offset: 0x0030BB09
		[Nullable(1)]
		public FLightPropagationVolumeSettings Settings
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FLightPropagationVolumeSettings result;
				if ((result = this._Settings) == null)
				{
					result = (this._Settings = new FLightPropagationVolumeSettings(base.NativePtr + (IntPtr)ULightPropagationVolumeBlendable.__PropertyOffset_Settings, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FLightPropagationVolumeSettings.StaticStruct(), base.NativePtr + (IntPtr)ULightPropagationVolumeBlendable.__PropertyOffset_Settings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008160 RID: 33120
		// (get) Token: 0x06021202 RID: 135682 RVA: 0x0030D92A File Offset: 0x0030BB2A
		// (set) Token: 0x06021203 RID: 135683 RVA: 0x0030D93A File Offset: 0x0030BB3A
		public unsafe float BlendWeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULightPropagationVolumeBlendable.__PropertyOffset_BlendWeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULightPropagationVolumeBlendable.__PropertyOffset_BlendWeight) = value;
			}
		}

		// Token: 0x06021204 RID: 135684 RVA: 0x0030D94B File Offset: 0x0030BB4B
		static ULightPropagationVolumeBlendable()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LightPropagationVolumeRuntime.LightPropagationVolumeBlendable");
		}

		// Token: 0x06021205 RID: 135685 RVA: 0x0030D959 File Offset: 0x0030BB59
		protected ULightPropagationVolumeBlendable(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011AC4 RID: 72388
		internal static int __InterfaceOffset_IBlendableInterface;

		// Token: 0x04011AC5 RID: 72389
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LightPropagationVolumeRuntime.LightPropagationVolumeBlendable";

		// Token: 0x04011AC6 RID: 72390
		private static IntPtr _ClassPtr;

		// Token: 0x04011AC7 RID: 72391
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011AC8 RID: 72392
		internal static int __PropertyOffset_Settings;

		// Token: 0x04011AC9 RID: 72393
		[Nullable(2)]
		private FLightPropagationVolumeSettings _Settings;

		// Token: 0x04011ACA RID: 72394
		internal static int __PropertyOffset_BlendWeight;
	}
}
