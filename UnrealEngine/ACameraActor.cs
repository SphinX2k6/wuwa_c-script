using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000198 RID: 408
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.CameraActor")]
	[UnrealStructLayout(3728, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 3728)]
	public class ACameraActor : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001B5A RID: 7002 RVA: 0x00028BDB File Offset: 0x00026DDB
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ACameraActor._ClassPtr;
		}

		// Token: 0x06001B5B RID: 7003 RVA: 0x00028BE8 File Offset: 0x00026DE8
		public ACameraActor() : this(BuiltinUtils.AllocNativeUObject(ACameraActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001B5C RID: 7004 RVA: 0x00028C10 File Offset: 0x00026E10
		[NullableContext(1)]
		public ACameraActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ACameraActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000345 RID: 837
		// (get) Token: 0x06001B5D RID: 7005 RVA: 0x00028C43 File Offset: 0x00026E43
		// (set) Token: 0x06001B5E RID: 7006 RVA: 0x00028C57 File Offset: 0x00026E57
		public unsafe UCameraComponent CameraComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCameraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ACameraActor.__PropertyOffset_CameraComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ACameraActor.__PropertyOffset_CameraComponent, value);
			}
		}

		// Token: 0x17000346 RID: 838
		// (get) Token: 0x06001B5F RID: 7007 RVA: 0x00028C6C File Offset: 0x00026E6C
		// (set) Token: 0x06001B60 RID: 7008 RVA: 0x00028C80 File Offset: 0x00026E80
		public unsafe USceneComponent SceneComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ACameraActor.__PropertyOffset_SceneComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ACameraActor.__PropertyOffset_SceneComponent, value);
			}
		}

		// Token: 0x17000347 RID: 839
		// (get) Token: 0x06001B61 RID: 7009 RVA: 0x00028C95 File Offset: 0x00026E95
		// (set) Token: 0x06001B62 RID: 7010 RVA: 0x00028CAE File Offset: 0x00026EAE
		public unsafe bool bConstrainAspectRatio_DEPRECATED
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ACameraActor.__PropertyOffset_bConstrainAspectRatio_DEPRECATED) & ACameraActor.__PropertyMask_bConstrainAspectRatio_DEPRECATED) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ACameraActor.__PropertyOffset_bConstrainAspectRatio_DEPRECATED) = ((*(base.NativePtr + (IntPtr)ACameraActor.__PropertyOffset_bConstrainAspectRatio_DEPRECATED) & ~ACameraActor.__PropertyMask_bConstrainAspectRatio_DEPRECATED) | (value ? ACameraActor.__PropertyMask_bConstrainAspectRatio_DEPRECATED : 0));
			}
		}

		// Token: 0x17000348 RID: 840
		// (get) Token: 0x06001B63 RID: 7011 RVA: 0x00028CDE File Offset: 0x00026EDE
		// (set) Token: 0x06001B64 RID: 7012 RVA: 0x00028CEE File Offset: 0x00026EEE
		public unsafe float AspectRatio_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACameraActor.__PropertyOffset_AspectRatio_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACameraActor.__PropertyOffset_AspectRatio_DEPRECATED) = value;
			}
		}

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x06001B65 RID: 7013 RVA: 0x00028CFF File Offset: 0x00026EFF
		// (set) Token: 0x06001B66 RID: 7014 RVA: 0x00028D0F File Offset: 0x00026F0F
		public unsafe float FOVAngle_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACameraActor.__PropertyOffset_FOVAngle_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACameraActor.__PropertyOffset_FOVAngle_DEPRECATED) = value;
			}
		}

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x06001B67 RID: 7015 RVA: 0x00028D20 File Offset: 0x00026F20
		// (set) Token: 0x06001B68 RID: 7016 RVA: 0x00028D30 File Offset: 0x00026F30
		public unsafe float PostProcessBlendWeight_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACameraActor.__PropertyOffset_PostProcessBlendWeight_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACameraActor.__PropertyOffset_PostProcessBlendWeight_DEPRECATED) = value;
			}
		}

		// Token: 0x1700034B RID: 843
		// (get) Token: 0x06001B69 RID: 7017 RVA: 0x00028D44 File Offset: 0x00026F44
		// (set) Token: 0x06001B6A RID: 7018 RVA: 0x00028D7D File Offset: 0x00026F7D
		[Nullable(1)]
		public FPostProcessSettings PostProcessSettings_DEPRECATED
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FPostProcessSettings result;
				if ((result = this._PostProcessSettings_DEPRECATED) == null)
				{
					result = (this._PostProcessSettings_DEPRECATED = new FPostProcessSettings(base.NativePtr + (IntPtr)ACameraActor.__PropertyOffset_PostProcessSettings_DEPRECATED, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPostProcessSettings.StaticStruct(), base.NativePtr + (IntPtr)ACameraActor.__PropertyOffset_PostProcessSettings_DEPRECATED, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06001B6B RID: 7019 RVA: 0x00028D9E File Offset: 0x00026F9E
		public int GetAutoActivatePlayerIndex()
		{
			return ACameraActor.__GetAutoActivatePlayerIndex_Internal(base.NativePtr);
		}

		// Token: 0x06001B6C RID: 7020
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetAutoActivatePlayerIndex_Internal(IntPtr @this);

		// Token: 0x06001B6D RID: 7021 RVA: 0x00028DAB File Offset: 0x00026FAB
		static ACameraActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.CameraActor");
		}

		// Token: 0x06001B6E RID: 7022 RVA: 0x00028DB9 File Offset: 0x00026FB9
		protected ACameraActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040008D9 RID: 2265
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.CameraActor";

		// Token: 0x040008DA RID: 2266
		private static IntPtr _ClassPtr;

		// Token: 0x040008DB RID: 2267
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040008DC RID: 2268
		internal static int __PropertyOffset_CameraComponent;

		// Token: 0x040008DD RID: 2269
		internal static int __PropertyOffset_SceneComponent;

		// Token: 0x040008DE RID: 2270
		internal static int __PropertyOffset_bConstrainAspectRatio_DEPRECATED;

		// Token: 0x040008DF RID: 2271
		internal static byte __PropertyMask_bConstrainAspectRatio_DEPRECATED;

		// Token: 0x040008E0 RID: 2272
		internal static int __PropertyOffset_AspectRatio_DEPRECATED;

		// Token: 0x040008E1 RID: 2273
		internal static int __PropertyOffset_FOVAngle_DEPRECATED;

		// Token: 0x040008E2 RID: 2274
		internal static int __PropertyOffset_PostProcessBlendWeight_DEPRECATED;

		// Token: 0x040008E3 RID: 2275
		internal static int __PropertyOffset_PostProcessSettings_DEPRECATED;

		// Token: 0x040008E4 RID: 2276
		private FPostProcessSettings _PostProcessSettings_DEPRECATED;
	}
}
