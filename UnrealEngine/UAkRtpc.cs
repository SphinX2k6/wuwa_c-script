using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200023D RID: 573
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AkAudio.AkRtpc")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 160)]
	public class UAkRtpc : UAkAudioType, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06002173 RID: 8563 RVA: 0x00031A84 File Offset: 0x0002FC84
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAkRtpc._ClassPtr;
		}

		// Token: 0x06002174 RID: 8564 RVA: 0x00031A90 File Offset: 0x0002FC90
		public UAkRtpc() : this(BuiltinUtils.AllocNativeUObject(UAkRtpc.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06002175 RID: 8565 RVA: 0x00031AB8 File Offset: 0x0002FCB8
		public UAkRtpc(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAkRtpc.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000814 RID: 2068
		// (get) Token: 0x06002176 RID: 8566 RVA: 0x00031AEC File Offset: 0x0002FCEC
		// (set) Token: 0x06002177 RID: 8567 RVA: 0x00031B25 File Offset: 0x0002FD25
		public FWwiseGameParameterCookedData GameParameterCookedData
		{
			get
			{
				base.FastCheckIsValid();
				FWwiseGameParameterCookedData result;
				if ((result = this._GameParameterCookedData) == null)
				{
					result = (this._GameParameterCookedData = new FWwiseGameParameterCookedData(base.NativePtr + (IntPtr)UAkRtpc.__PropertyOffset_GameParameterCookedData, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FWwiseGameParameterCookedData.StaticStruct(), base.NativePtr + (IntPtr)UAkRtpc.__PropertyOffset_GameParameterCookedData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06002178 RID: 8568 RVA: 0x00031B46 File Offset: 0x0002FD46
		static UAkRtpc()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AkAudio.AkRtpc");
		}

		// Token: 0x06002179 RID: 8569 RVA: 0x00031B54 File Offset: 0x0002FD54
		protected UAkRtpc(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000B56 RID: 2902
		public new const string __ObjectPath = "/Script/AkAudio.AkRtpc";

		// Token: 0x04000B57 RID: 2903
		private static IntPtr _ClassPtr;

		// Token: 0x04000B58 RID: 2904
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000B59 RID: 2905
		internal static int __PropertyOffset_GameParameterCookedData;

		// Token: 0x04000B5A RID: 2906
		[Nullable(2)]
		private FWwiseGameParameterCookedData _GameParameterCookedData;
	}
}
