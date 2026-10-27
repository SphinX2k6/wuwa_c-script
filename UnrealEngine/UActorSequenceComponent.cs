using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020000D4 RID: 212
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ActorSequence.ActorSequenceComponent")]
	[UnrealStructLayout(240, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 240)]
	public class UActorSequenceComponent : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001168 RID: 4456 RVA: 0x00019FA1 File Offset: 0x000181A1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UActorSequenceComponent._ClassPtr;
		}

		// Token: 0x06001169 RID: 4457 RVA: 0x00019FB0 File Offset: 0x000181B0
		public UActorSequenceComponent() : this(BuiltinUtils.AllocNativeUObject(UActorSequenceComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600116A RID: 4458 RVA: 0x00019FD8 File Offset: 0x000181D8
		[NullableContext(1)]
		public UActorSequenceComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UActorSequenceComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170004F4 RID: 1268
		// (get) Token: 0x0600116B RID: 4459 RVA: 0x0001A00C File Offset: 0x0001820C
		// (set) Token: 0x0600116C RID: 4460 RVA: 0x0001A045 File Offset: 0x00018245
		[Nullable(1)]
		public FMovieSceneSequencePlaybackSettings PlaybackSettings
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FMovieSceneSequencePlaybackSettings result;
				if ((result = this._PlaybackSettings) == null)
				{
					result = (this._PlaybackSettings = new FMovieSceneSequencePlaybackSettings(base.NativePtr + (IntPtr)UActorSequenceComponent.__PropertyOffset_PlaybackSettings, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneSequencePlaybackSettings.StaticStruct(), base.NativePtr + (IntPtr)UActorSequenceComponent.__PropertyOffset_PlaybackSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170004F5 RID: 1269
		// (get) Token: 0x0600116D RID: 4461 RVA: 0x0001A066 File Offset: 0x00018266
		// (set) Token: 0x0600116E RID: 4462 RVA: 0x0001A07A File Offset: 0x0001827A
		public unsafe UActorSequence Sequence
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UActorSequence>(base.NativePtr / (IntPtr)sizeof(void*) + UActorSequenceComponent.__PropertyOffset_Sequence);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UActorSequenceComponent.__PropertyOffset_Sequence, value);
			}
		}

		// Token: 0x170004F6 RID: 1270
		// (get) Token: 0x0600116F RID: 4463 RVA: 0x0001A08F File Offset: 0x0001828F
		// (set) Token: 0x06001170 RID: 4464 RVA: 0x0001A0A3 File Offset: 0x000182A3
		public unsafe UActorSequencePlayer SequencePlayer
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UActorSequencePlayer>(base.NativePtr / (IntPtr)sizeof(void*) + UActorSequenceComponent.__PropertyOffset_SequencePlayer);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UActorSequenceComponent.__PropertyOffset_SequencePlayer, value);
			}
		}

		// Token: 0x06001171 RID: 4465 RVA: 0x0001A0B8 File Offset: 0x000182B8
		static UActorSequenceComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/ActorSequence.ActorSequenceComponent");
		}

		// Token: 0x06001172 RID: 4466 RVA: 0x0001A0C6 File Offset: 0x000182C6
		protected UActorSequenceComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040002AF RID: 687
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ActorSequence.ActorSequenceComponent";

		// Token: 0x040002B0 RID: 688
		private static IntPtr _ClassPtr;

		// Token: 0x040002B1 RID: 689
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040002B2 RID: 690
		internal static int __PropertyOffset_PlaybackSettings;

		// Token: 0x040002B3 RID: 691
		private FMovieSceneSequencePlaybackSettings _PlaybackSettings;

		// Token: 0x040002B4 RID: 692
		internal static int __PropertyOffset_Sequence;

		// Token: 0x040002B5 RID: 693
		internal static int __PropertyOffset_SequencePlayer;
	}
}
