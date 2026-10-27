using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020004E0 RID: 1248
	[UnrealObjectPath("/Script/ControlRig.CRSimSoftCollision")]
	[UnrealStructLayout(80, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FCRSimSoftCollision : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060042F9 RID: 17145 RVA: 0x00063F81 File Offset: 0x00062181
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCRSimSoftCollision._ScriptStructPtr != 0) ? FCRSimSoftCollision._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.CRSimSoftCollision", ref FCRSimSoftCollision._ScriptStructPtr);
		}

		// Token: 0x17001041 RID: 4161
		// (get) Token: 0x060042FA RID: 17146 RVA: 0x00063FA5 File Offset: 0x000621A5
		// (set) Token: 0x060042FB RID: 17147 RVA: 0x00063FB9 File Offset: 0x000621B9
		public unsafe FTransform Transform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCRSimSoftCollision.__PropertyOffset_Transform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCRSimSoftCollision.__PropertyOffset_Transform) = value;
			}
		}

		// Token: 0x17001042 RID: 4162
		// (get) Token: 0x060042FC RID: 17148 RVA: 0x00063FCE File Offset: 0x000621CE
		// (set) Token: 0x060042FD RID: 17149 RVA: 0x00063FDE File Offset: 0x000621DE
		public unsafe ECRSimSoftCollisionType ShapeType
		{
			get
			{
				return (ECRSimSoftCollisionType)(*(base.NativePtr + (IntPtr)FCRSimSoftCollision.__PropertyOffset_ShapeType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCRSimSoftCollision.__PropertyOffset_ShapeType) = (byte)value;
			}
		}

		// Token: 0x17001043 RID: 4163
		// (get) Token: 0x060042FE RID: 17150 RVA: 0x00063FEF File Offset: 0x000621EF
		// (set) Token: 0x060042FF RID: 17151 RVA: 0x00063FFF File Offset: 0x000621FF
		public unsafe float MinimumDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCRSimSoftCollision.__PropertyOffset_MinimumDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCRSimSoftCollision.__PropertyOffset_MinimumDistance) = value;
			}
		}

		// Token: 0x17001044 RID: 4164
		// (get) Token: 0x06004300 RID: 17152 RVA: 0x00064010 File Offset: 0x00062210
		// (set) Token: 0x06004301 RID: 17153 RVA: 0x00064020 File Offset: 0x00062220
		public unsafe float MaximumDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCRSimSoftCollision.__PropertyOffset_MaximumDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCRSimSoftCollision.__PropertyOffset_MaximumDistance) = value;
			}
		}

		// Token: 0x17001045 RID: 4165
		// (get) Token: 0x06004302 RID: 17154 RVA: 0x00064031 File Offset: 0x00062231
		// (set) Token: 0x06004303 RID: 17155 RVA: 0x00064041 File Offset: 0x00062241
		public unsafe EControlRigAnimEasingType FalloffType
		{
			get
			{
				return (EControlRigAnimEasingType)(*(base.NativePtr + (IntPtr)FCRSimSoftCollision.__PropertyOffset_FalloffType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCRSimSoftCollision.__PropertyOffset_FalloffType) = (byte)value;
			}
		}

		// Token: 0x17001046 RID: 4166
		// (get) Token: 0x06004304 RID: 17156 RVA: 0x00064052 File Offset: 0x00062252
		// (set) Token: 0x06004305 RID: 17157 RVA: 0x00064062 File Offset: 0x00062262
		public unsafe float Coefficient
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCRSimSoftCollision.__PropertyOffset_Coefficient);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCRSimSoftCollision.__PropertyOffset_Coefficient) = value;
			}
		}

		// Token: 0x17001047 RID: 4167
		// (get) Token: 0x06004306 RID: 17158 RVA: 0x00064073 File Offset: 0x00062273
		// (set) Token: 0x06004307 RID: 17159 RVA: 0x00064083 File Offset: 0x00062283
		public unsafe bool bInverted
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCRSimSoftCollision.__PropertyOffset_bInverted) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCRSimSoftCollision.__PropertyOffset_bInverted) = (value ? 1 : 0);
			}
		}

		// Token: 0x06004308 RID: 17160 RVA: 0x00064094 File Offset: 0x00062294
		public FCRSimSoftCollision()
		{
		}

		// Token: 0x06004309 RID: 17161 RVA: 0x0006409C File Offset: 0x0006229C
		public FCRSimSoftCollision(FTransform Transform, ECRSimSoftCollisionType ShapeType, float MinimumDistance, float MaximumDistance, EControlRigAnimEasingType FalloffType, float Coefficient, bool bInverted)
		{
			this.Transform = Transform;
			this.ShapeType = ShapeType;
			this.MinimumDistance = MinimumDistance;
			this.MaximumDistance = MaximumDistance;
			this.FalloffType = FalloffType;
			this.Coefficient = Coefficient;
			this.bInverted = bInverted;
		}

		// Token: 0x0600430A RID: 17162 RVA: 0x000640D9 File Offset: 0x000622D9
		protected override IntPtr GetUStructPtr()
		{
			return FCRSimSoftCollision.StaticStruct();
		}

		// Token: 0x0600430B RID: 17163 RVA: 0x000640E5 File Offset: 0x000622E5
		[NullableContext(2)]
		public FCRSimSoftCollision(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600430C RID: 17164 RVA: 0x000640EF File Offset: 0x000622EF
		public FCRSimSoftCollision(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600430D RID: 17165 RVA: 0x000640FA File Offset: 0x000622FA
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCRSimSoftCollision(Pointer, false, true);
		}

		// Token: 0x0600430E RID: 17166 RVA: 0x00064104 File Offset: 0x00062304
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCRSimSoftCollision(Pointer, MemoryOwner);
		}

		// Token: 0x04001FD0 RID: 8144
		[Nullable(1)]
		public const string __ObjectPath = "/Script/ControlRig.CRSimSoftCollision";

		// Token: 0x04001FD1 RID: 8145
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001FD2 RID: 8146
		internal static int __PropertyOffset_Transform;

		// Token: 0x04001FD3 RID: 8147
		internal static int __PropertyOffset_ShapeType;

		// Token: 0x04001FD4 RID: 8148
		internal static int __PropertyOffset_MinimumDistance;

		// Token: 0x04001FD5 RID: 8149
		internal static int __PropertyOffset_MaximumDistance;

		// Token: 0x04001FD6 RID: 8150
		internal static int __PropertyOffset_FalloffType;

		// Token: 0x04001FD7 RID: 8151
		internal static int __PropertyOffset_Coefficient;

		// Token: 0x04001FD8 RID: 8152
		internal static int __PropertyOffset_bInverted;
	}
}
