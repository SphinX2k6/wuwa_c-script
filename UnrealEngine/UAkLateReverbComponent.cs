using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000215 RID: 533
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AkAudio.AkLateReverbComponent")]
	[UnrealStructLayout(784, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 784)]
	public class UAkLateReverbComponent : USceneComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001FA5 RID: 8101 RVA: 0x0002ED8B File Offset: 0x0002CF8B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAkLateReverbComponent._ClassPtr;
		}

		// Token: 0x06001FA6 RID: 8102 RVA: 0x0002ED98 File Offset: 0x0002CF98
		public UAkLateReverbComponent() : this(BuiltinUtils.AllocNativeUObject(UAkLateReverbComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001FA7 RID: 8103 RVA: 0x0002EDC0 File Offset: 0x0002CFC0
		[NullableContext(1)]
		public UAkLateReverbComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAkLateReverbComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170007BD RID: 1981
		// (get) Token: 0x06001FA8 RID: 8104 RVA: 0x0002EDF3 File Offset: 0x0002CFF3
		// (set) Token: 0x06001FA9 RID: 8105 RVA: 0x0002EE03 File Offset: 0x0002D003
		public unsafe bool bEnable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAkLateReverbComponent.__PropertyOffset_bEnable) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAkLateReverbComponent.__PropertyOffset_bEnable) = (value ? 1 : 0);
			}
		}

		// Token: 0x170007BE RID: 1982
		// (get) Token: 0x06001FAA RID: 8106 RVA: 0x0002EE14 File Offset: 0x0002D014
		// (set) Token: 0x06001FAB RID: 8107 RVA: 0x0002EE24 File Offset: 0x0002D024
		public unsafe float SendLevel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAkLateReverbComponent.__PropertyOffset_SendLevel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAkLateReverbComponent.__PropertyOffset_SendLevel) = value;
			}
		}

		// Token: 0x170007BF RID: 1983
		// (get) Token: 0x06001FAC RID: 8108 RVA: 0x0002EE35 File Offset: 0x0002D035
		// (set) Token: 0x06001FAD RID: 8109 RVA: 0x0002EE45 File Offset: 0x0002D045
		public unsafe float FadeRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAkLateReverbComponent.__PropertyOffset_FadeRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAkLateReverbComponent.__PropertyOffset_FadeRate) = value;
			}
		}

		// Token: 0x170007C0 RID: 1984
		// (get) Token: 0x06001FAE RID: 8110 RVA: 0x0002EE56 File Offset: 0x0002D056
		// (set) Token: 0x06001FAF RID: 8111 RVA: 0x0002EE66 File Offset: 0x0002D066
		public unsafe float Priority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAkLateReverbComponent.__PropertyOffset_Priority);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAkLateReverbComponent.__PropertyOffset_Priority) = value;
			}
		}

		// Token: 0x170007C1 RID: 1985
		// (get) Token: 0x06001FB0 RID: 8112 RVA: 0x0002EE77 File Offset: 0x0002D077
		// (set) Token: 0x06001FB1 RID: 8113 RVA: 0x0002EE87 File Offset: 0x0002D087
		public unsafe bool AutoAssignAuxBus
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAkLateReverbComponent.__PropertyOffset_AutoAssignAuxBus) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAkLateReverbComponent.__PropertyOffset_AutoAssignAuxBus) = (value ? 1 : 0);
			}
		}

		// Token: 0x170007C2 RID: 1986
		// (get) Token: 0x06001FB2 RID: 8114 RVA: 0x0002EE98 File Offset: 0x0002D098
		// (set) Token: 0x06001FB3 RID: 8115 RVA: 0x0002EEAC File Offset: 0x0002D0AC
		public unsafe UAkAuxBus AuxBus
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkAuxBus>(base.NativePtr / (IntPtr)sizeof(void*) + UAkLateReverbComponent.__PropertyOffset_AuxBus);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UAkLateReverbComponent.__PropertyOffset_AuxBus, value);
			}
		}

		// Token: 0x170007C3 RID: 1987
		// (get) Token: 0x06001FB4 RID: 8116 RVA: 0x0002EEC1 File Offset: 0x0002D0C1
		// (set) Token: 0x06001FB5 RID: 8117 RVA: 0x0002EED5 File Offset: 0x0002D0D5
		[Nullable(1)]
		public unsafe string AuxBusName
		{
			[NullableContext(1)]
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UAkLateReverbComponent.__PropertyOffset_AuxBusName)));
			}
			[NullableContext(1)]
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UAkLateReverbComponent.__PropertyOffset_AuxBusName)), value);
			}
		}

		// Token: 0x170007C4 RID: 1988
		// (get) Token: 0x06001FB6 RID: 8118 RVA: 0x0002EEEA File Offset: 0x0002D0EA
		// (set) Token: 0x06001FB7 RID: 8119 RVA: 0x0002EEFE File Offset: 0x0002D0FE
		public unsafe UAkAuxBus AuxBusManual
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkAuxBus>(base.NativePtr / (IntPtr)sizeof(void*) + UAkLateReverbComponent.__PropertyOffset_AuxBusManual);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UAkLateReverbComponent.__PropertyOffset_AuxBusManual, value);
			}
		}

		// Token: 0x06001FB8 RID: 8120 RVA: 0x0002EF13 File Offset: 0x0002D113
		public void AssociateAkTextureSetComponent(UAkAcousticTextureSetComponent textureSetComponent)
		{
			UAkLateReverbComponent.__AssociateAkTextureSetComponent_Internal(base.NativePtr, (textureSetComponent != null) ? textureSetComponent.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06001FB9 RID: 8121
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AssociateAkTextureSetComponent_Internal(IntPtr @this, IntPtr textureSetComponent);

		// Token: 0x06001FBA RID: 8122 RVA: 0x0002EF30 File Offset: 0x0002D130
		static UAkLateReverbComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AkAudio.AkLateReverbComponent");
		}

		// Token: 0x06001FBB RID: 8123 RVA: 0x0002EF3E File Offset: 0x0002D13E
		protected UAkLateReverbComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000A7B RID: 2683
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AkAudio.AkLateReverbComponent";

		// Token: 0x04000A7C RID: 2684
		private static IntPtr _ClassPtr;

		// Token: 0x04000A7D RID: 2685
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000A7E RID: 2686
		internal static int __PropertyOffset_bEnable;

		// Token: 0x04000A7F RID: 2687
		internal static int __PropertyOffset_SendLevel;

		// Token: 0x04000A80 RID: 2688
		internal static int __PropertyOffset_FadeRate;

		// Token: 0x04000A81 RID: 2689
		internal static int __PropertyOffset_Priority;

		// Token: 0x04000A82 RID: 2690
		internal static int __PropertyOffset_AutoAssignAuxBus;

		// Token: 0x04000A83 RID: 2691
		internal static int __PropertyOffset_AuxBus;

		// Token: 0x04000A84 RID: 2692
		internal static int __PropertyOffset_AuxBusName;

		// Token: 0x04000A85 RID: 2693
		internal static int __PropertyOffset_AuxBusManual;
	}
}
