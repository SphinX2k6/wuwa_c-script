using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000352 RID: 850
	[UnrealObjectPath("/Script/ApexDestruction.DestructibleDebrisParameters")]
	[UnrealStructLayout(44, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 44)]
	public class FDestructibleDebrisParameters : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06002F36 RID: 12086 RVA: 0x0004853D File Offset: 0x0004673D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FDestructibleDebrisParameters._ScriptStructPtr != 0) ? FDestructibleDebrisParameters._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ApexDestruction.DestructibleDebrisParameters", ref FDestructibleDebrisParameters._ScriptStructPtr);
		}

		// Token: 0x17000BB3 RID: 2995
		// (get) Token: 0x06002F37 RID: 12087 RVA: 0x00048561 File Offset: 0x00046761
		// (set) Token: 0x06002F38 RID: 12088 RVA: 0x00048571 File Offset: 0x00046771
		public unsafe float DebrisLifetimeMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDestructibleDebrisParameters.__PropertyOffset_DebrisLifetimeMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDestructibleDebrisParameters.__PropertyOffset_DebrisLifetimeMin) = value;
			}
		}

		// Token: 0x17000BB4 RID: 2996
		// (get) Token: 0x06002F39 RID: 12089 RVA: 0x00048582 File Offset: 0x00046782
		// (set) Token: 0x06002F3A RID: 12090 RVA: 0x00048592 File Offset: 0x00046792
		public unsafe float DebrisLifetimeMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDestructibleDebrisParameters.__PropertyOffset_DebrisLifetimeMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDestructibleDebrisParameters.__PropertyOffset_DebrisLifetimeMax) = value;
			}
		}

		// Token: 0x17000BB5 RID: 2997
		// (get) Token: 0x06002F3B RID: 12091 RVA: 0x000485A3 File Offset: 0x000467A3
		// (set) Token: 0x06002F3C RID: 12092 RVA: 0x000485B3 File Offset: 0x000467B3
		public unsafe float DebrisMaxSeparationMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDestructibleDebrisParameters.__PropertyOffset_DebrisMaxSeparationMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDestructibleDebrisParameters.__PropertyOffset_DebrisMaxSeparationMin) = value;
			}
		}

		// Token: 0x17000BB6 RID: 2998
		// (get) Token: 0x06002F3D RID: 12093 RVA: 0x000485C4 File Offset: 0x000467C4
		// (set) Token: 0x06002F3E RID: 12094 RVA: 0x000485D4 File Offset: 0x000467D4
		public unsafe float DebrisMaxSeparationMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDestructibleDebrisParameters.__PropertyOffset_DebrisMaxSeparationMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDestructibleDebrisParameters.__PropertyOffset_DebrisMaxSeparationMax) = value;
			}
		}

		// Token: 0x17000BB7 RID: 2999
		// (get) Token: 0x06002F3F RID: 12095 RVA: 0x000485E5 File Offset: 0x000467E5
		// (set) Token: 0x06002F40 RID: 12096 RVA: 0x000485F9 File Offset: 0x000467F9
		public unsafe FBox ValidBounds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FDestructibleDebrisParameters.__PropertyOffset_ValidBounds);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FDestructibleDebrisParameters.__PropertyOffset_ValidBounds) = value;
			}
		}

		// Token: 0x06002F41 RID: 12097 RVA: 0x0004860E File Offset: 0x0004680E
		public FDestructibleDebrisParameters()
		{
		}

		// Token: 0x06002F42 RID: 12098 RVA: 0x00048616 File Offset: 0x00046816
		public FDestructibleDebrisParameters(float DebrisLifetimeMin, float DebrisLifetimeMax, float DebrisMaxSeparationMin, float DebrisMaxSeparationMax, FBox ValidBounds)
		{
			this.DebrisLifetimeMin = DebrisLifetimeMin;
			this.DebrisLifetimeMax = DebrisLifetimeMax;
			this.DebrisMaxSeparationMin = DebrisMaxSeparationMin;
			this.DebrisMaxSeparationMax = DebrisMaxSeparationMax;
			this.ValidBounds = ValidBounds;
		}

		// Token: 0x06002F43 RID: 12099 RVA: 0x00048643 File Offset: 0x00046843
		protected override IntPtr GetUStructPtr()
		{
			return FDestructibleDebrisParameters.StaticStruct();
		}

		// Token: 0x06002F44 RID: 12100 RVA: 0x0004864F File Offset: 0x0004684F
		[NullableContext(2)]
		public FDestructibleDebrisParameters(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002F45 RID: 12101 RVA: 0x00048659 File Offset: 0x00046859
		public FDestructibleDebrisParameters(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002F46 RID: 12102 RVA: 0x00048664 File Offset: 0x00046864
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FDestructibleDebrisParameters(Pointer, false, true);
		}

		// Token: 0x06002F47 RID: 12103 RVA: 0x0004866E File Offset: 0x0004686E
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FDestructibleDebrisParameters(Pointer, MemoryOwner);
		}

		// Token: 0x0400145E RID: 5214
		[Nullable(1)]
		public const string __ObjectPath = "/Script/ApexDestruction.DestructibleDebrisParameters";

		// Token: 0x0400145F RID: 5215
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001460 RID: 5216
		internal static int __PropertyOffset_DebrisLifetimeMin;

		// Token: 0x04001461 RID: 5217
		internal static int __PropertyOffset_DebrisLifetimeMax;

		// Token: 0x04001462 RID: 5218
		internal static int __PropertyOffset_DebrisMaxSeparationMin;

		// Token: 0x04001463 RID: 5219
		internal static int __PropertyOffset_DebrisMaxSeparationMax;

		// Token: 0x04001464 RID: 5220
		internal static int __PropertyOffset_ValidBounds;
	}
}
