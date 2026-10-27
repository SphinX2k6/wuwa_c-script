using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200122E RID: 4654
	[UnrealObjectPath("/Script/Engine.ViewTargetTransitionParams")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FViewTargetTransitionParams : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060111DE RID: 70110 RVA: 0x00191E30 File Offset: 0x00190030
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FViewTargetTransitionParams._ScriptStructPtr != 0) ? FViewTargetTransitionParams._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.ViewTargetTransitionParams", ref FViewTargetTransitionParams._ScriptStructPtr);
		}

		// Token: 0x170042CA RID: 17098
		// (get) Token: 0x060111DF RID: 70111 RVA: 0x00191E54 File Offset: 0x00190054
		// (set) Token: 0x060111E0 RID: 70112 RVA: 0x00191E64 File Offset: 0x00190064
		public unsafe float BlendTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FViewTargetTransitionParams.__PropertyOffset_BlendTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FViewTargetTransitionParams.__PropertyOffset_BlendTime) = value;
			}
		}

		// Token: 0x170042CB RID: 17099
		// (get) Token: 0x060111E1 RID: 70113 RVA: 0x00191E75 File Offset: 0x00190075
		// (set) Token: 0x060111E2 RID: 70114 RVA: 0x00191E89 File Offset: 0x00190089
		public unsafe TEnumAsByte<EViewTargetBlendFunction> BlendFunction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FViewTargetTransitionParams.__PropertyOffset_BlendFunction);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FViewTargetTransitionParams.__PropertyOffset_BlendFunction) = value;
			}
		}

		// Token: 0x170042CC RID: 17100
		// (get) Token: 0x060111E3 RID: 70115 RVA: 0x00191E9E File Offset: 0x0019009E
		// (set) Token: 0x060111E4 RID: 70116 RVA: 0x00191EAE File Offset: 0x001900AE
		public unsafe float BlendExp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FViewTargetTransitionParams.__PropertyOffset_BlendExp);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FViewTargetTransitionParams.__PropertyOffset_BlendExp) = value;
			}
		}

		// Token: 0x170042CD RID: 17101
		// (get) Token: 0x060111E5 RID: 70117 RVA: 0x00191EBF File Offset: 0x001900BF
		// (set) Token: 0x060111E6 RID: 70118 RVA: 0x00191ED8 File Offset: 0x001900D8
		public unsafe bool bLockOutgoing
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FViewTargetTransitionParams.__PropertyOffset_bLockOutgoing) & FViewTargetTransitionParams.__PropertyMask_bLockOutgoing) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FViewTargetTransitionParams.__PropertyOffset_bLockOutgoing) = ((*(base.NativePtr + (IntPtr)FViewTargetTransitionParams.__PropertyOffset_bLockOutgoing) & ~FViewTargetTransitionParams.__PropertyMask_bLockOutgoing) | (value ? FViewTargetTransitionParams.__PropertyMask_bLockOutgoing : 0));
			}
		}

		// Token: 0x170042CE RID: 17102
		// (get) Token: 0x060111E7 RID: 70119 RVA: 0x00191F08 File Offset: 0x00190108
		// (set) Token: 0x060111E8 RID: 70120 RVA: 0x00191F18 File Offset: 0x00190118
		public unsafe bool bKuroEnableBlend
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FViewTargetTransitionParams.__PropertyOffset_bKuroEnableBlend) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FViewTargetTransitionParams.__PropertyOffset_bKuroEnableBlend) = (value ? 1 : 0);
			}
		}

		// Token: 0x170042CF RID: 17103
		// (get) Token: 0x060111E9 RID: 70121 RVA: 0x00191F29 File Offset: 0x00190129
		// (set) Token: 0x060111EA RID: 70122 RVA: 0x00191F3D File Offset: 0x0019013D
		[Nullable(2)]
		public unsafe UCurveFloat BlendCurve
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + FViewTargetTransitionParams.__PropertyOffset_BlendCurve);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FViewTargetTransitionParams.__PropertyOffset_BlendCurve, value);
			}
		}

		// Token: 0x060111EB RID: 70123 RVA: 0x00191F52 File Offset: 0x00190152
		public FViewTargetTransitionParams()
		{
		}

		// Token: 0x060111EC RID: 70124 RVA: 0x00191F5A File Offset: 0x0019015A
		public FViewTargetTransitionParams(float BlendTime, TEnumAsByte<EViewTargetBlendFunction> BlendFunction, float BlendExp, bool bLockOutgoing, bool bKuroEnableBlend, [Nullable(1)] UCurveFloat BlendCurve)
		{
			this.BlendTime = BlendTime;
			this.BlendFunction = BlendFunction;
			this.BlendExp = BlendExp;
			this.bLockOutgoing = bLockOutgoing;
			this.bKuroEnableBlend = bKuroEnableBlend;
			this.BlendCurve = BlendCurve;
		}

		// Token: 0x060111ED RID: 70125 RVA: 0x00191F8F File Offset: 0x0019018F
		protected override IntPtr GetUStructPtr()
		{
			return FViewTargetTransitionParams.StaticStruct();
		}

		// Token: 0x060111EE RID: 70126 RVA: 0x00191F9B File Offset: 0x0019019B
		[NullableContext(2)]
		public FViewTargetTransitionParams(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060111EF RID: 70127 RVA: 0x00191FA5 File Offset: 0x001901A5
		public FViewTargetTransitionParams(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060111F0 RID: 70128 RVA: 0x00191FB0 File Offset: 0x001901B0
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FViewTargetTransitionParams(Pointer, false, true);
		}

		// Token: 0x060111F1 RID: 70129 RVA: 0x00191FBA File Offset: 0x001901BA
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FViewTargetTransitionParams(Pointer, MemoryOwner);
		}

		// Token: 0x04009292 RID: 37522
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ViewTargetTransitionParams";

		// Token: 0x04009293 RID: 37523
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04009294 RID: 37524
		internal static int __PropertyOffset_BlendTime;

		// Token: 0x04009295 RID: 37525
		internal static int __PropertyOffset_BlendFunction;

		// Token: 0x04009296 RID: 37526
		internal static int __PropertyOffset_BlendExp;

		// Token: 0x04009297 RID: 37527
		internal static int __PropertyOffset_bLockOutgoing;

		// Token: 0x04009298 RID: 37528
		internal static byte __PropertyMask_bLockOutgoing;

		// Token: 0x04009299 RID: 37529
		internal static int __PropertyOffset_bKuroEnableBlend;

		// Token: 0x0400929A RID: 37530
		internal static int __PropertyOffset_BlendCurve;
	}
}
