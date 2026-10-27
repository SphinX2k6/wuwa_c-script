using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001756 RID: 5974
	[UnrealObjectPath("/Script/KuroComponent.GpuNpcDitherComponent")]
	[UnrealStructLayout(416, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 416)]
	public class UGpuNpcDitherComponent : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601576D RID: 87917 RVA: 0x001F8B1A File Offset: 0x001F6D1A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGpuNpcDitherComponent._ClassPtr;
		}

		// Token: 0x0601576E RID: 87918 RVA: 0x001F8B28 File Offset: 0x001F6D28
		public UGpuNpcDitherComponent() : this(BuiltinUtils.AllocNativeUObject(UGpuNpcDitherComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601576F RID: 87919 RVA: 0x001F8B50 File Offset: 0x001F6D50
		[NullableContext(1)]
		public UGpuNpcDitherComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGpuNpcDitherComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170054BA RID: 21690
		// (get) Token: 0x06015770 RID: 87920 RVA: 0x001F8B83 File Offset: 0x001F6D83
		// (set) Token: 0x06015771 RID: 87921 RVA: 0x001F8B97 File Offset: 0x001F6D97
		public unsafe FName DitherCollisionTagName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGpuNpcDitherComponent.__PropertyOffset_DitherCollisionTagName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGpuNpcDitherComponent.__PropertyOffset_DitherCollisionTagName) = value;
			}
		}

		// Token: 0x170054BB RID: 21691
		// (get) Token: 0x06015772 RID: 87922 RVA: 0x001F8BAC File Offset: 0x001F6DAC
		// (set) Token: 0x06015773 RID: 87923 RVA: 0x001F8BBC File Offset: 0x001F6DBC
		public unsafe float GpuNpcCollisionRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGpuNpcDitherComponent.__PropertyOffset_GpuNpcCollisionRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGpuNpcDitherComponent.__PropertyOffset_GpuNpcCollisionRadius) = value;
			}
		}

		// Token: 0x170054BC RID: 21692
		// (get) Token: 0x06015774 RID: 87924 RVA: 0x001F8BCD File Offset: 0x001F6DCD
		// (set) Token: 0x06015775 RID: 87925 RVA: 0x001F8BDD File Offset: 0x001F6DDD
		public unsafe float GpuNpcCollisionHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGpuNpcDitherComponent.__PropertyOffset_GpuNpcCollisionHeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGpuNpcDitherComponent.__PropertyOffset_GpuNpcCollisionHeight) = value;
			}
		}

		// Token: 0x170054BD RID: 21693
		// (get) Token: 0x06015776 RID: 87926 RVA: 0x001F8BEE File Offset: 0x001F6DEE
		// (set) Token: 0x06015777 RID: 87927 RVA: 0x001F8BFE File Offset: 0x001F6DFE
		public unsafe float ExtraOverlapCheckDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGpuNpcDitherComponent.__PropertyOffset_ExtraOverlapCheckDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGpuNpcDitherComponent.__PropertyOffset_ExtraOverlapCheckDistance) = value;
			}
		}

		// Token: 0x170054BE RID: 21694
		// (get) Token: 0x06015778 RID: 87928 RVA: 0x001F8C0F File Offset: 0x001F6E0F
		// (set) Token: 0x06015779 RID: 87929 RVA: 0x001F8C1F File Offset: 0x001F6E1F
		public unsafe float DitherExp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGpuNpcDitherComponent.__PropertyOffset_DitherExp);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGpuNpcDitherComponent.__PropertyOffset_DitherExp) = value;
			}
		}

		// Token: 0x170054BF RID: 21695
		// (get) Token: 0x0601577A RID: 87930 RVA: 0x001F8C30 File Offset: 0x001F6E30
		// (set) Token: 0x0601577B RID: 87931 RVA: 0x001F8C40 File Offset: 0x001F6E40
		public unsafe float MaxTickInterval
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGpuNpcDitherComponent.__PropertyOffset_MaxTickInterval);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGpuNpcDitherComponent.__PropertyOffset_MaxTickInterval) = value;
			}
		}

		// Token: 0x170054C0 RID: 21696
		// (get) Token: 0x0601577C RID: 87932 RVA: 0x001F8C51 File Offset: 0x001F6E51
		// (set) Token: 0x0601577D RID: 87933 RVA: 0x001F8C61 File Offset: 0x001F6E61
		public unsafe float MinTickIntervalDist
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGpuNpcDitherComponent.__PropertyOffset_MinTickIntervalDist);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGpuNpcDitherComponent.__PropertyOffset_MinTickIntervalDist) = value;
			}
		}

		// Token: 0x170054C1 RID: 21697
		// (get) Token: 0x0601577E RID: 87934 RVA: 0x001F8C72 File Offset: 0x001F6E72
		// (set) Token: 0x0601577F RID: 87935 RVA: 0x001F8C82 File Offset: 0x001F6E82
		public unsafe float MaxTickIntervalDist
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGpuNpcDitherComponent.__PropertyOffset_MaxTickIntervalDist);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGpuNpcDitherComponent.__PropertyOffset_MaxTickIntervalDist) = value;
			}
		}

		// Token: 0x170054C2 RID: 21698
		// (get) Token: 0x06015780 RID: 87936 RVA: 0x001F8C93 File Offset: 0x001F6E93
		// (set) Token: 0x06015781 RID: 87937 RVA: 0x001F8CA7 File Offset: 0x001F6EA7
		[Nullable(2)]
		public unsafe ACharacter WatchingCharacter
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ACharacter>(base.NativePtr / (IntPtr)sizeof(void*) + UGpuNpcDitherComponent.__PropertyOffset_WatchingCharacter);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UGpuNpcDitherComponent.__PropertyOffset_WatchingCharacter, value);
			}
		}

		// Token: 0x170054C3 RID: 21699
		// (get) Token: 0x06015782 RID: 87938 RVA: 0x001F8CBC File Offset: 0x001F6EBC
		// (set) Token: 0x06015783 RID: 87939 RVA: 0x001F8CD0 File Offset: 0x001F6ED0
		public unsafe FVector Gravity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGpuNpcDitherComponent.__PropertyOffset_Gravity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGpuNpcDitherComponent.__PropertyOffset_Gravity) = value;
			}
		}

		// Token: 0x170054C4 RID: 21700
		// (get) Token: 0x06015784 RID: 87940 RVA: 0x001F8CE5 File Offset: 0x001F6EE5
		// (set) Token: 0x06015785 RID: 87941 RVA: 0x001F8CF5 File Offset: 0x001F6EF5
		public unsafe int NumCustomData
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGpuNpcDitherComponent.__PropertyOffset_NumCustomData);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGpuNpcDitherComponent.__PropertyOffset_NumCustomData) = value;
			}
		}

		// Token: 0x06015786 RID: 87942 RVA: 0x001F8D06 File Offset: 0x001F6F06
		public void ResetDitherForAllInstance(float Value)
		{
			UGpuNpcDitherComponent.__ResetDitherForAllInstance_Internal(base.NativePtr, Value);
		}

		// Token: 0x06015787 RID: 87943
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetDitherForAllInstance_Internal(IntPtr @this, float Value);

		// Token: 0x06015788 RID: 87944 RVA: 0x001F8D14 File Offset: 0x001F6F14
		static UGpuNpcDitherComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroComponent.GpuNpcDitherComponent");
		}

		// Token: 0x06015789 RID: 87945 RVA: 0x001F8D22 File Offset: 0x001F6F22
		protected UGpuNpcDitherComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400BB5E RID: 47966
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroComponent.GpuNpcDitherComponent";

		// Token: 0x0400BB5F RID: 47967
		private static IntPtr _ClassPtr;

		// Token: 0x0400BB60 RID: 47968
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400BB61 RID: 47969
		internal static int __PropertyOffset_DitherCollisionTagName;

		// Token: 0x0400BB62 RID: 47970
		internal static int __PropertyOffset_GpuNpcCollisionRadius;

		// Token: 0x0400BB63 RID: 47971
		internal static int __PropertyOffset_GpuNpcCollisionHeight;

		// Token: 0x0400BB64 RID: 47972
		internal static int __PropertyOffset_ExtraOverlapCheckDistance;

		// Token: 0x0400BB65 RID: 47973
		internal static int __PropertyOffset_DitherExp;

		// Token: 0x0400BB66 RID: 47974
		internal static int __PropertyOffset_MaxTickInterval;

		// Token: 0x0400BB67 RID: 47975
		internal static int __PropertyOffset_MinTickIntervalDist;

		// Token: 0x0400BB68 RID: 47976
		internal static int __PropertyOffset_MaxTickIntervalDist;

		// Token: 0x0400BB69 RID: 47977
		internal static int __PropertyOffset_WatchingCharacter;

		// Token: 0x0400BB6A RID: 47978
		internal static int __PropertyOffset_Gravity;

		// Token: 0x0400BB6B RID: 47979
		internal static int __PropertyOffset_NumCustomData;
	}
}
