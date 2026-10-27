using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000970 RID: 2416
	[UnrealObjectPath("/Script/Engine.ConstraintDrive")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FConstraintDrive : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600885D RID: 34909 RVA: 0x000C35EE File Offset: 0x000C17EE
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FConstraintDrive._ScriptStructPtr != 0) ? FConstraintDrive._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.ConstraintDrive", ref FConstraintDrive._ScriptStructPtr);
		}

		// Token: 0x1700202D RID: 8237
		// (get) Token: 0x0600885E RID: 34910 RVA: 0x000C3612 File Offset: 0x000C1812
		// (set) Token: 0x0600885F RID: 34911 RVA: 0x000C3622 File Offset: 0x000C1822
		public unsafe float Stiffness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FConstraintDrive.__PropertyOffset_Stiffness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FConstraintDrive.__PropertyOffset_Stiffness) = value;
			}
		}

		// Token: 0x1700202E RID: 8238
		// (get) Token: 0x06008860 RID: 34912 RVA: 0x000C3633 File Offset: 0x000C1833
		// (set) Token: 0x06008861 RID: 34913 RVA: 0x000C3643 File Offset: 0x000C1843
		public unsafe float Damping
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FConstraintDrive.__PropertyOffset_Damping);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FConstraintDrive.__PropertyOffset_Damping) = value;
			}
		}

		// Token: 0x1700202F RID: 8239
		// (get) Token: 0x06008862 RID: 34914 RVA: 0x000C3654 File Offset: 0x000C1854
		// (set) Token: 0x06008863 RID: 34915 RVA: 0x000C3664 File Offset: 0x000C1864
		public unsafe float MaxForce
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FConstraintDrive.__PropertyOffset_MaxForce);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FConstraintDrive.__PropertyOffset_MaxForce) = value;
			}
		}

		// Token: 0x17002030 RID: 8240
		// (get) Token: 0x06008864 RID: 34916 RVA: 0x000C3675 File Offset: 0x000C1875
		// (set) Token: 0x06008865 RID: 34917 RVA: 0x000C368E File Offset: 0x000C188E
		public unsafe bool bEnablePositionDrive
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FConstraintDrive.__PropertyOffset_bEnablePositionDrive) & FConstraintDrive.__PropertyMask_bEnablePositionDrive) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FConstraintDrive.__PropertyOffset_bEnablePositionDrive) = ((*(base.NativePtr + (IntPtr)FConstraintDrive.__PropertyOffset_bEnablePositionDrive) & ~FConstraintDrive.__PropertyMask_bEnablePositionDrive) | (value ? FConstraintDrive.__PropertyMask_bEnablePositionDrive : 0));
			}
		}

		// Token: 0x17002031 RID: 8241
		// (get) Token: 0x06008866 RID: 34918 RVA: 0x000C36BE File Offset: 0x000C18BE
		// (set) Token: 0x06008867 RID: 34919 RVA: 0x000C36D7 File Offset: 0x000C18D7
		public unsafe bool bEnableVelocityDrive
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FConstraintDrive.__PropertyOffset_bEnableVelocityDrive) & FConstraintDrive.__PropertyMask_bEnableVelocityDrive) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FConstraintDrive.__PropertyOffset_bEnableVelocityDrive) = ((*(base.NativePtr + (IntPtr)FConstraintDrive.__PropertyOffset_bEnableVelocityDrive) & ~FConstraintDrive.__PropertyMask_bEnableVelocityDrive) | (value ? FConstraintDrive.__PropertyMask_bEnableVelocityDrive : 0));
			}
		}

		// Token: 0x06008868 RID: 34920 RVA: 0x000C3707 File Offset: 0x000C1907
		public FConstraintDrive()
		{
		}

		// Token: 0x06008869 RID: 34921 RVA: 0x000C370F File Offset: 0x000C190F
		public FConstraintDrive(float Stiffness, float Damping, float MaxForce, bool bEnablePositionDrive, bool bEnableVelocityDrive)
		{
			this.Stiffness = Stiffness;
			this.Damping = Damping;
			this.MaxForce = MaxForce;
			this.bEnablePositionDrive = bEnablePositionDrive;
			this.bEnableVelocityDrive = bEnableVelocityDrive;
		}

		// Token: 0x0600886A RID: 34922 RVA: 0x000C373C File Offset: 0x000C193C
		protected override IntPtr GetUStructPtr()
		{
			return FConstraintDrive.StaticStruct();
		}

		// Token: 0x0600886B RID: 34923 RVA: 0x000C3748 File Offset: 0x000C1948
		[NullableContext(2)]
		public FConstraintDrive(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600886C RID: 34924 RVA: 0x000C3752 File Offset: 0x000C1952
		public FConstraintDrive(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600886D RID: 34925 RVA: 0x000C375D File Offset: 0x000C195D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FConstraintDrive(Pointer, false, true);
		}

		// Token: 0x0600886E RID: 34926 RVA: 0x000C3767 File Offset: 0x000C1967
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FConstraintDrive(Pointer, MemoryOwner);
		}

		// Token: 0x040040D1 RID: 16593
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ConstraintDrive";

		// Token: 0x040040D2 RID: 16594
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040040D3 RID: 16595
		internal static int __PropertyOffset_Stiffness;

		// Token: 0x040040D4 RID: 16596
		internal static int __PropertyOffset_Damping;

		// Token: 0x040040D5 RID: 16597
		internal static int __PropertyOffset_MaxForce;

		// Token: 0x040040D6 RID: 16598
		internal static int __PropertyOffset_bEnablePositionDrive;

		// Token: 0x040040D7 RID: 16599
		internal static byte __PropertyMask_bEnablePositionDrive;

		// Token: 0x040040D8 RID: 16600
		internal static int __PropertyOffset_bEnableVelocityDrive;

		// Token: 0x040040D9 RID: 16601
		internal static byte __PropertyMask_bEnableVelocityDrive;
	}
}
