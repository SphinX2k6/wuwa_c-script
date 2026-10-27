using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200114B RID: 4427
	[UnrealObjectPath("/Script/Engine.SoundNodeParamCrossFade")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 120)]
	public class USoundNodeParamCrossFade : USoundNodeDistanceCrossFade, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060102D2 RID: 66258 RVA: 0x0017D630 File Offset: 0x0017B830
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USoundNodeParamCrossFade._ClassPtr;
		}

		// Token: 0x060102D3 RID: 66259 RVA: 0x0017D63C File Offset: 0x0017B83C
		public USoundNodeParamCrossFade() : this(BuiltinUtils.AllocNativeUObject(USoundNodeParamCrossFade.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060102D4 RID: 66260 RVA: 0x0017D664 File Offset: 0x0017B864
		[NullableContext(1)]
		public USoundNodeParamCrossFade(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USoundNodeParamCrossFade.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003F59 RID: 16217
		// (get) Token: 0x060102D5 RID: 66261 RVA: 0x0017D697 File Offset: 0x0017B897
		// (set) Token: 0x060102D6 RID: 66262 RVA: 0x0017D6AB File Offset: 0x0017B8AB
		public unsafe FName ParamName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USoundNodeParamCrossFade.__PropertyOffset_ParamName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USoundNodeParamCrossFade.__PropertyOffset_ParamName) = value;
			}
		}

		// Token: 0x060102D7 RID: 66263 RVA: 0x0017D6C0 File Offset: 0x0017B8C0
		static USoundNodeParamCrossFade()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.SoundNodeParamCrossFade");
		}

		// Token: 0x060102D8 RID: 66264 RVA: 0x0017D6CE File Offset: 0x0017B8CE
		protected USoundNodeParamCrossFade(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008B43 RID: 35651
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.SoundNodeParamCrossFade";

		// Token: 0x04008B44 RID: 35652
		private static IntPtr _ClassPtr;

		// Token: 0x04008B45 RID: 35653
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04008B46 RID: 35654
		internal static int __PropertyOffset_ParamName;
	}
}
