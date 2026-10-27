using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000342 RID: 834
	[UnrealObjectPath("/Script/AnimGraphRuntime.SimSpaceSettings")]
	[UnrealStructLayout(64, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FSimSpaceSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06002E8E RID: 11918 RVA: 0x00047518 File Offset: 0x00045718
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSimSpaceSettings._ScriptStructPtr != 0) ? FSimSpaceSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AnimGraphRuntime.SimSpaceSettings", ref FSimSpaceSettings._ScriptStructPtr);
		}

		// Token: 0x17000B8E RID: 2958
		// (get) Token: 0x06002E8F RID: 11919 RVA: 0x0004753C File Offset: 0x0004573C
		// (set) Token: 0x06002E90 RID: 11920 RVA: 0x0004754C File Offset: 0x0004574C
		public unsafe float MasterAlpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSimSpaceSettings.__PropertyOffset_MasterAlpha);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSimSpaceSettings.__PropertyOffset_MasterAlpha) = value;
			}
		}

		// Token: 0x17000B8F RID: 2959
		// (get) Token: 0x06002E91 RID: 11921 RVA: 0x0004755D File Offset: 0x0004575D
		// (set) Token: 0x06002E92 RID: 11922 RVA: 0x0004756D File Offset: 0x0004576D
		public unsafe float VelocityScaleZ
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSimSpaceSettings.__PropertyOffset_VelocityScaleZ);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSimSpaceSettings.__PropertyOffset_VelocityScaleZ) = value;
			}
		}

		// Token: 0x17000B90 RID: 2960
		// (get) Token: 0x06002E93 RID: 11923 RVA: 0x0004757E File Offset: 0x0004577E
		// (set) Token: 0x06002E94 RID: 11924 RVA: 0x0004758E File Offset: 0x0004578E
		public unsafe float MaxLinearVelocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSimSpaceSettings.__PropertyOffset_MaxLinearVelocity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSimSpaceSettings.__PropertyOffset_MaxLinearVelocity) = value;
			}
		}

		// Token: 0x17000B91 RID: 2961
		// (get) Token: 0x06002E95 RID: 11925 RVA: 0x0004759F File Offset: 0x0004579F
		// (set) Token: 0x06002E96 RID: 11926 RVA: 0x000475AF File Offset: 0x000457AF
		public unsafe float MaxAngularVelocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSimSpaceSettings.__PropertyOffset_MaxAngularVelocity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSimSpaceSettings.__PropertyOffset_MaxAngularVelocity) = value;
			}
		}

		// Token: 0x17000B92 RID: 2962
		// (get) Token: 0x06002E97 RID: 11927 RVA: 0x000475C0 File Offset: 0x000457C0
		// (set) Token: 0x06002E98 RID: 11928 RVA: 0x000475D0 File Offset: 0x000457D0
		public unsafe float MaxLinearAcceleration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSimSpaceSettings.__PropertyOffset_MaxLinearAcceleration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSimSpaceSettings.__PropertyOffset_MaxLinearAcceleration) = value;
			}
		}

		// Token: 0x17000B93 RID: 2963
		// (get) Token: 0x06002E99 RID: 11929 RVA: 0x000475E1 File Offset: 0x000457E1
		// (set) Token: 0x06002E9A RID: 11930 RVA: 0x000475F1 File Offset: 0x000457F1
		public unsafe float MaxAngularAcceleration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSimSpaceSettings.__PropertyOffset_MaxAngularAcceleration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSimSpaceSettings.__PropertyOffset_MaxAngularAcceleration) = value;
			}
		}

		// Token: 0x17000B94 RID: 2964
		// (get) Token: 0x06002E9B RID: 11931 RVA: 0x00047602 File Offset: 0x00045802
		// (set) Token: 0x06002E9C RID: 11932 RVA: 0x00047612 File Offset: 0x00045812
		public unsafe float ExternalLinearDrag_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSimSpaceSettings.__PropertyOffset_ExternalLinearDrag_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSimSpaceSettings.__PropertyOffset_ExternalLinearDrag_DEPRECATED) = value;
			}
		}

		// Token: 0x17000B95 RID: 2965
		// (get) Token: 0x06002E9D RID: 11933 RVA: 0x00047623 File Offset: 0x00045823
		// (set) Token: 0x06002E9E RID: 11934 RVA: 0x00047637 File Offset: 0x00045837
		public unsafe FVector ExternalLinearDragV
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSimSpaceSettings.__PropertyOffset_ExternalLinearDragV);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSimSpaceSettings.__PropertyOffset_ExternalLinearDragV) = value;
			}
		}

		// Token: 0x17000B96 RID: 2966
		// (get) Token: 0x06002E9F RID: 11935 RVA: 0x0004764C File Offset: 0x0004584C
		// (set) Token: 0x06002EA0 RID: 11936 RVA: 0x00047660 File Offset: 0x00045860
		public unsafe FVector ExternalLinearVelocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSimSpaceSettings.__PropertyOffset_ExternalLinearVelocity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSimSpaceSettings.__PropertyOffset_ExternalLinearVelocity) = value;
			}
		}

		// Token: 0x17000B97 RID: 2967
		// (get) Token: 0x06002EA1 RID: 11937 RVA: 0x00047675 File Offset: 0x00045875
		// (set) Token: 0x06002EA2 RID: 11938 RVA: 0x00047689 File Offset: 0x00045889
		public unsafe FVector ExternalAngularVelocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSimSpaceSettings.__PropertyOffset_ExternalAngularVelocity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSimSpaceSettings.__PropertyOffset_ExternalAngularVelocity) = value;
			}
		}

		// Token: 0x06002EA3 RID: 11939 RVA: 0x0004769E File Offset: 0x0004589E
		public FSimSpaceSettings()
		{
		}

		// Token: 0x06002EA4 RID: 11940 RVA: 0x000476A8 File Offset: 0x000458A8
		public FSimSpaceSettings(float MasterAlpha, float VelocityScaleZ, float MaxLinearVelocity, float MaxAngularVelocity, float MaxLinearAcceleration, float MaxAngularAcceleration, float ExternalLinearDrag_DEPRECATED, FVector ExternalLinearDragV, FVector ExternalLinearVelocity, FVector ExternalAngularVelocity)
		{
			this.MasterAlpha = MasterAlpha;
			this.VelocityScaleZ = VelocityScaleZ;
			this.MaxLinearVelocity = MaxLinearVelocity;
			this.MaxAngularVelocity = MaxAngularVelocity;
			this.MaxLinearAcceleration = MaxLinearAcceleration;
			this.MaxAngularAcceleration = MaxAngularAcceleration;
			this.ExternalLinearDrag_DEPRECATED = ExternalLinearDrag_DEPRECATED;
			this.ExternalLinearDragV = ExternalLinearDragV;
			this.ExternalLinearVelocity = ExternalLinearVelocity;
			this.ExternalAngularVelocity = ExternalAngularVelocity;
		}

		// Token: 0x06002EA5 RID: 11941 RVA: 0x00047708 File Offset: 0x00045908
		protected override IntPtr GetUStructPtr()
		{
			return FSimSpaceSettings.StaticStruct();
		}

		// Token: 0x06002EA6 RID: 11942 RVA: 0x00047714 File Offset: 0x00045914
		[NullableContext(2)]
		public FSimSpaceSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002EA7 RID: 11943 RVA: 0x0004771E File Offset: 0x0004591E
		public FSimSpaceSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002EA8 RID: 11944 RVA: 0x00047729 File Offset: 0x00045929
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSimSpaceSettings(Pointer, false, true);
		}

		// Token: 0x06002EA9 RID: 11945 RVA: 0x00047733 File Offset: 0x00045933
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSimSpaceSettings(Pointer, MemoryOwner);
		}

		// Token: 0x040013F5 RID: 5109
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AnimGraphRuntime.SimSpaceSettings";

		// Token: 0x040013F6 RID: 5110
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040013F7 RID: 5111
		internal static int __PropertyOffset_MasterAlpha;

		// Token: 0x040013F8 RID: 5112
		internal static int __PropertyOffset_VelocityScaleZ;

		// Token: 0x040013F9 RID: 5113
		internal static int __PropertyOffset_MaxLinearVelocity;

		// Token: 0x040013FA RID: 5114
		internal static int __PropertyOffset_MaxAngularVelocity;

		// Token: 0x040013FB RID: 5115
		internal static int __PropertyOffset_MaxLinearAcceleration;

		// Token: 0x040013FC RID: 5116
		internal static int __PropertyOffset_MaxAngularAcceleration;

		// Token: 0x040013FD RID: 5117
		internal static int __PropertyOffset_ExternalLinearDrag_DEPRECATED;

		// Token: 0x040013FE RID: 5118
		internal static int __PropertyOffset_ExternalLinearDragV;

		// Token: 0x040013FF RID: 5119
		internal static int __PropertyOffset_ExternalLinearVelocity;

		// Token: 0x04001400 RID: 5120
		internal static int __PropertyOffset_ExternalAngularVelocity;
	}
}
