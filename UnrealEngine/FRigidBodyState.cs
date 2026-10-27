using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001098 RID: 4248
	[UnrealObjectPath("/Script/Engine.RigidBodyState")]
	[UnrealStructLayout(64, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FRigidBodyState : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600F2C8 RID: 62152 RVA: 0x0016829C File Offset: 0x0016649C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigidBodyState._ScriptStructPtr != 0) ? FRigidBodyState._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.RigidBodyState", ref FRigidBodyState._ScriptStructPtr);
		}

		// Token: 0x17003B20 RID: 15136
		// (get) Token: 0x0600F2C9 RID: 62153 RVA: 0x001682C0 File Offset: 0x001664C0
		// (set) Token: 0x0600F2CA RID: 62154 RVA: 0x001682D4 File Offset: 0x001664D4
		public unsafe FVector_NetQuantize100 Position
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigidBodyState.__PropertyOffset_Position);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigidBodyState.__PropertyOffset_Position) = value;
			}
		}

		// Token: 0x17003B21 RID: 15137
		// (get) Token: 0x0600F2CB RID: 62155 RVA: 0x001682E9 File Offset: 0x001664E9
		// (set) Token: 0x0600F2CC RID: 62156 RVA: 0x001682FD File Offset: 0x001664FD
		public unsafe FQuat Quaternion
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigidBodyState.__PropertyOffset_Quaternion);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigidBodyState.__PropertyOffset_Quaternion) = value;
			}
		}

		// Token: 0x17003B22 RID: 15138
		// (get) Token: 0x0600F2CD RID: 62157 RVA: 0x00168312 File Offset: 0x00166512
		// (set) Token: 0x0600F2CE RID: 62158 RVA: 0x00168326 File Offset: 0x00166526
		public unsafe FVector_NetQuantize100 LinVel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigidBodyState.__PropertyOffset_LinVel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigidBodyState.__PropertyOffset_LinVel) = value;
			}
		}

		// Token: 0x17003B23 RID: 15139
		// (get) Token: 0x0600F2CF RID: 62159 RVA: 0x0016833B File Offset: 0x0016653B
		// (set) Token: 0x0600F2D0 RID: 62160 RVA: 0x0016834F File Offset: 0x0016654F
		public unsafe FVector_NetQuantize100 AngVel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigidBodyState.__PropertyOffset_AngVel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigidBodyState.__PropertyOffset_AngVel) = value;
			}
		}

		// Token: 0x17003B24 RID: 15140
		// (get) Token: 0x0600F2D1 RID: 62161 RVA: 0x00168364 File Offset: 0x00166564
		// (set) Token: 0x0600F2D2 RID: 62162 RVA: 0x00168374 File Offset: 0x00166574
		public unsafe byte Flags
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigidBodyState.__PropertyOffset_Flags);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigidBodyState.__PropertyOffset_Flags) = value;
			}
		}

		// Token: 0x0600F2D3 RID: 62163 RVA: 0x00168385 File Offset: 0x00166585
		public FRigidBodyState()
		{
		}

		// Token: 0x0600F2D4 RID: 62164 RVA: 0x0016838D File Offset: 0x0016658D
		public FRigidBodyState(FVector_NetQuantize100 Position, FQuat Quaternion, FVector_NetQuantize100 LinVel, FVector_NetQuantize100 AngVel, byte Flags)
		{
			this.Position = Position;
			this.Quaternion = Quaternion;
			this.LinVel = LinVel;
			this.AngVel = AngVel;
			this.Flags = Flags;
		}

		// Token: 0x0600F2D5 RID: 62165 RVA: 0x001683BA File Offset: 0x001665BA
		protected override IntPtr GetUStructPtr()
		{
			return FRigidBodyState.StaticStruct();
		}

		// Token: 0x0600F2D6 RID: 62166 RVA: 0x001683C6 File Offset: 0x001665C6
		[NullableContext(2)]
		public FRigidBodyState(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600F2D7 RID: 62167 RVA: 0x001683D0 File Offset: 0x001665D0
		public FRigidBodyState(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600F2D8 RID: 62168 RVA: 0x001683DB File Offset: 0x001665DB
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigidBodyState(Pointer, false, true);
		}

		// Token: 0x0600F2D9 RID: 62169 RVA: 0x001683E5 File Offset: 0x001665E5
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigidBodyState(Pointer, MemoryOwner);
		}

		// Token: 0x040083B5 RID: 33717
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.RigidBodyState";

		// Token: 0x040083B6 RID: 33718
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040083B7 RID: 33719
		internal static int __PropertyOffset_Position;

		// Token: 0x040083B8 RID: 33720
		internal static int __PropertyOffset_Quaternion;

		// Token: 0x040083B9 RID: 33721
		internal static int __PropertyOffset_LinVel;

		// Token: 0x040083BA RID: 33722
		internal static int __PropertyOffset_AngVel;

		// Token: 0x040083BB RID: 33723
		internal static int __PropertyOffset_Flags;
	}
}
