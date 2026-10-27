using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200141E RID: 5150
	[UnrealObjectPath("/Script/GeometryCollectionEngine.ChaosCollisionEventRequestSettings")]
	[UnrealStructLayout(24, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FChaosCollisionEventRequestSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06012CA6 RID: 76966 RVA: 0x001BA44E File Offset: 0x001B864E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FChaosCollisionEventRequestSettings._ScriptStructPtr != 0) ? FChaosCollisionEventRequestSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GeometryCollectionEngine.ChaosCollisionEventRequestSettings", ref FChaosCollisionEventRequestSettings._ScriptStructPtr);
		}

		// Token: 0x170048C7 RID: 18631
		// (get) Token: 0x06012CA7 RID: 76967 RVA: 0x001BA472 File Offset: 0x001B8672
		// (set) Token: 0x06012CA8 RID: 76968 RVA: 0x001BA482 File Offset: 0x001B8682
		public unsafe int MaxNumberResults
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FChaosCollisionEventRequestSettings.__PropertyOffset_MaxNumberResults);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FChaosCollisionEventRequestSettings.__PropertyOffset_MaxNumberResults) = value;
			}
		}

		// Token: 0x170048C8 RID: 18632
		// (get) Token: 0x06012CA9 RID: 76969 RVA: 0x001BA493 File Offset: 0x001B8693
		// (set) Token: 0x06012CAA RID: 76970 RVA: 0x001BA4A3 File Offset: 0x001B86A3
		public unsafe float MinMass
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FChaosCollisionEventRequestSettings.__PropertyOffset_MinMass);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FChaosCollisionEventRequestSettings.__PropertyOffset_MinMass) = value;
			}
		}

		// Token: 0x170048C9 RID: 18633
		// (get) Token: 0x06012CAB RID: 76971 RVA: 0x001BA4B4 File Offset: 0x001B86B4
		// (set) Token: 0x06012CAC RID: 76972 RVA: 0x001BA4C4 File Offset: 0x001B86C4
		public unsafe float MinSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FChaosCollisionEventRequestSettings.__PropertyOffset_MinSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FChaosCollisionEventRequestSettings.__PropertyOffset_MinSpeed) = value;
			}
		}

		// Token: 0x170048CA RID: 18634
		// (get) Token: 0x06012CAD RID: 76973 RVA: 0x001BA4D5 File Offset: 0x001B86D5
		// (set) Token: 0x06012CAE RID: 76974 RVA: 0x001BA4E5 File Offset: 0x001B86E5
		public unsafe float MinImpulse
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FChaosCollisionEventRequestSettings.__PropertyOffset_MinImpulse);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FChaosCollisionEventRequestSettings.__PropertyOffset_MinImpulse) = value;
			}
		}

		// Token: 0x170048CB RID: 18635
		// (get) Token: 0x06012CAF RID: 76975 RVA: 0x001BA4F6 File Offset: 0x001B86F6
		// (set) Token: 0x06012CB0 RID: 76976 RVA: 0x001BA506 File Offset: 0x001B8706
		public unsafe float MaxDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FChaosCollisionEventRequestSettings.__PropertyOffset_MaxDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FChaosCollisionEventRequestSettings.__PropertyOffset_MaxDistance) = value;
			}
		}

		// Token: 0x170048CC RID: 18636
		// (get) Token: 0x06012CB1 RID: 76977 RVA: 0x001BA517 File Offset: 0x001B8717
		// (set) Token: 0x06012CB2 RID: 76978 RVA: 0x001BA527 File Offset: 0x001B8727
		public unsafe EChaosCollisionSortMethod SortMethod
		{
			get
			{
				return (EChaosCollisionSortMethod)(*(base.NativePtr + (IntPtr)FChaosCollisionEventRequestSettings.__PropertyOffset_SortMethod));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FChaosCollisionEventRequestSettings.__PropertyOffset_SortMethod) = (byte)value;
			}
		}

		// Token: 0x06012CB3 RID: 76979 RVA: 0x001BA538 File Offset: 0x001B8738
		public FChaosCollisionEventRequestSettings()
		{
		}

		// Token: 0x06012CB4 RID: 76980 RVA: 0x001BA540 File Offset: 0x001B8740
		public FChaosCollisionEventRequestSettings(int MaxNumberResults, float MinMass, float MinSpeed, float MinImpulse, float MaxDistance, EChaosCollisionSortMethod SortMethod)
		{
			this.MaxNumberResults = MaxNumberResults;
			this.MinMass = MinMass;
			this.MinSpeed = MinSpeed;
			this.MinImpulse = MinImpulse;
			this.MaxDistance = MaxDistance;
			this.SortMethod = SortMethod;
		}

		// Token: 0x06012CB5 RID: 76981 RVA: 0x001BA575 File Offset: 0x001B8775
		protected override IntPtr GetUStructPtr()
		{
			return FChaosCollisionEventRequestSettings.StaticStruct();
		}

		// Token: 0x06012CB6 RID: 76982 RVA: 0x001BA581 File Offset: 0x001B8781
		[NullableContext(2)]
		public FChaosCollisionEventRequestSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06012CB7 RID: 76983 RVA: 0x001BA58B File Offset: 0x001B878B
		public FChaosCollisionEventRequestSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06012CB8 RID: 76984 RVA: 0x001BA596 File Offset: 0x001B8796
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FChaosCollisionEventRequestSettings(Pointer, false, true);
		}

		// Token: 0x06012CB9 RID: 76985 RVA: 0x001BA5A0 File Offset: 0x001B87A0
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FChaosCollisionEventRequestSettings(Pointer, MemoryOwner);
		}

		// Token: 0x0400A09B RID: 41115
		[Nullable(1)]
		public const string __ObjectPath = "/Script/GeometryCollectionEngine.ChaosCollisionEventRequestSettings";

		// Token: 0x0400A09C RID: 41116
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400A09D RID: 41117
		internal static int __PropertyOffset_MaxNumberResults;

		// Token: 0x0400A09E RID: 41118
		internal static int __PropertyOffset_MinMass;

		// Token: 0x0400A09F RID: 41119
		internal static int __PropertyOffset_MinSpeed;

		// Token: 0x0400A0A0 RID: 41120
		internal static int __PropertyOffset_MinImpulse;

		// Token: 0x0400A0A1 RID: 41121
		internal static int __PropertyOffset_MaxDistance;

		// Token: 0x0400A0A2 RID: 41122
		internal static int __PropertyOffset_SortMethod;
	}
}
