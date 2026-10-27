using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200096E RID: 2414
	[UnrealObjectPath("/Script/Engine.ConstraintBaseParams")]
	[UnrealStructLayout(20, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 20)]
	public class FConstraintBaseParams : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06008841 RID: 34881 RVA: 0x000C334A File Offset: 0x000C154A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FConstraintBaseParams._ScriptStructPtr != 0) ? FConstraintBaseParams._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.ConstraintBaseParams", ref FConstraintBaseParams._ScriptStructPtr);
		}

		// Token: 0x17002028 RID: 8232
		// (get) Token: 0x06008842 RID: 34882 RVA: 0x000C336E File Offset: 0x000C156E
		// (set) Token: 0x06008843 RID: 34883 RVA: 0x000C337E File Offset: 0x000C157E
		public unsafe float Stiffness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FConstraintBaseParams.__PropertyOffset_Stiffness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FConstraintBaseParams.__PropertyOffset_Stiffness) = value;
			}
		}

		// Token: 0x17002029 RID: 8233
		// (get) Token: 0x06008844 RID: 34884 RVA: 0x000C338F File Offset: 0x000C158F
		// (set) Token: 0x06008845 RID: 34885 RVA: 0x000C339F File Offset: 0x000C159F
		public unsafe float Damping
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FConstraintBaseParams.__PropertyOffset_Damping);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FConstraintBaseParams.__PropertyOffset_Damping) = value;
			}
		}

		// Token: 0x1700202A RID: 8234
		// (get) Token: 0x06008846 RID: 34886 RVA: 0x000C33B0 File Offset: 0x000C15B0
		// (set) Token: 0x06008847 RID: 34887 RVA: 0x000C33C0 File Offset: 0x000C15C0
		public unsafe float Restitution
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FConstraintBaseParams.__PropertyOffset_Restitution);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FConstraintBaseParams.__PropertyOffset_Restitution) = value;
			}
		}

		// Token: 0x1700202B RID: 8235
		// (get) Token: 0x06008848 RID: 34888 RVA: 0x000C33D1 File Offset: 0x000C15D1
		// (set) Token: 0x06008849 RID: 34889 RVA: 0x000C33E1 File Offset: 0x000C15E1
		public unsafe float ContactDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FConstraintBaseParams.__PropertyOffset_ContactDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FConstraintBaseParams.__PropertyOffset_ContactDistance) = value;
			}
		}

		// Token: 0x1700202C RID: 8236
		// (get) Token: 0x0600884A RID: 34890 RVA: 0x000C33F2 File Offset: 0x000C15F2
		// (set) Token: 0x0600884B RID: 34891 RVA: 0x000C340B File Offset: 0x000C160B
		public unsafe bool bSoftConstraint
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FConstraintBaseParams.__PropertyOffset_bSoftConstraint) & FConstraintBaseParams.__PropertyMask_bSoftConstraint) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FConstraintBaseParams.__PropertyOffset_bSoftConstraint) = ((*(base.NativePtr + (IntPtr)FConstraintBaseParams.__PropertyOffset_bSoftConstraint) & ~FConstraintBaseParams.__PropertyMask_bSoftConstraint) | (value ? FConstraintBaseParams.__PropertyMask_bSoftConstraint : 0));
			}
		}

		// Token: 0x0600884C RID: 34892 RVA: 0x000C343B File Offset: 0x000C163B
		public FConstraintBaseParams()
		{
		}

		// Token: 0x0600884D RID: 34893 RVA: 0x000C3443 File Offset: 0x000C1643
		public FConstraintBaseParams(float Stiffness, float Damping, float Restitution, float ContactDistance, bool bSoftConstraint)
		{
			this.Stiffness = Stiffness;
			this.Damping = Damping;
			this.Restitution = Restitution;
			this.ContactDistance = ContactDistance;
			this.bSoftConstraint = bSoftConstraint;
		}

		// Token: 0x0600884E RID: 34894 RVA: 0x000C3470 File Offset: 0x000C1670
		protected override IntPtr GetUStructPtr()
		{
			return FConstraintBaseParams.StaticStruct();
		}

		// Token: 0x0600884F RID: 34895 RVA: 0x000C347C File Offset: 0x000C167C
		[NullableContext(2)]
		public FConstraintBaseParams(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008850 RID: 34896 RVA: 0x000C3486 File Offset: 0x000C1686
		public FConstraintBaseParams(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008851 RID: 34897 RVA: 0x000C3491 File Offset: 0x000C1691
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FConstraintBaseParams(Pointer, false, true);
		}

		// Token: 0x06008852 RID: 34898 RVA: 0x000C349B File Offset: 0x000C169B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FConstraintBaseParams(Pointer, MemoryOwner);
		}

		// Token: 0x040040C6 RID: 16582
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ConstraintBaseParams";

		// Token: 0x040040C7 RID: 16583
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040040C8 RID: 16584
		internal static int __PropertyOffset_Stiffness;

		// Token: 0x040040C9 RID: 16585
		internal static int __PropertyOffset_Damping;

		// Token: 0x040040CA RID: 16586
		internal static int __PropertyOffset_Restitution;

		// Token: 0x040040CB RID: 16587
		internal static int __PropertyOffset_ContactDistance;

		// Token: 0x040040CC RID: 16588
		internal static int __PropertyOffset_bSoftConstraint;

		// Token: 0x040040CD RID: 16589
		internal static byte __PropertyMask_bSoftConstraint;
	}
}
