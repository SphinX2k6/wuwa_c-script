using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000450 RID: 1104
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ChaosSolverEngine.ChaosPhysicsCollisionInfo")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 112)]
	public class FChaosPhysicsCollisionInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06003B7A RID: 15226 RVA: 0x00059A90 File Offset: 0x00057C90
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FChaosPhysicsCollisionInfo._ScriptStructPtr != 0) ? FChaosPhysicsCollisionInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ChaosSolverEngine.ChaosPhysicsCollisionInfo", ref FChaosPhysicsCollisionInfo._ScriptStructPtr);
		}

		// Token: 0x17000E55 RID: 3669
		// (get) Token: 0x06003B7B RID: 15227 RVA: 0x00059AB4 File Offset: 0x00057CB4
		// (set) Token: 0x06003B7C RID: 15228 RVA: 0x00059AC8 File Offset: 0x00057CC8
		public unsafe UPrimitiveComponent Component
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPrimitiveComponent>(base.NativePtr / (IntPtr)sizeof(void*) + FChaosPhysicsCollisionInfo.__PropertyOffset_Component);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FChaosPhysicsCollisionInfo.__PropertyOffset_Component, value);
			}
		}

		// Token: 0x17000E56 RID: 3670
		// (get) Token: 0x06003B7D RID: 15229 RVA: 0x00059ADD File Offset: 0x00057CDD
		// (set) Token: 0x06003B7E RID: 15230 RVA: 0x00059AF1 File Offset: 0x00057CF1
		public unsafe UPrimitiveComponent OtherComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPrimitiveComponent>(base.NativePtr / (IntPtr)sizeof(void*) + FChaosPhysicsCollisionInfo.__PropertyOffset_OtherComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FChaosPhysicsCollisionInfo.__PropertyOffset_OtherComponent, value);
			}
		}

		// Token: 0x17000E57 RID: 3671
		// (get) Token: 0x06003B7F RID: 15231 RVA: 0x00059B06 File Offset: 0x00057D06
		// (set) Token: 0x06003B80 RID: 15232 RVA: 0x00059B1A File Offset: 0x00057D1A
		public unsafe FVector Location
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FChaosPhysicsCollisionInfo.__PropertyOffset_Location);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FChaosPhysicsCollisionInfo.__PropertyOffset_Location) = value;
			}
		}

		// Token: 0x17000E58 RID: 3672
		// (get) Token: 0x06003B81 RID: 15233 RVA: 0x00059B2F File Offset: 0x00057D2F
		// (set) Token: 0x06003B82 RID: 15234 RVA: 0x00059B43 File Offset: 0x00057D43
		public unsafe FVector Normal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FChaosPhysicsCollisionInfo.__PropertyOffset_Normal);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FChaosPhysicsCollisionInfo.__PropertyOffset_Normal) = value;
			}
		}

		// Token: 0x17000E59 RID: 3673
		// (get) Token: 0x06003B83 RID: 15235 RVA: 0x00059B58 File Offset: 0x00057D58
		// (set) Token: 0x06003B84 RID: 15236 RVA: 0x00059B6C File Offset: 0x00057D6C
		public unsafe FVector AccumulatedImpulse
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FChaosPhysicsCollisionInfo.__PropertyOffset_AccumulatedImpulse);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FChaosPhysicsCollisionInfo.__PropertyOffset_AccumulatedImpulse) = value;
			}
		}

		// Token: 0x17000E5A RID: 3674
		// (get) Token: 0x06003B85 RID: 15237 RVA: 0x00059B81 File Offset: 0x00057D81
		// (set) Token: 0x06003B86 RID: 15238 RVA: 0x00059B95 File Offset: 0x00057D95
		public unsafe FVector Velocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FChaosPhysicsCollisionInfo.__PropertyOffset_Velocity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FChaosPhysicsCollisionInfo.__PropertyOffset_Velocity) = value;
			}
		}

		// Token: 0x17000E5B RID: 3675
		// (get) Token: 0x06003B87 RID: 15239 RVA: 0x00059BAA File Offset: 0x00057DAA
		// (set) Token: 0x06003B88 RID: 15240 RVA: 0x00059BBE File Offset: 0x00057DBE
		public unsafe FVector OtherVelocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FChaosPhysicsCollisionInfo.__PropertyOffset_OtherVelocity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FChaosPhysicsCollisionInfo.__PropertyOffset_OtherVelocity) = value;
			}
		}

		// Token: 0x17000E5C RID: 3676
		// (get) Token: 0x06003B89 RID: 15241 RVA: 0x00059BD3 File Offset: 0x00057DD3
		// (set) Token: 0x06003B8A RID: 15242 RVA: 0x00059BE7 File Offset: 0x00057DE7
		public unsafe FVector AngularVelocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FChaosPhysicsCollisionInfo.__PropertyOffset_AngularVelocity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FChaosPhysicsCollisionInfo.__PropertyOffset_AngularVelocity) = value;
			}
		}

		// Token: 0x17000E5D RID: 3677
		// (get) Token: 0x06003B8B RID: 15243 RVA: 0x00059BFC File Offset: 0x00057DFC
		// (set) Token: 0x06003B8C RID: 15244 RVA: 0x00059C10 File Offset: 0x00057E10
		public unsafe FVector OtherAngularVelocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FChaosPhysicsCollisionInfo.__PropertyOffset_OtherAngularVelocity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FChaosPhysicsCollisionInfo.__PropertyOffset_OtherAngularVelocity) = value;
			}
		}

		// Token: 0x17000E5E RID: 3678
		// (get) Token: 0x06003B8D RID: 15245 RVA: 0x00059C25 File Offset: 0x00057E25
		// (set) Token: 0x06003B8E RID: 15246 RVA: 0x00059C35 File Offset: 0x00057E35
		public unsafe float Mass
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FChaosPhysicsCollisionInfo.__PropertyOffset_Mass);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FChaosPhysicsCollisionInfo.__PropertyOffset_Mass) = value;
			}
		}

		// Token: 0x17000E5F RID: 3679
		// (get) Token: 0x06003B8F RID: 15247 RVA: 0x00059C46 File Offset: 0x00057E46
		// (set) Token: 0x06003B90 RID: 15248 RVA: 0x00059C56 File Offset: 0x00057E56
		public unsafe float OtherMass
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FChaosPhysicsCollisionInfo.__PropertyOffset_OtherMass);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FChaosPhysicsCollisionInfo.__PropertyOffset_OtherMass) = value;
			}
		}

		// Token: 0x06003B91 RID: 15249 RVA: 0x00059C67 File Offset: 0x00057E67
		public FChaosPhysicsCollisionInfo()
		{
		}

		// Token: 0x06003B92 RID: 15250 RVA: 0x00059C70 File Offset: 0x00057E70
		[NullableContext(1)]
		public FChaosPhysicsCollisionInfo(UPrimitiveComponent Component, UPrimitiveComponent OtherComponent, FVector Location, FVector Normal, FVector AccumulatedImpulse, FVector Velocity, FVector OtherVelocity, FVector AngularVelocity, FVector OtherAngularVelocity, float Mass, float OtherMass)
		{
			this.Component = Component;
			this.OtherComponent = OtherComponent;
			this.Location = Location;
			this.Normal = Normal;
			this.AccumulatedImpulse = AccumulatedImpulse;
			this.Velocity = Velocity;
			this.OtherVelocity = OtherVelocity;
			this.AngularVelocity = AngularVelocity;
			this.OtherAngularVelocity = OtherAngularVelocity;
			this.Mass = Mass;
			this.OtherMass = OtherMass;
		}

		// Token: 0x06003B93 RID: 15251 RVA: 0x00059CD8 File Offset: 0x00057ED8
		protected override IntPtr GetUStructPtr()
		{
			return FChaosPhysicsCollisionInfo.StaticStruct();
		}

		// Token: 0x06003B94 RID: 15252 RVA: 0x00059CE4 File Offset: 0x00057EE4
		public FChaosPhysicsCollisionInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06003B95 RID: 15253 RVA: 0x00059CEE File Offset: 0x00057EEE
		public FChaosPhysicsCollisionInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06003B96 RID: 15254 RVA: 0x00059CF9 File Offset: 0x00057EF9
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FChaosPhysicsCollisionInfo(Pointer, false, true);
		}

		// Token: 0x06003B97 RID: 15255 RVA: 0x00059D03 File Offset: 0x00057F03
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FChaosPhysicsCollisionInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04001B61 RID: 7009
		[Nullable(1)]
		public const string __ObjectPath = "/Script/ChaosSolverEngine.ChaosPhysicsCollisionInfo";

		// Token: 0x04001B62 RID: 7010
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001B63 RID: 7011
		internal static int __PropertyOffset_Component;

		// Token: 0x04001B64 RID: 7012
		internal static int __PropertyOffset_OtherComponent;

		// Token: 0x04001B65 RID: 7013
		internal static int __PropertyOffset_Location;

		// Token: 0x04001B66 RID: 7014
		internal static int __PropertyOffset_Normal;

		// Token: 0x04001B67 RID: 7015
		internal static int __PropertyOffset_AccumulatedImpulse;

		// Token: 0x04001B68 RID: 7016
		internal static int __PropertyOffset_Velocity;

		// Token: 0x04001B69 RID: 7017
		internal static int __PropertyOffset_OtherVelocity;

		// Token: 0x04001B6A RID: 7018
		internal static int __PropertyOffset_AngularVelocity;

		// Token: 0x04001B6B RID: 7019
		internal static int __PropertyOffset_OtherAngularVelocity;

		// Token: 0x04001B6C RID: 7020
		internal static int __PropertyOffset_Mass;

		// Token: 0x04001B6D RID: 7021
		internal static int __PropertyOffset_OtherMass;
	}
}
