using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200023C RID: 572
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AkAudio.AkRoomComponent")]
	[UnrealStructLayout(672, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 672)]
	public class UAkRoomComponent : UAkGameObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600215C RID: 8540 RVA: 0x000318E5 File Offset: 0x0002FAE5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAkRoomComponent._ClassPtr;
		}

		// Token: 0x0600215D RID: 8541 RVA: 0x000318F4 File Offset: 0x0002FAF4
		public UAkRoomComponent() : this(BuiltinUtils.AllocNativeUObject(UAkRoomComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600215E RID: 8542 RVA: 0x0003191C File Offset: 0x0002FB1C
		[NullableContext(1)]
		public UAkRoomComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAkRoomComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700080D RID: 2061
		// (get) Token: 0x0600215F RID: 8543 RVA: 0x0003194F File Offset: 0x0002FB4F
		// (set) Token: 0x06002160 RID: 8544 RVA: 0x0003195F File Offset: 0x0002FB5F
		public unsafe bool bEnable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAkRoomComponent.__PropertyOffset_bEnable) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAkRoomComponent.__PropertyOffset_bEnable) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700080E RID: 2062
		// (get) Token: 0x06002161 RID: 8545 RVA: 0x00031970 File Offset: 0x0002FB70
		// (set) Token: 0x06002162 RID: 8546 RVA: 0x00031980 File Offset: 0x0002FB80
		public unsafe bool bDynamic
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAkRoomComponent.__PropertyOffset_bDynamic) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAkRoomComponent.__PropertyOffset_bDynamic) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700080F RID: 2063
		// (get) Token: 0x06002163 RID: 8547 RVA: 0x00031991 File Offset: 0x0002FB91
		// (set) Token: 0x06002164 RID: 8548 RVA: 0x000319A1 File Offset: 0x0002FBA1
		public unsafe float Priority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAkRoomComponent.__PropertyOffset_Priority);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAkRoomComponent.__PropertyOffset_Priority) = value;
			}
		}

		// Token: 0x17000810 RID: 2064
		// (get) Token: 0x06002165 RID: 8549 RVA: 0x000319B2 File Offset: 0x0002FBB2
		// (set) Token: 0x06002166 RID: 8550 RVA: 0x000319C2 File Offset: 0x0002FBC2
		public unsafe float WallOcclusion
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAkRoomComponent.__PropertyOffset_WallOcclusion);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAkRoomComponent.__PropertyOffset_WallOcclusion) = value;
			}
		}

		// Token: 0x17000811 RID: 2065
		// (get) Token: 0x06002167 RID: 8551 RVA: 0x000319D3 File Offset: 0x0002FBD3
		// (set) Token: 0x06002168 RID: 8552 RVA: 0x000319E3 File Offset: 0x0002FBE3
		public unsafe float AuxSendLevel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAkRoomComponent.__PropertyOffset_AuxSendLevel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAkRoomComponent.__PropertyOffset_AuxSendLevel) = value;
			}
		}

		// Token: 0x17000812 RID: 2066
		// (get) Token: 0x06002169 RID: 8553 RVA: 0x000319F4 File Offset: 0x0002FBF4
		// (set) Token: 0x0600216A RID: 8554 RVA: 0x00031A04 File Offset: 0x0002FC04
		public unsafe bool AutoPost
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAkRoomComponent.__PropertyOffset_AutoPost) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAkRoomComponent.__PropertyOffset_AutoPost) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000813 RID: 2067
		// (get) Token: 0x0600216B RID: 8555 RVA: 0x00031A15 File Offset: 0x0002FC15
		// (set) Token: 0x0600216C RID: 8556 RVA: 0x00031A29 File Offset: 0x0002FC29
		public unsafe UAkAcousticTextureSetComponent GeometryComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkAcousticTextureSetComponent>(base.NativePtr / (IntPtr)sizeof(void*) + UAkRoomComponent.__PropertyOffset_GeometryComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UAkRoomComponent.__PropertyOffset_GeometryComponent, value);
			}
		}

		// Token: 0x0600216D RID: 8557 RVA: 0x00031A3E File Offset: 0x0002FC3E
		public void SetGeometryComponent(UAkAcousticTextureSetComponent textureSetComponent)
		{
			UAkRoomComponent.__SetGeometryComponent_Internal(base.NativePtr, (textureSetComponent != null) ? textureSetComponent.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600216E RID: 8558 RVA: 0x00031A5B File Offset: 0x0002FC5B
		public UPrimitiveComponent GetPrimitiveParent()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UPrimitiveComponent>(UAkRoomComponent.__GetPrimitiveParent_Internal(base.NativePtr));
		}

		// Token: 0x0600216F RID: 8559
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetGeometryComponent_Internal(IntPtr @this, IntPtr textureSetComponent);

		// Token: 0x06002170 RID: 8560
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetPrimitiveParent_Internal(IntPtr @this);

		// Token: 0x06002171 RID: 8561 RVA: 0x00031A6D File Offset: 0x0002FC6D
		static UAkRoomComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AkAudio.AkRoomComponent");
		}

		// Token: 0x06002172 RID: 8562 RVA: 0x00031A7B File Offset: 0x0002FC7B
		protected UAkRoomComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000B4C RID: 2892
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AkAudio.AkRoomComponent";

		// Token: 0x04000B4D RID: 2893
		private static IntPtr _ClassPtr;

		// Token: 0x04000B4E RID: 2894
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000B4F RID: 2895
		internal static int __PropertyOffset_bEnable;

		// Token: 0x04000B50 RID: 2896
		internal static int __PropertyOffset_bDynamic;

		// Token: 0x04000B51 RID: 2897
		internal static int __PropertyOffset_Priority;

		// Token: 0x04000B52 RID: 2898
		internal static int __PropertyOffset_WallOcclusion;

		// Token: 0x04000B53 RID: 2899
		internal static int __PropertyOffset_AuxSendLevel;

		// Token: 0x04000B54 RID: 2900
		internal static int __PropertyOffset_AutoPost;

		// Token: 0x04000B55 RID: 2901
		internal static int __PropertyOffset_GeometryComponent;
	}
}
