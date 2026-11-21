using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020002F5 RID: 757
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroAnim.KuroAudioRecorder")]
	[UnrealStructLayout(176, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 176)]
	public class UKuroAudioRecorder : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06005255 RID: 21077 RVA: 0x0007328C File Offset: 0x0007148C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroAudioRecorder._ClassPtr;
		}

		// Token: 0x06005256 RID: 21078 RVA: 0x00073298 File Offset: 0x00071498
		public UKuroAudioRecorder() : this(BuiltinUtils.AllocNativeUObject(UKuroAudioRecorder.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06005257 RID: 21079 RVA: 0x000732C0 File Offset: 0x000714C0
		[NullableContext(1)]
		public UKuroAudioRecorder(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroAudioRecorder.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700105E RID: 4190
		// (get) Token: 0x06005258 RID: 21080 RVA: 0x000732F3 File Offset: 0x000714F3
		// (set) Token: 0x06005259 RID: 21081 RVA: 0x00073307 File Offset: 0x00071507
		public unsafe ULevelSequence OutSequence
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULevelSequence>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroAudioRecorder.__PropertyOffset_OutSequence);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroAudioRecorder.__PropertyOffset_OutSequence, value);
			}
		}

		// Token: 0x1700105F RID: 4191
		// (get) Token: 0x0600525A RID: 21082 RVA: 0x0007331C File Offset: 0x0007151C
		// (set) Token: 0x0600525B RID: 21083 RVA: 0x00073330 File Offset: 0x00071530
		public unsafe UMovieSceneAkAudioEventTrack AudioTrack
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMovieSceneAkAudioEventTrack>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroAudioRecorder.__PropertyOffset_AudioTrack);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroAudioRecorder.__PropertyOffset_AudioTrack, value);
			}
		}

		// Token: 0x0600525C RID: 21084 RVA: 0x00073345 File Offset: 0x00071545
		static UKuroAudioRecorder()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroAnim.KuroAudioRecorder");
		}

		// Token: 0x0600525D RID: 21085 RVA: 0x00073353 File Offset: 0x00071553
		protected UKuroAudioRecorder(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002183 RID: 8579
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroAnim.KuroAudioRecorder";

		// Token: 0x04002184 RID: 8580
		private static IntPtr _ClassPtr;

		// Token: 0x04002185 RID: 8581
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04002186 RID: 8582
		internal static int __PropertyOffset_OutSequence;

		// Token: 0x04002187 RID: 8583
		internal static int __PropertyOffset_AudioTrack;
	}
}
