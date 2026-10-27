using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020004DC RID: 1244
	[UnrealObjectPath("/Script/ControlRig.CRSimPoint")]
	[UnrealStructLayout(40, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FCRSimPoint : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060042AF RID: 17071 RVA: 0x00063910 File Offset: 0x00061B10
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCRSimPoint._ScriptStructPtr != 0) ? FCRSimPoint._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.CRSimPoint", ref FCRSimPoint._ScriptStructPtr);
		}

		// Token: 0x1700102C RID: 4140
		// (get) Token: 0x060042B0 RID: 17072 RVA: 0x00063934 File Offset: 0x00061B34
		// (set) Token: 0x060042B1 RID: 17073 RVA: 0x00063944 File Offset: 0x00061B44
		public unsafe float Mass
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCRSimPoint.__PropertyOffset_Mass);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCRSimPoint.__PropertyOffset_Mass) = value;
			}
		}

		// Token: 0x1700102D RID: 4141
		// (get) Token: 0x060042B2 RID: 17074 RVA: 0x00063955 File Offset: 0x00061B55
		// (set) Token: 0x060042B3 RID: 17075 RVA: 0x00063965 File Offset: 0x00061B65
		public unsafe float Size
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCRSimPoint.__PropertyOffset_Size);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCRSimPoint.__PropertyOffset_Size) = value;
			}
		}

		// Token: 0x1700102E RID: 4142
		// (get) Token: 0x060042B4 RID: 17076 RVA: 0x00063976 File Offset: 0x00061B76
		// (set) Token: 0x060042B5 RID: 17077 RVA: 0x00063986 File Offset: 0x00061B86
		public unsafe float LinearDamping
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCRSimPoint.__PropertyOffset_LinearDamping);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCRSimPoint.__PropertyOffset_LinearDamping) = value;
			}
		}

		// Token: 0x1700102F RID: 4143
		// (get) Token: 0x060042B6 RID: 17078 RVA: 0x00063997 File Offset: 0x00061B97
		// (set) Token: 0x060042B7 RID: 17079 RVA: 0x000639A7 File Offset: 0x00061BA7
		public unsafe float InheritMotion
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCRSimPoint.__PropertyOffset_InheritMotion);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCRSimPoint.__PropertyOffset_InheritMotion) = value;
			}
		}

		// Token: 0x17001030 RID: 4144
		// (get) Token: 0x060042B8 RID: 17080 RVA: 0x000639B8 File Offset: 0x00061BB8
		// (set) Token: 0x060042B9 RID: 17081 RVA: 0x000639CC File Offset: 0x00061BCC
		public unsafe FVector Position
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCRSimPoint.__PropertyOffset_Position);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCRSimPoint.__PropertyOffset_Position) = value;
			}
		}

		// Token: 0x17001031 RID: 4145
		// (get) Token: 0x060042BA RID: 17082 RVA: 0x000639E1 File Offset: 0x00061BE1
		// (set) Token: 0x060042BB RID: 17083 RVA: 0x000639F5 File Offset: 0x00061BF5
		public unsafe FVector LinearVelocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCRSimPoint.__PropertyOffset_LinearVelocity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCRSimPoint.__PropertyOffset_LinearVelocity) = value;
			}
		}

		// Token: 0x060042BC RID: 17084 RVA: 0x00063A0A File Offset: 0x00061C0A
		public FCRSimPoint()
		{
		}

		// Token: 0x060042BD RID: 17085 RVA: 0x00063A12 File Offset: 0x00061C12
		public FCRSimPoint(float Mass, float Size, float LinearDamping, float InheritMotion, FVector Position, FVector LinearVelocity)
		{
			this.Mass = Mass;
			this.Size = Size;
			this.LinearDamping = LinearDamping;
			this.InheritMotion = InheritMotion;
			this.Position = Position;
			this.LinearVelocity = LinearVelocity;
		}

		// Token: 0x060042BE RID: 17086 RVA: 0x00063A47 File Offset: 0x00061C47
		protected override IntPtr GetUStructPtr()
		{
			return FCRSimPoint.StaticStruct();
		}

		// Token: 0x060042BF RID: 17087 RVA: 0x00063A53 File Offset: 0x00061C53
		[NullableContext(2)]
		public FCRSimPoint(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060042C0 RID: 17088 RVA: 0x00063A5D File Offset: 0x00061C5D
		public FCRSimPoint(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060042C1 RID: 17089 RVA: 0x00063A68 File Offset: 0x00061C68
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCRSimPoint(Pointer, false, true);
		}

		// Token: 0x060042C2 RID: 17090 RVA: 0x00063A72 File Offset: 0x00061C72
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCRSimPoint(Pointer, MemoryOwner);
		}

		// Token: 0x04001FAD RID: 8109
		[Nullable(1)]
		public const string __ObjectPath = "/Script/ControlRig.CRSimPoint";

		// Token: 0x04001FAE RID: 8110
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001FAF RID: 8111
		internal static int __PropertyOffset_Mass;

		// Token: 0x04001FB0 RID: 8112
		internal static int __PropertyOffset_Size;

		// Token: 0x04001FB1 RID: 8113
		internal static int __PropertyOffset_LinearDamping;

		// Token: 0x04001FB2 RID: 8114
		internal static int __PropertyOffset_InheritMotion;

		// Token: 0x04001FB3 RID: 8115
		internal static int __PropertyOffset_Position;

		// Token: 0x04001FB4 RID: 8116
		internal static int __PropertyOffset_LinearVelocity;
	}
}
