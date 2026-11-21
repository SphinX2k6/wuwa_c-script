using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020002AD RID: 685
	[UnrealObjectPath("/Script/Engine.ViewTargetTransitionParams")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FViewTargetTransitionParams : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004A30 RID: 18992 RVA: 0x00067E74 File Offset: 0x00066074
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FViewTargetTransitionParams._ScriptStructPtr != 0) ? FViewTargetTransitionParams._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.ViewTargetTransitionParams", ref FViewTargetTransitionParams._ScriptStructPtr);
		}

		// Token: 0x17000DE3 RID: 3555
		// (get) Token: 0x06004A31 RID: 18993 RVA: 0x00067E98 File Offset: 0x00066098
		// (set) Token: 0x06004A32 RID: 18994 RVA: 0x00067EA8 File Offset: 0x000660A8
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

		// Token: 0x17000DE4 RID: 3556
		// (get) Token: 0x06004A33 RID: 18995 RVA: 0x00067EB9 File Offset: 0x000660B9
		// (set) Token: 0x06004A34 RID: 18996 RVA: 0x00067ECD File Offset: 0x000660CD
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

		// Token: 0x17000DE5 RID: 3557
		// (get) Token: 0x06004A35 RID: 18997 RVA: 0x00067EE2 File Offset: 0x000660E2
		// (set) Token: 0x06004A36 RID: 18998 RVA: 0x00067EF2 File Offset: 0x000660F2
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

		// Token: 0x17000DE6 RID: 3558
		// (get) Token: 0x06004A37 RID: 18999 RVA: 0x00067F03 File Offset: 0x00066103
		// (set) Token: 0x06004A38 RID: 19000 RVA: 0x00067F1C File Offset: 0x0006611C
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

		// Token: 0x17000DE7 RID: 3559
		// (get) Token: 0x06004A39 RID: 19001 RVA: 0x00067F4C File Offset: 0x0006614C
		// (set) Token: 0x06004A3A RID: 19002 RVA: 0x00067F5C File Offset: 0x0006615C
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

		// Token: 0x17000DE8 RID: 3560
		// (get) Token: 0x06004A3B RID: 19003 RVA: 0x00067F6D File Offset: 0x0006616D
		// (set) Token: 0x06004A3C RID: 19004 RVA: 0x00067F81 File Offset: 0x00066181
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

		// Token: 0x06004A3D RID: 19005 RVA: 0x00067F96 File Offset: 0x00066196
		public FViewTargetTransitionParams()
		{
		}

		// Token: 0x06004A3E RID: 19006 RVA: 0x00067F9E File Offset: 0x0006619E
		protected override IntPtr GetUStructPtr()
		{
			return FViewTargetTransitionParams.StaticStruct();
		}

		// Token: 0x06004A3F RID: 19007 RVA: 0x00067FAA File Offset: 0x000661AA
		[NullableContext(2)]
		public FViewTargetTransitionParams(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004A40 RID: 19008 RVA: 0x00067FB4 File Offset: 0x000661B4
		public FViewTargetTransitionParams(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004A41 RID: 19009 RVA: 0x00067FBF File Offset: 0x000661BF
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FViewTargetTransitionParams(Pointer, false, true);
		}

		// Token: 0x06004A42 RID: 19010 RVA: 0x00067FC9 File Offset: 0x000661C9
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FViewTargetTransitionParams(Pointer, MemoryOwner);
		}

		// Token: 0x04001D3C RID: 7484
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ViewTargetTransitionParams";

		// Token: 0x04001D3D RID: 7485
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001D3E RID: 7486
		internal static int __PropertyOffset_BlendTime;

		// Token: 0x04001D3F RID: 7487
		internal static int __PropertyOffset_BlendFunction;

		// Token: 0x04001D40 RID: 7488
		internal static int __PropertyOffset_BlendExp;

		// Token: 0x04001D41 RID: 7489
		internal static int __PropertyOffset_bLockOutgoing;

		// Token: 0x04001D42 RID: 7490
		internal static byte __PropertyMask_bLockOutgoing;

		// Token: 0x04001D43 RID: 7491
		internal static int __PropertyOffset_bKuroEnableBlend;

		// Token: 0x04001D44 RID: 7492
		internal static int __PropertyOffset_BlendCurve;
	}
}
