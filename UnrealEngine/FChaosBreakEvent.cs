using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000449 RID: 1097
	[UnrealObjectPath("/Script/ChaosSolverEngine.ChaosBreakEvent")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FChaosBreakEvent : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06003B3C RID: 15164 RVA: 0x0005958B File Offset: 0x0005778B
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FChaosBreakEvent._ScriptStructPtr != 0) ? FChaosBreakEvent._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ChaosSolverEngine.ChaosBreakEvent", ref FChaosBreakEvent._ScriptStructPtr);
		}

		// Token: 0x17000E4A RID: 3658
		// (get) Token: 0x06003B3D RID: 15165 RVA: 0x000595AF File Offset: 0x000577AF
		// (set) Token: 0x06003B3E RID: 15166 RVA: 0x000595C3 File Offset: 0x000577C3
		[Nullable(2)]
		public unsafe UPrimitiveComponent Component
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPrimitiveComponent>(base.NativePtr / (IntPtr)sizeof(void*) + FChaosBreakEvent.__PropertyOffset_Component);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FChaosBreakEvent.__PropertyOffset_Component, value);
			}
		}

		// Token: 0x17000E4B RID: 3659
		// (get) Token: 0x06003B3F RID: 15167 RVA: 0x000595D8 File Offset: 0x000577D8
		// (set) Token: 0x06003B40 RID: 15168 RVA: 0x000595EC File Offset: 0x000577EC
		public unsafe FVector Location
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FChaosBreakEvent.__PropertyOffset_Location);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FChaosBreakEvent.__PropertyOffset_Location) = value;
			}
		}

		// Token: 0x17000E4C RID: 3660
		// (get) Token: 0x06003B41 RID: 15169 RVA: 0x00059601 File Offset: 0x00057801
		// (set) Token: 0x06003B42 RID: 15170 RVA: 0x00059615 File Offset: 0x00057815
		public unsafe FVector Velocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FChaosBreakEvent.__PropertyOffset_Velocity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FChaosBreakEvent.__PropertyOffset_Velocity) = value;
			}
		}

		// Token: 0x17000E4D RID: 3661
		// (get) Token: 0x06003B43 RID: 15171 RVA: 0x0005962A File Offset: 0x0005782A
		// (set) Token: 0x06003B44 RID: 15172 RVA: 0x0005963E File Offset: 0x0005783E
		public unsafe FVector AngularVelocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FChaosBreakEvent.__PropertyOffset_AngularVelocity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FChaosBreakEvent.__PropertyOffset_AngularVelocity) = value;
			}
		}

		// Token: 0x17000E4E RID: 3662
		// (get) Token: 0x06003B45 RID: 15173 RVA: 0x00059653 File Offset: 0x00057853
		// (set) Token: 0x06003B46 RID: 15174 RVA: 0x00059663 File Offset: 0x00057863
		public unsafe float Mass
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FChaosBreakEvent.__PropertyOffset_Mass);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FChaosBreakEvent.__PropertyOffset_Mass) = value;
			}
		}

		// Token: 0x06003B47 RID: 15175 RVA: 0x00059674 File Offset: 0x00057874
		public FChaosBreakEvent()
		{
		}

		// Token: 0x06003B48 RID: 15176 RVA: 0x0005967C File Offset: 0x0005787C
		[NullableContext(1)]
		public FChaosBreakEvent(UPrimitiveComponent Component, FVector Location, FVector Velocity, FVector AngularVelocity, float Mass)
		{
			this.Component = Component;
			this.Location = Location;
			this.Velocity = Velocity;
			this.AngularVelocity = AngularVelocity;
			this.Mass = Mass;
		}

		// Token: 0x06003B49 RID: 15177 RVA: 0x000596A9 File Offset: 0x000578A9
		protected override IntPtr GetUStructPtr()
		{
			return FChaosBreakEvent.StaticStruct();
		}

		// Token: 0x06003B4A RID: 15178 RVA: 0x000596B5 File Offset: 0x000578B5
		[NullableContext(2)]
		public FChaosBreakEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06003B4B RID: 15179 RVA: 0x000596BF File Offset: 0x000578BF
		public FChaosBreakEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06003B4C RID: 15180 RVA: 0x000596CA File Offset: 0x000578CA
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FChaosBreakEvent(Pointer, false, true);
		}

		// Token: 0x06003B4D RID: 15181 RVA: 0x000596D4 File Offset: 0x000578D4
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FChaosBreakEvent(Pointer, MemoryOwner);
		}

		// Token: 0x04001B43 RID: 6979
		[Nullable(1)]
		public const string __ObjectPath = "/Script/ChaosSolverEngine.ChaosBreakEvent";

		// Token: 0x04001B44 RID: 6980
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001B45 RID: 6981
		internal static int __PropertyOffset_Component;

		// Token: 0x04001B46 RID: 6982
		internal static int __PropertyOffset_Location;

		// Token: 0x04001B47 RID: 6983
		internal static int __PropertyOffset_Velocity;

		// Token: 0x04001B48 RID: 6984
		internal static int __PropertyOffset_AngularVelocity;

		// Token: 0x04001B49 RID: 6985
		internal static int __PropertyOffset_Mass;
	}
}
