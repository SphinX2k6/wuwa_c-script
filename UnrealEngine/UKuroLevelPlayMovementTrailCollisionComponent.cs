using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020018EE RID: 6382
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplay.KuroLevelPlayMovementTrailCollisionComponent")]
	[UnrealStructLayout(320, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 320)]
	public class UKuroLevelPlayMovementTrailCollisionComponent : UActorComponent, IUnrealUObject, IUnrealObject, IKuroWaterDetectedReceiverInterface, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06017AB1 RID: 96945 RVA: 0x0022AFCD File Offset: 0x002291CD
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroLevelPlayMovementTrailCollisionComponent._ClassPtr;
		}

		// Token: 0x06017AB2 RID: 96946 RVA: 0x0022AFD9 File Offset: 0x002291D9
		int IKuroWaterDetectedReceiverInterface.InterfaceOffset()
		{
			return UKuroLevelPlayMovementTrailCollisionComponent.__InterfaceOffset_IKuroWaterDetectedReceiverInterface;
		}

		// Token: 0x06017AB3 RID: 96947 RVA: 0x0022AFE0 File Offset: 0x002291E0
		public UKuroLevelPlayMovementTrailCollisionComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroLevelPlayMovementTrailCollisionComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06017AB4 RID: 96948 RVA: 0x0022B008 File Offset: 0x00229208
		[NullableContext(1)]
		public UKuroLevelPlayMovementTrailCollisionComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroLevelPlayMovementTrailCollisionComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005F5B RID: 24411
		// (get) Token: 0x06017AB5 RID: 96949 RVA: 0x0022B03B File Offset: 0x0022923B
		// (set) Token: 0x06017AB6 RID: 96950 RVA: 0x0022B04F File Offset: 0x0022924F
		public unsafe UKuroTrailCollisionAsset KuroTrailCollisionAsset
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroTrailCollisionAsset>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroLevelPlayMovementTrailCollisionComponent.__PropertyOffset_KuroTrailCollisionAsset);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroLevelPlayMovementTrailCollisionComponent.__PropertyOffset_KuroTrailCollisionAsset, value);
			}
		}

		// Token: 0x17005F5C RID: 24412
		// (get) Token: 0x06017AB7 RID: 96951 RVA: 0x0022B064 File Offset: 0x00229264
		// (set) Token: 0x06017AB8 RID: 96952 RVA: 0x0022B078 File Offset: 0x00229278
		public unsafe AActor Invoker
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroLevelPlayMovementTrailCollisionComponent.__PropertyOffset_Invoker);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroLevelPlayMovementTrailCollisionComponent.__PropertyOffset_Invoker, value);
			}
		}

		// Token: 0x17005F5D RID: 24413
		// (get) Token: 0x06017AB9 RID: 96953 RVA: 0x0022B08D File Offset: 0x0022928D
		// (set) Token: 0x06017ABA RID: 96954 RVA: 0x0022B09D File Offset: 0x0022929D
		public unsafe bool bIgnoreInvoker
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroLevelPlayMovementTrailCollisionComponent.__PropertyOffset_bIgnoreInvoker) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroLevelPlayMovementTrailCollisionComponent.__PropertyOffset_bIgnoreInvoker) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005F5E RID: 24414
		// (get) Token: 0x06017ABB RID: 96955 RVA: 0x0022B0AE File Offset: 0x002292AE
		// (set) Token: 0x06017ABC RID: 96956 RVA: 0x0022B0C2 File Offset: 0x002292C2
		public unsafe USceneComponent TrailRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroLevelPlayMovementTrailCollisionComponent.__PropertyOffset_TrailRoot);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroLevelPlayMovementTrailCollisionComponent.__PropertyOffset_TrailRoot, value);
			}
		}

		// Token: 0x17005F5F RID: 24415
		// (get) Token: 0x06017ABD RID: 96957 RVA: 0x0022B0D8 File Offset: 0x002292D8
		// (set) Token: 0x06017ABE RID: 96958 RVA: 0x0022B111 File Offset: 0x00229311
		[Nullable(1)]
		public TArray<FTrailSegment> Segments
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FTrailSegment> result;
				if ((result = this._Segments) == null)
				{
					result = (this._Segments = new TArray<FTrailSegment>(base.NativePtr + (IntPtr)UKuroLevelPlayMovementTrailCollisionComponent.__PropertyOffset_Segments, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.Segments.CopyAssign(value);
			}
		}

		// Token: 0x17005F60 RID: 24416
		// (get) Token: 0x06017ABF RID: 96959 RVA: 0x0022B11F File Offset: 0x0022931F
		// (set) Token: 0x06017AC0 RID: 96960 RVA: 0x0022B133 File Offset: 0x00229333
		public unsafe UBoxComponent CurrentDetectedBox
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBoxComponent>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroLevelPlayMovementTrailCollisionComponent.__PropertyOffset_CurrentDetectedBox);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroLevelPlayMovementTrailCollisionComponent.__PropertyOffset_CurrentDetectedBox, value);
			}
		}

		// Token: 0x06017AC1 RID: 96961 RVA: 0x0022B148 File Offset: 0x00229348
		public void ResetTrail()
		{
			UKuroLevelPlayMovementTrailCollisionComponent.__ResetTrail_Internal(base.NativePtr);
		}

		// Token: 0x06017AC2 RID: 96962
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetTrail_Internal(IntPtr @this);

		// Token: 0x06017AC3 RID: 96963 RVA: 0x0022B155 File Offset: 0x00229355
		static UKuroLevelPlayMovementTrailCollisionComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.KuroLevelPlayMovementTrailCollisionComponent");
		}

		// Token: 0x06017AC4 RID: 96964 RVA: 0x0022B163 File Offset: 0x00229363
		protected UKuroLevelPlayMovementTrailCollisionComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400CDA5 RID: 52645
		internal static int __InterfaceOffset_IKuroWaterDetectedReceiverInterface;

		// Token: 0x0400CDA6 RID: 52646
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameplay.KuroLevelPlayMovementTrailCollisionComponent";

		// Token: 0x0400CDA7 RID: 52647
		private static IntPtr _ClassPtr;

		// Token: 0x0400CDA8 RID: 52648
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400CDA9 RID: 52649
		internal static int __PropertyOffset_KuroTrailCollisionAsset;

		// Token: 0x0400CDAA RID: 52650
		internal static int __PropertyOffset_Invoker;

		// Token: 0x0400CDAB RID: 52651
		internal static int __PropertyOffset_bIgnoreInvoker;

		// Token: 0x0400CDAC RID: 52652
		internal static int __PropertyOffset_TrailRoot;

		// Token: 0x0400CDAD RID: 52653
		internal static int __PropertyOffset_Segments;

		// Token: 0x0400CDAE RID: 52654
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FTrailSegment> _Segments;

		// Token: 0x0400CDAF RID: 52655
		internal static int __PropertyOffset_CurrentDetectedBox;
	}
}
