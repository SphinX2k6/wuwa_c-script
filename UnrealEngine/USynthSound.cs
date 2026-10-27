using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000386 RID: 902
	[UnrealObjectPath("/Script/AudioMixer.SynthSound")]
	[UnrealStructLayout(1392, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1392)]
	public class USynthSound : USoundWaveProcedural, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060031DE RID: 12766 RVA: 0x0004D0F2 File Offset: 0x0004B2F2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USynthSound._ClassPtr;
		}

		// Token: 0x060031DF RID: 12767 RVA: 0x0004D100 File Offset: 0x0004B300
		public USynthSound() : this(BuiltinUtils.AllocNativeUObject(USynthSound.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060031E0 RID: 12768 RVA: 0x0004D128 File Offset: 0x0004B328
		[NullableContext(1)]
		public USynthSound(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USynthSound.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000C2C RID: 3116
		// (get) Token: 0x060031E1 RID: 12769 RVA: 0x0004D15B File Offset: 0x0004B35B
		// (set) Token: 0x060031E2 RID: 12770 RVA: 0x0004D16F File Offset: 0x0004B36F
		[Nullable(2)]
		public unsafe USynthComponent OwningSynthComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USynthComponent>(base.NativePtr / (IntPtr)sizeof(void*) + USynthSound.__PropertyOffset_OwningSynthComponent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USynthSound.__PropertyOffset_OwningSynthComponent, value);
			}
		}

		// Token: 0x060031E3 RID: 12771 RVA: 0x0004D184 File Offset: 0x0004B384
		static USynthSound()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AudioMixer.SynthSound");
		}

		// Token: 0x060031E4 RID: 12772 RVA: 0x0004D192 File Offset: 0x0004B392
		protected USynthSound(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040015BF RID: 5567
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AudioMixer.SynthSound";

		// Token: 0x040015C0 RID: 5568
		private static IntPtr _ClassPtr;

		// Token: 0x040015C1 RID: 5569
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040015C2 RID: 5570
		internal static int __PropertyOffset_OwningSynthComponent;
	}
}
