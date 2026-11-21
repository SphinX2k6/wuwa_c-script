using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020000E7 RID: 231
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/CinematicCamera.CineCameraActor")]
	[UnrealStructLayout(3840, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 3840)]
	public class ACineCameraActor : ACameraActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001028 RID: 4136 RVA: 0x00019CCB File Offset: 0x00017ECB
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ACineCameraActor._ClassPtr;
		}

		// Token: 0x06001029 RID: 4137 RVA: 0x00019CD8 File Offset: 0x00017ED8
		public ACineCameraActor() : this(BuiltinUtils.AllocNativeUObject(ACineCameraActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600102A RID: 4138 RVA: 0x00019D00 File Offset: 0x00017F00
		public ACineCameraActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ACineCameraActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x0600102B RID: 4139 RVA: 0x00019D34 File Offset: 0x00017F34
		// (set) Token: 0x0600102C RID: 4140 RVA: 0x00019D6D File Offset: 0x00017F6D
		public FCameraLookatTrackingSettings LookatTrackingSettings
		{
			get
			{
				base.FastCheckIsValid();
				FCameraLookatTrackingSettings result;
				if ((result = this._LookatTrackingSettings) == null)
				{
					result = (this._LookatTrackingSettings = new FCameraLookatTrackingSettings(base.NativePtr + (IntPtr)ACineCameraActor.__PropertyOffset_LookatTrackingSettings, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCameraLookatTrackingSettings.StaticStruct(), base.NativePtr + (IntPtr)ACineCameraActor.__PropertyOffset_LookatTrackingSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600102D RID: 4141 RVA: 0x00019D8E File Offset: 0x00017F8E
		[NullableContext(2)]
		public UCineCameraComponent GetCineCameraComponent()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UCineCameraComponent>(ACineCameraActor.__GetCineCameraComponent_Internal(base.NativePtr));
		}

		// Token: 0x0600102E RID: 4142
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetCineCameraComponent_Internal(IntPtr @this);

		// Token: 0x0600102F RID: 4143 RVA: 0x00019DA0 File Offset: 0x00017FA0
		static ACineCameraActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CinematicCamera.CineCameraActor");
		}

		// Token: 0x06001030 RID: 4144 RVA: 0x00019DAE File Offset: 0x00017FAE
		protected ACineCameraActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040003C5 RID: 965
		public new const string __ObjectPath = "/Script/CinematicCamera.CineCameraActor";

		// Token: 0x040003C6 RID: 966
		private static IntPtr _ClassPtr;

		// Token: 0x040003C7 RID: 967
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040003C8 RID: 968
		internal static int __PropertyOffset_LookatTrackingSettings;

		// Token: 0x040003C9 RID: 969
		[Nullable(2)]
		private FCameraLookatTrackingSettings _LookatTrackingSettings;
	}
}
