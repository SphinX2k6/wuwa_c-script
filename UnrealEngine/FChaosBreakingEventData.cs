using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200141B RID: 5147
	[UnrealObjectPath("/Script/GeometryCollectionEngine.ChaosBreakingEventData")]
	[UnrealStructLayout(28, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 28)]
	public class FChaosBreakingEventData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06012C6E RID: 76910 RVA: 0x001BA057 File Offset: 0x001B8257
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FChaosBreakingEventData._ScriptStructPtr != 0) ? FChaosBreakingEventData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GeometryCollectionEngine.ChaosBreakingEventData", ref FChaosBreakingEventData._ScriptStructPtr);
		}

		// Token: 0x170048B7 RID: 18615
		// (get) Token: 0x06012C6F RID: 76911 RVA: 0x001BA07B File Offset: 0x001B827B
		// (set) Token: 0x06012C70 RID: 76912 RVA: 0x001BA08F File Offset: 0x001B828F
		public unsafe FVector Location
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FChaosBreakingEventData.__PropertyOffset_Location);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FChaosBreakingEventData.__PropertyOffset_Location) = value;
			}
		}

		// Token: 0x170048B8 RID: 18616
		// (get) Token: 0x06012C71 RID: 76913 RVA: 0x001BA0A4 File Offset: 0x001B82A4
		// (set) Token: 0x06012C72 RID: 76914 RVA: 0x001BA0B8 File Offset: 0x001B82B8
		public unsafe FVector Velocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FChaosBreakingEventData.__PropertyOffset_Velocity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FChaosBreakingEventData.__PropertyOffset_Velocity) = value;
			}
		}

		// Token: 0x170048B9 RID: 18617
		// (get) Token: 0x06012C73 RID: 76915 RVA: 0x001BA0CD File Offset: 0x001B82CD
		// (set) Token: 0x06012C74 RID: 76916 RVA: 0x001BA0DD File Offset: 0x001B82DD
		public unsafe float Mass
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FChaosBreakingEventData.__PropertyOffset_Mass);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FChaosBreakingEventData.__PropertyOffset_Mass) = value;
			}
		}

		// Token: 0x06012C75 RID: 76917 RVA: 0x001BA0EE File Offset: 0x001B82EE
		public FChaosBreakingEventData()
		{
		}

		// Token: 0x06012C76 RID: 76918 RVA: 0x001BA0F6 File Offset: 0x001B82F6
		public FChaosBreakingEventData(FVector Location, FVector Velocity, float Mass)
		{
			this.Location = Location;
			this.Velocity = Velocity;
			this.Mass = Mass;
		}

		// Token: 0x06012C77 RID: 76919 RVA: 0x001BA113 File Offset: 0x001B8313
		protected override IntPtr GetUStructPtr()
		{
			return FChaosBreakingEventData.StaticStruct();
		}

		// Token: 0x06012C78 RID: 76920 RVA: 0x001BA11F File Offset: 0x001B831F
		[NullableContext(2)]
		public FChaosBreakingEventData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06012C79 RID: 76921 RVA: 0x001BA129 File Offset: 0x001B8329
		public FChaosBreakingEventData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06012C7A RID: 76922 RVA: 0x001BA134 File Offset: 0x001B8334
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FChaosBreakingEventData(Pointer, false, true);
		}

		// Token: 0x06012C7B RID: 76923 RVA: 0x001BA13E File Offset: 0x001B833E
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FChaosBreakingEventData(Pointer, MemoryOwner);
		}

		// Token: 0x0400A085 RID: 41093
		[Nullable(1)]
		public const string __ObjectPath = "/Script/GeometryCollectionEngine.ChaosBreakingEventData";

		// Token: 0x0400A086 RID: 41094
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400A087 RID: 41095
		internal static int __PropertyOffset_Location;

		// Token: 0x0400A088 RID: 41096
		internal static int __PropertyOffset_Velocity;

		// Token: 0x0400A089 RID: 41097
		internal static int __PropertyOffset_Mass;
	}
}
