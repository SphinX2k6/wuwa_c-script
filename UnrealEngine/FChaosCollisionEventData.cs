using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200141D RID: 5149
	[UnrealObjectPath("/Script/GeometryCollectionEngine.ChaosCollisionEventData")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 88)]
	public class FChaosCollisionEventData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06012C90 RID: 76944 RVA: 0x001BA2A2 File Offset: 0x001B84A2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FChaosCollisionEventData._ScriptStructPtr != 0) ? FChaosCollisionEventData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GeometryCollectionEngine.ChaosCollisionEventData", ref FChaosCollisionEventData._ScriptStructPtr);
		}

		// Token: 0x170048C0 RID: 18624
		// (get) Token: 0x06012C91 RID: 76945 RVA: 0x001BA2C6 File Offset: 0x001B84C6
		// (set) Token: 0x06012C92 RID: 76946 RVA: 0x001BA2DA File Offset: 0x001B84DA
		public unsafe FVector Location
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FChaosCollisionEventData.__PropertyOffset_Location);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FChaosCollisionEventData.__PropertyOffset_Location) = value;
			}
		}

		// Token: 0x170048C1 RID: 18625
		// (get) Token: 0x06012C93 RID: 76947 RVA: 0x001BA2EF File Offset: 0x001B84EF
		// (set) Token: 0x06012C94 RID: 76948 RVA: 0x001BA303 File Offset: 0x001B8503
		public unsafe FVector Normal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FChaosCollisionEventData.__PropertyOffset_Normal);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FChaosCollisionEventData.__PropertyOffset_Normal) = value;
			}
		}

		// Token: 0x170048C2 RID: 18626
		// (get) Token: 0x06012C95 RID: 76949 RVA: 0x001BA318 File Offset: 0x001B8518
		// (set) Token: 0x06012C96 RID: 76950 RVA: 0x001BA32C File Offset: 0x001B852C
		public unsafe FVector Velocity1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FChaosCollisionEventData.__PropertyOffset_Velocity1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FChaosCollisionEventData.__PropertyOffset_Velocity1) = value;
			}
		}

		// Token: 0x170048C3 RID: 18627
		// (get) Token: 0x06012C97 RID: 76951 RVA: 0x001BA341 File Offset: 0x001B8541
		// (set) Token: 0x06012C98 RID: 76952 RVA: 0x001BA355 File Offset: 0x001B8555
		public unsafe FVector Velocity2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FChaosCollisionEventData.__PropertyOffset_Velocity2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FChaosCollisionEventData.__PropertyOffset_Velocity2) = value;
			}
		}

		// Token: 0x170048C4 RID: 18628
		// (get) Token: 0x06012C99 RID: 76953 RVA: 0x001BA36A File Offset: 0x001B856A
		// (set) Token: 0x06012C9A RID: 76954 RVA: 0x001BA37A File Offset: 0x001B857A
		public unsafe float Mass1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FChaosCollisionEventData.__PropertyOffset_Mass1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FChaosCollisionEventData.__PropertyOffset_Mass1) = value;
			}
		}

		// Token: 0x170048C5 RID: 18629
		// (get) Token: 0x06012C9B RID: 76955 RVA: 0x001BA38B File Offset: 0x001B858B
		// (set) Token: 0x06012C9C RID: 76956 RVA: 0x001BA39B File Offset: 0x001B859B
		public unsafe float Mass2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FChaosCollisionEventData.__PropertyOffset_Mass2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FChaosCollisionEventData.__PropertyOffset_Mass2) = value;
			}
		}

		// Token: 0x170048C6 RID: 18630
		// (get) Token: 0x06012C9D RID: 76957 RVA: 0x001BA3AC File Offset: 0x001B85AC
		// (set) Token: 0x06012C9E RID: 76958 RVA: 0x001BA3C0 File Offset: 0x001B85C0
		public unsafe FVector Impulse
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FChaosCollisionEventData.__PropertyOffset_Impulse);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FChaosCollisionEventData.__PropertyOffset_Impulse) = value;
			}
		}

		// Token: 0x06012C9F RID: 76959 RVA: 0x001BA3D5 File Offset: 0x001B85D5
		public FChaosCollisionEventData()
		{
		}

		// Token: 0x06012CA0 RID: 76960 RVA: 0x001BA3DD File Offset: 0x001B85DD
		public FChaosCollisionEventData(FVector Location, FVector Normal, FVector Velocity1, FVector Velocity2, float Mass1, float Mass2, FVector Impulse)
		{
			this.Location = Location;
			this.Normal = Normal;
			this.Velocity1 = Velocity1;
			this.Velocity2 = Velocity2;
			this.Mass1 = Mass1;
			this.Mass2 = Mass2;
			this.Impulse = Impulse;
		}

		// Token: 0x06012CA1 RID: 76961 RVA: 0x001BA41A File Offset: 0x001B861A
		protected override IntPtr GetUStructPtr()
		{
			return FChaosCollisionEventData.StaticStruct();
		}

		// Token: 0x06012CA2 RID: 76962 RVA: 0x001BA426 File Offset: 0x001B8626
		[NullableContext(2)]
		public FChaosCollisionEventData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06012CA3 RID: 76963 RVA: 0x001BA430 File Offset: 0x001B8630
		public FChaosCollisionEventData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06012CA4 RID: 76964 RVA: 0x001BA43B File Offset: 0x001B863B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FChaosCollisionEventData(Pointer, false, true);
		}

		// Token: 0x06012CA5 RID: 76965 RVA: 0x001BA445 File Offset: 0x001B8645
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FChaosCollisionEventData(Pointer, MemoryOwner);
		}

		// Token: 0x0400A092 RID: 41106
		[Nullable(1)]
		public const string __ObjectPath = "/Script/GeometryCollectionEngine.ChaosCollisionEventData";

		// Token: 0x0400A093 RID: 41107
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400A094 RID: 41108
		internal static int __PropertyOffset_Location;

		// Token: 0x0400A095 RID: 41109
		internal static int __PropertyOffset_Normal;

		// Token: 0x0400A096 RID: 41110
		internal static int __PropertyOffset_Velocity1;

		// Token: 0x0400A097 RID: 41111
		internal static int __PropertyOffset_Velocity2;

		// Token: 0x0400A098 RID: 41112
		internal static int __PropertyOffset_Mass1;

		// Token: 0x0400A099 RID: 41113
		internal static int __PropertyOffset_Mass2;

		// Token: 0x0400A09A RID: 41114
		internal static int __PropertyOffset_Impulse;
	}
}
