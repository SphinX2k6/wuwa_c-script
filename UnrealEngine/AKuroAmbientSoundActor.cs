using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001693 RID: 5779
	[UnrealObjectPath("/Script/KuroAudio.KuroAmbientSoundActor")]
	[UnrealStructLayout(1072, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1072)]
	public class AKuroAmbientSoundActor : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06014F57 RID: 85847 RVA: 0x001ECF6E File Offset: 0x001EB16E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroAmbientSoundActor._ClassPtr;
		}

		// Token: 0x06014F58 RID: 85848 RVA: 0x001ECF7C File Offset: 0x001EB17C
		public AKuroAmbientSoundActor() : this(BuiltinUtils.AllocNativeUObject(AKuroAmbientSoundActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06014F59 RID: 85849 RVA: 0x001ECFA4 File Offset: 0x001EB1A4
		[NullableContext(1)]
		public AKuroAmbientSoundActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroAmbientSoundActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005307 RID: 21255
		// (get) Token: 0x06014F5A RID: 85850 RVA: 0x001ECFD7 File Offset: 0x001EB1D7
		// (set) Token: 0x06014F5B RID: 85851 RVA: 0x001ECFEB File Offset: 0x001EB1EB
		[Nullable(2)]
		public unsafe UKuroAmbientSoundComponent AmbientSoundComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroAmbientSoundComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroAmbientSoundActor.__PropertyOffset_AmbientSoundComponent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroAmbientSoundActor.__PropertyOffset_AmbientSoundComponent, value);
			}
		}

		// Token: 0x06014F5C RID: 85852 RVA: 0x001ED000 File Offset: 0x001EB200
		static AKuroAmbientSoundActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroAudio.KuroAmbientSoundActor");
		}

		// Token: 0x06014F5D RID: 85853 RVA: 0x001ED00E File Offset: 0x001EB20E
		protected AKuroAmbientSoundActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400B6BA RID: 46778
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroAudio.KuroAmbientSoundActor";

		// Token: 0x0400B6BB RID: 46779
		private static IntPtr _ClassPtr;

		// Token: 0x0400B6BC RID: 46780
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400B6BD RID: 46781
		internal static int __PropertyOffset_AmbientSoundComponent;
	}
}
