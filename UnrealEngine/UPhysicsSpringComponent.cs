using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000FE7 RID: 4071
	[UnrealObjectPath("/Script/Engine.PhysicsSpringComponent")]
	[UnrealStructLayout(608, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 608)]
	public class UPhysicsSpringComponent : USceneComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600DC7A RID: 56442 RVA: 0x00144929 File Offset: 0x00142B29
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UPhysicsSpringComponent._ClassPtr;
		}

		// Token: 0x0600DC7B RID: 56443 RVA: 0x00144938 File Offset: 0x00142B38
		public UPhysicsSpringComponent() : this(BuiltinUtils.AllocNativeUObject(UPhysicsSpringComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600DC7C RID: 56444 RVA: 0x00144960 File Offset: 0x00142B60
		[NullableContext(1)]
		public UPhysicsSpringComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UPhysicsSpringComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170033F8 RID: 13304
		// (get) Token: 0x0600DC7D RID: 56445 RVA: 0x00144993 File Offset: 0x00142B93
		// (set) Token: 0x0600DC7E RID: 56446 RVA: 0x001449A3 File Offset: 0x00142BA3
		public unsafe float SpringStiffness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPhysicsSpringComponent.__PropertyOffset_SpringStiffness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPhysicsSpringComponent.__PropertyOffset_SpringStiffness) = value;
			}
		}

		// Token: 0x170033F9 RID: 13305
		// (get) Token: 0x0600DC7F RID: 56447 RVA: 0x001449B4 File Offset: 0x00142BB4
		// (set) Token: 0x0600DC80 RID: 56448 RVA: 0x001449C4 File Offset: 0x00142BC4
		public unsafe float SpringDamping
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPhysicsSpringComponent.__PropertyOffset_SpringDamping);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPhysicsSpringComponent.__PropertyOffset_SpringDamping) = value;
			}
		}

		// Token: 0x170033FA RID: 13306
		// (get) Token: 0x0600DC81 RID: 56449 RVA: 0x001449D5 File Offset: 0x00142BD5
		// (set) Token: 0x0600DC82 RID: 56450 RVA: 0x001449E5 File Offset: 0x00142BE5
		public unsafe float SpringLengthAtRest
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPhysicsSpringComponent.__PropertyOffset_SpringLengthAtRest);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPhysicsSpringComponent.__PropertyOffset_SpringLengthAtRest) = value;
			}
		}

		// Token: 0x170033FB RID: 13307
		// (get) Token: 0x0600DC83 RID: 56451 RVA: 0x001449F6 File Offset: 0x00142BF6
		// (set) Token: 0x0600DC84 RID: 56452 RVA: 0x00144A06 File Offset: 0x00142C06
		public unsafe float SpringRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPhysicsSpringComponent.__PropertyOffset_SpringRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPhysicsSpringComponent.__PropertyOffset_SpringRadius) = value;
			}
		}

		// Token: 0x170033FC RID: 13308
		// (get) Token: 0x0600DC85 RID: 56453 RVA: 0x00144A17 File Offset: 0x00142C17
		// (set) Token: 0x0600DC86 RID: 56454 RVA: 0x00144A2B File Offset: 0x00142C2B
		public unsafe TEnumAsByte<ECollisionChannel> SpringChannel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPhysicsSpringComponent.__PropertyOffset_SpringChannel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPhysicsSpringComponent.__PropertyOffset_SpringChannel) = value;
			}
		}

		// Token: 0x170033FD RID: 13309
		// (get) Token: 0x0600DC87 RID: 56455 RVA: 0x00144A40 File Offset: 0x00142C40
		// (set) Token: 0x0600DC88 RID: 56456 RVA: 0x00144A50 File Offset: 0x00142C50
		public unsafe bool bIgnoreSelf
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPhysicsSpringComponent.__PropertyOffset_bIgnoreSelf) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPhysicsSpringComponent.__PropertyOffset_bIgnoreSelf) = (value ? 1 : 0);
			}
		}

		// Token: 0x170033FE RID: 13310
		// (get) Token: 0x0600DC89 RID: 56457 RVA: 0x00144A61 File Offset: 0x00142C61
		// (set) Token: 0x0600DC8A RID: 56458 RVA: 0x00144A71 File Offset: 0x00142C71
		public unsafe float SpringCompression
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPhysicsSpringComponent.__PropertyOffset_SpringCompression);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPhysicsSpringComponent.__PropertyOffset_SpringCompression) = value;
			}
		}

		// Token: 0x0600DC8B RID: 56459 RVA: 0x00144A82 File Offset: 0x00142C82
		public FVector GetSpringRestingPoint()
		{
			return UPhysicsSpringComponent.__GetSpringRestingPoint_Internal(base.NativePtr);
		}

		// Token: 0x0600DC8C RID: 56460 RVA: 0x00144A8F File Offset: 0x00142C8F
		public FVector GetSpringDirection()
		{
			return UPhysicsSpringComponent.__GetSpringDirection_Internal(base.NativePtr);
		}

		// Token: 0x0600DC8D RID: 56461 RVA: 0x00144A9C File Offset: 0x00142C9C
		public FVector GetSpringCurrentEndPoint()
		{
			return UPhysicsSpringComponent.__GetSpringCurrentEndPoint_Internal(base.NativePtr);
		}

		// Token: 0x0600DC8E RID: 56462 RVA: 0x00144AA9 File Offset: 0x00142CA9
		public float GetNormalizedCompressionScalar()
		{
			return UPhysicsSpringComponent.__GetNormalizedCompressionScalar_Internal(base.NativePtr);
		}

		// Token: 0x0600DC8F RID: 56463
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetSpringRestingPoint_Internal(IntPtr @this);

		// Token: 0x0600DC90 RID: 56464
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetSpringDirection_Internal(IntPtr @this);

		// Token: 0x0600DC91 RID: 56465
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetSpringCurrentEndPoint_Internal(IntPtr @this);

		// Token: 0x0600DC92 RID: 56466
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetNormalizedCompressionScalar_Internal(IntPtr @this);

		// Token: 0x0600DC93 RID: 56467 RVA: 0x00144AB6 File Offset: 0x00142CB6
		static UPhysicsSpringComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.PhysicsSpringComponent");
		}

		// Token: 0x0600DC94 RID: 56468 RVA: 0x00144AC4 File Offset: 0x00142CC4
		protected UPhysicsSpringComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04007722 RID: 30498
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.PhysicsSpringComponent";

		// Token: 0x04007723 RID: 30499
		private static IntPtr _ClassPtr;

		// Token: 0x04007724 RID: 30500
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04007725 RID: 30501
		internal static int __PropertyOffset_SpringStiffness;

		// Token: 0x04007726 RID: 30502
		internal static int __PropertyOffset_SpringDamping;

		// Token: 0x04007727 RID: 30503
		internal static int __PropertyOffset_SpringLengthAtRest;

		// Token: 0x04007728 RID: 30504
		internal static int __PropertyOffset_SpringRadius;

		// Token: 0x04007729 RID: 30505
		internal static int __PropertyOffset_SpringChannel;

		// Token: 0x0400772A RID: 30506
		internal static int __PropertyOffset_bIgnoreSelf;

		// Token: 0x0400772B RID: 30507
		internal static int __PropertyOffset_SpringCompression;
	}
}
