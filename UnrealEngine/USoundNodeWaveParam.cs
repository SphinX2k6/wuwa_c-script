using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001150 RID: 4432
	[UnrealObjectPath("/Script/Engine.SoundNodeWaveParam")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class USoundNodeWaveParam : USoundNode, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06010301 RID: 66305 RVA: 0x0017DAF3 File Offset: 0x0017BCF3
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USoundNodeWaveParam._ClassPtr;
		}

		// Token: 0x06010302 RID: 66306 RVA: 0x0017DB00 File Offset: 0x0017BD00
		public USoundNodeWaveParam() : this(BuiltinUtils.AllocNativeUObject(USoundNodeWaveParam.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06010303 RID: 66307 RVA: 0x0017DB28 File Offset: 0x0017BD28
		[NullableContext(1)]
		public USoundNodeWaveParam(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USoundNodeWaveParam.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003F64 RID: 16228
		// (get) Token: 0x06010304 RID: 66308 RVA: 0x0017DB5B File Offset: 0x0017BD5B
		// (set) Token: 0x06010305 RID: 66309 RVA: 0x0017DB6F File Offset: 0x0017BD6F
		public unsafe FName WaveParameterName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USoundNodeWaveParam.__PropertyOffset_WaveParameterName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USoundNodeWaveParam.__PropertyOffset_WaveParameterName) = value;
			}
		}

		// Token: 0x06010306 RID: 66310 RVA: 0x0017DB84 File Offset: 0x0017BD84
		static USoundNodeWaveParam()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.SoundNodeWaveParam");
		}

		// Token: 0x06010307 RID: 66311 RVA: 0x0017DB92 File Offset: 0x0017BD92
		protected USoundNodeWaveParam(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008B62 RID: 35682
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.SoundNodeWaveParam";

		// Token: 0x04008B63 RID: 35683
		private static IntPtr _ClassPtr;

		// Token: 0x04008B64 RID: 35684
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04008B65 RID: 35685
		internal static int __PropertyOffset_WaveParameterName;
	}
}
