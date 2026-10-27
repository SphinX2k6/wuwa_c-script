using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020001F4 RID: 500
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AkAudio.AkAuxBus")]
	[UnrealStructLayout(256, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 256)]
	public class UAkAuxBus : UAkAudioType, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001D6D RID: 7533 RVA: 0x0002BC69 File Offset: 0x00029E69
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAkAuxBus._ClassPtr;
		}

		// Token: 0x06001D6E RID: 7534 RVA: 0x0002BC78 File Offset: 0x00029E78
		public UAkAuxBus() : this(BuiltinUtils.AllocNativeUObject(UAkAuxBus.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001D6F RID: 7535 RVA: 0x0002BCA0 File Offset: 0x00029EA0
		public UAkAuxBus(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAkAuxBus.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000769 RID: 1897
		// (get) Token: 0x06001D70 RID: 7536 RVA: 0x0002BCD4 File Offset: 0x00029ED4
		// (set) Token: 0x06001D71 RID: 7537 RVA: 0x0002BD0D File Offset: 0x00029F0D
		public FWwiseLocalizedAuxBusCookedData AuxBusCookedData
		{
			get
			{
				base.FastCheckIsValid();
				FWwiseLocalizedAuxBusCookedData result;
				if ((result = this._AuxBusCookedData) == null)
				{
					result = (this._AuxBusCookedData = new FWwiseLocalizedAuxBusCookedData(base.NativePtr + (IntPtr)UAkAuxBus.__PropertyOffset_AuxBusCookedData, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FWwiseLocalizedAuxBusCookedData.StaticStruct(), base.NativePtr + (IntPtr)UAkAuxBus.__PropertyOffset_AuxBusCookedData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700076A RID: 1898
		// (get) Token: 0x06001D72 RID: 7538 RVA: 0x0002BD2E File Offset: 0x00029F2E
		// (set) Token: 0x06001D73 RID: 7539 RVA: 0x0002BD42 File Offset: 0x00029F42
		[Nullable(2)]
		public unsafe UAkAudioBank RequiredBank_DEPRECATED
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkAudioBank>(base.NativePtr / (IntPtr)sizeof(void*) + UAkAuxBus.__PropertyOffset_RequiredBank_DEPRECATED);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UAkAuxBus.__PropertyOffset_RequiredBank_DEPRECATED, value);
			}
		}

		// Token: 0x06001D74 RID: 7540 RVA: 0x0002BD57 File Offset: 0x00029F57
		static UAkAuxBus()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AkAudio.AkAuxBus");
		}

		// Token: 0x06001D75 RID: 7541 RVA: 0x0002BD65 File Offset: 0x00029F65
		protected UAkAuxBus(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040009B2 RID: 2482
		public new const string __ObjectPath = "/Script/AkAudio.AkAuxBus";

		// Token: 0x040009B3 RID: 2483
		private static IntPtr _ClassPtr;

		// Token: 0x040009B4 RID: 2484
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040009B5 RID: 2485
		internal static int __PropertyOffset_AuxBusCookedData;

		// Token: 0x040009B6 RID: 2486
		[Nullable(2)]
		private FWwiseLocalizedAuxBusCookedData _AuxBusCookedData;

		// Token: 0x040009B7 RID: 2487
		internal static int __PropertyOffset_RequiredBank_DEPRECATED;
	}
}
