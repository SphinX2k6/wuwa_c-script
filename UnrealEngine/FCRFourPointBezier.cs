using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020004D9 RID: 1241
	[UnrealObjectPath("/Script/ControlRig.CRFourPointBezier")]
	[UnrealStructLayout(48, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FCRFourPointBezier : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004281 RID: 17025 RVA: 0x000635FE File Offset: 0x000617FE
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCRFourPointBezier._ScriptStructPtr != 0) ? FCRFourPointBezier._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.CRFourPointBezier", ref FCRFourPointBezier._ScriptStructPtr);
		}

		// Token: 0x17001021 RID: 4129
		// (get) Token: 0x06004282 RID: 17026 RVA: 0x00063622 File Offset: 0x00061822
		// (set) Token: 0x06004283 RID: 17027 RVA: 0x00063636 File Offset: 0x00061836
		public unsafe FVector A
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCRFourPointBezier.__PropertyOffset_A);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCRFourPointBezier.__PropertyOffset_A) = value;
			}
		}

		// Token: 0x17001022 RID: 4130
		// (get) Token: 0x06004284 RID: 17028 RVA: 0x0006364B File Offset: 0x0006184B
		// (set) Token: 0x06004285 RID: 17029 RVA: 0x0006365F File Offset: 0x0006185F
		public unsafe FVector B
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCRFourPointBezier.__PropertyOffset_B);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCRFourPointBezier.__PropertyOffset_B) = value;
			}
		}

		// Token: 0x17001023 RID: 4131
		// (get) Token: 0x06004286 RID: 17030 RVA: 0x00063674 File Offset: 0x00061874
		// (set) Token: 0x06004287 RID: 17031 RVA: 0x00063688 File Offset: 0x00061888
		public unsafe FVector C
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCRFourPointBezier.__PropertyOffset_C);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCRFourPointBezier.__PropertyOffset_C) = value;
			}
		}

		// Token: 0x17001024 RID: 4132
		// (get) Token: 0x06004288 RID: 17032 RVA: 0x0006369D File Offset: 0x0006189D
		// (set) Token: 0x06004289 RID: 17033 RVA: 0x000636B1 File Offset: 0x000618B1
		public unsafe FVector D
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCRFourPointBezier.__PropertyOffset_D);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCRFourPointBezier.__PropertyOffset_D) = value;
			}
		}

		// Token: 0x0600428A RID: 17034 RVA: 0x000636C6 File Offset: 0x000618C6
		public FCRFourPointBezier()
		{
		}

		// Token: 0x0600428B RID: 17035 RVA: 0x000636CE File Offset: 0x000618CE
		public FCRFourPointBezier(FVector A, FVector B, FVector C, FVector D)
		{
			this.A = A;
			this.B = B;
			this.C = C;
			this.D = D;
		}

		// Token: 0x0600428C RID: 17036 RVA: 0x000636F3 File Offset: 0x000618F3
		protected override IntPtr GetUStructPtr()
		{
			return FCRFourPointBezier.StaticStruct();
		}

		// Token: 0x0600428D RID: 17037 RVA: 0x000636FF File Offset: 0x000618FF
		[NullableContext(2)]
		public FCRFourPointBezier(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600428E RID: 17038 RVA: 0x00063709 File Offset: 0x00061909
		public FCRFourPointBezier(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600428F RID: 17039 RVA: 0x00063714 File Offset: 0x00061914
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCRFourPointBezier(Pointer, false, true);
		}

		// Token: 0x06004290 RID: 17040 RVA: 0x0006371E File Offset: 0x0006191E
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCRFourPointBezier(Pointer, MemoryOwner);
		}

		// Token: 0x04001F9C RID: 8092
		[Nullable(1)]
		public const string __ObjectPath = "/Script/ControlRig.CRFourPointBezier";

		// Token: 0x04001F9D RID: 8093
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001F9E RID: 8094
		internal static int __PropertyOffset_A;

		// Token: 0x04001F9F RID: 8095
		internal static int __PropertyOffset_B;

		// Token: 0x04001FA0 RID: 8096
		internal static int __PropertyOffset_C;

		// Token: 0x04001FA1 RID: 8097
		internal static int __PropertyOffset_D;
	}
}
