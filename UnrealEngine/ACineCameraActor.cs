using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000477 RID: 1143
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/CinematicCamera.CineCameraActor")]
	[UnrealStructLayout(3792, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 3792)]
	public class ACineCameraActor : ACameraActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06003D34 RID: 15668 RVA: 0x0005C0C4 File Offset: 0x0005A2C4
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ACineCameraActor._ClassPtr;
		}

		// Token: 0x06003D35 RID: 15669 RVA: 0x0005C0D0 File Offset: 0x0005A2D0
		public ACineCameraActor() : this(BuiltinUtils.AllocNativeUObject(ACineCameraActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06003D36 RID: 15670 RVA: 0x0005C0F8 File Offset: 0x0005A2F8
		public ACineCameraActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ACineCameraActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000EDE RID: 3806
		// (get) Token: 0x06003D37 RID: 15671 RVA: 0x0005C12C File Offset: 0x0005A32C
		// (set) Token: 0x06003D38 RID: 15672 RVA: 0x0005C165 File Offset: 0x0005A365
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

		// Token: 0x06003D39 RID: 15673 RVA: 0x0005C186 File Offset: 0x0005A386
		[NullableContext(2)]
		public UCineCameraComponent GetCineCameraComponent()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UCineCameraComponent>(ACineCameraActor.__GetCineCameraComponent_Internal(base.NativePtr));
		}

		// Token: 0x06003D3A RID: 15674
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetCineCameraComponent_Internal(IntPtr @this);

		// Token: 0x06003D3B RID: 15675 RVA: 0x0005C198 File Offset: 0x0005A398
		static ACineCameraActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CinematicCamera.CineCameraActor");
		}

		// Token: 0x06003D3C RID: 15676 RVA: 0x0005C1A6 File Offset: 0x0005A3A6
		protected ACineCameraActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001CB4 RID: 7348
		public new const string __ObjectPath = "/Script/CinematicCamera.CineCameraActor";

		// Token: 0x04001CB5 RID: 7349
		private static IntPtr _ClassPtr;

		// Token: 0x04001CB6 RID: 7350
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04001CB7 RID: 7351
		internal static int __PropertyOffset_LookatTrackingSettings;

		// Token: 0x04001CB8 RID: 7352
		[Nullable(2)]
		private FCameraLookatTrackingSettings _LookatTrackingSettings;
	}
}
