using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200030E RID: 782
	[UnrealObjectPath("/Script/KuroAudio.KuroAmbientSoundActor")]
	[UnrealStructLayout(1072, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1072)]
	public class AKuroAmbientSoundActor : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06005340 RID: 21312 RVA: 0x0007473E File Offset: 0x0007293E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroAmbientSoundActor._ClassPtr;
		}

		// Token: 0x06005341 RID: 21313 RVA: 0x0007474C File Offset: 0x0007294C
		public AKuroAmbientSoundActor() : this(BuiltinUtils.AllocNativeUObject(AKuroAmbientSoundActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06005342 RID: 21314 RVA: 0x00074774 File Offset: 0x00072974
		[NullableContext(1)]
		public AKuroAmbientSoundActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroAmbientSoundActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700108A RID: 4234
		// (get) Token: 0x06005343 RID: 21315 RVA: 0x000747A7 File Offset: 0x000729A7
		// (set) Token: 0x06005344 RID: 21316 RVA: 0x000747BB File Offset: 0x000729BB
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

		// Token: 0x06005345 RID: 21317 RVA: 0x000747D0 File Offset: 0x000729D0
		static AKuroAmbientSoundActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroAudio.KuroAmbientSoundActor");
		}

		// Token: 0x06005346 RID: 21318 RVA: 0x000747DE File Offset: 0x000729DE
		protected AKuroAmbientSoundActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002210 RID: 8720
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroAudio.KuroAmbientSoundActor";

		// Token: 0x04002211 RID: 8721
		private static IntPtr _ClassPtr;

		// Token: 0x04002212 RID: 8722
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04002213 RID: 8723
		internal static int __PropertyOffset_AmbientSoundComponent;
	}
}
