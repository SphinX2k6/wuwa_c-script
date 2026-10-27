using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020015D8 RID: 5592
	[UnrealObjectPath("/Script/KawaiiPhysics.KawaiiPhysicsSettings")]
	[UnrealStructLayout(32, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FKawaiiPhysicsSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060142A4 RID: 82596 RVA: 0x001D9F18 File Offset: 0x001D8118
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKawaiiPhysicsSettings._ScriptStructPtr != 0) ? FKawaiiPhysicsSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KawaiiPhysics.KawaiiPhysicsSettings", ref FKawaiiPhysicsSettings._ScriptStructPtr);
		}

		// Token: 0x17004F16 RID: 20246
		// (get) Token: 0x060142A5 RID: 82597 RVA: 0x001D9F3C File Offset: 0x001D813C
		// (set) Token: 0x060142A6 RID: 82598 RVA: 0x001D9F4C File Offset: 0x001D814C
		public unsafe float Damping
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKawaiiPhysicsSettings.__PropertyOffset_Damping);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKawaiiPhysicsSettings.__PropertyOffset_Damping) = value;
			}
		}

		// Token: 0x17004F17 RID: 20247
		// (get) Token: 0x060142A7 RID: 82599 RVA: 0x001D9F5D File Offset: 0x001D815D
		// (set) Token: 0x060142A8 RID: 82600 RVA: 0x001D9F6D File Offset: 0x001D816D
		public unsafe float WorldDampingLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKawaiiPhysicsSettings.__PropertyOffset_WorldDampingLocation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKawaiiPhysicsSettings.__PropertyOffset_WorldDampingLocation) = value;
			}
		}

		// Token: 0x17004F18 RID: 20248
		// (get) Token: 0x060142A9 RID: 82601 RVA: 0x001D9F7E File Offset: 0x001D817E
		// (set) Token: 0x060142AA RID: 82602 RVA: 0x001D9F8E File Offset: 0x001D818E
		public unsafe float WorldDampingRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKawaiiPhysicsSettings.__PropertyOffset_WorldDampingRotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKawaiiPhysicsSettings.__PropertyOffset_WorldDampingRotation) = value;
			}
		}

		// Token: 0x17004F19 RID: 20249
		// (get) Token: 0x060142AB RID: 82603 RVA: 0x001D9F9F File Offset: 0x001D819F
		// (set) Token: 0x060142AC RID: 82604 RVA: 0x001D9FAF File Offset: 0x001D81AF
		public unsafe float Stiffness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKawaiiPhysicsSettings.__PropertyOffset_Stiffness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKawaiiPhysicsSettings.__PropertyOffset_Stiffness) = value;
			}
		}

		// Token: 0x17004F1A RID: 20250
		// (get) Token: 0x060142AD RID: 82605 RVA: 0x001D9FC0 File Offset: 0x001D81C0
		// (set) Token: 0x060142AE RID: 82606 RVA: 0x001D9FD0 File Offset: 0x001D81D0
		public unsafe float Radius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKawaiiPhysicsSettings.__PropertyOffset_Radius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKawaiiPhysicsSettings.__PropertyOffset_Radius) = value;
			}
		}

		// Token: 0x17004F1B RID: 20251
		// (get) Token: 0x060142AF RID: 82607 RVA: 0x001D9FE1 File Offset: 0x001D81E1
		// (set) Token: 0x060142B0 RID: 82608 RVA: 0x001D9FF1 File Offset: 0x001D81F1
		public unsafe float LimitAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKawaiiPhysicsSettings.__PropertyOffset_LimitAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKawaiiPhysicsSettings.__PropertyOffset_LimitAngle) = value;
			}
		}

		// Token: 0x17004F1C RID: 20252
		// (get) Token: 0x060142B1 RID: 82609 RVA: 0x001DA002 File Offset: 0x001D8202
		// (set) Token: 0x060142B2 RID: 82610 RVA: 0x001DA012 File Offset: 0x001D8212
		public unsafe float HalfWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKawaiiPhysicsSettings.__PropertyOffset_HalfWidth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKawaiiPhysicsSettings.__PropertyOffset_HalfWidth) = value;
			}
		}

		// Token: 0x17004F1D RID: 20253
		// (get) Token: 0x060142B3 RID: 82611 RVA: 0x001DA023 File Offset: 0x001D8223
		// (set) Token: 0x060142B4 RID: 82612 RVA: 0x001DA033 File Offset: 0x001D8233
		public unsafe EPhyCollisionShape Shape
		{
			get
			{
				return (EPhyCollisionShape)(*(base.NativePtr + (IntPtr)FKawaiiPhysicsSettings.__PropertyOffset_Shape));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKawaiiPhysicsSettings.__PropertyOffset_Shape) = (byte)value;
			}
		}

		// Token: 0x060142B5 RID: 82613 RVA: 0x001DA044 File Offset: 0x001D8244
		public FKawaiiPhysicsSettings()
		{
		}

		// Token: 0x060142B6 RID: 82614 RVA: 0x001DA04C File Offset: 0x001D824C
		public FKawaiiPhysicsSettings(float Damping, float WorldDampingLocation, float WorldDampingRotation, float Stiffness, float Radius, float LimitAngle, float HalfWidth, EPhyCollisionShape Shape)
		{
			this.Damping = Damping;
			this.WorldDampingLocation = WorldDampingLocation;
			this.WorldDampingRotation = WorldDampingRotation;
			this.Stiffness = Stiffness;
			this.Radius = Radius;
			this.LimitAngle = LimitAngle;
			this.HalfWidth = HalfWidth;
			this.Shape = Shape;
		}

		// Token: 0x060142B7 RID: 82615 RVA: 0x001DA09C File Offset: 0x001D829C
		protected override IntPtr GetUStructPtr()
		{
			return FKawaiiPhysicsSettings.StaticStruct();
		}

		// Token: 0x060142B8 RID: 82616 RVA: 0x001DA0A8 File Offset: 0x001D82A8
		[NullableContext(2)]
		public FKawaiiPhysicsSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060142B9 RID: 82617 RVA: 0x001DA0B2 File Offset: 0x001D82B2
		public FKawaiiPhysicsSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060142BA RID: 82618 RVA: 0x001DA0BD File Offset: 0x001D82BD
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKawaiiPhysicsSettings(Pointer, false, true);
		}

		// Token: 0x060142BB RID: 82619 RVA: 0x001DA0C7 File Offset: 0x001D82C7
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKawaiiPhysicsSettings(Pointer, MemoryOwner);
		}

		// Token: 0x0400AF7F RID: 44927
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KawaiiPhysics.KawaiiPhysicsSettings";

		// Token: 0x0400AF80 RID: 44928
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400AF81 RID: 44929
		internal static int __PropertyOffset_Damping;

		// Token: 0x0400AF82 RID: 44930
		internal static int __PropertyOffset_WorldDampingLocation;

		// Token: 0x0400AF83 RID: 44931
		internal static int __PropertyOffset_WorldDampingRotation;

		// Token: 0x0400AF84 RID: 44932
		internal static int __PropertyOffset_Stiffness;

		// Token: 0x0400AF85 RID: 44933
		internal static int __PropertyOffset_Radius;

		// Token: 0x0400AF86 RID: 44934
		internal static int __PropertyOffset_LimitAngle;

		// Token: 0x0400AF87 RID: 44935
		internal static int __PropertyOffset_HalfWidth;

		// Token: 0x0400AF88 RID: 44936
		internal static int __PropertyOffset_Shape;
	}
}
