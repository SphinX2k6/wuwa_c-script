using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000CB2 RID: 3250
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.InterpTrackParticleReplay")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 192)]
	public class UInterpTrackParticleReplay : UInterpTrack, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A461 RID: 42081 RVA: 0x000E9CA1 File Offset: 0x000E7EA1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UInterpTrackParticleReplay._ClassPtr;
		}

		// Token: 0x0600A462 RID: 42082 RVA: 0x000E9CB0 File Offset: 0x000E7EB0
		public UInterpTrackParticleReplay() : this(BuiltinUtils.AllocNativeUObject(UInterpTrackParticleReplay.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A463 RID: 42083 RVA: 0x000E9CD8 File Offset: 0x000E7ED8
		public UInterpTrackParticleReplay(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UInterpTrackParticleReplay.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700271C RID: 10012
		// (get) Token: 0x0600A464 RID: 42084 RVA: 0x000E9D0C File Offset: 0x000E7F0C
		// (set) Token: 0x0600A465 RID: 42085 RVA: 0x000E9D45 File Offset: 0x000E7F45
		public TArray<FParticleReplayTrackKey> TrackKeys
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FParticleReplayTrackKey> result;
				if ((result = this._TrackKeys) == null)
				{
					result = (this._TrackKeys = new TArray<FParticleReplayTrackKey>(base.NativePtr + (IntPtr)UInterpTrackParticleReplay.__PropertyOffset_TrackKeys, this));
				}
				return result;
			}
			set
			{
				this.TrackKeys.CopyAssign(value);
			}
		}

		// Token: 0x0600A466 RID: 42086 RVA: 0x000E9D53 File Offset: 0x000E7F53
		static UInterpTrackParticleReplay()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.InterpTrackParticleReplay");
		}

		// Token: 0x0600A467 RID: 42087 RVA: 0x000E9D61 File Offset: 0x000E7F61
		protected UInterpTrackParticleReplay(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005A69 RID: 23145
		public new const string __ObjectPath = "/Script/Engine.InterpTrackParticleReplay";

		// Token: 0x04005A6A RID: 23146
		private static IntPtr _ClassPtr;

		// Token: 0x04005A6B RID: 23147
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04005A6C RID: 23148
		internal static int __PropertyOffset_TrackKeys;

		// Token: 0x04005A6D RID: 23149
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FParticleReplayTrackKey> _TrackKeys;
	}
}
