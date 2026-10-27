using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E9B RID: 3739
	[UnrealObjectPath("/Script/Engine.MatineeActorCameraAnim")]
	[UnrealStructLayout(1392, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1392)]
	public class AMatineeActorCameraAnim : AMatineeActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C9A7 RID: 51623 RVA: 0x00125A23 File Offset: 0x00123C23
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AMatineeActorCameraAnim._ClassPtr;
		}

		// Token: 0x0600C9A8 RID: 51624 RVA: 0x00125A30 File Offset: 0x00123C30
		public AMatineeActorCameraAnim() : this(BuiltinUtils.AllocNativeUObject(AMatineeActorCameraAnim.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C9A9 RID: 51625 RVA: 0x00125A58 File Offset: 0x00123C58
		[NullableContext(1)]
		public AMatineeActorCameraAnim(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AMatineeActorCameraAnim.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002F44 RID: 12100
		// (get) Token: 0x0600C9AA RID: 51626 RVA: 0x00125A8B File Offset: 0x00123C8B
		// (set) Token: 0x0600C9AB RID: 51627 RVA: 0x00125A9F File Offset: 0x00123C9F
		[Nullable(2)]
		public unsafe UCameraAnim CameraAnim
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCameraAnim>(base.NativePtr / (IntPtr)sizeof(void*) + AMatineeActorCameraAnim.__PropertyOffset_CameraAnim);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AMatineeActorCameraAnim.__PropertyOffset_CameraAnim, value);
			}
		}

		// Token: 0x0600C9AC RID: 51628 RVA: 0x00125AB4 File Offset: 0x00123CB4
		static AMatineeActorCameraAnim()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MatineeActorCameraAnim");
		}

		// Token: 0x0600C9AD RID: 51629 RVA: 0x00125AC2 File Offset: 0x00123CC2
		protected AMatineeActorCameraAnim(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006C8C RID: 27788
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MatineeActorCameraAnim";

		// Token: 0x04006C8D RID: 27789
		private static IntPtr _ClassPtr;

		// Token: 0x04006C8E RID: 27790
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04006C8F RID: 27791
		internal static int __PropertyOffset_CameraAnim;
	}
}
