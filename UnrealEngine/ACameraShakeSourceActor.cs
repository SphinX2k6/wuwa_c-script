using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000914 RID: 2324
	[UnrealObjectPath("/Script/Engine.CameraShakeSourceActor")]
	[UnrealStructLayout(1048, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1048)]
	public class ACameraShakeSourceActor : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06007FE6 RID: 32742 RVA: 0x000B747F File Offset: 0x000B567F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ACameraShakeSourceActor._ClassPtr;
		}

		// Token: 0x06007FE7 RID: 32743 RVA: 0x000B748C File Offset: 0x000B568C
		public ACameraShakeSourceActor() : this(BuiltinUtils.AllocNativeUObject(ACameraShakeSourceActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06007FE8 RID: 32744 RVA: 0x000B74B4 File Offset: 0x000B56B4
		[NullableContext(1)]
		public ACameraShakeSourceActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ACameraShakeSourceActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001E14 RID: 7700
		// (get) Token: 0x06007FE9 RID: 32745 RVA: 0x000B74E7 File Offset: 0x000B56E7
		// (set) Token: 0x06007FEA RID: 32746 RVA: 0x000B74FB File Offset: 0x000B56FB
		[Nullable(2)]
		public unsafe UCameraShakeSourceComponent CameraShakeSourceComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCameraShakeSourceComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ACameraShakeSourceActor.__PropertyOffset_CameraShakeSourceComponent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ACameraShakeSourceActor.__PropertyOffset_CameraShakeSourceComponent, value);
			}
		}

		// Token: 0x06007FEB RID: 32747 RVA: 0x000B7510 File Offset: 0x000B5710
		static ACameraShakeSourceActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.CameraShakeSourceActor");
		}

		// Token: 0x06007FEC RID: 32748 RVA: 0x000B751E File Offset: 0x000B571E
		protected ACameraShakeSourceActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003D4F RID: 15695
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.CameraShakeSourceActor";

		// Token: 0x04003D50 RID: 15696
		private static IntPtr _ClassPtr;

		// Token: 0x04003D51 RID: 15697
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003D52 RID: 15698
		internal static int __PropertyOffset_CameraShakeSourceComponent;
	}
}
