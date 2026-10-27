using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001915 RID: 6421
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplay.KuroStair")]
	[UnrealStructLayout(1872, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1872)]
	public class AKuroStair : AKuroBPActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06017D38 RID: 97592 RVA: 0x0022E553 File Offset: 0x0022C753
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroStair._ClassPtr;
		}

		// Token: 0x06017D39 RID: 97593 RVA: 0x0022E560 File Offset: 0x0022C760
		public AKuroStair() : this(BuiltinUtils.AllocNativeUObject(AKuroStair.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06017D3A RID: 97594 RVA: 0x0022E588 File Offset: 0x0022C788
		[NullableContext(1)]
		public AKuroStair(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroStair.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005FC8 RID: 24520
		// (get) Token: 0x06017D3B RID: 97595 RVA: 0x0022E5BB File Offset: 0x0022C7BB
		// (set) Token: 0x06017D3C RID: 97596 RVA: 0x0022E5CB File Offset: 0x0022C7CB
		public unsafe int StairCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroStair.__PropertyOffset_StairCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroStair.__PropertyOffset_StairCount) = value;
			}
		}

		// Token: 0x17005FC9 RID: 24521
		// (get) Token: 0x06017D3D RID: 97597 RVA: 0x0022E5DC File Offset: 0x0022C7DC
		// (set) Token: 0x06017D3E RID: 97598 RVA: 0x0022E5EC File Offset: 0x0022C7EC
		public unsafe int TailHorizontalStairCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroStair.__PropertyOffset_TailHorizontalStairCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroStair.__PropertyOffset_TailHorizontalStairCount) = value;
			}
		}

		// Token: 0x17005FCA RID: 24522
		// (get) Token: 0x06017D3F RID: 97599 RVA: 0x0022E5FD File Offset: 0x0022C7FD
		// (set) Token: 0x06017D40 RID: 97600 RVA: 0x0022E60D File Offset: 0x0022C80D
		public unsafe int HeadHorizontalStairCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroStair.__PropertyOffset_HeadHorizontalStairCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroStair.__PropertyOffset_HeadHorizontalStairCount) = value;
			}
		}

		// Token: 0x17005FCB RID: 24523
		// (get) Token: 0x06017D41 RID: 97601 RVA: 0x0022E61E File Offset: 0x0022C81E
		// (set) Token: 0x06017D42 RID: 97602 RVA: 0x0022E632 File Offset: 0x0022C832
		public unsafe FVector MoveDelta
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroStair.__PropertyOffset_MoveDelta);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroStair.__PropertyOffset_MoveDelta) = value;
			}
		}

		// Token: 0x17005FCC RID: 24524
		// (get) Token: 0x06017D43 RID: 97603 RVA: 0x0022E647 File Offset: 0x0022C847
		// (set) Token: 0x06017D44 RID: 97604 RVA: 0x0022E657 File Offset: 0x0022C857
		public unsafe float OneStairTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroStair.__PropertyOffset_OneStairTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroStair.__PropertyOffset_OneStairTime) = value;
			}
		}

		// Token: 0x17005FCD RID: 24525
		// (get) Token: 0x06017D45 RID: 97605 RVA: 0x0022E668 File Offset: 0x0022C868
		// (set) Token: 0x06017D46 RID: 97606 RVA: 0x0022E67C File Offset: 0x0022C87C
		public unsafe UStaticMesh StairMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroStair.__PropertyOffset_StairMesh);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroStair.__PropertyOffset_StairMesh, value);
			}
		}

		// Token: 0x17005FCE RID: 24526
		// (get) Token: 0x06017D47 RID: 97607 RVA: 0x0022E691 File Offset: 0x0022C891
		// (set) Token: 0x06017D48 RID: 97608 RVA: 0x0022E6A5 File Offset: 0x0022C8A5
		public unsafe UStaticMesh WholeStairMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMesh>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroStair.__PropertyOffset_WholeStairMesh);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroStair.__PropertyOffset_WholeStairMesh, value);
			}
		}

		// Token: 0x17005FCF RID: 24527
		// (get) Token: 0x06017D49 RID: 97609 RVA: 0x0022E6BA File Offset: 0x0022C8BA
		// (set) Token: 0x06017D4A RID: 97610 RVA: 0x0022E6CA File Offset: 0x0022C8CA
		public unsafe float BoxCollisionHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroStair.__PropertyOffset_BoxCollisionHeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroStair.__PropertyOffset_BoxCollisionHeight) = value;
			}
		}

		// Token: 0x17005FD0 RID: 24528
		// (get) Token: 0x06017D4B RID: 97611 RVA: 0x0022E6DB File Offset: 0x0022C8DB
		// (set) Token: 0x06017D4C RID: 97612 RVA: 0x0022E6EB File Offset: 0x0022C8EB
		public unsafe float BoxCollisionWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroStair.__PropertyOffset_BoxCollisionWidth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroStair.__PropertyOffset_BoxCollisionWidth) = value;
			}
		}

		// Token: 0x06017D4D RID: 97613 RVA: 0x0022E6FC File Offset: 0x0022C8FC
		public void OnHorizontalConveyBase(float DeltaSeconds, FVector FloorLocation, UCharacterMovementComponent CharacterMovement)
		{
			AKuroStair.__OnHorizontalConveyBase_Internal(base.NativePtr, DeltaSeconds, FloorLocation, (CharacterMovement != null) ? CharacterMovement.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06017D4E RID: 97614 RVA: 0x0022E71B File Offset: 0x0022C91B
		public void OnConveyBase(float DeltaSeconds, FVector FloorLocation, UCharacterMovementComponent CharacterMovement)
		{
			AKuroStair.__OnConveyBase_Internal(base.NativePtr, DeltaSeconds, FloorLocation, (CharacterMovement != null) ? CharacterMovement.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06017D4F RID: 97615
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnHorizontalConveyBase_Internal(IntPtr @this, float DeltaSeconds, FVector FloorLocation, IntPtr CharacterMovement);

		// Token: 0x06017D50 RID: 97616
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnConveyBase_Internal(IntPtr @this, float DeltaSeconds, FVector FloorLocation, IntPtr CharacterMovement);

		// Token: 0x06017D51 RID: 97617 RVA: 0x0022E73A File Offset: 0x0022C93A
		static AKuroStair()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.KuroStair");
		}

		// Token: 0x06017D52 RID: 97618 RVA: 0x0022E748 File Offset: 0x0022C948
		protected AKuroStair(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400CEA0 RID: 52896
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameplay.KuroStair";

		// Token: 0x0400CEA1 RID: 52897
		private static IntPtr _ClassPtr;

		// Token: 0x0400CEA2 RID: 52898
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400CEA3 RID: 52899
		internal static int __PropertyOffset_StairCount;

		// Token: 0x0400CEA4 RID: 52900
		internal static int __PropertyOffset_TailHorizontalStairCount;

		// Token: 0x0400CEA5 RID: 52901
		internal static int __PropertyOffset_HeadHorizontalStairCount;

		// Token: 0x0400CEA6 RID: 52902
		internal static int __PropertyOffset_MoveDelta;

		// Token: 0x0400CEA7 RID: 52903
		internal static int __PropertyOffset_OneStairTime;

		// Token: 0x0400CEA8 RID: 52904
		internal static int __PropertyOffset_StairMesh;

		// Token: 0x0400CEA9 RID: 52905
		internal static int __PropertyOffset_WholeStairMesh;

		// Token: 0x0400CEAA RID: 52906
		internal static int __PropertyOffset_BoxCollisionHeight;

		// Token: 0x0400CEAB RID: 52907
		internal static int __PropertyOffset_BoxCollisionWidth;
	}
}
