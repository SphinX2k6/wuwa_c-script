using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000246 RID: 582
	[UnrealObjectPath("/Script/AkAudio.AkSubmixInputComponent")]
	[UnrealStructLayout(1088, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1088)]
	public class UAkSubmixInputComponent : UAkAudioInputComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06002280 RID: 8832 RVA: 0x0003328A File Offset: 0x0003148A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAkSubmixInputComponent._ClassPtr;
		}

		// Token: 0x06002281 RID: 8833 RVA: 0x00033298 File Offset: 0x00031498
		public UAkSubmixInputComponent() : this(BuiltinUtils.AllocNativeUObject(UAkSubmixInputComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06002282 RID: 8834 RVA: 0x000332C0 File Offset: 0x000314C0
		[NullableContext(1)]
		public UAkSubmixInputComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAkSubmixInputComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000876 RID: 2166
		// (get) Token: 0x06002283 RID: 8835 RVA: 0x000332F3 File Offset: 0x000314F3
		// (set) Token: 0x06002284 RID: 8836 RVA: 0x00033307 File Offset: 0x00031507
		[Nullable(2)]
		public unsafe USoundSubmix SubmixToRecord
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USoundSubmix>(base.NativePtr / (IntPtr)sizeof(void*) + UAkSubmixInputComponent.__PropertyOffset_SubmixToRecord);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UAkSubmixInputComponent.__PropertyOffset_SubmixToRecord, value);
			}
		}

		// Token: 0x06002285 RID: 8837 RVA: 0x0003331C File Offset: 0x0003151C
		static UAkSubmixInputComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AkAudio.AkSubmixInputComponent");
		}

		// Token: 0x06002286 RID: 8838 RVA: 0x0003332A File Offset: 0x0003152A
		protected UAkSubmixInputComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000BE6 RID: 3046
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AkAudio.AkSubmixInputComponent";

		// Token: 0x04000BE7 RID: 3047
		private static IntPtr _ClassPtr;

		// Token: 0x04000BE8 RID: 3048
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000BE9 RID: 3049
		internal static int __PropertyOffset_SubmixToRecord;
	}
}
