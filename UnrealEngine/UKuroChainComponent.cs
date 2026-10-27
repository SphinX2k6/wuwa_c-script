using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001759 RID: 5977
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroComponent.KuroChainComponent")]
	[UnrealStructLayout(1888, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1888)]
	public class UKuroChainComponent : UMeshComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060157B9 RID: 87993 RVA: 0x001F9148 File Offset: 0x001F7348
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroChainComponent._ClassPtr;
		}

		// Token: 0x060157BA RID: 87994 RVA: 0x001F9154 File Offset: 0x001F7354
		public UKuroChainComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroChainComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060157BB RID: 87995 RVA: 0x001F917C File Offset: 0x001F737C
		public UKuroChainComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroChainComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170054D5 RID: 21717
		// (get) Token: 0x060157BC RID: 87996 RVA: 0x001F91AF File Offset: 0x001F73AF
		// (set) Token: 0x060157BD RID: 87997 RVA: 0x001F91C3 File Offset: 0x001F73C3
		[Nullable(2)]
		public unsafe UStaticMesh ChainMesh
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroChainComponent.__PropertyOffset_ChainMesh);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroChainComponent.__PropertyOffset_ChainMesh, value);
			}
		}

		// Token: 0x170054D6 RID: 21718
		// (get) Token: 0x060157BE RID: 87998 RVA: 0x001F91D8 File Offset: 0x001F73D8
		// (set) Token: 0x060157BF RID: 87999 RVA: 0x001F91EC File Offset: 0x001F73EC
		public unsafe FVector Scale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroChainComponent.__PropertyOffset_Scale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroChainComponent.__PropertyOffset_Scale) = value;
			}
		}

		// Token: 0x170054D7 RID: 21719
		// (get) Token: 0x060157C0 RID: 88000 RVA: 0x001F9201 File Offset: 0x001F7401
		// (set) Token: 0x060157C1 RID: 88001 RVA: 0x001F9211 File Offset: 0x001F7411
		public unsafe int Segments
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroChainComponent.__PropertyOffset_Segments);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroChainComponent.__PropertyOffset_Segments) = value;
			}
		}

		// Token: 0x170054D8 RID: 21720
		// (get) Token: 0x060157C2 RID: 88002 RVA: 0x001F9222 File Offset: 0x001F7422
		// (set) Token: 0x060157C3 RID: 88003 RVA: 0x001F9236 File Offset: 0x001F7436
		public unsafe FVector AdditiveRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroChainComponent.__PropertyOffset_AdditiveRotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroChainComponent.__PropertyOffset_AdditiveRotation) = value;
			}
		}

		// Token: 0x170054D9 RID: 21721
		// (get) Token: 0x060157C4 RID: 88004 RVA: 0x001F924B File Offset: 0x001F744B
		// (set) Token: 0x060157C5 RID: 88005 RVA: 0x001F925B File Offset: 0x001F745B
		public unsafe float ChainLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroChainComponent.__PropertyOffset_ChainLength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroChainComponent.__PropertyOffset_ChainLength) = value;
			}
		}

		// Token: 0x170054DA RID: 21722
		// (get) Token: 0x060157C6 RID: 88006 RVA: 0x001F926C File Offset: 0x001F746C
		// (set) Token: 0x060157C7 RID: 88007 RVA: 0x001F9280 File Offset: 0x001F7480
		public unsafe FVector EndPoint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroChainComponent.__PropertyOffset_EndPoint);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroChainComponent.__PropertyOffset_EndPoint) = value;
			}
		}

		// Token: 0x170054DB RID: 21723
		// (get) Token: 0x060157C8 RID: 88008 RVA: 0x001F9295 File Offset: 0x001F7495
		// (set) Token: 0x060157C9 RID: 88009 RVA: 0x001F92A5 File Offset: 0x001F74A5
		public unsafe bool AttachStart
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroChainComponent.__PropertyOffset_AttachStart) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroChainComponent.__PropertyOffset_AttachStart) = (value ? 1 : 0);
			}
		}

		// Token: 0x170054DC RID: 21724
		// (get) Token: 0x060157CA RID: 88010 RVA: 0x001F92B8 File Offset: 0x001F74B8
		// (set) Token: 0x060157CB RID: 88011 RVA: 0x001F92F1 File Offset: 0x001F74F1
		public FComponentReference AttachStartTo
		{
			get
			{
				base.FastCheckIsValid();
				FComponentReference result;
				if ((result = this._AttachStartTo) == null)
				{
					result = (this._AttachStartTo = new FComponentReference(base.NativePtr + (IntPtr)UKuroChainComponent.__PropertyOffset_AttachStartTo, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FComponentReference.StaticStruct(), base.NativePtr + (IntPtr)UKuroChainComponent.__PropertyOffset_AttachStartTo, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170054DD RID: 21725
		// (get) Token: 0x060157CC RID: 88012 RVA: 0x001F9312 File Offset: 0x001F7512
		// (set) Token: 0x060157CD RID: 88013 RVA: 0x001F9326 File Offset: 0x001F7526
		public unsafe FName AttachStartToSocket
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroChainComponent.__PropertyOffset_AttachStartToSocket);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroChainComponent.__PropertyOffset_AttachStartToSocket) = value;
			}
		}

		// Token: 0x170054DE RID: 21726
		// (get) Token: 0x060157CE RID: 88014 RVA: 0x001F933B File Offset: 0x001F753B
		// (set) Token: 0x060157CF RID: 88015 RVA: 0x001F934B File Offset: 0x001F754B
		public unsafe bool AttachEnd
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroChainComponent.__PropertyOffset_AttachEnd) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroChainComponent.__PropertyOffset_AttachEnd) = (value ? 1 : 0);
			}
		}

		// Token: 0x170054DF RID: 21727
		// (get) Token: 0x060157D0 RID: 88016 RVA: 0x001F935C File Offset: 0x001F755C
		// (set) Token: 0x060157D1 RID: 88017 RVA: 0x001F9395 File Offset: 0x001F7595
		public FComponentReference AttachEndTo
		{
			get
			{
				base.FastCheckIsValid();
				FComponentReference result;
				if ((result = this._AttachEndTo) == null)
				{
					result = (this._AttachEndTo = new FComponentReference(base.NativePtr + (IntPtr)UKuroChainComponent.__PropertyOffset_AttachEndTo, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FComponentReference.StaticStruct(), base.NativePtr + (IntPtr)UKuroChainComponent.__PropertyOffset_AttachEndTo, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170054E0 RID: 21728
		// (get) Token: 0x060157D2 RID: 88018 RVA: 0x001F93B6 File Offset: 0x001F75B6
		// (set) Token: 0x060157D3 RID: 88019 RVA: 0x001F93CA File Offset: 0x001F75CA
		public unsafe FName AttachEndToSocket
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroChainComponent.__PropertyOffset_AttachEndToSocket);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroChainComponent.__PropertyOffset_AttachEndToSocket) = value;
			}
		}

		// Token: 0x170054E1 RID: 21729
		// (get) Token: 0x060157D4 RID: 88020 RVA: 0x001F93DF File Offset: 0x001F75DF
		// (set) Token: 0x060157D5 RID: 88021 RVA: 0x001F93EF File Offset: 0x001F75EF
		public unsafe float Gravity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroChainComponent.__PropertyOffset_Gravity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroChainComponent.__PropertyOffset_Gravity) = value;
			}
		}

		// Token: 0x170054E2 RID: 21730
		// (get) Token: 0x060157D6 RID: 88022 RVA: 0x001F9400 File Offset: 0x001F7600
		// (set) Token: 0x060157D7 RID: 88023 RVA: 0x001F9410 File Offset: 0x001F7610
		public unsafe int Stiffness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroChainComponent.__PropertyOffset_Stiffness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroChainComponent.__PropertyOffset_Stiffness) = value;
			}
		}

		// Token: 0x170054E3 RID: 21731
		// (get) Token: 0x060157D8 RID: 88024 RVA: 0x001F9421 File Offset: 0x001F7621
		// (set) Token: 0x060157D9 RID: 88025 RVA: 0x001F9431 File Offset: 0x001F7631
		public unsafe bool SelfCollision
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroChainComponent.__PropertyOffset_SelfCollision) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroChainComponent.__PropertyOffset_SelfCollision) = (value ? 1 : 0);
			}
		}

		// Token: 0x170054E4 RID: 21732
		// (get) Token: 0x060157DA RID: 88026 RVA: 0x001F9442 File Offset: 0x001F7642
		// (set) Token: 0x060157DB RID: 88027 RVA: 0x001F9452 File Offset: 0x001F7652
		public unsafe float SelfCollisionWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroChainComponent.__PropertyOffset_SelfCollisionWidth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroChainComponent.__PropertyOffset_SelfCollisionWidth) = value;
			}
		}

		// Token: 0x170054E5 RID: 21733
		// (get) Token: 0x060157DC RID: 88028 RVA: 0x001F9463 File Offset: 0x001F7663
		// (set) Token: 0x060157DD RID: 88029 RVA: 0x001F9473 File Offset: 0x001F7673
		public unsafe float SelfCollisionThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroChainComponent.__PropertyOffset_SelfCollisionThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroChainComponent.__PropertyOffset_SelfCollisionThreshold) = value;
			}
		}

		// Token: 0x170054E6 RID: 21734
		// (get) Token: 0x060157DE RID: 88030 RVA: 0x001F9484 File Offset: 0x001F7684
		// (set) Token: 0x060157DF RID: 88031 RVA: 0x001F9494 File Offset: 0x001F7694
		public unsafe int FrameSkip
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroChainComponent.__PropertyOffset_FrameSkip);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroChainComponent.__PropertyOffset_FrameSkip) = value;
			}
		}

		// Token: 0x170054E7 RID: 21735
		// (get) Token: 0x060157E0 RID: 88032 RVA: 0x001F94A5 File Offset: 0x001F76A5
		// (set) Token: 0x060157E1 RID: 88033 RVA: 0x001F94B9 File Offset: 0x001F76B9
		[Nullable(2)]
		public unsafe UInstancedStaticMeshComponent InstanceComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UInstancedStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroChainComponent.__PropertyOffset_InstanceComponent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroChainComponent.__PropertyOffset_InstanceComponent, value);
			}
		}

		// Token: 0x060157E2 RID: 88034 RVA: 0x001F94CE File Offset: 0x001F76CE
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void InitChain()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroChainComponent.__InitChain_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060157E3 RID: 88035 RVA: 0x001F94E3 File Offset: 0x001F76E3
		static UKuroChainComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroComponent.KuroChainComponent");
		}

		// Token: 0x060157E4 RID: 88036 RVA: 0x001F94F1 File Offset: 0x001F76F1
		protected UKuroChainComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400BB88 RID: 48008
		public new const string __ObjectPath = "/Script/KuroComponent.KuroChainComponent";

		// Token: 0x0400BB89 RID: 48009
		private static IntPtr _ClassPtr;

		// Token: 0x0400BB8A RID: 48010
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400BB8B RID: 48011
		internal static int __PropertyOffset_ChainMesh;

		// Token: 0x0400BB8C RID: 48012
		internal static int __PropertyOffset_Scale;

		// Token: 0x0400BB8D RID: 48013
		internal static int __PropertyOffset_Segments;

		// Token: 0x0400BB8E RID: 48014
		internal static int __PropertyOffset_AdditiveRotation;

		// Token: 0x0400BB8F RID: 48015
		internal static int __PropertyOffset_ChainLength;

		// Token: 0x0400BB90 RID: 48016
		internal static int __PropertyOffset_EndPoint;

		// Token: 0x0400BB91 RID: 48017
		internal static int __PropertyOffset_AttachStart;

		// Token: 0x0400BB92 RID: 48018
		internal static int __PropertyOffset_AttachStartTo;

		// Token: 0x0400BB93 RID: 48019
		[Nullable(2)]
		private FComponentReference _AttachStartTo;

		// Token: 0x0400BB94 RID: 48020
		internal static int __PropertyOffset_AttachStartToSocket;

		// Token: 0x0400BB95 RID: 48021
		internal static int __PropertyOffset_AttachEnd;

		// Token: 0x0400BB96 RID: 48022
		internal static int __PropertyOffset_AttachEndTo;

		// Token: 0x0400BB97 RID: 48023
		[Nullable(2)]
		private FComponentReference _AttachEndTo;

		// Token: 0x0400BB98 RID: 48024
		internal static int __PropertyOffset_AttachEndToSocket;

		// Token: 0x0400BB99 RID: 48025
		internal static int __PropertyOffset_Gravity;

		// Token: 0x0400BB9A RID: 48026
		internal static int __PropertyOffset_Stiffness;

		// Token: 0x0400BB9B RID: 48027
		internal static int __PropertyOffset_SelfCollision;

		// Token: 0x0400BB9C RID: 48028
		internal static int __PropertyOffset_SelfCollisionWidth;

		// Token: 0x0400BB9D RID: 48029
		internal static int __PropertyOffset_SelfCollisionThreshold;

		// Token: 0x0400BB9E RID: 48030
		internal static int __PropertyOffset_FrameSkip;

		// Token: 0x0400BB9F RID: 48031
		internal static int __PropertyOffset_InstanceComponent;

		// Token: 0x0400BBA0 RID: 48032
		private static IntPtr __InitChain_NativeFunctionPtr;
	}
}
