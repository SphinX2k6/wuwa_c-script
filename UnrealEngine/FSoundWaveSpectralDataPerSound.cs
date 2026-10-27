using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001160 RID: 4448
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.SoundWaveSpectralDataPerSound")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FSoundWaveSpectralDataPerSound : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06010418 RID: 66584 RVA: 0x0017F2D4 File Offset: 0x0017D4D4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSoundWaveSpectralDataPerSound._ScriptStructPtr != 0) ? FSoundWaveSpectralDataPerSound._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.SoundWaveSpectralDataPerSound", ref FSoundWaveSpectralDataPerSound._ScriptStructPtr);
		}

		// Token: 0x17003FB3 RID: 16307
		// (get) Token: 0x06010419 RID: 66585 RVA: 0x0017F2F8 File Offset: 0x0017D4F8
		// (set) Token: 0x0601041A RID: 66586 RVA: 0x0017F33B File Offset: 0x0017D53B
		public TArray<FSoundWaveSpectralData> SpectralData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSoundWaveSpectralData> result;
				if ((result = this._SpectralData) == null)
				{
					result = (this._SpectralData = new TArray<FSoundWaveSpectralData>(base.NativePtr + (IntPtr)FSoundWaveSpectralDataPerSound.__PropertyOffset_SpectralData, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SpectralData.CopyAssign(value);
			}
		}

		// Token: 0x17003FB4 RID: 16308
		// (get) Token: 0x0601041B RID: 66587 RVA: 0x0017F349 File Offset: 0x0017D549
		// (set) Token: 0x0601041C RID: 66588 RVA: 0x0017F359 File Offset: 0x0017D559
		public unsafe float PlaybackTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSoundWaveSpectralDataPerSound.__PropertyOffset_PlaybackTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSoundWaveSpectralDataPerSound.__PropertyOffset_PlaybackTime) = value;
			}
		}

		// Token: 0x17003FB5 RID: 16309
		// (get) Token: 0x0601041D RID: 66589 RVA: 0x0017F36A File Offset: 0x0017D56A
		// (set) Token: 0x0601041E RID: 66590 RVA: 0x0017F37E File Offset: 0x0017D57E
		[Nullable(2)]
		public unsafe USoundWave SoundWave
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USoundWave>(base.NativePtr / (IntPtr)sizeof(void*) + FSoundWaveSpectralDataPerSound.__PropertyOffset_SoundWave);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FSoundWaveSpectralDataPerSound.__PropertyOffset_SoundWave, value);
			}
		}

		// Token: 0x0601041F RID: 66591 RVA: 0x0017F393 File Offset: 0x0017D593
		public FSoundWaveSpectralDataPerSound()
		{
		}

		// Token: 0x06010420 RID: 66592 RVA: 0x0017F39B File Offset: 0x0017D59B
		public FSoundWaveSpectralDataPerSound(TArray<FSoundWaveSpectralData> SpectralData, float PlaybackTime, USoundWave SoundWave)
		{
			this.SpectralData = SpectralData;
			this.PlaybackTime = PlaybackTime;
			this.SoundWave = SoundWave;
		}

		// Token: 0x06010421 RID: 66593 RVA: 0x0017F3B8 File Offset: 0x0017D5B8
		protected override IntPtr GetUStructPtr()
		{
			return FSoundWaveSpectralDataPerSound.StaticStruct();
		}

		// Token: 0x06010422 RID: 66594 RVA: 0x0017F3C4 File Offset: 0x0017D5C4
		[NullableContext(2)]
		public FSoundWaveSpectralDataPerSound(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06010423 RID: 66595 RVA: 0x0017F3CE File Offset: 0x0017D5CE
		public FSoundWaveSpectralDataPerSound(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06010424 RID: 66596 RVA: 0x0017F3D9 File Offset: 0x0017D5D9
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSoundWaveSpectralDataPerSound(Pointer, false, true);
		}

		// Token: 0x06010425 RID: 66597 RVA: 0x0017F3E3 File Offset: 0x0017D5E3
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSoundWaveSpectralDataPerSound(Pointer, MemoryOwner);
		}

		// Token: 0x04008BEE RID: 35822
		public const string __ObjectPath = "/Script/Engine.SoundWaveSpectralDataPerSound";

		// Token: 0x04008BEF RID: 35823
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04008BF0 RID: 35824
		internal static int __PropertyOffset_SpectralData;

		// Token: 0x04008BF1 RID: 35825
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSoundWaveSpectralData> _SpectralData;

		// Token: 0x04008BF2 RID: 35826
		internal static int __PropertyOffset_PlaybackTime;

		// Token: 0x04008BF3 RID: 35827
		internal static int __PropertyOffset_SoundWave;
	}
}
