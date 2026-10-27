using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001151 RID: 4433
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.SoundNodeWavePlayer")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 160)]
	public class USoundNodeWavePlayer : USoundNodeAssetReferencer, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06010308 RID: 66312 RVA: 0x0017DB9B File Offset: 0x0017BD9B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USoundNodeWavePlayer._ClassPtr;
		}

		// Token: 0x06010309 RID: 66313 RVA: 0x0017DBA8 File Offset: 0x0017BDA8
		public USoundNodeWavePlayer() : this(BuiltinUtils.AllocNativeUObject(USoundNodeWavePlayer.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601030A RID: 66314 RVA: 0x0017DBD0 File Offset: 0x0017BDD0
		public USoundNodeWavePlayer(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USoundNodeWavePlayer.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003F65 RID: 16229
		// (get) Token: 0x0601030B RID: 66315 RVA: 0x0017DC03 File Offset: 0x0017BE03
		// (set) Token: 0x0601030C RID: 66316 RVA: 0x0017DC18 File Offset: 0x0017BE18
		public TSoftObjectPtr<USoundWave> SoundWaveAssetPtr
		{
			get
			{
				return new TSoftObjectPtr<USoundWave>(base.NativePtr + (IntPtr)USoundNodeWavePlayer.__PropertyOffset_SoundWaveAssetPtr, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)USoundNodeWavePlayer.__PropertyOffset_SoundWaveAssetPtr, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17003F66 RID: 16230
		// (get) Token: 0x0601030D RID: 66317 RVA: 0x0017DC3D File Offset: 0x0017BE3D
		// (set) Token: 0x0601030E RID: 66318 RVA: 0x0017DC51 File Offset: 0x0017BE51
		[Nullable(2)]
		public unsafe USoundWave SoundWave
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USoundWave>(base.NativePtr / (IntPtr)sizeof(void*) + USoundNodeWavePlayer.__PropertyOffset_SoundWave);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USoundNodeWavePlayer.__PropertyOffset_SoundWave, value);
			}
		}

		// Token: 0x17003F67 RID: 16231
		// (get) Token: 0x0601030F RID: 66319 RVA: 0x0017DC66 File Offset: 0x0017BE66
		// (set) Token: 0x06010310 RID: 66320 RVA: 0x0017DC7F File Offset: 0x0017BE7F
		public unsafe bool bLooping
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USoundNodeWavePlayer.__PropertyOffset_bLooping) & USoundNodeWavePlayer.__PropertyMask_bLooping) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USoundNodeWavePlayer.__PropertyOffset_bLooping) = ((*(base.NativePtr + (IntPtr)USoundNodeWavePlayer.__PropertyOffset_bLooping) & ~USoundNodeWavePlayer.__PropertyMask_bLooping) | (value ? USoundNodeWavePlayer.__PropertyMask_bLooping : 0));
			}
		}

		// Token: 0x06010311 RID: 66321 RVA: 0x0017DCAF File Offset: 0x0017BEAF
		static USoundNodeWavePlayer()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.SoundNodeWavePlayer");
		}

		// Token: 0x06010312 RID: 66322 RVA: 0x0017DCBD File Offset: 0x0017BEBD
		protected USoundNodeWavePlayer(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008B66 RID: 35686
		public new const string __ObjectPath = "/Script/Engine.SoundNodeWavePlayer";

		// Token: 0x04008B67 RID: 35687
		private static IntPtr _ClassPtr;

		// Token: 0x04008B68 RID: 35688
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04008B69 RID: 35689
		internal static int __PropertyOffset_SoundWaveAssetPtr;

		// Token: 0x04008B6A RID: 35690
		internal static int __PropertyOffset_SoundWave;

		// Token: 0x04008B6B RID: 35691
		internal static int __PropertyOffset_bLooping;

		// Token: 0x04008B6C RID: 35692
		internal static byte __PropertyMask_bLooping;
	}
}
